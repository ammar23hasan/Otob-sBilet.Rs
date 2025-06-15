using Otob_sBilet.R.S;
using Otob_sBilet.R.S.Forms;
using System.Diagnostics.Metrics;

namespace Otob_sBilet.R.S
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Replace ApplicationConfiguration.Initialize() with this
            Application.SetCompatibleTextRenderingDefault(false); // Add this line for compatibility
            Application.Run(new MainForm());
        }
    }
}