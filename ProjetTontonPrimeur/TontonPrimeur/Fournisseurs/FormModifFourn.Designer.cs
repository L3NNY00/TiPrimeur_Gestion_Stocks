namespace TontonPrimeur.Fournisseurs
{
    partial class FormModifFourn
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
            textBox2 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 31;
            // 
            // button1
            // 
            button1.Location = new Point(127, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 30;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(102, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 29;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 126);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 27;
            label5.Text = "Adresse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 97);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 26;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 68);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 25;
            label3.Text = "Téléphone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 39);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 24;
            label1.Text = "Nom";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 23;
            // 
            // FormModifFourn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 207);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormModifFourn";
            Text = "FormModifFourn";
            Load += FormModifFourn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
    }
}