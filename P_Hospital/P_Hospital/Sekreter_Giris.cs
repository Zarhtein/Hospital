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
    public partial class Sekreter_Giris : Form
    {
        public Sekreter_Giris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@s1 and SekreterSifre=@s2", bgl.baglanti());
            kmt.Parameters.AddWithValue("@s1", mskdtc.Text);
            kmt.Parameters.AddWithValue("@s2", txtsifre.Text);
            SqlDataReader dr = kmt.ExecuteReader();
            if (dr.Read())
            {
                Sekreter_Detay sd = new Sekreter_Detay();
                sd.tcno = mskdtc.Text;
                sd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre :(", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            AnaForm fr = new AnaForm();
            fr.Show();
            this.Hide();
        }

        private void Sekreter_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
