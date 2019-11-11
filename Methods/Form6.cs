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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        void Hesapla(int s1,int s2, out int toplam, out int fark, out double bolum, out int carpim, out int mod)
        {
            toplam = s1 + s2;
            fark = s1 - s2;
            bolum = Convert.ToDouble(s1) / Convert.ToDouble(s2);
            carpim = s1 * s2;
            mod = s1 % s2;
        }
        private void BtnOut_Click(object sender, EventArgs e)
        {

        }

        private void BtnOutIki_Click(object sender, EventArgs e)
        {
            int _toplam = 0;
            int _fark= 0;
            double _bolum = 0;
            int _carpim = 0;
            int _mod = 0;

            Hesapla(10,5,out _toplam,out _fark,out _bolum,out _carpim,out _mod);
            MessageBox.Show($"Toplama sonucu: {_toplam}, Fark: {_fark}, Bölüm: {_bolum}, Çarpım {_carpim}, Mod: {_mod}");
        }

        private void BtnParams_Click(object sender, EventArgs e)
        {

        }
    }
}
