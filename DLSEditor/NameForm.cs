using System;
using System.Windows.Forms;

namespace DLSEditor {
    public partial class NameForm : Form {
        public bool Cancel = false;

        public NameForm(Form parent) {
            InitializeComponent();
            Left = Cursor.Position.X - Width / 2;
            Top = Cursor.Position.Y - Height / 2;
            if (Left < parent.Left + 16) {
                Left = parent.Left + 16;
            }
            if (Top < parent.Top) {
                Top = parent.Top;
            }
            if (parent.Bottom < Bottom + 16) {
                Top = parent.Bottom - Height - 16;
            }
            if (parent.Right < Right - 16) {
                Left = parent.Right - Width - 16;
            }
            panel1.Width = Width;
            panel1.Height = Height;
        }

        private void btnReflection_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Cancel = true;
            Close();
        }
    }
}
