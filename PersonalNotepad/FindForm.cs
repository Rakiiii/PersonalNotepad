using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalNotepad
{
    public partial class FindForm : Form
    {
        public int find = 0;
        public FindForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void btnFindMatch_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBoxFinds options = RichTextBoxFinds.None;
                int selected = ((Form1)this.Tag).rchtxtbxMain.SelectionStart;
                int to = ((Form1)this.Tag).rchtxtbxMain.TextLength - 1;
                if (chckbxMatchCase.Checked) options = options | RichTextBoxFinds.MatchCase;
                if(rdbtnUp.Checked)
                {
                    options = options | RichTextBoxFinds.Reverse;
                    to = selected;
                    selected = 0;
                }
                int res = 0;
                res = ((Form1)this.Tag).rchtxtbxMain.Find(txtbxStringToFind.Text, selected, to, options);
                if(res > 0)
                {
                    ((Form1)this.Tag).rchtxtbxMain.SelectionStart = res;
                    ((Form1)this.Tag).rchtxtbxMain.SelectionLength = txtbxStringToFind.TextLength;
                    ((Form1)this.Tag).rchtxtbxMain.ScrollToCaret();
                    ((Form1)this.Tag).rchtxtbxMain.Refresh();
                    ((Form1)this.Tag).rchtxtbxMain.Focus();
                }
                else
                {
                    MessageBox.Show("No match found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Hide();
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }
    }
}
