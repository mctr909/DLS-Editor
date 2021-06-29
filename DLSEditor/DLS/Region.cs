using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DLS {
    public class RegionList : RiffChunk {
        public const string ID = "lrgn";

        private List<Region> mList = new List<Region>();

        public Region this[int index] {
            get { return mList[index]; }
            set { mList[index] = value; }
        }

        public int Count { get { return mList.Count; } }

        public void Clear() { mList.Clear(); }

        public void Add(Region region) { mList.Add(region); }

        public void AddRange(List<Region> regions) { mList.AddRange(regions); }

        public RegionList() { }

        public RegionList(FileStream fs, uint size) : base(fs, size) { }

        protected override void loadList(FileStream fs, string type, uint size) {
            switch (type) {
            case Region.ID:
            case Region.ID2:
                mList.Add(new Region(fs, size));
                break;
            default:
                fs.Seek(size, SeekOrigin.Current);
                break;
            }
        }

        protected override uint write(FileStream fs) {
            var len = (uint)0;
            foreach (var rgn in mList) {
                len += rgn.Write(fs, Region.ID);
            }
            return len;
        }
    }

    public class Region : RiffChunk {
        public const string ID = "rgn ";
        public const string ID2 = "rgn2";

        public RiffInfo Info = new RiffInfo();
        public RegionHeader Header = new RegionHeader();
        public WaveLink WaveLink = new WaveLink();
        public WaveSample WaveSample = new WaveSample();
        public ArtList ArtList = new ArtList();

        public Region(FileStream fs, uint size) : base(fs, size) { }

        protected override void loadInfo(FileStream fs, uint size) {
            Info = new RiffInfo(fs, size);
        }

        protected override void loadChunk(FileStream fs, string type, uint size) {
            switch (type) {
            case RegionHeader.ID:
                Header = new RegionHeader(fs, size);
                break;
            case WaveLink.ID:
                WaveLink = new WaveLink(fs, size);
                break;
            case WaveSample.ID:
                WaveSample = new WaveSample(fs, size);
                break;
            default:
                fs.Seek(size, SeekOrigin.Current);
                break;
            }
        }

        protected override void loadList(FileStream fs, string type, uint size) {
            switch (type) {
            case ArtList.ID:
            case ArtList.ID2:
                ArtList = new ArtList(fs, size);
                break;
            default:
                fs.Seek(size, SeekOrigin.Current);
                break;
            }
        }

        protected override uint write(FileStream fs) {
            var len = Info.Write(fs);
            len += Header.Write(fs);
            len += WaveLink.Write(fs);
            len += WaveSample.Write(fs);
            len += ArtList.Write(fs, ArtList.ID);
            return len;
        }
    }

    public class RegionHeader {
        public const string ID = "rgnh";

        public short KeyLo = 0;
        public short KeyHi = 127;
        public short VelLo = 0;
        public short VelHi = 127;
        public ushort Option = 0;
        public short Group = 0;

        public RegionHeader() { }

        public RegionHeader(FileStream fs, uint size) {
            var br = new BinaryReader(fs);
            KeyLo = br.ReadInt16();
            KeyHi = br.ReadInt16();
            VelLo = br.ReadInt16();
            VelHi = br.ReadInt16();
            Option = br.ReadUInt16();
            Group = br.ReadInt16();
            fs.Seek(size - 12, SeekOrigin.Current);
        }

        public uint Write(FileStream fs) {
            var begin = fs.Position;
            var bw = new BinaryWriter(fs);
            bw.Write(Encoding.ASCII.GetBytes(ID));
            bw.Write((uint)12);
            bw.Write(KeyLo);
            bw.Write(KeyHi);
            bw.Write(VelLo);
            bw.Write(VelHi);
            bw.Write(Option);
            bw.Write(Group);
            return (uint)(fs.Position - begin);
        }
    }

    public class WaveLink {
        public const string ID = "wlnk";

        public ushort Options;
        public ushort PhaseGroup;
        public uint Channel;
        public uint Index;

        public WaveLink() { }

        public WaveLink(FileStream fs, uint size) {
            var br = new BinaryReader(fs);
            Options = br.ReadUInt16();
            PhaseGroup = br.ReadUInt16();
            Channel = br.ReadUInt32();
            Index = br.ReadUInt32();
            fs.Seek(size - 12, SeekOrigin.Current);
        }

        public uint Write(FileStream fs) {
            var begin = fs.Position;
            var bw = new BinaryWriter(fs);
            bw.Write(Encoding.ASCII.GetBytes(ID));
            bw.Write((uint)12);
            bw.Write(Options);
            bw.Write(PhaseGroup);
            bw.Write(Channel);
            bw.Write(Index);
            return (uint)(fs.Position - begin);
        }
    }
}