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
    public partial class dersSecimPanel : Form
    {
        public dersSecimPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            DersKayıtListele();
        }
        void DersKayıtListele()
        {
            string query = "select * from OgrenciDersTable where OgrenciNo = @OgrenciNo";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, baglanti);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@OgrenciNo", Convert.ToInt32(girisPanel.form_variable));
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgwEkliDersler.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                if (dgwEkliDersler.CurrentRow != null && dgwEkliDersler.CurrentRow.Cells[0].Value != null)
                {
                    SqlCommand cmd = new SqlCommand("delete from OgrenciDersTable where OgrenciDersID = @OgrenciDersID", baglanti);
                    cmd.Parameters.AddWithValue("@OgrenciDersID", Convert.ToInt32(dgwEkliDersler.CurrentRow.Cells[0].Value));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                DersKayıtListele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                if (dgwEkliDersler.CurrentRow != null && dgwEkliDersler.CurrentRow.Cells[0].Value != null)
                {
                    SqlCommand cmd = new SqlCommand("update OgrenciDersTable set DanismanOnay = @DanismanOnay where OgrenciDersID = @OgrenciDersID", baglanti);
                    cmd.Parameters.AddWithValue("@DanismanOnay", "Onay Bekleniyor");
                    cmd.Parameters.AddWithValue("@OgrenciDersID", Convert.ToInt32(dgwEkliDersler.CurrentRow.Cells[0].Value));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                DersKayıtListele();
            }
        }
    }
}
