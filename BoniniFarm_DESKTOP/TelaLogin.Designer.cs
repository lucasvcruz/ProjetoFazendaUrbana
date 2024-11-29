namespace BoniniFarm2
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tEmail = new Label();
            tSenha = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            btnEntrarConta = new Button();
            pictureBox1 = new PictureBox();
            tEfetuarLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tEmail
            // 
            tEmail.AutoSize = true;
            tEmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tEmail.Location = new Point(531, 413);
            tEmail.Name = "tEmail";
            tEmail.Size = new Size(54, 18);
            tEmail.TabIndex = 1;
            tEmail.Text = "Email:";
            // 
            // tSenha
            // 
            tSenha.AutoSize = true;
            tSenha.Location = new Point(531, 490);
            tSenha.Name = "tSenha";
            tSenha.Size = new Size(52, 20);
            tSenha.TabIndex = 3;
            tSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightGray;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(531, 434);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(277, 26);
            txtEmail.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.LightGray;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(531, 513);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(277, 26);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrarConta
            // 
            btnEntrarConta.BackColor = Color.Green;
            btnEntrarConta.FlatStyle = FlatStyle.Flat;
            btnEntrarConta.ForeColor = SystemColors.Control;
            btnEntrarConta.Location = new Point(531, 562);
            btnEntrarConta.Name = "btnEntrarConta";
            btnEntrarConta.Size = new Size(277, 29);
            btnEntrarConta.TabIndex = 5;
            btnEntrarConta.Text = "Entrar";
            btnEntrarConta.UseVisualStyleBackColor = false;
            btnEntrarConta.Click += btnEntrarConta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(434, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 209);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // tEfetuarLogin
            // 
            tEfetuarLogin.Font = new Font("Lucida Sans", 12.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tEfetuarLogin.Location = new Point(434, 347);
            tEfetuarLogin.Name = "tEfetuarLogin";
            tEfetuarLogin.Size = new Size(456, 49);
            tEfetuarLogin.TabIndex = 0;
            tEfetuarLogin.Text = "EFETUAR LOGIN";
            tEfetuarLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 247);
            ClientSize = new Size(1348, 721);
            Controls.Add(tEfetuarLogin);
            Controls.Add(pictureBox1);
            Controls.Add(btnEntrarConta);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(tSenha);
            Controls.Add(tEmail);
            Name = "TelaLogin";
            Text = "TelaLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tEmail;
        private Label tSenha;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Button btnEntrarConta;
        private PictureBox pictureBox1;
        private Label tEfetuarLogin;
    }
}
