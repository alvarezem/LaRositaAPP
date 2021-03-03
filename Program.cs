using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaRositaAPP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Presentacion.Mesas_salones.frmConfigurar_mesas_ok frm = new Presentacion.Mesas_salones.frmConfigurar_mesas_ok();
            frm.FormClosed += frm_closed;
            frm.ShowDialog();
            Application.Run();
        }
        private static void frm_closed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
