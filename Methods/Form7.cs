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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        void Temizle(Control ctrl)
            //Control türünde ctrl değişkeni oluştur.
        {
            foreach (Control item in ctrl.Controls)
                //Control türündeki ctrl'nin Controls(kontrolleri) içinde dön ve Control türündekileri item olarak yakala
            {
                if (item is TextBox)
                    //eğer item(Control) TextBox ise
                {
                    item.Text = "";
                    //Textbox'ın Text'ini temizle.
                }
                else if (item is NumericUpDown)
                    //Eğer item(control) bir NumericUpDown ise
                {
                    //Numeric up down'ı cast etmemiz lazım çünkü Control türünün value değeri yok. Bu yüzden item'ı cast edip NumericUpDown'a çevirmemiz gerekiyor.
                    NumericUpDown nmr = (NumericUpDown)item;

                    //nmr(NumericUpDown)'ın değerini 0'a eşitle.
                    nmr.Value = nmr.Minimum;
                }
                //n sayıda iç içe group box var ise, eğer item is GroupBox ise Temizle() metodunu çalıştır ve item olarak Control al. Temizle(item);
                else if (item is GroupBox)
                {
                    Temizle(item);
                }
            }
        }

        private void BtnOrnek1_Click(object sender, EventArgs e)
        {
            Temizle(this);
        }
    }
}
