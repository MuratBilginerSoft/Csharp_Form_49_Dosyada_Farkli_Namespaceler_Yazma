using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aynı_Dosyada_Farklı_Namespaceler_Yazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Toplama.işlemler nesne = new Toplama.işlemler();
           label3.Text=nesne.topla(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Çıkarma.işlemler nesne = new Çıkarma.işlemler();
            label3.Text = nesne.çıkarma(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Çarpma.işlemler nesne = new Çarpma.işlemler();
            label3.Text = nesne.çarpım(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bölme.işlemler nesne = new Bölme.işlemler();
            label3.Text = nesne.bölüm(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}

namespace Toplama
{
    public partial class işlemler
    {
        int a, b, sonuc = 0;

        public int topla(int a, int b)
        {
            sonuc = a + b;
            return sonuc;
        }
    }

}

namespace Çıkarma
{
    public partial class işlemler
    {
        int a, b, sonuc = 0;

        public int çıkarma(int a, int b)
        {
            sonuc = a - b;
            return sonuc;
        }
    }
}

namespace Çarpma
{
    public partial class işlemler
    {
        int a, b, sonuc = 0;

        public int çarpım(int a, int b)
        {
            sonuc = a * b;
            return sonuc;
        }
    }
}

namespace Bölme
{
    public partial class işlemler
    {
        int a, b, sonuc = 0;

        public int bölüm(int a, int b)
        {
            sonuc = a / b;
            return sonuc;
        }
    }
}