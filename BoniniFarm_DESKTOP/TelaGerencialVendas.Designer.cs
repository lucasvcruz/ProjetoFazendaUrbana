namespace BoniniFarm2
{
    partial class TelaGerencialVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listaPedidos = new DataGridView();
            listaLucroPedidos = new DataGridView();
            btnSairTelaGerencial = new Button();
            tValorTotalCusto = new Label();
            tValorTotalFatu = new Label();
            tValorTotalLucro = new Label();
            tInfoFinanceiras = new Label();
            tHistoricoPedidos = new Label();
            tValorTotalPed = new Label();
            txtBucarPedido = new TextBox();
            btnBuscarPedido = new Button();
            btnAtualizarLista = new Button();
            btnExtrairLucroPedidos = new Button();
            txtValorTotalCusto = new Label();
            txtValorTotalLucro = new Label();
            txtValorTotalFatu = new Label();
            txtValorTotalPed = new Label();
            ((System.ComponentModel.ISupportInitialize)listaPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaLucroPedidos).BeginInit();
            SuspendLayout();
            // 
            // listaPedidos
            // 
            listaPedidos.AllowUserToAddRows = false;
            listaPedidos.AllowUserToDeleteRows = false;
            listaPedidos.AllowUserToOrderColumns = true;
            listaPedidos.AllowUserToResizeColumns = false;
            listaPedidos.AllowUserToResizeRows = false;
            listaPedidos.BackgroundColor = SystemColors.ButtonFace;
            listaPedidos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            listaPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaPedidos.GridColor = SystemColors.ControlLight;
            listaPedidos.Location = new Point(47, 59);
            listaPedidos.Name = "listaPedidos";
            listaPedidos.RowHeadersWidth = 51;
            listaPedidos.Size = new Size(929, 249);
            listaPedidos.TabIndex = 2;
            // 
            // listaLucroPedidos
            // 
            listaLucroPedidos.AllowUserToAddRows = false;
            listaLucroPedidos.AllowUserToDeleteRows = false;
            listaLucroPedidos.AllowUserToOrderColumns = true;
            listaLucroPedidos.AllowUserToResizeColumns = false;
            listaLucroPedidos.AllowUserToResizeRows = false;
            listaLucroPedidos.BackgroundColor = SystemColors.ButtonFace;
            listaLucroPedidos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            listaLucroPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaLucroPedidos.GridColor = SystemColors.ControlLight;
            listaLucroPedidos.Location = new Point(47, 380);
            listaLucroPedidos.Name = "listaLucroPedidos";
            listaLucroPedidos.RowHeadersWidth = 51;
            listaLucroPedidos.Size = new Size(929, 277);
            listaLucroPedidos.TabIndex = 9;
            // 
            // btnSairTelaGerencial
            // 
            btnSairTelaGerencial.Location = new Point(12, 669);
            btnSairTelaGerencial.Name = "btnSairTelaGerencial";
            btnSairTelaGerencial.Size = new Size(94, 40);
            btnSairTelaGerencial.TabIndex = 0;
            btnSairTelaGerencial.Text = "Sair";
            btnSairTelaGerencial.UseVisualStyleBackColor = true;
            btnSairTelaGerencial.Click += btnSairTelaGerencial_Click;
            // 
            // tValorTotalCusto
            // 
            tValorTotalCusto.BackColor = Color.FromArgb(56, 80, 27);
            tValorTotalCusto.BorderStyle = BorderStyle.FixedSingle;
            tValorTotalCusto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tValorTotalCusto.ForeColor = SystemColors.Control;
            tValorTotalCusto.Location = new Point(1001, 404);
            tValorTotalCusto.Name = "tValorTotalCusto";
            tValorTotalCusto.RightToLeft = RightToLeft.No;
            tValorTotalCusto.Size = new Size(313, 27);
            tValorTotalCusto.TabIndex = 10;
            tValorTotalCusto.Text = "TOTAL CUSTO";
            tValorTotalCusto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tValorTotalFatu
            // 
            tValorTotalFatu.BackColor = Color.FromArgb(56, 80, 27);
            tValorTotalFatu.BorderStyle = BorderStyle.FixedSingle;
            tValorTotalFatu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tValorTotalFatu.ForeColor = SystemColors.Control;
            tValorTotalFatu.Location = new Point(1001, 496);
            tValorTotalFatu.Name = "tValorTotalFatu";
            tValorTotalFatu.RightToLeft = RightToLeft.No;
            tValorTotalFatu.Size = new Size(313, 27);
            tValorTotalFatu.TabIndex = 12;
            tValorTotalFatu.Text = "TOTAL FATURAMENTO";
            tValorTotalFatu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tValorTotalLucro
            // 
            tValorTotalLucro.BackColor = Color.FromArgb(56, 80, 27);
            tValorTotalLucro.BorderStyle = BorderStyle.FixedSingle;
            tValorTotalLucro.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tValorTotalLucro.ForeColor = SystemColors.Control;
            tValorTotalLucro.Location = new Point(1001, 582);
            tValorTotalLucro.Name = "tValorTotalLucro";
            tValorTotalLucro.RightToLeft = RightToLeft.No;
            tValorTotalLucro.Size = new Size(313, 27);
            tValorTotalLucro.TabIndex = 14;
            tValorTotalLucro.Text = "TOTAL LUCRO";
            tValorTotalLucro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tInfoFinanceiras
            // 
            tInfoFinanceiras.BackColor = Color.FromArgb(56, 80, 27);
            tInfoFinanceiras.BorderStyle = BorderStyle.FixedSingle;
            tInfoFinanceiras.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tInfoFinanceiras.ForeColor = SystemColors.ButtonHighlight;
            tInfoFinanceiras.Location = new Point(47, 336);
            tInfoFinanceiras.Name = "tInfoFinanceiras";
            tInfoFinanceiras.RightToLeft = RightToLeft.No;
            tInfoFinanceiras.Size = new Size(1267, 41);
            tInfoFinanceiras.TabIndex = 8;
            tInfoFinanceiras.Text = "LISTA - INFORMAÇÕES FINANCEIRAS";
            tInfoFinanceiras.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tHistoricoPedidos
            // 
            tHistoricoPedidos.BackColor = Color.FromArgb(78, 41, 21);
            tHistoricoPedidos.BorderStyle = BorderStyle.FixedSingle;
            tHistoricoPedidos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tHistoricoPedidos.ForeColor = SystemColors.ButtonHighlight;
            tHistoricoPedidos.Location = new Point(47, 15);
            tHistoricoPedidos.Name = "tHistoricoPedidos";
            tHistoricoPedidos.RightToLeft = RightToLeft.No;
            tHistoricoPedidos.Size = new Size(1267, 41);
            tHistoricoPedidos.TabIndex = 1;
            tHistoricoPedidos.Text = "LISTA - HISTÓRIO DE PEDIDOS";
            tHistoricoPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tValorTotalPed
            // 
            tValorTotalPed.BackColor = Color.FromArgb(78, 41, 21);
            tValorTotalPed.BorderStyle = BorderStyle.FixedSingle;
            tValorTotalPed.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tValorTotalPed.ForeColor = SystemColors.Control;
            tValorTotalPed.Location = new Point(1001, 128);
            tValorTotalPed.Name = "tValorTotalPed";
            tValorTotalPed.RightToLeft = RightToLeft.No;
            tValorTotalPed.Size = new Size(313, 30);
            tValorTotalPed.TabIndex = 3;
            tValorTotalPed.Text = "VALOR TOTAL DO PEDIDO";
            tValorTotalPed.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtBucarPedido
            // 
            txtBucarPedido.BorderStyle = BorderStyle.FixedSingle;
            txtBucarPedido.CharacterCasing = CharacterCasing.Lower;
            txtBucarPedido.ForeColor = Color.Gray;
            txtBucarPedido.Location = new Point(1001, 162);
            txtBucarPedido.Name = "txtBucarPedido";
            txtBucarPedido.RightToLeft = RightToLeft.No;
            txtBucarPedido.Size = new Size(204, 27);
            txtBucarPedido.TabIndex = 4;
            txtBucarPedido.Text = "inserir código do pedido...";
            txtBucarPedido.Enter += txtBucarPedido_Enter;
            txtBucarPedido.Leave += txtBucarPedido_Leave;
            // 
            // btnBuscarPedido
            // 
            btnBuscarPedido.BackColor = Color.FromArgb(113, 56, 25);
            btnBuscarPedido.FlatAppearance.BorderColor = Color.FromArgb(75, 107, 36);
            btnBuscarPedido.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarPedido.FlatStyle = FlatStyle.Popup;
            btnBuscarPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarPedido.ForeColor = SystemColors.Control;
            btnBuscarPedido.Location = new Point(1211, 161);
            btnBuscarPedido.Name = "btnBuscarPedido";
            btnBuscarPedido.Size = new Size(103, 27);
            btnBuscarPedido.TabIndex = 5;
            btnBuscarPedido.Text = "Buscar";
            btnBuscarPedido.UseVisualStyleBackColor = false;
            btnBuscarPedido.Click += btnBuscarPedido_Click;
            // 
            // btnAtualizarLista
            // 
            btnAtualizarLista.BackColor = Color.FromArgb(96, 63, 45);
            btnAtualizarLista.FlatAppearance.BorderColor = Color.FromArgb(75, 107, 36);
            btnAtualizarLista.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 107, 36);
            btnAtualizarLista.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 107, 36);
            btnAtualizarLista.FlatStyle = FlatStyle.Popup;
            btnAtualizarLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtualizarLista.ForeColor = SystemColors.Control;
            btnAtualizarLista.Location = new Point(1211, 193);
            btnAtualizarLista.Name = "btnAtualizarLista";
            btnAtualizarLista.Size = new Size(103, 27);
            btnAtualizarLista.TabIndex = 7;
            btnAtualizarLista.Text = "Limpar";
            btnAtualizarLista.UseVisualStyleBackColor = false;
            btnAtualizarLista.Click += btnAtualizarLista_Click;
            // 
            // btnExtrairLucroPedidos
            // 
            btnExtrairLucroPedidos.BackColor = Color.FromArgb(0, 64, 64);
            btnExtrairLucroPedidos.FlatAppearance.BorderColor = Color.FromArgb(75, 107, 36);
            btnExtrairLucroPedidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 107, 36);
            btnExtrairLucroPedidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 107, 36);
            btnExtrairLucroPedidos.FlatStyle = FlatStyle.Popup;
            btnExtrairLucroPedidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExtrairLucroPedidos.ForeColor = SystemColors.Control;
            btnExtrairLucroPedidos.Location = new Point(804, 663);
            btnExtrairLucroPedidos.Name = "btnExtrairLucroPedidos";
            btnExtrairLucroPedidos.Size = new Size(172, 27);
            btnExtrairLucroPedidos.TabIndex = 16;
            btnExtrairLucroPedidos.Text = "Extrair Relatório";
            btnExtrairLucroPedidos.UseVisualStyleBackColor = false;
            btnExtrairLucroPedidos.Click += btnExtrairLucroPedidos_Click;
            // 
            // txtValorTotalCusto
            // 
            txtValorTotalCusto.BackColor = Color.FromArgb(224, 224, 224);
            txtValorTotalCusto.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotalCusto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtValorTotalCusto.ForeColor = SystemColors.ControlText;
            txtValorTotalCusto.Location = new Point(1001, 434);
            txtValorTotalCusto.Name = "txtValorTotalCusto";
            txtValorTotalCusto.Size = new Size(313, 27);
            txtValorTotalCusto.TabIndex = 11;
            txtValorTotalCusto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtValorTotalLucro
            // 
            txtValorTotalLucro.BackColor = Color.FromArgb(224, 224, 224);
            txtValorTotalLucro.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotalLucro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtValorTotalLucro.ForeColor = SystemColors.ControlText;
            txtValorTotalLucro.Location = new Point(1001, 612);
            txtValorTotalLucro.Name = "txtValorTotalLucro";
            txtValorTotalLucro.Size = new Size(313, 27);
            txtValorTotalLucro.TabIndex = 15;
            txtValorTotalLucro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtValorTotalFatu
            // 
            txtValorTotalFatu.BackColor = Color.FromArgb(224, 224, 224);
            txtValorTotalFatu.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotalFatu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtValorTotalFatu.ForeColor = SystemColors.ControlText;
            txtValorTotalFatu.Location = new Point(1001, 526);
            txtValorTotalFatu.Name = "txtValorTotalFatu";
            txtValorTotalFatu.Size = new Size(313, 27);
            txtValorTotalFatu.TabIndex = 13;
            txtValorTotalFatu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtValorTotalPed
            // 
            txtValorTotalPed.BackColor = Color.FromArgb(224, 224, 224);
            txtValorTotalPed.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotalPed.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtValorTotalPed.ForeColor = SystemColors.ControlText;
            txtValorTotalPed.Location = new Point(1001, 193);
            txtValorTotalPed.Name = "txtValorTotalPed";
            txtValorTotalPed.Size = new Size(204, 27);
            txtValorTotalPed.TabIndex = 6;
            txtValorTotalPed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TelaGerencialVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(txtValorTotalPed);
            Controls.Add(txtValorTotalFatu);
            Controls.Add(txtValorTotalLucro);
            Controls.Add(txtValorTotalCusto);
            Controls.Add(btnExtrairLucroPedidos);
            Controls.Add(btnAtualizarLista);
            Controls.Add(btnBuscarPedido);
            Controls.Add(txtBucarPedido);
            Controls.Add(tValorTotalPed);
            Controls.Add(tHistoricoPedidos);
            Controls.Add(tInfoFinanceiras);
            Controls.Add(tValorTotalLucro);
            Controls.Add(tValorTotalFatu);
            Controls.Add(tValorTotalCusto);
            Controls.Add(btnSairTelaGerencial);
            Controls.Add(listaLucroPedidos);
            Controls.Add(listaPedidos);
            Name = "TelaGerencialVendas";
            Text = "TelaGerencialVendas";
            Load += TelaGerencialVendas_Load;
            ((System.ComponentModel.ISupportInitialize)listaPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaLucroPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView listaPedidos;
        private DataGridView listaLucroPedidos;
        private Button btnSairTelaGerencial;
        private Label tValorTotalCusto;
        private Label tValorTotalFatu;
        private Label tValorTotalLucro;
        private Label tInfoFinanceiras;
        private Label tHistoricoPedidos;
        private Label tValorTotalPed;
        private TextBox txtBucarPedido;
        private Button btnBuscarPedido;
        private Button btnAtualizarLista;
        private Button btnExtrairLucroPedidos;
        private Label txtValorTotalCusto;
        private Label txtValorTotalLucro;
        private Label txtValorTotalFatu;
        private Label txtValorTotalPed;
    }
}