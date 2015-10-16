namespace AES_CRYPT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.texta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.anstext = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb1hash = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cb2len = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.salt0 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // texta
            // 
            this.texta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texta.Location = new System.Drawing.Point(12, 25);
            this.texta.Name = "texta";
            this.texta.Size = new System.Drawing.Size(280, 20);
            this.texta.TabIndex = 0;
            this.texta.Text = "Hello, World!";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(192, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pass1
            // 
            this.pass1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pass1.Location = new System.Drawing.Point(12, 78);
            this.pass1.Name = "pass1";
            this.pass1.PasswordChar = '*';
            this.pass1.Size = new System.Drawing.Size(120, 20);
            this.pass1.TabIndex = 3;
            this.pass1.Text = "1488";
            // 
            // anstext
            // 
            this.anstext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anstext.Cursor = System.Windows.Forms.Cursors.Cross;
            this.anstext.Location = new System.Drawing.Point(12, 158);
            this.anstext.Multiline = true;
            this.anstext.Name = "anstext";
            this.anstext.ReadOnly = true;
            this.anstext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.anstext.Size = new System.Drawing.Size(280, 131);
            this.anstext.TabIndex = 8;
            this.anstext.WordWrap = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.checkBox1.Location = new System.Drawing.Point(223, 79);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Decrypt?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите текст и пароль для шифрования";
            // 
            // cb1hash
            // 
            this.cb1hash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1hash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb1hash.FormattingEnabled = true;
            this.cb1hash.Items.AddRange(new object[] {
            "SHA1",
            "MD5"});
            this.cb1hash.Location = new System.Drawing.Point(138, 52);
            this.cb1hash.Name = "cb1hash";
            this.cb1hash.Size = new System.Drawing.Size(73, 21);
            this.cb1hash.TabIndex = 1;
            this.cb1hash.SelectedIndexChanged += new System.EventHandler(this.cb1hash_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 104);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(174, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // cb2len
            // 
            this.cb2len.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2len.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb2len.FormattingEnabled = true;
            this.cb2len.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.cb2len.Location = new System.Drawing.Point(217, 52);
            this.cb2len.Name = "cb2len";
            this.cb2len.Size = new System.Drawing.Size(75, 21);
            this.cb2len.TabIndex = 2;
            this.cb2len.SelectedIndexChanged += new System.EventHandler(this.cb2len_SelectedIndexChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.AsciiOnly = true;
            this.maskedTextBox1.HidePromptOnLeave = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 52);
            this.maskedTextBox1.Mask = "AAAAAAAAAAAAAAAA";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(120, 20);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.TabStop = false;
            this.maskedTextBox1.Text = "SCHOOL2283221488";
            // 
            // salt0
            // 
            this.salt0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salt0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salt0.Location = new System.Drawing.Point(138, 78);
            this.salt0.Name = "salt0";
            this.salt0.Size = new System.Drawing.Size(73, 20);
            this.salt0.TabIndex = 4;
            this.salt0.Text = "salted";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 301);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.cb2len);
            this.Controls.Add(this.cb1hash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.anstext);
            this.Controls.Add(this.salt0);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "AES";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.TextBox anstext;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb1hash;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox cb2len;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox salt0;
    }
}

