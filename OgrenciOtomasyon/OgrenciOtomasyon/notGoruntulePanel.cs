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
    public partial class notGoruntulePanel : Form
    {
        public notGoruntulePanel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");

        private void Form8_Load(object sender, EventArgs e) 
        {
            baglanti.Open();
            string query = "select OgrenciDersID,Vize,Final,Butunleme,[Gecme Notu],[Gecme Durumu],OgrenciDonem from NotTable where NotTable.OgrenciDersID in (select OgrenciDersID from OgrenciDersTable where OgrenciNo ='" + Convert.ToInt32(girisPanel.form_variable) + "' ) "; 
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgwNot.DataSource = dataTable;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbDersID.Text = dgwNot.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Close();

            baglanti.Open();
            string query = "select DersID from OgrenciDersTable where OgrenciDersID = '" + Convert.ToInt32(dgwNot.CurrentRow.Cells[0].Value.ToString()) + "'";
            SqlCommand cmd = new SqlCommand(query, baglanti);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            txbDersID.Text = Convert.ToString(reader.GetValue(0));
            reader.Close();
            baglanti.Close();


            baglanti.Open();
            string query2 = "select DersAdi from DersTable where DersID = '" + Convert.ToInt32(txbDersID.Text) + "'";
            SqlCommand cmd2 = new SqlCommand(query2, baglanti);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();
            txbDersAdi.Text = Convert.ToString(reader2.GetValue(0));
            reader2.Close();

            baglanti.Close();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbDersID.Text = dgwNot.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
