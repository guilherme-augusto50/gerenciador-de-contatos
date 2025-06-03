namespace gerenciador_de_contatos
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("")) 
                {
                    usuarios usuarios = new usuarios();
                    usuarios.Nome = textBox1.Text;
                    usuarios.Email = textBox2.Text;
                    usuarios.Senha = textBox3.Text;
                    if (usuarios.logar())
                    {
                        MessageBox.Show("Login realizado com sucesso! Bem vindo " + usuarios.Nome, "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TelaPrincipal telaPrincipal = new TelaPrincipal(usuarios.Id, usuarios.Nome);
                        telaPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Focus();
                        textBox2.Focus();
                        textBox3.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
