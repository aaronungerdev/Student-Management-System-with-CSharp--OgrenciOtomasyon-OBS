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
    public partial class notEklePanel : Form
    {
        public notEklePanel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");
        private void Form9_Load(object sender, EventArgs e)
        {
            NotListele();
        }
        void NotListele()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select NotID,NotTable.OgrenciDonem,Vize,Final,Butunleme,[Gecme Notu],[Gecme Durumu]  from NotTable where NotTable.OgrenciDersID in (select OgrenciDersID from OgrenciDersTable where DersID in (select DersID from OgretmenDersTable where OgretmenID = '"+girisPanel.form_variable+ "'))", baglanti);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgwNotEkle.DataSource = dataTable;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand("update NotTable set Vize = '" + Convert.ToInt32(txbVize.Text) + "',Final = '" + Convert.ToInt32(txbFinal.Text) + "',Butunleme = '" + Convert.ToInt32(txbBut.Text) + "' where NotID = ('" + dgwNotEkle.CurrentRow.Cells[0].Value + "') ", baglanti);
                cmd.ExecuteNonQuery();

                baglanti.Close();

                if (Convert.ToInt32(dgwNotEkle.CurrentRow.Cells[4].Value) == 0) 
                {
                    baglanti.Open();

                    SqlCommand cmd2 = new SqlCommand("update NotTable set [Gecme Notu] = '"+((Convert.ToInt32(txbVize.Text)*0.4)+(Convert.ToInt32(txbFinal.Text) * 0.6)) + "' where NotID = ('" + dgwNotEkle.CurrentRow.Cells[0].Value + "') ", baglanti);
                    cmd2.ExecuteNonQuery();

                    baglanti.Close();
                    Gectimi();
                    NotListele();

                }
                else if (Convert.ToInt32(dgwNotEkle.CurrentRow.Cells[4].Value) != 0) 
                {
                    baglanti.Open();

                    SqlCommand cmd3 = new SqlCommand("update NotTable set [Gecme Notu] = '" + ((Convert.ToInt32(txbVize.Text) * 0.4) + (Convert.ToInt32(txbBut.Text) * 0.6)) + "' where NotID = ('" + dgwNotEkle.CurrentRow.Cells[0].Value + "')", baglanti);
                    cmd3.ExecuteNonQuery();

                    baglanti.Close();
                    Gectimi();
                    NotListele();

                }
                baglanti.Close();
                Gectimi();
                NotListele();

                txbBut.Clear();
                txbFinal.Clear();
                txbVize.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
            }
        }
        void Gectimi()
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("update NotTable set [Gecme Durumu] = 'Basarili' where NotTable.[Gecme Notu] >= 60 and NotID ='"+ dgwNotEkle.CurrentRow.Cells[0].Value + "'", baglanti);
            SqlCommand cmd2 = new SqlCommand("update NotTable set [Gecme Durumu] = 'Basarisiz' where NotTable.[Gecme Notu] < 60 and NotID = '" + dgwNotEkle.CurrentRow.Cells[0].Value + "' ", baglanti);
            cmd2.ExecuteNonQuery();
            cmd.ExecuteNonQuery();

            baglanti.Close();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbVize.Text = dgwNotEkle.CurrentRow.Cells[2].Value.ToString();
            txbFinal.Text = dgwNotEkle.CurrentRow.Cells[3].Value.ToString();
            txbBut.Text = dgwNotEkle.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
