namespace Otob_sBilet.R.S.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel leftMenuPanel;
        private Button btnSeferOlustur;
        private Button btnKoltukSecimi;
        private Button btnBiletYazdir;
        private Button btnAyarlar;
        private Button btnCikis;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            leftMenuPanel = new Panel();
            btnCikis = new Button();
            btnAyarlar = new Button();
            btnBiletYazdir = new Button();
            btnKoltukSecimi = new Button();
            btnSeferOlustur = new Button();
            mainContentPanel = new Panel();
            leftMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftMenuPanel
            // 
            leftMenuPanel.BackColor = Color.MidnightBlue;
            leftMenuPanel.Controls.Add(btnCikis);
            leftMenuPanel.Controls.Add(btnAyarlar);
            leftMenuPanel.Controls.Add(btnBiletYazdir);
            leftMenuPanel.Controls.Add(btnKoltukSecimi);
            leftMenuPanel.Controls.Add(btnSeferOlustur);
            leftMenuPanel.Dock = DockStyle.Left;
            leftMenuPanel.Location = new Point(0, 0);
            leftMenuPanel.Name = "leftMenuPanel";
            leftMenuPanel.Size = new Size(180, 600);
            leftMenuPanel.TabIndex = 0;
            // 
            // btnCikis
            // 
            btnCikis.Dock = DockStyle.Bottom;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.ForeColor = Color.White;
            btnCikis.Location = new Point(0, 550);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(180, 50);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "❌ Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.Dock = DockStyle.Top;
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.ForeColor = Color.White;
            btnAyarlar.Location = new Point(0, 150);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(180, 50);
            btnAyarlar.TabIndex = 3;
            btnAyarlar.Text = "⚙️ Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = true;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // btnBiletYazdir
            // 
            btnBiletYazdir.Dock = DockStyle.Top;
            btnBiletYazdir.FlatStyle = FlatStyle.Flat;
            btnBiletYazdir.ForeColor = Color.White;
            btnBiletYazdir.Location = new Point(0, 100);
            btnBiletYazdir.Name = "btnBiletYazdir";
            btnBiletYazdir.Size = new Size(180, 50);
            btnBiletYazdir.TabIndex = 2;
            btnBiletYazdir.Text = "\U0001f9fe Bilet Yazdır";
            btnBiletYazdir.UseVisualStyleBackColor = true;
            btnBiletYazdir.Click += btnBiletYazdir_Click;
            // 
            // btnKoltukSecimi
            // 
            btnKoltukSecimi.Dock = DockStyle.Top;
            btnKoltukSecimi.FlatStyle = FlatStyle.Flat;
            btnKoltukSecimi.ForeColor = Color.White;
            btnKoltukSecimi.Location = new Point(0, 50);
            btnKoltukSecimi.Name = "btnKoltukSecimi";
            btnKoltukSecimi.Size = new Size(180, 50);
            btnKoltukSecimi.TabIndex = 1;
            btnKoltukSecimi.Text = "💺 Koltuk Seçimi";
            btnKoltukSecimi.UseVisualStyleBackColor = true;
            btnKoltukSecimi.Click += btnKoltukSecimi_Click;
            // 
            // btnSeferOlustur
            // 
            btnSeferOlustur.Dock = DockStyle.Top;
            btnSeferOlustur.FlatStyle = FlatStyle.Flat;
            btnSeferOlustur.ForeColor = Color.White;
            btnSeferOlustur.Location = new Point(0, 0);
            btnSeferOlustur.Name = "btnSeferOlustur";
            btnSeferOlustur.Size = new Size(180, 50);
            btnSeferOlustur.TabIndex = 0;
            btnSeferOlustur.Text = "🚌 Sefer Oluştur";
            btnSeferOlustur.UseVisualStyleBackColor = true;
            btnSeferOlustur.Click += btnSeferOlustur_Click;
            // 
            // mainContentPanel
            // 
            mainContentPanel.Location = new Point(186, 0);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(820, 600);
            mainContentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 600);
            Controls.Add(mainContentPanel);
            Controls.Add(leftMenuPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Otobüs Bilet Rezervasyon Sistemi";
            leftMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Panel mainContentPanel;
    }
}
