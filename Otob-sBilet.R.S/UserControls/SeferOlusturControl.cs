using System;
using System.Linq;
using System.Windows.Forms;

namespace Otob_sBilet.R.S.UserControls
{
    public partial class SeferOlusturControl : UserControl
    {
        private DateTimePicker dtpTarih;

        public SeferOlusturControl()
        {
            InitializeComponent();

            // DateTimePicker oluşturuluyor
            dtpTarih = new DateTimePicker();
            dtpTarih.Format = DateTimePickerFormat.Custom;
            dtpTarih.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpTarih.Value = DateTime.Now;
            dtpTarih.Width = 200;
            dtpTarih.Location = new System.Drawing.Point(180, 120); // İstediğin konuma göre değiştir
            this.Controls.Add(dtpTarih);
        }

        public event EventHandler<Sefer> SeferOlusturuldu;

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string nereden = txtNereden.Text;
            string nereye = txtNereye.Text;
            DateTime seferTarihi = dtpTarih.Value;

            if (string.IsNullOrWhiteSpace(nereden) || string.IsNullOrWhiteSpace(nereye))
            {
                MessageBox.Show("Nereden ve nereye alanlarini doldurun.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboBox cmbSeferTipi = this.Controls.Find("cmbSeferTuru", true).FirstOrDefault() as ComboBox;
            if (cmbSeferTipi == null)
            {
                MessageBox.Show("Sefer tipi secimi icin bir ComboBox bulunamadi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tip = cmbSeferTipi.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(tip))
            {
                MessageBox.Show("Sefer turunu secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Sefer yeniSefer;
            if (tip == "Sehirici")
                yeniSefer = new SehiriciSefer(nereden, nereye, seferTarihi);
            else
                yeniSefer = new SehirlerarasiSefer(nereden, nereye, seferTarihi);

            SeferOlusturuldu?.Invoke(this, yeniSefer);
            MessageBox.Show("Sefer olusturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            btnOlustur_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}