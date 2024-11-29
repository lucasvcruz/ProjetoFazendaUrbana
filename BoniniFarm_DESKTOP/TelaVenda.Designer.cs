namespace BoniniFarm2
{
    partial class TelaVenda
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
            tCodProd = new Label();
            tValorUnid = new Label();
            tNomeProd = new Label();
            txtCodProd = new TextBox();
            txtValorUnid = new TextBox();
            txtNomeProd = new TextBox();
            tQuantidade = new Label();
            txtQuantidade = new TextBox();
            tValorTotalProd = new Label();
            txtValorTotalProd = new TextBox();
            retcor1 = new Button();
            logo1 = new PictureBox();
            listaProdutos = new DataGridView();
            tPedLoja = new Label();
            tTotalAPagar = new Label();
            btnAdditem = new Button();
            btnExcItem = new Button();
            btnExcItemList = new Button();
            btnEmitirPed = new Button();
            tInserir = new Label();
            tDataHoje = new Label();
            tCaixaAberto = new Label();
            tTituloLista = new Label();
            txtData = new Label();
            tValorTotal = new Label();
            btnSairTelaV = new Button();
            txtMatricula = new Label();
            grupoAddItem = new GroupBox();
            btnGerencial = new Button();
            ((System.ComponentModel.ISupportInitialize)logo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaProdutos).BeginInit();
            grupoAddItem.SuspendLayout();
            SuspendLayout();
            // 
            // tCodProd
            // 
            tCodProd.BackColor = SystemColors.ScrollBar;
            tCodProd.BorderStyle = BorderStyle.FixedSingle;
            tCodProd.Location = new Point(10, 200);
            tCodProd.Name = "tCodProd";
            tCodProd.Size = new Size(193, 27);
            tCodProd.TabIndex = 5;
            tCodProd.Text = "Código do Produto:";
            // 
            // tValorUnid
            // 
            tValorUnid.BackColor = SystemColors.ScrollBar;
            tValorUnid.BorderStyle = BorderStyle.FixedSingle;
            tValorUnid.Location = new Point(10, 291);
            tValorUnid.Name = "tValorUnid";
            tValorUnid.RightToLeft = RightToLeft.No;
            tValorUnid.Size = new Size(193, 27);
            tValorUnid.TabIndex = 9;
            tValorUnid.Text = "Valor da Unidade:";
            // 
            // tNomeProd
            // 
            tNomeProd.BackColor = SystemColors.ScrollBar;
            tNomeProd.BorderStyle = BorderStyle.FixedSingle;
            tNomeProd.Location = new Point(10, 246);
            tNomeProd.Name = "tNomeProd";
            tNomeProd.RightToLeft = RightToLeft.No;
            tNomeProd.Size = new Size(193, 27);
            tNomeProd.TabIndex = 7;
            tNomeProd.Text = "Nome do Produto:";
            // 
            // txtCodProd
            // 
            txtCodProd.BorderStyle = BorderStyle.FixedSingle;
            txtCodProd.Location = new Point(220, 200);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(225, 27);
            txtCodProd.TabIndex = 6;
            txtCodProd.TextChanged += txtCodProd_TextChanged;
            // 
            // txtValorUnid
            // 
            txtValorUnid.BackColor = SystemColors.ScrollBar;
            txtValorUnid.BorderStyle = BorderStyle.FixedSingle;
            txtValorUnid.Enabled = false;
            txtValorUnid.Location = new Point(220, 291);
            txtValorUnid.Name = "txtValorUnid";
            txtValorUnid.Size = new Size(225, 27);
            txtValorUnid.TabIndex = 10;
            txtValorUnid.TextChanged += txtValorUnid_TextChanged;
            // 
            // txtNomeProd
            // 
            txtNomeProd.BackColor = SystemColors.ScrollBar;
            txtNomeProd.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProd.Enabled = false;
            txtNomeProd.Location = new Point(220, 246);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(225, 27);
            txtNomeProd.TabIndex = 8;
            // 
            // tQuantidade
            // 
            tQuantidade.BackColor = SystemColors.ScrollBar;
            tQuantidade.BorderStyle = BorderStyle.FixedSingle;
            tQuantidade.Location = new Point(10, 333);
            tQuantidade.Name = "tQuantidade";
            tQuantidade.RightToLeft = RightToLeft.No;
            tQuantidade.Size = new Size(193, 27);
            tQuantidade.TabIndex = 11;
            tQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Location = new Point(220, 333);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(225, 27);
            txtQuantidade.TabIndex = 12;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // tValorTotalProd
            // 
            tValorTotalProd.BackColor = SystemColors.ScrollBar;
            tValorTotalProd.BorderStyle = BorderStyle.FixedSingle;
            tValorTotalProd.Location = new Point(10, 375);
            tValorTotalProd.Name = "tValorTotalProd";
            tValorTotalProd.RightToLeft = RightToLeft.No;
            tValorTotalProd.Size = new Size(193, 27);
            tValorTotalProd.TabIndex = 13;
            tValorTotalProd.Text = "Valor Total do Produto:";
            // 
            // txtValorTotalProd
            // 
            txtValorTotalProd.BackColor = SystemColors.ScrollBar;
            txtValorTotalProd.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotalProd.Enabled = false;
            txtValorTotalProd.Location = new Point(220, 375);
            txtValorTotalProd.Name = "txtValorTotalProd";
            txtValorTotalProd.Size = new Size(225, 27);
            txtValorTotalProd.TabIndex = 14;
            // 
            // retcor1
            // 
            retcor1.BackColor = Color.FromArgb(78, 41, 21);
            retcor1.Enabled = false;
            retcor1.FlatStyle = FlatStyle.Flat;
            retcor1.ForeColor = Color.DarkGoldenrod;
            retcor1.Location = new Point(119, 34);
            retcor1.Name = "retcor1";
            retcor1.Size = new Size(1119, 110);
            retcor1.TabIndex = 23;
            retcor1.UseMnemonic = false;
            retcor1.UseVisualStyleBackColor = false;
            // 
            // logo1
            // 
            logo1.Image = Properties.Resources.image;
            logo1.Location = new Point(128, 165);
            logo1.Name = "logo1";
            logo1.Size = new Size(435, 78);
            logo1.SizeMode = PictureBoxSizeMode.CenterImage;
            logo1.TabIndex = 12;
            logo1.TabStop = false;
            logo1.WaitOnLoad = true;
            // 
            // listaProdutos
            // 
            listaProdutos.AllowUserToAddRows = false;
            listaProdutos.AllowUserToDeleteRows = false;
            listaProdutos.AllowUserToOrderColumns = true;
            listaProdutos.AllowUserToResizeColumns = false;
            listaProdutos.AllowUserToResizeRows = false;
            listaProdutos.BackgroundColor = SystemColors.ButtonFace;
            listaProdutos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            listaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaProdutos.GridColor = SystemColors.ControlLight;
            listaProdutos.Location = new Point(595, 195);
            listaProdutos.Name = "listaProdutos";
            listaProdutos.RowHeadersWidth = 51;
            listaProdutos.Size = new Size(643, 332);
            listaProdutos.TabIndex = 18;
            // 
            // tPedLoja
            // 
            tPedLoja.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tPedLoja.AutoSize = true;
            tPedLoja.Location = new Point(120, 155);
            tPedLoja.Name = "tPedLoja";
            tPedLoja.Size = new Size(228, 20);
            tPedLoja.TabIndex = 4;
            tPedLoja.Text = "ADICIONAR ITEM AO CARRINHO";
            // 
            // tTotalAPagar
            // 
            tTotalAPagar.BackColor = Color.FromArgb(78, 41, 21);
            tTotalAPagar.BorderStyle = BorderStyle.FixedSingle;
            tTotalAPagar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tTotalAPagar.ForeColor = SystemColors.ButtonHighlight;
            tTotalAPagar.Location = new Point(667, 544);
            tTotalAPagar.Name = "tTotalAPagar";
            tTotalAPagar.RightToLeft = RightToLeft.No;
            tTotalAPagar.Size = new Size(504, 27);
            tTotalAPagar.TabIndex = 19;
            tTotalAPagar.Text = "TOTAL A PAGAR";
            tTotalAPagar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdditem
            // 
            btnAdditem.BackColor = Color.FromArgb(55, 124, 38);
            btnAdditem.FlatStyle = FlatStyle.Popup;
            btnAdditem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdditem.ForeColor = SystemColors.Control;
            btnAdditem.Location = new Point(146, 624);
            btnAdditem.Name = "btnAdditem";
            btnAdditem.Size = new Size(193, 29);
            btnAdditem.TabIndex = 15;
            btnAdditem.Text = "Adicionar item";
            btnAdditem.UseVisualStyleBackColor = false;
            btnAdditem.Click += btnAdditem_Click;
            // 
            // btnExcItem
            // 
            btnExcItem.BackColor = Color.FromArgb(112, 41, 41);
            btnExcItem.FlatStyle = FlatStyle.Popup;
            btnExcItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcItem.ForeColor = SystemColors.Control;
            btnExcItem.Location = new Point(356, 624);
            btnExcItem.Name = "btnExcItem";
            btnExcItem.Size = new Size(193, 29);
            btnExcItem.TabIndex = 16;
            btnExcItem.Text = "Limpas dados";
            btnExcItem.UseVisualStyleBackColor = false;
            btnExcItem.Click += btnExcItem_Click;
            // 
            // btnExcItemList
            // 
            btnExcItemList.BackColor = Color.FromArgb(112, 41, 41);
            btnExcItemList.FlatStyle = FlatStyle.Popup;
            btnExcItemList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcItemList.ForeColor = SystemColors.Control;
            btnExcItemList.Location = new Point(928, 624);
            btnExcItemList.Name = "btnExcItemList";
            btnExcItemList.Size = new Size(193, 29);
            btnExcItemList.TabIndex = 22;
            btnExcItemList.Text = "Excluir Item";
            btnExcItemList.UseVisualStyleBackColor = false;
            btnExcItemList.Click += btnExcItemList_Click;
            // 
            // btnEmitirPed
            // 
            btnEmitirPed.BackColor = Color.FromArgb(55, 124, 38);
            btnEmitirPed.FlatStyle = FlatStyle.Popup;
            btnEmitirPed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmitirPed.ForeColor = SystemColors.Control;
            btnEmitirPed.Location = new Point(718, 624);
            btnEmitirPed.Name = "btnEmitirPed";
            btnEmitirPed.Size = new Size(193, 29);
            btnEmitirPed.TabIndex = 21;
            btnEmitirPed.Text = "Emitir Pedido";
            btnEmitirPed.UseVisualStyleBackColor = false;
            btnEmitirPed.Click += btnEmitirPed_Click;
            // 
            // tInserir
            // 
            tInserir.BackColor = SystemColors.ScrollBar;
            tInserir.BorderStyle = BorderStyle.FixedSingle;
            tInserir.Location = new Point(817, 58);
            tInserir.Name = "tInserir";
            tInserir.Size = new Size(163, 27);
            tInserir.TabIndex = 25;
            tInserir.Text = "Matricula Vendedor:";
            tInserir.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tDataHoje
            // 
            tDataHoje.BackColor = SystemColors.ScrollBar;
            tDataHoje.BorderStyle = BorderStyle.FixedSingle;
            tDataHoje.Location = new Point(1008, 58);
            tDataHoje.Name = "tDataHoje";
            tDataHoje.Size = new Size(163, 27);
            tDataHoje.TabIndex = 27;
            tDataHoje.Text = "Data:";
            tDataHoje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tCaixaAberto
            // 
            tCaixaAberto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tCaixaAberto.AutoSize = true;
            tCaixaAberto.BackColor = Color.FromArgb(78, 41, 21);
            tCaixaAberto.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            tCaixaAberto.ForeColor = SystemColors.ButtonHighlight;
            tCaixaAberto.Location = new Point(227, 68);
            tCaixaAberto.Name = "tCaixaAberto";
            tCaixaAberto.Size = new Size(261, 46);
            tCaixaAberto.TabIndex = 24;
            tCaixaAberto.Text = "CAIXA ABERTO";
            // 
            // tTituloLista
            // 
            tTituloLista.BackColor = Color.FromArgb(78, 41, 21);
            tTituloLista.BorderStyle = BorderStyle.FixedSingle;
            tTituloLista.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tTituloLista.ForeColor = SystemColors.ButtonHighlight;
            tTituloLista.Location = new Point(595, 165);
            tTituloLista.Name = "tTituloLista";
            tTituloLista.RightToLeft = RightToLeft.No;
            tTituloLista.Size = new Size(643, 27);
            tTituloLista.TabIndex = 17;
            tTituloLista.Text = "LISTA DE PRODUTOS";
            tTituloLista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtData
            // 
            txtData.BackColor = SystemColors.ScrollBar;
            txtData.BorderStyle = BorderStyle.FixedSingle;
            txtData.ForeColor = SystemColors.ControlText;
            txtData.Location = new Point(1008, 95);
            txtData.Name = "txtData";
            txtData.Size = new Size(163, 27);
            txtData.TabIndex = 28;
            txtData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tValorTotal
            // 
            tValorTotal.BackColor = SystemColors.ScrollBar;
            tValorTotal.BorderStyle = BorderStyle.FixedSingle;
            tValorTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tValorTotal.ForeColor = SystemColors.ControlText;
            tValorTotal.Location = new Point(667, 571);
            tValorTotal.Name = "tValorTotal";
            tValorTotal.Size = new Size(504, 27);
            tValorTotal.TabIndex = 20;
            tValorTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSairTelaV
            // 
            btnSairTelaV.Location = new Point(12, 669);
            btnSairTelaV.Name = "btnSairTelaV";
            btnSairTelaV.Size = new Size(94, 40);
            btnSairTelaV.TabIndex = 29;
            btnSairTelaV.Text = "Sair";
            btnSairTelaV.UseVisualStyleBackColor = true;
            btnSairTelaV.Click += btnSairTelaV_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = SystemColors.ScrollBar;
            txtMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtMatricula.ForeColor = SystemColors.ControlText;
            txtMatricula.Location = new Point(817, 95);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(163, 27);
            txtMatricula.TabIndex = 26;
            txtMatricula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grupoAddItem
            // 
            grupoAddItem.Controls.Add(tPedLoja);
            grupoAddItem.Controls.Add(tCodProd);
            grupoAddItem.Controls.Add(tValorUnid);
            grupoAddItem.Controls.Add(tNomeProd);
            grupoAddItem.Controls.Add(txtCodProd);
            grupoAddItem.Controls.Add(txtValorUnid);
            grupoAddItem.Controls.Add(txtNomeProd);
            grupoAddItem.Controls.Add(tQuantidade);
            grupoAddItem.Controls.Add(txtQuantidade);
            grupoAddItem.Controls.Add(tValorTotalProd);
            grupoAddItem.Controls.Add(txtValorTotalProd);
            grupoAddItem.Location = new Point(119, 142);
            grupoAddItem.Name = "grupoAddItem";
            grupoAddItem.Size = new Size(456, 523);
            grupoAddItem.TabIndex = 0;
            grupoAddItem.TabStop = false;
            // 
            // btnGerencial
            // 
            btnGerencial.BackColor = Color.FromArgb(224, 224, 224);
            btnGerencial.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnGerencial.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnGerencial.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            btnGerencial.Location = new Point(1190, 669);
            btnGerencial.Name = "btnGerencial";
            btnGerencial.Size = new Size(146, 40);
            btnGerencial.TabIndex = 30;
            btnGerencial.Text = "Gerencial - Vendas";
            btnGerencial.UseVisualStyleBackColor = false;
            btnGerencial.Click += btnGerencial_Click;
            // 
            // TelaVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 247);
            ClientSize = new Size(1348, 721);
            Controls.Add(btnGerencial);
            Controls.Add(txtMatricula);
            Controls.Add(btnSairTelaV);
            Controls.Add(tValorTotal);
            Controls.Add(txtData);
            Controls.Add(tTituloLista);
            Controls.Add(tCaixaAberto);
            Controls.Add(tDataHoje);
            Controls.Add(tInserir);
            Controls.Add(btnExcItemList);
            Controls.Add(btnEmitirPed);
            Controls.Add(btnExcItem);
            Controls.Add(btnAdditem);
            Controls.Add(tTotalAPagar);
            Controls.Add(listaProdutos);
            Controls.Add(logo1);
            Controls.Add(retcor1);
            Controls.Add(grupoAddItem);
            Name = "TelaVenda";
            Text = "TelaVenda";
            ((System.ComponentModel.ISupportInitialize)logo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaProdutos).EndInit();
            grupoAddItem.ResumeLayout(false);
            grupoAddItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tCodProd;
        private Label tValorUnid;
        private Label tNomeProd;
        private TextBox txtCodProd;
        private TextBox txtValorUnid;
        private TextBox txtNomeProd;
        private Label tQuantidade;
        private TextBox txtQuantidade;
        private Label tValorTotalProd;
        private TextBox txtValorTotalProd;
        private Button retcor1;
        private PictureBox logo1;
        private DataGridView listaProdutos;
        private Label tPedLoja;
        private Label tTotalAPagar;
        private Button btnAdditem;
        private Button btnExcItem;
        private Button btnExcItemList;
        private Button btnEmitirPed;
        private Label tInserir;
        private Label tDataHoje;
        private Label tCaixaAberto;
        private Label tTituloLista;
        private Label txtData;
        private Label tValorTotal;
        private Button btnSairTelaV;
        private Label txtMatricula;
        private GroupBox grupoAddItem;
        private Button btnGerencial;
    }
}