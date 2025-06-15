namespace Otob_sBilet.R.S.UserControls
{
    partial class SeferOlusturControl
    {
        private System.ComponentModel.IContainer components = null;
        // ...existing code...

        // No changes needed here, as only one DateTimePicker (dtpTarihSaat) is declared and added.
        // Ensure that only 'dtpTarihSaat' is present and no other DateTimePicker is declared or added.

        // ...existing code...
        private System.Windows.Forms.TextBox txtNereden;
        private System.Windows.Forms.TextBox txtNereye;
        private System.Windows.Forms.ComboBox cmbSeferTuru;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label lblNereden;
        private System.Windows.Forms.Label lblNereye;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Label lblSeferTuru;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNereden = new Label();
            lblNereye = new Label();
            lblTarihSaat = new Label();
            lblSeferTuru = new Label();
            txtNereden = new TextBox();
            txtNereye = new TextBox();
            cmbSeferTuru = new ComboBox();
            btnOlustur = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNereden
            // 
            lblNereden.AutoSize = true;
            lblNereden.Location = new Point(40, 40);
            lblNereden.Name = "lblNereden";
            lblNereden.Size = new Size(104, 20);
            lblNereden.TabIndex = 0;
            lblNereden.Text = "Kalkýþ Noktasý:";
            // 
            // lblNereye
            // 
            lblNereye.AutoSize = true;
            lblNereye.Location = new Point(40, 80);
            lblNereye.Name = "lblNereye";
            lblNereye.Size = new Size(97, 20);
            lblNereye.TabIndex = 2;
            lblNereye.Text = "Varýþ Noktasý:";
            // 
            // lblTarihSaat
            // 
            lblTarihSaat.AutoSize = true;
            lblTarihSaat.Location = new Point(40, 120);
            lblTarihSaat.Name = "lblTarihSaat";
            lblTarihSaat.Size = new Size(95, 20);
            lblTarihSaat.TabIndex = 4;
            lblTarihSaat.Text = "Tarih ve Saat:";
            // 
            // lblSeferTuru
            // 
            lblSeferTuru.AutoSize = true;
            lblSeferTuru.Location = new Point(40, 160);
            lblSeferTuru.Name = "lblSeferTuru";
            lblSeferTuru.Size = new Size(79, 20);
            lblSeferTuru.TabIndex = 6;
            lblSeferTuru.Text = "Sefer Türü:";
            // 
            // txtNereden
            // 
            txtNereden.Location = new Point(180, 37);
            txtNereden.Name = "txtNereden";
            txtNereden.Size = new Size(200, 27);
            txtNereden.TabIndex = 1;
            // 
            // txtNereye
            // 
            txtNereye.Location = new Point(180, 77);
            txtNereye.Name = "txtNereye";
            txtNereye.Size = new Size(200, 27);
            txtNereye.TabIndex = 3;
            // 
            // cmbSeferTuru
            // 
            cmbSeferTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeferTuru.Items.AddRange(new object[] { "Þehirlerarasý", "Þehiriçi" });
            cmbSeferTuru.Location = new Point(180, 157);
            cmbSeferTuru.Name = "cmbSeferTuru";
            cmbSeferTuru.Size = new Size(200, 28);
            cmbSeferTuru.TabIndex = 7;
            // 
            // btnOlustur
            // 
            btnOlustur.Location = new Point(180, 210);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(120, 35);
            btnOlustur.TabIndex = 8;
            btnOlustur.Text = "Oluþtur";
            btnOlustur.UseVisualStyleBackColor = true;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.logo_bus_icon_school_vector_600nw_2381986327_removebg_preview;
            pictureBox1.Location = new Point(327, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(457, 404);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SeferOlusturControl
            // 
            Controls.Add(pictureBox1);
            Controls.Add(lblNereden);
            Controls.Add(txtNereden);
            Controls.Add(lblNereye);
            Controls.Add(txtNereye);
            Controls.Add(lblTarihSaat);
            Controls.Add(lblSeferTuru);
            Controls.Add(cmbSeferTuru);
            Controls.Add(btnOlustur);
            Name = "SeferOlusturControl";
            Size = new Size(784, 608);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
