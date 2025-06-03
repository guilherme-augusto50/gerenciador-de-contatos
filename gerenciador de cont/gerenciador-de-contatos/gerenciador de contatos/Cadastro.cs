using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciador_de_contatos
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    usuarios usuarios = new usuarios();

                    usuarios.Nome = txtNome.Text;
                    usuarios.Email = txtEmail.Text;
                    usuarios.Senha = txtSenha.Text;

                    usuarios.inserir();
                    MessageBox.Show("Usuário cadastrado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login login = new login();
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    txtNome.Focus();
                    txtSenha.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Fecha a aplicação ao fechar o formulário de cadastro
        }
    }
}
