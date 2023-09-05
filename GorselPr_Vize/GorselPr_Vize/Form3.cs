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
    public partial class Frm_kullanici : Form
    {
        public Frm_kullanici()
        {
            InitializeComponent();
        }

        string path = Application.StartupPath + @"/urunler.xml";

        int toplam = 0;
        int c1, c2, c3, c4;
        int faturaToplam;

        private void Frm_kullanici_Load(object sender, EventArgs e)
        {
            XDocument myxml = XDocument.Load(path);
            var urunler = from urun in myxml.Descendants("urun")
                          select urun.Element("fiyat").Value;


        

        }

        private void Btn_hesapla_Click(object sender, EventArgs e)
        {
            int t1, t2, t3, t4;
           

            XDocument myxml = XDocument.Load(path);



            richTextBox1.AppendText("Ürün Adı" + "                        " + "Adet" + "             " + "Fiyat (TL)\n");

            if (checkBox1.Checked)
            {
                var urunler = (from urun in myxml.Descendants("urun")
                               where
                               urun.Element("ad").Value == checkBox1.Text.ToString()
                               select urun).SingleOrDefault();
                t1 = (Convert.ToInt32(comboBox1.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));
                richTextBox1.AppendText((urunler.Element("ad").Value + "                  " + comboBox1.SelectedItem + "                   " + (Convert.ToInt32(comboBox1.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value))) + " TL" + "\n"));

                faturaToplam = faturaToplam + (Convert.ToInt32(comboBox1.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));

            }
            if (checkBox2.Checked)
            {
                var urunler = (from urun in myxml.Descendants("urun")
                               where
                               urun.Element("ad").Value == checkBox2.Text.ToString()
                               select urun).SingleOrDefault();
                t2 = (Convert.ToInt32(comboBox2.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));
                richTextBox1.AppendText((urunler.Element("ad").Value + "                        " + comboBox2.SelectedItem + "                   " + (Convert.ToInt32(comboBox2.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value))) + " TL" + "\n"));

                faturaToplam = faturaToplam + (Convert.ToInt32(comboBox2.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));

            }
            if (checkBox3.Checked)
            {
                var urunler = (from urun in myxml.Descendants("urun")
                               where
                               urun.Element("ad").Value == checkBox3.Text.ToString()
                               select urun).SingleOrDefault();
                t3 = (Convert.ToInt32(comboBox3.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));
                richTextBox1.AppendText((urunler.Element("ad").Value + "                " + comboBox3.SelectedItem + "                   " + (Convert.ToInt32(comboBox3.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value))) + " TL" + "\n"));
                faturaToplam = faturaToplam + (Convert.ToInt32(comboBox3.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));

            }
            if (checkBox4.Checked)
            {
                var urunler = (from urun in myxml.Descendants("urun")
                               where
                               urun.Element("ad").Value == checkBox4.Text.ToString()
                               select urun).SingleOrDefault();
                t4 = (Convert.ToInt32(comboBox4.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));
                richTextBox1.AppendText((urunler.Element("ad").Value + "          " + comboBox4.SelectedItem + "                   " + (Convert.ToInt32(comboBox4.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value))) + " TL" + "\n" + "\n"));

                faturaToplam = faturaToplam + (Convert.ToInt32(comboBox4.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));

            }

            richTextBox1.AppendText("TOPLAM>>>" + "  " + faturaToplam + "  " + " TL" + "\n");



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            XDocument myxml = XDocument.Load(path);
            var urunler = (from urun in myxml.Descendants("urun")
                           where
                           urun.Element("ad").Value == checkBox1.Text.ToString()
                           select urun).SingleOrDefault();

            //if (checkBox1.Checked)
            //{
            //    c1 = (Convert.ToInt32(comboBox1.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));
                
            //}

            c1 = Convert.ToInt32(comboBox1.SelectedItem);
            toplam = toplam + c1;
            toplama();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            XDocument myxml = XDocument.Load(path);
            var urunler = (from urun in myxml.Descendants("urun")
                           where
                           urun.Element("ad").Value == checkBox2.Text.ToString()
                           select urun).SingleOrDefault();

            //if (checkBox2.Checked)
            //{
            //    c2 = (Convert.ToInt32(comboBox2.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));
                
            //}

            c2 = Convert.ToInt32(comboBox2.SelectedItem);
            toplam = toplam + c2;
            toplama();
        }

        private void Btn_temizle_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            TextToplam.Clear();
            comboBox1.Text = "0";
            comboBox2.Text = "0";
            comboBox3.Text = "0";
            comboBox4.Text = "0";

        }

        private void Btn_yaz_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            XDocument myxml = XDocument.Load(path);
            var urunler = (from urun in myxml.Descendants("urun")
                           where
                           urun.Element("ad").Value == checkBox3.Text.ToString()
                           select urun).SingleOrDefault();

            //if (checkBox3.Checked)
            //{
            //    c3 = (Convert.ToInt32(comboBox3.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));
                
            //}
            c3 = Convert.ToInt32(comboBox3.SelectedItem);
            toplam = toplam + c3;
            toplama();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            XDocument myxml = XDocument.Load(path);
            var urunler = (from urun in myxml.Descendants("urun")
                           where
                           urun.Element("ad").Value == checkBox4.Text.ToString()
                           select urun).SingleOrDefault();

            //c4 = (Convert.ToInt32(comboBox4.SelectedItem) * Convert.ToInt32((urunler.Element("fiyat").Value)));
                c4 = Convert.ToInt32(comboBox4.SelectedItem);
                toplam = toplam + c4;
                toplama();

            
            
        }

        void toplama()
        {
            TextToplam.Text = (c1 + c2 + c3 + c4).ToString(); ;
        }

        
    }
}
