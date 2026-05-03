using System;
using System.Windows.Forms;

namespace Otob_sBilet.R.S.UserControls
{
    public partial class BiletYazdirControl : UserControl
    {

        private IRezervasyon _rezervasyon;
        private Sefer _sefer;
        private int _koltukNo;

        public BiletYazdirControl()
        {
            InitializeComponent();
        }

        public BiletYazdirControl(IRezervasyon rezervasyon)
        {
            InitializeComponent();
            _rezervasyon = rezervasyon;
            // Bilet bilgilerini goster ve kaydet/yazdir islemlerini baslat
        }

        public BiletYazdirControl(Sefer sefer, int koltukNo)
        {
            InitializeComponent();
            _sefer = sefer;
            _koltukNo = koltukNo;
            // Bilet bilgilerini goster
            lblSeferBilgi.Text = $"Sefer: {_sefer.Nereden} -> {_sefer.Nereye}";
            lblKoltukBilgi.Text = $"Koltuk No: {_koltukNo}";
            lblTarihBilgi.Text = $"Tarih: {_sefer.Tarih:dd.MM.yyyy HH:mm}";
        }

        private void btnPdfKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PDF olarak kaydedildi (ornek).", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            // Guzel ve detayli bilet mesaji hazirla
            string mesaj = 
                "----- Bilet Bilgileri -----\n" +
                $"Sefer: {_sefer?.Nereden} -> {_sefer?.Nereye}\n" +
                $"Koltuk No: {_koltukNo}\n" +
                $"Tarih: {_sefer?.Tarih:dd.MM.yyyy HH:mm}\n" +
                "--------------------------\n" +
                "Iyi yolculuklar dileriz!";

            MessageBox.Show(mesaj, "Bilet Yazdir", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

}
