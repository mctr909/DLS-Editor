using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DLS {
    public class ArtList : RiffChunk {
        public const string ID = "lart";
        public const string ID2 = "lar2";

        private List<Art> mList = new List<Art>();

        public Art this[int index] {
            get { return mList[index]; }
            set { mList[index] = value; }
        }

        public void Clear() { mList.Clear(); }

        public void Add(Art art) { mList.Add(art); }

        public void AddRange(List<Art> art) { mList.AddRange(art); }

        public ArtList() { }

        public ArtList(FileStream fs, uint size) : base(fs, size) { }

        protected override void loadChunk(FileStream fs, string type, uint size) {
            switch (type) {
            case Art.ID:
            case Art.ID2:
                mList.Add(new Art(fs, size));
                break;
            default:
                fs.Seek(size, SeekOrigin.Current);
                break;
            }
        }

        public uint Write(FileStream fs) {
            if (0 == mList.Count) {
                return 0;
            }

            var begin = fs.Position;
            var bw = new BinaryWriter(fs);

            bw.Write(Encoding.ASCII.GetBytes(LIST_ID));
            bw.Write((uint)0);
            bw.Write(Encoding.ASCII.GetBytes(ID));

            var len = (uint)4;
            foreach (var art in mList) {
                len += art.Write(fs);
            }

            fs.Seek(-len - 4, SeekOrigin.Current);
            bw.Write(len);
            fs.Seek(len, SeekOrigin.Current);

            return (uint)(fs.Position - begin);
        }
    }

    public class Art {
        public const string ID = "art1";
        public const string ID2 = "art2";

        private uint mSize = 8;
        private uint mBlocks;
        private List<Connection> mList = new List<Connection>();

        public Connection this[int index] {
            get { return mList[index]; }
            set { mList[index] = value; }
        }

        public void Clear() { mList.Clear(); }

        public void Add(Connection conn) { mList.Add(conn); }

        public void AddRange(List<Connection> conn) { mList.AddRange(conn); }

        public Art(FileStream fs, uint size) {
            var br = new BinaryReader(fs);
            mSize = br.ReadUInt32();
            mBlocks = br.ReadUInt32();
            for (int i = 0; i < mBlocks; i++) {
                mList.Add(new Connection(br));
            }
            fs.Seek(size - 8 - mBlocks * 12, SeekOrigin.Current);
        }

        public uint Write(FileStream fs) {
            var begin = fs.Position;
            var bw = new BinaryWriter(fs);

            bw.Write(Encoding.ASCII.GetBytes(ID));
            bw.Write((uint)0);

            var len = (uint)8;
            bw.Write(mSize);
            bw.Write((uint)mList.Count);
            foreach (var conn in mList) {
                len += conn.Write(fs);
            }

            fs.Seek(-len - 4, SeekOrigin.Current);
            bw.Write(len);
            fs.Seek(len, SeekOrigin.Current);

            return (uint)(fs.Position - begin);
        }
    }

    public class Connection {
        public enum SRC_TYPE : ushort {
            // MODULATOR SOURCES
            NONE = 0x0000,
            LFO = 0x0001,
            KEY_ON_VELOCITY = 0x0002,
            KEY_NUMBER = 0x0003,
            EG1 = 0x0004,
            EG2 = 0x0005,
            PITCH_WHEEL = 0x0006,
            POLY_PRESSURE = 0x0007,
            CHANNEL_PRESSURE = 0x0008,
            VIBRATO = 0x0009,

            // MIDI CONTROLLER SOURCES
            CC1 = 0x0081,
            CC7 = 0x0087,
            CC10 = 0x008A,
            CC11 = 0x008B,
            CC91 = 0x00DB,
            CC93 = 0x00DD,

            // REGISTERED PARAMETER NUMBERS
            RPN0 = 0x0100,
            RPN1 = 0x0101,
            RPN2 = 0x0102
        }

        public enum DST_TYPE : ushort {
            // GENERIC DESTINATIONS
            NONE = 0x0000,
            GAIN = 0x0001,
            RESERVED = 0x0002,
            PITCH = 0x0003,
            PAN = 0x0004,
            KEY_NUMBER = 0x0005,

            // CHANNEL OUTPUT DESTINATIONS
            LEFT = 0x0010,
            RIGHT = 0x0011,
            CENTER = 0x0012,
            LFET_CHANNEL = 0x0013,
            LEFT_REAR = 0x0014,
            RIGHT_REAR = 0x0015,
            CHORUS = 0x0080,
            REVERB = 0x0081,

            // MODULATOR LFO DESTINATIONS
            LFO_FREQUENCY = 0x0104,
            LFO_START_DELAY = 0x0105,

            // VIBRATO LFO DESTINATIONS
            VIB_FREQUENCY = 0x0114,
            VIB_START_DELAY = 0x0115,

            // EG DESTINATIONS
            EG1_ATTACK_TIME = 0x0206,
            EG1_DECAY_TIME = 0x0207,
            EG1_RESERVED = 0x0208,
            EG1_RELEASE_TIME = 0x0209,
            EG1_SUSTAIN_LEVEL = 0x020A,
            EG1_DELAY_TIME = 0x020B,
            EG1_HOLD_TIME = 0x020C,
            EG1_SHUTDOWN_TIME = 0x020D,
            EG2_ATTACK_TIME = 0x030A,
            EG2_DECAY_TIME = 0x030B,
            EG2_RESERVED = 0x030C,
            EG2_RELEASE_TIME = 0x030D,
            EG2_SUSTAIN_LEVEL = 0x030E,
            EG2_DELAY_TIME = 0x030F,
            EG2_HOLD_TIME = 0x0310,

            // FILTER DESTINATIONS
            FILTER_CUTOFF = 0x0500,
            FILTER_Q = 0x0501
        }

        public enum TRN_TYPE : ushort {
            NONE = 0x0,
            CONCAVE = 0x1,
            CONVEX = 0x2,
            SWITCH = 0x3
        }

        public enum TRN_CTRL : ushort {
            NONE = 0x000,
            BIPOLAR = 0x100,
            INVERT = 0x200,
            MASK = 0x300,
        }

        public enum TRN_SRC : ushort {
            NONE = 0x0000,
            BIPOLAR = 0x4000,
            INVERT = 0x8000,
            MASK = 0xC000
        }

        public SRC_TYPE Source;
        public SRC_TYPE Control;
        public DST_TYPE Destination;
        private ushort mTransform;
        private int mScale;

        public TRN_TYPE OutTransform {
            get { return (TRN_TYPE)(mTransform & 0x3); }
            set {
                mTransform &= 0xFFFF ^ 0x3;
                mTransform |= (ushort)((uint)value & 0x3);
            }
        }

        public TRN_TYPE CtrlTransform {
            get { return (TRN_TYPE)((mTransform >> 4) & 0x3); }
            set {
                mTransform &= 0xFFFF ^ (0x3 << 4);
                mTransform |= (ushort)(((uint)value & 0x3) << 4);
            }
        }

        public TRN_TYPE SrcTransform {
            get { return (TRN_TYPE)((mTransform >> 10) & 0x3); }
            set {
                mTransform &= 0xF3FF;
                mTransform |= (ushort)(((uint)value & 0x3) << 10);
            }
        }

        public TRN_CTRL CtrlType {
            get { return (TRN_CTRL)(mTransform & (ushort)TRN_CTRL.MASK); }
            set {
                mTransform &= 0xFFFF ^ (ushort)TRN_CTRL.MASK;
                mTransform |= (ushort)((uint)value & (ushort)TRN_CTRL.MASK);
            }
        }

        public TRN_SRC SrcType {
            get { return (TRN_SRC)(mTransform & (ushort)TRN_SRC.MASK); }
            set {
                mTransform &= 0xFFFF ^ (ushort)TRN_SRC.MASK;
                mTransform |= (ushort)((uint)value & (ushort)TRN_SRC.MASK);
            }
        }

        public double Value {
            get {
                switch (Destination) {
                case DST_TYPE.GAIN:
                case DST_TYPE.FILTER_Q:
                    return Math.Pow(10.0, mScale / (200 * 65536.0));
                case DST_TYPE.PAN:
                    return (mScale / 655360.0) - 0.5;
                case DST_TYPE.LFO_START_DELAY:
                case DST_TYPE.VIB_START_DELAY:
                case DST_TYPE.EG1_ATTACK_TIME:
                case DST_TYPE.EG1_DECAY_TIME:
                case DST_TYPE.EG1_RELEASE_TIME:
                case DST_TYPE.EG1_DELAY_TIME:
                case DST_TYPE.EG1_HOLD_TIME:
                case DST_TYPE.EG1_SHUTDOWN_TIME:
                case DST_TYPE.EG2_ATTACK_TIME:
                case DST_TYPE.EG2_DECAY_TIME:
                case DST_TYPE.EG2_RELEASE_TIME:
                case DST_TYPE.EG2_DELAY_TIME:
                case DST_TYPE.EG2_HOLD_TIME:
                    return Math.Pow(2.0, mScale / (1200 * 65536.0));
                case DST_TYPE.EG1_SUSTAIN_LEVEL:
                case DST_TYPE.EG2_SUSTAIN_LEVEL:
                    return mScale / 655360.0;
                case DST_TYPE.PITCH:
                case DST_TYPE.LFO_FREQUENCY:
                case DST_TYPE.VIB_FREQUENCY:
                case DST_TYPE.FILTER_CUTOFF:
                    return Math.Pow(2.0, (mScale / 65536.0 - 6900) / 1200.0) * 440;
                default:
                    return 0.0;
                }
            }
            set {
                switch (Destination) {
                case DST_TYPE.GAIN:
                case DST_TYPE.FILTER_Q:
                    mScale = (int)(Math.Log10(value) * 200 * 65536);
                    break;
                case DST_TYPE.PAN:
                    mScale = (int)((value + 0.5) * 655360);
                    break;
                case DST_TYPE.LFO_START_DELAY:
                case DST_TYPE.VIB_START_DELAY:
                case DST_TYPE.EG1_ATTACK_TIME:
                case DST_TYPE.EG1_DECAY_TIME:
                case DST_TYPE.EG1_RELEASE_TIME:
                case DST_TYPE.EG1_DELAY_TIME:
                case DST_TYPE.EG1_HOLD_TIME:
                case DST_TYPE.EG1_SHUTDOWN_TIME:
                case DST_TYPE.EG2_ATTACK_TIME:
                case DST_TYPE.EG2_DECAY_TIME:
                case DST_TYPE.EG2_RELEASE_TIME:
                case DST_TYPE.EG2_DELAY_TIME:
                case DST_TYPE.EG2_HOLD_TIME:
                    mScale = (int)(Math.Log(value, 2.0) * 1200 * 65536);
                    break;
                case DST_TYPE.EG1_SUSTAIN_LEVEL:
                case DST_TYPE.EG2_SUSTAIN_LEVEL:
                    mScale = (int)(value * 655360);
                    break;
                case DST_TYPE.PITCH:
                case DST_TYPE.LFO_FREQUENCY:
                case DST_TYPE.VIB_FREQUENCY:
                case DST_TYPE.FILTER_CUTOFF:
                    mScale = (int)(((Math.Log(value / 440, 2.0) * 1200) + 6900) * 65536);
                    break;
                default:
                    mScale = 0;
                    break;
                }
            }
        }

        public Connection(BinaryReader br) {
            Source = (SRC_TYPE)br.ReadUInt16();
            Control = (SRC_TYPE)br.ReadUInt16();
            Destination = (DST_TYPE)br.ReadUInt16();
            mTransform = br.ReadUInt16();
            mScale = br.ReadInt32();
        }

        public uint Write(FileStream fs) {
            var begin = fs.Position;
            var bw = new BinaryWriter(fs);
            bw.Write((ushort)Source);
            bw.Write((ushort)Control);
            bw.Write((ushort)Destination);
            bw.Write(mTransform);
            bw.Write(mScale);
            return (uint)(fs.Position - begin);
        }
    }
}