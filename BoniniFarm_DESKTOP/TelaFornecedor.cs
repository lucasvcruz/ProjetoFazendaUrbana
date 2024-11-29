using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace BoniniFarm2
{
    public partial class TelaFornecedor : Form
    {

        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";
        private Thread nt;
        private string matriculaUsuario;

        public TelaFornecedor(string matricula)
        {
            InitializeComponent();
            matriculaUsuario = matricula;
        }

        private void TelaFornecedor_Load(object sender, EventArgs e)
        {
            CarregarFornecedor();
            CarregarCompra();
            txtDataC.Text = DateTime.Now.ToString("dd-MM-yyyy");
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
        private void btnSairTHome_Click(object sender, EventArgs e)
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
        // PARTE DO FORNECEDOR
        //
        private void CarregarFornecedor()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT * FROM Fornecedor";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listFornecedor.AutoGenerateColumns = true;
                    listFornecedor.DataSource = dataTable;
                    listFornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    listFornecedor.Columns["cod_forne"].HeaderText = "Código";
                    listFornecedor.Columns["nome_fantasia"].HeaderText = "Nome";
                    listFornecedor.Columns["CNPJ_forne"].HeaderText = "CNPJ";
                    listFornecedor.Columns["telefone_forne"].HeaderText = "Telefone";
                    listFornecedor.Columns["email_forne"].HeaderText = "E-mail";
                    listFornecedor.Columns["endereco_forne"].HeaderText = "Endereço";
                    listFornecedor.Columns["site_forne"].HeaderText = "Site";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao buscar dados da tabela Fornecedor: " + erro.Message);
                }
            }
        }

        private void listFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = listFornecedor.Rows[e.RowIndex];

                txtCodForne.Text = row.Cells["cod_forne"].Value.ToString();
                txtNomeForne.Text = row.Cells["nome_fantasia"].Value.ToString();
                txtCNPJ.Text = row.Cells["CNPJ_forne"].Value.ToString();
                txtTelefone.Text = row.Cells["telefone_forne"].Value.ToString();
                txtEmail.Text = row.Cells["email_forne"].Value.ToString();
                txtEndereco.Text = row.Cells["endereco_forne"].Value.ToString();
                txtSite.Text = row.Cells["site_forne"].Value.ToString();
            }
        }


        // BUSCAR FORNECEDOR PELO CODIGO
        private void txtBuscarForne_Enter(object sender, EventArgs e)
        {
            if (txtBuscarForne.Text == "inserir código do fornecedor...")
            {
                txtBuscarForne.Text = "";
                txtBuscarForne.ForeColor = Color.Black;
            }
        }

        private void txtBuscarForne_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarForne.Text))
            {
                txtBuscarForne.Text = "inserir código do fornecedor...";
                txtBuscarForne.ForeColor = Color.Gray;
            }
        }

        private void btnBuscarForne_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarForne.Text) && txtBuscarForne.Text != "inserir código do fornecedor...")
            {
                string codigoFornecedor = txtBuscarForne.Text.Trim();
                bool found = false; // Flag para verificar se encontrou o código do fornecedor

                foreach (DataGridViewRow row in listFornecedor.Rows)
                {
                    if (row.Cells["cod_forne"].Value != null && row.Cells["cod_forne"].Value.ToString() == codigoFornecedor)
                    {
                        // Se encontrar, preenche os campos com os dados da linha
                        txtCodForne.Text = row.Cells["cod_forne"].Value.ToString();
                        txtNomeForne.Text = row.Cells["nome_fantasia"].Value.ToString();
                        txtCNPJ.Text = row.Cells["CNPJ_forne"].Value.ToString();
                        txtTelefone.Text = row.Cells["telefone_forne"].Value.ToString();
                        txtEmail.Text = row.Cells["email_forne"].Value.ToString();
                        txtEndereco.Text = row.Cells["endereco_forne"].Value.ToString();
                        txtSite.Text = row.Cells["site_forne"].Value.ToString();

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Fornecedor não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código de fornecedor válido.");
            }
        }


        // Botão Gravar Fornecedor
        private void btnGravarForne_Click(object sender, EventArgs e)
        {
            CriarFornecedor();
        }

        private void CriarFornecedor()
        {
            if (string.IsNullOrWhiteSpace(txtNomeForne.Text) ||
                string.IsNullOrWhiteSpace(txtCNPJ.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtSite.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string checkQuery = "SELECT COUNT(*) FROM Fornecedor WHERE CNPJ_forne = @cnpj";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                        int fornecedorExistente = (int)checkCommand.ExecuteScalar();

                        if (fornecedorExistente > 0)
                        {
                            MessageBox.Show("Fornecedor com este CNPJ já está registrado.");
                            return;
                        }
                    }

                    string query = "INSERT INTO Fornecedor (nome_fantasia, CNPJ_forne, telefone_forne, email_forne, endereco_forne, site_forne) " +
                                   "VALUES (@nome, @cnpj, @telefone, @email, @endereco, @site); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nome", txtNomeForne.Text);
                        command.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                        command.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        command.Parameters.AddWithValue("@site", txtSite.Text);

                        var newId = command.ExecuteScalar();
                        MessageBox.Show($"Fornecedor criado com sucesso. Código gerado: {newId}");

                        CarregarFornecedor();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar fornecedor: " + ex.Message);
                }
            }
            LimparCamposFornecedor();
        }


        // Botão Alterar Fornecedor
        private void btnAlterarForne_Click(object sender, EventArgs e)
        {
            AlterarFornecedor();
        }

        private void AlterarFornecedor()
        {
            if (string.IsNullOrWhiteSpace(txtCodForne.Text) ||
                string.IsNullOrWhiteSpace(txtNomeForne.Text) ||
                string.IsNullOrWhiteSpace(txtCNPJ.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtSite.Text))
            {
                MessageBox.Show("Por favor, selecione um fornecedor e preencha todos os campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE Fornecedor SET nome_fantasia = @nome, CNPJ_forne = @cnpj, telefone_forne = @telefone, " +
                                   "email_forne = @email, endereco_forne = @endereco, site_forne = @site WHERE cod_forne = @codForne";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codForne", int.Parse(txtCodForne.Text));
                        command.Parameters.AddWithValue("@nome", txtNomeForne.Text);
                        command.Parameters.AddWithValue("@cnpj", txtCNPJ.Text);
                        command.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                        command.Parameters.AddWithValue("@email", txtEmail.Text);
                        command.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                        command.Parameters.AddWithValue("@site", txtSite.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Fornecedor atualizado com sucesso.");

                    CarregarFornecedor();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar fornecedor: " + ex.Message);
                }
            }

            LimparCamposFornecedor();
        }


        // Botão Excluir Fornecedor
        private void btnExcluirForne_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodForne.Text))
            {
                MessageBox.Show("Por favor, selecione um fornecedor para excluir.");
                return;
            }

            string codForne = txtCodForne.Text;

            var confirmResult = MessageBox.Show($"Confirmar exclusão do fornecedor com código '{codForne}'?",
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
                        string query = "DELETE FROM Fornecedor WHERE cod_forne = @codForne";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@codForne", codForne);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Fornecedor excluído com sucesso.");
                                CarregarFornecedor(); // Atualiza a lista após a exclusão
                            }
                            else
                            {
                                MessageBox.Show("Nenhum fornecedor encontrado com o código especificado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
                    }
                }
            }
        }


        // Botão Atualizar Lista Fornecedor
        private void btnAtualizarForne_Click(object sender, EventArgs e)
        {
            CarregarFornecedor();
        }


        // Botão Limpar Campos Fornecedor
        private void btnLimparForne_Click(object sender, EventArgs e)
        {
            LimparCamposFornecedor();
        }

        private void LimparCamposFornecedor()
        {
            txtCodForne.Text = "";
            txtNomeForne.Clear();
            txtCNPJ.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtSite.Clear();

            txtBuscarForne.Text = "inserir código do fornecedor...";
            txtBuscarForne.ForeColor = Color.Gray;

        }


        //
        // PARTE DA COMPRA
        //
        private void CarregarCompra()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                        SELECT 
                            Compra.cod_compra, 
                            Fornecedor.cod_forne,
                            Produto.cod_prod,
                            Produto.nome_prod,
                            Compra.data_compra,
                            Compra.valor_unid_compra,
                            Compra.qtd_item_compra,
                            Compra.valor_total_compra
                        FROM Compra
                        INNER JOIN Fornecedor ON Compra.cod_forne = Fornecedor.cod_forne
                        INNER JOIN Produto ON Compra.cod_prod = Produto.cod_prod";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listCompra.AutoGenerateColumns = true;
                    listCompra.DataSource = dataTable;
                    listCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // Ajuste dos cabeçalhos das colunas
                    listCompra.Columns["cod_compra"].HeaderText = "Código da Compra";
                    listCompra.Columns["cod_forne"].HeaderText = "Código do Fornecedor";
                    listCompra.Columns["cod_prod"].HeaderText = "Código do Produto";
                    listCompra.Columns["nome_prod"].HeaderText = "Produto";
                    listCompra.Columns["data_compra"].HeaderText = "Data da Compra";
                    listCompra.Columns["valor_unid_compra"].HeaderText = "Valor Unitário";
                    listCompra.Columns["qtd_item_compra"].HeaderText = "Quantidade";
                    listCompra.Columns["valor_total_compra"].HeaderText = "Valor Total";

                    // Formatação dos valores com 2 casas decimais
                    listCompra.Columns["valor_unid_compra"].DefaultCellStyle.Format = "F2";
                    listCompra.Columns["valor_total_compra"].DefaultCellStyle.Format = "F2";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao buscar dados das compras: " + erro.Message);
                }
            }
        }

        private void listCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = listCompra.Rows[e.RowIndex];

                txtCodCompra.Text = row.Cells["cod_compra"].Value.ToString();
                txtCodForneC.Text = row.Cells["cod_forne"].Value.ToString();
                txtCodProdC.Text = row.Cells["cod_prod"].Value.ToString();
                txtValorUnidC.Text = Convert.ToDecimal(row.Cells["valor_unid_compra"].Value).ToString("F2");
                txtValorTotalC.Text = Convert.ToDecimal(row.Cells["valor_total_compra"].Value).ToString("F2");
                txtQtdC.Text = row.Cells["qtd_item_compra"].Value.ToString();
                txtDataC.Text = Convert.ToDateTime(row.Cells["data_compra"].Value).ToString("dd-MM-yyyy");
            }
        }


        // BUSCAR COMPRA PELO CODIGO
        private void txtBuscarCompra_Enter(object sender, EventArgs e)
        {
            // Limpa o texto de placeholder quando o campo for focado
            if (txtBuscarCompra.Text == "inserir código da compra...")
            {
                txtBuscarCompra.Text = "";
                txtBuscarCompra.ForeColor = Color.Black;
            }
        }

        private void txtBuscarCompra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarCompra.Text))
            {
                txtBuscarCompra.Text = "inserir código da compra...";
                txtBuscarCompra.ForeColor = Color.Gray;
            }
        }

        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarCompra.Text) && txtBuscarCompra.Text != "inserir código da compra...")
            {
                string codigoCompra = txtBuscarCompra.Text.Trim();
                bool found = false; // Flag para verificar se encontrou o código da compra

                foreach (DataGridViewRow row in listCompra.Rows)
                {
                    if (row.Cells["cod_compra"].Value != null && row.Cells["cod_compra"].Value.ToString() == codigoCompra)
                    {
                        txtCodCompra.Text = row.Cells["cod_compra"].Value.ToString();
                        txtCodForneC.Text = row.Cells["cod_forne"].Value.ToString();
                        txtCodProdC.Text = row.Cells["cod_prod"].Value.ToString();
                        txtValorUnidC.Text = Convert.ToDecimal(row.Cells["valor_unid_compra"].Value).ToString("F2");
                        txtValorTotalC.Text = Convert.ToDecimal(row.Cells["valor_total_compra"].Value).ToString("F2");
                        txtQtdC.Text = row.Cells["qtd_item_compra"].Value.ToString();
                        txtDataC.Text = Convert.ToDateTime(row.Cells["data_compra"].Value).ToString("dd-MM-yyyy");

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Compra não encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código de compra válido.");
            }
        }


        // Evento para preencher o nome do fornecedor
        private void txtCodForneC_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o código do fornecedor tem o numero de caracteres corretos
            if (txtCodForneC.Text.Length >= 1 && txtCodForneC.Text.Length <= 2)
            {
                string queryForne = "SELECT nome_fantasia FROM Fornecedor WHERE cod_forne = @codForne";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(queryForne, connection);
                        cmd.Parameters.AddWithValue("@codForne", txtCodForneC.Text);

                        connection.Open();
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtNomeForneC.Text = result.ToString();
                        }
                        else
                        {
                            txtNomeForneC.Text = "";
                            MessageBox.Show("Fornecedor não encontrado.");
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao buscar nome do fornecedor: " + erro.Message);
                    }
                }
            }
            else
            {
                txtNomeForneC.Text = "";
            }
        }

        // Evento para preencher o nome do produto
        private void txtCodProdC_TextChanged(object sender, EventArgs e)
        {
            // Verifica se o código do produto possui o tamanho completo (5 caracteres)
            if (txtCodProdC.Text.Length == 5)
            {
                string queryProd = "SELECT nome_prod FROM Produto WHERE cod_prod = @codProd";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand(queryProd, connection);
                        cmd.Parameters.AddWithValue("@codProd", txtCodProdC.Text);

                        connection.Open();
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            txtNomeProdC.Text = result.ToString();
                        }
                        else
                        {
                            txtNomeProdC.Text = "";
                            MessageBox.Show("Produto não encontrado.");
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao buscar nome do produto: " + erro.Message);
                    }
                }
            }
            else
            {
                txtNomeProdC.Text = "";
            }
        }


        private void txtValorUnidC_TextChanged(object sender, EventArgs e)
        {
            CalcularValorTotalItemCompra();
        }

        private void txtQtdC_TextChanged(object sender, EventArgs e)
        {
            CalcularValorTotalItemCompra();
        }

        private void CalcularValorTotalItemCompra()
        {
            if (double.TryParse(txtValorUnidC.Text, out double valorUnidCompra) &&
                double.TryParse(txtQtdC.Text, out double qtdItemCompra))
            {
                double valorTotalCompra = valorUnidCompra * qtdItemCompra;

                txtValorTotalC.Text = valorTotalCompra.ToString("F2");
            }
            else
            {
                txtValorTotalC.Text = "";
            }
        }


        // Botão Gravar Compra
        private void btnGravarCompra_Click(object sender, EventArgs e)
        {
            CriarCompra();
        }

        private void CriarCompra()
        {
            // Valida se os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(txtCodForneC.Text) ||
                string.IsNullOrWhiteSpace(txtCodProdC.Text) ||
                string.IsNullOrWhiteSpace(txtDataC.Text) ||
                string.IsNullOrWhiteSpace(txtValorUnidC.Text) ||
                string.IsNullOrWhiteSpace(txtQtdC.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            decimal valorUnidCompra;
            int qtdItemCompra;

            if (!decimal.TryParse(txtValorUnidC.Text, out valorUnidCompra) ||
                !int.TryParse(txtQtdC.Text, out qtdItemCompra))
            {
                MessageBox.Show("Por favor, insira valores válidos para preço unitário e quantidade.");
                return;
            }

            // Verifica se a compra já existe no banco de dados
            if (!string.IsNullOrWhiteSpace(txtCodCompra.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string checkQuery = "SELECT COUNT(*) FROM Compra WHERE cod_compra = @codCompra";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@codCompra", txtCodCompra.Text);
                            int compraExistente = (int)checkCommand.ExecuteScalar();

                            if (compraExistente > 0)
                            {
                                MessageBox.Show("Código de compra já existe. Por favor, verificar.");
                                LimparCamposCompra();
                                return;
                            }
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao verificar o código da compra: " + erro.Message);
                        return;
                    }
                }
            }

            // Criação de nova compra
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO Compra (cod_forne, cod_prod, data_compra, valor_unid_compra, qtd_item_compra) " +
                                   "VALUES (@codForne, @codProd, @dataCompra, @valorUnidCompra, @qtdItemCompra); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codForne", txtCodForneC.Text);
                        command.Parameters.AddWithValue("@codProd", txtCodProdC.Text);
                        command.Parameters.AddWithValue("@dataCompra", txtDataC.Text);
                        command.Parameters.AddWithValue("@valorUnidCompra", valorUnidCompra);
                        command.Parameters.AddWithValue("@qtdItemCompra", qtdItemCompra);

                        var novoCodigo = command.ExecuteScalar();

                        if (novoCodigo != null)
                        {
                            MessageBox.Show($"Compra criada com sucesso. Código gerado: {novoCodigo}");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao gerar o código para a compra.");
                        }

                        CarregarCompra();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar compra: " + ex.Message);
                }
            }

            LimparCamposCompra();
        }


        // Botão Alterar Compra
        private void btnAlterarCompra_Click(object sender, EventArgs e)
        {
            AlterarCompra();
        }

        private void AlterarCompra()
        {
            if (string.IsNullOrWhiteSpace(txtCodCompra.Text) ||
                string.IsNullOrWhiteSpace(txtCodForneC.Text) ||
                string.IsNullOrWhiteSpace(txtCodProdC.Text) ||
                string.IsNullOrWhiteSpace(txtDataC.Text) ||
                string.IsNullOrWhiteSpace(txtValorUnidC.Text) ||
                string.IsNullOrWhiteSpace(txtQtdC.Text))
            {
                MessageBox.Show("Por favor, selecione uma compra e preencha todos os campos.");
                return;
            }

            decimal valorUnidCompra;
            int qtdItemCompra;

            if (!decimal.TryParse(txtValorUnidC.Text, out valorUnidCompra) ||
                !int.TryParse(txtQtdC.Text, out qtdItemCompra))
            {
                MessageBox.Show("Por favor, insira valores válidos para preço unitário e quantidade.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "UPDATE Compra SET cod_forne = @codForne, cod_prod = @codProd, data_compra = @dataCompra, " +
                                   "valor_unid_compra = @valorUnidCompra, qtd_item_compra = @qtdItemCompra WHERE cod_compra = @codCompra";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codCompra", txtCodCompra.Text);
                        command.Parameters.AddWithValue("@codForne", txtCodForneC.Text);
                        command.Parameters.AddWithValue("@codProd", txtCodProdC.Text);
                        command.Parameters.AddWithValue("@dataCompra", txtDataC.Text);
                        command.Parameters.AddWithValue("@valorUnidCompra", valorUnidCompra);
                        command.Parameters.AddWithValue("@qtdItemCompra", qtdItemCompra);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Compra atualizada com sucesso.");
                    CarregarCompra();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar compra: " + ex.Message);
                }
            }

            LimparCamposCompra();
        }


        // Botão Excluir Compra
        private void btnExcluirCompra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodCompra.Text))
            {
                MessageBox.Show("Por favor, selecione uma compra para excluir.");
                return;
            }

            string codCompra = txtCodCompra.Text;

            var confirmResult = MessageBox.Show($"Confirmar exclusão da compra com código '{codCompra}'?",
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
                        string query = "DELETE FROM Compra WHERE cod_compra = @codCompra";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@codCompra", codCompra);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Compra excluída com sucesso.");
                                CarregarCompra();
                            }
                            else
                            {
                                MessageBox.Show("Nenhuma compra encontrada com o código especificado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir compra: " + ex.Message);
                    }
                }
            }
        }


        // Botãp Atualizar Lista de Compras
        private void btnAtualizarCompra_Click(object sender, EventArgs e)
        {
            CarregarCompra();
        }


        // Botão Limpar Campos Compra
        private void btnLimparCompra_Click(object sender, EventArgs e)
        {
            LimparCamposCompra();
        }

        private void LimparCamposCompra()
        {
            txtCodCompra.Text = "";
            txtCodForneC.Text = "";
            txtNomeForneC.Text = "";
            txtCodProdC.Text = "";
            txtNomeProdC.Text = "";
            txtDataC.Clear();
            txtValorUnidC.Clear();
            txtQtdC.Clear();
            txtValorTotalC.Text = "";

            txtDataC.Text = DateTime.Now.ToString("dd-MM-yyyy");

            txtBuscarCompra.Text = "inserir código da compra...";
            txtBuscarCompra.ForeColor = Color.Gray;
        }
    }
}
