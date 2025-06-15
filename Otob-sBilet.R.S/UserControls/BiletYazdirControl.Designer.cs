namespace Otob_sBilet.R.S.UserControls
{
    partial class BiletYazdirControl
    {
        private System.ComponentModel.IContainer components = null;
        // ...existing code...
        private System.Windows.Forms.Label lblSeferBilgi;
        private System.Windows.Forms.Label lblKoltukBilgi;
        private System.Windows.Forms.Button btnPdfKaydet;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label lblTarihBilgi; // yeni label

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSeferBilgi = new Label();
            lblKoltukBilgi = new Label();
            btnPdfKaydet = new Button();
            btnYazdir = new Button();
            lblTarihBilgi = new Label();
            SuspendLayout();
            // 
            // lblSeferBilgi
            // 
            lblSeferBilgi.AutoSize = true;
            lblSeferBilgi.Location = new Point(40, 40);
            lblSeferBilgi.Name = "lblSeferBilgi";
            lblSeferBilgi.Size = new Size(163, 20);
            lblSeferBilgi.TabIndex = 0;
            lblSeferBilgi.Text = "Sefer: [Kalkýþ] -> [Varýþ]";
            // 
            // lblKoltukBilgi
            // 
            lblKoltukBilgi.AutoSize = true;
            lblKoltukBilgi.Location = new Point(40, 80);
            lblKoltukBilgi.Name = "lblKoltukBilgi";
            lblKoltukBilgi.Size = new Size(112, 20);
            lblKoltukBilgi.TabIndex = 1;
            lblKoltukBilgi.Text = "Koltuk No: [No]";
            // 
            // btnPdfKaydet
            // 
            btnPdfKaydet.Location = new Point(40, 143);
            btnPdfKaydet.Name = "btnPdfKaydet";
            btnPdfKaydet.Size = new Size(150, 35);
            btnPdfKaydet.TabIndex = 3;
            btnPdfKaydet.Text = "PDF Olarak Kaydet";
            btnPdfKaydet.UseVisualStyleBackColor = true;
            btnPdfKaydet.Click += btnPdfKaydet_Click;
            // 
            // btnYazdir
            // 
            btnYazdir.Location = new Point(210, 143);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(120, 35);
            btnYazdir.TabIndex = 4;
            btnYazdir.Text = "Yazdýr";
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // lblTarihBilgi
            // 
            lblTarihBilgi.AutoSize = true;
            lblTarihBilgi.Location = new Point(40, 110);
            lblTarihBilgi.Name = "lblTarihBilgi";
            lblTarihBilgi.Size = new Size(88, 20);
            lblTarihBilgi.TabIndex = 2;
            lblTarihBilgi.Text = "Tarih: [Tarih]";
            // 
            // BiletYazdirControl
            // 
            Controls.Add(lblSeferBilgi);
            Controls.Add(lblKoltukBilgi);
            Controls.Add(lblTarihBilgi);
            Controls.Add(btnPdfKaydet);
            Controls.Add(btnYazdir);
            Name = "BiletYazdirControl";
            Size = new Size(600, 200);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
