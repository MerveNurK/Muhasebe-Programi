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
    public partial class Form2 : Form
    {   
        SqlConnection connection=new SqlConnection("Data Source=MERVE\\SQLEXPRESS;Initial Catalog=DenemeDB;Integrated Security=True;Encrypt=False");
        
        
        public Form2()
        {
            InitializeComponent();
        }
        bool isThere;
        private void button1_Click(object sender, EventArgs e)
        {
            string Kullanıcı_Adı = textBox1.Text;
            string Şifre = textBox2.Text;
            

            connection.Open();
            SqlCommand command = new SqlCommand("Select Kullanıcı_Adı,Şifre From DenemeTbl", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                if (Kullanıcı_Adı == reader["Kullanıcı_Adı"].ToString() && Şifre == reader["Şifre"].ToString())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere=false;
                }
            }
            if(isThere)
            {
                MessageBox.Show("Giriş Başarılı");
                Form4 muhasebe = new Form4();
                muhasebe.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            connection.Close();
        }
    }
}
