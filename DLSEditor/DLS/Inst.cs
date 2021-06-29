using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DLS {
    public class InstList : RiffChunk {
        public const string ID = "lins";

        private List<Inst> mList = new List<Inst>();

        public Inst this[int index] {
            get { return mList[index]; }
            set { mList[index] = value; }
        }

        public int Count { get { return mList.Count; } }

        public void Clear() { mList.Clear(); }

        public void Add(Inst inst) { mList.Add(inst); }

        public void AddRange(List<Inst> inst) { mList.AddRange(inst); }

        public InstList() { }

        public InstList(FileStream fs, uint size) : base(fs, size) { }

        protected override void loadList(FileStream fs, string type, uint size) {
            switch (type) {
            case Inst.ID:
                mList.Add(new Inst(fs, size));
                break;
            default:
                fs.Seek(size, SeekOrigin.Current);
                break;
            }
        }

        public void Write(FileStream fs) {
            var bw = new BinaryWriter(fs);

            bw.Write(Encoding.ASCII.GetBytes(LIST_ID));
            bw.Write((uint)0);
            bw.Write(Encoding.ASCII.GetBytes(ID));

            var len = (uint)4;
            foreach (var inst in mList) {
                len += inst.Write(fs);
            }

            fs.Seek(-len - 4, SeekOrigin.Current);
            bw.Write(len);
            fs.Seek(len, SeekOrigin.Current);
        }
    }

    public class Inst : RiffChunk {
        public const string ID = "ins ";

        public RiffInfo Info = new RiffInfo();
        public InstHeader Header = new InstHeader();
        public RegionList RegionList = new RegionList();
        public ArtList ArtList = new ArtList();

        public Inst(FileStream fs, uint size) : base(fs, size) { }

        protected override void loadInfo(FileStream fs, uint size) {
            Info = new RiffInfo(fs, size);
        }

        protected override void loadChunk(FileStream fs, string type, uint size) {
            switch (type) {
            case InstHeader.ID:
                Header = new InstHeader(fs, size);
                break;
            default:
                fs.Seek(size, SeekOrigin.Current);
                break;
            }
        }

        protected override void loadList(FileStream fs, string type, uint size) {
            switch (type) {
            case RegionList.ID:
                RegionList = new RegionList(fs, size);
                break;
            case ArtList.ID:
            case ArtList.ID2:
                ArtList = new ArtList(fs, size);
                break;
            default:
                fs.Seek(size, SeekOrigin.Current);
                break;
            }
        }

        public uint Write(FileStream fs) {
            var begin = fs.Position;
            var bw = new BinaryWriter(fs);

            bw.Write(Encoding.ASCII.GetBytes(LIST_ID));
            bw.Write((uint)0);
            bw.Write(Encoding.ASCII.GetBytes(ID));

            var len = (uint)4;
            len += Info.Write(fs);
            len += Header.Write(fs);
            len += RegionList.Write(fs);
            len += ArtList.Write(fs);

            fs.Seek(-len - 4, SeekOrigin.Current);
            bw.Write(len);
            fs.Seek(len, SeekOrigin.Current);

            return (uint)(fs.Position - begin);
        }
    }

    public class InstHeader {
        public const string ID = "insh";

        public uint Regions;
        public byte BankLsb;
        public byte BankMsb;
        private byte Reserved1;
        public byte IsDrum;
        public byte ProgNum;
        private byte Reserved2;
        private byte Reserved3;
        private byte Reserved4;

        public InstHeader() { }

        public InstHeader(FileStream fs, uint size) {
            var br = new BinaryReader(fs);
            Regions = br.ReadUInt32();

            BankLsb = br.ReadByte();
            BankMsb = br.ReadByte();
            Reserved1 = br.ReadByte();
            IsDrum = br.ReadByte();

            ProgNum = br.ReadByte();
            Reserved2 = br.ReadByte();
            Reserved3 = br.ReadByte();
            Reserved4 = br.ReadByte();
            fs.Seek(size - 12, SeekOrigin.Current);
        }

        public uint Write(FileStream fs) {
            var begin = fs.Position;
            var bw = new BinaryWriter(fs);

            bw.Write(Encoding.ASCII.GetBytes(ID));
            bw.Write((uint)12);
            bw.Write(Regions);

            bw.Write(BankLsb);
            bw.Write(BankMsb);
            bw.Write(Reserved1);
            bw.Write(IsDrum);

            bw.Write(ProgNum);
            bw.Write(Reserved2);
            bw.Write(Reserved3);
            bw.Write(Reserved4);

            return (uint)(fs.Position - begin);
        }
    }
}