using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Text_editor
{
    public partial class FormEditor : Form
    {

        private OpenFileDialog ofd;

        public FormEditor()
        {
            InitializeComponent();
            toolStripComboBoxProgrammingLanguages.SelectedIndex = 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog()
            {
                Filter = "Текстовые файлы (*.txt)|*.txt"
            };

            if (ofd.ShowDialog() == DialogResult.OK &&
                File.Exists(ofd.FileName))
            {
                richTextBox.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd != null)
            {
                richTextBox.SaveFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }
            else
            {
                SaveAs();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "Текстовые файлы(.txt) |.txt",
                RestoreDirectory = false
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show($"Файл сохранен в:\n{sfd.FileName}");
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText.Length > 0)
            {
                richTextBox.Copy();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выделите текст для копирования.");
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Text);

                if (richTextBox.CanPaste(myFormat))
                {
                    richTextBox.Paste();
                }
                else
                {
                    MessageBox.Show("Буфер обмена пуст.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindText();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxReplace.Text))
            {
                if (FindText())
                {
                    richTextBox.Text = richTextBox.Text.Replace(textBoxFind.Text, textBoxReplace.Text);
                }
            }
            else
            {
                MessageBox.Show("Введите строку или символ в поле замены.");
            }
        }

        private bool FindText()
        {
            if (!String.IsNullOrEmpty(textBoxFind.Text))
            {
                if (richTextBox.Find(textBoxFind.Text) != -1)
                {
                    MatchCollection RegEx = Regex.Matches(richTextBox.Text, textBoxFind.Text);

                    foreach (Match match in RegEx)
                    {
                        richTextBox.Select(match.Index, match.Length);

                        richTextBox.SelectionBackColor = Color.Yellow;

                        richTextBox.Select(match.Index, match.Length);
                    }

                    if (String.IsNullOrEmpty(textBoxReplace.Text))
                    {
                        MessageBox.Show("Нажмите двав раз на левую кнопку мыши, чтобы снять выдиления.");
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Совпадений не найдено.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Введите строку или символ в поле поиска.");
                return false;
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox.SelectedText.Length > 0)
            {
                if (richTextBox.SelectionFont.Style != FontStyle.Bold)
                {
                    richTextBox.SelectionFont = new Font("Times New Roman", 14, FontStyle.Bold);
                }
                else
                {
                    richTextBox.SelectionFont = new Font("Times New Roman", 14, FontStyle.Regular);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выделите текст для форматирования.");
            }
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox.SelectedText.Length > 0)
            {
                if (richTextBox.SelectionFont.Style != FontStyle.Italic)
                {
                    richTextBox.SelectionFont = new Font("Times New Roman", 14, FontStyle.Italic);
                }
                else
                {
                    richTextBox.SelectionFont = new Font("Times New Roman", 14, FontStyle.Regular);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выделите текст для форматирования.");
            }
        }

        private void underlinedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText.Length > 0)
            {
                if (richTextBox.SelectionFont.Style != FontStyle.Underline)
                {
                    richTextBox.SelectionFont = new Font("Times New Roman", 14, FontStyle.Underline);
                }
                else
                {
                    richTextBox.SelectionFont = new Font("Times New Roman", 14, FontStyle.Regular);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выделите текст для форматирования.");
            }
        }

        private void strikeoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText.Length > 0)
            {
                if (richTextBox.SelectionFont.Style != FontStyle.Strikeout)
                {
                    richTextBox.SelectionFont = new Font("Times New Roman", 14, FontStyle.Strikeout);
                }
                else
                {
                    richTextBox.SelectionFont = new Font("Times New Roman", 14, FontStyle.Regular);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выделите текст для форматирования.");
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox.SelectedText.Length > 0)
                {
                    richTextBox.SelectionFont = fd.Font;
                }
                else
                {
                    richTextBox.Font = fd.Font;
                }

                if(richTextBox.Text.Length == 0)
                {
                    richTextBox.Clear();
                }
            }
        }

        private void richTextBox_DoubleClick(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = Color.White;
        }
               
        private void toolStripComboBoxProgrammingLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regexNumber = new Regex(@"\d+", RegexOptions.Compiled);
            MatchCollection matchesNumber = regexNumber.Matches(richTextBox.Text);

            foreach (Match match in matchesNumber)
            {
                richTextBox.Select(match.Index, match.Length);

                if(toolStripComboBoxProgrammingLanguages.SelectedIndex == 0)
                {
                    richTextBox.SelectionColor = Color.Black;
                }
                else
                {
                    richTextBox.SelectionColor = Color.DarkSlateGray;
                }

                richTextBox.SelectedText = match.Value;
            }

            Regex regexSyntax = new Regex(@"\b(object|namespace|class|let|var|bool|double|int|string|void|long|short|byte|sbyte|decimal|float|char|typeof|new|public|private|protected|internal|static|sealed|abstract|async|await|virtual|override|partial|params|out|ref|in|case|else|switch|try|catch|finally|do|while|for|foreach|using|is|as|break|continue|goto|throw|checked|unchecked|default|if|else|return|get|set|lock|when|unsafe|fixed|yield|dynamic|from|to|by|on|off|true|false|null)\b", RegexOptions.Compiled);
            MatchCollection matchesSyntax = regexSyntax.Matches(richTextBox.Text);
            foreach (Match match in matchesSyntax)
            {
                richTextBox.Select(match.Index, match.Length);

                switch (toolStripComboBoxProgrammingLanguages.SelectedIndex)
                {
                    case 0:
                        richTextBox.SelectionColor = Color.Black;
                        break;
                    case 1:
                        richTextBox.SelectionColor = Color.DarkBlue;
                        break;
                    case 2:
                        richTextBox.SelectionColor = Color.Blue;
                        break;
                    case 3:
                        richTextBox.SelectionColor = Color.OrangeRed;
                        break;
                    case 4:
                        richTextBox.SelectionColor = Color.Orange;
                        break;
                }

                richTextBox.SelectedText = match.Value;
            }
        }

        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                                
            }
        }
    }
}        
    

