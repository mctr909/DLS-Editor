using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DLS {
    public class File : RiffFile {
        public RiffInfo Info = new RiffInfo();
        public InstList InstList = new InstList();
        public WaveList WaveList = new WaveList();
        public List<uint> Cues = new List<uint>();

        public File() { }

        public File(string filePath) : base(filePath) { }

        protected override void loadInfo(FileStream fs, uint size) {
            Info = new RiffInfo(fs, size);
        }

        protected override void loadChunk(FileStream fs, string type, uint size) {
            switch (type) {
            case "ptbl":
                Cues = new List<uint>();
                fs.Seek(4, SeekOrigin.Current);
                var br = new BinaryReader(fs);
                var cueCount = br.ReadUInt32();
                for (int i = 0; i < cueCount; i++) {
                    Cues.Add(br.ReadUInt32());
                }
                fs.Seek(size - 8 - cueCount * 4, SeekOrigin.Current);
                break;
            default:
                fs.Seek(size, SeekOrigin.Current);
                break;
            }
        }

        protected override void loadList(FileStream fs, string type, uint size) {
            switch (type) {
            case InstList.ID:
                InstList = new InstList(fs, size);
                break;
            case WaveList.ID:
                WaveList = new WaveList(fs, size);
                break;
            default:
                fs.Seek(size, SeekOrigin.Current);
                break;
            }
        }

        public void Save(string filePath) {
            var fs = new FileStream(filePath, FileMode.Create);
            var bw = new BinaryWriter(fs);

            bw.Write(ID);
            bw.Write((uint)0);
            bw.Write(Encoding.ASCII.GetBytes("DLS "));

            Info.Write(fs);
            InstList.Write(fs, InstList.ID);
            WaveList.Write(fs, WaveList.ID);

            fs.Seek(4, SeekOrigin.Begin);
            bw.Write((uint)(fs.Length - 8));

            fs.Close();
            fs.Dispose();
        }

        public bool CheckUseWave(int index) {
            for (int i = 0; i < InstList.Count; i++) {
                var inst = InstList[i];
                for (int j = 0; j < inst.RegionList.Count; j++) {
                    var rgn = inst.RegionList[j];
                    if (index == rgn.WaveLink.Index) {
                        return true;
                    }
                }
            }
            return false;
        }

        public void DeleteWaves(List<int> indexes) {
            var deleteList = new List<int>();
            foreach (var index in indexes) {
                if (!CheckUseWave(index)) {
                    deleteList.Add(index);
                }
            }

            var newWaveList = new List<Wave>();
            var changeList = new List<int>();
            var changedIndex = 0;
            for (int index = 0; index < WaveList.Count; index++) {
                changeList.Add(changedIndex);
                if (!deleteList.Contains(index)) {
                    newWaveList.Add(WaveList[index]);
                    changedIndex++;
                }
            }
            WaveList.Clear();
            WaveList.AddRange(newWaveList);

            for (int i = 0; i < InstList.Count; i++) {
                var inst = InstList[i];
                for (int j = 0; j < inst.RegionList.Count; j++) {
                    var rgn = inst.RegionList[j];
                    rgn.WaveLink.Index = (uint)changeList[(int)rgn.WaveLink.Index];
                }
            }
        }

        public void DeleteInst(List<InstHeader> headers) {
            var newInstList = new List<Inst>();
            for (int i = 0; i < InstList.Count; i++) {
                var inst = InstList[i].Header;
                var tagetInst = false;
                foreach (var header in headers) {
                    if (header.IsDrum == inst.IsDrum &&
                        header.ProgNum == inst.ProgNum &&
                        header.BankMsb == inst.BankMsb &&
                        header.BankLsb == inst.BankLsb) {
                        tagetInst = true;
                        break;
                    }
                }
                if (!tagetInst) {
                    newInstList.Add(InstList[i]);
                }
            }
            InstList.Clear();
            InstList.AddRange(newInstList);
        }
    }
}