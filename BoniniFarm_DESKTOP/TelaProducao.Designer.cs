namespace BoniniFarm2
{
    partial class TelaProducao
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
            btnTelaRH = new Button();
            btnTelaProduto = new Button();
            btnTelaProducao = new Button();
            btnSairTela = new Button();
            btnForne = new Button();
            btnTelaPlantio = new Button();
            logo2 = new PictureBox();
            retcor2 = new Button();
            listCultivo2 = new DataGridView();
            listColheita = new DataGridView();
            txtNomePlantaC2 = new Label();
            tNomePlantaC2 = new Label();
            txtQuantidade2 = new TextBox();
            txtCodCultivo2 = new Label();
            tQuantidade2 = new Label();
            tDataCultivo = new Label();
            tCodCultivo2 = new Label();
            tGerColheita = new Label();
            txtDataHoje2 = new TextBox();
            tDataHoje2 = new Label();
            btnGerarColheita = new Button();
            txtDateCultivo = new Label();
            btnLimparCult = new Button();
            txtCodColheita = new Label();
            tCodColheita = new Label();
            txtQuantidadeColh = new TextBox();
            tQuantidadeColh = new Label();
            txtDataHojeColh = new TextBox();
            tDataHojeColh = new Label();
            txtNomePlantaColh = new Label();
            tCodPlantaColh = new Label();
            btnAltColheita = new Button();
            btnExcColheita = new Button();
            btnAtualizarColh = new Button();
            btnLimparColh = new Button();
            btnAtualizarCul = new Button();
            tEditarColh = new Label();
            txtCodPlantaC2 = new Label();
            txtCodProdColh = new TextBox();
            tProdColh = new Label();
            txtProdColhE = new TextBox();
            tProdColhE = new Label();
            grupoGerarColheita = new GroupBox();
            tlistaCultivos = new Label();
            btnBuscarCultivo = new Button();
            txtBuscarCultivo = new TextBox();
            grupoEditarColheita = new GroupBox();
            tListaColheitas = new Label();
            btnBuscarColheita = new Button();
            txtBuscarColheita = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listCultivo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listColheita).BeginInit();
            grupoGerarColheita.SuspendLayout();
            grupoEditarColheita.SuspendLayout();
            SuspendLayout();
            // 
            // btnTelaRH
            // 
            btnTelaRH.BackColor = Color.FromArgb(78, 41, 21);
            btnTelaRH.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnTelaRH.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnTelaRH.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnTelaRH.FlatStyle = FlatStyle.Flat;
            btnTelaRH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTelaRH.ForeColor = SystemColors.Control;
            btnTelaRH.Location = new Point(12, 358);
            btnTelaRH.Name = "btnTelaRH";
            btnTelaRH.Size = new Size(213, 29);
            btnTelaRH.TabIndex = 4;
            btnTelaRH.Text = "Recursos Humanos";
            btnTelaRH.TextAlign = ContentAlignment.MiddleLeft;
            btnTelaRH.UseVisualStyleBackColor = true;
            btnTelaRH.Click += btnTelaRH_Click;
            // 
            // btnTelaProduto
            // 
            btnTelaProduto.BackColor = Color.FromArgb(78, 41, 21);
            btnTelaProduto.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnTelaProduto.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnTelaProduto.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnTelaProduto.FlatStyle = FlatStyle.Flat;
            btnTelaProduto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTelaProduto.ForeColor = SystemColors.Control;
            btnTelaProduto.Location = new Point(12, 308);
            btnTelaProduto.Name = "btnTelaProduto";
            btnTelaProduto.Size = new Size(213, 29);
            btnTelaProduto.TabIndex = 3;
            btnTelaProduto.Text = "Produto / Estoque";
            btnTelaProduto.TextAlign = ContentAlignment.MiddleLeft;
            btnTelaProduto.UseVisualStyleBackColor = true;
            btnTelaProduto.Click += btnTelaProduto_Click;
            // 
            // btnTelaProducao
            // 
            btnTelaProducao.BackColor = Color.FromArgb(103, 54, 27);
            btnTelaProducao.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnTelaProducao.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnTelaProducao.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnTelaProducao.FlatStyle = FlatStyle.Flat;
            btnTelaProducao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTelaProducao.ForeColor = SystemColors.Control;
            btnTelaProducao.Location = new Point(12, 256);
            btnTelaProducao.Name = "btnTelaProducao";
            btnTelaProducao.Size = new Size(213, 29);
            btnTelaProducao.TabIndex = 2;
            btnTelaProducao.Text = "Produção";
            btnTelaProducao.TextAlign = ContentAlignment.MiddleLeft;
            btnTelaProducao.UseVisualStyleBackColor = false;
            btnTelaProducao.Click += btnTelaProducao_Click;
            // 
            // btnSairTela
            // 
            btnSairTela.BackColor = Color.FromArgb(100, 59, 36);
            btnSairTela.FlatAppearance.BorderSize = 0;
            btnSairTela.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 87, 54);
            btnSairTela.FlatAppearance.MouseOverBackColor = Color.FromArgb(148, 87, 54);
            btnSairTela.FlatStyle = FlatStyle.Flat;
            btnSairTela.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSairTela.ForeColor = SystemColors.ButtonHighlight;
            btnSairTela.Location = new Point(12, 680);
            btnSairTela.Name = "btnSairTela";
            btnSairTela.Size = new Size(213, 29);
            btnSairTela.TabIndex = 6;
            btnSairTela.Text = "Sair";
            btnSairTela.UseVisualStyleBackColor = true;
            btnSairTela.Click += btnSairTela_Click;
            // 
            // btnForne
            // 
            btnForne.BackColor = Color.FromArgb(78, 41, 21);
            btnForne.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnForne.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnForne.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnForne.FlatStyle = FlatStyle.Flat;
            btnForne.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnForne.ForeColor = SystemColors.Control;
            btnForne.Location = new Point(12, 409);
            btnForne.Name = "btnForne";
            btnForne.Size = new Size(213, 29);
            btnForne.TabIndex = 5;
            btnForne.Text = "Fornecedor";
            btnForne.TextAlign = ContentAlignment.MiddleLeft;
            btnForne.UseVisualStyleBackColor = true;
            btnForne.Click += btnForne_Click;
            // 
            // btnTelaPlantio
            // 
            btnTelaPlantio.BackColor = Color.FromArgb(78, 41, 21);
            btnTelaPlantio.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnTelaPlantio.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnTelaPlantio.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnTelaPlantio.FlatStyle = FlatStyle.Flat;
            btnTelaPlantio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTelaPlantio.ForeColor = SystemColors.Control;
            btnTelaPlantio.Location = new Point(12, 204);
            btnTelaPlantio.Name = "btnTelaPlantio";
            btnTelaPlantio.Size = new Size(213, 29);
            btnTelaPlantio.TabIndex = 1;
            btnTelaPlantio.Text = "Plantio";
            btnTelaPlantio.TextAlign = ContentAlignment.MiddleLeft;
            btnTelaPlantio.UseVisualStyleBackColor = false;
            btnTelaPlantio.Click += btnTelaPlantio_Click;
            // 
            // logo2
            // 
            logo2.BackgroundImageLayout = ImageLayout.Zoom;
            logo2.Enabled = false;
            logo2.Image = Properties.Resources.image;
            logo2.Location = new Point(0, -4);
            logo2.Name = "logo2";
            logo2.Size = new Size(240, 124);
            logo2.SizeMode = PictureBoxSizeMode.Zoom;
            logo2.TabIndex = 4;
            logo2.TabStop = false;
            // 
            // retcor2
            // 
            retcor2.BackColor = Color.FromArgb(78, 41, 21);
            retcor2.Enabled = false;
            retcor2.FlatStyle = FlatStyle.Flat;
            retcor2.ForeColor = Color.DarkGoldenrod;
            retcor2.Location = new Point(0, -4);
            retcor2.Name = "retcor2";
            retcor2.Size = new Size(240, 725);
            retcor2.TabIndex = 0;
            retcor2.UseMnemonic = false;
            retcor2.UseVisualStyleBackColor = false;
            // 
            // listCultivo2
            // 
            listCultivo2.AllowUserToAddRows = false;
            listCultivo2.AllowUserToDeleteRows = false;
            listCultivo2.AllowUserToOrderColumns = true;
            listCultivo2.AllowUserToResizeRows = false;
            listCultivo2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            listCultivo2.BackgroundColor = SystemColors.Control;
            listCultivo2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listCultivo2.Location = new Point(275, 61);
            listCultivo2.MultiSelect = false;
            listCultivo2.Name = "listCultivo2";
            listCultivo2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            listCultivo2.Size = new Size(535, 280);
            listCultivo2.TabIndex = 8;
            listCultivo2.CellContentClick += listCultivo_CellClick;
            // 
            // listColheita
            // 
            listColheita.AllowUserToAddRows = false;
            listColheita.AllowUserToDeleteRows = false;
            listColheita.AllowUserToOrderColumns = true;
            listColheita.AllowUserToResizeRows = false;
            listColheita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            listColheita.BackgroundColor = SystemColors.Control;
            listColheita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listColheita.Location = new Point(275, 419);
            listColheita.MultiSelect = false;
            listColheita.Name = "listColheita";
            listColheita.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            listColheita.Size = new Size(698, 276);
            listColheita.TabIndex = 26;
            listColheita.CellContentClick += listColheita_CellClick;
            // 
            // txtNomePlantaC2
            // 
            txtNomePlantaC2.BackColor = SystemColors.ScrollBar;
            txtNomePlantaC2.BorderStyle = BorderStyle.FixedSingle;
            txtNomePlantaC2.Location = new Point(1055, 199);
            txtNomePlantaC2.Name = "txtNomePlantaC2";
            txtNomePlantaC2.Size = new Size(242, 27);
            txtNomePlantaC2.TabIndex = 17;
            // 
            // tNomePlantaC2
            // 
            tNomePlantaC2.BackColor = SystemColors.ScrollBar;
            tNomePlantaC2.BorderStyle = BorderStyle.FixedSingle;
            tNomePlantaC2.Location = new Point(856, 199);
            tNomePlantaC2.Name = "tNomePlantaC2";
            tNomePlantaC2.Size = new Size(193, 27);
            tNomePlantaC2.TabIndex = 16;
            tNomePlantaC2.Text = "Nome da planta:";
            // 
            // txtQuantidade2
            // 
            txtQuantidade2.Location = new Point(1055, 237);
            txtQuantidade2.Name = "txtQuantidade2";
            txtQuantidade2.Size = new Size(242, 27);
            txtQuantidade2.TabIndex = 19;
            // 
            // txtCodCultivo2
            // 
            txtCodCultivo2.BackColor = SystemColors.ScrollBar;
            txtCodCultivo2.BorderStyle = BorderStyle.FixedSingle;
            txtCodCultivo2.Location = new Point(1055, 86);
            txtCodCultivo2.Name = "txtCodCultivo2";
            txtCodCultivo2.Size = new Size(242, 27);
            txtCodCultivo2.TabIndex = 11;
            // 
            // tQuantidade2
            // 
            tQuantidade2.BackColor = SystemColors.ScrollBar;
            tQuantidade2.BorderStyle = BorderStyle.FixedSingle;
            tQuantidade2.Location = new Point(856, 237);
            tQuantidade2.Name = "tQuantidade2";
            tQuantidade2.Size = new Size(193, 27);
            tQuantidade2.TabIndex = 18;
            tQuantidade2.Text = "Quantidade colhida:";
            // 
            // tDataCultivo
            // 
            tDataCultivo.BackColor = SystemColors.ScrollBar;
            tDataCultivo.BorderStyle = BorderStyle.FixedSingle;
            tDataCultivo.Location = new Point(856, 123);
            tDataCultivo.Name = "tDataCultivo";
            tDataCultivo.Size = new Size(193, 27);
            tDataCultivo.TabIndex = 12;
            tDataCultivo.Text = "Data do cultivo:";
            // 
            // tCodCultivo2
            // 
            tCodCultivo2.BackColor = SystemColors.ScrollBar;
            tCodCultivo2.BorderStyle = BorderStyle.FixedSingle;
            tCodCultivo2.Location = new Point(856, 86);
            tCodCultivo2.Name = "tCodCultivo2";
            tCodCultivo2.Size = new Size(193, 27);
            tCodCultivo2.TabIndex = 10;
            tCodCultivo2.Text = "Código selecionado:";
            // 
            // tGerColheita
            // 
            tGerColheita.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tGerColheita.AutoSize = true;
            tGerColheita.Font = new Font("Segoe UI", 13F);
            tGerColheita.Location = new Point(743, 45);
            tGerColheita.Name = "tGerColheita";
            tGerColheita.Size = new Size(182, 30);
            tGerColheita.TabIndex = 3;
            tGerColheita.Text = "GERAR COLHEITA";
            // 
            // txtDataHoje2
            // 
            txtDataHoje2.Location = new Point(1055, 160);
            txtDataHoje2.Name = "txtDataHoje2";
            txtDataHoje2.Size = new Size(242, 27);
            txtDataHoje2.TabIndex = 15;
            // 
            // tDataHoje2
            // 
            tDataHoje2.BackColor = SystemColors.ScrollBar;
            tDataHoje2.BorderStyle = BorderStyle.FixedSingle;
            tDataHoje2.Location = new Point(856, 160);
            tDataHoje2.Name = "tDataHoje2";
            tDataHoje2.Size = new Size(193, 27);
            tDataHoje2.TabIndex = 14;
            tDataHoje2.Text = "Data da colheita:";
            // 
            // btnGerarColheita
            // 
            btnGerarColheita.BackColor = Color.FromArgb(78, 41, 21);
            btnGerarColheita.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnGerarColheita.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnGerarColheita.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnGerarColheita.FlatStyle = FlatStyle.Flat;
            btnGerarColheita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGerarColheita.ForeColor = SystemColors.Control;
            btnGerarColheita.Location = new Point(882, 312);
            btnGerarColheita.Name = "btnGerarColheita";
            btnGerarColheita.Size = new Size(124, 29);
            btnGerarColheita.TabIndex = 22;
            btnGerarColheita.Text = "Gerar Colheita";
            btnGerarColheita.UseVisualStyleBackColor = true;
            btnGerarColheita.Click += btnGerarColheita_Click;
            // 
            // txtDateCultivo
            // 
            txtDateCultivo.BackColor = SystemColors.ScrollBar;
            txtDateCultivo.BorderStyle = BorderStyle.FixedSingle;
            txtDateCultivo.Location = new Point(1055, 123);
            txtDateCultivo.Name = "txtDateCultivo";
            txtDateCultivo.Size = new Size(242, 27);
            txtDateCultivo.TabIndex = 13;
            // 
            // btnLimparCult
            // 
            btnLimparCult.BackColor = Color.FromArgb(78, 41, 21);
            btnLimparCult.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnLimparCult.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnLimparCult.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnLimparCult.FlatStyle = FlatStyle.Flat;
            btnLimparCult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimparCult.ForeColor = SystemColors.Control;
            btnLimparCult.Location = new Point(1164, 312);
            btnLimparCult.Name = "btnLimparCult";
            btnLimparCult.Size = new Size(124, 29);
            btnLimparCult.TabIndex = 24;
            btnLimparCult.Text = "Limpar";
            btnLimparCult.UseVisualStyleBackColor = true;
            btnLimparCult.Click += btnLimparCult_Click;
            // 
            // txtCodColheita
            // 
            txtCodColheita.BackColor = SystemColors.ScrollBar;
            txtCodColheita.BorderStyle = BorderStyle.FixedSingle;
            txtCodColheita.Location = new Point(1151, 435);
            txtCodColheita.Name = "txtCodColheita";
            txtCodColheita.Size = new Size(158, 27);
            txtCodColheita.TabIndex = 28;
            // 
            // tCodColheita
            // 
            tCodColheita.BackColor = SystemColors.ScrollBar;
            tCodColheita.BorderStyle = BorderStyle.FixedSingle;
            tCodColheita.Location = new Point(987, 435);
            tCodColheita.Name = "tCodColheita";
            tCodColheita.Size = new Size(158, 27);
            tCodColheita.TabIndex = 27;
            tCodColheita.Text = "Código selecionado:";
            // 
            // txtQuantidadeColh
            // 
            txtQuantidadeColh.Location = new Point(1151, 508);
            txtQuantidadeColh.Name = "txtQuantidadeColh";
            txtQuantidadeColh.Size = new Size(158, 27);
            txtQuantidadeColh.TabIndex = 32;
            // 
            // tQuantidadeColh
            // 
            tQuantidadeColh.BackColor = SystemColors.ScrollBar;
            tQuantidadeColh.BorderStyle = BorderStyle.FixedSingle;
            tQuantidadeColh.Location = new Point(987, 508);
            tQuantidadeColh.Name = "tQuantidadeColh";
            tQuantidadeColh.Size = new Size(158, 27);
            tQuantidadeColh.TabIndex = 31;
            tQuantidadeColh.Text = "Quantidade colhida:";
            // 
            // txtDataHojeColh
            // 
            txtDataHojeColh.Location = new Point(1151, 546);
            txtDataHojeColh.Name = "txtDataHojeColh";
            txtDataHojeColh.Size = new Size(158, 27);
            txtDataHojeColh.TabIndex = 34;
            // 
            // tDataHojeColh
            // 
            tDataHojeColh.BackColor = SystemColors.ScrollBar;
            tDataHojeColh.BorderStyle = BorderStyle.FixedSingle;
            tDataHojeColh.Location = new Point(987, 546);
            tDataHojeColh.Name = "tDataHojeColh";
            tDataHojeColh.Size = new Size(158, 27);
            tDataHojeColh.TabIndex = 33;
            tDataHojeColh.Text = "Data da colheita:";
            // 
            // txtNomePlantaColh
            // 
            txtNomePlantaColh.BackColor = SystemColors.ScrollBar;
            txtNomePlantaColh.BorderStyle = BorderStyle.FixedSingle;
            txtNomePlantaColh.Location = new Point(1151, 473);
            txtNomePlantaColh.Name = "txtNomePlantaColh";
            txtNomePlantaColh.Size = new Size(158, 27);
            txtNomePlantaColh.TabIndex = 30;
            // 
            // tCodPlantaColh
            // 
            tCodPlantaColh.BackColor = SystemColors.ScrollBar;
            tCodPlantaColh.BorderStyle = BorderStyle.FixedSingle;
            tCodPlantaColh.Location = new Point(987, 473);
            tCodPlantaColh.Name = "tCodPlantaColh";
            tCodPlantaColh.Size = new Size(158, 27);
            tCodPlantaColh.TabIndex = 29;
            tCodPlantaColh.Text = "Nome da planta:";
            // 
            // btnAltColheita
            // 
            btnAltColheita.BackColor = Color.FromArgb(78, 41, 21);
            btnAltColheita.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnAltColheita.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnAltColheita.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnAltColheita.FlatStyle = FlatStyle.Flat;
            btnAltColheita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAltColheita.ForeColor = SystemColors.Control;
            btnAltColheita.Location = new Point(1035, 624);
            btnAltColheita.Name = "btnAltColheita";
            btnAltColheita.Size = new Size(100, 29);
            btnAltColheita.TabIndex = 37;
            btnAltColheita.Text = "Alterar";
            btnAltColheita.UseVisualStyleBackColor = true;
            btnAltColheita.Click += btnAltColheita_Click;
            // 
            // btnExcColheita
            // 
            btnExcColheita.BackColor = Color.FromArgb(78, 41, 21);
            btnExcColheita.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnExcColheita.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnExcColheita.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnExcColheita.FlatStyle = FlatStyle.Flat;
            btnExcColheita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcColheita.ForeColor = SystemColors.Control;
            btnExcColheita.Location = new Point(1161, 624);
            btnExcColheita.Name = "btnExcColheita";
            btnExcColheita.Size = new Size(100, 29);
            btnExcColheita.TabIndex = 38;
            btnExcColheita.Text = "Excluir";
            btnExcColheita.UseVisualStyleBackColor = true;
            btnExcColheita.Click += btnExcColheita_Click;
            // 
            // btnAtualizarColh
            // 
            btnAtualizarColh.BackColor = Color.FromArgb(78, 41, 21);
            btnAtualizarColh.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnAtualizarColh.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarColh.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarColh.FlatStyle = FlatStyle.Flat;
            btnAtualizarColh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtualizarColh.ForeColor = SystemColors.Control;
            btnAtualizarColh.Location = new Point(1035, 664);
            btnAtualizarColh.Name = "btnAtualizarColh";
            btnAtualizarColh.Size = new Size(100, 29);
            btnAtualizarColh.TabIndex = 39;
            btnAtualizarColh.Text = "Atualizar";
            btnAtualizarColh.UseVisualStyleBackColor = true;
            btnAtualizarColh.Click += btnAtualizarColh_Click;
            // 
            // btnLimparColh
            // 
            btnLimparColh.BackColor = Color.FromArgb(78, 41, 21);
            btnLimparColh.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnLimparColh.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnLimparColh.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnLimparColh.FlatStyle = FlatStyle.Flat;
            btnLimparColh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimparColh.ForeColor = SystemColors.Control;
            btnLimparColh.Location = new Point(1161, 664);
            btnLimparColh.Name = "btnLimparColh";
            btnLimparColh.Size = new Size(100, 29);
            btnLimparColh.TabIndex = 40;
            btnLimparColh.Text = "Limpar";
            btnLimparColh.UseVisualStyleBackColor = true;
            btnLimparColh.Click += btnLimparColh_Click;
            // 
            // btnAtualizarCul
            // 
            btnAtualizarCul.BackColor = Color.FromArgb(78, 41, 21);
            btnAtualizarCul.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnAtualizarCul.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarCul.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarCul.FlatStyle = FlatStyle.Flat;
            btnAtualizarCul.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtualizarCul.ForeColor = SystemColors.Control;
            btnAtualizarCul.Location = new Point(1024, 312);
            btnAtualizarCul.Name = "btnAtualizarCul";
            btnAtualizarCul.Size = new Size(124, 29);
            btnAtualizarCul.TabIndex = 23;
            btnAtualizarCul.Text = "Atualizar";
            btnAtualizarCul.UseVisualStyleBackColor = true;
            btnAtualizarCul.Click += btnAtualizarCul_Click;
            // 
            // tEditarColh
            // 
            tEditarColh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tEditarColh.AutoSize = true;
            tEditarColh.Font = new Font("Segoe UI", 13F);
            tEditarColh.Location = new Point(797, 28);
            tEditarColh.Name = "tEditarColh";
            tEditarColh.Size = new Size(185, 30);
            tEditarColh.TabIndex = 3;
            tEditarColh.Text = "EDITAR COLHEITA";
            // 
            // txtCodPlantaC2
            // 
            txtCodPlantaC2.BackColor = SystemColors.ScrollBar;
            txtCodPlantaC2.BorderStyle = BorderStyle.FixedSingle;
            txtCodPlantaC2.Enabled = false;
            txtCodPlantaC2.Location = new Point(856, 46);
            txtCodPlantaC2.Name = "txtCodPlantaC2";
            txtCodPlantaC2.Size = new Size(82, 27);
            txtCodPlantaC2.TabIndex = 9;
            txtCodPlantaC2.Visible = false;
            // 
            // txtCodProdColh
            // 
            txtCodProdColh.Location = new Point(1055, 275);
            txtCodProdColh.Name = "txtCodProdColh";
            txtCodProdColh.Size = new Size(242, 27);
            txtCodProdColh.TabIndex = 21;
            // 
            // tProdColh
            // 
            tProdColh.BackColor = SystemColors.ScrollBar;
            tProdColh.BorderStyle = BorderStyle.FixedSingle;
            tProdColh.Location = new Point(856, 275);
            tProdColh.Name = "tProdColh";
            tProdColh.Size = new Size(193, 27);
            tProdColh.TabIndex = 20;
            tProdColh.Text = "Produto relacionado:";
            // 
            // txtProdColhE
            // 
            txtProdColhE.Location = new Point(1151, 584);
            txtProdColhE.Name = "txtProdColhE";
            txtProdColhE.Size = new Size(158, 27);
            txtProdColhE.TabIndex = 36;
            // 
            // tProdColhE
            // 
            tProdColhE.BackColor = SystemColors.ScrollBar;
            tProdColhE.BorderStyle = BorderStyle.FixedSingle;
            tProdColhE.Location = new Point(987, 584);
            tProdColhE.Name = "tProdColhE";
            tProdColhE.Size = new Size(158, 27);
            tProdColhE.TabIndex = 35;
            tProdColhE.Text = "Produto relacionado:";
            // 
            // grupoGerarColheita
            // 
            grupoGerarColheita.Controls.Add(tlistaCultivos);
            grupoGerarColheita.Controls.Add(btnBuscarCultivo);
            grupoGerarColheita.Controls.Add(txtBuscarCultivo);
            grupoGerarColheita.Controls.Add(tGerColheita);
            grupoGerarColheita.Location = new Point(258, -2);
            grupoGerarColheita.Name = "grupoGerarColheita";
            grupoGerarColheita.Size = new Size(1064, 358);
            grupoGerarColheita.TabIndex = 7;
            grupoGerarColheita.TabStop = false;
            // 
            // tlistaCultivos
            // 
            tlistaCultivos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlistaCultivos.AutoSize = true;
            tlistaCultivos.Enabled = false;
            tlistaCultivos.Font = new Font("Segoe UI", 10F);
            tlistaCultivos.Location = new Point(419, 34);
            tlistaCultivos.Name = "tlistaCultivos";
            tlistaCultivos.Size = new Size(133, 23);
            tlistaCultivos.TabIndex = 32;
            tlistaCultivos.Text = "Lista de Cultivos";
            // 
            // btnBuscarCultivo
            // 
            btnBuscarCultivo.BackColor = Color.FromArgb(75, 107, 36);
            btnBuscarCultivo.FlatAppearance.BorderColor = Color.FromArgb(75, 107, 36);
            btnBuscarCultivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarCultivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarCultivo.FlatStyle = FlatStyle.Popup;
            btnBuscarCultivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarCultivo.ForeColor = SystemColors.Control;
            btnBuscarCultivo.Location = new Point(210, 30);
            btnBuscarCultivo.Name = "btnBuscarCultivo";
            btnBuscarCultivo.Size = new Size(70, 27);
            btnBuscarCultivo.TabIndex = 1;
            btnBuscarCultivo.Text = "Buscar";
            btnBuscarCultivo.UseVisualStyleBackColor = false;
            btnBuscarCultivo.Click += btnBuscarCultivo_Click;
            // 
            // txtBuscarCultivo
            // 
            txtBuscarCultivo.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarCultivo.CharacterCasing = CharacterCasing.Lower;
            txtBuscarCultivo.ForeColor = Color.Gray;
            txtBuscarCultivo.Location = new Point(17, 30);
            txtBuscarCultivo.Name = "txtBuscarCultivo";
            txtBuscarCultivo.RightToLeft = RightToLeft.No;
            txtBuscarCultivo.Size = new Size(187, 27);
            txtBuscarCultivo.TabIndex = 0;
            txtBuscarCultivo.Text = "inserir código do cultivo...";
            txtBuscarCultivo.Enter += txtBuscarCultivo_Enter;
            txtBuscarCultivo.Leave += txtBuscarCultivo_Leave;
            // 
            // grupoEditarColheita
            // 
            grupoEditarColheita.Controls.Add(tListaColheitas);
            grupoEditarColheita.Controls.Add(btnBuscarColheita);
            grupoEditarColheita.Controls.Add(txtBuscarColheita);
            grupoEditarColheita.Controls.Add(tEditarColh);
            grupoEditarColheita.Location = new Point(258, 358);
            grupoEditarColheita.Name = "grupoEditarColheita";
            grupoEditarColheita.Size = new Size(1064, 351);
            grupoEditarColheita.TabIndex = 25;
            grupoEditarColheita.TabStop = false;
            // 
            // tListaColheitas
            // 
            tListaColheitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tListaColheitas.AutoSize = true;
            tListaColheitas.Enabled = false;
            tListaColheitas.Font = new Font("Segoe UI", 10F);
            tListaColheitas.Location = new Point(572, 32);
            tListaColheitas.Name = "tListaColheitas";
            tListaColheitas.Size = new Size(143, 23);
            tListaColheitas.TabIndex = 33;
            tListaColheitas.Text = "Lista de Colheitas\r\n";
            // 
            // btnBuscarColheita
            // 
            btnBuscarColheita.BackColor = Color.FromArgb(75, 107, 36);
            btnBuscarColheita.FlatAppearance.BorderColor = Color.FromArgb(75, 107, 36);
            btnBuscarColheita.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarColheita.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarColheita.FlatStyle = FlatStyle.Popup;
            btnBuscarColheita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarColheita.ForeColor = SystemColors.Control;
            btnBuscarColheita.Location = new Point(210, 28);
            btnBuscarColheita.Name = "btnBuscarColheita";
            btnBuscarColheita.Size = new Size(70, 27);
            btnBuscarColheita.TabIndex = 1;
            btnBuscarColheita.Text = "Buscar";
            btnBuscarColheita.UseVisualStyleBackColor = false;
            btnBuscarColheita.Click += btnBuscarColheita_Click;
            // 
            // txtBuscarColheita
            // 
            txtBuscarColheita.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarColheita.CharacterCasing = CharacterCasing.Lower;
            txtBuscarColheita.ForeColor = Color.Gray;
            txtBuscarColheita.Location = new Point(17, 28);
            txtBuscarColheita.Name = "txtBuscarColheita";
            txtBuscarColheita.RightToLeft = RightToLeft.No;
            txtBuscarColheita.Size = new Size(187, 27);
            txtBuscarColheita.TabIndex = 0;
            txtBuscarColheita.Text = "inserir código da colheita...";
            txtBuscarColheita.Enter += txtBuscarColheita_Enter;
            txtBuscarColheita.Leave += txtBuscarColheita_Leave;
            // 
            // TelaProducao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(txtProdColhE);
            Controls.Add(tProdColhE);
            Controls.Add(txtCodProdColh);
            Controls.Add(tProdColh);
            Controls.Add(txtCodPlantaC2);
            Controls.Add(btnAtualizarCul);
            Controls.Add(btnLimparColh);
            Controls.Add(btnAtualizarColh);
            Controls.Add(btnExcColheita);
            Controls.Add(btnAltColheita);
            Controls.Add(txtNomePlantaColh);
            Controls.Add(tCodPlantaColh);
            Controls.Add(txtDataHojeColh);
            Controls.Add(tDataHojeColh);
            Controls.Add(txtQuantidadeColh);
            Controls.Add(tQuantidadeColh);
            Controls.Add(txtCodColheita);
            Controls.Add(tCodColheita);
            Controls.Add(btnLimparCult);
            Controls.Add(txtDateCultivo);
            Controls.Add(btnGerarColheita);
            Controls.Add(txtDataHoje2);
            Controls.Add(tDataHoje2);
            Controls.Add(txtNomePlantaC2);
            Controls.Add(tNomePlantaC2);
            Controls.Add(txtQuantidade2);
            Controls.Add(txtCodCultivo2);
            Controls.Add(tQuantidade2);
            Controls.Add(tDataCultivo);
            Controls.Add(tCodCultivo2);
            Controls.Add(listColheita);
            Controls.Add(listCultivo2);
            Controls.Add(btnTelaRH);
            Controls.Add(btnTelaProduto);
            Controls.Add(btnTelaProducao);
            Controls.Add(btnSairTela);
            Controls.Add(btnForne);
            Controls.Add(btnTelaPlantio);
            Controls.Add(logo2);
            Controls.Add(retcor2);
            Controls.Add(grupoGerarColheita);
            Controls.Add(grupoEditarColheita);
            Name = "TelaProducao";
            Text = "TelaProducao";
            Load += TelaProducao_Load;
            ((System.ComponentModel.ISupportInitialize)logo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)listCultivo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)listColheita).EndInit();
            grupoGerarColheita.ResumeLayout(false);
            grupoGerarColheita.PerformLayout();
            grupoEditarColheita.ResumeLayout(false);
            grupoEditarColheita.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTelaRH;
        private Button btnTelaProduto;
        private Button btnTelaProducao;
        private Button btnSairTela;
        private Button btnForne;
        private Button btnTelaPlantio;
        private PictureBox logo2;
        private Button retcor2;
        private DataGridView listCultivo2;
        private DataGridView listColheita;
        private TextBox txtDataCultivo;
        private Label txtNomePlantaC2;
        private Label tNomePlantaC2;
        private TextBox txtQuantidade2;
        private Label txtCodCultivo2;
        private Label tQuantidade2;
        private Label tDataCultivo;
        private Label tCodCultivo2;
        private Label tGerColheita;
        private TextBox txtDataHoje2;
        private Label tDataHoje2;
        private Button btnGerarColheita;
        private Label txtDateCultivo;
        private Button btnLimparCult;
        private Label txtCodColheita;
        private Label tCodColheita;
        private TextBox txtQuantidadeColh;
        private Label tQuantidadeColh;
        private TextBox txtDataHojeColh;
        private Label tDataHojeColh;
        private Label txtNomePlantaColh;
        private Label tCodPlantaColh;
        private Button btnAltColheita;
        private Button btnExcColheita;
        private Button btnAtualizarColh;
        private Button btnLimparColh;
        private Button btnAtualizarCul;
        private Label tEditarColh;
        private Label txtCodPlantaC2;
        private TextBox txtCodProdColh;
        private Label tProdColh;
        private TextBox txtProdColhE;
        private Label tProdColhE;
        private GroupBox grupoGerarColheita;
        private GroupBox grupoEditarColheita;
        private Button btnBuscarCultivo;
        private TextBox txtBuscarCultivo;
        private Button btnBuscarColheita;
        private TextBox txtBuscarColheita;
        private Label tlistaCultivos;
        private Label tListaColheitas;
    }
}