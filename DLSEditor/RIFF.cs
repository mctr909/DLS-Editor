using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public abstract class RiffFile {
    protected const uint ID = 0x46464952;

    protected uint mFileType;

    public RiffFile() { }

    public RiffFile(string filePath) {
        var fs = new FileStream(filePath, FileMode.Open);
        var br = new BinaryReader(fs);
        if (fs.Length < 12 || ID != br.ReadUInt32()) {
            return;
        }
        var fileSize = br.ReadUInt32();
        mFileType = br.ReadUInt32();
        while ((fs.Position - 8) < fileSize) {
            var type = Encoding.ASCII.GetString(BitConverter.GetBytes(br.ReadUInt32()));
            var size = br.ReadUInt32();
            if ("LIST" == type) {
                var listType = Encoding.ASCII.GetString(BitConverter.GetBytes(br.ReadUInt32()));
                if ("INFO" == listType) {
                    loadInfo(fs, size - 4);
                } else {
                    loadList(fs, listType, size - 4);
                }
            } else {
                loadChunk(fs, type, size);
            }
        }
        fs.Close();
        fs.Dispose();
    }

    protected virtual void loadChunk(FileStream fs, string type, uint size) {
        fs.Seek(size, SeekOrigin.Current);
    }

    protected virtual void loadList(FileStream fs, string type, uint size) {
        fs.Seek(size, SeekOrigin.Current);
    }

    protected virtual void loadInfo(FileStream fs, uint size) {
        fs.Seek(size, SeekOrigin.Current);
    }
}

public class RiffChunk {
    protected const string LIST_ID = "LIST";
    protected const string DATA_ID = "data";

    public RiffChunk() { }

    public RiffChunk(FileStream fs, uint size) {
        var br = new BinaryReader(fs);
        uint pos = 0;
        while (pos < size) {
            var child_type = Encoding.ASCII.GetString(BitConverter.GetBytes(br.ReadUInt32()));
            var child_size = br.ReadUInt32();
            if (LIST_ID == child_type) {
                var list_type = Encoding.ASCII.GetString(BitConverter.GetBytes(br.ReadUInt32()));
                if ("INFO" == list_type) {
                    loadInfo(fs, child_size - 4);
                } else {
                    loadList(fs, list_type, child_size - 4);
                }
            } else {
                loadChunk(fs, child_type, child_size);
            }
            pos += child_size + 8;
        }
    }

    public uint Write(FileStream fs, string id) {
        var begin = fs.Position;
        var bw = new BinaryWriter(fs);

        bw.Write(Encoding.ASCII.GetBytes(LIST_ID));
        bw.Write((uint)0);
        bw.Write(Encoding.ASCII.GetBytes(id.PadRight(4).Substring(0, 4)));

        var len = write(fs) + 4;

        if (4 == len) {
            fs.Seek(-12, SeekOrigin.Current);
        } else {
            fs.Seek(-len - 4, SeekOrigin.Current);
            bw.Write(len);
            fs.Seek(len, SeekOrigin.Current);
        }

        return (uint)(fs.Position - begin);
    }

    protected virtual void loadChunk(FileStream fs, string type, uint size) {
        fs.Seek(size, SeekOrigin.Current);
    }

    protected virtual void loadList(FileStream fs, string type, uint size) {
        fs.Seek(size, SeekOrigin.Current);
    }

    protected virtual void loadInfo(FileStream fs, uint size) {
        fs.Seek(size, SeekOrigin.Current);
    }

    protected virtual uint write(FileStream fs) { return 0; }
}

public sealed class RiffInfo {
    private Dictionary<string, string> mList = new Dictionary<string, string>();

    public string this[string key] {
        get { return mList[key]; }
        set { mList[key] = value; }
    }

    public int Count { get { return mList.Count; } }

    public void Clear() { mList.Clear(); }

    public void Add(string key, string value) { mList.Add(key, value); }

    public bool ContainsKey(string key) {
        return mList.ContainsKey(key);
    }

    public RiffInfo() { }

    public RiffInfo(FileStream fs, uint size) {
        var br = new BinaryReader(fs);
        uint pos = 0;
        while (pos < size) {
            var child_type = Encoding.ASCII.GetString(BitConverter.GetBytes(br.ReadUInt32()));
            var child_size = br.ReadUInt32();
            child_size += child_size % 2;
            load(fs, child_type, child_size);
            pos += child_size + 8;
        }
    }

    private void load(FileStream fs, string type, uint size) {
        var strArray = new byte[size];
        fs.Read(strArray, 0, (int)size);
        fs.Seek(size % 2, SeekOrigin.Current);
        mList.Add(type, Encoding.UTF8.GetString(strArray));
    }

    public uint Write(FileStream fs) {
        if (0 == mList.Count) {
            return 0;
        }

        var list = new List<Tuple<byte[], byte[], byte[]>>();
        var size = 0;
        foreach (var info in mList) {
            var keyArray = Encoding.ASCII.GetBytes(info.Key.PadRight(4, ' ').Substring(0, 4));
            var valLen = Encoding.UTF8.GetByteCount(info.Value);
            var valArray = Encoding.ASCII.GetBytes(valLen % 2 == 0 ? info.Value : (info.Value + ' '));
            list.Add(new Tuple<byte[], byte[], byte[]>(
                keyArray,
                BitConverter.GetBytes((uint)valLen),
                valArray
            ));
            size += 8 + valArray.Length;
        }
        var begin = fs.Position;
        var bw = new BinaryWriter(fs);
        bw.Write(Encoding.ASCII.GetBytes("LIST"), 0, 4);
        bw.Write(BitConverter.GetBytes((uint)(size + 4)), 0, 4);
        bw.Write(Encoding.ASCII.GetBytes("INFO"), 0, 4);
        foreach (var info in list) {
            bw.Write(info.Item1, 0, info.Item1.Length);
            bw.Write(info.Item2, 0, info.Item2.Length);
            bw.Write(info.Item3, 0, info.Item3.Length);
        }
        return (uint)(fs.Position - begin);
    }
}