using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnectivity
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string address = txtAddress.Text;

            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog = DatabaseConnectivity;Trusted_Connection=true;");
                con.Open();

                SqlCommand com = new SqlCommand(); // Create a object of SqlCommand class
                com.Connection = con; //Pass the connection object to Command
                com.CommandType = CommandType.StoredProcedure; // We will use stored procedure.
                com.CommandText = "spInsertUser"; //Stored Procedure Name

                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
                com.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                com.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
                com.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }


        }
    }
}