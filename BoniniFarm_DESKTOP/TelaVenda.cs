using System.Data.SqlClient;
using System.Globalization;

namespace BoniniFarm2
{
    public partial class TelaVenda : Form
    {
        private string connectionString = "Data Source=LucasCruz;Initial Catalog=BoniniFarm2;Integrated Security=True;";
        private string matriculaUsuario;
        private Thread nt;

        public TelaVenda(string matricula)
        {
            InitializeComponent();
            matriculaUsuario = matricula;
            this.Load += TelaVenda_Load;
        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {
            txtMatricula.Text = matriculaUsuario;
            CarregarListaCarrinho();
            txtData.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        //
        //
        // PARTE DE ADICIONAR ITEM AO CARRINHO
        //
        //

        private void CarregarListaCarrinho()
        {
            listaProdutos.Columns.Add("NumeroLinha", "N° Linha");
            listaProdutos.Columns.Add("CodProd", "Código do Produto");
            listaProdutos.Columns.Add("NomeProd", "Nome do Produto");
            listaProdutos.Columns.Add("ValorUnid", "Valor Unitário");
            listaProdutos.Columns.Add("Quantidade", "Quantidade");
            listaProdutos.Columns.Add("ValorTotal", "Valor Total");
            listaProdutos.Columns["ValorUnid"].DefaultCellStyle.Format = "F2";

            listaProdutos.Columns["NumeroLinha"].Width = 30;
            listaProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        // Puxar Informações pelo código do produto
        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodProd.Text))
            {
                if (int.TryParse(txtCodProd.Text, out int codProduto))
                {
                    BuscarProdutoPorCodigo(codProduto);
                }
                else
                {
                    LimparCamposProduto();
                }
            }
            else
            {
                LimparCamposProduto();
            }
        }

        private void BuscarProdutoPorCodigo(int codProduto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT nome_prod, valor_venda FROM Produto WHERE cod_prod = @CodProd";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodProd", codProduto);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNomeProd.Text = reader["nome_prod"].ToString();
                            txtValorUnid.Text = Convert.ToDecimal(reader["valor_venda"]).ToString("F2");
                        }
                        else
                        {
                            LimparCamposProduto();
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LimparCamposProduto()
        {
            txtNomeProd.Clear();
            txtValorUnid.Clear();
        }


        // Calculo para puxar valor total do item
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            CalcularValorTotalItem();
        }

        private void txtValorUnid_TextChanged(object sender, EventArgs e)
        {
            CalcularValorTotalItem();
        }

        private void CalcularValorTotalItem()
        {
            if (double.TryParse(txtValorUnid.Text, out double valorUnitario) &&
                double.TryParse(txtQuantidade.Text, out double quantidade))
            {
                double valorTotal = valorUnitario * quantidade;
                txtValorTotalProd.Text = valorTotal.ToString("F2");
            }
            else
            {
                txtValorTotalProd.Clear();
            }
        }


