namespace TontonPrimeur.Articles
{
    partial class FormModifArticle
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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(98, 138);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Fruit", "Legume" });
            comboBox1.Location = new Point(98, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(123, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 141);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 18;
            label5.Text = "Fournisseur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 112);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 17;
            label4.Text = "Quantité";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 83);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 16;
            label3.Text = "Prix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 54);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 15;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 14;
            label1.Text = "Nom";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(98, 109);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 24;
            // 
            // FormModifArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 210);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormModifArticle";
            Text = "FormModifArticle";
            Load += FormModifArticle_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
    }
}