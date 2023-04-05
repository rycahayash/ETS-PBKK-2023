namespace MoneyConverter
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(209, 35);
            label1.Name = "label1";
            label1.Size = new Size(359, 47);
            label1.TabIndex = 0;
            label1.Text = "Money Converter";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 114);
            label2.Name = "label2";
            label2.Size = new Size(178, 23);
            label2.TabIndex = 1;
            label2.Text = "Mata Uang Awal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 152);
            label3.Name = "label3";
            label3.Size = new Size(206, 23);
            label3.TabIndex = 2;
            label3.Text = "Mata Uang Konversi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 189);
            label4.Name = "label4";
            label4.Size = new Size(185, 23);
            label4.TabIndex = 3;
            label4.Text = "Masukkan Jumlah";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.CadetBlue;
            label5.Location = new Point(281, 327);
            label5.Name = "label5";
            label5.Size = new Size(214, 37);
            label5.TabIndex = 4;
            label5.Text = "Hasil Konversi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(108, 373);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 5;
            label6.Text = "Mata Uang";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(453, 373);
            label7.Name = "label7";
            label7.Size = new Size(82, 23);
            label7.TabIndex = 6;
            label7.Text = "Jumlah";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(281, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(406, 32);
            textBox1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ControlLightLight;
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(281, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(406, 31);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ControlLightLight;
            comboBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(281, 152);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(406, 31);
            comboBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(561, 236);
            button1.Name = "button1";
            button1.Size = new Size(126, 43);
            button1.TabIndex = 10;
            button1.Text = "Konversi";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLightLight;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(61, 399);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 32);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLightLight;
            textBox3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(281, 396);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(406, 32);
            textBox3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(777, 496);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}