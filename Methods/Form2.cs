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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void DonguluMetot()
        {
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }
        private void BtnOrnekBir_Click(object sender, EventArgs e)
        {
            DonguluMetot();
        }
        void FormStil()
        {
            this.Size = new Size(400, 400);
            this.BackColor = Color.White;
        }
        private void BtnOrnekIki_Click(object sender, EventArgs e)
        {
            FormStil();
        }
    }
}
