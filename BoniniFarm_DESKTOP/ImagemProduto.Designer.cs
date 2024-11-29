namespace BoniniFarm2
{
    partial class ImagemProduto
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
            imgProduto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgProduto).BeginInit();
            SuspendLayout();
            // 
            // imgProduto
            // 
            imgProduto.Location = new Point(12, 12);
            imgProduto.Name = "imgProduto";
            imgProduto.Size = new Size(500, 500);
            imgProduto.SizeMode = PictureBoxSizeMode.Zoom;
            imgProduto.BorderStyle = BorderStyle.FixedSingle;
            imgProduto.TabIndex = 0;
            imgProduto.TabStop = false;
            imgProduto.Cursor = Cursors.Hand;
            // 
            // ImagemProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 524);
            Controls.Add(imgProduto);
            Name = "ImagemProduto";
            Text = "ImagemProduto";
            ((System.ComponentModel.ISupportInitialize)imgProduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgProduto;
    }
}