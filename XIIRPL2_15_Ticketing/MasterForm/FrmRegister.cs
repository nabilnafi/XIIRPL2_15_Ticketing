using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIIRPL2_15_Ticketing.Properties.MasterForm
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
