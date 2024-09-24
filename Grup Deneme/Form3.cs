using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grup_Deneme
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=MERVE\\SQLEXPRESS;Initial Catalog=DenemeDB;Integrated Security=True;Encrypt=False";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti=new SqlConnection(conString);
            baglanti.Open();
            if(baglanti.State==System.Data.ConnectionState.Open)
            {
                string query="insert into DenemeTbl values('"+textBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"')";
                SqlCommand komut = new SqlCommand(query,baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı");
                Form2 girisekrani = new Form2();
                girisekrani.Show();
                this.Hide();
            }
        }
    }
}
