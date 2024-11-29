using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace BoniniFarm2
{
    public partial class TelaRH : Form
    {
        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";
        private Thread nt;
        private string matriculaUsuario;

        public TelaRH(string matricula)
        {
            InitializeComponent();
            matriculaUsuario = matricula;
        }

        private void TelaRH_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
            txtStatus.Items.Add("Ativa");
            txtStatus.Items.Add("Inativa");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");
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
            nt = new Thread(abrirTelaRH);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            this.Close();
        }
        private void abrirTelaRH(object? obj)
        {
            Application.Run(new TelaRH(matriculaUsuario));
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


        //
        //
        // PARTE FUNCIONARIO
        //
        //
        private void CarregarFuncionario()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Funcionario";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listFuncionario.AutoGenerateColumns = true;
                    listFuncionario.DataSource = dataTable;
                    listFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Ajuste dos cabeçalhos das colunas
                    listFuncionario.Columns["matricula"].HeaderText = "Matrícula";
                    listFuncionario.Columns["nome_func"].HeaderText = "Nome";
                    listFuncionario.Columns["endereco_func"].HeaderText = "Endereço";
                    listFuncionario.Columns["telefone_func"].HeaderText = "Telefone";
                    listFuncionario.Columns["cargo"].HeaderText = "Cargo";
                    listFuncionario.Columns["CPF_func"].HeaderText = "CPF";
                    listFuncionario.Columns["salario"].HeaderText = "Salário";
                    listFuncionario.Columns["status_matricula"].HeaderText = "Status";
                    listFuncionario.Columns["data_nasc"].HeaderText = "Data de Nascimento";
                    listFuncionario.Columns["login_func"].HeaderText = "Login";
                    listFuncionario.Columns["senha_func"].HeaderText = "Senha";
                    listFuncionario.Columns["cod_adm"].HeaderText = "Código Admin";

                    listFuncionario.Columns["salario"].DefaultCellStyle.Format = "F2";

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao buscar dados da tabela Funcionario: " + erro.Message);
                }
            }
        }

        private void listFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = listFuncionario.Rows[e.RowIndex];

                txtMatricula.Text = row.Cells["matricula"].Value.ToString();
                txtNomeFunc.Text = row.Cells["nome_func"].Value.ToString();
                txtEndereco.Text = row.Cells["endereco_func"].Value.ToString();
                txtTele.Text = row.Cells["telefone_func"].Value.ToString();
                txtCargo.Text = row.Cells["cargo"].Value.ToString();
                txtCpf.Text = row.Cells["CPF_func"].Value.ToString();
                txtSalario.Text = Convert.ToDecimal(row.Cells["salario"].Value).ToString("F2");
                txtStatus.SelectedItem = row.Cells["status_matricula"].Value.ToString();
                txtNasc.Text = Convert.ToDateTime(row.Cells["data_nasc"].Value).ToString("dd-MM-yyyy");
                txtLogin.Text = row.Cells["login_func"].Value.ToString();
                txtSenha.Text = row.Cells["senha_func"].Value.ToString();
                txtCodAdm.Text = row.Cells["cod_adm"].Value != null ? row.Cells["cod_adm"].Value.ToString() : "";
            }
        }

        // BUSCAR FUNCIONARIO PELA MATRICULA
        private void txtBuscarFunc_Enter(object sender, EventArgs e)
        {
            if (txtBuscarFunc.Text == "inserir a matricula do funcionario...")
            {
                txtBuscarFunc.Text = "";
                txtBuscarFunc.ForeColor = Color.Black;
            }
        }

        private void txtBuscarFunc_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarFunc.Text))
            {
                txtBuscarFunc.Text = "inserir a matricula do funcionario...";
                txtBuscarFunc.ForeColor = Color.Gray;
            }
        }

        private void btnBuscarFunc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarFunc.Text) && txtBuscarFunc.Text != "inserir a matricula do funcionario...")
            {
                string matriculaFuncionario = txtBuscarFunc.Text.Trim();
                bool found = false;

                foreach (DataGridViewRow row in listFuncionario.Rows)
                {
                    if (row.Cells["matricula"].Value != null && row.Cells["matricula"].Value.ToString() == matriculaFuncionario)
                    {
                        // Preenche os campos com os dados da linha correspondente
                        txtMatricula.Text = row.Cells["matricula"].Value.ToString();
                        txtNomeFunc.Text = row.Cells["nome_func"].Value.ToString();
                        txtEndereco.Text = row.Cells["endereco_func"].Value.ToString();
                        txtTele.Text = row.Cells["telefone_func"].Value.ToString();
                        txtCargo.Text = row.Cells["cargo"].Value.ToString();
                        txtCpf.Text = row.Cells["CPF_func"].Value.ToString();
                        txtSalario.Text = Convert.ToDecimal(row.Cells["salario"].Value).ToString("F2");
                        txtStatus.SelectedItem = row.Cells["status_matricula"].Value.ToString();
                        txtNasc.Text = Convert.ToDateTime(row.Cells["data_nasc"].Value).ToString("dd-MM-yyyy");
                        txtLogin.Text = row.Cells["login_func"].Value.ToString();
                        txtSenha.Text = row.Cells["senha_func"].Value.ToString();
                        txtCodAdm.Text = row.Cells["cod_adm"].Value != null ? row.Cells["cod_adm"].Value.ToString() : "";

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Funcionário não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira uma matrícula válida.");
            }
        }


        // Botão Gravar Funcionario
        private void btnGravarFunc_Click(object sender, EventArgs e)
        {
            CriarFuncionario();
        }

        private void CriarFuncionario()
        {
            if (string.IsNullOrWhiteSpace(txtNomeFunc.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtTele.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) ||
                string.IsNullOrWhiteSpace(txtNasc.Text) ||
                string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                txtStatus.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario) || salario != Math.Round(salario, 2))
            {
                MessageBox.Show("Por favor, insira um valor válido para o salário com até duas casas decimais.");
                return;
            }

            // Arredonda para 2 casas decimais
            salario = Math.Round(salario, 2);

            // Validação da data de nascimento
            DateTime dataNasc;
            if (!DateTime.TryParse(txtNasc.Text, out dataNasc))
            {
                MessageBox.Show("Formato de data inválido. Por favor, insira uma data válida.");
                return;
            }

            // Verificar se o CPF já está cadastrado
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string checkQuery = "SELECT COUNT(*) FROM Funcionario WHERE CPF_func = @cpf";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@cpf", txtCpf.Text);
                        int cpfExistente = (int)checkCommand.ExecuteScalar();

                        if (cpfExistente > 0)
                        {
                            MessageBox.Show("Este CPF já foi registrado. Por favor, verifique.");
                            return;
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao verificar CPF: " + erro.Message);
                    return;
                }
            }

            // Criar o funcionário se o CPF não estiver duplicado
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = @"
                INSERT INTO Funcionario (nome_func, endereco_func, telefone_func, cargo, CPF_func, salario, status_matricula, data_nasc, login_func, senha_func, cod_adm) 
                VALUES (@nome, @endereco, @telefone, @cargo, @cpf, @salario, @status, @dataNasc, @login, @senha, @codAdm);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nome", txtNomeFunc.Text);
                        command.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        command.Parameters.AddWithValue("@telefone", txtTele.Text);
                        command.Parameters.AddWithValue("@cargo", txtCargo.Text);
                        command.Parameters.AddWithValue("@cpf", txtCpf.Text);
                        command.Parameters.AddWithValue("@salario", salario);
                        command.Parameters.AddWithValue("@status", txtStatus.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@dataNasc", dataNasc);
                        command.Parameters.AddWithValue("@login", txtLogin.Text);
                        command.Parameters.AddWithValue("@senha", txtSenha.Text);

                        int codAdm = string.IsNullOrWhiteSpace(txtCodAdm.Text) ? 0 : Convert.ToInt32(txtCodAdm.Text);
                        command.Parameters.AddWithValue("@codAdm", codAdm);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Funcionário adicionado com sucesso!");
                    CarregarFuncionario();
                    LimparCampos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao inserir funcionário: " + erro.Message);
                }
            }
        }


        // Botão Alterar Funcionario
        private void btnAlterarFunc_Click(object sender, EventArgs e)
        {
            AlterarFuncionario();
        }

        private void AlterarFuncionario()
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) || string.IsNullOrWhiteSpace(txtNomeFunc.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) || string.IsNullOrWhiteSpace(txtTele.Text) ||
                string.IsNullOrWhiteSpace(txtCargo.Text) || string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) || txtStatus.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtNasc.Text) || string.IsNullOrWhiteSpace(txtLogin.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, selecione um funcionário e preencha todos os campos.");
                return;
            }

            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out salario))
            {
                MessageBox.Show("Por favor, insira um valor válido para o salário. Use ponto ou vírgula como separador decimal.");
                txtSalario.Focus();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = @"
                        UPDATE Funcionario 
                        SET nome_func = @nome, 
                            endereco_func = @endereco, 
                            telefone_func = @telefone, 
                            cargo = @cargo, 
                            CPF_func = @cpf, 
                            salario = @salario, 
                            status_matricula = @status, 
                            data_nasc = @dataNasc, 
                            login_func = @login, 
                            senha_func = @senha, 
                            cod_adm = @codAdm 
                        WHERE matricula = @matricula";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                        command.Parameters.AddWithValue("@nome", txtNomeFunc.Text);
                        command.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        command.Parameters.AddWithValue("@telefone", txtTele.Text);
                        command.Parameters.AddWithValue("@cargo", txtCargo.Text);
                        command.Parameters.AddWithValue("@cpf", txtCpf.Text);
                        command.Parameters.AddWithValue("@salario", salario);
                        command.Parameters.AddWithValue("@status", txtStatus.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@dataNasc", txtNasc.Text);
                        command.Parameters.AddWithValue("@login", txtLogin.Text);
                        command.Parameters.AddWithValue("@senha", txtSenha.Text);

                        // Se o campo de ADM for vazio, insere um valor nulo
                        if (string.IsNullOrWhiteSpace(txtCodAdm.Text))
                            command.Parameters.AddWithValue("@codAdm", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@codAdm", txtCodAdm.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Funcionário atualizado com sucesso.");
                    CarregarFuncionario();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao atualizar funcionário: " + erro.Message);
                }
            }

            LimparCampos();
        }


        // Botão Excluir Funcionario
        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            ExcluirFuncionario();
        }

        private void ExcluirFuncionario()
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("Por favor, selecione um funcionário para excluir.");
                return;
            }

            string matricula = txtMatricula.Text;

            var confirmResult = MessageBox.Show($"Confirmar exclusão do funcionário com matrícula '{matricula}'?",
                                                 "Confirmação de Exclusão",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Funcionario WHERE matricula = @matricula";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@matricula", matricula);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Funcionário excluído com sucesso.");
                                CarregarFuncionario();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum funcionário encontrado com a matrícula especificada.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir funcionário: " + ex.Message);
                    }
                }
            }
        }


        // Botão Limpar Campos Funcionario
        private void btnLimparFunc_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtMatricula.Text = "";
            txtNomeFunc.Clear();
            txtEndereco.Clear();
            txtTele.Clear();
            txtCargo.Clear();
            txtCpf.Clear();
            txtSalario.Clear();
            txtStatus.SelectedIndex = -1; // Limpa o ComboBox
            txtNasc.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtCodAdm.Clear();

            txtBuscarFunc.Text = "inserir a matricula do funcionario...";
            txtBuscarFunc.ForeColor = Color.Gray;
        }


        // Botão Atualizar Lista Funcionario
        private void btnAtualizarFunc_Click(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

    }
}
