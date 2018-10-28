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
    public partial class Form1 : Form
    {
        //экзеспляр формы с лицензией
        InformationForm frmInfo = new InformationForm();

        //экземпляр соханения в файл
        SaveFileDialog svf = new SaveFileDialog();
        

        //экземпляр открытия файла
        OpenFileDialog ofd = new OpenFileDialog();

        //строка для хранения пути
        string path = null;

        //флаг проверки на сохраненность
        bool flagSaved = false;

        //форма для поиска
        FindForm frmFind = new FindForm();

        //форма замены
        ReplaceForm frmReplace = new ReplaceForm();

        
        public Form1()
        {
            InitializeComponent();
        }

        //кнопка вывода лицензии
        private void licensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfo.ShowDialog();
        }

        //кнопка выхода
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //если файл сохранен или пуст то выходим
                if (flagSaved || (rchtxtbxMain.Text == ""))
                {
                    this.Close();

                }
                else
                {
                    //создаем экхемпляер формы вопроса по сохранению
                    frmAskForSaving asker = new frmAskForSaving();

                    //передаем в нее ссылку на форму
                    asker.Tag = this;
                    //отображаем форму
                    asker.ShowDialog();
                    //выходим
                    this.Close();
                }
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
            
        }

        //создаем новый файл
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //если сохранен или пуст то чистим
                if(flagSaved || (rchtxtbxMain.Text == "" ) )
                {
                    rchtxtbxMain.Clear();
                    
                }
                else
                {
                    //создаем экземпляр форму задания вопроса сохранения
                    frmAskForSaving asker = new frmAskForSaving();

                    //передаем ссылку на оснавную форму
                    asker.Tag = this;
                    //выводим форму
                    asker.ShowDialog();
                    //чистим
                    rchtxtbxMain.Clear();
                }
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        //кнопка открытия файла
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //настраеваем дефолты для файла
                ofd.DefaultExt = "*.txt";
                ofd.Filter = "Text Files|*.txt";
                //если файл сохранен или пуст
                if (flagSaved || (rchtxtbxMain.Text == ""))
                {
                    //выводим диалог выбора,если ок
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        //открываем файл
                        rchtxtbxMain.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                        path = ofd.FileName;
                    }
                    
                }
                else
                {
                    //иначе спрашиваем прос охранение
                    frmAskForSaving asker = new frmAskForSaving();
                    asker.Tag = this;
                    asker.ShowDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //открываем новый файл
                        rchtxtbxMain.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                        path = ofd.FileName;
                    }
                }
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //настраиваем дефолты сохранения
                svf.DefaultExt = "*.txt";
                svf.Filter = "Text Files|*.txt";

                //если не сохоранен
                if (!flagSaved)
                {
                    //если путь есть
                    if(path != null)
                    {
                        //сохраняем
                        rchtxtbxMain.SaveFile(path, RichTextBoxStreamType.PlainText);
                        flagSaved = true;

                    }
                    else
                    {
                        //предлагаем выбрать путь
                        if(svf.ShowDialog() == DialogResult.OK)
                        {
                            rchtxtbxMain.SaveFile(svf.FileName, RichTextBoxStreamType.PlainText);
                            path = svf.FileName;
                            flagSaved = true;
                        }
                    }
                }
            }
            catch(AccessViolationException)
            {
                MessageBox.Show("Access is denied", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //настраиваем дефолты для сохранения файлов
                svf.DefaultExt = "*.txt";
                svf.Filter = "Text Files|*.txt";

                //если не сохранен
                if (!flagSaved)
                {
                    //выводим окно выбора точки сохранения
                    if (svf.ShowDialog() == DialogResult.OK)
                    {
                        //сохраняем
                            rchtxtbxMain.SaveFile(svf.FileName, RichTextBoxStreamType.PlainText);
                            flagSaved = true;
                            path = svf.FileName;
                    }
                }
            }
            catch(AccessViolationException)
            {
                MessageBox.Show("Access is denied", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //если что то выделено
                if (rchtxtbxMain.SelectedText != null)
                {
                    //коппируем
                    rchtxtbxMain.Copy();
                }
            }
            catch (Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //если можем втсавит сожержимое буфера
                if (rchtxtbxMain.CanPaste(DataFormats.GetFormat(DataFormats.Text)))
                {
                    //вставляем
                    rchtxtbxMain.Paste();
                }
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //если что то выделено
                if (rchtxtbxMain.SelectedText != null)
                {
                    //вырезаем
                    rchtxtbxMain.Cut();
                }
            }
            catch (Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //если что то выбрано
                if (rchtxtbxMain.SelectedText != null)
                {
                    //удаляем выделенный текст
                    rchtxtbxMain.SelectedText = "";
                }
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //если можем откатить последнюю операцию 
                if(rchtxtbxMain.CanUndo)
                {
                    //откатываем
                    rchtxtbxMain.Undo();
                }
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void rchtxtbxMain_TextChanged(object sender, EventArgs e)
        {
            if (flagSaved)
                flagSaved = false;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //передаем ссылку на эту форму в форму поиска
                frmFind.Tag = this;
                //выводим форму поиска
                frmFind.ShowDialog();
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //передаем ссылка на эту форму в форму замены
                frmReplace.Tag = this;
                //выводим форму замены
                frmReplace.ShowDialog();
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //выбираем весь текст
                rchtxtbxMain.SelectAll();
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //создаем экземпляр формы выбора шрмфта
                FontDialog fnt = new FontDialog();
                //разрешаем выбор цветов
                fnt.ShowColor = true;
                //выводим форму выбора щрифта
                fnt.ShowDialog();

                //меняем шрифт
                rchtxtbxMain.Font = fnt.Font;
                //меняем цвет
                rchtxtbxMain.ForeColor = fnt.Color;
                
            }
            catch(Exception er)
            {
                Logger.writeLog(er.ToString());
            }
        }
    }
}
