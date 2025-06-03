namespace gerenciador_de_contatos
{
    partial class TelaPrincipal
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
            lblusuarios = new Label();
            dataContatos = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new MaskedTextBox();
            btnInserir = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnDeslogar = new Button();
            label1 = new Label();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataContatos).BeginInit();
            SuspendLayout();
            // 
            // lblusuarios
            // 
            lblusuarios.AutoSize = true;
            lblusuarios.Location = new Point(401, 9);
            lblusuarios.Name = "lblusuarios";
            lblusuarios.Size = new Size(150, 27);
            lblusuarios.TabIndex = 0;
            lblusuarios.Text = "<<Usuario>>";
            // 
            // dataContatos
            // 
            dataContatos.AllowUserToAddRows = false;
            dataContatos.AllowUserToDeleteRows = false;
            dataContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataContatos.Location = new Point(12, 62);
            dataContatos.Name = "dataContatos";
            dataContatos.ReadOnly = true;
            dataContatos.RowHeadersWidth = 62;
            dataContatos.Size = new Size(978, 200);
            dataContatos.TabIndex = 1;
            dataContatos.CellContentDoubleClick += dataContatos_CellContentDoubleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(645, 287);
            label3.Name = "label3";
            label3.Size = new Size(79, 27);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 373);
            label4.Name = "label4";
            label4.Size = new Size(82, 27);
            label4.TabIndex = 4;
            label4.Text = "Nome:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(645, 382);
            label5.Name = "label5";
            label5.Size = new Size(109, 27);
            label5.TabIndex = 5;
            label5.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(64, 403);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(225, 35);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(645, 317);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 35);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(645, 403);
            txtTelefone.Mask = "00 (00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(219, 35);
            txtTelefone.TabIndex = 3;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(64, 485);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(115, 43);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(390, 485);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(128, 43);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(713, 485);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(109, 43);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnDeslogar
            // 
            btnDeslogar.Location = new Point(836, 0);
            btnDeslogar.Name = "btnDeslogar";
            btnDeslogar.Size = new Size(154, 44);
            btnDeslogar.TabIndex = 10;
            btnDeslogar.Text = "Deslogar";
            btnDeslogar.UseVisualStyleBackColor = true;
            btnDeslogar.Click += btnDeslogar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 287);
            label1.Name = "label1";
            label1.Size = new Size(42, 27);
            label1.TabIndex = 11;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(64, 320);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(47, 35);
            txtID.TabIndex = 12;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1002, 573);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(btnDeslogar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnInserir);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataContatos);
            Controls.Add(lblusuarios);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            FormClosing += TelaPrincipal_FormClosing;
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dataContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusuarios;
        private DataGridView dataContatos;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtEmail;
        private MaskedTextBox txtTelefone;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnDeslogar;
        private Label label1;
        private TextBox txtID;
    }
}