namespace BoniniFarm2
{
    partial class TelaRH
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
            txtNomeFunc = new TextBox();
            btnGravarFunc = new Button();
            btnAtualizarFunc = new Button();
            btnAlterarFunc = new Button();
            btnLimparFunc = new Button();
            btnExcluirFunc = new Button();
            tNomeFunc = new Label();
            tEndereco = new Label();
            txtEndereco = new TextBox();
            tCodAdm = new Label();
            tTele = new Label();
            tStatus = new Label();
            tMatricula = new Label();
            tCadProd = new Label();
            listFuncionario = new DataGridView();
            tCargo = new Label();
            tNasc = new Label();
            tLogin = new Label();
            tCpf = new Label();
            tSenha = new Label();
            txtMatricula = new Label();
            txtCodAdm = new TextBox();
            txtCargo = new TextBox();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            tSalario = new Label();
            txtCpf = new MaskedTextBox();
            txtTele = new MaskedTextBox();
            txtNasc = new MaskedTextBox();
            txtSalario = new MaskedTextBox();
            grupoGerenFuncionario = new GroupBox();
            txtStatus = new ComboBox();
            btnBuscarFunc = new Button();
            txtBuscarFunc = new TextBox();
            tlistaFunc = new Label();
            ((System.ComponentModel.ISupportInitialize)logo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listFuncionario).BeginInit();
            grupoGerenFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // btnTelaRH
            // 
            btnTelaRH.BackColor = Color.FromArgb(103, 54, 27);
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
            btnTelaRH.UseVisualStyleBackColor = false;
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
            // txtNomeFunc
            // 
            txtNomeFunc.Location = new Point(0, 150);
            txtNomeFunc.Name = "txtNomeFunc";
            txtNomeFunc.Size = new Size(608, 27);
            txtNomeFunc.TabIndex = 9;
            // 
            // btnGravarFunc
            // 
            btnGravarFunc.BackColor = Color.FromArgb(78, 41, 21);
            btnGravarFunc.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnGravarFunc.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnGravarFunc.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnGravarFunc.FlatStyle = FlatStyle.Flat;
            btnGravarFunc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGravarFunc.ForeColor = SystemColors.Control;
            btnGravarFunc.Location = new Point(624, 277);
            btnGravarFunc.Name = "btnGravarFunc";
            btnGravarFunc.Size = new Size(80, 29);
            btnGravarFunc.TabIndex = 24;
            btnGravarFunc.Text = "Gravar";
            btnGravarFunc.UseVisualStyleBackColor = true;
            btnGravarFunc.Click += btnGravarFunc_Click;
            // 
            // btnAtualizarFunc
            // 
            btnAtualizarFunc.BackColor = Color.FromArgb(78, 41, 21);
            btnAtualizarFunc.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnAtualizarFunc.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarFunc.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnAtualizarFunc.FlatStyle = FlatStyle.Flat;
            btnAtualizarFunc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAtualizarFunc.ForeColor = SystemColors.Control;
            btnAtualizarFunc.Location = new Point(1066, 675);
            btnAtualizarFunc.Name = "btnAtualizarFunc";
            btnAtualizarFunc.Size = new Size(80, 29);
            btnAtualizarFunc.TabIndex = 11;
            btnAtualizarFunc.Text = "Atualizar";
            btnAtualizarFunc.UseVisualStyleBackColor = true;
            btnAtualizarFunc.Click += btnAtualizarFunc_Click;
            // 
            // btnAlterarFunc
            // 
            btnAlterarFunc.BackColor = Color.FromArgb(78, 41, 21);
            btnAlterarFunc.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnAlterarFunc.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnAlterarFunc.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnAlterarFunc.FlatStyle = FlatStyle.Flat;
            btnAlterarFunc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAlterarFunc.ForeColor = SystemColors.Control;
            btnAlterarFunc.Location = new Point(766, 277);
            btnAlterarFunc.Name = "btnAlterarFunc";
            btnAlterarFunc.Size = new Size(80, 29);
            btnAlterarFunc.TabIndex = 25;
            btnAlterarFunc.Text = "Alterar";
            btnAlterarFunc.UseVisualStyleBackColor = true;
            btnAlterarFunc.Click += btnAlterarFunc_Click;
            // 
            // btnLimparFunc
            // 
            btnLimparFunc.BackColor = Color.FromArgb(78, 41, 21);
            btnLimparFunc.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnLimparFunc.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnLimparFunc.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnLimparFunc.FlatStyle = FlatStyle.Flat;
            btnLimparFunc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLimparFunc.ForeColor = SystemColors.Control;
            btnLimparFunc.Location = new Point(896, 276);
            btnLimparFunc.Name = "btnLimparFunc";
            btnLimparFunc.Size = new Size(80, 29);
            btnLimparFunc.TabIndex = 26;
            btnLimparFunc.Text = "Limpar";
            btnLimparFunc.UseVisualStyleBackColor = true;
            btnLimparFunc.Click += btnLimparFunc_Click;
            // 
            // btnExcluirFunc
            // 
            btnExcluirFunc.BackColor = Color.FromArgb(78, 41, 21);
            btnExcluirFunc.FlatAppearance.BorderColor = Color.FromArgb(89, 44, 22);
            btnExcluirFunc.FlatAppearance.MouseDownBackColor = Color.FromArgb(103, 54, 27);
            btnExcluirFunc.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 54, 27);
            btnExcluirFunc.FlatStyle = FlatStyle.Flat;
            btnExcluirFunc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExcluirFunc.ForeColor = SystemColors.Control;
            btnExcluirFunc.Location = new Point(1196, 675);
            btnExcluirFunc.Name = "btnExcluirFunc";
            btnExcluirFunc.Size = new Size(80, 29);
            btnExcluirFunc.TabIndex = 12;
            btnExcluirFunc.Text = "Excluir";
            btnExcluirFunc.UseVisualStyleBackColor = true;
            btnExcluirFunc.Click += btnExcluirFunc_Click;
            // 
            // tNomeFunc
            // 
            tNomeFunc.BackColor = SystemColors.ScrollBar;
            tNomeFunc.BorderStyle = BorderStyle.FixedSingle;
            tNomeFunc.Enabled = false;
            tNomeFunc.Location = new Point(0, 120);
            tNomeFunc.Name = "tNomeFunc";
            tNomeFunc.Size = new Size(608, 27);
            tNomeFunc.TabIndex = 8;
            tNomeFunc.Text = "Nome funcionario:";
            // 
            // tEndereco
            // 
            tEndereco.BackColor = SystemColors.ScrollBar;
            tEndereco.BorderStyle = BorderStyle.FixedSingle;
            tEndereco.Enabled = false;
            tEndereco.Location = new Point(0, 201);
            tEndereco.Name = "tEndereco";
            tEndereco.Size = new Size(608, 27);
            tEndereco.TabIndex = 14;
            tEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(0, 231);
            txtEndereco.Multiline = true;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.ScrollBars = ScrollBars.Horizontal;
            txtEndereco.Size = new Size(608, 27);
            txtEndereco.TabIndex = 15;
            // 
            // tCodAdm
            // 
            tCodAdm.BackColor = SystemColors.ScrollBar;
            tCodAdm.BorderStyle = BorderStyle.FixedSingle;
            tCodAdm.Enabled = false;
            tCodAdm.Location = new Point(624, 152);
            tCodAdm.Name = "tCodAdm";
            tCodAdm.Size = new Size(172, 27);
            tCodAdm.TabIndex = 12;
            tCodAdm.Text = "Codigo de ADM:";
            // 
            // tTele
            // 
            tTele.BackColor = SystemColors.ScrollBar;
            tTele.BorderStyle = BorderStyle.FixedSingle;
            tTele.Enabled = false;
            tTele.Location = new Point(624, 230);
            tTele.Name = "tTele";
            tTele.Size = new Size(174, 27);
            tTele.TabIndex = 18;
            tTele.Text = "Telefone:";
            // 
            // tStatus
            // 
            tStatus.BackColor = SystemColors.ScrollBar;
            tStatus.BorderStyle = BorderStyle.FixedSingle;
            tStatus.Enabled = false;
            tStatus.Location = new Point(624, 72);
            tStatus.Name = "tStatus";
            tStatus.Size = new Size(172, 27);
            tStatus.TabIndex = 6;
            tStatus.Text = "Status matricula:";
            // 
            // tMatricula
            // 
            tMatricula.BackColor = SystemColors.ScrollBar;
            tMatricula.BorderStyle = BorderStyle.FixedSingle;
            tMatricula.Enabled = false;
            tMatricula.Location = new Point(0, 26);
            tMatricula.Name = "tMatricula";
            tMatricula.Size = new Size(174, 27);
            tMatricula.TabIndex = 0;
            tMatricula.Text = "Matricula selecionada:";
            // 
            // tCadProd
            // 
            tCadProd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tCadProd.AutoSize = true;
            tCadProd.Font = new Font("Segoe UI", 13F);
            tCadProd.Location = new Point(483, 19);
            tCadProd.Name = "tCadProd";
            tCadProd.Size = new Size(277, 30);
            tCadProd.TabIndex = 27;
            tCadProd.Text = "GERENCIAR FUNCIONARIO";
            // 
            // listFuncionario
            // 
            listFuncionario.AllowUserToAddRows = false;
            listFuncionario.AllowUserToDeleteRows = false;
            listFuncionario.AllowUserToResizeRows = false;
            listFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            listFuncionario.BackgroundColor = SystemColors.Control;
            listFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listFuncionario.Location = new Point(300, 382);
            listFuncionario.MultiSelect = false;
            listFuncionario.Name = "listFuncionario";
            listFuncionario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            listFuncionario.Size = new Size(976, 281);
            listFuncionario.TabIndex = 10;
            listFuncionario.CellContentClick += listFuncionario_CellClick;
            // 
            // tCargo
            // 
            tCargo.BackColor = SystemColors.ScrollBar;
            tCargo.BorderStyle = BorderStyle.FixedSingle;
            tCargo.Enabled = false;
            tCargo.Location = new Point(0, 72);
            tCargo.Name = "tCargo";
            tCargo.Size = new Size(174, 27);
            tCargo.TabIndex = 2;
            tCargo.Text = "Cargo:";
            // 
            // tNasc
            // 
            tNasc.BackColor = SystemColors.ScrollBar;
            tNasc.BorderStyle = BorderStyle.FixedSingle;
            tNasc.Enabled = false;
            tNasc.Location = new Point(624, 120);
            tNasc.Name = "tNasc";
            tNasc.Size = new Size(174, 27);
            tNasc.TabIndex = 10;
            tNasc.Text = "Data de nascimento:";
            // 
            // tLogin
            // 
            tLogin.BackColor = SystemColors.ScrollBar;
            tLogin.BorderStyle = BorderStyle.FixedSingle;
            tLogin.Enabled = false;
            tLogin.Location = new Point(0, 277);
            tLogin.Name = "tLogin";
            tLogin.Size = new Size(58, 27);
            tLogin.TabIndex = 20;
            tLogin.Text = "Login:";
            // 
            // tCpf
            // 
            tCpf.BackColor = SystemColors.ScrollBar;
            tCpf.BorderStyle = BorderStyle.FixedSingle;
            tCpf.Enabled = false;
            tCpf.Location = new Point(624, 201);
            tCpf.Name = "tCpf";
            tCpf.Size = new Size(174, 27);
            tCpf.TabIndex = 16;
            tCpf.Text = "CPF:";
            // 
            // tSenha
            // 
            tSenha.BackColor = SystemColors.ScrollBar;
            tSenha.BorderStyle = BorderStyle.FixedSingle;
            tSenha.Enabled = false;
            tSenha.Location = new Point(331, 276);
            tSenha.Name = "tSenha";
            tSenha.Size = new Size(64, 27);
            tSenha.TabIndex = 22;
            tSenha.Text = "Senha:";
            // 
            // txtMatricula
            // 
            txtMatricula.BackColor = SystemColors.ScrollBar;
            txtMatricula.BorderStyle = BorderStyle.FixedSingle;
            txtMatricula.Enabled = false;
            txtMatricula.Location = new Point(180, 26);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(170, 27);
            txtMatricula.TabIndex = 1;
            // 
            // txtCodAdm
            // 
            txtCodAdm.Location = new Point(804, 150);
            txtCodAdm.Name = "txtCodAdm";
            txtCodAdm.Size = new Size(172, 27);
            txtCodAdm.TabIndex = 13;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(180, 72);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(170, 27);
            txtCargo.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(401, 277);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(207, 27);
            txtSenha.TabIndex = 23;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(64, 277);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(250, 27);
            txtLogin.TabIndex = 21;
            // 
            // tSalario
            // 
            tSalario.BackColor = SystemColors.ScrollBar;
            tSalario.BorderStyle = BorderStyle.FixedSingle;
            tSalario.Enabled = false;
            tSalario.Location = new Point(365, 72);
            tSalario.Name = "tSalario";
            tSalario.Size = new Size(80, 27);
            tSalario.TabIndex = 4;
            tSalario.Text = "Salario:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(804, 201);
            txtCpf.Mask = "000,000,000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(172, 27);
            txtCpf.TabIndex = 17;
            txtCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            // 
            // txtTele
            // 
            txtTele.Location = new Point(804, 231);
            txtTele.Mask = "(99) 00000-0000";
            txtTele.Name = "txtTele";
            txtTele.Size = new Size(172, 27);
            txtTele.TabIndex = 19;
            // 
            // txtNasc
            // 
            txtNasc.Location = new Point(804, 120);
            txtNasc.Mask = "00/00/0000";
            txtNasc.Name = "txtNasc";
            txtNasc.Size = new Size(172, 27);
            txtNasc.TabIndex = 11;
            txtNasc.ValidatingType = typeof(DateTime);
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(451, 72);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(157, 27);
            txtSalario.TabIndex = 5;
            // 
            // grupoGerenFuncionario
            // 
            grupoGerenFuncionario.Controls.Add(txtSalario);
            grupoGerenFuncionario.Controls.Add(txtNasc);
            grupoGerenFuncionario.Controls.Add(txtStatus);
            grupoGerenFuncionario.Controls.Add(txtTele);
            grupoGerenFuncionario.Controls.Add(tSenha);
            grupoGerenFuncionario.Controls.Add(txtCpf);
            grupoGerenFuncionario.Controls.Add(btnLimparFunc);
            grupoGerenFuncionario.Controls.Add(tSalario);
            grupoGerenFuncionario.Controls.Add(tTele);
            grupoGerenFuncionario.Controls.Add(txtLogin);
            grupoGerenFuncionario.Controls.Add(tCadProd);
            grupoGerenFuncionario.Controls.Add(txtSenha);
            grupoGerenFuncionario.Controls.Add(tMatricula);
            grupoGerenFuncionario.Controls.Add(txtCargo);
            grupoGerenFuncionario.Controls.Add(tStatus);
            grupoGerenFuncionario.Controls.Add(txtCodAdm);
            grupoGerenFuncionario.Controls.Add(tCodAdm);
            grupoGerenFuncionario.Controls.Add(txtMatricula);
            grupoGerenFuncionario.Controls.Add(txtEndereco);
            grupoGerenFuncionario.Controls.Add(tCpf);
            grupoGerenFuncionario.Controls.Add(tEndereco);
            grupoGerenFuncionario.Controls.Add(tLogin);
            grupoGerenFuncionario.Controls.Add(tNomeFunc);
            grupoGerenFuncionario.Controls.Add(tNasc);
            grupoGerenFuncionario.Controls.Add(btnAlterarFunc);
            grupoGerenFuncionario.Controls.Add(tCargo);
            grupoGerenFuncionario.Controls.Add(btnGravarFunc);
            grupoGerenFuncionario.Controls.Add(txtNomeFunc);
            grupoGerenFuncionario.Location = new Point(300, 12);
            grupoGerenFuncionario.Name = "grupoGerenFuncionario";
            grupoGerenFuncionario.Size = new Size(976, 315);
            grupoGerenFuncionario.TabIndex = 7;
            grupoGerenFuncionario.TabStop = false;
            // 
            // txtStatus
            // 
            txtStatus.FormattingEnabled = true;
            txtStatus.Location = new Point(804, 71);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(172, 28);
            txtStatus.TabIndex = 7;
            // 
            // btnBuscarFunc
            // 
            btnBuscarFunc.BackColor = Color.FromArgb(75, 107, 36);
            btnBuscarFunc.FlatAppearance.BorderColor = Color.FromArgb(75, 107, 36);
            btnBuscarFunc.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarFunc.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 107, 36);
            btnBuscarFunc.FlatStyle = FlatStyle.Popup;
            btnBuscarFunc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBuscarFunc.ForeColor = SystemColors.Control;
            btnBuscarFunc.Location = new Point(631, 347);
            btnBuscarFunc.Name = "btnBuscarFunc";
            btnBuscarFunc.Size = new Size(64, 27);
            btnBuscarFunc.TabIndex = 9;
            btnBuscarFunc.Text = "Buscar";
            btnBuscarFunc.UseVisualStyleBackColor = false;
            btnBuscarFunc.Click += btnBuscarFunc_Click;
            // 
            // txtBuscarFunc
            // 
            txtBuscarFunc.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarFunc.CharacterCasing = CharacterCasing.Lower;
            txtBuscarFunc.ForeColor = Color.Gray;
            txtBuscarFunc.Location = new Point(300, 347);
            txtBuscarFunc.Name = "txtBuscarFunc";
            txtBuscarFunc.RightToLeft = RightToLeft.No;
            txtBuscarFunc.Size = new Size(314, 27);
            txtBuscarFunc.TabIndex = 8;
            txtBuscarFunc.Text = "inserir a matricula do funcionario...";
            txtBuscarFunc.Enter += txtBuscarFunc_Enter;
            txtBuscarFunc.Leave += txtBuscarFunc_Leave;
            // 
            // tlistaFunc
            // 
            tlistaFunc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlistaFunc.AutoSize = true;
            tlistaFunc.Enabled = false;
            tlistaFunc.Font = new Font("Segoe UI", 10F);
            tlistaFunc.Location = new Point(1107, 351);
            tlistaFunc.Name = "tlistaFunc";
            tlistaFunc.Size = new Size(169, 23);
            tlistaFunc.TabIndex = 165;
            tlistaFunc.Text = "Lista de Funcionarios\r\n";
            // 
            // TelaRH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(tlistaFunc);
            Controls.Add(btnBuscarFunc);
            Controls.Add(txtBuscarFunc);
            Controls.Add(btnAtualizarFunc);
            Controls.Add(btnExcluirFunc);
            Controls.Add(listFuncionario);
            Controls.Add(btnTelaRH);
            Controls.Add(btnTelaProduto);
            Controls.Add(btnTelaProducao);
            Controls.Add(btnSairTela);
            Controls.Add(btnForne);
            Controls.Add(btnTelaPlantio);
            Controls.Add(logo2);
            Controls.Add(retcor2);
            Controls.Add(grupoGerenFuncionario);
            Name = "TelaRH";
            Text = "TelaRH";
            Load += TelaRH_Load;
            ((System.ComponentModel.ISupportInitialize)logo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)listFuncionario).EndInit();
            grupoGerenFuncionario.ResumeLayout(false);
            grupoGerenFuncionario.PerformLayout();
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
        private TextBox txtNomeFunc;
        private Button btnGravarFunc;
        private Button btnAtualizarFunc;
        private Button btnAlterarFunc;
        private Button btnLimparFunc;
        private Button btnExcluirFunc;
        private Label tNomeFunc;
        private Label tEndereco;
        private TextBox txtEndereco;
        private Label tCodAdm;
        private Label tTele;
        private Label tStatus;
        private Label tMatricula;
        private Label tCadProd;
        private DataGridView listFuncionario;
        private Label tCargo;
        private Label tNasc;
        private Label tLogin;
        private Label tCpf;
        private Label tSenha;
        private Label txtMatricula;
        private TextBox txtCodAdm;
        private TextBox txtCargo;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label tSalario;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtTele;
        private MaskedTextBox txtNasc;
        private MaskedTextBox txtSalario;
        private GroupBox grupoGerenFuncionario;
        private ComboBox txtStatus;
        private Button btnBuscarFunc;
        private TextBox txtBuscarFunc;
        private Label tlistaFunc;
    }
}