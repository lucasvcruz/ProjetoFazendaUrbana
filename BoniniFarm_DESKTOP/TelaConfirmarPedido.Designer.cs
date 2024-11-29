namespace BoniniFarm2
{
    partial class TelaConfirmarPedido
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
            txtCPFCliente = new MaskedTextBox();
            tMatriculaFuncEmissao = new Label();
            tNomeCliente = new Label();
            tCPFCliente = new Label();
            txtNomeCliente = new TextBox();
            tCadProd = new Label();
            txtMatriculaFuncEmissao = new Label();
            txtValorTotalEmissao = new Label();
            tValorTotalEmissao = new Label();
            btnCancelar = new Button();
            btnEmitirNf = new Button();
            tCNPJCliente = new Label();
            txtCNPJCliente = new MaskedTextBox();
            grupoEmissao = new GroupBox();
            tlistaItens = new Label();
            txtDataEmissao = new Label();
            tDataEmissao = new Label();
            listaProdutosEmissao = new DataGridView();
            tFormaPag = new Label();
            txtFormaPag = new ComboBox();
            grupoEmissao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaProdutosEmissao).BeginInit();
            SuspendLayout();
            // 
            // txtCPFCliente
            // 
            txtCPFCliente.Location = new Point(144, 184);
            txtCPFCliente.Mask = "000,000,000-00";
            txtCPFCliente.Name = "txtCPFCliente";
            txtCPFCliente.Size = new Size(205, 27);
            txtCPFCliente.TabIndex = 6;
            txtCPFCliente.ValidatingType = typeof(DateTime);
            // 
            // tMatriculaFuncEmissao
            // 
            tMatriculaFuncEmissao.BackColor = SystemColors.ScrollBar;
            tMatriculaFuncEmissao.BorderStyle = BorderStyle.FixedSingle;
            tMatriculaFuncEmissao.Enabled = false;
            tMatriculaFuncEmissao.Location = new Point(20, 85);
            tMatriculaFuncEmissao.Name = "tMatriculaFuncEmissao";
            tMatriculaFuncEmissao.Size = new Size(106, 27);
            tMatriculaFuncEmissao.TabIndex = 1;
            tMatriculaFuncEmissao.Text = "Matricula Funcionario:";
            // 
            // tNomeCliente
            // 
            tNomeCliente.BackColor = SystemColors.ScrollBar;
            tNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            tNomeCliente.Enabled = false;
            tNomeCliente.Location = new Point(32, 143);
            tNomeCliente.Name = "tNomeCliente";
            tNomeCliente.Size = new Size(106, 27);
            tNomeCliente.TabIndex = 1;
            tNomeCliente.Text = "Inserir Nome:";
            // 
            // tCPFCliente
            // 
            tCPFCliente.BackColor = SystemColors.ScrollBar;
            tCPFCliente.BorderStyle = BorderStyle.FixedSingle;
            tCPFCliente.Enabled = false;
            tCPFCliente.Location = new Point(32, 184);
            tCPFCliente.Name = "tCPFCliente";
            tCPFCliente.Size = new Size(106, 27);
            tCPFCliente.TabIndex = 5;
            tCPFCliente.Text = "Inserir CPF:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCliente.Location = new Point(144, 143);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(205, 27);
            txtNomeCliente.TabIndex = 2;
            // 
            // tCadProd
            // 
            tCadProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tCadProd.AutoSize = true;
            tCadProd.Font = new Font("Segoe UI", 13F);
            tCadProd.Location = new Point(243, 32);
            tCadProd.Name = "tCadProd";
            tCadProd.Size = new Size(219, 30);
            tCadProd.TabIndex = 0;
            tCadProd.Text = "EMISSÃO DE PEDIDO";
            // 
            // txtMatriculaFuncEmissao
            // 
            txtMatriculaFuncEmissao.BackColor = SystemColors.ScrollBar;
            txtMatriculaFuncEmissao.BorderStyle = BorderStyle.FixedSingle;
            txtMatriculaFuncEmissao.ForeColor = SystemColors.ControlText;
            txtMatriculaFuncEmissao.Location = new Point(132, 85);
            txtMatriculaFuncEmissao.Name = "txtMatriculaFuncEmissao";
            txtMatriculaFuncEmissao.Size = new Size(205, 27);
            txtMatriculaFuncEmissao.TabIndex = 2;
            txtMatriculaFuncEmissao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtValorTotalEmissao
            // 
            txtValorTotalEmissao.BackColor = SystemColors.ScrollBar;
            txtValorTotalEmissao.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotalEmissao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtValorTotalEmissao.ForeColor = SystemColors.ControlText;
            txtValorTotalEmissao.Location = new Point(32, 606);
            txtValorTotalEmissao.Name = "txtValorTotalEmissao";
            txtValorTotalEmissao.Size = new Size(643, 27);
            txtValorTotalEmissao.TabIndex = 10;
            txtValorTotalEmissao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tValorTotalEmissao
            // 
            tValorTotalEmissao.BackColor = Color.FromArgb(78, 41, 21);
            tValorTotalEmissao.BorderStyle = BorderStyle.FixedSingle;
            tValorTotalEmissao.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tValorTotalEmissao.ForeColor = SystemColors.ButtonHighlight;
            tValorTotalEmissao.Location = new Point(32, 574);
            tValorTotalEmissao.Name = "tValorTotalEmissao";
            tValorTotalEmissao.RightToLeft = RightToLeft.No;
            tValorTotalEmissao.Size = new Size(643, 27);
            tValorTotalEmissao.TabIndex = 9;
            tValorTotalEmissao.Text = "TOTAL A PAGAR";
            tValorTotalEmissao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(112, 41, 41);
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(398, 650);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(193, 29);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEmitirNf
            // 
            btnEmitirNf.BackColor = Color.FromArgb(55, 124, 38);
            btnEmitirNf.FlatStyle = FlatStyle.Popup;
            btnEmitirNf.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmitirNf.ForeColor = SystemColors.Control;
            btnEmitirNf.Location = new Point(121, 650);
            btnEmitirNf.Name = "btnEmitirNf";
            btnEmitirNf.Size = new Size(193, 29);
            btnEmitirNf.TabIndex = 11;
            btnEmitirNf.Text = "Gerar Nota Fiscal";
            btnEmitirNf.UseVisualStyleBackColor = false;
            btnEmitirNf.Click += btnEmitirNf_Click;
            // 
            // tCNPJCliente
            // 
            tCNPJCliente.BackColor = SystemColors.ScrollBar;
            tCNPJCliente.BorderStyle = BorderStyle.FixedSingle;
            tCNPJCliente.Enabled = false;
            tCNPJCliente.Location = new Point(358, 184);
            tCNPJCliente.Name = "tCNPJCliente";
            tCNPJCliente.Size = new Size(116, 27);
            tCNPJCliente.TabIndex = 7;
            tCNPJCliente.Text = "Inserir CNPJ:";
            // 
            // txtCNPJCliente
            // 
            txtCNPJCliente.Location = new Point(480, 184);
            txtCNPJCliente.Mask = "00,000,000/0000-00";
            txtCNPJCliente.Name = "txtCNPJCliente";
            txtCNPJCliente.Size = new Size(195, 27);
            txtCNPJCliente.TabIndex = 8;
            txtCNPJCliente.ValidatingType = typeof(DateTime);
            // 
            // grupoEmissao
            // 
            grupoEmissao.Controls.Add(tlistaItens);
            grupoEmissao.Controls.Add(txtDataEmissao);
            grupoEmissao.Controls.Add(tDataEmissao);
            grupoEmissao.Controls.Add(tMatriculaFuncEmissao);
            grupoEmissao.Controls.Add(txtMatriculaFuncEmissao);
            grupoEmissao.Controls.Add(listaProdutosEmissao);
            grupoEmissao.Controls.Add(tCadProd);
            grupoEmissao.Location = new Point(12, 14);
            grupoEmissao.Name = "grupoEmissao";
            grupoEmissao.Size = new Size(682, 689);
            grupoEmissao.TabIndex = 0;
            grupoEmissao.TabStop = false;
            // 
            // tlistaItens
            // 
            tlistaItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlistaItens.AutoSize = true;
            tlistaItens.Enabled = false;
            tlistaItens.Font = new Font("Segoe UI", 10F);
            tlistaItens.Location = new Point(259, 221);
            tlistaItens.Name = "tlistaItens";
            tlistaItens.Size = new Size(182, 23);
            tlistaItens.TabIndex = 25;
            tlistaItens.Text = "Lista Itens no Carrinho";
            // 
            // txtDataEmissao
            // 
            txtDataEmissao.BackColor = SystemColors.ScrollBar;
            txtDataEmissao.BorderStyle = BorderStyle.FixedSingle;
            txtDataEmissao.ForeColor = SystemColors.ControlText;
            txtDataEmissao.Location = new Point(468, 87);
            txtDataEmissao.Name = "txtDataEmissao";
            txtDataEmissao.Size = new Size(193, 27);
            txtDataEmissao.TabIndex = 4;
            txtDataEmissao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tDataEmissao
            // 
            tDataEmissao.BackColor = SystemColors.ScrollBar;
            tDataEmissao.BorderStyle = BorderStyle.FixedSingle;
            tDataEmissao.Location = new Point(346, 87);
            tDataEmissao.Name = "tDataEmissao";
            tDataEmissao.Size = new Size(116, 27);
            tDataEmissao.TabIndex = 3;
            tDataEmissao.Text = "Data:";
            // 
            // listaProdutosEmissao
            // 
            listaProdutosEmissao.AllowUserToAddRows = false;
            listaProdutosEmissao.AllowUserToDeleteRows = false;
            listaProdutosEmissao.AllowUserToResizeColumns = false;
            listaProdutosEmissao.AllowUserToResizeRows = false;
            listaProdutosEmissao.BackgroundColor = SystemColors.ButtonFace;
            listaProdutosEmissao.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            listaProdutosEmissao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaProdutosEmissao.Enabled = false;
            listaProdutosEmissao.GridColor = SystemColors.ControlLight;
            listaProdutosEmissao.Location = new Point(20, 247);
            listaProdutosEmissao.MultiSelect = false;
            listaProdutosEmissao.Name = "listaProdutosEmissao";
            listaProdutosEmissao.RowHeadersWidth = 51;
            listaProdutosEmissao.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            listaProdutosEmissao.Size = new Size(643, 301);
            listaProdutosEmissao.TabIndex = 5;
            // 
            // tFormaPag
            // 
            tFormaPag.BackColor = SystemColors.ScrollBar;
            tFormaPag.BorderStyle = BorderStyle.FixedSingle;
            tFormaPag.Enabled = false;
            tFormaPag.Location = new Point(358, 144);
            tFormaPag.Name = "tFormaPag";
            tFormaPag.Size = new Size(116, 27);
            tFormaPag.TabIndex = 3;
            tFormaPag.Text = "Forma de Pgnt:";
            // 
            // txtFormaPag
            // 
            txtFormaPag.FormattingEnabled = true;
            txtFormaPag.Items.AddRange(new object[] { "Dinheiro", "Credito", "Debito", "Pix" });
            txtFormaPag.Location = new Point(480, 143);
            txtFormaPag.Name = "txtFormaPag";
            txtFormaPag.Size = new Size(193, 28);
            txtFormaPag.TabIndex = 4;
            // 
            // TelaConfirmarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 715);
            Controls.Add(txtFormaPag);
            Controls.Add(tFormaPag);
            Controls.Add(tCNPJCliente);
            Controls.Add(txtCNPJCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnEmitirNf);
            Controls.Add(txtValorTotalEmissao);
            Controls.Add(tValorTotalEmissao);
            Controls.Add(txtNomeCliente);
            Controls.Add(tCPFCliente);
            Controls.Add(tNomeCliente);
            Controls.Add(txtCPFCliente);
            Controls.Add(grupoEmissao);
            Name = "TelaConfirmarPedido";
            Text = "TelaConfirmarPedido";
            Load += TelaConfirmarPedido_Load;
            grupoEmissao.ResumeLayout(false);
            grupoEmissao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaProdutosEmissao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox txtCPFCliente;
        private Label tMatriculaFuncEmissao;
        private Label tNomeCliente;
        private Label tCPFCliente;
        private TextBox txtNomeCliente;
        private Label tCadProd;
        private Label txtMatriculaFuncEmissao;
        private Label txtValorTotalEmissao;
        private Label tValorTotalEmissao;
        private Button btnCancelar;
        private Button btnEmitirNf;
        private Label tCNPJCliente;
        private MaskedTextBox txtCNPJCliente;
        private GroupBox grupoEmissao;
        private Label tFormaPag;
        private ComboBox txtFormaPag;
        private DataGridView listaProdutosEmissao;
        private Label txtDataEmissao;
        private Label tDataEmissao;
        private Label tlistaItens;
    }
}