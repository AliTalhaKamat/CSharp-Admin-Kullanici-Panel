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
    public partial class Frm_fiyat : Form
    {
        public Frm_fiyat()
        {
            InitializeComponent();
        }

        string path = Application.StartupPath + @"/urunler.xml";

        private void Btn_guncelle_Click(object sender, EventArgs e)
        {

            if (ComboUrun.SelectedIndex == -1) {

                MessageBox.Show("Ürün seçmediniz, lütfen ürün seçiniz!","Hata!");
            }
            else if (TextFiyat.Text == "")
            {
                MessageBox.Show("Lütfen fiyat giriniz!", "Hata!");
            }
            else
            { 

                XDocument myxml = XDocument.Load(path);
            var urunler = (from urun in myxml.Descendants("urun")
                           where
                           urun.Element("ad").Value == ComboUrun.SelectedItem.ToString()
                           select urun).SingleOrDefault();
            ((XElement)urunler).Element("fiyat").SetValue(TextFiyat.Text);
            myxml.Save(path);
            MessageBox.Show("fiyat güncelleme başarılı");
            }
        }

        private void Frm_fiyat_Load(object sender, EventArgs e)
        {

            XDocument myxml = XDocument.Load(path);
            var urunler = from urun in myxml.Descendants("urun")
                          select urun.Element("ad").Value;

            foreach (var veri in urunler)
                ComboUrun.Items.Add(veri.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
