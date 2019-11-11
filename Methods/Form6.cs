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

        double Hesapla(int s1,int s2, out int toplam, out int fark, out double bolum, out int carpim, out int mod)
        {
            toplam = s1 + s2;
            fark = s1 - s2;
            bolum = Convert.ToDouble(s1) / Convert.ToDouble(s2);
            carpim = s1 * s2;
            mod = s1 % s2;
            return toplam;
        }
        private void BtnOut_Click(object sender, EventArgs e)
        {

        }

        private void BtnOutIki_Click(object sender, EventArgs e)
        {

        }
    }
}
