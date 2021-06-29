using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DLS {
    public class WaveList : RiffChunk {
        public const string ID = "wvpl";

        private List<Wave> mList = new List<Wave>();

        public Wave this[int index] {
            get { return mList[index]; }
            set { mList[index] = value; }
        }

        public int Count { get { return mList.Count; } }

        public void Clear() { mList.Clear(); }

        public void Add(Wave wave) { mList.Add(wave); }

        public void AddRange(List<Wave> waves) { mList.AddRange(waves); }

        public WaveList() { }

        public WaveList(FileStream fs, uint size) : base(fs, size) { }

        protected override void loadList(FileStream fs, string type, uint size) {
            switch (type) {
            case Wave.ID:
                mList.Add(new Wave(fs, size));
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
            foreach (var wave in mList) {
                len += wave.Write(fs);
            }

            fs.Seek(-len - 4, SeekOrigin.Current);
            bw.Write(len);
            fs.Seek(len, SeekOrigin.Current);
        }
    }

    public class Wave : RiffChunk {
        public const string ID = "wave";

        public RiffInfo Info = new RiffInfo();
        public WaveSample WaveSample = new WaveSample();
        public Format Format = new Format();
        public byte[] Data;

        public Wave(FileStream fs, uint size) : base(fs, size) { }

        protected override void loadInfo(FileStream fs, uint size) {
            Info = new RiffInfo(fs, size);
        }

        protected override void loadChunk(FileStream fs, string type, uint size) {
            switch (type) {
            case WaveSample.ID:
                WaveSample = new WaveSample(fs, size);
                break;
            case Format.ID:
                Format = new Format(fs, size);
                break;
            case DATA_ID:
                Data = new byte[size];
                fs.Read(Data, 0, (int)size);
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
            len += WaveSample.Write(fs);
            len += Format.Write(fs);
            len += (uint)Data.Length + 8;
            bw.Write(Encoding.ASCII.GetBytes(DATA_ID));
            bw.Write((uint)Data.Length);
            bw.Write(Data);

            fs.Seek(-len - 4, SeekOrigin.Current);
            bw.Write(len);
            fs.Seek(len, SeekOrigin.Current);

            return (uint)(fs.Position - begin);
        }
    }

    public class Format {
        public const string ID = "fmt ";

        public ushort Tag;
        public ushort Channels;
        public uint SampleRate;
        public uint BytesPerSec;
        public ushort BlockAlign;
        public ushort Bits;

        public Format() { }

        public Format(FileStream fs, uint size) {
            var br = new BinaryReader(fs);
            Tag = br.ReadUInt16();
            Channels = br.ReadUInt16();
            SampleRate = br.ReadUInt32();
            BytesPerSec = br.ReadUInt32();
            BlockAlign = br.ReadUInt16();
            Bits = br.ReadUInt16();
            fs.Seek(size - 16, SeekOrigin.Current);
        }

        public uint Write(FileStream fs) {
            var begin = fs.Position;
            var bw = new BinaryWriter(fs);
            bw.Write(Encoding.ASCII.GetBytes(ID));
            bw.Write((uint)16);
            bw.Write(Tag);
            bw.Write(Channels);
            bw.Write(SampleRate);
            bw.Write(BytesPerSec);
            bw.Write(BlockAlign);
            bw.Write(Bits);
            return (uint)(fs.Position - begin);
        }
    }

    public class WaveSample {
        public const string ID = "wsmp";

        public uint Size;
        public ushort UnityNote;
        public short FineTune;
        public int Gain;
        public uint Options;
        public uint LoopCount;
        public List<SampleLoop> Loops = new List<SampleLoop>();

        public WaveSample() { }

        public WaveSample(FileStream fs, uint size) {
            var br = new BinaryReader(fs);
            Size = br.ReadUInt32();
            UnityNote = br.ReadUInt16();
            FineTune = br.ReadInt16();
            Gain = br.ReadInt32();
            Options = br.ReadUInt32();
            LoopCount = br.ReadUInt32();
            for (uint i = 0; i < LoopCount; i++) {
                Loops.Add(new SampleLoop(br));
            }
            fs.Seek(size - 20 - LoopCount * 4 * 4, SeekOrigin.Current);
        }

        public uint Write(FileStream fs) {
            var begin = fs.Position;
            var bw = new BinaryWriter(fs);
            bw.Write(Encoding.ASCII.GetBytes(ID));
            bw.Write(20 + LoopCount * 16);
            bw.Write((uint)20);
            bw.Write(UnityNote);
            bw.Write(FineTune);
            bw.Write(Gain);
            bw.Write(Options);
            bw.Write(LoopCount);
            foreach(var loop in Loops) {
                loop.Write(bw);
            }
            return (uint)(fs.Position - begin);
        }
    }

    public class SampleLoop {
        public uint Size;
        public uint Type;
        public uint Start;
        public uint Length;

        public SampleLoop(BinaryReader br) {
            Size = br.ReadUInt32();
            Type = br.ReadUInt32();
            Start = br.ReadUInt32();
            Length = br.ReadUInt32();
        }

        public void Write(BinaryWriter bw) {
            bw.Write((uint)16);
            bw.Write(Type);
            bw.Write(Start);
            bw.Write(Length);
        }
    }
}