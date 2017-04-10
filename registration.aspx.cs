using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


    public partial class registration : System.Web.UI.Page
    {
       protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string address = txtAddress.Text;

            try
            {
            //SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog = DatabaseConnectivity;Trusted_Connection=true;");
               SqlConnection con = new SqlConnection("Data Source=jdbc:oracle:thin:@oracle1.centennialcollege.ca:1521:SQLD;InitialCatalog=DatabaseConnectivity;;Trusted_Connection=true; UserID=COMP214_W17_003_10;" + "Password=password;");
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
