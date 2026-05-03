using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Otob_sBilet.R.S.UserControls
{
    public partial class KoltukSecimiControl : UserControl
    {
        private readonly List<Button> _koltuklar = new List<Button>();
        private int? seciliKoltuk = null;
        private Sefer _sefer;

        public event EventHandler<int> RezervasyonOnaylandi; // Koltuk numarasi ile

        public KoltukSecimiControl(Sefer sefer)
        {
            InitializeComponent();
            _sefer = sefer;
            OlusturKoltuklar();
        }

        private void OlusturKoltuklar()
        {
            int startX = 30, startY = 30, btnW = 40, btnH = 40, gap = 10;
            int columns = 10;
            int toplamKoltuk = _sefer?.Otobus?.Koltuklar?.Length ?? 30;

            for (int index = 0; index < toplamKoltuk; index++)
            {
                int row = index / columns;
                int col = index % columns;
                int koltukNo = index + 1;
                var btn = new Button();
                btn.Width = btnW;
                btn.Height = btnH;
                btn.Left = startX + col * (btnW + gap);
                btn.Top = startY + row * (btnH + gap);
                btn.Text = koltukNo.ToString();
                btn.Tag = koltukNo;

                bool doluMu = _sefer?.Otobus?.Koltuklar?[koltukNo - 1].DoluMu ?? false;
                btn.BackColor = doluMu ? Color.IndianRed : Color.LightGreen;
                btn.Enabled = !doluMu;

                btn.Click += Koltuk_Click;
                Controls.Add(btn);
                _koltuklar.Add(btn);
            }
        }

        private void Koltuk_Click(object sender, EventArgs e)
        {
            foreach (var btn in _koltuklar)
                if (btn.BackColor == Color.Gold)
                    btn.BackColor = Color.LightGreen;

            var clicked = sender as Button;
            clicked.BackColor = Color.Gold;
            seciliKoltuk = (int)clicked.Tag;
            lblSeciliKoltuk.Text = $"Secili Koltuk: {seciliKoltuk}";
        }

        private void btnRezerveEt_Click(object sender, EventArgs e)
        {
            if (seciliKoltuk == null)
            {
                MessageBox.Show("Lutfen bir koltuk secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_sefer == null)
            {
                MessageBox.Show("Sefer bilgisi bulunamadi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_sefer.RezervasyonYap(seciliKoltuk.Value))
            {
                MessageBox.Show("Koltuk rezerve edilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var btn in _koltuklar)
            {
                if ((int)btn.Tag == seciliKoltuk)
                {
                    btn.BackColor = Color.IndianRed; // Dolu
                    btn.Enabled = false;
                }
            }
            RezervasyonOnaylandi?.Invoke(this, seciliKoltuk.Value);

            MessageBox.Show($"Koltuk {seciliKoltuk} secildi, onaylandi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            seciliKoltuk = null;
            lblSeciliKoltuk.Text = "Secili Koltuk: -";
        }
    }
}
