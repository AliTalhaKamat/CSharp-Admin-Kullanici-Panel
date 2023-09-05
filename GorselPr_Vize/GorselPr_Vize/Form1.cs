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
    public partial class Frm_giris : Form
    {
        public Frm_giris()
        {
            InitializeComponent();
        }

        private void Frm_giris_Load(object sender, EventArgs e)
        {

        }

        private void Btn_giris_Click(object sender, EventArgs e)
        {
            

            if (TextAd.Text=="admin")
            {
                string xmldosyaAdmin = @"admin.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(xmldosyaAdmin);

                foreach (XmlNode node in doc.SelectNodes("//admin"))
                {
                string username = node.SelectSingleNode("adminname").InnerText;
                string pword = node.SelectSingleNode("password").InnerText;

                     if (username==TextAd.Text && pword==TextSifre.Text)
                     {
                             Frm_admin f2 = new Frm_admin();
                                f2.Show();  
                     }
                    else
                    {
                        MessageBox.Show("Şifre veya kullanıcı adı hatalı olabilir!!");
                    }
                }
            }
            else
            {
                string xmldosyaAdmin = @"users.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(xmldosyaAdmin);

                foreach (XmlNode node in doc.SelectNodes("//user"))
                {
                    string username = node.SelectSingleNode("username").InnerText;
                    string pword = node.SelectSingleNode("password").InnerText;

                    if (username == TextAd.Text && pword == TextSifre.Text)
                    {
                        Frm_kullanici f3 = new Frm_kullanici();
                        f3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifre veya Kullanıcı adı hatalı olabilir!!");
                        
                    }
                }
            }

           
        }
    }
}