        // Botão Adicionar Item ao Carrinho
        private void btnAdditem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodProd.Text) &&
                !string.IsNullOrWhiteSpace(txtNomeProd.Text) &&
                !string.IsNullOrWhiteSpace(txtValorUnid.Text) &&
                !string.IsNullOrWhiteSpace(txtQuantidade.Text) &&
                !string.IsNullOrWhiteSpace(txtValorTotalProd.Text))
            {
                int codProduto = int.Parse(txtCodProd.Text);
                string nomeProduto = txtNomeProd.Text;
                decimal valorUnid = decimal.Parse(txtValorUnid.Text);
                int quantidade = int.Parse(txtQuantidade.Text);
                decimal valorTotal = decimal.Parse(txtValorTotalProd.Text);

                int numeroLinha = listaProdutos.Rows.Count + 1;
                listaProdutos.Rows.Add(numeroLinha, codProduto, nomeProduto, valorUnid, quantidade, valorTotal);

                LimparCamposProduto();
                txtCodProd.Clear();
                txtQuantidade.Clear();

                CalcularTotalAPagar();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Botão Limpar Campos de ADD Item ao Carrinho
        private void btnExcItem_Click(object sender, EventArgs e)
        {

            txtCodProd.Clear();
            txtQuantidade.Clear();
        }


        //
        // PARTE DE EXCLUSÃO DE ITEM DO PEDIDO
        //

        // Botão Excluir Item da Lista
        private void btnExcItemList_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Informe o número da linha a ser excluída:", "Excluir Item", "");

            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int numeroLinha))
            {
                if (numeroLinha > 0 && numeroLinha <= listaProdutos.Rows.Count)
                {
                    string codigoAcesso = Microsoft.VisualBasic.Interaction.InputBox("Informe o código de acesso:", "Código de Acesso", "");

                    if (ValidarCodigoAcesso(codigoAcesso))
                    {
                        // Remove o item selecionado
                        listaProdutos.Rows.RemoveAt(numeroLinha - 1); // Ajusta para o índice zero

                        // Atualiza os números das linhas restantes
                        AtualizarNumerosLinhas();

                        MessageBox.Show("Item excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CalcularTotalAPagar(); // Recalcula o total após a exclusão
                    }
                    else
                    {
                        MessageBox.Show("Usuário não permitido!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Número da linha inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, informe um número de linha válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarNumerosLinhas()
        {
            for (int i = 0; i < listaProdutos.Rows.Count; i++)
            {
                // Atualiza a coluna "NumeroLinha" com o número correto
                listaProdutos.Rows[i].Cells["NumeroLinha"].Value = (i + 1).ToString();
            }
        }


        // Valor total a Pagar no Pedido
        private void CalcularTotalAPagar()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in listaProdutos.Rows)
            {
                if (row.Cells["ValorTotal"].Value != null)
                {
                    if (decimal.TryParse(row.Cells["ValorTotal"].Value.ToString(), out decimal valorTotal))
                    {
                        total += valorTotal;
                    }
                }
            }

            tValorTotal.Text = total.ToString("C2", new System.Globalization.CultureInfo("pt-BR")); // Formata com o símbolo de R$
        }


        // Validação do códgio ADM para exclusão dos itens no carrinho
        private bool ValidarCodigoAcesso(string codigoAcesso)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Funcionario WHERE cod_adm = @CodigoAcesso";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodigoAcesso", codigoAcesso);
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


        //
        // PARTE DE EMISSÃO DE PEDIDO
        //

        // Borão Emitir Pedido
        private void btnEmitirPed_Click(object sender, EventArgs e)
        {
            // Verifica se a lista de produtos está vazia
            if (listaProdutos.Rows.Count == 0)
            {
                MessageBox.Show("A lista de produtos está vazia. Adicione produtos para poder continuar.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string matriculaFuncionario = txtMatricula.Text;

            TelaConfirmarPedido telaConfirmarPedido = new TelaConfirmarPedido(listaProdutos, matriculaFuncionario);
            telaConfirmarPedido.ShowDialog();

            if (telaConfirmarPedido.PedidoEmitidoComSucesso)
            {
                listaProdutos.Rows.Clear();
                CalcularTotalAPagar();
            }

        }


        // Botão Sair da Tela de Vendas
        private void btnSairTelaV_Click(object sender, EventArgs e)
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

        private void btnGerencial_Click(object sender, EventArgs e)
        {
            // Valida se o usuário possui permissão para acessar a TelaGerencialVendas
            if (UsuarioPossuiPermissao())
            {
                // Abre a TelaGerencialVendas
                TelaGerencialVendas telaGerencial = new TelaGerencialVendas();
                telaGerencial.ShowDialog();
            }
            else
            {
                // Exibe mensagem de acesso negado
                MessageBox.Show("Você não tem permissão para acessar esta funcionalidade.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool UsuarioPossuiPermissao()
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
    }
}
