using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonalNotepad
{
    public partial class frmAskForSaving : Form
    {
        public frmAskForSaving()
        {
            InitializeComponent();
        }

        //кнопка yes
        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                //создаем объект выбора пути сохранения
                SaveFileDialog saver = new SaveFileDialog();

                //настраиваем дефолтные значения для выбора
                saver.DefaultExt = "*.txt";
                saver.Filter = "Text Files|*.txt";

                //открываем форму выбора пути сохранения
                if(saver.ShowDialog() == DialogResult.OK)
                {
                    //сохраняем
                    ((Form1)this.Tag).rchtxtbxMain.SaveFile(saver.FileName, RichTextBoxStreamType.PlainText);
                    
                }
                //скрываем форму
                this.Hide();
            }
            catch(AccessViolationException)
            {
                
                //выводим сообзение об ошибке сохранения
                MessageBox.Show("Access is denied" ,"Error " , MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
