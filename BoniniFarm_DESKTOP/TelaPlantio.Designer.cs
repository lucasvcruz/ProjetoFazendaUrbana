    namespace BoniniFarm2
{
    partial class TelaPlantio
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
            retcor2 = new Button();
            logo2 = new PictureBox();
            btnTelaPlantio = new Button();
            btnForne = new Button();
            btnSairTela = new Button();
            btnTelaProducao = new Button();
            btnTelaProduto = new Button();
            btnTelaRH = new Button();
            listPlanta = new DataGridView();
            tCodPlanta = new Label();
            tNomePlanta = new Label();
            tTipoPlanta = new Label();
            txtCodPlanta = new Label();
            tCadPlanta = new Label();
            txtNomePlanta = new TextBox();
            txtTipoPlanta = new TextBox();
            btnExcluirPlanta = new Button();
            btnLimparPlanta = new Button();
            btnAlterarPlanta = new Button();
            btnAtualizarPlanta = new Button();
            btnGravarPlanta = new Button();
            listCultivo = new DataGridView();
            tGerCultivo = new Label();
            btnGravarCult = new Button();
            btnAtualizarCult = new Button();
            btnAlterarCult = new Button();
            btnLimparCult = new Button();
            btnExcluirCult = new Button();
            txtQuantidade = new TextBox();
            txtCodCultivo = new Label();
            tQuantidade = new Label();
            tDataHoje = new Label();
            tCodCultivo = new Label();
            tCodPlantaC = new Label();
            txtCodPlantaC = new TextBox();
            txtNomePlantaC = new Label();
            tNomePlantaC = new Label();
            txtDataHoje = new MaskedTextBox();
            grupoPlanta = new GroupBox();
            tlistaPlantas = new Label();
            btnBuscarPlanta = new Button();
            txtBuscarPlanta = new TextBox();
            grupoCultivo = new GroupBox();
            tListaCultivo = new Label();
            btnBuscarCultivo = new Button();
            txtBuscarCultivo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listPlanta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listCultivo).BeginInit();
            grupoPlanta.SuspendLayout();
            grupoCultivo.SuspendLayout();
            SuspendLayout();
            // 
            // retcor2
            // 
            retcor2.AutoSize = true;
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
            // btnTelaPlantio
            // 
            btnTelaPlantio.AutoSize = true;
            btnTelaPlantio.BackColor = Color.FromArgb(103, 54, 27);
            btnTelaPlantio.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnTelaPlantio.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnTelaPlantio.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnTelaPlantio.FlatStyle = FlatStyle.Flat;
            btnTelaPlantio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTelaPlantio.ForeColor = SystemColors.Control;
            btnTelaPlantio.Location = new Point(12, 204);
            btnTelaPlantio.Name = "btnTelaPlantio";
            btnTelaPlantio.Size = new Size(213, 32);
            btnTelaPlantio.TabIndex = 1;
            btnTelaPlantio.Text = "Plantio";
            btnTelaPlantio.TextAlign = ContentAlignment.MiddleLeft;
            btnTelaPlantio.UseVisualStyleBackColor = false;
            btnTelaPlantio.Click += btnTelaPlantio_Click;
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
            // btnTelaProducao
            // 
            btnTelaProducao.BackColor = Color.FromArgb(78, 41, 21);
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
            btnTelaProducao.UseVisualStyleBackColor = true;
            btnTelaProducao.Click += btnTelaProducao_Click;
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
            // listPlanta
            // 
            listPlanta.AllowUserToAddRows = false;
            listPlanta.AllowUserToDeleteRows = false;
            listPlanta.AllowUserToOrderColumns = true;
            listPlanta.AllowUserToResizeRows = false;
            listPlanta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            listPlanta.BackgroundColor = SystemColors.Control;
            listPlanta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listPlanta.Location = new Point(273, 69);
            listPlanta.MultiSelect = false;
            listPlanta.Name = "listPlanta";
            listPlanta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            listPlanta.Size = new Size(494, 254);
            listPlanta.TabIndex = 8;
            // 
            // tCodPlanta
            // 
            tCodPlanta.BackColor = SystemColors.ScrollBar;
            tCodPlanta.BorderStyle = BorderStyle.FixedSingle;
            tCodPlanta.Location = new Point(795, 100);
            tCodPlanta.Name = "tCodPlanta";
            tCodPlanta.Size = new Size(193, 27);
            tCodPlanta.TabIndex = 10;
            tCodPlanta.Text = "Código selecionado:";
            // 
            // tNomePlanta
            // 
            tNomePlanta.BackColor = SystemColors.ScrollBar;
            tNomePlanta.BorderStyle = BorderStyle.FixedSingle;
            tNomePlanta.Location = new Point(795, 175);
            tNomePlanta.Name = "tNomePlanta";
            tNomePlanta.Size = new Size(193, 27);
            tNomePlanta.TabIndex = 12;
            tNomePlanta.Text = "Nome:";
            // 
            // tTipoPlanta
            // 
            tTipoPlanta.BackColor = SystemColors.ScrollBar;
            tTipoPlanta.BorderStyle = BorderStyle.FixedSingle;
            tTipoPlanta.Location = new Point(795, 254);
            tTipoPlanta.Name = "tTipoPlanta";
            tTipoPlanta.Size = new Size(193, 27);
            tTipoPlanta.TabIndex = 14;
            tTipoPlanta.Text = "Tipo:";
            // 
            // txtCodPlanta
            // 
            txtCodPlanta.BackColor = SystemColors.ScrollBar;
            txtCodPlanta.BorderStyle = BorderStyle.FixedSingle;
            txtCodPlanta.Location = new Point(994, 100);
            txtCodPlanta.Name = "txtCodPlanta";
            txtCodPlanta.Size = new Size(193, 27);
            txtCodPlanta.TabIndex = 11;
            // 
            // tCadPlanta
            // 
            tCadPlanta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tCadPlanta.AutoSize = true;
            tCadPlanta.Font = new Font("Segoe UI", 13F);
            tCadPlanta.Location = new Point(908, 48);
            tCadPlanta.Name = "tCadPlanta";
            tCadPlanta.Size = new Size(216, 30);
            tCadPlanta.TabIndex = 9;
            tCadPlanta.Text = "CADASTRAR PLANTA";
            // 
            // txtNomePlanta
            // 
            txtNomePlanta.Location = new Point(994, 175);
            txtNomePlanta.Name = "txtNomePlanta";
            txtNomePlanta.Size = new Size(193, 27);
            txtNomePlanta.TabIndex = 13;
            // 
            // txtTipoPlanta
            // 
            txtTipoPlanta.Location = new Point(994, 254);
            txtTipoPlanta.Name = "txtTipoPlanta";
            txtTipoPlanta.Size = new Size(193, 27);
            txtTipoPlanta.TabIndex = 15;
            // 
            // btnExcluirPlanta
            // 
            btnExcluirPlanta.BackColor = Color.FromArgb(78, 41, 21);
            btnExcluirPlanta.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnExcluirPlanta.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnExcluirPlanta.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnExcluirPlanta.FlatStyle = FlatStyle.Flat;
            btnExcluirPlanta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcluirPlanta.ForeColor = SystemColors.Control;
            btnExcluirPlanta.Location = new Point(1212, 175);
            btnExcluirPlanta.Name = "btnExcluirPlanta";
            btnExcluirPlanta.Size = new Size(100, 29);
            btnExcluirPlanta.TabIndex = 18;
            btnExcluirPlanta.Text = "Excluir";
            btnExcluirPlanta.UseVisualStyleBackColor = true;
            btnExcluirPlanta.Click += btnExcluirPlanta_Click;
            // 
            // btnLimparPlanta
            // 
            btnLimparPlanta.BackColor = Color.FromArgb(78, 41, 21);
            btnLimparPlanta.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnLimparPlanta.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnLimparPlanta.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnLimparPlanta.FlatStyle = FlatStyle.Flat;
            btnLimparPlanta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimparPlanta.ForeColor = SystemColors.Control;
            btnLimparPlanta.Location = new Point(1212, 267);
            btnLimparPlanta.Name = "btnLimparPlanta";
            btnLimparPlanta.Size = new Size(100, 29);
            btnLimparPlanta.TabIndex = 20;
            btnLimparPlanta.Text = "Limpar";
            btnLimparPlanta.UseVisualStyleBackColor = true;
            btnLimparPlanta.Click += btnLimparPlanta_Click;
            // 
            // btnAlterarPlanta
            // 
            btnAlterarPlanta.BackColor = Color.FromArgb(78, 41, 21);
            btnAlterarPlanta.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnAlterarPlanta.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnAlterarPlanta.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnAlterarPlanta.FlatStyle = FlatStyle.Flat;
            btnAlterarPlanta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlterarPlanta.ForeColor = SystemColors.Control;
            btnAlterarPlanta.Location = new Point(1212, 123);
            btnAlterarPlanta.Name = "btnAlterarPlanta";
            btnAlterarPlanta.Size = new Size(100, 29);
            btnAlterarPlanta.TabIndex = 17;
            btnAlterarPlanta.Text = "Alterar";
            btnAlterarPlanta.UseVisualStyleBackColor = true;
            btnAlterarPlanta.Click += btnAlterarPlanta_Click;
            // 
            // btnAtualizarPlanta
            // 
            btnAtualizarPlanta.BackColor = Color.FromArgb(78, 41, 21);
            btnAtualizarPlanta.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnAtualizarPlanta.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarPlanta.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarPlanta.FlatStyle = FlatStyle.Flat;
            btnAtualizarPlanta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtualizarPlanta.ForeColor = SystemColors.Control;
            btnAtualizarPlanta.Location = new Point(1212, 221);
            btnAtualizarPlanta.Name = "btnAtualizarPlanta";
            btnAtualizarPlanta.Size = new Size(100, 29);
            btnAtualizarPlanta.TabIndex = 19;
            btnAtualizarPlanta.Text = "Atualizar";
            btnAtualizarPlanta.UseVisualStyleBackColor = true;
            btnAtualizarPlanta.Click += btnAtualizarPlanta_Click;
            // 
            // btnGravarPlanta
            // 
            btnGravarPlanta.BackColor = Color.FromArgb(78, 41, 21);
            btnGravarPlanta.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnGravarPlanta.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnGravarPlanta.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnGravarPlanta.FlatStyle = FlatStyle.Flat;
            btnGravarPlanta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGravarPlanta.ForeColor = SystemColors.Control;
            btnGravarPlanta.Location = new Point(1212, 74);
            btnGravarPlanta.Name = "btnGravarPlanta";
            btnGravarPlanta.Size = new Size(100, 29);
            btnGravarPlanta.TabIndex = 16;
            btnGravarPlanta.Text = "Gravar";
            btnGravarPlanta.UseVisualStyleBackColor = true;
            btnGravarPlanta.Click += btnGravarPlanta_Click;
            // 
            // listCultivo
            // 
            listCultivo.AllowUserToAddRows = false;
            listCultivo.AllowUserToDeleteRows = false;
            listCultivo.AllowUserToResizeRows = false;
            listCultivo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            listCultivo.BackgroundColor = SystemColors.Control;
            listCultivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listCultivo.Location = new Point(273, 409);
            listCultivo.MultiSelect = false;
            listCultivo.Name = "listCultivo";
            listCultivo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            listCultivo.Size = new Size(494, 264);
            listCultivo.TabIndex = 22;
            listCultivo.CellContentClick += listCultivo_CellClick;
            // 
            // tGerCultivo
            // 
            tGerCultivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tGerCultivo.AutoSize = true;
            tGerCultivo.Font = new Font("Segoe UI", 13F);
            tGerCultivo.Location = new Point(921, 405);
            tGerCultivo.Name = "tGerCultivo";
            tGerCultivo.Size = new Size(170, 30);
            tGerCultivo.TabIndex = 23;
            tGerCultivo.Text = "GERAR CULTIVO";
            // 
            // btnGravarCult
            // 
            btnGravarCult.BackColor = Color.FromArgb(78, 41, 21);
            btnGravarCult.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnGravarCult.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnGravarCult.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnGravarCult.FlatStyle = FlatStyle.Flat;
            btnGravarCult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGravarCult.ForeColor = SystemColors.Control;
            btnGravarCult.Location = new Point(1212, 433);
            btnGravarCult.Name = "btnGravarCult";
            btnGravarCult.Size = new Size(100, 29);
            btnGravarCult.TabIndex = 26;
            btnGravarCult.Text = "Gravar";
            btnGravarCult.UseVisualStyleBackColor = true;
            btnGravarCult.Click += btnGravarCult_Click;
            // 
            // btnAtualizarCult
            // 
            btnAtualizarCult.BackColor = Color.FromArgb(78, 41, 21);
            btnAtualizarCult.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnAtualizarCult.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarCult.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarCult.FlatStyle = FlatStyle.Flat;
            btnAtualizarCult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtualizarCult.ForeColor = SystemColors.Control;
            btnAtualizarCult.Location = new Point(1212, 580);
            btnAtualizarCult.Name = "btnAtualizarCult";
            btnAtualizarCult.Size = new Size(100, 29);
            btnAtualizarCult.TabIndex = 29;
            btnAtualizarCult.Text = "Atualizar";
            btnAtualizarCult.UseVisualStyleBackColor = true;
            btnAtualizarCult.Click += btnAtualizarCult_Click;
            // 
            // btnAlterarCult
            // 
            btnAlterarCult.BackColor = Color.FromArgb(78, 41, 21);
            btnAlterarCult.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnAlterarCult.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnAlterarCult.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnAlterarCult.FlatStyle = FlatStyle.Flat;
            btnAlterarCult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlterarCult.ForeColor = SystemColors.Control;
            btnAlterarCult.Location = new Point(1212, 482);
            btnAlterarCult.Name = "btnAlterarCult";
            btnAlterarCult.Size = new Size(100, 29);
            btnAlterarCult.TabIndex = 27;
            btnAlterarCult.Text = "Alterar";
            btnAlterarCult.UseVisualStyleBackColor = true;
            btnAlterarCult.Click += btnAlterarCult_Click;
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
            btnLimparCult.Location = new Point(1212, 626);
            btnLimparCult.Name = "btnLimparCult";
            btnLimparCult.Size = new Size(100, 29);
            btnLimparCult.TabIndex = 30;
            btnLimparCult.Text = "Limpar";
            btnLimparCult.UseVisualStyleBackColor = true;
            btnLimparCult.Click += btnLimparCult_Click;
            // 
            // btnExcluirCult
            // 
            btnExcluirCult.BackColor = Color.FromArgb(78, 41, 21);
            btnExcluirCult.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnExcluirCult.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnExcluirCult.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnExcluirCult.FlatStyle = FlatStyle.Flat;
            btnExcluirCult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcluirCult.ForeColor = SystemColors.Control;
            btnExcluirCult.Location = new Point(1212, 534);
            btnExcluirCult.Name = "btnExcluirCult";
            btnExcluirCult.Size = new Size(100, 29);
            btnExcluirCult.TabIndex = 28;
            btnExcluirCult.Text = "Excluir";
            btnExcluirCult.UseVisualStyleBackColor = true;
            btnExcluirCult.Click += btnExcluirCult_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(739, 210);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(193, 27);
            txtQuantidade.TabIndex = 7;
            // 
            // txtCodCultivo
            // 
            txtCodCultivo.BackColor = SystemColors.ScrollBar;
            txtCodCultivo.BorderStyle = BorderStyle.FixedSingle;
            txtCodCultivo.Location = new Point(994, 447);
            txtCodCultivo.Name = "txtCodCultivo";
            txtCodCultivo.Size = new Size(193, 27);
            txtCodCultivo.TabIndex = 25;
            // 
            // tQuantidade
            // 
            tQuantidade.BackColor = SystemColors.ScrollBar;
            tQuantidade.BorderStyle = BorderStyle.FixedSingle;
            tQuantidade.Location = new Point(540, 210);
            tQuantidade.Name = "tQuantidade";
            tQuantidade.Size = new Size(193, 27);
            tQuantidade.TabIndex = 6;
            tQuantidade.Text = "Quantidade:";
            // 
            // tDataHoje
            // 
            tDataHoje.BackColor = SystemColors.ScrollBar;
            tDataHoje.BorderStyle = BorderStyle.FixedSingle;
            tDataHoje.Location = new Point(540, 249);
            tDataHoje.Name = "tDataHoje";
            tDataHoje.Size = new Size(193, 26);
            tDataHoje.TabIndex = 8;
            tDataHoje.Text = "Data:";
            // 
            // tCodCultivo
            // 
            tCodCultivo.BackColor = SystemColors.ScrollBar;
            tCodCultivo.BorderStyle = BorderStyle.FixedSingle;
            tCodCultivo.Location = new Point(795, 447);
            tCodCultivo.Name = "tCodCultivo";
            tCodCultivo.Size = new Size(193, 27);
            tCodCultivo.TabIndex = 24;
            tCodCultivo.Text = "Código selecionado:";
            // 
            // tCodPlantaC
            // 
            tCodPlantaC.BackColor = SystemColors.ScrollBar;
            tCodPlantaC.BorderStyle = BorderStyle.FixedSingle;
            tCodPlantaC.Location = new Point(540, 129);
            tCodPlantaC.Name = "tCodPlantaC";
            tCodPlantaC.Size = new Size(193, 27);
            tCodPlantaC.TabIndex = 2;
            tCodPlantaC.Text = "Código da planta:";
            // 
            // txtCodPlantaC
            // 
            txtCodPlantaC.Location = new Point(739, 129);
            txtCodPlantaC.Name = "txtCodPlantaC";
            txtCodPlantaC.Size = new Size(193, 27);
            txtCodPlantaC.TabIndex = 3;
            // 
            // txtNomePlantaC
            // 
            txtNomePlantaC.BackColor = SystemColors.ScrollBar;
            txtNomePlantaC.BorderStyle = BorderStyle.FixedSingle;
            txtNomePlantaC.Location = new Point(739, 170);
            txtNomePlantaC.Name = "txtNomePlantaC";
            txtNomePlantaC.Size = new Size(193, 27);
            txtNomePlantaC.TabIndex = 5;
            // 
            // tNomePlantaC
            // 
            tNomePlantaC.BackColor = SystemColors.ScrollBar;
            tNomePlantaC.BorderStyle = BorderStyle.FixedSingle;
            tNomePlantaC.Location = new Point(540, 170);
            tNomePlantaC.Name = "tNomePlantaC";
            tNomePlantaC.Size = new Size(193, 27);
            tNomePlantaC.TabIndex = 4;
            tNomePlantaC.Text = "Nome da planta:";
            // 
            // txtDataHoje
            // 
            txtDataHoje.Location = new Point(739, 249);
            txtDataHoje.Mask = "00-00-0000";
            txtDataHoje.Name = "txtDataHoje";
            txtDataHoje.Size = new Size(193, 27);
            txtDataHoje.TabIndex = 9;
            txtDataHoje.ValidatingType = typeof(DateTime);
            // 
            // grupoPlanta
            // 
            grupoPlanta.Controls.Add(tlistaPlantas);
            grupoPlanta.Controls.Add(btnBuscarPlanta);
            grupoPlanta.Controls.Add(txtBuscarPlanta);
            grupoPlanta.Location = new Point(255, 12);
            grupoPlanta.Name = "grupoPlanta";
            grupoPlanta.Size = new Size(1081, 332);
            grupoPlanta.TabIndex = 7;
            grupoPlanta.TabStop = false;
            // 
            // tlistaPlantas
            // 
            tlistaPlantas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlistaPlantas.AutoSize = true;
            tlistaPlantas.Enabled = false;
            tlistaPlantas.Font = new Font("Segoe UI", 10F);
            tlistaPlantas.Location = new Point(384, 28);
            tlistaPlantas.Name = "tlistaPlantas";
            tlistaPlantas.Size = new Size(128, 23);
            tlistaPlantas.TabIndex = 31;
            tlistaPlantas.Text = "Lista de Plantas";
            // 
            // btnBuscarPlanta
            // 
            btnBuscarPlanta.BackColor = Color.FromArgb(75, 107, 36);
            btnBuscarPlanta.FlatAppearance.BorderColor = Color.FromArgb(75, 107, 36);
            btnBuscarPlanta.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarPlanta.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarPlanta.FlatStyle = FlatStyle.Popup;
            btnBuscarPlanta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarPlanta.ForeColor = SystemColors.Control;
            btnBuscarPlanta.Location = new Point(282, 24);
            btnBuscarPlanta.Name = "btnBuscarPlanta";
            btnBuscarPlanta.Size = new Size(70, 27);
            btnBuscarPlanta.TabIndex = 1;
            btnBuscarPlanta.Text = "Buscar";
            btnBuscarPlanta.UseVisualStyleBackColor = false;
            btnBuscarPlanta.Click += btnBuscarPlanta_Click;
            // 
            // txtBuscarPlanta
            // 
            txtBuscarPlanta.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarPlanta.CharacterCasing = CharacterCasing.Lower;
            txtBuscarPlanta.ForeColor = Color.Gray;
            txtBuscarPlanta.Location = new Point(18, 24);
            txtBuscarPlanta.Name = "txtBuscarPlanta";
            txtBuscarPlanta.RightToLeft = RightToLeft.No;
            txtBuscarPlanta.Size = new Size(258, 27);
            txtBuscarPlanta.TabIndex = 0;
            txtBuscarPlanta.Text = "inserir código ou o nome da planta...";
            txtBuscarPlanta.Enter += txtBuscarPlanta_Enter;
            txtBuscarPlanta.Leave += txtBuscarPlanta_Leave;
            // 
            // grupoCultivo
            // 
            grupoCultivo.Controls.Add(tListaCultivo);
            grupoCultivo.Controls.Add(txtNomePlantaC);
            grupoCultivo.Controls.Add(tNomePlantaC);
            grupoCultivo.Controls.Add(txtDataHoje);
            grupoCultivo.Controls.Add(btnBuscarCultivo);
            grupoCultivo.Controls.Add(txtQuantidade);
            grupoCultivo.Controls.Add(txtCodPlantaC);
            grupoCultivo.Controls.Add(tQuantidade);
            grupoCultivo.Controls.Add(tCodPlantaC);
            grupoCultivo.Controls.Add(txtBuscarCultivo);
            grupoCultivo.Controls.Add(tDataHoje);
            grupoCultivo.Location = new Point(255, 358);
            grupoCultivo.Name = "grupoCultivo";
            grupoCultivo.Size = new Size(1081, 339);
            grupoCultivo.TabIndex = 21;
            grupoCultivo.TabStop = false;
            // 
            // tListaCultivo
            // 
            tListaCultivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tListaCultivo.AutoSize = true;
            tListaCultivo.Enabled = false;
            tListaCultivo.Font = new Font("Segoe UI", 10F);
            tListaCultivo.Location = new Point(379, 22);
            tListaCultivo.Name = "tListaCultivo";
            tListaCultivo.Size = new Size(133, 23);
            tListaCultivo.TabIndex = 32;
            tListaCultivo.Text = "Lista de Cultivos";
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
            btnBuscarCultivo.Location = new Point(282, 18);
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
            txtBuscarCultivo.Location = new Point(18, 18);
            txtBuscarCultivo.Name = "txtBuscarCultivo";
            txtBuscarCultivo.RightToLeft = RightToLeft.No;
            txtBuscarCultivo.Size = new Size(258, 27);
            txtBuscarCultivo.TabIndex = 0;
            txtBuscarCultivo.Text = "inserir código do cultivo...";
            txtBuscarCultivo.Enter += txtBuscarCultivo_Enter;
            txtBuscarCultivo.Leave += txtBuscarCultivo_Leave;
            // 
            // TelaPlantio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(txtCodCultivo);
            Controls.Add(tCodCultivo);
            Controls.Add(btnGravarCult);
            Controls.Add(btnAtualizarCult);
            Controls.Add(btnAlterarCult);
            Controls.Add(btnLimparCult);
            Controls.Add(btnExcluirCult);
            Controls.Add(tGerCultivo);
            Controls.Add(listCultivo);
            Controls.Add(btnGravarPlanta);
            Controls.Add(btnAtualizarPlanta);
            Controls.Add(btnAlterarPlanta);
            Controls.Add(btnLimparPlanta);
            Controls.Add(btnExcluirPlanta);
            Controls.Add(txtTipoPlanta);
            Controls.Add(txtNomePlanta);
            Controls.Add(tCadPlanta);
            Controls.Add(txtCodPlanta);
            Controls.Add(tTipoPlanta);
            Controls.Add(tNomePlanta);
            Controls.Add(tCodPlanta);
            Controls.Add(listPlanta);
            Controls.Add(btnTelaRH);
            Controls.Add(btnTelaProduto);
            Controls.Add(btnTelaProducao);
            Controls.Add(btnSairTela);
            Controls.Add(btnForne);
            Controls.Add(btnTelaPlantio);
            Controls.Add(logo2);
            Controls.Add(retcor2);
            Controls.Add(grupoPlanta);
            Controls.Add(grupoCultivo);
            Name = "TelaPlantio";
            Text = "TelaPlantio";
            ((System.ComponentModel.ISupportInitialize)logo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)listPlanta).EndInit();
            ((System.ComponentModel.ISupportInitialize)listCultivo).EndInit();
            grupoPlanta.ResumeLayout(false);
            grupoPlanta.PerformLayout();
            grupoCultivo.ResumeLayout(false);
            grupoCultivo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private PictureBox imgPlanta3;
        private PictureBox imgPlanta2;
        private Button retcor2;
        private PictureBox logo2;
        private PictureBox imgPlanta1;
        private Button btnTelaPlantio;
        private Button btnForne;
        private Button btnSairTela;
        private Button btnTelaProducao;
        private Button btnTelaProduto;
        private Button btnTelaRH;
        private DataGridView listCultivo;
        private DataGridView listPlanta;
        private Label tCodPlanta;
        private Label tNomePlanta;
        private Label tTipoPlanta;
        private Label txtCodPlanta;
        private Label tCadPlanta;
        private TextBox txtNomePlanta;
        private TextBox txtTipoPlanta;
        private Button btnExcluirPlanta;
        private Button btnLimparPlanta;
        private Button btnAlterarPlanta;
        private Button btnAtualizarPlanta;
        private TextBox txtQuantidade;
        private Label tDataHoje;
        private Button btnGravarPlanta;
        private Label tGerCultivo;
        private Button btnGravarCult;
        private Button btnAtualizarCult;
        private Button btnAlterarCult;
        private Button btnLimparCult;
        private Button btnExcluirCult;
        private Label txtCodCultivo;
        private Label tQuantidade;
        private Label tCodCultivo;
        private Label tCodPlantaC;
        private TextBox txtCodPlantaC;
        private Label txtNomePlantaC;
        private Label tNomePlantaC;
        private MaskedTextBox txtDataHoje;
        private GroupBox grupoPlanta;
        private GroupBox grupoCultivo;
        private Button btnBuscarPlanta;
        private TextBox txtBuscarPlanta;
        private Button btnBuscarCultivo;
        private TextBox txtBuscarCultivo;
        private Label tlistaPlantas;
        private Label tListaCultivo;
    }
}