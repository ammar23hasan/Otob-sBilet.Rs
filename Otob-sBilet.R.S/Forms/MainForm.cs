using System;
using System.Windows.Forms;
using Otob_sBilet.R.S.UserControls;

namespace Otob_sBilet.R.S.Forms
{
    public partial class MainForm : Form
    {
        private SeferOlusturControl seferOlusturControl;
        private KoltukSecimiControl koltukSecimiControl;
        private BiletYazdirControl biletYazdirControl;

        private Sefer _olusturulanSefer;
        private int? _seciliKoltukNo;

        public MainForm()
        {
            InitializeComponent();
            LoadSeferOlustur();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SeferOlusturControl_SeferOlusturuldu(object sender, Sefer sefer)
        {

            _olusturulanSefer = sefer;
            LoadKoltukSecimi(sefer);
        }

        private void KoltukSecimiControl_RezervasyonOnaylandi(object sender, int koltukNo)
        {
            _seciliKoltukNo = koltukNo;
            _olusturulanSefer.RezervasyonYap(koltukNo);
            LoadBiletYazdir(_olusturulanSefer, koltukNo);
        }

        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            LoadSeferOlustur();
        }

        private void btnKoltukSecimi_Click(object sender, EventArgs e)
        {
            LoadKoltukSecimi(_olusturulanSefer);
        }

        private void btnBiletYazdir_Click(object sender, EventArgs e)
        {
            if (_olusturulanSefer != null && _seciliKoltukNo.HasValue)
            {
                LoadBiletYazdir(_olusturulanSefer, _seciliKoltukNo.Value);
            }
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            LoadAyarlar();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadSeferOlustur()
        {
            mainContentPanel.Controls.Clear();
            var control = new SeferOlusturControl();
            control.Dock = DockStyle.Fill;
            control.SeferOlusturuldu += SeferOlusturControl_SeferOlusturuldu;
            mainContentPanel.Controls.Add(control);
        }

        private void LoadKoltukSecimi(Sefer sefer)
        {
            mainContentPanel.Controls.Clear();
            var control = new KoltukSecimiControl(sefer);
            control.Dock = DockStyle.Fill;
            control.RezervasyonOnaylandi += KoltukSecimiControl_RezervasyonOnaylandi;
            mainContentPanel.Controls.Add(control);
        }

        private void LoadBiletYazdir(Sefer sefer, int koltukNo)
        {
            mainContentPanel.Controls.Clear();
            var control = new BiletYazdirControl(sefer, koltukNo);
            control.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(control);
        }

        private void LoadAyarlar()
        {
            mainContentPanel.Controls.Clear();
            var control = new AyarlarControl();
            control.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(control);
        }
    }
}
