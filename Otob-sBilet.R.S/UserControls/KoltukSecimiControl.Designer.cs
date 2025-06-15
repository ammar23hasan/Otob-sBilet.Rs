namespace Otob_sBilet.R.S.UserControls
{
    partial class KoltukSecimiControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSeciliKoltuk;
        private System.Windows.Forms.Button btnRezerveEt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSeciliKoltuk = new System.Windows.Forms.Label();
            this.btnRezerveEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeciliKoltuk
            // 
            this.lblSeciliKoltuk.AutoSize = true;
            this.lblSeciliKoltuk.Location = new System.Drawing.Point(30, 220);
            this.lblSeciliKoltuk.Name = "lblSeciliKoltuk";
            this.lblSeciliKoltuk.Size = new System.Drawing.Size(120, 20);
            this.lblSeciliKoltuk.Text = "Seçili Koltuk: -";
            // 
            // btnRezerveEt
            // 
            this.btnRezerveEt.Location = new System.Drawing.Point(30, 240);
            this.btnRezerveEt.Name = "btnRezerveEt";
            this.btnRezerveEt.Size = new System.Drawing.Size(120, 35);
            this.btnRezerveEt.Text = "Rezerve Et";
            this.btnRezerveEt.UseVisualStyleBackColor = true;
            this.btnRezerveEt.Click += new System.EventHandler(this.btnRezerveEt_Click);
            // 
            // KoltukSecimiControl
            // 
            this.Controls.Add(this.lblSeciliKoltuk);
            this.Controls.Add(this.btnRezerveEt);
            this.Name = "KoltukSecimiControl";
            this.Size = new System.Drawing.Size(600, 300);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
