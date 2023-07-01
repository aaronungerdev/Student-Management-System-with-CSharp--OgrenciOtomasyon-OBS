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
    public partial class kisiGuncellePanel : Form
    {
        public kisiGuncellePanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e) 
        {
            OgrenciListele();
        }
        void OgrenciListele()
        {
            baglanti.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from OgrenciTable ", baglanti);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgwOgrenciGuncelle.DataSource = dataTable;

            baglanti.Close();
        }
        void OgretmenListele()
        {
            baglanti.Open();

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("Select * from OgretmenTable ", baglanti);
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);
            dgwOgretmenGuncelle.DataSource = dataTable2;

            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            OgretmenListele();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("update OgrenciTable set OgrenciAd = '" + tbxOgrenciAdi.Text + "',OgrenciSoyad = '" + txbOgrenciSoyadi.Text + "',OgrenciBolumID = '" + txbOgrenciBolumu.Text + "',OgrenciTC = '" + txbOgrenciTC.Text + "',OgrenciDanismanID = '" + txbOgrenciDanisman.Text + "',OgrenciSifre = '" + txbOgrenciSifre.Text + "' where OgrenciNo = '" + txbOgrenciNo.Text + "' ", baglanti);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Öğrenci Güncellendi!");

            baglanti.Close();
            OgrenciListele();

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("update OgretmenTable set OgretmenAd = '" + txbOgretmenAdi.Text + "',OgretmenSoyad = '" + txbOgretmenSoyadi.Text + "',OgretmenBolumID = '" + txbOgretmenBrans.Text + "',OgretmenTC = '" + txbOgretmenTC.Text + "',OgretmenSifre = '" + txbOgretmenSifre.Text + "' where OgretmenID = '" + txbOgretmenNo.Text + "' ", baglanti);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Öğretmen Güncellendi!");

            baglanti.Close();
            OgretmenListele();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)  
        {
            tbxOgrenciAdi.Text = dgwOgrenciGuncelle.CurrentRow.Cells[1].Value.ToString();
            txbOgrenciSoyadi.Text = dgwOgrenciGuncelle.CurrentRow.Cells[2].Value.ToString();
            txbOgrenciTC.Text = dgwOgrenciGuncelle.CurrentRow.Cells[3].Value.ToString();
            txbOgrenciBolumu.Text = dgwOgrenciGuncelle.CurrentRow.Cells[4].Value.ToString();
            txbOgrenciNo.Text = dgwOgrenciGuncelle.CurrentRow.Cells[0].Value.ToString();
            txbOgrenciDanisman.Text = dgwOgrenciGuncelle.CurrentRow.Cells[6].Value.ToString();
            txbOgrenciSifre.Text = dgwOgrenciGuncelle.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e) 
        {
            txbOgretmenAdi.Text = dgwOgretmenGuncelle.CurrentRow.Cells[1].Value.ToString();
            txbOgretmenSoyadi.Text = dgwOgretmenGuncelle.CurrentRow.Cells[2].Value.ToString();
            txbOgretmenBrans.Text = dgwOgretmenGuncelle.CurrentRow.Cells[3].Value.ToString();
            txbOgretmenTC.Text = dgwOgretmenGuncelle.CurrentRow.Cells[4].Value.ToString();
            txbOgretmenNo.Text = dgwOgretmenGuncelle.CurrentRow.Cells[0].Value.ToString();
            txbOgretmenSifre.Text = dgwOgretmenGuncelle.CurrentRow.Cells[5].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e) 
        {
            try
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand("UPDATE OgrenciTable set OgrenciDonem = OgrenciDonem+1;", baglanti);
                cmd.ExecuteNonQuery();

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
