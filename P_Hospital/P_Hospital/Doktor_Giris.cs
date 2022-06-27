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

namespace P_Hospital
{
    public partial class Doktor_Giris : Form
    {
        public Doktor_Giris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Select * From Tbl_Doktor where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", mskdtc.Text);
            kmt.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                Doktor_Detay dd = new Doktor_Detay();
                dd.TC = mskdtc.Text;
                dd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı :(", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            AnaForm fr = new AnaForm();
            fr.Show();
            this.Hide();
        }
    }
}
