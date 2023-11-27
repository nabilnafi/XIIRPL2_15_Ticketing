using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIIRPL2_15_Ticketing.MasterForm;


namespace XIIRPL2_15_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //FrmLogin FrmLogin = new FrmLogin();
            //FrmLogin.Show();
            FrmMasterJadwalPenerbangan jadwal_penerbangan= new FrmMasterJadwalPenerbangan();
            jadwal_penerbangan.Show();
            Application.Run();
        }
    }
}