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
    public partial class TelaGerencialVendas : Form
    {
        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";

        public TelaGerencialVendas()
        {
            InitializeComponent();
        }

        private void TelaGerencialVendas_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
            CarregarLucroPedidos();
            CalcularTotais();
        }

        //
        // PARTE DE HISTORICO DE PEDIDO
        //
        private void CarregarPedidos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                        SELECT Pedido.cod_pedido, 
                               Pedido.data_pedido, 
                               Cliente.nome_cli, 
                               Cliente.CPF_cli, 
                               Cliente.CNPJ_cli, 
                               Produto.cod_prod, 
                               Produto.nome_prod, 
                               Produto.valor_venda, 
                               Item_Pedido.qtd_item_pedido, 
                               (Produto.valor_venda * Item_Pedido.qtd_item_pedido) AS valor_total_p, 
                               Pedido.forma_pag_p, 
                               Funcionario.matricula
                        FROM Pedido
                        INNER JOIN Item_Pedido ON Item_Pedido.cod_pedido = Pedido.cod_pedido
                        INNER JOIN Produto ON Produto.cod_prod = Item_Pedido.cod_prod
                        INNER JOIN Cliente ON Cliente.cod_cli = Pedido.cod_cli
                        INNER JOIN Funcionario ON Funcionario.matricula = Pedido.matricula";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listaPedidos.AutoGenerateColumns = true;
                    listaPedidos.DataSource = dataTable;
                    listaPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    listaPedidos.Columns["cod_pedido"].HeaderText = "Código do Pedido";
                    listaPedidos.Columns["data_pedido"].HeaderText = "Data do Pedido";
                    listaPedidos.Columns["nome_cli"].HeaderText = "Nome do Cliente";
                    listaPedidos.Columns["CPF_cli"].HeaderText = "CPF do Cliente";
                    listaPedidos.Columns["CNPJ_cli"].HeaderText = "CNPJ do Cliente";
                    listaPedidos.Columns["cod_prod"].HeaderText = "Código Produto";
                    listaPedidos.Columns["nome_prod"].HeaderText = "Nome do Produto";
                    listaPedidos.Columns["valor_venda"].HeaderText = "Valor Unitário (R$)";
                    listaPedidos.Columns["valor_venda"].DefaultCellStyle.Format = "F2";
                    listaPedidos.Columns["qtd_item_pedido"].HeaderText = "Quantidade";
                    listaPedidos.Columns["valor_total_p"].HeaderText = "Valor Total (R$)";
                    listaPedidos.Columns["valor_total_p"].DefaultCellStyle.Format = "F2";
                    listaPedidos.Columns["forma_pag_p"].HeaderText = "Forma de Pagamento";
                    listaPedidos.Columns["matricula"].HeaderText = "Matrícula";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao buscar dados da tabela Pedido: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Buscar pedido para obter total
        private void txtBucarPedido_Enter(object sender, EventArgs e)
        {
            if (txtBucarPedido.Text == "inserir código do pedido...")
            {
                txtBucarPedido.Text = "";
                txtBucarPedido.ForeColor = Color.Black;
            }
        }

        private void txtBucarPedido_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBucarPedido.Text))
            {
                txtBucarPedido.Text = "inserir código do pedido...";
                txtBucarPedido.ForeColor = Color.Gray;
            }
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBucarPedido.Text) || txtBucarPedido.Text == "inserir código do pedido...")
                {
                    MessageBox.Show("Insira o código do pedido para realizar a busca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string codigoPedido = txtBucarPedido.Text.Trim();
                decimal valorTotal = 0;
                bool pedidoEncontrado = false;

                // Criar um novo DataTable para armazenar as linhas filtradas
                DataTable dataTableFiltrado = ((DataTable)listaPedidos.DataSource).Clone();

                foreach (DataGridViewRow row in listaPedidos.Rows)
                {
                    if (row.Cells["cod_pedido"].Value != null && row.Cells["valor_total_p"].Value != null)
                    {
                        string codPedidoLinha = row.Cells["cod_pedido"].Value.ToString();

                        if (codPedidoLinha == codigoPedido)
                        {
                            pedidoEncontrado = true; // Pedido encontrado
                            DataRow novaLinha = dataTableFiltrado.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                novaLinha[cell.ColumnIndex] = cell.Value;
                            }
                            dataTableFiltrado.Rows.Add(novaLinha);

                            valorTotal += Convert.ToDecimal(row.Cells["valor_total_p"].Value);
                        }
                    }
                }

                if (!pedidoEncontrado)
                {
                    MessageBox.Show("Código do pedido não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtBucarPedido.Text = "inserir código do pedido...";
                    txtBucarPedido.ForeColor = Color.Gray;

                    txtValorTotalPed.Text = "";

                    return;
                }

                listaPedidos.DataSource = dataTableFiltrado;

                txtValorTotalPed.Text = valorTotal.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os pedidos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Botão para limpar campo de valor total e recarregar a lista ao modo original
        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            try
            {
                txtBucarPedido.Text = "inserir código do pedido...";
                txtBucarPedido.ForeColor = Color.Gray;

                txtValorTotalPed.Text = "";

                CarregarPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a lista de pedidos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //
        // PARTE DAS INFORMAÇÕES FISCAIS
        //
        private void CarregarLucroPedidos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                        SELECT Pedido.cod_pedido, 
                               Produto.nome_prod, 
                               Item_Pedido.qtd_item_pedido, 
                               Produto.valor_compra, 
                               (Item_Pedido.qtd_item_pedido * Produto.valor_compra) AS valor_custo, 
                               Item_Pedido.valor_unid_pedido, 
                               (Item_Pedido.qtd_item_pedido * Item_Pedido.valor_unid_pedido) AS valor_faturado, 
                               ((Item_Pedido.qtd_item_pedido * Item_Pedido.valor_unid_pedido) - (Item_Pedido.qtd_item_pedido * Produto.valor_compra)) AS valor_lucro
                        FROM Produto
                        INNER JOIN Item_Pedido ON Produto.cod_prod = Item_Pedido.cod_prod
                        INNER JOIN Pedido ON Pedido.cod_pedido = Item_Pedido.cod_pedido";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    listaLucroPedidos.AutoGenerateColumns = true;
                    listaLucroPedidos.DataSource = dataTable;
                    listaLucroPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    listaLucroPedidos.Columns["cod_pedido"].HeaderText = "Código do Pedido";
                    listaLucroPedidos.Columns["nome_prod"].HeaderText = "Produto";
                    listaLucroPedidos.Columns["qtd_item_pedido"].HeaderText = "Quantidade";
                    listaLucroPedidos.Columns["valor_compra"].HeaderText = "Valor Unitário Compra (R$)";
                    listaLucroPedidos.Columns["valor_compra"].DefaultCellStyle.Format = "F2";
                    listaLucroPedidos.Columns["valor_custo"].HeaderText = "Custo Total (R$)";
                    listaLucroPedidos.Columns["valor_custo"].DefaultCellStyle.Format = "F2";
                    listaLucroPedidos.Columns["valor_unid_pedido"].HeaderText = "Valor Unitário Venda (R$)";
                    listaLucroPedidos.Columns["valor_unid_pedido"].DefaultCellStyle.Format = "F2";
                    listaLucroPedidos.Columns["valor_faturado"].HeaderText = "Faturamento Total (R$)";
                    listaLucroPedidos.Columns["valor_faturado"].DefaultCellStyle.Format = "F2";
                    listaLucroPedidos.Columns["valor_lucro"].HeaderText = "Lucro Total (R$)";
                    listaLucroPedidos.Columns["valor_lucro"].DefaultCellStyle.Format = "F2";
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao buscar dados de lucro dos pedidos: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Botão para extrair o relatório de custo, faturamento e lucro
        private void btnExtrairLucroPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                string folderPath = @"C:\Sistema Bonini Farms\relatoriosvenda";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string filePath = Path.Combine(folderPath, "Lucro_Pedidos.csv");

                StringBuilder csvContent = new StringBuilder();

                foreach (DataGridViewColumn column in listaLucroPedidos.Columns)
                {
                    csvContent.Append(column.HeaderText + ";");
                }
                csvContent.AppendLine();

                foreach (DataGridViewRow row in listaLucroPedidos.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        csvContent.Append(cell.Value.ToString() + ";");
                    }
                    csvContent.AppendLine();
                }

                System.IO.File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);

                MessageBox.Show("Histórico de lucro dos pedidos exportado com sucesso para o arquivo: " + filePath, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao extrair o histórico de lucro dos pedidos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Metodo para trazer valores de custo, faturamento e lucro
        private void CalcularTotais()
        {
            try
            {
                decimal totalCusto = 0;
                decimal totalFaturado = 0;
                decimal totalLucro = 0;

                // Iterar sobre as linhas da DataGridView para somar os valores das colunas
                foreach (DataGridViewRow row in listaLucroPedidos.Rows)
                {
                    if (row.Cells["valor_custo"].Value != null && row.Cells["valor_faturado"].Value != null && row.Cells["valor_lucro"].Value != null)
                    {
                        // Somar os valores de custo, faturamento e lucro
                        totalCusto += Convert.ToDecimal(row.Cells["valor_custo"].Value);
                        totalFaturado += Convert.ToDecimal(row.Cells["valor_faturado"].Value);
                        totalLucro += Convert.ToDecimal(row.Cells["valor_lucro"].Value);
                    }
                }

                // Atualizar os campos de texto com os totais calculados
                txtValorTotalCusto.Text = totalCusto.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
                txtValorTotalFatu.Text = totalFaturado.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
                txtValorTotalLucro.Text = totalLucro.ToString("C2", new System.Globalization.CultureInfo("pt-BR"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular totais: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Botão para fechar a tela
        private void btnSairTelaGerencial_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
