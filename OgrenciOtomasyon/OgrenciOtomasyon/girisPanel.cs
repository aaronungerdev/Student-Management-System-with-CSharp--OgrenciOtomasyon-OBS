using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OgrenciOtomasyon
{
    public partial class girisPanel : Form
    {
       
        private SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=OgrenciOtomasyon;Integrated Security=True");
        public static string form_variable;

        public girisPanel()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {

            form_variable = txbKullaniciAdi.Text;

            if (baglanti.State.ToString() == "Closed")
            {
                baglanti.Open();
            }

            try
            {

                if (int.Parse(txbKullaniciAdi.Text.ToString()) > 19060299 && int.Parse(txbKullaniciAdi.Text.ToString()) < 29060300)
                {
                    string query = "SELECT * FROM OgrenciTable WHERE OgrenciNo = @No AND OgrenciSifre = @Sifre";

                    SqlParameter prm1 = new SqlParameter("@No", txbKullaniciAdi.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("@Sifre", txbSifre.Text.Trim());
                    SqlCommand cmd = new SqlCommand(query, baglanti);

                    cmd.Parameters.Add(prm1);
                    cmd.Parameters.Add(prm2);

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        Form f = new ogrenciPanel();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı");
                    }
                }
                else if (int.Parse(txbKullaniciAdi.Text.ToString()) > 29060299 && int.Parse(txbKullaniciAdi.Text.ToString()) < 39060300)
                {
                    string query = "SELECT * FROM OgretmenTable WHERE OgretmenID = @ID AND OgretmenSifre = @Sifre";

                    SqlParameter prm1 = new SqlParameter("@ID", txbKullaniciAdi.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("@Sifre", txbSifre.Text.Trim());

                    SqlCommand cmd = new SqlCommand(query, baglanti);

                    cmd.Parameters.Add(prm1);
                    cmd.Parameters.Add(prm2);

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        Form f = new ogretmenPanel();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı");
                    }
                }
                else if (int.Parse(txbKullaniciAdi.Text.ToString()) > 39060299)
                {
                    string query = "SELECT * FROM MemurTable WHERE MemurID = @ID AND MemurSifre = @Sifre";

                    SqlParameter prm1 = new SqlParameter("@ID", txbKullaniciAdi.Text.Trim());
                    SqlParameter prm2 = new SqlParameter("@Sifre", txbSifre.Text.Trim());

                    SqlCommand cmd = new SqlCommand(query, baglanti);

                    cmd.Parameters.Add(prm1);
                    cmd.Parameters.Add(prm2);

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        Form f = new memurPanel();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı");
                    }
                }
                else
                {
                    if (txbKullaniciAdi.Text.Length != 11 || txbSifre.Text.Length != 8)
                    {
                        MessageBox.Show("Geçersiz Kullanıcı Adı veya Şifre");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
