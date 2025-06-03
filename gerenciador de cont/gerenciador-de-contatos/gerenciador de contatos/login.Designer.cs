namespace gerenciador_de_contatos
{
    partial class login
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 117);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 167);
            label2.Name = "label2";
            label2.Size = new Size(57, 18);
            label2.TabIndex = 1;
            label2.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 217);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 26);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 26);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 238);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(154, 26);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(156, 270);
            button1.Name = "button1";
            button1.Size = new Size(110, 26);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(171, 322);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(95, 18);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cadastre-se";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 497);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}
