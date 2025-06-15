namespace Otob_sBilet.R.S.UserControls
{
    partial class AyarlarControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAyarlar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAyarlar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAyarlar
            // 
            this.lblAyarlar.AutoSize = true;
            this.lblAyarlar.Location = new System.Drawing.Point(40, 40);
            this.lblAyarlar.Name = "lblAyarlar";
            this.lblAyarlar.Size = new System.Drawing.Size(120, 20);
            this.lblAyarlar.Text = "Ayarlar Sayfasý";
            // 
            // AyarlarControl
            // 
            this.Controls.Add(this.lblAyarlar);
            this.Name = "AyarlarControl";
            this.Size = new System.Drawing.Size(600, 200);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
