using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace yükleme_c_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        string ad, soyad, ders;
        int vize, final, odev;
        private void button1_Click(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            soyad = textBox2.Text;
            ders = textBox6.Text;
            vize = Convert.ToInt32(textBox3.Text);
            final = Convert.ToInt32(textBox4.Text);
            odev = Convert.ToInt32(textBox5.Text);

            Class1 hesapla = new Class1();
            double ortalama = hesapla.hesapla(vize, final, odev);

            label7.Text = ad + " " + soyad + " " + ders + " Ortalaması :" + ortalama;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text))
            { 
              MessageBox.Show("Lütfen Bilgiler Doldurunuz");
            }
            else
            {   
            Class1 hesapla = new Class1();
            double ortalama = hesapla.hesapla(vize, final, odev);

            StreamWriter yaz = File.AppendText("bilgiler.txt");
            yaz.WriteLine(ad + " " + soyad + " " + ders + " Ortalaması :" + ortalama);
            yaz.Close();
            MessageBox.Show("Bilgileriniz Başarıyla Kaydedildi!");
               
            }
        }

        string veri;
        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader oku=File.OpenText("bilgiler.txt");
            while ((veri = oku.ReadLine()) !=null)
            {
                listBox1.Items.Add(veri);
            }
            oku.Close();
        }
    }
}
