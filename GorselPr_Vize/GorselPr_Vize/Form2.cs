using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselPr_Vize
{
    public partial class Frm_admin : Form
    {
        public Frm_admin()
        {
            InitializeComponent();
        }

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {
            Frm_fiyat f4 = new Frm_fiyat();
            f4.Show();
        }

        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            Frm_users f5 = new Frm_users();
            f5.Show();
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            FrmKullaniciSil fsil = new FrmKullaniciSil();
            fsil.Show();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
