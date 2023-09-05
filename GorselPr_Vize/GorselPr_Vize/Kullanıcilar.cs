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
    public partial class Frm_users : Form
    {
        public Frm_users()
        {
            InitializeComponent();
        }

        int i = 0;
        string path = Application.StartupPath + @"/users.xml";
        XmlDocument xdoc = new XmlDocument();

        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            if (TextAd.Text == ""|| TextSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez..!", "Hata!");

                return;
            }
            else { 
            string xmldosyaAdmin = @"users.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(xmldosyaAdmin);
            foreach (XmlNode node in doc.SelectNodes("//user"))
            {
                string username = node.SelectSingleNode("username").InnerText;
                string pword = node.SelectSingleNode("password").InnerText;

                if (username == TextAd.Text)
                {
                    i++;
                    
                }
                else
                {
                    i = 0;
                }
            }

            if (i>0)
            {
                MessageBox.Show("BU KULLANICI ZATEN MEVCUT!! BAŞKA KULLANICI ADI DENEYİN....");
            }

            else
            {
                XDocument xdoc = XDocument.Load(path);
                xdoc.Root.Add(new XElement("user",
                new XElement("username", TextAd.Text),
                new XElement("password", TextSifre.Text)));
                xdoc.Save(path);
                MessageBox.Show("Kullanıcı Başarıyla eklendi...");
            }

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
