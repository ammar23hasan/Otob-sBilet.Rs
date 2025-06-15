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

            ComboBox cmbSeferTipi = this.Controls.Find("cmbSeferTuru", true).FirstOrDefault() as ComboBox;
            if (cmbSeferTipi == null)
            {
                MessageBox.Show("Sefer tipi seçimi için bir ComboBox bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tip = cmbSeferTipi.SelectedItem?.ToString();

            Sefer yeniSefer;
            if (tip == "Şehiriçi")
                yeniSefer = new SehiriciSefer(nereden, nereye, seferTarihi);
            else
                yeniSefer = new SehirlerarasiSefer(nereden, nereye, seferTarihi);

            SeferOlusturuldu?.Invoke(this, yeniSefer);
            MessageBox.Show("Sefer oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            string nereden = txtNereden.Text;
            string nereye = txtNereye.Text;
            DateTime seferTarihi = dtpTarih.Value;

            ComboBox cmbSeferTipi = this.Controls.Find("cmbSeferTipi", true).FirstOrDefault() as ComboBox;
            if (cmbSeferTipi == null)
            {
                MessageBox.Show("Sefer tipi seçimi için bir ComboBox bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tip = cmbSeferTipi.SelectedItem?.ToString();

            Sefer yeniSefer;
            if (tip == "Şehiriçi")
                yeniSefer = new SehiriciSefer(nereden, nereye, seferTarihi);
            else
                yeniSefer = new SehirlerarasiSefer(nereden, nereye, seferTarihi);

            SeferOlusturuldu?.Invoke(this, yeniSefer);
            MessageBox.Show("Sefer oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}