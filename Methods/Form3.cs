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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        void ParametreliMetot(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(i);
            }
        }
        private void BtnOrnekUc_Click(object sender, EventArgs e)
        {
            ParametreliMetot(50);
            ParametreliMetot(int.Parse(txtDeger1.Text));
        }

        void ToplaminKupu(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            int kup = Convert.ToInt32(Math.Pow(toplam,3));
            MessageBox.Show(kup.ToString());

        }
        private void BtnOrnekDort_Click(object sender, EventArgs e)
        {
            ToplaminKupu(Convert.ToInt32(txtDeger1.Text), Convert.ToInt32(txtDeger2.Text));
        }
        void HarfKirp(string param)
        {
            //if (param.Length<=3)
            //{
            //    MessageBox.Show(param);
            //}
            //else
            //{
            //    param = param.Substring(param.Length-3);
            //    MessageBox.Show(param);
            //}
            MessageBox.Show(param.Length<=3?param:param.Substring(param.Length-3));
        }
        private void BtnKirp_Click(object sender, EventArgs e)
        {
            HarfKirp(txtDeger1.Text);
        }

        void MailAyristir(string mails)
        {
            string[] mailler= mails.Split(',', ';', '+');
            foreach (var item in mailler) 
            {
                listBox1.Items.Add(item);
            }
        }

        
        private void BtnListBoxaDoldur_Click(object sender, EventArgs e)
        {
            MailAyristir(txtDeger1.Text);

        }
        void RenkDegistir(string color)
        {
            this.BackColor = Color.FromName(color);
        }

        private void BtnArkaPlanDegistir_Click(object sender, EventArgs e)
        {
            RenkDegistir(cmbRenkler.Text);
        }

        private void BtnSesliKontrolu_Click(object sender, EventArgs e)
        {

        }
    }
}
