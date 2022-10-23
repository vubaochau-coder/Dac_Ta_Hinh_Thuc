namespace Dac_Ta_Hinh_Thuc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnGenerating = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnBlank = new System.Windows.Forms.ToolStripButton();
            this.BtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnUndo = new System.Windows.Forms.ToolStripButton();
            this.BtnRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.textBox_program = new System.Windows.Forms.TextBox();
            this.textBox_exe = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnTrans = new Dac_Ta_Hinh_Thuc.CustomControl.RadiusButton();
            this.BtnBuild = new Dac_Ta_Hinh_Thuc.CustomControl.RadiusButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnFile,
            this.BtnEdit,
            this.BtnGenerating,
            this.BtnAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1578, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnFile
            // 
            this.BtnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_New,
            this.MenuItem_Open,
            this.toolStripSeparator3,
            this.MenuItem_Save,
            this.toolStripSeparator4,
            this.MenuItem_Exit});
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(58, 32);
            this.BtnFile.Text = "File";
            // 
            // MenuItem_New
            // 
            this.MenuItem_New.Name = "MenuItem_New";
            this.MenuItem_New.ShortcutKeyDisplayString = "";
            this.MenuItem_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MenuItem_New.Size = new System.Drawing.Size(234, 36);
            this.MenuItem_New.Text = "&New";
            this.MenuItem_New.Click += new System.EventHandler(this.MenuItem_New_Click);
            // 
            // MenuItem_Open
            // 
            this.MenuItem_Open.Name = "MenuItem_Open";
            this.MenuItem_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItem_Open.Size = new System.Drawing.Size(234, 36);
            this.MenuItem_Open.Text = "&Open";
            this.MenuItem_Open.Click += new System.EventHandler(this.MenuItem_Open_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(231, 6);
            // 
            // MenuItem_Save
            // 
            this.MenuItem_Save.Name = "MenuItem_Save";
            this.MenuItem_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItem_Save.Size = new System.Drawing.Size(234, 36);
            this.MenuItem_Save.Text = "&Save";
            this.MenuItem_Save.Click += new System.EventHandler(this.MenuItem_Save_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(231, 6);
            // 
            // MenuItem_Exit
            // 
            this.MenuItem_Exit.Name = "MenuItem_Exit";
            this.MenuItem_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuItem_Exit.Size = new System.Drawing.Size(234, 36);
            this.MenuItem_Exit.Text = "E&xit";
            this.MenuItem_Exit.Click += new System.EventHandler(this.MenuItem_Exit_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(62, 32);
            this.BtnEdit.Text = "Edit";
            // 
            // BtnGenerating
            // 
            this.BtnGenerating.Name = "BtnGenerating";
            this.BtnGenerating.Size = new System.Drawing.Size(125, 32);
            this.BtnGenerating.Text = "Generating";
            // 
            // BtnAbout
            // 
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(83, 32);
            this.BtnAbout.Text = "About";
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnBlank,
            this.BtnOpenFile,
            this.BtnSave,
            this.toolStripSeparator1,
            this.BtnUndo,
            this.BtnRedo,
            this.toolStripSeparator2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1578, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnBlank
            // 
            this.BtnBlank.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnBlank.Image = ((System.Drawing.Image)(resources.GetObject("BtnBlank.Image")));
            this.BtnBlank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBlank.Margin = new System.Windows.Forms.Padding(0, 2, 8, 3);
            this.BtnBlank.Name = "BtnBlank";
            this.BtnBlank.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnBlank.Size = new System.Drawing.Size(38, 32);
            this.BtnBlank.Text = "toolStripButton1";
            this.BtnBlank.ToolTipText = "Blank Page";
            this.BtnBlank.Click += new System.EventHandler(this.BtnBlank_Click);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpenFile.Image")));
            this.BtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpenFile.Margin = new System.Windows.Forms.Padding(0, 2, 8, 3);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOpenFile.Size = new System.Drawing.Size(38, 32);
            this.BtnOpenFile.Text = "toolStripButton3";
            this.BtnOpenFile.ToolTipText = "Open";
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0, 2, 8, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnSave.Size = new System.Drawing.Size(38, 32);
            this.BtnSave.Text = "toolStripButton2";
            this.BtnSave.ToolTipText = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // BtnUndo
            // 
            this.BtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnUndo.Margin = new System.Windows.Forms.Padding(0, 2, 8, 3);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(65, 32);
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnRedo
            // 
            this.BtnRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnRedo.Image = ((System.Drawing.Image)(resources.GetObject("BtnRedo.Image")));
            this.BtnRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRedo.Margin = new System.Windows.Forms.Padding(0, 2, 8, 3);
            this.BtnRedo.Name = "BtnRedo";
            this.BtnRedo.Size = new System.Drawing.Size(61, 32);
            this.BtnRedo.Text = "Redo";
            this.BtnRedo.Click += new System.EventHandler(this.BtnRedo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 2, 8, 3);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 32);
            this.toolStripLabel1.Text = "C#";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(2, 2);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(909, 741);
            this.textBoxOutput.TabIndex = 3;
            this.textBoxOutput.Text = "";
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(37, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Class name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(37, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Exe file name:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(12, 219);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(615, 613);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.Text = "";
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBox_program
            // 
            this.textBox_program.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_program.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_program.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_program.Location = new System.Drawing.Point(179, 110);
            this.textBox_program.Multiline = true;
            this.textBox_program.Name = "textBox_program";
            this.textBox_program.ReadOnly = true;
            this.textBox_program.Size = new System.Drawing.Size(180, 32);
            this.textBox_program.TabIndex = 13;
            this.textBox_program.Text = " Program";
            // 
            // textBox_exe
            // 
            this.textBox_exe.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_exe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_exe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_exe.ForeColor = System.Drawing.Color.Indigo;
            this.textBox_exe.Location = new System.Drawing.Point(179, 161);
            this.textBox_exe.Multiline = true;
            this.textBox_exe.Name = "textBox_exe";
            this.textBox_exe.ReadOnly = true;
            this.textBox_exe.Size = new System.Drawing.Size(180, 32);
            this.textBox_exe.TabIndex = 14;
            this.textBox_exe.Text = " Application.exe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Location = new System.Drawing.Point(10, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 617);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.textBoxOutput);
            this.panel2.Location = new System.Drawing.Point(644, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 745);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Location = new System.Drawing.Point(177, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 36);
            this.panel3.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Location = new System.Drawing.Point(177, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 36);
            this.panel4.TabIndex = 18;
            // 
            // BtnTrans
            // 
            this.BtnTrans.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnTrans.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnTrans.BorderColor = System.Drawing.Color.Indigo;
            this.BtnTrans.BorderRadius = 15;
            this.BtnTrans.BorderSize = 2;
            this.BtnTrans.FlatAppearance.BorderSize = 0;
            this.BtnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrans.ForeColor = System.Drawing.Color.White;
            this.BtnTrans.Location = new System.Drawing.Point(394, 155);
            this.BtnTrans.Name = "BtnTrans";
            this.BtnTrans.Size = new System.Drawing.Size(170, 44);
            this.BtnTrans.TabIndex = 12;
            this.BtnTrans.Text = "Trans";
            this.BtnTrans.TextColor = System.Drawing.Color.White;
            this.BtnTrans.UseVisualStyleBackColor = false;
            this.BtnTrans.Click += new System.EventHandler(this.BtnTrans_Click);
            // 
            // BtnBuild
            // 
            this.BtnBuild.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuild.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnBuild.BorderColor = System.Drawing.Color.Indigo;
            this.BtnBuild.BorderRadius = 15;
            this.BtnBuild.BorderSize = 2;
            this.BtnBuild.FlatAppearance.BorderSize = 0;
            this.BtnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuild.ForeColor = System.Drawing.Color.White;
            this.BtnBuild.Location = new System.Drawing.Point(394, 104);
            this.BtnBuild.Name = "BtnBuild";
            this.BtnBuild.Size = new System.Drawing.Size(170, 44);
            this.BtnBuild.TabIndex = 11;
            this.BtnBuild.Text = "Build Solution";
            this.BtnBuild.TextColor = System.Drawing.Color.White;
            this.BtnBuild.UseVisualStyleBackColor = false;
            this.BtnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.textBox_exe);
            this.Controls.Add(this.textBox_program);
            this.Controls.Add(this.BtnTrans);
            this.Controls.Add(this.BtnBuild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formular Specification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnFile;
        private System.Windows.Forms.ToolStripMenuItem BtnEdit;
        private System.Windows.Forms.ToolStripMenuItem BtnGenerating;
        private System.Windows.Forms.ToolStripMenuItem BtnAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnBlank;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_New;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Exit;
        private System.Windows.Forms.ToolStripButton BtnOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnUndo;
        private System.Windows.Forms.ToolStripButton BtnRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.RichTextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private CustomControl.RadiusButton BtnBuild;
        private CustomControl.RadiusButton BtnTrans;
        private System.Windows.Forms.TextBox textBox_program;
        private System.Windows.Forms.TextBox textBox_exe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

