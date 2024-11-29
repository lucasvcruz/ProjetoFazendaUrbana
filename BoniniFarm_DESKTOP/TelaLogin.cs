using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace BoniniFarm2
{
    public partial class TelaLogin : Form
    {
        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";
        Thread nt;

        public TelaLogin()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true; // Esconde o texto digitado da senha
            this.AcceptButton = btnEntrarConta;
        }

        private void btnEntrarConta_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            if (AutenticarUsuario(email, senha))
            {
                var (matricula, cargo, status) = MatriculaUsuario(email);

                if (status == "Inativa")
                {
                    MessageBox.Show("Usuário inativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Clear();
                    txtSenha.Clear();
                    return;
                }

                // Abre a tela apropriada de acordo com o cargo
                if (cargo == "Vendedor")
                {
                    AbrirNovaTela(new TelaVenda(matricula));
                }
                else if (cargo == "Gerente de Operacoes")
                {
                    DialogResult resultado = MessageBox.Show("Você deseja abrir a TELA DE VENDA?", "Escolha de tela",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                        AbrirNovaTela(new TelaVenda(matricula));
                    else
                        AbrirNovaTela(new TelaHome(matricula));
                }
                else
                {
                    AbrirNovaTela(new TelaHome(matricula));
                }
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos.", "Erro");
            }
        }

        private (string matricula, string cargo, string status) MatriculaUsuario(string email)
        {
            string matricula = null;
            string cargo = null;
            string status = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT matricula, cargo, status_matricula FROM Funcionario WHERE login_func = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            matricula = reader["matricula"].ToString();
                            cargo = reader["cargo"].ToString();
                            status = reader["status_matricula"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return (matricula, cargo, status);
        }

        private bool AutenticarUsuario(string email, string senha)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Funcionario WHERE login_func = @Email AND senha_func = @Senha";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        // Função auxiliar para abrir uma nova tela
        private void AbrirNovaTela(Form tela)
        {
            this.Close();
            nt = new Thread(() => Application.Run(tela));
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
    }
}
