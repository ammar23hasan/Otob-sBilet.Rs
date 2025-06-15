using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otob_sBilet.R.S
{
//sefer modulu
    public abstract class Sefer : IRezervasyon
    {
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public Otobus Otobus { get; set; }

        public Sefer(string nereden, string nereye)
        {
            Nereden = nereden;
            Nereye = nereye;
            Otobus = new Otobus(30); 
        }

        // RezervasyonYap artık bool döndürür
        public virtual bool RezervasyonYap(int koltukNumarasi)
        {
            if (koltukNumarasi < 1 || koltukNumarasi > Otobus.Koltuklar.Length)
            {
                Console.WriteLine("Hatalı koltuk numarası!");
                return false;
            }

            var koltuk = Otobus.Koltuklar[koltukNumarasi - 1];
            if (koltuk.DoluMu)
            {
                Console.WriteLine("Bu koltuk zaten dolu!");
                return false;
            }
            else
            {
                koltuk.DoluMu = true;
                Console.WriteLine($"Koltuk {koltukNumarasi} başarıyla rezerve edildi.");
                return true;
            }
        }

        // Bilet Yazdırma
        public virtual void BiletYazdir(int koltukNumarasi)
        {
            Console.WriteLine("\n--- Bilet Bilgileri ---");
            Console.WriteLine($"Sefer: {Nereden} -> {Nereye}");
            Console.WriteLine($"Koltuk No: {koltukNumarasi}");
            Console.WriteLine($"Tarih: {DateTime.Now:dd.MM.yyyy HH:mm}");
            Console.WriteLine("----------------------\n");
        }

        void IRezervasyon.RezervasyonYap(int koltukNumarasi)
        {
            throw new NotImplementedException();
        }
    }
}
