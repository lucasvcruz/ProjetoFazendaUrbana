using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace BoniniFarm2
{
    public partial class TelaHome : Form
    {
        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";
        private Thread nt;
        private string matriculaUsuario;

        public TelaHome(string matricula)
        {
            InitializeComponent();
            matriculaUsuario = matricula;
        }


        // Botão para Tela Plantio
        private void btnTelaPlantio_Click(object sender, EventArgs e)
        {
            nt = new Thread(abrirTelaPlantio);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void abrirTelaPlantio(object? obj)
        {
            Application.Run(new TelaPlantio(matriculaUsuario));
        }


        // Botão para Tela Produção
        private void btnTelaProducao_Click(object sender, EventArgs e)
        {
            nt = new Thread(abrirTelaProducao);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void abrirTelaProducao(object? obj)
        {
            Application.Run(new TelaProducao(matriculaUsuario));
        }


        // Botão para Tela Produto/Estoque
        private void btnTelaProduto_Click(object sender, EventArgs e)
        {
            nt = new Thread(abrirTelaProduto);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void abrirTelaProduto(object? obj)
        {
            Application.Run(new TelaProduto(matriculaUsuario));
        }


        // Botão para Tela Recursos Humanos
        private void btnTelaRH_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário tem permissão para acessar a TelaRH
            if (UsuarioPossuiPermissaoRH())
            {
                nt = new Thread(abrirTelaRH);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                this.Close();
            }
            else
            {
                // Exibe a mensagem de acesso negado sem fechar a tela atual
                MessageBox.Show("Acesso negado. Você não possui permissão para acessar a Tela de Recursos Humanos.", "Permissão Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void abrirTelaRH(object? obj)
        {
            Application.Run(new TelaRH(matriculaUsuario));
        }

        private bool UsuarioPossuiPermissaoRH()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT cod_adm FROM Funcionario WHERE matricula = @Matricula";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Matricula", matriculaUsuario);

                    try
                    {
                        connection.Open();
                        var result = command.ExecuteScalar();

                        // Verifica se result é não nulo e maior que 0
                        if (result != null && Convert.ToInt32(result) > 0)
                        {
                            return true; // Retorna verdadeiro se cod_adm for maior que 0
                        }
                        else
                        {
                            return false; // Retorna falso se cod_adm for nulo ou 0
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao verificar permissões de acesso: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }


        // Botão para Tela Fornecedor
        private void btnForne_Click(object sender, EventArgs e)
        {
            nt = new Thread(abrirTelaFornecedor);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }

        private void abrirTelaFornecedor(object? obj)
        {
            Application.Run(new TelaFornecedor(matriculaUsuario));
        }


        // Botão para Tela Login
        private void btnSairTela_Click(object sender, EventArgs e)
        {
            nt = new Thread(abrirTelaLogin);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

            this.Close();
        }

        private void abrirTelaLogin(object? obj)
        {
            Application.Run(new TelaLogin());
        }
    }
}
