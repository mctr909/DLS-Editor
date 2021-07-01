
namespace DLSEditor {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFile = new System.Windows.Forms.ToolStripSeparator();
            this.tsmFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tssEdit = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditRegroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tssEdit2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWindowEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWindowRefList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeviceWaveOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeviceMidiIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWave = new System.Windows.Forms.TabPage();
            this.lblWaveSearchGroup = new System.Windows.Forms.Label();
            this.cmbWaveSearchGroup = new System.Windows.Forms.ComboBox();
            this.lblWaveSearchName = new System.Windows.Forms.Label();
            this.txtWaveSearchName = new System.Windows.Forms.TextBox();
            this.lstWave = new System.Windows.Forms.ListBox();
            this.cmsWave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmWaveAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWaveDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tssWave = new System.Windows.Forms.ToolStripSeparator();
            this.tsmWaveRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWaveRegroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tssWave2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmWaveCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWaveCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWavePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tssWave3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmWaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPagePreset = new System.Windows.Forms.TabPage();
            this.lblPresetSearchGroup = new System.Windows.Forms.Label();
            this.cmbPresetSearchGroup = new System.Windows.Forms.ComboBox();
            this.lblPresetSearchName = new System.Windows.Forms.Label();
            this.txtPresetSearchName = new System.Windows.Forms.TextBox();
            this.lstPreset = new System.Windows.Forms.ListBox();
            this.cmsPreset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmPresetAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPresetDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tssPreset = new System.Windows.Forms.ToolStripSeparator();
            this.tsmPresetRename = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPresetRegroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tssPreset2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmPresetCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPresetCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPresetPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageWave.SuspendLayout();
            this.cmsWave.SuspendLayout();
            this.tabPagePreset.SuspendLayout();
            this.cmsPreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmEdit,
            this.tsmWindow,
            this.tsmDevice});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFileNew,
            this.tsmFileOpen,
            this.tssFile,
            this.tsmFileSave,
            this.tsmFileSaveAs});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(128, 36);
            this.tsmFile.Text = "ファイル(&F)";
            // 
            // tsmFileNew
            // 
            this.tsmFileNew.Image = ((System.Drawing.Image)(resources.GetObject("tsmFileNew.Image")));
            this.tsmFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmFileNew.Name = "tsmFileNew";
            this.tsmFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmFileNew.Size = new System.Drawing.Size(368, 44);
            this.tsmFileNew.Text = "新規作成(&N)";
            this.tsmFileNew.Click += new System.EventHandler(this.tsmFileNew_OnClick);
            // 
            // tsmFileOpen
            // 
            this.tsmFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsmFileOpen.Image")));
            this.tsmFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmFileOpen.Name = "tsmFileOpen";
            this.tsmFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmFileOpen.Size = new System.Drawing.Size(368, 44);
            this.tsmFileOpen.Text = "開く(&O)";
            this.tsmFileOpen.Click += new System.EventHandler(this.tsmFileOpen_OnClick);
            // 
            // tssFile
            // 
            this.tssFile.Name = "tssFile";
            this.tssFile.Size = new System.Drawing.Size(365, 6);
            // 
            // tsmFileSave
            // 
            this.tsmFileSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmFileSave.Image")));
            this.tsmFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmFileSave.Name = "tsmFileSave";
            this.tsmFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmFileSave.Size = new System.Drawing.Size(368, 44);
            this.tsmFileSave.Text = "上書き保存(&S)";
            this.tsmFileSave.Click += new System.EventHandler(this.tsmFileSave_OnClick);
            // 
            // tsmFileSaveAs
            // 
            this.tsmFileSaveAs.Name = "tsmFileSaveAs";
            this.tsmFileSaveAs.Size = new System.Drawing.Size(368, 44);
            this.tsmFileSaveAs.Text = "名前を付けて保存(&A)";
            this.tsmFileSaveAs.Click += new System.EventHandler(this.tsmFileSaveAs_OnClick);
            // 
            // tsmEdit
            // 
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditAdd,
            this.tsmEditDelete,
            this.tssEdit,
            this.tsmEditRename,
            this.tsmEditRegroup,
            this.tssEdit2,
            this.tsmEditCut,
            this.tsmEditCopy,
            this.tsmEditPaste});
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(108, 36);
            this.tsmEdit.Text = "編集(&E)";
            // 
            // tsmEditAdd
            // 
            this.tsmEditAdd.Name = "tsmEditAdd";
            this.tsmEditAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmEditAdd.Size = new System.Drawing.Size(425, 44);
            this.tsmEditAdd.Text = "追加(&A)";
            this.tsmEditAdd.Click += new System.EventHandler(this.tsmEditAdd_OnClick);
            // 
            // tsmEditDelete
            // 
            this.tsmEditDelete.Name = "tsmEditDelete";
            this.tsmEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmEditDelete.Size = new System.Drawing.Size(425, 44);
            this.tsmEditDelete.Text = "削除(&D)";
            this.tsmEditDelete.Click += new System.EventHandler(this.tsmEditDelete_OnClick);
            // 
            // tssEdit
            // 
            this.tssEdit.Name = "tssEdit";
            this.tssEdit.Size = new System.Drawing.Size(422, 6);
            // 
            // tsmEditRename
            // 
            this.tsmEditRename.Name = "tsmEditRename";
            this.tsmEditRename.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.tsmEditRename.Size = new System.Drawing.Size(425, 44);
            this.tsmEditRename.Text = "名称の変更(&N)";
            this.tsmEditRename.Click += new System.EventHandler(this.tsmEditRename_OnClick);
            // 
            // tsmEditRegroup
            // 
            this.tsmEditRegroup.Name = "tsmEditRegroup";
            this.tsmEditRegroup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsmEditRegroup.Size = new System.Drawing.Size(425, 44);
            this.tsmEditRegroup.Text = "グループの変更(&G)";
            this.tsmEditRegroup.Click += new System.EventHandler(this.tsmEditRegroup_OnClick);
            // 
            // tssEdit2
            // 
            this.tssEdit2.Name = "tssEdit2";
            this.tssEdit2.Size = new System.Drawing.Size(422, 6);
            // 
            // tsmEditCut
            // 
            this.tsmEditCut.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditCut.Image")));
            this.tsmEditCut.Name = "tsmEditCut";
            this.tsmEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmEditCut.Size = new System.Drawing.Size(425, 44);
            this.tsmEditCut.Text = "切り取り(&X)";
            this.tsmEditCut.Click += new System.EventHandler(this.tsmEditCut_OnClick);
            // 
            // tsmEditCopy
            // 
            this.tsmEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditCopy.Image")));
            this.tsmEditCopy.Name = "tsmEditCopy";
            this.tsmEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmEditCopy.Size = new System.Drawing.Size(425, 44);
            this.tsmEditCopy.Text = "コピー(&C)";
            this.tsmEditCopy.Click += new System.EventHandler(this.tsmEditCopy_OnClick);
            // 
            // tsmEditPaste
            // 
            this.tsmEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditPaste.Image")));
            this.tsmEditPaste.Name = "tsmEditPaste";
            this.tsmEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmEditPaste.Size = new System.Drawing.Size(425, 44);
            this.tsmEditPaste.Text = "貼り付け(&P)";
            this.tsmEditPaste.Click += new System.EventHandler(this.tsmEditPaste_OnClick);
            // 
            // tsmWindow
            // 
            this.tsmWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmWindowEdit,
            this.tsmWindowRefList});
            this.tsmWindow.Name = "tsmWindow";
            this.tsmWindow.Size = new System.Drawing.Size(155, 36);
            this.tsmWindow.Text = "ウィンドウ(&W)";
            // 
            // tsmWindowEdit
            // 
            this.tsmWindowEdit.Name = "tsmWindowEdit";
            this.tsmWindowEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmWindowEdit.Size = new System.Drawing.Size(412, 44);
            this.tsmWindowEdit.Text = "編集画面を開く(&E)";
            this.tsmWindowEdit.Click += new System.EventHandler(this.tsmWindowEdit_OnClick);
            // 
            // tsmWindowRefList
            // 
            this.tsmWindowRefList.Name = "tsmWindowRefList";
            this.tsmWindowRefList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmWindowRefList.Size = new System.Drawing.Size(412, 44);
            this.tsmWindowRefList.Text = "参照リストを開く(&R)";
            this.tsmWindowRefList.Click += new System.EventHandler(this.tsmWindowRefList_OnClick);
            // 
            // tsmDevice
            // 
            this.tsmDevice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDeviceWaveOut,
            this.tsmDeviceMidiIn});
            this.tsmDevice.Name = "tsmDevice";
            this.tsmDevice.Size = new System.Drawing.Size(138, 36);
            this.tsmDevice.Text = "デバイス(&D)";
            // 
            // tsmDeviceWaveOut
            // 
            this.tsmDeviceWaveOut.Name = "tsmDeviceWaveOut";
            this.tsmDeviceWaveOut.Size = new System.Drawing.Size(343, 44);
            this.tsmDeviceWaveOut.Text = "音声出力デバイス(&S)";
            this.tsmDeviceWaveOut.Click += new System.EventHandler(this.tsmDeviceWaveOut_OnClick);
            // 
            // tsmDeviceMidiIn
            // 
            this.tsmDeviceMidiIn.Name = "tsmDeviceMidiIn";
            this.tsmDeviceMidiIn.Size = new System.Drawing.Size(343, 44);
            this.tsmDeviceMidiIn.Text = "MIDI入力(&I)";
            this.tsmDeviceMidiIn.Click += new System.EventHandler(this.tsmDeviceMidiIn_OnClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageWave);
            this.tabControl1.Controls.Add(this.tabPagePreset);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 395);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageWave
            // 
            this.tabPageWave.Controls.Add(this.lblWaveSearchGroup);
            this.tabPageWave.Controls.Add(this.cmbWaveSearchGroup);
            this.tabPageWave.Controls.Add(this.lblWaveSearchName);
            this.tabPageWave.Controls.Add(this.txtWaveSearchName);
            this.tabPageWave.Controls.Add(this.lstWave);
            this.tabPageWave.Location = new System.Drawing.Point(8, 46);
            this.tabPageWave.Name = "tabPageWave";
            this.tabPageWave.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWave.Size = new System.Drawing.Size(794, 341);
            this.tabPageWave.TabIndex = 0;
            this.tabPageWave.Text = "波形リスト";
            this.tabPageWave.UseVisualStyleBackColor = true;
            // 
            // lblWaveSearchGroup
            // 
            this.lblWaveSearchGroup.AutoSize = true;
            this.lblWaveSearchGroup.Location = new System.Drawing.Point(384, 0);
            this.lblWaveSearchGroup.Name = "lblWaveSearchGroup";
            this.lblWaveSearchGroup.Size = new System.Drawing.Size(158, 32);
            this.lblWaveSearchGroup.TabIndex = 4;
            this.lblWaveSearchGroup.Text = "グループ名検索";
            // 
            // cmbWaveSearchGroup
            // 
            this.cmbWaveSearchGroup.FormattingEnabled = true;
            this.cmbWaveSearchGroup.Location = new System.Drawing.Point(384, 35);
            this.cmbWaveSearchGroup.Name = "cmbWaveSearchGroup";
            this.cmbWaveSearchGroup.Size = new System.Drawing.Size(398, 40);
            this.cmbWaveSearchGroup.TabIndex = 3;
            this.cmbWaveSearchGroup.Text = "----+----1----+----2----+----3--";
            this.cmbWaveSearchGroup.SelectedIndexChanged += new System.EventHandler(this.cmbWaveSearchGroup_SelectedIndexChanged);
            this.cmbWaveSearchGroup.TextChanged += new System.EventHandler(this.cmbWaveSearchGroup_TextChanged);
            // 
            // lblWaveSearchName
            // 
            this.lblWaveSearchName.AutoSize = true;
            this.lblWaveSearchName.Location = new System.Drawing.Point(3, 0);
            this.lblWaveSearchName.Name = "lblWaveSearchName";
            this.lblWaveSearchName.Size = new System.Drawing.Size(110, 32);
            this.lblWaveSearchName.TabIndex = 2;
            this.lblWaveSearchName.Text = "名称検索";
            // 
            // txtWaveSearchName
            // 
            this.txtWaveSearchName.Location = new System.Drawing.Point(0, 35);
            this.txtWaveSearchName.Name = "txtWaveSearchName";
            this.txtWaveSearchName.Size = new System.Drawing.Size(378, 39);
            this.txtWaveSearchName.TabIndex = 1;
            this.txtWaveSearchName.Text = "----+----1----+----2----+----3--";
            this.txtWaveSearchName.TextChanged += new System.EventHandler(this.txtWaveSearchName_TextChanged);
            // 
            // lstWave
            // 
            this.lstWave.ContextMenuStrip = this.cmsWave;
            this.lstWave.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstWave.FormattingEnabled = true;
            this.lstWave.ItemHeight = 24;
            this.lstWave.Location = new System.Drawing.Point(3, 80);
            this.lstWave.Name = "lstWave";
            this.lstWave.ScrollAlwaysVisible = true;
            this.lstWave.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstWave.Size = new System.Drawing.Size(240, 148);
            this.lstWave.TabIndex = 0;
            // 
            // cmsWave
            // 
            this.cmsWave.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsWave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmWaveAdd,
            this.tsmWaveDelete,
            this.tssWave,
            this.tsmWaveRename,
            this.tsmWaveRegroup,
            this.tssWave2,
            this.tsmWaveCut,
            this.tsmWaveCopy,
            this.tsmWavePaste,
            this.tssWave3,
            this.tsmWaveFile});
            this.cmsWave.Name = "cmsWave";
            this.cmsWave.Size = new System.Drawing.Size(266, 302);
            // 
            // tsmWaveAdd
            // 
            this.tsmWaveAdd.Name = "tsmWaveAdd";
            this.tsmWaveAdd.Size = new System.Drawing.Size(265, 40);
            this.tsmWaveAdd.Text = "追加(&A)";
            this.tsmWaveAdd.Click += new System.EventHandler(this.tsmWaveAdd_OnClick);
            // 
            // tsmWaveDelete
            // 
            this.tsmWaveDelete.Name = "tsmWaveDelete";
            this.tsmWaveDelete.Size = new System.Drawing.Size(265, 40);
            this.tsmWaveDelete.Text = "削除(&D)";
            this.tsmWaveDelete.Click += new System.EventHandler(this.tsmWaveDelete_OnClick);
            // 
            // tssWave
            // 
            this.tssWave.Name = "tssWave";
            this.tssWave.Size = new System.Drawing.Size(262, 6);
            // 
            // tsmWaveRename
            // 
            this.tsmWaveRename.Name = "tsmWaveRename";
            this.tsmWaveRename.Size = new System.Drawing.Size(265, 40);
            this.tsmWaveRename.Text = "名称の変更(&N)";
            this.tsmWaveRename.Click += new System.EventHandler(this.tsmWaveRename_OnClick);
            // 
            // tsmWaveRegroup
            // 
            this.tsmWaveRegroup.Name = "tsmWaveRegroup";
            this.tsmWaveRegroup.Size = new System.Drawing.Size(265, 40);
            this.tsmWaveRegroup.Text = "グループの変更(&G)";
            this.tsmWaveRegroup.Click += new System.EventHandler(this.tsmWaveRegroup_OnClick);
            // 
            // tssWave2
            // 
            this.tssWave2.Name = "tssWave2";
            this.tssWave2.Size = new System.Drawing.Size(262, 6);
            // 
            // tsmWaveCut
            // 
            this.tsmWaveCut.Image = ((System.Drawing.Image)(resources.GetObject("tsmWaveCut.Image")));
            this.tsmWaveCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmWaveCut.Name = "tsmWaveCut";
            this.tsmWaveCut.Size = new System.Drawing.Size(265, 40);
            this.tsmWaveCut.Text = "切り取り(&X)";
            this.tsmWaveCut.Click += new System.EventHandler(this.tsmWaveCut_OnClick);
            // 
            // tsmWaveCopy
            // 
            this.tsmWaveCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsmWaveCopy.Image")));
            this.tsmWaveCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmWaveCopy.Name = "tsmWaveCopy";
            this.tsmWaveCopy.Size = new System.Drawing.Size(265, 40);
            this.tsmWaveCopy.Text = "コピー(&C)";
            this.tsmWaveCopy.Click += new System.EventHandler(this.tsmWaveCopy_OnClick);
            // 
            // tsmWavePaste
            // 
            this.tsmWavePaste.Image = ((System.Drawing.Image)(resources.GetObject("tsmWavePaste.Image")));
            this.tsmWavePaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmWavePaste.Name = "tsmWavePaste";
            this.tsmWavePaste.Size = new System.Drawing.Size(265, 40);
            this.tsmWavePaste.Text = "貼り付け(&P)";
            this.tsmWavePaste.Click += new System.EventHandler(this.tsmWavePaste_OnClick);
            // 
            // tssWave3
            // 
            this.tssWave3.Name = "tssWave3";
            this.tssWave3.Size = new System.Drawing.Size(262, 6);
            // 
            // tsmWaveFile
            // 
            this.tsmWaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmWaveFile.Name = "tsmWaveFile";
            this.tsmWaveFile.Size = new System.Drawing.Size(265, 40);
            this.tsmWaveFile.Text = "ファイルに保存(&F)";
            this.tsmWaveFile.Click += new System.EventHandler(this.tsmWaveFile_OnClick);
            // 
            // tabPagePreset
            // 
            this.tabPagePreset.Controls.Add(this.lblPresetSearchGroup);
            this.tabPagePreset.Controls.Add(this.cmbPresetSearchGroup);
            this.tabPagePreset.Controls.Add(this.lblPresetSearchName);
            this.tabPagePreset.Controls.Add(this.txtPresetSearchName);
            this.tabPagePreset.Controls.Add(this.lstPreset);
            this.tabPagePreset.Location = new System.Drawing.Point(8, 46);
            this.tabPagePreset.Name = "tabPagePreset";
            this.tabPagePreset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreset.Size = new System.Drawing.Size(794, 341);
            this.tabPagePreset.TabIndex = 1;
            this.tabPagePreset.Text = "プリセットリスト";
            this.tabPagePreset.UseVisualStyleBackColor = true;
            // 
            // lblPresetSearchGroup
            // 
            this.lblPresetSearchGroup.AutoSize = true;
            this.lblPresetSearchGroup.Location = new System.Drawing.Point(387, 0);
            this.lblPresetSearchGroup.Name = "lblPresetSearchGroup";
            this.lblPresetSearchGroup.Size = new System.Drawing.Size(158, 32);
            this.lblPresetSearchGroup.TabIndex = 8;
            this.lblPresetSearchGroup.Text = "グループ名検索";
            // 
            // cmbPresetSearchGroup
            // 
            this.cmbPresetSearchGroup.FormattingEnabled = true;
            this.cmbPresetSearchGroup.Location = new System.Drawing.Point(387, 34);
            this.cmbPresetSearchGroup.Name = "cmbPresetSearchGroup";
            this.cmbPresetSearchGroup.Size = new System.Drawing.Size(398, 40);
            this.cmbPresetSearchGroup.TabIndex = 7;
            this.cmbPresetSearchGroup.Text = "----+----1----+----2----+----3--";
            this.cmbPresetSearchGroup.SelectedIndexChanged += new System.EventHandler(this.cmbPresetSearchGroup_SelectedIndexChanged);
            this.cmbPresetSearchGroup.TextChanged += new System.EventHandler(this.cmbPresetSearchGroup_TextChanged);
            // 
            // lblPresetSearchName
            // 
            this.lblPresetSearchName.AutoSize = true;
            this.lblPresetSearchName.Location = new System.Drawing.Point(0, 0);
            this.lblPresetSearchName.Name = "lblPresetSearchName";
            this.lblPresetSearchName.Size = new System.Drawing.Size(110, 32);
            this.lblPresetSearchName.TabIndex = 6;
            this.lblPresetSearchName.Text = "名称検索";
            // 
            // txtPresetSearchName
            // 
            this.txtPresetSearchName.Location = new System.Drawing.Point(3, 35);
            this.txtPresetSearchName.Name = "txtPresetSearchName";
            this.txtPresetSearchName.Size = new System.Drawing.Size(378, 39);
            this.txtPresetSearchName.TabIndex = 5;
            this.txtPresetSearchName.Text = "----+----1----+----2----+----3--";
            this.txtPresetSearchName.TextChanged += new System.EventHandler(this.txtPresetSearchName_TextChanged);
            // 
            // lstPreset
            // 
            this.lstPreset.ContextMenuStrip = this.cmsPreset;
            this.lstPreset.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstPreset.FormattingEnabled = true;
            this.lstPreset.ItemHeight = 24;
            this.lstPreset.Location = new System.Drawing.Point(3, 80);
            this.lstPreset.Name = "lstPreset";
            this.lstPreset.ScrollAlwaysVisible = true;
            this.lstPreset.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPreset.Size = new System.Drawing.Size(240, 148);
            this.lstPreset.TabIndex = 0;
            // 
            // cmsPreset
            // 
            this.cmsPreset.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsPreset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPresetAdd,
            this.tsmPresetDelete,
            this.tssPreset,
            this.tsmPresetRename,
            this.tsmPresetRegroup,
            this.tssPreset2,
            this.tsmPresetCut,
            this.tsmPresetCopy,
            this.tsmPresetPaste});
            this.cmsPreset.Name = "cmsPreset";
            this.cmsPreset.Size = new System.Drawing.Size(253, 256);
            // 
            // tsmPresetAdd
            // 
            this.tsmPresetAdd.Name = "tsmPresetAdd";
            this.tsmPresetAdd.Size = new System.Drawing.Size(252, 40);
            this.tsmPresetAdd.Text = "追加(&A)";
            this.tsmPresetAdd.Click += new System.EventHandler(this.tsmPresetAdd_OnClick);
            // 
            // tsmPresetDelete
            // 
            this.tsmPresetDelete.Name = "tsmPresetDelete";
            this.tsmPresetDelete.Size = new System.Drawing.Size(252, 40);
            this.tsmPresetDelete.Text = "削除(&D)";
            this.tsmPresetDelete.Click += new System.EventHandler(this.tsmPresetDelete_OnClick);
            // 
            // tssPreset
            // 
            this.tssPreset.Name = "tssPreset";
            this.tssPreset.Size = new System.Drawing.Size(249, 6);
            // 
            // tsmPresetRename
            // 
            this.tsmPresetRename.Name = "tsmPresetRename";
            this.tsmPresetRename.Size = new System.Drawing.Size(252, 40);
            this.tsmPresetRename.Text = "名称の変更(&N)";
            this.tsmPresetRename.Click += new System.EventHandler(this.tsmPresetRename_OnClick);
            // 
            // tsmPresetRegroup
            // 
            this.tsmPresetRegroup.Name = "tsmPresetRegroup";
            this.tsmPresetRegroup.Size = new System.Drawing.Size(252, 40);
            this.tsmPresetRegroup.Text = "グループの変更(&G)";
            this.tsmPresetRegroup.Click += new System.EventHandler(this.tsmPresetRegroup_OnClick);
            // 
            // tssPreset2
            // 
            this.tssPreset2.Name = "tssPreset2";
            this.tssPreset2.Size = new System.Drawing.Size(249, 6);
            // 
            // tsmPresetCut
            // 
            this.tsmPresetCut.Image = ((System.Drawing.Image)(resources.GetObject("tsmPresetCut.Image")));
            this.tsmPresetCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmPresetCut.Name = "tsmPresetCut";
            this.tsmPresetCut.Size = new System.Drawing.Size(252, 40);
            this.tsmPresetCut.Text = "切り取り(&X)";
            this.tsmPresetCut.Click += new System.EventHandler(this.tsmPresetCut_OnClick);
            // 
            // tsmPresetCopy
            // 
            this.tsmPresetCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsmPresetCopy.Image")));
            this.tsmPresetCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmPresetCopy.Name = "tsmPresetCopy";
            this.tsmPresetCopy.Size = new System.Drawing.Size(252, 40);
            this.tsmPresetCopy.Text = "コピー(&C)";
            this.tsmPresetCopy.Click += new System.EventHandler(this.tsmPresetCopy_OnClick);
            // 
            // tsmPresetPaste
            // 
            this.tsmPresetPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsmPresetPaste.Image")));
            this.tsmPresetPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmPresetPaste.Name = "tsmPresetPaste";
            this.tsmPresetPaste.Size = new System.Drawing.Size(252, 40);
            this.tsmPresetPaste.Text = "貼り付け(&P)";
            this.tsmPresetPaste.Click += new System.EventHandler(this.tsmPresetPaste_OnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 731);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DLS Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageWave.ResumeLayout(false);
            this.tabPageWave.PerformLayout();
            this.cmsWave.ResumeLayout(false);
            this.tabPagePreset.ResumeLayout(false);
            this.tabPagePreset.PerformLayout();
            this.cmsPreset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmFileNew;
        private System.Windows.Forms.ToolStripMenuItem tsmFileOpen;
        private System.Windows.Forms.ToolStripSeparator tssFile;
        private System.Windows.Forms.ToolStripMenuItem tsmFileSave;
        private System.Windows.Forms.ToolStripMenuItem tsmFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmEditAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmEditDelete;
        private System.Windows.Forms.ToolStripSeparator tssEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmEditRename;
        private System.Windows.Forms.ToolStripMenuItem tsmEditRegroup;
        private System.Windows.Forms.ToolStripSeparator tssEdit2;
        private System.Windows.Forms.ToolStripMenuItem tsmEditCut;
        private System.Windows.Forms.ToolStripMenuItem tsmEditCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmEditPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmWindowEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmWindowRefList;
        private System.Windows.Forms.ToolStripMenuItem tsmDevice;
        private System.Windows.Forms.ToolStripMenuItem tsmDeviceWaveOut;
        private System.Windows.Forms.ToolStripMenuItem tsmDeviceMidiIn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageWave;
        private System.Windows.Forms.TabPage tabPagePreset;
        private System.Windows.Forms.ListBox lstWave;
        private System.Windows.Forms.ListBox lstPreset;
        private System.Windows.Forms.ContextMenuStrip cmsWave;
        private System.Windows.Forms.ToolStripMenuItem tsmWaveAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmWaveDelete;
        private System.Windows.Forms.ToolStripSeparator tssWave;
        private System.Windows.Forms.ToolStripMenuItem tsmWaveRename;
        private System.Windows.Forms.ToolStripMenuItem tsmWaveRegroup;
        private System.Windows.Forms.ToolStripSeparator tssWave2;
        private System.Windows.Forms.ToolStripMenuItem tsmWaveCut;
        private System.Windows.Forms.ToolStripMenuItem tsmWaveCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmWavePaste;
        private System.Windows.Forms.ToolStripSeparator tssWave3;
        private System.Windows.Forms.ToolStripMenuItem tsmWaveFile;
        private System.Windows.Forms.ContextMenuStrip cmsPreset;
        private System.Windows.Forms.ToolStripMenuItem tsmPresetAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmPresetDelete;
        private System.Windows.Forms.ToolStripSeparator tssPreset;
        private System.Windows.Forms.ToolStripMenuItem tsmPresetRename;
        private System.Windows.Forms.ToolStripMenuItem tsmPresetRegroup;
        private System.Windows.Forms.ToolStripSeparator tssPreset2;
        private System.Windows.Forms.ToolStripMenuItem tsmPresetCut;
        private System.Windows.Forms.ToolStripMenuItem tsmPresetCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmPresetPaste;
        private System.Windows.Forms.Label lblWaveSearchName;
        private System.Windows.Forms.TextBox txtWaveSearchName;
        private System.Windows.Forms.Label lblWaveSearchGroup;
        private System.Windows.Forms.ComboBox cmbWaveSearchGroup;
        private System.Windows.Forms.Label lblPresetSearchName;
        private System.Windows.Forms.TextBox txtPresetSearchName;
        private System.Windows.Forms.Label lblPresetSearchGroup;
        private System.Windows.Forms.ComboBox cmbPresetSearchGroup;
    }
}