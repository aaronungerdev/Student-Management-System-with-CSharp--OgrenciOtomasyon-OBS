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

namespace OgrenciOtomasyon
{
    public partial class memurPanel : Form
    {
        public memurPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");

        private void Form5_Load(object sender, EventArgs e)
        {
            txbNo.Text = girisPanel.form_variable;

            baglanti.Open();

            string query = "select * from MemurTable where MemurID = '" + txbNo.Text + "'"; 
            SqlCommand cmd = new SqlCommand(query, baglanti);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            txbAdi.Text = reader.GetString(1); 
            txbSoyadi.Text = reader.GetString(2);

            reader.Close();

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new kisiEklePanel();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new kisiGuncellePanel();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
