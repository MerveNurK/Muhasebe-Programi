using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grup_Deneme
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ///////Merve
            String işletmeadi = Convert.ToString(textBox1.Text);
            textBox1.Text = Convert.ToString(işletmeadi);
            double faturalar = Convert.ToDouble(textBox2.Text);
            double sigorta = Convert.ToDouble(textBox10.Text);
            double Amortismanharcaması = Convert.ToDouble(textBox17.Text);
            double Amortismanyüzdesi = Convert.ToDouble(((Amortismanharcaması * 20) / 100)+Amortismanharcaması);
           
            if (radioButton6.Checked)
            {
                double dükkankirasi1 = Convert.ToDouble(textBox16.Text);
                double stopaj1 = Convert.ToDouble(dükkankirasi1);                  
                double stopajvergisi1 = Convert.ToDouble(((dükkankirasi1 * 20) / 100));
                textBox19.Text = Convert.ToString(stopajvergisi1);
            }
            else 
            {
                double dükkankirasi1 = Convert.ToDouble(textBox16.Text);
                double aylikgelir = Convert.ToDouble(textBox15.Text);
                double stopaj2 = Convert.ToDouble(dükkankirasi1);                  
                double stopajvergisi2 = Convert.ToDouble(((aylikgelir * 20) / 100));
                textBox19.Text = Convert.ToString(stopajvergisi2);
                textBox4.Text = Convert.ToString(aylikgelir);
                double dükkankirasi3 = 0;
                textBox16.Text = Convert.ToString(dükkankirasi3);
                textBox16.Enabled = false;

            }

            //////////////////Bukle

                double sayi1 = Convert.ToDouble(textBox11.Text);
                double sayi2 = Convert.ToDouble(textBox12.Text);
                double sayi3 = Convert.ToDouble(textBox13.Text);
                double sayi4 = Convert.ToDouble(textBox14.Text);
                double ekstramasraflar = Convert.ToDouble(sayi1 + sayi2 + sayi3 + sayi4);
          
            //////////////////Cansuu

            double net = 17002, brut = 20002;
            double calisansayisi = Convert.ToDouble(textBox9.Text);
            double ekucret = 0;
            double toplamiscimaas = 0;
            double yol = 1456, yemek = 2860;

            ekucret = (yol + yemek)*calisansayisi;
            textBox3.Text = ekucret.ToString();


            if (radioButton4.Checked)
            {
                toplamiscimaas = (calisansayisi * net) + ekucret;
                textBox8.Text = toplamiscimaas.ToString();

            }
            else if (radioButton5.Checked)
            {
                toplamiscimaas = (calisansayisi * brut) + ekucret;
                textBox8.Text = toplamiscimaas.ToString();
            }
            else
            {
                textBox3.Clear();
                MessageBox.Show("Lütfen brüt ya da net seçimi yapınız.");
            }

            ////// cansu gelir vergisi
            double gelirvergi = 0;
            double sonuc = 0;
            double toplamgelir;
            toplamgelir = Convert.ToDouble(textBox15.Text);
            if (toplamgelir <= 110000)
            {   sonuc = toplamgelir * 0.15;
                textBox18.Enabled = false;
                textBox18.Text = Convert.ToString(sonuc);
            }
            else if (toplamgelir <= 230000)
            {   sonuc = 16500 + (toplamgelir - 110000) * 0.2;
                textBox18.Enabled = false;
                textBox18.Text = Convert.ToString(sonuc);
            }
            else if (toplamgelir <= 570000)
            {   sonuc = 40500 + (toplamgelir - 230000) * 0.27;
                textBox18.Enabled = false;
                textBox18.Text = Convert.ToString(sonuc);
            }
            else if (toplamgelir <= 3000000)
            {   sonuc = 135000 + (toplamgelir - 580000) * 0.35;
                textBox18.Enabled = false;
                textBox18.Text = Convert.ToString(sonuc);
            }
            else
            {
                sonuc = 982000 + (toplamgelir - 3000000) * 0.4;
                textBox18.Enabled = false;
                textBox18.Text = Convert.ToString(sonuc);
            }
            double dükkankirasi = Convert.ToDouble(textBox16.Text);
            double gider = Convert.ToDouble(dükkankirasi +sonuc+ Amortismanyüzdesi + ekstramasraflar + toplamiscimaas + ekucret + faturalar + sigorta);
            textBox5.Text = Convert.ToString(gider);
            double aylikgelir2 = Convert.ToDouble(textBox15.Text);
            double kar = Convert.ToDouble(aylikgelir2 - gider);
            textBox6.Text = Convert.ToString(kar);
            double zarar = Convert.ToDouble(aylikgelir2 - gider);
            textBox7.Text = Convert.ToString(zarar);

            if (aylikgelir2 < gider)
            {
                double aylikgelir = Convert.ToDouble(textBox15.Text);
                textBox4.Text = Convert.ToString(aylikgelir);
                textBox6.Visible = false;
                textBox6.Enabled = false;
                label19.Text = "";
                textBox7.Text = Convert.ToString(zarar);
                MessageBox.Show("ZARARDASINIZ");
                
            }
            else if (aylikgelir2 > gider)
            {
                double aylikgelir = Convert.ToDouble(textBox15.Text);
                textBox4.Text = Convert.ToString(aylikgelir);
                textBox7.Visible = false;
                textBox7.Enabled = false;
                label20.Text = "";
                textBox6.Text = Convert.ToString(kar);
                MessageBox.Show("KARDASINIZ");   
            }
            //////Bukle
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;   
        }

        //bukle button3

        private void button3_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = false;
            textBox17.Enabled = true;
            textBox18.Enabled = false;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            if (radioButton4.Checked)
            {
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked)
            {
                radioButton5.Checked = false;
            }
            if (radioButton6.Checked == true)
            {
                radioButton6.Checked = false;
                textBox16.Text = "";
            }
        }

        //Bukle button4

        private void button4_Click(object sender, EventArgs e)
        {
            label20.Text = "Zarar";
            label19.Text = "Kar";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox19.Text = "";
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = false;
            textBox17.Enabled = true;
            textBox18.Enabled = false;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            if (radioButton6.Checked==true)
            {
                radioButton6.Checked = false;
                textBox16.Text = "";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                textBox16.Enabled = true;
                textBox16.Text = "";
                textBox19.Text = "";
            }
            else if (radioButton6.Checked)
            {
                double aylikgelir = Convert.ToDouble(textBox15.Text);
                double dükkankirasi = Convert.ToDouble(textBox16.Text);
                double stopaj = Convert.ToDouble(dükkankirasi);                   
                double stopajvergisi = Convert.ToDouble(((aylikgelir * 20) / 100));
                textBox19.Text = Convert.ToString(stopajvergisi);
            }
        }
    }
}