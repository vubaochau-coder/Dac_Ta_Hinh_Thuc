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
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Dac_Ta_Hinh_Thuc
{
    public partial class Form1 : Form
    {
        public string inputStr;

        public string nameFunc;

        private string finalText;
        private string lastSavedText;
        private bool isSaved;
        private string fileName;

        public const string PRE = "pre";
        public const string POST = "post";

        public const string THEME_1 =
            "using System;\n" +
            "namespace FormalSpecification\n" +
            "{\n" +
            "\tclass Program\n" +
            "\t{\n";
        public const string THEME_2 = "(string[] args)\n" +
            "\t\t{\n";

        public string textBoxSelected;
        public Form1()
        {
            isSaved = true;
            fileName = "";
            lastSavedText = "";
            textBoxSelected = "";

            InitializeComponent();
        }

        private void BtnBlank_Click(object sender, EventArgs e)
        {
            SetBlankPage();
            isSaved = true;
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        private void MenuItem_Open_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void MenuItem_New_Click(object sender, EventArgs e)
        {
            SetBlankPage();
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {
            isSaved = false;
        }

        private void MenuItem_Save_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        private void MenuItem_Exit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (isSaved)
                    Application.Exit();
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to save change?", "Exit", MessageBoxButtons.YesNoCancel);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            SaveText();
                            break;
                        case DialogResult.No:
                            e.Cancel = false;
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                        default:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\Users\\Wellcome\\Desktop\\TestCase_DacTaHinhThuc";
            openFileDialog.Filter = ".txt|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //textBoxInput.Clear();
                    TextBoxInputClear();
                    textBoxInput.Text = File.ReadAllText(openFileDialog.FileName);
                    fileName = Path.GetFileName(openFileDialog.FileName);
                    fileName = fileName.Substring(0, fileName.IndexOf("."));

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        private void SetBlankPage()
        {
            TextBoxInputClear();
            TextBoxOutputClear();
        }
        private void SaveText()
        {
            if (isSaved == false)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "C:\\Users\\Wellcome\\Desktop\\Saved_DacTaHinhThuc\\";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Text file (.txt)|*.txt";
                saveFileDialog.Title = "Save program file";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    streamWriter.Write(finalText);
                    streamWriter.Dispose();
                    streamWriter.Close();
                    isSaved = true;
                    lastSavedText = textBoxOutput.Text;
                    MessageBox.Show("Save successfully!");
                }
            }
            else
            {
                if (lastSavedText.Equals(textBoxOutput.Text))
                    MessageBox.Show("Resuilt has been saved!");
            }
        }
        private void ExitApp()
        {
            if (isSaved)
                Application.Exit();
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save change?", "Exit", MessageBoxButtons.YesNoCancel);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        SaveText();
                        break;
                    case DialogResult.No:
                        Application.Exit();
                        break;
                    case DialogResult.Cancel:
                        break;
                    default:
                        break;
                }
            }
        }
        private void HighlightText()
        {
            string[] blueWords = new string[] { "int", "float", "bool", "string", "void", "ref", "using", "public", "private", "class", "namespace",
            "new", "true","false", "static"};
            string[] purpleWords = new string[] { "for", "return", "else" };
            string[] greenWords = new string[] { "Console", "Program" };
            string[] yelloWords = new string[] { "Main", "ReadLine", "WriteLine", "Nhap_" + nameFunc, "KiemTra_" + nameFunc, nameFunc, "Xuat_" + nameFunc };

            textBoxOutput.SelectAll();

            foreach (string blue in blueWords)
            {
                int index0 = finalText.IndexOf(blue);
                if (index0 >= 0)
                {
                    while (index0 <= textBoxOutput.Text.LastIndexOf(blue))
                    {
                        textBoxOutput.Find(blue, index0, textBoxOutput.TextLength, RichTextBoxFinds.MatchCase);
                        textBoxOutput.SelectionColor = Color.Blue;
                        index0 = textBoxOutput.Text.IndexOf(blue, index0) + blue.Length;
                    }
                }
            }
            foreach (string purple in purpleWords)
            {
                int index0 = finalText.IndexOf(purple);
                if (index0 >= 0)
                {
                    while (index0 <= textBoxOutput.Text.LastIndexOf(purple))
                    {
                        textBoxOutput.Find(purple, index0, textBoxOutput.TextLength, RichTextBoxFinds.MatchCase);
                        textBoxOutput.SelectionColor = Color.Purple;
                        index0 = textBoxOutput.Text.IndexOf(purple, index0) + purple.Length;
                    }
                }
            }
            foreach (string yellow in yelloWords)
            {
                int index0 = finalText.IndexOf(yellow);
                if (index0 >= 0)
                {
                    while (index0 <= textBoxOutput.Text.LastIndexOf(yellow))
                    {
                        textBoxOutput.Find(yellow, index0, textBoxOutput.TextLength, RichTextBoxFinds.MatchCase);
                        textBoxOutput.SelectionColor = Color.FromArgb(229, 183, 49);
                        index0 = textBoxOutput.Text.IndexOf(yellow, index0) + yellow.Length;
                    }
                }
            }
            foreach (string green in greenWords)
            {
                int index0 = finalText.IndexOf(green);
                if (index0 >= 0)
                {
                    while (index0 <= textBoxOutput.Text.LastIndexOf(green))
                    {
                        textBoxOutput.Find(green, index0, textBoxOutput.TextLength, RichTextBoxFinds.MatchCase);
                        textBoxOutput.SelectionColor = Color.FromArgb(24, 132, 101);
                        index0 = textBoxOutput.Text.IndexOf(green, index0) + green.Length;
                    }
                }
            }

            //Tim chuoi nam giua 2 dau: "text"
            MatchCollection a = Regex.Matches(finalText, @"\""(.*?)\""");
            foreach (Match b in a)
            {
                int index0 = b.Index;
                string t = b.ToString();
                while (index0 <= textBoxOutput.Text.LastIndexOf(t))
                {
                    textBoxOutput.Find(t, index0, textBoxOutput.TextLength, RichTextBoxFinds.MatchCase);
                    textBoxOutput.SelectionColor = Color.FromArgb(208, 109, 5);
                    index0 = textBoxOutput.Text.IndexOf(t, index0) + t.Length;
                }
            }

            MatchCollection aa = Regex.Matches(finalText, @"\tif");
            foreach (Match b in aa)
            {
                int index0 = b.Index;
                string t = b.ToString();
                while (index0 <= textBoxOutput.Text.LastIndexOf(t))
                {
                    textBoxOutput.Find(t, index0, textBoxOutput.TextLength, RichTextBoxFinds.MatchCase);
                    textBoxOutput.SelectionColor = Color.Purple;
                    index0 = textBoxOutput.Text.IndexOf(t, index0) + t.Length;
                }
            }
        }

        private void HighlightInputText()
        {           
            string[] blueWords = new string[] { "pre", "post"};
            string[] redWords = new string[] { "R", "N", "B", "*", "Z", "char"};
            string[] brownWords = new string[] { "||", "&&"};

            string temp = textBoxInput.Text;
            temp = temp.Insert(temp.IndexOf("pre"), "\n");
            temp = temp.Insert(temp.IndexOf("pre") + 3, " ");
            temp = temp.Insert(temp.IndexOf("post"), "\n");
            temp = temp.Insert(temp.IndexOf("post") + 4, " ");
            textBoxInput.Text = temp;

            foreach (string blue in blueWords)
            {
                int index0 = textBoxInput.Text.IndexOf(blue);
                if (index0 >= 0)
                {
                    while (index0 <= textBoxInput.Text.LastIndexOf(blue))
                    {
                        textBoxInput.Find(blue, index0, textBoxInput.TextLength, RichTextBoxFinds.MatchCase);
                        textBoxInput.SelectionColor = Color.Blue;
                        index0 = textBoxInput.Text.IndexOf(blue, index0) + blue.Length;
                    }
                }
            }

            MatchCollection a = Regex.Matches(temp, @"(?<=\:)(R|N|char|B|Z)");
            foreach (Match b in a)
            {
                int index0 = b.Index;
                string t = b.ToString();
                while (index0 <= textBoxInput.Text.LastIndexOf(t))
                {
                    textBoxInput.Find(t, index0, textBoxInput.TextLength, RichTextBoxFinds.MatchCase);
                    textBoxInput.SelectionColor = Color.Red;
                    index0 = textBoxInput.Text.IndexOf(t, index0) + t.Length;
                }
            }

            foreach (string brown in brownWords)
            {
                int index0 = textBoxInput.Text.IndexOf(brown);
                if (index0 >= 0)
                {
                    while (index0 <= textBoxInput.Text.LastIndexOf(brown))
                    {
                        textBoxInput.Find(brown, index0, textBoxInput.TextLength, RichTextBoxFinds.MatchCase);
                        textBoxInput.SelectionColor = Color.FromArgb(208, 109, 5);
                        index0 = textBoxInput.Text.IndexOf(brown, index0) + brown.Length;
                    }
                }
            }
        }

        private void BackSpace(ref string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '=')
                {
                    if (str[i - 1] != '=' && str[i - 1] != ' ' && str[i - 1] != '<' && str[i - 1] != '>' && str[i - 1] != '!')
                    {
                        str = str.Insert(i, " ");
                        i++;
                    }
                    if (str[i + 1] != '=' && str[i + 1] != ' ')
                    {
                        str = str.Insert(i + 1, " ");
                    }
                }
                if (str[i] == '<')
                {
                    if (str[i - 1] != ' ')
                    {
                        str = str.Insert(i, " ");
                        i++;
                    }
                    if (str[i + 1] != '=' && str[i + 1] != ' ')
                    {
                        str = str.Insert(i + 1, " ");
                    }
                }
                if (str[i] == '>')
                {
                    if (str[i - 1] != ' ')
                    {
                        str = str.Insert(i, " ");
                        i++;
                    }
                    if (str[i + 1] != '=' && str[i + 1] != ' ')
                    {
                        str = str.Insert(i + 1, " ");
                    }
                }
                if (str[i] == '!')
                {
                    if (str[i - 1] != ' ')
                    {
                        str = str.Insert(i, " ");
                        i++;
                    }
                }
            }
        }

        private void BtnBuild_Click(object sender, EventArgs e)
        {
            if (!textBoxOutput.Text.Equals(""))
            {
                var csc = new CSharpCodeProvider();
                string path = "C:\\Users\\Wellcome\\Desktop\\TestCase_DacTaHinhThuc\\Application.exe";
                var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, path, true);
                parameters.GenerateExecutable = true;
                //var resuilt = csc.CompileAssemblyFromSource(parameters, finalText);
                Process.Start("C:\\Users\\Wellcome\\Desktop\\TestCase_DacTaHinhThuc\\Application.exe");
            }
        }

        private void Generating()
        {
            finalText = "";
            if (!textBoxInput.Text.Equals(""))
            {
                textBoxInput.Text = textBoxInput.Text.Replace(" ", "");
                textBoxInput.Text = textBoxInput.Text.Replace("\n", "");
                textBoxInput.Text = textBoxInput.Text.Replace("\t", "");

                inputStr = textBoxInput.Text;
                XuLy a = new XuLy(inputStr);
                nameFunc = a.nameFunc;

                finalText += THEME_1;
                finalText += a.HamNhap(2);
                finalText += a.HamKiemTra(2);
                finalText += a.HamXuat(2);
                finalText += a.HamXuLy(2);
                finalText += a.HamMain(2);

                finalText += "\t}\n" +
                    "}";

                BackSpace(ref finalText);

                textBoxOutput.Text = finalText;

                HighlightText();
                BackSpace(ref inputStr);
                textBoxInput.Text = inputStr;
                HighlightInputText();
            }
        }

        private void BtnTrans_Click(object sender, EventArgs e)
        {
            Generating();
            isSaved = false;
        }

        private void BtnGenerating_Click(object sender, EventArgs e)
        {
            Generating();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.ShowDialog();
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            textBoxInput.Undo();
            textBoxOutput.Undo();
        }
        private void BtnRedo_Click(object sender, EventArgs e)
        {
            textBoxInput.Redo();
            textBoxOutput.Redo();
        }
        private void TextBoxInputClear()
        {
            textBoxInput.Clear();
        }
        private void TextBoxOutputClear()
        {
            textBoxOutput.Clear();
        }
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCut_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void CutText()
        {
            if (textBoxInput.SelectionLength != 0)
            {
                Clipboard.SetText(textBoxInput.SelectedText);
                textBoxInput.SelectedText = "";
            }
        }
        private void CopyText()
        {
            if (textBoxInput.SelectionLength != 0)
            {
                Clipboard.SetText(textBoxInput.SelectedText);
            }
            if (textBoxOutput.SelectionLength != 0)
            {
                Clipboard.SetText(textBoxOutput.SelectedText);
            }
        }
        private void PasteText()
        {
            if (textBoxInput.ContainsFocus)
            {
                textBoxInput.SelectedText = Clipboard.GetText();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxInput.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxInput.Redo();
        }
    }
}
