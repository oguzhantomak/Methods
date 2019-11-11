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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Verilen kullanıcı adına göre hotmail.com adresi teslim edilir.
        /// </summary>
        /// <param name="user">Lütfen boşluk bırakarak kullanıcı adı ve soyadı paramtresi veriniz.</param>
        void MailOlustur(string user)
        {
            string[] username = user.Split(' ');
            string mail = $"{username[0].ToLower()}.{username[username.Length - 1].ToLower()}@hotmail.com";
            MessageBox.Show(mail);
        }

        /// <summary>
        /// Verilen kullanıcı adına ve seçilen domain adresine göre mail adresi teslim eder.
        /// </summary>
        /// <param name="user">Lütfen boşluk bırakarak kullanıcı adı ve soyadı paramtresi veriniz.</param>
        /// <param name="domain">Geçerli bir mail sunucu adı giriniz.</param>
        void MailOlustur(string user,string domain)
        {
            string[] username = user.Split(' ');
            string mail = $"{username[0].ToLower()}.{username[username.Length - 1].ToLower()}@{domain}";
            MessageBox.Show(mail);
        }
        private void BtnMailOlustur_Click(object sender, EventArgs e)
        {
            if (cmbSunucuAdlari.SelectedIndex==-1)
            {
                MailOlustur(txtMailKullaniciAdi.Text);
            }
            else
            {
                MailOlustur(txtMailKullaniciAdi.Text, cmbSunucuAdlari.Text);
            }
        }
    }
}
