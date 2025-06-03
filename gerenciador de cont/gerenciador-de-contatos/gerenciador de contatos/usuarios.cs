using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciador_de_contatos
{
    class usuarios
    {
        private int id;
        private string nome;
        private string email;
        private string senha;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public void inserir()
        {
            try {
                using (MySqlConnection conexao = new ConexaoDB().Conectar())
                {
                    string query = "INSERT INTO usuarios (nome, email, senha) VALUES (@nome, @email, @senha)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", Nome);
                        cmd.Parameters.AddWithValue("@email", Email);
                        cmd.Parameters.AddWithValue("@senha", Senha);
                        int resultado = cmd.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            Console.WriteLine("Usuário inserido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao inserir usuário.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir usuário: " + ex.Message);
            }
        }
        public bool logar()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoDB().Conectar())
                {
                    string query = "SELECT Id_usuario, nome FROM usuarios WHERE email = @Email AND senha = @Senha";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@Senha", Senha);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                id = reader.GetInt32("Id_usuario");
                                nome = reader.GetString("nome");
                                Console.WriteLine("Usuário logado com sucesso: " + Nome);
                                return true;
                            }
                            else
                            {
                                Console.WriteLine("Usuário ou senha inválidos.");
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao logar usuário: " + ex.Message);
            }
        }
    }
}
