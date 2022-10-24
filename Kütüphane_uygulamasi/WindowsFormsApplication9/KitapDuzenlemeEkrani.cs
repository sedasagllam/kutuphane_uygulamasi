using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class KitapDuzenlemeEkrani : Form
    {
        AnaEkran anaEkran;
        public KitapDuzenlemeEkrani(AnaEkran parametre)
        {
            InitializeComponent();
            anaEkran = parametre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.kitapDuzenle(textBox1.Text, textBox2.Text);
            
            this.Close();
        }

        private void KitapDuzenlemeEkrani_Load(object sender, EventArgs e)
        {

        }

    }
}
