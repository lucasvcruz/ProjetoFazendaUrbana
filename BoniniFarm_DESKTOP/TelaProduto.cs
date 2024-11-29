using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace BoniniFarm2
{
    public partial class TelaProduto : Form
    {
        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";
        private Thread nt;
        private string matriculaUsuario;

        public TelaProduto(string matricula)
        {
            InitializeComponent();
            matriculaUsuario = matricula;
        }

        private void TelaProduto_Load(object sender, EventArgs e)
        {
            CarregarProduto();
            CarregarEstoque();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(imageProd, "Clique para visualizar a imagem em tamanho real");

            // Função de aumentar a imagem do produto
            imageProd.Click += (s, e) =>
            {
                ImagemProduto imagemProdutoForm = new ImagemProduto();

                imagemProdutoForm.ProdutoImagem = imageProd.Image;

                imagemProdutoForm.ShowDialog();
            };
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


        // Botão para Tela Recursos Humanos com verificação de permissão
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
                MessageBox.Show("Acesso negado. Você não possui permissão para acessar a Tela de Recursos Humanos.",
                                "Permissão Negada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        // Botão para Tela Login (Sair)
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
        // PARTE DO PRODUTO
        //
        //
        private void CarregarProduto()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Formata valor_venda e valor_compra para duas casas decimais na consulta SQL
                    string query = @"
                        SELECT 
                            cod_prod, 
                            nome_prod, 
                            FORMAT(valor_venda, 'N2') AS valor_venda, 
                            FORMAT(valor_compra, 'N2') AS valor_compra, 
                            medida,
                            qtd_min_prod, 
                            imagem_prod
                        FROM Produto";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listCadProduto.AutoGenerateColumns = true;
                    listCadProduto.DataSource = dataTable;
                    listCadProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    listCadProduto.Columns["cod_prod"].HeaderText = "Código";
                    listCadProduto.Columns["nome_prod"].HeaderText = "Nome do Produto";
                    listCadProduto.Columns["valor_venda"].HeaderText = "Valor de Venda";
                    listCadProduto.Columns["valor_compra"].HeaderText = "Valor de Compra";
                    listCadProduto.Columns["medida"].HeaderText = "Unidade de Medida";
                    listCadProduto.Columns["qtd_min_prod"].HeaderText = "Quantidade Mínima";
                    listCadProduto.Columns["imagem_prod"].HeaderText = "Imagem Produto";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao buscar dados da tabela Produto: " + erro.Message);
                }
            }
        }

        private void listCadProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = listCadProduto.Rows[e.RowIndex];

                // Atualizando os campos de texto
                txtCodProd.Text = row.Cells["cod_prod"].Value.ToString();
                txtNomeProd.Text = row.Cells["nome_prod"].Value.ToString();
                txtValorVenda.Text = Convert.ToDecimal(row.Cells["valor_venda"].Value).ToString("F2");
                txtValorCompra.Text = Convert.ToDecimal(row.Cells["valor_compra"].Value).ToString("F2");
                txtQtdProd.Text = row.Cells["qtd_min_prod"].Value.ToString();
                txtMedida.SelectedItem = row.Cells["medida"].Value.ToString();

                // Carregar a imagem do produto
                if (row.Cells["imagem_prod"].Value != DBNull.Value)
                {
                    byte[] imagemBytes = (byte[])row.Cells["imagem_prod"].Value;
                    using (var memoryStream = new MemoryStream(imagemBytes))
                    {
                        imageProd.Image = Image.FromStream(memoryStream);

                        // Atualizando a variável imagemProduto com a imagem carregada
                        imagemProduto = imagemBytes;  // Agora a imagem será armazenada para uso posterior
                    }
                }
                else
                {
                    imageProd.Image = null;
                    imagemProduto = null; // Limpa a variável imagemProduto
                }
            }
        }


        // BUSCAR PRODUTO COM CODIGO OU NOME
        private void txtBuscarProduto_Enter(object sender, EventArgs e)
        {
            if (txtBuscarProduto.Text == "inserir codigo ou nome do produto...")
            {
                txtBuscarProduto.Text = "";
                txtBuscarProduto.ForeColor = Color.Black;
            }
        }

        private void txtBuscarProduto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarProduto.Text))
            {
                txtBuscarProduto.Text = "inserir codigo ou nome do produto...";
                txtBuscarProduto.ForeColor = Color.Gray;
            }
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscarProduto.Text) && txtBuscarProduto.Text != "inserir codigo ou nome do produto...")
            {
                string pesquisa = txtBuscarProduto.Text.Trim();
                bool found = false; // Flag para verificar se encontrou o produto

                foreach (DataGridViewRow row in listCadProduto.Rows)
                {
                    if (row.Cells["cod_prod"].Value != null && row.Cells["cod_prod"].Value.ToString() == pesquisa ||
                        row.Cells["nome_prod"].Value != null && row.Cells["nome_prod"].Value.ToString().Equals(pesquisa, StringComparison.OrdinalIgnoreCase))
                    {
                        txtCodProd.Text = row.Cells["cod_prod"].Value.ToString();
                        txtNomeProd.Text = row.Cells["nome_prod"].Value.ToString();
                        txtValorVenda.Text = Convert.ToDecimal(row.Cells["valor_venda"].Value).ToString("F2");
                        txtValorCompra.Text = Convert.ToDecimal(row.Cells["valor_compra"].Value).ToString("F2");
                        txtQtdProd.Text = row.Cells["qtd_min_prod"].Value.ToString();
                        txtMedida.SelectedItem = row.Cells["medida"].Value.ToString();

                        if (row.Cells["imagem_prod"].Value != DBNull.Value)
                        {
                            byte[] imagemBytes = (byte[])row.Cells["imagem_prod"].Value;
                            using (var memoryStream = new MemoryStream(imagemBytes))
                            {
                                imageProd.Image = Image.FromStream(memoryStream);
                            }
                        }
                        else
                        {
                            imageProd.Image = null;
                        }

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Produto não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código ou nome do produto válido.");
            }
        }


        // Botão Carregar Imagem
        private byte[] imagemProduto;

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    imageProd.Image = Image.FromFile(imagePath); // Exibe a imagem selecionada

                    // Converte a imagem em um array de bytes
                    using (var memoryStream = new MemoryStream())
                    {
                        imageProd.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imagemProduto = memoryStream.ToArray();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma imagem foi selecionada.");
                }
            }
        }


        // Botão Gravar Produto
        private void btnGravarProd_Click(object sender, EventArgs e)
        {
            CriarProduto();
        }

        private void CriarProduto()
        {
            if (string.IsNullOrWhiteSpace(txtNomeProd.Text) ||
                string.IsNullOrWhiteSpace(txtValorVenda.Text) ||
                string.IsNullOrWhiteSpace(txtValorCompra.Text) ||
                txtMedida.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtQtdProd.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                return;
            }

            decimal valorVenda, valorCompra;
            int qtdMinProd;

            if (!decimal.TryParse(txtValorVenda.Text, out valorVenda) ||
                !decimal.TryParse(txtValorCompra.Text, out valorCompra) ||
                !int.TryParse(txtQtdProd.Text, out qtdMinProd))
            {
                MessageBox.Show("Por favor, insira valores válidos para preço e quantidade mínima.");
                return;
            }

            // Parte da validação do código já criado
            if (!string.IsNullOrWhiteSpace(txtCodProd.Text))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    try
                    {
                        string checkQuery = "SELECT 1 FROM Produto WHERE cod_prod = @codProd";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@codProd", txtCodProd.Text);
                            var resultado = checkCommand.ExecuteScalar();
                            if (resultado != null)
                            {
                                MessageBox.Show("Código de produto já existe. Por favor verificar.");
                                LimparCamposProduto();
                                return;
                            }
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao verificar o código do produto: " + erro.Message);
                        return;
                    }
                }
            }

            // Parte de criação de novo produto não cadastrado
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    string query = "INSERT INTO Produto (nome_prod, valor_venda, valor_compra, medida, qtd_min_prod, imagem_prod) " +
                                   "VALUES (@nomeProd, @valorVenda, @valorCompra, @medida, @qtdMinProd, @imagemProd); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nomeProd", txtNomeProd.Text);
                        command.Parameters.AddWithValue("@valorVenda", valorVenda);
                        command.Parameters.AddWithValue("@valorCompra", valorCompra);
                        command.Parameters.AddWithValue("@medida", txtMedida.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@qtdMinProd", qtdMinProd);
                        command.Parameters.AddWithValue("@imagemProd", imagemProduto ?? (object)DBNull.Value);

                        var novoCodigo = command.ExecuteScalar();

                        if (novoCodigo != null)
                        {
                            MessageBox.Show($"Produto '{txtNomeProd.Text}' criado com sucesso. Código gerado: {novoCodigo}");
                        }
                        else
                        {
                            MessageBox.Show("Erro ao gerar o código para o produto.");
                        }

                        CarregarProduto();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar produto: " + ex.Message);
                }
            }

            LimparCamposProduto();
        }


        // Botão Alterar Produto
        private void btnAlterarProd_Click(object sender, EventArgs e)
        {
            AlterarProduto();
        }

        private void AlterarProduto()
        {
            // Verifica se os campos de texto estão preenchidos
            if (string.IsNullOrWhiteSpace(txtCodProd.Text) ||
                string.IsNullOrWhiteSpace(txtNomeProd.Text) ||
                string.IsNullOrWhiteSpace(txtValorVenda.Text) ||
                string.IsNullOrWhiteSpace(txtValorCompra.Text) ||
                string.IsNullOrWhiteSpace(txtQtdProd.Text) ||
                txtMedida.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um produto e preencha todos os campos.");
                return;
            }

            // Validação dos campos numéricos
            if (!decimal.TryParse(txtValorVenda.Text, out decimal valorVenda) ||
                !decimal.TryParse(txtValorCompra.Text, out decimal valorCompra) ||
                !int.TryParse(txtQtdProd.Text, out int qtdMinProd))
            {
                MessageBox.Show("Por favor, insira valores válidos para preço e quantidade mínima.");
                return;
            }

            byte[] imagemAtual = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    // Verificar se o produto existe
                    string checkQuery = "SELECT imagem_prod FROM Produto WHERE cod_prod = @codProd";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@codProd", txtCodProd.Text);
                        var result = checkCommand.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("O código do produto não foi encontrado. Verifique e tente novamente.");
                            return;
                        }

                        // Obtém a imagem existente do banco de dados, se houver
                        if (result != DBNull.Value)
                            imagemAtual = (byte[])result;
                    }

                    // Atualizar o produto
                    string query = "UPDATE Produto SET nome_prod = @nomeProd, valor_venda = @valorVenda, valor_compra = @valorCompra, medida = @medida, qtd_min_prod = @qtdMinProd, imagem_prod = @imagemProd WHERE cod_prod = @codProd";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codProd", txtCodProd.Text);
                        command.Parameters.AddWithValue("@nomeProd", txtNomeProd.Text);
                        command.Parameters.AddWithValue("@valorVenda", valorVenda);
                        command.Parameters.AddWithValue("@valorCompra", valorCompra);
                        command.Parameters.AddWithValue("@medida", txtMedida.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@qtdMinProd", qtdMinProd);

                        // Se uma nova imagem for selecionada, usa essa nova; caso contrário, mantém a imagem existente
                        command.Parameters.AddWithValue("@imagemProd", imagemProduto ?? (object)imagemAtual ?? DBNull.Value);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Produto '{txtNomeProd.Text}' atualizado com sucesso.");
                    CarregarProduto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
                }
            }

            LimparCamposProduto();
        }



        // Botão Excluir Produto
        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodProd.Text))
            {
                MessageBox.Show("Por favor, selecione um produto para excluir.");
                return;
            }

            string codProd = txtCodProd.Text;

            var confirmResult = MessageBox.Show($"Confirmar exclusão do produto com código '{codProd}'?",
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
                        string query = "DELETE FROM Produto WHERE cod_prod = @codProd";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@codProd", codProd);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Produto excluído com sucesso.");
                                CarregarProduto();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum produto encontrado com o código especificado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir produto: " + ex.Message);
                    }
                }
            }
        }


        // Botão Atualizar Lista Produto
        private void btnAtualizarProd_Click(object sender, EventArgs e)
        {
            CarregarProduto();
        }


        // Botão Limpar Campos Produto
        private void btnLimparProd_Click(object sender, EventArgs e)
        {
            LimparCamposProduto();
        }

        private void LimparCamposProduto()
        {
            txtCodProd.Text = "";
            txtNomeProd.Clear();
            txtValorVenda.Clear();
            txtValorCompra.Clear();
            txtQtdProd.Clear();
            imageProd.Image = null;
            txtMedida.SelectedIndex = -1;

            txtNomeProd.Focus();

            txtBuscarProduto.Text = "inserir codigo ou nome do produto...";
            txtBuscarProduto.ForeColor = Color.Gray;
        }

        //
        //
        // PARTE ESTOQUE
        //
        //
        private void CarregarEstoque()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT Estoque.cod_prod, Produto.nome_prod, Produto.medida,Produto.qtd_min_prod, Estoque.qtd_estoque FROM Estoque INNER JOIN Produto ON Estoque.cod_prod = Produto.cod_prod";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listEstoque.AutoGenerateColumns = true;
                    listEstoque.DataSource = dataTable;
                    listEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Define os cabeçalhos das colunas
                    listEstoque.Columns["cod_prod"].HeaderText = "Código do Produto";
                    listEstoque.Columns["nome_prod"].HeaderText = "Nome do Produto";
                    listEstoque.Columns["medida"].HeaderText = "Unidade de Medida";
                    listEstoque.Columns["qtd_min_prod"].HeaderText = "Quantidade Minima";
                    listEstoque.Columns["qtd_estoque"].HeaderText = "Quantidade em Estoque";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao buscar dados do estoque: " + erro.Message);
                }
            }
        }

        //Botão Consultar Lista Estoque
        private void btnConsultarE_Click(object sender, EventArgs e)
        {
            string codProduto = txtCodProdE.Text.Trim();
            string nomeProduto = txtNomeProdE.Text.Trim();

            if (string.IsNullOrWhiteSpace(codProduto) && string.IsNullOrWhiteSpace(nomeProduto))
            {
                MessageBox.Show("Por favor, informe o código ou o nome do produto.");
                return;
            }

            bool produtoEncontrado = false;

            if (!string.IsNullOrWhiteSpace(codProduto))
            {
                foreach (DataGridViewRow row in listEstoque.Rows)
                {
                    if (row.Cells["cod_prod"].Value.ToString() == codProduto)
                    {
                        txtNomeProdE.Text = row.Cells["nome_prod"].Value.ToString();
                        txtQtdProdE.Text = row.Cells["qtd_estoque"].Value.ToString();
                        produtoEncontrado = true;
                        break;
                    }
                }
            }

            if (!produtoEncontrado && !string.IsNullOrWhiteSpace(nomeProduto))
            {
                foreach (DataGridViewRow row in listEstoque.Rows)
                {
                    if (row.Cells["nome_prod"].Value.ToString().Equals(nomeProduto, StringComparison.OrdinalIgnoreCase))
                    {
                        txtCodProdE.Text = row.Cells["cod_prod"].Value.ToString();
                        txtQtdProdE.Text = row.Cells["qtd_estoque"].Value.ToString();
                        produtoEncontrado = true;
                        break;
                    }
                }
            }

            if (!produtoEncontrado)
            {
                MessageBox.Show("Produto não encontrado.");
            }
        }


        //Botão Atualizar Lista Estoque
        private void btnAtualizarE_Click(object sender, EventArgs e)
        {
            CarregarEstoque();
        }


        //Botão Limpar Campos Estoque
        private void btnLimparE_Click(object sender, EventArgs e)
        {

            txtCodProdE.Clear();
            txtNomeProdE.Text = "";
            txtQtdProdE.Text = "";

            txtCodProdE.Focus();
        }
    }
}
