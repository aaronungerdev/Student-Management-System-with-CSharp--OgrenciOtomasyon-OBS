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
    public partial class dersOnayPanel : Form
    {
        public dersOnayPanel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");

        private void Form10_Load(object sender, EventArgs e)
        {
            DanismanOnayListele();
        }
        void DanismanOnayListele()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select OgrenciDersID,OgrenciTable.OgrenciNo,concat(OgrenciTable.OgrenciAd,' ',OgrenciTable.OgrenciSoyad) as Ogrenci,DanismanOnay,concat(OgretmenAd,' ',OgretmenSoyad) as Danisman,DersAdi,OgrenciDonem from OgrenciTable,OgrenciDersTable,OgretmenTable,DersTable where OgrenciTable.OgrenciDanismanID = '" + girisPanel.form_variable + "' and OgrenciDersTable.OgrenciNo = OgrenciTable.OgrenciNo and OgrenciDersTable.DanismanOnay like ' Onay%' and OgretmenAd = (select OgretmenAd from OgretmenTable where OgretmenID = '" + girisPanel.form_variable+"') and OgrenciDersTable.DersID = DersTable.DersID ;", baglanti);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            try
            {
                baglanti.Open();

                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null && dataGridView1.CurrentRow.Cells[6].Value != null)
                {
                    string sql = "insert into NotTable (OgrenciDersID, OgrenciDonem) values (@OgrenciDersID, @OgrenciDonem)";
                    SqlCommand sqlCommand = new SqlCommand(sql, baglanti);
                    sqlCommand.Parameters.AddWithValue("@OgrenciDersID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    sqlCommand.Parameters.AddWithValue("@OgrenciDonem", Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value));
                    sqlCommand.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("update OgrenciDersTable set DanismanOnay = 'Kesin Kayıt' where OgrenciDersID = @OgrenciDersID", baglanti);
                    cmd.Parameters.AddWithValue("@OgrenciDersID", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
                DanismanOnayListele();
            }
        }

    }
}
