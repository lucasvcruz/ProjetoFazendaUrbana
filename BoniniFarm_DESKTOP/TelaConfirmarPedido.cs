using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BoniniFarm2
{
    public partial class TelaConfirmarPedido : Form
    {
        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";
        private DataGridView _listaProdutosEmissao;
        private string _matriculaFuncionario;
        public bool PedidoEmitidoComSucesso { get; private set; } = false; // Informa se o pedido foi realmente emitido.

        public TelaConfirmarPedido(DataGridView listaProdutos, string matriculaFuncionario)
        {
            InitializeComponent();
            _listaProdutosEmissao = listaProdutos;
            _matriculaFuncionario = matriculaFuncionario;
        }

        private void TelaConfirmarPedido_Load(object sender, EventArgs e)
        {
            InicializarColunasDataGridView();
            PreencherItensPedido();
            PreencherMatriculaFuncionario();
            txtDataEmissao.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void InicializarColunasDataGridView()
        {
            listaProdutosEmissao.Columns.Add("NumeroLinha", "N° Linha");
            listaProdutosEmissao.Columns.Add("CodProd", "Código do Produto");
            listaProdutosEmissao.Columns.Add("NomeProd", "Nome do Produto");
            listaProdutosEmissao.Columns.Add("ValorUnid", "Valor Unitário");
            listaProdutosEmissao.Columns.Add("Quantidade", "Quantidade");
            listaProdutosEmissao.Columns.Add("ValorTotal", "Valor Total");

            listaProdutosEmissao.Columns["NumeroLinha"].Width = 30;
            listaProdutosEmissao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaProdutosEmissao.Columns["ValorUnid"].DefaultCellStyle.Format = "F2";
            listaProdutosEmissao.Columns["ValorTotal"].DefaultCellStyle.Format = "F2";
        }

        // Preencher informações da tabela da TelaVenda para a TelaConfirmarPedido
        private void PreencherItensPedido()
        {
            decimal totalAPagar = 0;

            listaProdutosEmissao.Rows.Clear();

            foreach (DataGridViewRow row in _listaProdutosEmissao.Rows)
            {
                if (row.Cells["ValorTotal"].Value != null)
                {
                    listaProdutosEmissao.Rows.Add(
                        row.Cells["NumeroLinha"].Value.ToString(),
                        row.Cells["CodProd"].Value.ToString(),
                        row.Cells["NomeProd"].Value.ToString(),
                        row.Cells["ValorUnid"].Value.ToString(),
                        Convert.ToDecimal(row.Cells["Quantidade"].Value).ToString(),
                        row.Cells["ValorTotal"].Value.ToString()
                    );
                    // Calculo do total do Pedido
                    totalAPagar += Convert.ToDecimal(row.Cells["ValorTotal"].Value);
                }
            }
            txtValorTotalEmissao.Text = totalAPagar.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
        }

        private void PreencherMatriculaFuncionario()
        {
            txtMatriculaFuncEmissao.Text = _matriculaFuncionario;
        }


        // Botao Emitir Nota Fiscal e Movimentar Estoque
        private void btnEmitirNf_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações obrigatórias
                if (string.IsNullOrWhiteSpace(txtMatriculaFuncEmissao.Text) ||
                    string.IsNullOrWhiteSpace(txtDataEmissao.Text) ||
                    string.IsNullOrWhiteSpace(txtFormaPag.Text) ||
                    string.IsNullOrWhiteSpace(txtValorTotalEmissao.Text))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validações de CPF, CNPJ e Nome do Cliente
                bool cpfPreenchido = txtCPFCliente.MaskCompleted;
                bool cnpjPreenchido = txtCNPJCliente.MaskCompleted;

                if ((cpfPreenchido || cnpjPreenchido) && string.IsNullOrWhiteSpace(txtNomeCliente.Text))
                {
                    MessageBox.Show("Preencha o nome do cliente quando informar CPF ou CNPJ.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obter código do cliente
                string nomeCliente = txtNomeCliente.Text;
                string cpfCliente = cpfPreenchido ? txtCPFCliente.Text.Replace(".", "") : null; //Remove os caracteres não necessarios para introduzir no banco de dados
                string cnpjCliente = cnpjPreenchido ? txtCNPJCliente.Text.Replace(".", "").Replace("/", "") : null;//Remove os caracteres não necessarios para introduzir no banco

                int codigoCliente = ObterOuCriarCliente(nomeCliente, cpfCliente, cnpjCliente);

                decimal valorTotalEmissao;
                if (!decimal.TryParse(txtValorTotalEmissao.Text, System.Globalization.NumberStyles.Currency, new System.Globalization.CultureInfo("pt-BR"), out valorTotalEmissao))
                {
                    MessageBox.Show("O valor total de emissão não está no formato correto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inserir pedido
                int codigoPedido = InserirPedido(
                    codigoCliente,
                    txtMatriculaFuncEmissao.Text,
                    txtDataEmissao.Text,
                    txtFormaPag.Text,
                    valorTotalEmissao
                );

                foreach (DataGridViewRow row in listaProdutosEmissao.Rows)
                {
                    if (row.Cells["CodProd"].Value != null &&
                        row.Cells["Quantidade"].Value != null &&
                        row.Cells["ValorUnid"].Value != null)
                    {
                        InserirItemPedido(
                            codigoPedido,
                            Convert.ToInt32(row.Cells["CodProd"].Value),
                            Convert.ToInt32(row.Cells["Quantidade"].Value),
                            Convert.ToDecimal(row.Cells["ValorUnid"].Value)
                        );
                    }
                }

                // Criar nota fiscal (arquivo externo)
                CriarNotaFiscal(codigoPedido, nomeCliente, cpfCliente, cnpjCliente);

                // Indicar que o pedido foi emitido com sucesso
                PedidoEmitidoComSucesso = true;

                MessageBox.Show($"Pedido emitido com sucesso!\nCódigo do Pedido: {codigoPedido}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao emitir o pedido: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Buscar Codigo do Cliente se CPF ou CNPJ estiver cadastrado
        private int ObterOuCriarCliente(string nomeCliente, string cpfCliente, string cnpjCliente)
        {
            int codigoCliente = 1; // Cliente não identificado por padrão

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                conexao.Open();

                if (!string.IsNullOrWhiteSpace(cpfCliente) || !string.IsNullOrWhiteSpace(cnpjCliente))
                {
                    string queryBuscarCliente = @"
                        SELECT cod_cli 
                        FROM Cliente 
                        WHERE CPF_cli = @CPF OR CNPJ_cli = @CNPJ";

                    SqlCommand comandoBuscar = new SqlCommand(queryBuscarCliente, conexao);
                    comandoBuscar.Parameters.AddWithValue("@CPF", cpfCliente ?? (object)DBNull.Value);
                    comandoBuscar.Parameters.AddWithValue("@CNPJ", cnpjCliente ?? (object)DBNull.Value);

                    object resultado = comandoBuscar.ExecuteScalar();

                    if (resultado != null)
                    {
                        codigoCliente = Convert.ToInt32(resultado);
                    }
                    else
                    {
                        // Cliente não existe, vai criar um novo
                        string queryCriarCliente = @"
                            INSERT INTO Cliente (nome_cli, CPF_cli, CNPJ_cli) 
                            OUTPUT INSERTED.cod_cli
                            VALUES (@Nome, @CPF, @CNPJ)";

                        SqlCommand comandoCriar = new SqlCommand(queryCriarCliente, conexao);
                        comandoCriar.Parameters.AddWithValue("@Nome", nomeCliente);
                        comandoCriar.Parameters.AddWithValue("@CPF", cpfCliente ?? (object)DBNull.Value);
                        comandoCriar.Parameters.AddWithValue("@CNPJ", cnpjCliente ?? (object)DBNull.Value);

                        codigoCliente = (int)comandoCriar.ExecuteScalar();
                    }
                }
            }

            return codigoCliente;
        }


        // Inser na Tabela Pedido
        private int InserirPedido(int codigoCliente, string matriculaFuncionario, string dataPedido, string formaPagamento, decimal valorTotalPedido)
        {
            int codigoPedido;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Pedido (valor_total_pedido, data_pedido, forma_pag_p, cod_cli, matricula)
                    OUTPUT INSERTED.cod_pedido
                    VALUES (@ValorTotalPedido, @DataPedido, @FormaPag, @CodCli, @Matricula)";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@ValorTotalPedido", valorTotalPedido);
                comando.Parameters.AddWithValue("@DataPedido", dataPedido);
                comando.Parameters.AddWithValue("@FormaPag", formaPagamento);
                comando.Parameters.AddWithValue("@CodCli", codigoCliente);
                comando.Parameters.AddWithValue("@Matricula", matriculaFuncionario);

                conexao.Open();
                codigoPedido = (int)comando.ExecuteScalar();
            }

            return codigoPedido;
        }


        // Insert na Tabela Item_Pedido
        private void InserirItemPedido(int codigoPedido, int codigoProduto, int quantidade, decimal valorUnitario)
        {
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Item_Pedido (cod_prod, valor_unid_pedido, qtd_item_pedido, cod_pedido)
                    VALUES (@CodProd, @ValorUnid, @Quantidade, @CodPedido)";
                SqlCommand comando = new SqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@CodProd", codigoProduto);
                comando.Parameters.AddWithValue("@ValorUnid", valorUnitario);
                comando.Parameters.AddWithValue("@Quantidade", quantidade);
                comando.Parameters.AddWithValue("@CodPedido", codigoPedido);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }


        // Criação da Nota Fiscal
        private void CriarNotaFiscal(int codigoPedido, string nomeCliente, string cpfCliente, string cnpjCliente)
        {
            string caminhoArquivo = $@"C:\Sistema Bonini Farms\notasfiscais\Pedido_{codigoPedido}.txt";

            try
            {
                // Cria o diretório caso ele não exista
                Directory.CreateDirectory(@"C:\Sistema Bonini Farms\notasfiscais");

                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    // Cabeçalho da nota fiscal
                    writer.WriteLine("========== NOTA FISCAL ==========");
                    writer.WriteLine($"Código do Pedido: {codigoPedido}");
                    writer.WriteLine($"Data do Pedido: {txtDataEmissao.Text}");
                    writer.WriteLine($"Cliente: {(!string.IsNullOrWhiteSpace(nomeCliente) ? nomeCliente : "Cliente Não Identificado")}");
                    if (!string.IsNullOrWhiteSpace(cpfCliente)) writer.WriteLine($"CPF: {cpfCliente}");
                    if (!string.IsNullOrWhiteSpace(cnpjCliente)) writer.WriteLine($"CNPJ: {cnpjCliente}");
                    writer.WriteLine($"Forma de Pagamento: {txtFormaPag.Text}");
                    writer.WriteLine("--------------------------------");

                    // Lista de produtos
                    writer.WriteLine("Produtos:");
                    foreach (DataGridViewRow row in listaProdutosEmissao.Rows)
                    {
                        if (row.Cells["CodProd"].Value != null &&
                            row.Cells["NomeProd"].Value != null &&
                            row.Cells["Quantidade"].Value != null &&
                            row.Cells["ValorUnid"].Value != null &&
                            row.Cells["ValorTotal"].Value != null)
                        {
                            writer.WriteLine($"- Código: {row.Cells["CodProd"].Value}");
                            writer.WriteLine($"  Produto: {row.Cells["NomeProd"].Value}");
                            writer.WriteLine($"  Quantidade: {row.Cells["Quantidade"].Value}");
                            writer.WriteLine($"  Valor Unitário: {row.Cells["ValorUnid"].Value:C2}");
                            writer.WriteLine($"  Total: {row.Cells["ValorTotal"].Value:C2}");
                            writer.WriteLine("- - - - - - - - - - - -");
                        }
                    }

                    // Total do pedido
                    writer.WriteLine("--------------------------------");
                    writer.WriteLine($"Valor Total do Pedido: {txtValorTotalEmissao.Text}");
                    writer.WriteLine("================================");
                }

                MessageBox.Show($"Nota fiscal gerada com sucesso em:\n\n\n{caminhoArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar nota fiscal: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
