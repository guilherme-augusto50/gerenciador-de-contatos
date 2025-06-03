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
    public partial class TelaPrincipal : Form
    {
        private int idusuario;
        private string nome;
        public TelaPrincipal(int idusuario, string nome)
        {
            InitializeComponent();
            this.idusuario = idusuario;
            this.nome = nome;

            Contatos contato = new Contatos();
            lblusuarios.Text = "Usuário: " + nome; // Exibindo o nome do usuário logado na tela principal
            contato.Id_usuario = idusuario; // Associando o ID do usuário logado ao objeto contato

            dataContatos.DataSource = contato.Listar(); // Carregando os contatos do usuário logado na DataGridView

        }
        private void atualizargrid()
        {
            Contatos contato = new Contatos();
            contato.Id_usuario = idusuario; // Associando o ID do usuário logado ao objeto contato
            dataContatos.DataSource = contato.Listar(); // Atualizando a DataGridView com os contatos do usuário logado

        }
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Contatos contato = new Contatos();
                contato.Id_usuario = idusuario; // Associando o ID do usuário logado ao objeto contato
                atualizargrid(); // Atualizando a DataGridView com os contatos do usuário logado
                dataContatos.DataSource = contato.Listar(); // Carregando os contatos do usuário logado na DataGridView
                dataContatos.AllowUserToAddRows = false; // Desabilita a adição de novas linhas pelo usuário no DataGridView
                dataContatos.ReadOnly = true; // Define o DataGridView como somente leitura para evitar edições diretas
                dataContatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta as colunas para preencher o espaço disponível
                dataContatos.AutoResizeColumns(); // Redimensiona as colunas para se ajustarem ao conteúdo
                dataContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Define o modo de seleção para linha inteira
                dataContatos.MultiSelect = false; // Desabilita a seleção múltipla de linhas no DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a tela principal: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmail.Text.Equals("") && !txtNome.Text.Equals("") && !txtTelefone.Text.Equals(""))
                {
                    Contatos contato = new Contatos();
                    contato.Nome = txtNome.Text;
                    contato.Telefone = txtTelefone.Text;
                    contato.Email = txtEmail.Text;
                    contato.Id_usuario = idusuario; // Associando o ID do usuário logado
                    contato.InserirContato();
                    MessageBox.Show("Contato inserido com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizargrid(); // Atualizando a DataGridView após a inserção do contato
                    txtNome.Clear(); // Limpando o campo de nome após a inserção
                    txtTelefone.Clear(); // Limpando o campo de telefone após a inserção
                    txtEmail.Clear(); // Limpando o campo de email após a inserção
                    dataContatos.ClearSelection(); // Limpando a seleção do DataGridView após a inserção
                    dataContatos.ClearSelection();
                    dataContatos.AllowUserToAddRows = false; // Desabilita a adição de novas linhas pelo usuário no DataGridView
                    dataContatos.ReadOnly = true; // Define o DataGridView como somente leitura para evitar edições diretas
                    dataContatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta as colunas para preencher o espaço disponível
                    dataContatos.AutoResizeColumns(); // Redimensiona as colunas para se ajustarem ao conteúdo
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir contato: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide(); // Esconde a tela principal ao deslogar
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtEmail.Text.Equals("") && !txtNome.Text.Equals("") && !txtTelefone.Text.Equals(""))
                {
                    Contatos contatos = new Contatos();
                    contatos.Id_usuario = idusuario; // Associando o ID do usuário logado ao objeto contato
                    contatos.Id_contato = Convert.ToInt32(txtID.Text); // Obtendo o ID do contato a ser editado
                    contatos.Nome = txtNome.Text;
                    contatos.Telefone = txtTelefone.Text;
                    contatos.Email = txtEmail.Text;

                    contatos.Atualizar(); // Atualizando o contato com os novos dados
                    MessageBox.Show("Contato editado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizargrid(); // Atualizando a DataGridView após a edição do contato
                    txtNome.Clear(); // Limpando o campo de nome após a edição
                    txtTelefone.Clear(); // Limpando o campo de telefone após a edição
                    txtEmail.Clear(); // Limpando o campo de email após a edição
                    dataContatos.ClearSelection(); // Limpando a seleção do DataGridView após a edição
                    dataContatos.ClearSelection();
                    dataContatos.AllowUserToAddRows = false; // Desabilita a adição de novas linhas pelo usuário no DataGridView
                    dataContatos.ReadOnly = true; // Define o DataGridView como somente leitura para evitar edições diretas
                    dataContatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta as colunas para preencher o espaço disponível
                    dataContatos.AutoResizeColumns(); // Redimensiona as colunas para se ajustarem ao 
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar contato: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int id_contato_selecionado = 0;
        private void dataContatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataContatos.Rows[e.RowIndex];
                    txtID.Text = row.Cells["Id_contatos"].Value.ToString();
                    txtNome.Text = row.Cells["nome"].Value.ToString();
                    txtTelefone.Text = row.Cells["telefone"].Value.ToString();
                    txtEmail.Text = row.Cells["email"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar contato: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int id_contato_excluir = 0;
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try {
                if (id_contato_excluir >= 0)
                {
                    Contatos contatos = new Contatos();
                    var result = MessageBox.Show("Deseja realmente excluir o contato selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        contatos.Id_contato = Convert.ToInt32(txtID.Text); // Obtendo o ID do contato a ser excluído
                        contatos.Id_usuario = idusuario; // Associando o ID do usuário logado ao objeto contato
                        contatos.Excluir(); // Excluindo o contato
                        MessageBox.Show("Contato excluído com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        atualizargrid(); // Atualizando a DataGridView após a exclusão do contato
                        txtID.Clear(); // Limpando o campo de ID após a exclusão
                        txtNome.Clear(); // Limpando o campo de nome após a exclusão
                        txtTelefone.Clear(); // Limpando o campo de telefone após a exclusão
                        txtEmail.Clear(); // Limpando o campo de email após a exclusão
                    }
                    else
                    {
                        if (result == DialogResult.No)
                        {
                            MessageBox.Show("Exclusão cancelada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            atualizargrid(); // Atualizando a DataGridView após o cancelamento da exclusão
                            txtID.Clear();
                            txtNome.Clear(); // Limpando o campo de nome após o cancelamento da exclusão
                            txtTelefone.Clear(); // Limpando o campo de telefone após o cancelamento da exclusão
                            txtEmail.Clear();// Limpando o campo de email após o cancelamento da exclusão
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um contato para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir contato: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
