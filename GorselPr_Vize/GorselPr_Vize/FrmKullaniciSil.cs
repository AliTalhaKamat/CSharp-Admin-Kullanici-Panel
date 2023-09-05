using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace GorselPr_Vize
{
    public partial class FrmKullaniciSil : Form
    {
        public FrmKullaniciSil()
        {
            InitializeComponent();
        }

        string path = Application.StartupPath + @"/users.xml";

        void yukle()
        {
            XDocument myxml = XDocument.Load(path);
            var users = from user in myxml.Descendants("user")
                        select user.Element("username").Value;

            foreach (var veri in users)
                comboUsers.Items.Add(veri.ToString());
        }



        private void FrmKullaniciSil_Load(object sender, EventArgs e)
        {

            yukle();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (comboUsers.SelectedIndex== -1)
            {
                MessageBox.Show("Kullanıcı seçimi yapmadınız veya eklenmiş kullanıcı yok");
            }
            else
            {
                XDocument myxml = XDocument.Load(path);
                var kullanicilar = (from kullanici in myxml.Descendants("user")
                                    where
                                    kullanici.Element("username").Value == comboUsers.SelectedItem.ToString()
                                    select kullanici).SingleOrDefault();
                kullanicilar.Remove();
                myxml.Save(path);
                MessageBox.Show("Kullanıcı Silme Başarılı");
                yukle();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
