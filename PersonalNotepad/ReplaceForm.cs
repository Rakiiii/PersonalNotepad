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
    public partial class ReplaceForm : Form
    {
        public ReplaceForm()
        {
            InitializeComponent();
        }

        //кнопка выхода 
        private void button1_Click(object sender, EventArgs e)
        {
            //прячем форму
            this.Hide();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            try
            {
                //настраиваем поиск 
                RichTextBoxFinds options = RichTextBoxFinds.None;

                //запоминаем место курсора
                int selected = ((Form1)this.Tag).rchtxtbxMain.SelectionStart;
                //запоминаем длину текста
                int to = ((Form1)this.Tag).rchtxtbxMain.TextLength - 1;

                //проверяем надо ли учитывать регистр
                if (chckbxMatchCase.Checked) options = options | RichTextBoxFinds.MatchCase;     
                
                //инициализируем переменную для хранения результата
                int res = 0;

                //изем в тесте
                res = ((Form1)this.Tag).rchtxtbxMain.Find(txtbxReplaceWhat.Text, selected, to, options);

                //если нашли
                if (res > 0)
                {
                    //удаляем найденое
                    ((Form1)this.Tag).rchtxtbxMain.Text = ((Form1)this.Tag).rchtxtbxMain.Text.Remove(res, txtbxReplaceWhat.TextLength);

                    //вставляем замену
                    ((Form1)this.Tag).rchtxtbxMain.Text = ((Form1)this.Tag).rchtxtbxMain.Text.Insert(res, txtbxRaplacwWith.Text);

                    //выделяем замену и двигаем фокус
                    ((Form1)this.Tag).rchtxtbxMain.SelectionStart = res;
                    ((Form1)this.Tag).rchtxtbxMain.SelectionLength = txtbxRaplacwWith.TextLength;
                    ((Form1)this.Tag).rchtxtbxMain.ScrollToCaret();
                    ((Form1)this.Tag).rchtxtbxMain.Refresh();
                    ((Form1)this.Tag).rchtxtbxMain.Focus();
                }
                else
                {
                    //если ничего не нашли, сообщаем об этом
                    MessageBox.Show("No match found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                //скрываем форму
                this.Hide();
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }
    }
}
