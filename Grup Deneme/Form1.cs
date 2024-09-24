using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grup_Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//SqlCommand komut = new SqlCommand("");
            Form2 girisekrani = new Form2();
            girisekrani.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 kayitekrani = new Form3();
            kayitekrani.Show();
            this.Hide();
        }
    }
}
