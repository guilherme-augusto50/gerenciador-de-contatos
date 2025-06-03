using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciador_de_contatos
{
    class Contatos
    {
        private int id_contato;
        private string nome;
        private string telefone;
        private string email;
        private int id_usuario;

        public int Id_contato
        {
            get { return id_contato; }
            set { id_contato = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        // Inserir Contato
        public void InserirContato()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDB().Conectar())
                {
                    string query = "INSERT INTO contatos (nome, telefone, email, Id_usuario) VALUES (@nome, @telefone, @email, @Id_usuario)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", Nome);
                        cmd.Parameters.AddWithValue("@telefone", Telefone);
                        cmd.Parameters.AddWithValue("@email", Email);
                        cmd.Parameters.AddWithValue("@Id_usuario", Id_usuario);
                        int resultado = cmd.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            Console.WriteLine("Contato inserido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao inserir contato.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir contato: " + ex.Message);
            }
        }

        // Listar Contatos
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conexao = new ConexaoDB().Conectar())
                {
                    string query = "SELECT Id_contatos, nome, email, telefone FROM contatos WHERE Id_usuario = @Id_usuario";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id_usuario", Id_usuario);
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar contatos: " + ex.Message);
            }
            return dt;
        }

        // Atualizar Contato
        public void Atualizar()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDB().Conectar())
                {
                    string query = "UPDATE contatos SET nome = @nome, telefone = @telefone, email = @email WHERE Id_contatos = @id_contato AND Id_usuario = @Id_usuario";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", Nome);
                        cmd.Parameters.AddWithValue("@telefone", Telefone);
                        cmd.Parameters.AddWithValue("@email", Email);
                        cmd.Parameters.AddWithValue("@id_contato", Id_contato);
                        cmd.Parameters.AddWithValue("@Id_usuario", Id_usuario);
                        int resultado = cmd.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            Console.WriteLine("Contato atualizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao atualizar contato. Verifique se o ID está correto.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar contato: " + ex.Message);
            }
        }

        // Excluir Contato
        public void Excluir()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDB().Conectar())
                {
                    string query = "DELETE FROM contatos WHERE Id_contatos = @id_contato AND Id_usuario = @Id_usuario";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id_contato", Id_contato);
                        cmd.Parameters.AddWithValue("@Id_usuario", Id_usuario);
                        int resultado = cmd.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            Console.WriteLine("Contato excluído com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao excluir contato. Verifique se o ID está correto.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir contato: " + ex.Message);
            }
        }
    }
}
