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
        
        public Form1()
        {
            isSaved = true;
            fileName = "";
            lastSavedText = "";
            
            InitializeComponent();
        }

        private void BtnBlank_Click(object sender, EventArgs e)
        {
            SetBlankPage();
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
            if(e.CloseReason == CloseReason.UserClosing)
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
            //textBoxInput.Clear();
            //textBoxOutput.Clear();
            //textBoxInput.Text = "";
            //textBoxOutput.Text = "";
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

            //int index = 0;
            textBoxOutput.SelectAll();
            //while(index<textBoxOutput.Text.LastIndexOf("static"))
            //{
            //    textBoxOutput.Find("static", index, textBoxOutput.TextLength, RichTextBoxFinds.MatchCase);
            //    textBoxOutput.SelectionColor = Color.Blue;
            //    index = textBoxOutput.Text.IndexOf("static", index) + 1;
            //}

            foreach(string blue in blueWords)
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

        private void BackSpace()
        {
            for (int i = 0; i < finalText.Length; i++) 
            {
                if (finalText[i] == '=') 
                {
                    if (finalText[i - 1] != '=' && finalText[i - 1] != ' ' && finalText[i - 1] != '<' && finalText[i - 1] != '>' && finalText[i - 1] != '!')
                    {
                        finalText = finalText.Insert(i, " ");
                        i++;
                    }
                    if (finalText[i + 1] != '=' && finalText[i + 1]!= ' ')
                    {
                        finalText = finalText.Insert(i + 1, " ");
                    }    
                }
                if (finalText[i] == '<') 
                {
                    if (finalText[i - 1] != ' ') 
                    {
                        finalText = finalText.Insert(i, " ");
                        i++;
                    }
                    if (finalText[i + 1] != '=' && finalText[i + 1] != ' ')
                    {
                        finalText = finalText.Insert(i + 1, " ");
                    }
                }
                if (finalText[i] == '>') 
                {
                    if (finalText[i - 1] != ' ')
                    {
                        finalText = finalText.Insert(i, " ");
                        i++;
                    }
                    if (finalText[i + 1] != '=' && finalText[i + 1] != ' ')
                    {
                        finalText = finalText.Insert(i + 1, " ");
                    }
                }
                if (finalText[i] == '!')
                {
                    if (finalText[i - 1] != ' ')
                    {
                        finalText = finalText.Insert(i, " ");
                        i++;
                    }
                }
            }
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            Form about = new AboutForm();
            about.ShowDialog();
        }

        private void BtnBuild_Click(object sender, EventArgs e)
        {
            if (!textBoxOutput.Text.Equals(""))
            {
                var csc = new CSharpCodeProvider();
                string path = "C:\\Users\\Wellcome\\Desktop\\TestCase_DacTaHinhThuc\\Application.exe";
                var parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, path, true);
                parameters.GenerateExecutable = true;
                var resuilt = csc.CompileAssemblyFromSource(parameters, finalText);
                Process.Start("C:\\Users\\Wellcome\\Desktop\\TestCase_DacTaHinhThuc\\Application.exe");
            }
        }

        private void BtnTrans_Click(object sender, EventArgs e)
        {
            //textBoxOutput.Clear();
            //textBoxOutput.Text = "";
            finalText = "";
            if (!textBoxInput.Text.Equals(""))
            {
                inputStr = textBoxInput.Text.Replace(" ", "");

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

                BackSpace();
                textBoxOutput.Text = finalText;

                HighlightText();
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            
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
            textBoxInput.Focus();
            textBoxInput.SelectAll();
            SendKeys.Send("{BACKSPACE}");
        }
        private void TextBoxOutputClear()
        {
            textBoxOutput.Focus();
            textBoxOutput.SelectAll();
            SendKeys.Send("{BACKSPACE}");
        }
    }
}
