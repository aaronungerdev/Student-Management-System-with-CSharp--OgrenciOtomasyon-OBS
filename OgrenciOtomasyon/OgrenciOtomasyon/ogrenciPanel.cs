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
    public partial class ogrenciPanel : Form
    {
        public ogrenciPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e) 
        {
            txbNo.Text = girisPanel.form_variable; 

            baglanti.Open();

            string query = "select * from OgrenciTable where OgrenciNo = '"+txbNo.Text+"'"; 
            SqlCommand cmd = new SqlCommand(query,baglanti);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            txbAdi.Text = reader.GetString(1); 
            txbSoyadi.Text = reader.GetString(2);
            txbBolumu.Text = reader.GetString(4);

            reader.Close();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from DersTable", baglanti); 
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgwdDersler.DataSource = dataTable;

            baglanti.Close();
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e) 
        {
            txbDersAdi.Text = dgwdDersler.CurrentRow.Cells[1].Value.ToString();
            txbDersKredisi.Text = dgwdDersler.CurrentRow.Cells[2].Value.ToString();
            txbDersAKTS.Text = dgwdDersler.CurrentRow.Cells[3].Value.ToString();
            txbDersNo.Text = dgwdDersler.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            baglanti.Open();
            try
            {
                string query = "Insert into OgrenciDersTable (OgrenciNo,DersID) values('" + txbNo.Text + "','" + txbDersNo.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query, baglanti);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Ders Listeye Eklendi!");
                baglanti.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new dersSecimPanel();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new notGoruntulePanel();
            f.Show();
        }
    }
}
