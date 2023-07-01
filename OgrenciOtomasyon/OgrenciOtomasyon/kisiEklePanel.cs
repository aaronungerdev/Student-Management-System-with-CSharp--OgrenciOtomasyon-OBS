using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciOtomasyon
{
    public partial class kisiEklePanel : Form
    {
        public kisiEklePanel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");

        private void Form6_Load(object sender, EventArgs e)
        {
            BolumIDgetir();
        }

        void BolumIDgetir()
        {
            baglanti.Open();

            string query = "select BolumID from BolumTable";
            SqlCommand cmd = new SqlCommand(query, baglanti);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            while (reader.Read())
            {
                cxbOgrenciBolumu.Items.Add(reader.GetString(0));
                cxbOgretmenBransi.Items.Add(reader.GetString(0));
            }

            reader.Close();
            baglanti.Close();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand2 = new SqlCommand("Insert into USERTable (USERTC) values ('" + txbOgrenciTC.Text + "')", baglanti);
                sqlCommand2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                string query = "Insert into OgrenciTable (OgrenciAd,OgrenciSoyad,OgrenciTC,OgrenciBolumID,OgrenciDanismanID,OgrenciSifre) values('" + tbxOgrenciAdi.Text + "','" + txbOgrenciSoyadi.Text + "','" + txbOgrenciTC.Text + "','" + cxbOgrenciBolumu.Text + "','" + Convert.ToInt32(cxbDanismanNo.Text) + "','" + txbOgrenciSifre.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query, baglanti);
                sqlCommand.ExecuteNonQuery();
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            MessageBox.Show("Öğrenci Eklendi!");

            cxbDanismanNo.Items.Clear();
            cxbOgretmenBransi.Items.Clear();
            cxbOgrenciBolumu.Items.Clear();
            tbxOgrenciAdi.Clear();
            txbOgrenciSoyadi.Clear();
            txbOgrenciTC.Clear();
            txbOgrenciSifre.Clear();


            BolumIDgetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand2 = new SqlCommand("Insert into USERTable (USERTC) values ('" + txbOgretmenTC.Text + "')", baglanti); 
                sqlCommand2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                string query = "Insert into OgretmenTable (OgretmenAd,OgretmenSoyad,OgretmenBolumID,OgretmenTC,OgretmenSifre) values('" + txbOgretmenAdi.Text + "','" + txbOgretmenSoyadi.Text + "','" + cxbOgretmenBransi.Text + "','" + txbOgretmenTC.Text + "','" + txbOgretmenSifre.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query, baglanti);
                sqlCommand.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                baglanti.Close();
            }

            MessageBox.Show("Öğretmen Eklendi!");

            txbOgretmenAdi.Clear();
            txbOgretmenSoyadi.Clear();
            txbOgretmenTC.Clear();
            cxbOgretmenBransi.Items.Clear();
            txbOgretmenSifre.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void DanismanIDgetir()
        {
            baglanti.Open();
            string query = "select OgretmenID from OgretmenTable where OgretmenBolumID = '" + cxbOgrenciBolumu.Text + "' ";
            SqlCommand sqlCommand = new SqlCommand(query, baglanti);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                cxbDanismanNo.Items.Add(reader.GetValue(0));
            }
            reader.Close();
            baglanti.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DanismanIDgetir();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DanismanIDgetir();
        }

     
    }
}
