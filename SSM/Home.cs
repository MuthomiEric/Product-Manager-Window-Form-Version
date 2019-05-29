using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSM
{
    public partial class Home : Form
    {
        #region MY METHODS
        public void ClearLoginLabels()
        {
            lblusername.Text = "";
            lblpassword.Text = "";
        }

        public void ClearSignUpLabels()
        {
            gb2lblusername.Text = "";
            gb2lblpassword.Text = "";
            gb2lblPhone.Text = "";
            gb2lblfirestname.Text = "";
            gb2lbllastname.Text = "";
            gb2lblidnumber.Text = "";
            gb2lblofficeid.Text = "";
            gb2lblEmail.Text = "";
        }
        #endregion

        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        int count = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                con.Open();
                //cmd.ExecuteReader();
                //SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                //dt.Load(rdr);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                count = dt.Rows.Count;
                if (txtUsername.Text == "")
                {
                    lblusername.Text = "Required!";
                }
               
                if (txtPassword.Text == "")
                {
                    lblpassword.Text = "Required!";
                }
             
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    if (count == 0)

                        MessageBox.Show("Invalid Credentials!");

                    else
                    {
                        gbLogin.Visible = false;
                        gbMain.Visible = true;
                       
                    }

                }



            }


        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            lblusername.Text = "";
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            lblpassword.Text = "";
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {

            gbLogin.Hide();
            ClearLoginLabels();
            gb2SignUp.Show();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            gb2lblEmail.Text = "";
        }

        private void LlLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gb2SignUp.Hide();
            ClearSignUpLabels();
            gbLogin.Show();

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection (CS))
            {
                SqlCommand cmd = new SqlCommand("addUsers", con);

                cmd.CommandType = CommandType.StoredProcedure;
                
                
                #region Sign Up Validation
                if (gb2Username.Text == "")
                {
                    gb2lblusername.Text = "*";
                }
                if (gb2Password.Text == "")
                {
                    gb2lblpassword.Text = "*";
                }
               if (gb2Email.Text == "")
                {
                    gb2lblEmail.Text = "*";
                }
                if (gb2Phone.Text == "")
                {
                    gb2lblPhone.Text = "*";
                }
                if (gb2Firstname.Text == "")
                {
                    gb2lblfirestname.Text = "*";
                }
                if (gb2Lastname.Text == "")
                {
                    gb2lbllastname.Text = "*";
                }
                if (gb2Idnumber.Text == "")
                {
                    gb2lblidnumber.Text = "*";
                }
                if (gb2Officeid.Text == "")
                {
                    gb2lblofficeid.Text = "*";
                }

                #endregion
                else {
                    if (gb2Username.Text != "" && gb2Password.Text!=""&&gb2Email.Text!=""&&gb2Phone.Text!=""&&gb2Firstname.Text!=""&&gb2Lastname.Text!=""&&gb2Idnumber.Text!=""&&gb2Officeid.Text!="")
                    {
                        cmd.Parameters.AddWithValue("@Username", gb2Firstname.Text);
                        cmd.Parameters.AddWithValue("@Password", gb2Password.Text);
                        cmd.Parameters.AddWithValue("@Email", gb2Email.Text);
                        cmd.Parameters.AddWithValue("@Phone", gb2Phone.Text);
                        cmd.Parameters.AddWithValue("@Firstname", gb2Firstname.Text);
                        cmd.Parameters.AddWithValue("@Lastname", gb2Lastname.Text);
                        cmd.Parameters.AddWithValue("@Id_Number", gb2Idnumber.Text);
                        cmd.Parameters.AddWithValue("@Office_Id", gb2Officeid.Text);

                        SqlParameter sp = new SqlParameter();
                        sp.ParameterName = "@Id";
                        sp.SqlDbType = SqlDbType.Int;
                        sp.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(sp);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        if (Convert.ToInt32(sp.Value) >0)
                        {
                            MessageBox.Show("Data Saved Successfully!!");
                        }
                    }
                }

               } 
        }

        private void Gb2Username_TextChanged(object sender, EventArgs e)
        {
            gb2lblusername.Text = "";
        }

        private void Gb2Password_TextChanged(object sender, EventArgs e)
        {
            gb2lblpassword.Text = "";
        }

        private void Gb2Phone_TextChanged(object sender, EventArgs e)
        {
            gb2lblPhone.Text = "";
        }

        private void Gb2Firstname_TextChanged(object sender, EventArgs e)
        {
            gb2lblfirestname.Text = "";
        }

        private void Gb2Lastname_TextChanged(object sender, EventArgs e)
        {
            gb2lbllastname.Text = "";
        }

        private void Gb2Idnumber_TextChanged(object sender, EventArgs e)
        {
            gb2lblidnumber.Text = "";
        }

        private void Gb2Officeid_TextChanged(object sender, EventArgs e)
        {
            gb2lblofficeid.Text = "";
        }

        private void Gb2Idnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void BtnProductMain_Click(object sender, EventArgs e)
        {
            gbMain.Visible = false;
            gbProdList.Visible = true;
        }

        private void BtnCategoryMain_Click(object sender, EventArgs e)
        {
            gbMain.Visible = false;
            gbCatList.Visible = true;
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            gbMain.Visible = true;
            gbProdList.Visible = false;
        }

        private void Label13_Click(object sender, EventArgs e)
        {
            gbMain.Visible = true;
            gbCatList.Visible = false;
        }

        private void BtnAddProd_Click(object sender, EventArgs e)
        {
            Create_Product create_Product = new Create_Product();
            create_Product.Show();
        }

        private void Btnshowproducts_Click(object sender, EventArgs e)
        {
            AllProducts allProducts = new AllProducts();
            allProducts.Show();
        }
    }
}
