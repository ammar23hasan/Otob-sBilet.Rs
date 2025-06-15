using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otob_sBilet.R.S
{
    public class Otobus
    {
        public Koltuk[] Koltuklar { get; set; }

        public Otobus(int koltukSayisi)
        {
            Koltuklar = new Koltuk[koltukSayisi];
            for (int i = 0; i < koltukSayisi; i++)
            {
                Koltuklar[i] = new Koltuk(i + 1);
            }
        }

        public void KoltuklariGoster()
        {
            Console.WriteLine("Koltuklar:");
            for (int i = 0; i < Koltuklar.Length; i++)
            {
                Console.ForegroundColor = Koltuklar[i].DoluMu ? ConsoleColor.Red : ConsoleColor.Green;
                Console.Write($"[{Koltuklar[i].Numara}] ");
                if ((i + 1) % 2 == 0) Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
