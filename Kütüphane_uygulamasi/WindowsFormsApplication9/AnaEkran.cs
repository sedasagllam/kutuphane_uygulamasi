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
    public partial class AnaEkran : Form
    {
        public static string gidenBilgi;
        public AnaEkran()
        {
            InitializeComponent();
        }
        string a ="";
        string b ="";
        public void veriGonder()
        {

        }
        public void kitapEkle(string kitapAdi, string kitapYazari)
        {
            listBox1.Items.Add(kitapAdi +"     "+ kitapYazari);
            a = kitapAdi;
            b = kitapYazari;
        }
        public void kitapDuzenle(string dKitapAdi, string dKitapYazari)
        {
            int secim = listBox1.SelectedIndex;
            listBox1.Items[secim] = dKitapAdi + "     " + dKitapYazari;
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gidenBilgi = listBox1.SelectedItem.ToString();
            KitapDuzenlemeEkrani kitapDuzenlemeEkrani = new KitapDuzenlemeEkrani(this);
            kitapDuzenlemeEkrani.textBox1.Text = a;
            kitapDuzenlemeEkrani.textBox2.Text = b;
            kitapDuzenlemeEkrani.Show();
            button1.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult silme = new DialogResult();
            silme = MessageBox.Show("Kaydı Silmek İstiyormusunuz ?", "Uyarı", MessageBoxButtons.YesNo);
            if (silme == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            button1.Visible = false;
            button2.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
        }
    }
}
