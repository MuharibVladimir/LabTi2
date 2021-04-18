
namespace Ti_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxKo = new System.Windows.Forms.TextBox();
            this.textBoxKs = new System.Windows.Forms.TextBox();
            this.BtnEncr = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(50, 44);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(687, 53);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(50, 341);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(687, 61);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(50, 197);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(90, 23);
            this.textBoxP.TabIndex = 2;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(200, 197);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(94, 23);
            this.textBoxQ.TabIndex = 3;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(350, 197);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(94, 23);
            this.textBoxR.TabIndex = 4;
            // 
            // textBoxKo
            // 
            this.textBoxKo.Location = new System.Drawing.Point(498, 197);
            this.textBoxKo.Name = "textBoxKo";
            this.textBoxKo.Size = new System.Drawing.Size(94, 23);
            this.textBoxKo.TabIndex = 5;
            this.textBoxKo.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBoxKs
            // 
            this.textBoxKs.Location = new System.Drawing.Point(643, 197);
            this.textBoxKs.Name = "textBoxKs";
            this.textBoxKs.Size = new System.Drawing.Size(94, 23);
            this.textBoxKs.TabIndex = 6;
            // 
            // BtnEncr
            // 
            this.BtnEncr.Location = new System.Drawing.Point(166, 254);
            this.BtnEncr.Name = "BtnEncr";
            this.BtnEncr.Size = new System.Drawing.Size(161, 47);
            this.BtnEncr.TabIndex = 7;
            this.BtnEncr.Text = "Зашифровать";
            this.BtnEncr.UseVisualStyleBackColor = true;
            this.BtnEncr.Click += new System.EventHandler(this.BtnEncr_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(453, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Расшифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Сгенерировать параметры шифрования",
            "Использовать параметры шифрования пользователя"});
            this.comboBox.Location = new System.Drawing.Point(224, 135);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(347, 23);
            this.comboBox.TabIndex = 9;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Результат шифровки/расшифровки текста";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите текст для шифровки/расшифровки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "p";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "q";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "r";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Коткр";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ксек";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnEncr);
            this.Controls.Add(this.textBoxKs);
            this.Controls.Add(this.textBoxKo);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxKo;
        private System.Windows.Forms.TextBox textBoxKs;
        private System.Windows.Forms.Button BtnEncr;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

