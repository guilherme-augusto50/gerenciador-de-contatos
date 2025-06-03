namespace gerenciador_de_contatos
{
    partial class Cadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnCadastrese = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 94);
            label1.Name = "label1";
            label1.Size = new Size(54, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 144);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 194);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(172, 308);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(70, 18);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "tela login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(129, 115);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(153, 26);
            txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(153, 26);
            txtEmail.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(129, 215);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(153, 26);
            txtSenha.TabIndex = 6;
            // 
            // btnCadastrese
            // 
            btnCadastrese.Location = new Point(145, 272);
            btnCadastrese.Name = "btnCadastrese";
            btnCadastrese.Size = new Size(119, 33);
            btnCadastrese.TabIndex = 7;
            btnCadastrese.Text = "Cadastra-se";
            btnCadastrese.UseVisualStyleBackColor = true;
            btnCadastrese.Click += button1_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 497);
            Controls.Add(btnCadastrese);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosing += Cadastro_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnCadastrese;
    }
}