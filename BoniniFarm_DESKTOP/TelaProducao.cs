using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace BoniniFarm2
{
    public partial class TelaProducao : Form
    {
        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";
        private Thread nt;
        private string matriculaUsuario;

        public TelaProducao(string matricula)
        {
            InitializeComponent();
            matriculaUsuario = matricula;
        }

        private void TelaProducao_Load(object sender, EventArgs e)
        {
            CarregarCultivo();
            CarregarColheita();
            txtDataHoje2.Text = DateTime.Now.ToString("dd-MM-yyyy");
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
        // PARTE GERAR COLHEITA
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

                    listCultivo2.AutoGenerateColumns = true;
                    listCultivo2.DataSource = dataTable;
                    listCultivo2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Ajuste dos cabeçalhos das colunas
                    listCultivo2.Columns["id_cultivo"].HeaderText = "Código";
                    listCultivo2.Columns["cod_planta"].HeaderText = "Cod Planta";
                    listCultivo2.Columns["nome_planta"].HeaderText = "Nome da Planta";
                    listCultivo2.Columns["qtd_cultivada"].HeaderText = "Quantidade Cultivada";
                    listCultivo2.Columns["data_plantio"].HeaderText = "Data do Plantio";
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
                DataGridViewRow row = listCultivo2.Rows[e.RowIndex];

                txtCodCultivo2.Text = row.Cells["id_cultivo"].Value.ToString();
                txtNomePlantaC2.Text = row.Cells["nome_planta"].Value.ToString();
                txtDateCultivo.Text = Convert.ToDateTime(row.Cells["data_plantio"].Value).ToString("dd-MM-yyyy");
                txtCodPlantaC2.Text = row.Cells["cod_planta"].Value.ToString();

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

                foreach (DataGridViewRow row in listCultivo2.Rows)
                {
                    if (row.Cells["id_cultivo"].Value != null && row.Cells["id_cultivo"].Value.ToString() == codigoCultivo)
                    {
                        txtCodCultivo2.Text = row.Cells["id_cultivo"].Value.ToString();
                        txtNomePlantaC2.Text = row.Cells["nome_planta"].Value.ToString();
                        txtDateCultivo.Text = Convert.ToDateTime(row.Cells["data_plantio"].Value).ToString("dd-MM-yyyy");
                        txtCodPlantaC2.Text = row.Cells["cod_planta"].Value.ToString();

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


        // Botão Gerar Colheita
        private void btnGerarColheita_Click(object sender, EventArgs e)
        {
            GerarColheita();
        }

        private void GerarColheita()
        {
            if (string.IsNullOrWhiteSpace(txtCodCultivo2.Text) ||
                string.IsNullOrWhiteSpace(txtDataHoje2.Text) ||
                string.IsNullOrWhiteSpace(txtQuantidade2.Text) ||
                string.IsNullOrWhiteSpace(txtCodPlantaC2.Text) ||
                string.IsNullOrWhiteSpace(txtCodProdColh.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string nomePlanta = string.Empty;
            string nomeProduto = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    // Verifica se o cultivo já foi registrado anteriormente
                    string checkQuery = "SELECT COUNT(*) FROM Colheita WHERE id_cultivo = @idCultivo";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@idCultivo", int.Parse(txtCodCultivo2.Text));
                        int cultivoExistente = (int)checkCommand.ExecuteScalar();

                        if (cultivoExistente > 0)
                        {
                            MessageBox.Show("Cultivo já finalizado anteriormente.");
                            LimparCamposCultivo();
                            return;
                        }
                    }

                    // Consulta para obter os nomes da planta e do produto com base nos códigos informados
                    string queryInfo = @"
                        SELECT p.nome_planta, pr.nome_prod 
                        FROM Planta p
                        INNER JOIN Produto pr ON pr.cod_prod = @codProduto
                        WHERE p.cod_planta = @codPlanta";

                    using (SqlCommand commandInfo = new SqlCommand(queryInfo, connection))
                    {
                        commandInfo.Parameters.AddWithValue("@codPlanta", int.Parse(txtCodPlantaC2.Text));
                        commandInfo.Parameters.AddWithValue("@codProduto", int.Parse(txtCodProdColh.Text));

                        using (SqlDataReader reader = commandInfo.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nomePlanta = reader["nome_planta"].ToString();
                                nomeProduto = reader["nome_prod"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Planta ou produto não encontrados. Verifique os códigos e tente novamente.");
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar informações: " + ex.Message);
                    return;
                }
            }

            var confirmResult = MessageBox.Show(
                $"Tem certeza de que deseja gerar a colheita do cultivo '{txtCodCultivo2.Text}' - '{nomePlanta}' relacionado ao produto '{nomeProduto}'?",
                "Confirmação de Gerar Colheita",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string query = @"
                            INSERT INTO Colheita (data_colheita, qtd_total_colheita, cod_planta, id_cultivo, cod_prod)
                            VALUES (@dataColheita, @quantidade, @codPlanta, @idCultivo, @codProduto); 
                            SELECT SCOPE_IDENTITY();";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@dataColheita", DateTime.Parse(txtDataHoje2.Text));
                            command.Parameters.AddWithValue("@quantidade", int.Parse(txtQuantidade2.Text));
                            command.Parameters.AddWithValue("@codPlanta", int.Parse(txtCodPlantaC2.Text));
                            command.Parameters.AddWithValue("@idCultivo", int.Parse(txtCodCultivo2.Text));
                            command.Parameters.AddWithValue("@codProduto", int.Parse(txtCodProdColh.Text));

                            var newId = command.ExecuteScalar();

                            MessageBox.Show($"Colheita gravada com sucesso. Código gerado: {newId}");

                            CarregarColheita();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar colheita: " + ex.Message);
                    }
                }

                LimparCamposCultivo();
            }
        }


        // Botão Atualizar Cultivo
        private void btnAtualizarCul_Click(object sender, EventArgs e)
        {
            CarregarCultivo();
            txtDataHoje2.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }


        // Botãoo Limpar Campos Gerar Colheita
        private void btnLimparCult_Click(object sender, EventArgs e)
        {
            LimparCamposCultivo();
        }

        private void LimparCamposCultivo()
        {
            txtCodCultivo2.Text = "";
            txtDateCultivo.Text = "";
            txtDataHoje2.Clear();
            txtNomePlantaC2.Text = "";
            txtQuantidade2.Clear();
            txtCodProdColh.Clear();

            txtDataHoje2.Text = DateTime.Now.ToString("dd-MM-yyyy");

            txtBuscarCultivo.Text = "inserir código do cultivo...";
            txtBuscarCultivo.ForeColor = Color.Gray;
        }

        //
        //
        // PARTE EDITAR COLHEITA
        //
        //

        private void CarregarColheita()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                        SELECT 
                            Colheita.id_colheita, 
                            Colheita.cod_planta, 
                            Planta.nome_planta, 
                            Colheita.qtd_total_colheita, 
                            Colheita.cod_prod,
	                        Produto.nome_prod,
                            Colheita.id_cultivo, 
                            Colheita.data_colheita
                        FROM 
                            Colheita
                        INNER JOIN 
                            Planta ON Colheita.cod_planta = Planta.cod_planta
                        INNER JOIN
	                        Produto ON Colheita.cod_prod = Produto.cod_prod";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listColheita.AutoGenerateColumns = true;
                    listColheita.DataSource = dataTable;
                    listColheita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    listColheita.Columns["id_colheita"].HeaderText = "Código da Colheita";
                    listColheita.Columns["cod_planta"].HeaderText = "Cod Planta";
                    listColheita.Columns["nome_planta"].HeaderText = "Nome da Planta";
                    listColheita.Columns["qtd_total_colheita"].HeaderText = "Quantidade Colhida";
                    listColheita.Columns["cod_prod"].HeaderText = "Código do Produto";
                    listColheita.Columns["nome_prod"].HeaderText = "Nome do Produto";
                    listColheita.Columns["id_cultivo"].HeaderText = "Código do Cultivo";
                    listColheita.Columns["data_colheita"].HeaderText = "Data da Colheita";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar dados da tabela Colheita: " + ex.Message);
                }
            }
        }

        private void listColheita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = listColheita.Rows[e.RowIndex];

                txtCodColheita.Text = row.Cells["id_colheita"].Value.ToString();
                txtNomePlantaColh.Text = row.Cells["nome_planta"].Value.ToString();
                txtQuantidadeColh.Text = row.Cells["qtd_total_colheita"].Value.ToString();
                txtDataHojeColh.Text = Convert.ToDateTime(row.Cells["data_colheita"].Value).ToString("dd-MM-yyyy");
                txtProdColhE.Text = row.Cells["cod_prod"].Value.ToString();

            }
        }


        // BUCAR COLHEITA PELO CODIGO
        private void txtBuscarColheita_Enter(object sender, EventArgs e)
        {
            if (txtBuscarColheita.Text == "inserir código da colheita...")
            {
                txtBuscarColheita.Text = "";
                txtBuscarColheita.ForeColor = Color.Black;
            }
        }

        private void txtBuscarColheita_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarColheita.Text))
            {
                txtBuscarColheita.Text = "inserir código da colheita...";
                txtBuscarColheita.ForeColor = Color.Gray;
            }
        }

        private void btnBuscarColheita_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarColheita.Text) && txtBuscarColheita.Text != "inserir código da colheita...")
            {
                string codigoColheita = txtBuscarColheita.Text.Trim();
                bool found = false; // Flag para verificar se encontrou a colheita

                foreach (DataGridViewRow row in listColheita.Rows)
                {
                    if (row.Cells["id_colheita"].Value != null && row.Cells["id_colheita"].Value.ToString() == codigoColheita)
                    {
                        txtCodColheita.Text = row.Cells["id_colheita"].Value.ToString();
                        txtNomePlantaColh.Text = row.Cells["nome_planta"].Value.ToString();
                        txtQuantidadeColh.Text = row.Cells["qtd_total_colheita"].Value.ToString();
                        txtDataHojeColh.Text = Convert.ToDateTime(row.Cells["data_colheita"].Value).ToString("dd-MM-yyyy");
                        txtProdColhE.Text = row.Cells["cod_prod"].Value.ToString();

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Colheita não encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código de colheita válido.");
            }
        }


        // Botão Alterar Colheita
        private void btnAltColheita_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodColheita.Text) ||
                string.IsNullOrWhiteSpace(txtNomePlantaColh.Text) ||
                string.IsNullOrWhiteSpace(txtQuantidadeColh.Text) ||
                string.IsNullOrWhiteSpace(txtDataHojeColh.Text) ||
                string.IsNullOrWhiteSpace(txtProdColhE.Text))
            {
                MessageBox.Show("Por favor, selecione uma colheita e preencha todos os campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE Colheita SET qtd_total_colheita = @quantidade, data_colheita = @dataColheita, cod_prod = @codProduto1 WHERE id_colheita = @idColheita";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idColheita", txtCodColheita.Text);
                        command.Parameters.AddWithValue("@quantidade", txtQuantidadeColh.Text);
                        command.Parameters.AddWithValue("@dataColheita", txtDataHojeColh.Text);
                        command.Parameters.AddWithValue("@codProduto1", txtProdColhE.Text);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Colheita atualizada com sucesso.");

                    CarregarColheita();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar colheita: " + ex.Message);
                }
            }

            LimparCamposColheita();
        }


        // Botão Excluir Colheita
        private void btnExcColheita_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodColheita.Text))
            {
                MessageBox.Show("Por favor, selecione uma colheita para excluir.");
                return;
            }

            string codColheita = txtCodColheita.Text;

            // Confirmação
            var confirmResult = MessageBox.Show($"Confirmar exclusão da colheita com código '{codColheita}'?",
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
                        string query = "DELETE FROM Colheita WHERE id_colheita = @codColh";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@codColh", codColheita);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Colheita excluída com sucesso.");
                                CarregarColheita();
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma colheita encontrada com o código especificado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir colheita: " + ex.Message);
                    }
                }
            }
            LimparCamposColheita();
        }


        // Botão Atualizar Colheita
        private void btnAtualizarColh_Click(object sender, EventArgs e)
        {
            CarregarColheita();
        }


        // Botão Limpas Campos Editar Colheita
        private void btnLimparColh_Click(object sender, EventArgs e)
        {
            LimparCamposColheita();
        }

        private void LimparCamposColheita()
        {
            txtCodColheita.Text = "";
            txtNomePlantaColh.Text = "";
            txtQuantidadeColh.Clear();
            txtDataHojeColh.Clear();
            txtProdColhE.Clear();

            txtBuscarColheita.Text = "inserir código da colheita...";
            txtBuscarColheita.ForeColor = Color.Gray;
        }
    }
}