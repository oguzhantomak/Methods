using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int Hesapla(int s1, int s2)
        {
            int toplam = s1 + s2;
            return toplam;
        }
        private void BtnToplamaYap_Click(object sender, EventArgs e)
        {
            int sonuc = Hesapla(10, 20);
            MessageBox.Show(sonuc.ToString());

        }

        int Kontrol(int s1)
        {
            txtOrnekIki.Clear();
            int sonuc = 0;
            if (s1!= 0 && s1%2==0)
            {
                sonuc = -1;
            }
            else if (s1!= 0 && s1%2==1)
            {
                sonuc = 1;
            }
            else if (s1==0)
            {
                sonuc = 0;
            }
            return sonuc;
        }
        private void BtnOrnekIki_Click(object sender, EventArgs e)
        {
            int sonucx =Kontrol(Convert.ToInt32(txtOrnekIki.Text));
            MessageBox.Show(sonucx.ToString());
        }

        string IfadeKontrol(string name, string lastname)
        {

            string newFirstName = $"{name.Substring(0, 2).ToUpper()}{name.Substring(2,name.Length-2).ToLower()}";
            string newLastName= lastname.ToLower().Replace('a','e');

            return $"{newFirstName }.{newLastName}@hotmail.com";
        }
        private void BtnOrnekUc_Click(object sender, EventArgs e)
        {
            string mail = IfadeKontrol(txtAd.Text, txtSoyad.Text);
            MessageBox.Show(mail);
        }

        int[] Sayilarx(string param) => Array.ConvertAll(param.Split(' '), Convert.ToInt32);
        

        double Koleksiyon(int[] dizi)
        {
            double toplam = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                toplam += Convert.ToDouble(dizi[i].ToString());
            }

            //veya foreach ile yapılabilir

            //foreach (int sayi in dizi)
            //{
            //    toplam += sayi;
            //}

            return Math.Sqrt(toplam);
        }
        private void BtnDiziIsleme_Click(object sender, EventArgs e)
        {
            //int[] sayilar = { 2, 3, 5, 7, 9 };
            //double _sonuc=Koleksiyon(sayilar);
            //MessageBox.Show(_sonuc.ToString());

            
            MessageBox.Show(string.Join("-" ,Sayilarx(txtOrnekIki.Text)));
        }


        Color RenkYakala(Control yakala)
        {
            return yakala.BackColor;
        }

        private void BtnRenkYakalayici_Click(object sender, EventArgs e)
        {
            this.BackColor = RenkYakala(btnRenkYakalayici);
        }
    }
}
