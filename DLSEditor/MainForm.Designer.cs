
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFile = new System.Windows.Forms.ToolStripSeparator();
            this.tsmFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tssEdit = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDisplayEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDisplayRefList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeviceWaveOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeviceMidiIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWave = new System.Windows.Forms.TabPage();
            this.lstWave = new System.Windows.Forms.ListBox();
            this.tabPagePreset = new System.Windows.Forms.TabPage();
            this.lstPreset = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageWave.SuspendLayout();
            this.tabPagePreset.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmEdit,
            this.tsmDisplay,
            this.tsmDevice});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
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
            this.tsmEditCut,
            this.tsmEditCopy,
            this.tsmEditPaste,
            this.tssEdit,
            this.tsmEditAdd,
            this.tsmEditDelete});
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(108, 36);
            this.tsmEdit.Text = "編集(&E)";
            // 
            // tsmEditCut
            // 
            this.tsmEditCut.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditCut.Image")));
            this.tsmEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmEditCut.Name = "tsmEditCut";
            this.tsmEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmEditCut.Size = new System.Drawing.Size(339, 44);
            this.tsmEditCut.Text = "切り取り(&X)";
            this.tsmEditCut.Click += new System.EventHandler(this.tsmEditCut_OnClick);
            // 
            // tsmEditCopy
            // 
            this.tsmEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditCopy.Image")));
            this.tsmEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmEditCopy.Name = "tsmEditCopy";
            this.tsmEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmEditCopy.Size = new System.Drawing.Size(339, 44);
            this.tsmEditCopy.Text = "コピー(&C)";
            this.tsmEditCopy.Click += new System.EventHandler(this.tsmEditCopy_OnClick);
            // 
            // tsmEditPaste
            // 
            this.tsmEditPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsmEditPaste.Image")));
            this.tsmEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmEditPaste.Name = "tsmEditPaste";
            this.tsmEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmEditPaste.Size = new System.Drawing.Size(339, 44);
            this.tsmEditPaste.Text = "貼り付け(&P)";
            this.tsmEditPaste.Click += new System.EventHandler(this.tsmEditPaste_OnClick);
            // 
            // tssEdit
            // 
            this.tssEdit.Name = "tssEdit";
            this.tssEdit.Size = new System.Drawing.Size(336, 6);
            // 
            // tsmEditAdd
            // 
            this.tsmEditAdd.Name = "tsmEditAdd";
            this.tsmEditAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmEditAdd.Size = new System.Drawing.Size(339, 44);
            this.tsmEditAdd.Text = "追加(&A)";
            this.tsmEditAdd.Click += new System.EventHandler(this.tsmEditAdd_OnClick);
            // 
            // tsmEditDelete
            // 
            this.tsmEditDelete.Name = "tsmEditDelete";
            this.tsmEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.tsmEditDelete.Size = new System.Drawing.Size(339, 44);
            this.tsmEditDelete.Text = "削除(&D)";
            this.tsmEditDelete.Click += new System.EventHandler(this.tsmEditDelete_OnClick);
            // 
            // tsmDisplay
            // 
            this.tsmDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDisplayEdit,
            this.tsmDisplayRefList});
            this.tsmDisplay.Name = "tsmDisplay";
            this.tsmDisplay.Size = new System.Drawing.Size(118, 36);
            this.tsmDisplay.Text = "表示(&W)";
            // 
            // tsmDisplayEdit
            // 
            this.tsmDisplayEdit.Name = "tsmDisplayEdit";
            this.tsmDisplayEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmDisplayEdit.Size = new System.Drawing.Size(412, 44);
            this.tsmDisplayEdit.Text = "編集画面を開く(&E)";
            this.tsmDisplayEdit.Click += new System.EventHandler(this.tsmDisplayEdit_OnClick);
            // 
            // tsmDisplayRefList
            // 
            this.tsmDisplayRefList.Name = "tsmDisplayRefList";
            this.tsmDisplayRefList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tsmDisplayRefList.Size = new System.Drawing.Size(412, 44);
            this.tsmDisplayRefList.Text = "参照リストを開く(&R)";
            this.tsmDisplayRefList.Click += new System.EventHandler(this.tsmDisplayRefList_OnClick);
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
            this.tabControl1.Size = new System.Drawing.Size(776, 395);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageWave
            // 
            this.tabPageWave.Controls.Add(this.lstWave);
            this.tabPageWave.Location = new System.Drawing.Point(8, 46);
            this.tabPageWave.Name = "tabPageWave";
            this.tabPageWave.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWave.Size = new System.Drawing.Size(760, 341);
            this.tabPageWave.TabIndex = 0;
            this.tabPageWave.Text = "波形リスト";
            this.tabPageWave.UseVisualStyleBackColor = true;
            // 
            // lstWave
            // 
            this.lstWave.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstWave.FormattingEnabled = true;
            this.lstWave.ItemHeight = 24;
            this.lstWave.Location = new System.Drawing.Point(3, 3);
            this.lstWave.Name = "lstWave";
            this.lstWave.ScrollAlwaysVisible = true;
            this.lstWave.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstWave.Size = new System.Drawing.Size(240, 148);
            this.lstWave.TabIndex = 0;
            // 
            // tabPagePreset
            // 
            this.tabPagePreset.Controls.Add(this.lstPreset);
            this.tabPagePreset.Location = new System.Drawing.Point(8, 46);
            this.tabPagePreset.Name = "tabPagePreset";
            this.tabPagePreset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreset.Size = new System.Drawing.Size(760, 341);
            this.tabPagePreset.TabIndex = 1;
            this.tabPagePreset.Text = "プリセットリスト";
            this.tabPagePreset.UseVisualStyleBackColor = true;
            // 
            // lstPreset
            // 
            this.lstPreset.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstPreset.FormattingEnabled = true;
            this.lstPreset.ItemHeight = 24;
            this.lstPreset.Location = new System.Drawing.Point(4, 4);
            this.lstPreset.Name = "lstPreset";
            this.lstPreset.ScrollAlwaysVisible = true;
            this.lstPreset.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPreset.Size = new System.Drawing.Size(240, 148);
            this.lstPreset.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.tabPagePreset.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmFileNew;
        private System.Windows.Forms.ToolStripMenuItem tsmFileOpen;
        private System.Windows.Forms.ToolStripSeparator tssFile;
        private System.Windows.Forms.ToolStripMenuItem tsmFileSave;
        private System.Windows.Forms.ToolStripMenuItem tsmFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmEditCut;
        private System.Windows.Forms.ToolStripMenuItem tsmEditCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmEditPaste;
        private System.Windows.Forms.ToolStripSeparator tssEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmEditAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmEditDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmDisplay;
        private System.Windows.Forms.ToolStripMenuItem tsmDisplayEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDisplayRefList;
        private System.Windows.Forms.ToolStripMenuItem tsmDevice;
        private System.Windows.Forms.ToolStripMenuItem tsmDeviceWaveOut;
        private System.Windows.Forms.ToolStripMenuItem tsmDeviceMidiIn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageWave;
        private System.Windows.Forms.TabPage tabPagePreset;
        private System.Windows.Forms.ListBox lstWave;
        private System.Windows.Forms.ListBox lstPreset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

