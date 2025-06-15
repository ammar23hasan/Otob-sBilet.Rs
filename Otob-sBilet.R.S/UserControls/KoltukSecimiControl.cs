using System;
using System.Drawing;
using System.Windows.Forms;

namespace Otob_sBilet.R.S.UserControls
{
    public partial class KoltukSecimiControl : UserControl
    {
        private Button[,] koltuklar = new Button[4, 10];
        private int? seciliKoltuk = null;
        private Sefer _sefer;

        public event EventHandler<int> RezervasyonOnaylandi; // Koltuk numarasý ile

        public KoltukSecimiControl(Sefer sefer)
        {
            InitializeComponent();
            _sefer = sefer;
            OlusturKoltuklar();
        }

        private void OlusturKoltuklar()
        {
            int startX = 30, startY = 30, btnW = 40, btnH = 40, gap = 10;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var btn = new Button();
                    btn.Width = btnW;
                    btn.Height = btnH;
                    btn.Left = startX + j * (btnW + gap);
                    btn.Top = startY + i * (btnH + gap);
                    int koltukNo = i * 10 + j + 1;
                    btn.Text = koltukNo.ToString();
                    btn.BackColor = Color.LightGreen; // Boþ
                    btn.Tag = koltukNo;
                    btn.Click += Koltuk_Click;
                    this.Controls.Add(btn);
                    koltuklar[i, j] = btn;
                }
            }
        }

        private void Koltuk_Click(object sender, EventArgs e)
        {
            foreach (var btn in koltuklar)
                if (btn.BackColor == Color.Gold)
                    btn.BackColor = Color.LightGreen;

            var clicked = sender as Button;
            clicked.BackColor = Color.Gold;
            seciliKoltuk = (int)clicked.Tag;
            lblSeciliKoltuk.Text = $"Seçili Koltuk: {seciliKoltuk}";
        }

        private void btnRezerveEt_Click(object sender, EventArgs e)
        {
            if (seciliKoltuk == null)
            {
                MessageBox.Show("Lütfen bir koltuk seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Koltuk rezerve iþlemi UI'da gösteriliyor, asýl rezerve MainForm'da yapýlacak
            foreach (var btn in koltuklar)
            {
                if ((int)btn.Tag == seciliKoltuk)
                {
                    btn.BackColor = Color.IndianRed; // Dolu
                    btn.Enabled = false;
                }
            }
            RezervasyonOnaylandi?.Invoke(this, seciliKoltuk.Value);

            MessageBox.Show($"Koltuk {seciliKoltuk} seçildi, onaylandý.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seciliKoltuk = null;
            lblSeciliKoltuk.Text = "Seçili Koltuk: -";
        }
    }
}
