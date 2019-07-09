using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace cinema_otomation
{
    public partial class kayit_ol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["db"].ConnectionString);
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "musteri_add";            
            cmd.Parameters.AddWithValue("@musteri_adi", txtUsername.Text);
            cmd.Parameters.AddWithValue("@musteri_soyadi", txtUsersurname.Text);
            cmd.Parameters.AddWithValue("@telefon_no", txtPhoneNo.Text);
            cmd.Parameters.AddWithValue("@e_mail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@porola", txtPassword.Text);
            cmd.Connection = baglanti;
            cmd.ExecuteNonQuery();
            baglanti.Close();
            txtUsername.Text="";
            txtUsersurname.Text="";
            txtPhoneNo.Text="";
            txtEmail.Text = "";
            txtPassword.Text = "";
            Response.Redirect("anasayfa.aspx");
        }
    }
}