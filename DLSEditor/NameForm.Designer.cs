
namespace DLSEditor {
    partial class NameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TxtName = new System.Windows.Forms.TextBox();
            this.btnReflection = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(11, 11);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(390, 39);
            this.TxtName.TabIndex = 2;
            this.TxtName.Text = "----+----1----+----2----+----3--";
            // 
            // btnReflection
            // 
            this.btnReflection.Location = new System.Drawing.Point(11, 56);
            this.btnReflection.Name = "btnReflection";
            this.btnReflection.Size = new System.Drawing.Size(173, 46);
            this.btnReflection.TabIndex = 4;
            this.btnReflection.Text = "反映";
            this.btnReflection.UseVisualStyleBackColor = true;
            this.btnReflection.Click += new System.EventHandler(this.btnReflection_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 46);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnReflection);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 116);
            this.panel1.TabIndex = 6;
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 116);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RenameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "名称変更";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReflection;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Panel panel1;
    }
}