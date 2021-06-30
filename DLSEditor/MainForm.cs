﻿using System;
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

            lblWaveSearchName.Top = 0;
            lblWaveSearchName.Left = 0;
            txtWaveSearchName.Top = lblWaveSearchName.Bottom;
            txtWaveSearchName.Left = 0;
            lblWaveSearchGroup.Top = lblWaveSearchName.Top;
            lblWaveSearchGroup.Left = txtWaveSearchName.Right + 8;
            cmbWaveSearchGroup.Top = txtWaveSearchName.Top;
            cmbWaveSearchGroup.Left = lblWaveSearchGroup.Left;
            lstWave.Top = txtWaveSearchName.Bottom + 4;
            lstWave.Left = 0;

            lblPresetSearchName.Top = 0;
            lblPresetSearchName.Left = 0;
            txtPresetSearchName.Top = lblPresetSearchName.Bottom;
            txtPresetSearchName.Left = 0;
            lblPresetSearchGroup.Top = lblPresetSearchName.Top;
            lblPresetSearchGroup.Left = txtPresetSearchName.Right + 8;
            cmbPresetSearchGroup.Top = txtPresetSearchName.Top;
            cmbPresetSearchGroup.Left = lblPresetSearchGroup.Left;
            lstPreset.Top = txtPresetSearchName.Bottom + 4;
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

        private void tsmEditRename_OnClick(object sender, EventArgs e) {
            switch (tabControl1.SelectedTab.Name) {
            case "tabPageWave":
                renameWave();
                break;
            case "tabPagePreset":
                renamePreset();
                break;
            default:
                break;
            }
        }

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
        #endregion

        #region MenuStrip[Window]
        private void tsmWindowEdit_OnClick(object sender, EventArgs e) {
        }

        private void tsmWindowRefList_OnClick(object sender, EventArgs e) {
        }
        #endregion

        #region MenuStrip[Device]
        private void tsmDeviceWaveOut_OnClick(object sender, EventArgs e) {
        }

        private void tsmDeviceMidiIn_OnClick(object sender, EventArgs e) {
        }
        #endregion

        #region ContextMenu[Wave]
        private void tsmWaveAdd_OnClick(object sender, EventArgs e) {
        }

        private void tsmWaveDelete_OnClick(object sender, EventArgs e) {
            deleteWave();
        }

        private void tsmWaveRename_OnClick(object sender, EventArgs e) {
            renameWave();
        }

        private void tsmWaveCut_OnClick(object sender, EventArgs e) {
        }

        private void tsmWaveCopy_OnClick(object sender, EventArgs e) {
        }

        private void tsmWavePaste_OnClick(object sender, EventArgs e) {
        }

        private void tsmWaveFile_OnClick(object sender, EventArgs e) {
        }
        #endregion

        #region ContextMenu[Preset]
        private void tsmPresetAdd_OnClick(object sender, EventArgs e) {
        }

        private void tsmPresetDelete_OnClick(object sender, EventArgs e) {
            deletePreset();
        }

        private void tsmPresetRename_OnClick(object sender, EventArgs e) {
            renamePreset();
        }

        private void tsmPresetCut_OnClick(object sender, EventArgs e) {
        }

        private void tsmPresetCopy_OnClick(object sender, EventArgs e) {
        }

        private void tsmPresetPaste_OnClick(object sender, EventArgs e) {
        }
        #endregion

        private void setSize() {
            tabControl1.Width = Width - 24;
            tabControl1.Height = Height - menuStrip1.Height - tabPageWave.Top - 24;
            lstWave.Width = tabControl1.Width - 16;
            lstWave.Height = tabControl1.Height - lstWave.Top - 50;
            lstPreset.Width = tabControl1.Width - 16;
            lstPreset.Height = tabControl1.Height - lstPreset.Top - 50;
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
            mDls.DeleteWaves(getWaveIndex());
            lstWave.SelectedIndex = -1;
            dispWaveList();
        }

        private void deletePreset() {
            mDls.DeleteInst(getPresetHeader());
            lstPreset.SelectedIndex = -1;
            dispPresetList();
            dispWaveList();
        }

        private void renameWave() {
            var fm = new RenameForm(this);
            fm.CmbGroup.Items.Clear();
            fm.ShowDialog();
        }

        private void renamePreset() {
            var fm = new RenameForm(this);
            fm.CmbGroup.Items.Clear();
            fm.ShowDialog();
        }
    
        private List<int> getWaveIndex() {
            var list = new List<int>();
            foreach(int index in lstWave.SelectedIndices) {
                var cols = lstWave.Items[index].ToString().Split("|");
                var waveIndex = int.Parse(cols[0].Trim());
                list.Add(waveIndex);
            }
            return list;
        }

        private List<DLS.InstHeader> getPresetHeader() {
            var list = new List<DLS.InstHeader>();
            foreach (int index in lstPreset.SelectedIndices) {
                var header = new DLS.InstHeader();
                var cols = lstPreset.Items[index].ToString().Split("|");
                header.IsDrum = (byte)("Drum" == cols[0].Trim() ? 0x80 : 0x00);
                header.ProgNum = byte.Parse(cols[1].Trim());
                header.BankMsb = byte.Parse(cols[2].Trim());
                header.BankLsb = byte.Parse(cols[3].Trim());
                list.Add(header);
            }
            return list;
        }
    }
}
