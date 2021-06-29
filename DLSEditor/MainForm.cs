using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DLSEditor {
    public partial class MainForm : Form {
        private string mFilePath = "";
        private DLS.File mDls = new DLS.File();
        private readonly string[] NoteName = new string[] {
            "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
        };

        public MainForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            tabControl1.Top = menuStrip1.Bottom;
            tabControl1.Left = 0;
            lstWave.Top = 0;
            lstWave.Left = 0;
            lstPreset.Top = 0;
            lstPreset.Left = 0;
            setSize();
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            setSize();
        }

        #region MenuStrip[File]
        private void tsmFileNew_OnClick(object sender, EventArgs e) {
            mFilePath = "";
            mDls = new DLS.File();
            Text = "DLS Editor";
            dispWaveList();
            dispPresetList();
        }

        private void tsmFileOpen_OnClick(object sender, EventArgs e) {
            openFileDialog1.Filter = "DLSファイル(*.dls)|*.dls";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            var fileName = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName)) {
                return;
            }
            mFilePath = fileName;
            mDls = new DLS.File(mFilePath);
            Text = string.Format("DLS Editor [{0}]", Path.GetFileName(mFilePath));
            dispWaveList();
            dispPresetList();
        }

        private void tsmFileSave_OnClick(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(mFilePath) || !File.Exists(mFilePath)) {
                saveFileDialog1.Filter = "DLSファイル(*.dls)|*.dls";
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
                mFilePath = saveFileDialog1.FileName;
                if (string.IsNullOrEmpty(mFilePath) || !Directory.Exists(Path.GetDirectoryName(mFilePath))) {
                    mFilePath = "";
                    Text = "DLS Editor";
                    return;
                }
            }
            mDls.Save(mFilePath);
            Text = string.Format("DLS Editor [{0}]", Path.GetFileName(mFilePath));
        }

        private void tsmFileSaveAs_OnClick(object sender, EventArgs e) {
            saveFileDialog1.Filter = "DLSファイル(*.dls)|*.dls";
            saveFileDialog1.FileName = mFilePath;
            saveFileDialog1.ShowDialog();
            mFilePath = saveFileDialog1.FileName;
            if (string.IsNullOrEmpty(mFilePath) || !Directory.Exists(Path.GetDirectoryName(mFilePath))) {
                mFilePath = "";
                Text = "DLS Editor";
                return;
            }
            mDls.Save(mFilePath);
            Text = string.Format("DLS Editor [{0}]", Path.GetFileName(mFilePath));
        }
        #endregion

        #region MenuStrip[Edit]
        private void tsmEditCut_OnClick(object sender, EventArgs e) {
            switch (tabControl1.SelectedTab.Name) {
            case "tabPageWave":
                break;
            case "tabPagePreset":
                break;
            default:
                break;
            }
        }

        private void tsmEditCopy_OnClick(object sender, EventArgs e) {
            switch (tabControl1.SelectedTab.Name) {
            case "tabPageWave":
                break;
            case "tabPagePreset":
                break;
            default:
                break;
            }
        }

        private void tsmEditPaste_OnClick(object sender, EventArgs e) {
            switch (tabControl1.SelectedTab.Name) {
            case "tabPageWave":
                break;
            case "tabPagePreset":
                break;
            default:
                break;
            }
        }

        private void tsmEditAdd_OnClick(object sender, EventArgs e) {
            switch (tabControl1.SelectedTab.Name) {
            case "tabPageWave":
                break;
            case "tabPagePreset":
                break;
            default:
                break;
            }
        }

        private void tsmEditDelete_OnClick(object sender, EventArgs e) {
            switch (tabControl1.SelectedTab.Name) {
            case "tabPageWave":
                deleteWave();
                break;
            case "tabPagePreset":
                deletePreset();
                break;
            default:
                break;
            }
        }
        #endregion

        #region MenuStrip[Display]
        private void tsmDisplayEdit_OnClick(object sender, EventArgs e) {
        }

        private void tsmDisplayRefList_OnClick(object sender, EventArgs e) {
        }
        #endregion

        #region MenuStrip[Device]
        private void tsmDeviceWaveOut_OnClick(object sender, EventArgs e) {
        }

        private void tsmDeviceMidiIn_OnClick(object sender, EventArgs e) {
        }
        #endregion

        private void setSize() {
            tabControl1.Width = Width - 24;
            tabControl1.Height = Height - menuStrip1.Height - tabPageWave.Top - 24;
            lstWave.Width = tabControl1.Width - 16;
            lstWave.Height = tabControl1.Height - 50;
            lstPreset.Width = tabControl1.Width - 16;
            lstPreset.Height = tabControl1.Height - 50;
        }

        private void dispWaveList() {
            lstWave.Items.Clear();
            for (int i = 0; i < mDls.WaveList.Count; i++) {
                var wave = mDls.WaveList[i];
                var smpl = wave.WaveSample;
                var group = wave.Info.ContainsKey("ICAT") ? wave.Info["ICAT"] : "";
                var name = wave.Info.ContainsKey("INAM") ? wave.Info["INAM"] : "";
                lstWave.Items.Add(string.Format(
                    "{0} | {1} | {2} | {3} | {4} | {5}",
                    i.ToString("00000"),
                    mDls.CheckUseWave(i) ? "use" : "   ",
                    0 < smpl.LoopCount ? "loop" : "    ",
                    (NoteName[smpl.UnityNote % 12] + (smpl.UnityNote / 12 - 1)).PadRight(4),
                    group.PadRight(20),
                    name
                ));
            }
        }

        private void dispPresetList() {
            lstPreset.Items.Clear();
            for (int i = 0; i < mDls.InstList.Count; i++) {
                var inst = mDls.InstList[i];
                var group = inst.Info.ContainsKey("ICAT") ? inst.Info["ICAT"] : "";
                var name = inst.Info.ContainsKey("INAM") ? inst.Info["INAM"] : "";
                lstPreset.Items.Add(string.Format(
                    "{0} | {1} | {2} | {3} | {4} | {5}",
                    inst.Header.IsDrum == 0x80 ? "Drum" : "Note",
                    inst.Header.ProgNum.ToString("000"),
                    inst.Header.BankMsb.ToString("000"),
                    inst.Header.BankLsb.ToString("000"),
                    group.PadRight(20),
                    name
                ));
            }
        }

        private void deleteWave() {
            var list = new List<int>();
            foreach(int index in lstWave.SelectedIndices) {
                list.Add(index);
            }
            lstWave.SelectedIndex = -1;
            mDls.DeleteWaves(list);
            dispWaveList();
        }

        private void deletePreset() {
            var list = new List<int>();
            foreach (int index in lstPreset.SelectedIndices) {
                list.Add(index);
            }
            lstPreset.SelectedIndex = -1;
            mDls.DeleteInst(list);
            dispPresetList();
            dispWaveList();
        }
    }
}
