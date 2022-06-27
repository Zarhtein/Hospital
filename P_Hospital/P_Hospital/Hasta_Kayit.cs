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
    public partial class Hasta_Kayit : Form
    {
        public Hasta_Kayit()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void btnkayit_Click(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("insert into Tbl_Hasta (HastaAd,HastaSoyad,HastaTC,HastaTel,HastaSifre,HastaCnsyt) values (@h1,@h2,@h3,@h4,@h5,@h6)", bgl.baglanti());
            kmt.Parameters.AddWithValue("@h1", txtad.Text);
            kmt.Parameters.AddWithValue("@h2", txtsoyad.Text);
            kmt.Parameters.AddWithValue("@h3", mskdtc.Text);
            kmt.Parameters.AddWithValue("@h4", mskdtel.Text);
            kmt.Parameters.AddWithValue("@h5", txtsifre.Text);
            kmt.Parameters.AddWithValue("@h6", cmbcinsiyet.Text);
            kmt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir :)" + "\n" + "Şifreniz: " + txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
