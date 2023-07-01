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
    public partial class ogretmenPanel : Form
    {
        public ogretmenPanel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txbNo.Text = girisPanel.form_variable;

            baglanti.Open();

            string query = "select * from OgretmenTable where OgretmenID = '" + txbNo.Text + "'";
            SqlCommand cmd = new SqlCommand(query, baglanti);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            txbAdi.Text = reader.GetString(1);
            txbSoyadi.Text = reader.GetString(2);
            txbBrans.Text = reader.GetString(3);

            reader.Close();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from OgrenciTable where OgrenciDanismanID = '"+ Convert.ToInt32(txbNo.Text) + "'", baglanti); //Danışmanlığını yaptığımız öğrencileri çekme
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgwOgrenciler.DataSource = dataTable;

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("select DersID,DersAdi from DersTable where DersID in (select OgretmenDersTable.DersID from OgretmenDersTable where OgretmenID = '"+Convert.ToInt32(txbNo.Text) +"')", baglanti); //Öğretmenin verdiği dersler
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);
            dgwDersler.DataSource = dataTable2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new dersOnayPanel();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new notEklePanel();
            f.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
