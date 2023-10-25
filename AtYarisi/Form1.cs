using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int BirinciAtSolaUzaklik, IkinciAtSolaUzaklik, UcuncuAtSolaUzaklik;
        Random rast = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label7.Text = "0";
            pictureBox1.Location = new Point(12, 40);
            pictureBox2.Location = new Point(12, 173);
            pictureBox3.Location = new Point(12, 308);

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciAtinGenisligi = pictureBox1.Width;
            int ikinciAtGenisligi = pictureBox2.Width;
            int ucuncuAtGenisligi = pictureBox3.Width;
            int bitisUzaklıgı = label6.Left;
            int sayac = Convert.ToInt32(label7.Text);
            sayac++;
            label7.Text = sayac.ToString();


            pictureBox1.Left = pictureBox1.Left + rast.Next(3, 13);
            pictureBox2.Left = pictureBox2.Left + rast.Next(3, 13);
            pictureBox3.Left = pictureBox3.Left + rast.Next(3, 13);

            if (pictureBox1.Left > pictureBox2.Left + 3 && pictureBox1.Left > pictureBox3.Left + 3)
            {
                label5.Text = "1 Numaralı At Yarışı Önde Götürüyor!!!";
            }

            if (pictureBox2.Left > pictureBox1.Left + 3 && pictureBox2.Left > pictureBox3.Left + 3)
            {
                label5.Text = "2 Numaralı At Sağlam Bir Atak İle Öne Geçti!!!";
            }

            if (pictureBox3.Left > pictureBox1.Left + 3 && pictureBox3.Left > pictureBox2.Left + 3)
            {
                label5.Text = "3 Numaralı At Liderliği Kaptı Durmuyor";
            }

            if (birinciAtinGenisligi + pictureBox1.Left >= bitisUzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("Bir Numaralı At Yarışı Kazandı" + " " + sayac + "Saniye ");
                label5.Text = ("Bir Numaralı At Yarışı Kazandı");

            }
            if (ikinciAtGenisligi + pictureBox2.Left >= bitisUzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("İki Numaralı At Yarışı Kazandı" + " " + sayac + "Saniye ");
                label5.Text = ("İki Numaralı At Yarışı Kazandı");

            }
            if (ucuncuAtGenisligi + pictureBox3.Left >= bitisUzaklıgı)
            {
                timer1.Enabled = false;
                MessageBox.Show("Üç Numaralı At Yarışı Kazandı" + " " + sayac + "Saniye ");
                label5.Text = ("Üç Numaralı At Yarışı Kazandı");

            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            BirinciAtSolaUzaklik = pictureBox1.Left;
            IkinciAtSolaUzaklik = pictureBox2.Left;
            UcuncuAtSolaUzaklik = pictureBox3.Left;

        }
    }
}
