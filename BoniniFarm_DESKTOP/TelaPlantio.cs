using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace BoniniFarm2
{
    public partial class TelaPlantio : Form
    {
        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";
        private Thread nt;
        private string matriculaUsuario;

        public TelaPlantio(string matricula)
        {
            InitializeComponent();
            matriculaUsuario = matricula;
            this.Load += TelaPlantio_Load;
            listPlanta.CellClick += listPlanta_CellClick;
        }

        private void TelaPlantio_Load(object sender, EventArgs e)
        {
            CarregarPlanta();
            CarregarCultivo();
            txtDataHoje.Text = DateTime.Now.ToString("dd-MM-yyyy");
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
            if (UsuarioPossuiPermissaoRH())
            {
                nt = new Thread(abrirTelaRH);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                this.Close();
            }
            else
            {
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


        //
        //
        // PARTE DA PLANTA PELO CODIGO OU NOME
        //
        //
        private void CarregarPlanta()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Planta";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listPlanta.AutoGenerateColumns = true;
                    listPlanta.DataSource = dataTable;
                    listPlanta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    listPlanta.Columns["cod_planta"].HeaderText = "Código";
                    listPlanta.Columns["nome_planta"].HeaderText = "Nome";
                    listPlanta.Columns["tipo_planta"].HeaderText = "Tipo de planta";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao buscar dados da tabela Planta: " + erro.Message);
                }
            }
        }

        private void listPlanta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = listPlanta.Rows[e.RowIndex];

                txtCodPlanta.Text = row.Cells["cod_planta"].Value.ToString();
                txtNomePlanta.Text = row.Cells["nome_planta"].Value.ToString();
                txtTipoPlanta.Text = row.Cells["tipo_planta"].Value.ToString();
            }
        }


        // BUSCAR PLANTA
        private void txtBuscarPlanta_Enter(object sender, EventArgs e)
        {
            if (txtBuscarPlanta.Text == "inserir código ou o nome da planta...")
            {
                txtBuscarPlanta.Text = "";
                txtBuscarPlanta.ForeColor = Color.Black;
            }
        }

        private void txtBuscarPlanta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarPlanta.Text))
            {
                txtBuscarPlanta.Text = "inserir código ou o nome da planta...";
                txtBuscarPlanta.ForeColor = Color.Gray;
            }
        }

        private void btnBuscarPlanta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarPlanta.Text) && txtBuscarPlanta.Text != "inserir código ou nome da planta...")
            {
                string searchValue = txtBuscarPlanta.Text.Trim();
                bool found = false; // Flag para verificar se encontrou algum resultado

                foreach (DataGridViewRow row in listPlanta.Rows)
                {
                    if ((row.Cells["cod_planta"].Value != null && row.Cells["cod_planta"].Value.ToString() == searchValue) ||
                        (row.Cells["nome_planta"].Value != null && row.Cells["nome_planta"].Value.ToString().ToLower().Contains(searchValue.ToLower())))
                    {
                        txtCodPlanta.Text = row.Cells["cod_planta"].Value.ToString();
                        txtNomePlanta.Text = row.Cells["nome_planta"].Value.ToString();
                        txtTipoPlanta.Text = row.Cells["tipo_planta"].Value.ToString();

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Planta não encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código ou nome de planta válido.");
            }
        }


        // Botão Gravar Planta
        private void btnGravarPlanta_Click(object sender, EventArgs e)
        {
            CriarPlanta();
        }

        private void CriarPlanta()
        {
            if (string.IsNullOrWhiteSpace(txtNomePlanta.Text) || string.IsNullOrWhiteSpace(txtTipoPlanta.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Parte da validação do código ja criado
            if (!string.IsNullOrWhiteSpace(txtCodPlanta.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string checkQuery = "SELECT COUNT(*) FROM Planta WHERE cod_planta = @codPlanta";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@codPlanta", txtCodPlanta.Text);
                            int plantaExistente = (int)checkCommand.ExecuteScalar();

                            if (plantaExistente > 0)
                            {
                                MessageBox.Show("Código de planta já existe. Por favor verificar.");
                                LimparCamposPlanta();
                                return;
                            }
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao verificar o código da planta: " + erro.Message);
                        return;
                    }
                }
            }

            // Parte de criação de nova planta nao cadastrada
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO Planta (nome_planta, tipo_planta) VALUES (@nome, @tipo); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nome", txtNomePlanta.Text);
                        command.Parameters.AddWithValue("@tipo", txtTipoPlanta.Text);

                        var novoCodigo = command.ExecuteScalar();

                        if (novoCodigo != null)
                        {
                            MessageBox.Show($"Planta criada com sucesso. Código gerado: {novoCodigo}");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao gerar o código para a planta.");
                        }

                        CarregarPlanta();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao criar planta: " + erro.Message);
                }
            }

            LimparCamposPlanta();
        }


        // Botão Alterar Planta
        private void btnAlterarPlanta_Click(object sender, EventArgs e)
        {
            AlterarPlanta();
        }

        private void AlterarPlanta()
        {
            if (string.IsNullOrWhiteSpace(txtCodPlanta.Text) || string.IsNullOrWhiteSpace(txtNomePlanta.Text) || string.IsNullOrWhiteSpace(txtTipoPlanta.Text))
            {
                MessageBox.Show("Por favor, selecione uma planta e preencha todos os campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE Planta SET nome_planta = @nome, tipo_planta = @tipo WHERE cod_planta = @cod";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@cod", txtCodPlanta.Text);
                        command.Parameters.AddWithValue("@nome", txtNomePlanta.Text);
                        command.Parameters.AddWithValue("@tipo", txtTipoPlanta.Text);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Planta atualizada com sucesso.");
                    CarregarPlanta();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao atualizar planta: " + erro.Message);
                }
            }

            LimparCamposPlanta();
        }


        // Botão Ecluir Planta
        private void btnExcluirPlanta_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCodPlanta.Text))
            {
                MessageBox.Show("Por favor, selecione uma planta para excluir.");
                return;
            }

            string nomePlanta = txtNomePlanta.Text;

            var confirmResult = MessageBox.Show($"Confirmar exclusão do item '{nomePlanta}'?",
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
                        string query = "DELETE FROM Planta WHERE cod_planta = @cod";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@cod", txtCodPlanta.Text);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Planta excluída com sucesso.");
                                CarregarPlanta();
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma planta encontrada com o código especificado.");
                            }
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao excluir planta: " + erro.Message);
                    }
                }
            }
        }


        // Botão Atualizar Lista da Planta
        private void btnAtualizarPlanta_Click(object sender, EventArgs e)
        {
            CarregarPlanta();
        }


        // Botão Limpar Campos Planta
        private void btnLimparPlanta_Click(object sender, EventArgs e)
        {
            LimparCamposPlanta();
        }

        private void LimparCamposPlanta()
        {
            txtCodPlanta.Text = "";
            txtNomePlanta.Clear();
            txtTipoPlanta.Clear();

            txtBuscarPlanta.Text = "inserir código ou o nome da planta...";
            txtBuscarPlanta.ForeColor = Color.Gray;
        }


        //
        //
        // PARTE DO CULTIVO
        //
        //
        private void CarregarCultivo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                        SELECT 
                            Cultivo.id_cultivo, 
                            Cultivo.cod_planta, 
                            Planta.nome_planta, 
                            Cultivo.qtd_cultivada, 
                            Cultivo.data_plantio 
                        FROM 
                            Cultivo
                        INNER JOIN 
                            Planta ON Cultivo.cod_planta = Planta.cod_planta";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listCultivo.AutoGenerateColumns = true;
                    listCultivo.DataSource = dataTable;
                    listCultivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Ajuste dos cabeçalhos das colunas
                    listCultivo.Columns["id_cultivo"].HeaderText = "Código";
                    listCultivo.Columns["cod_planta"].HeaderText = "Cod Planta";
                    listCultivo.Columns["nome_planta"].HeaderText = "Nome da Planta";
                    listCultivo.Columns["qtd_cultivada"].HeaderText = "Quantidade Cultivada";
                    listCultivo.Columns["data_plantio"].HeaderText = "Data do Plantio";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar dados da tabela Cultivo: " + ex.Message);
                }
            }
        }

        private void listCultivo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = listCultivo.Rows[e.RowIndex];

                txtCodCultivo.Text = row.Cells["id_cultivo"].Value.ToString();
                txtNomePlantaC.Text = row.Cells["nome_planta"].Value.ToString();
                txtCodPlantaC.Text = row.Cells["cod_planta"].Value.ToString();
                txtQuantidade.Text = row.Cells["qtd_cultivada"].Value.ToString();
                txtDataHoje.Text = Convert.ToDateTime(row.Cells["data_plantio"].Value).ToString("dd-MM-yyyy");
            }
        }

        // BUSCAR CULTIVO PELO CODIGO

        private void txtBuscarCultivo_Enter(object sender, EventArgs e)
        {
            if (txtBuscarCultivo.Text == "inserir código do cultivo...")
            {
                txtBuscarCultivo.Text = "";
                txtBuscarCultivo.ForeColor = Color.Black;
            }
        }

        private void txtBuscarCultivo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarCultivo.Text))
            {
                txtBuscarCultivo.Text = "inserir código do cultivo...";
                txtBuscarCultivo.ForeColor = Color.Gray;
            }
        }

        private void btnBuscarCultivo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarCultivo.Text) && txtBuscarCultivo.Text != "inserir código do cultivo...")
            {
                string codigoCultivo = txtBuscarCultivo.Text.Trim();
                bool found = false; // Flag para verificar se encontrou o cultivo

                foreach (DataGridViewRow row in listCultivo.Rows)
                {
                    if (row.Cells["id_cultivo"].Value != null && row.Cells["id_cultivo"].Value.ToString() == codigoCultivo)
                    {
                        txtCodCultivo.Text = row.Cells["id_cultivo"].Value.ToString();
                        txtNomePlantaC.Text = row.Cells["nome_planta"].Value.ToString();
                        txtCodPlantaC.Text = row.Cells["cod_planta"].Value.ToString();
                        txtQuantidade.Text = row.Cells["qtd_cultivada"].Value.ToString();
                        txtDataHoje.Text = Convert.ToDateTime(row.Cells["data_plantio"].Value).ToString("dd-MM-yyyy");

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Cultivo não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código de cultivo válido.");
            }
        }


        // Botão Gravar Cultivo
        private void btnGravarCult_Click(object sender, EventArgs e)
        {
            CriarCultivo();
        }

        private void CriarCultivo()
        {
            // Verifica se os campos de texto estão preenchidos
            if (string.IsNullOrWhiteSpace(txtCodPlantaC.Text) ||
                string.IsNullOrWhiteSpace(txtQuantidade.Text) ||
                string.IsNullOrWhiteSpace(txtDataHoje.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    DateTime dataCultivo;
                    if (!DateTime.TryParseExact(txtDataHoje.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataCultivo))
                    {
                        MessageBox.Show("Formato de data inválido. Por favor, insira uma data válida.");
                        return;
                    }

                    // Verifica se o cultivo já está registrado
                    string checkQuery = "SELECT COUNT(*) FROM Cultivo WHERE cod_planta = @codPlanta";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@codPlanta", int.Parse(txtCodPlantaC.Text));
                        int cultivoExistente = (int)checkCommand.ExecuteScalar();

                        if (cultivoExistente > 0)
                        {
                            MessageBox.Show("Cultivo já registrado anteriormente. Por favor verificar");
                            LimparCamposCultivo();
                            return;
                        }
                    }

                    // Cria o cultivo se não estiver registrado
                    string query = "INSERT INTO Cultivo (cod_planta, qtd_cultivada, data_plantio) VALUES (@codPlanta, @quantidade, @dataPlantio); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codPlanta", int.Parse(txtCodPlantaC.Text));
                        command.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                        command.Parameters.AddWithValue("@dataPlantio", dataCultivo);

                        var newId = command.ExecuteScalar();

                        MessageBox.Show($"Cultivo criado com sucesso. Código gerado: {newId}");

                        CarregarCultivo();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar cultivo: " + ex.Message);
                }
            }

            LimparCamposCultivo();
        }


        // Botão Alterar Cultivo
        private void btnAlterarCult_Click(object sender, EventArgs e)
        {
            AlterarCultivo();
        }

        private void AlterarCultivo()
        {
            if (string.IsNullOrWhiteSpace(txtCodCultivo.Text) ||
                string.IsNullOrWhiteSpace(txtCodPlantaC.Text) ||
                string.IsNullOrWhiteSpace(txtQuantidade.Text) ||
                string.IsNullOrWhiteSpace(txtDataHoje.Text))
            {
                MessageBox.Show("Por favor, selecione um cultivo e preencha todos os campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    DateTime dataCultivo;
                    if (!DateTime.TryParseExact(txtDataHoje.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataCultivo))
                    {
                        MessageBox.Show("Formato de data inválido. Por favor, insira uma data válida (dd-MM-yyyy).");
                        return;
                    }

                    string query = "UPDATE Cultivo SET cod_planta = @codPlanta, qtd_cultivada = @quantidade, data_plantio = @dataPlantio WHERE id_cultivo = @idCultivo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idCultivo", txtCodCultivo.Text);
                        command.Parameters.AddWithValue("@codPlanta", int.Parse(txtCodPlantaC.Text));
                        command.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade.Text));
                        command.Parameters.AddWithValue("@dataPlantio", dataCultivo);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cultivo atualizado com sucesso.");

                    CarregarCultivo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar cultivo: " + ex.Message);
                }
            }

            LimparCamposCultivo();
        }


        // Botão Excluir Cultivo
        private void btnExcluirCult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCultivo.Text))
            {
                MessageBox.Show("Por favor, selecione um cultivo para excluir.");
                return;
            }

            string codCultivo = txtCodCultivo.Text;

            var confirmResult = MessageBox.Show($"Confirmar exclusão do cultivo com código '{codCultivo}'?",
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
                        string query = "DELETE FROM Cultivo WHERE id_cultivo = @codC";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@codC", codCultivo);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cultivo excluído com sucesso.");
                                CarregarCultivo(); // Atualiza a lista após a exclusão
                            }
                            else
                            {
                                MessageBox.Show("Nenhum cultivo encontrado com o código especificado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir cultivo: " + ex.Message);
                    }
                }
            }
        }


        // Botão Atualizar Cultivo
        private void btnAtualizarCult_Click(object sender, EventArgs e)
        {
            CarregarCultivo();
            txtDataHoje.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }


        // Botão Limpar Campos Cultivo
        private void btnLimparCult_Click(object sender, EventArgs e)
        {
            LimparCamposCultivo();
        }

        private void LimparCamposCultivo()
        {
            txtCodCultivo.Text = "";
            txtDataHoje.Clear();
            txtQuantidade.Clear();
            txtCodPlantaC.Clear();
            txtNomePlantaC.Text = "";

            txtDataHoje.Text = DateTime.Now.ToString("dd-MM-yyyy");

            txtBuscarCultivo.Text = "inserir código do cultivo...";
            txtBuscarCultivo.ForeColor = Color.Gray;
        }
    }
}
