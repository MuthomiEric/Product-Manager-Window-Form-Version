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
    public partial class AllProducts : Form
    {
        #region My Methods
        public void ClearTxts()
        {
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
        }
    
        #endregion
        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        int i = 0;
        public AllProducts()
        {
            InitializeComponent();
        }
        public new void Refresh()
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("allProducts", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgViewAllProd.DataSource = dt;

            }
        }
        private void AllProducts_Load(object sender, EventArgs e)
        {

           
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("allProducts", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgViewAllProd.DataSource = dt;

            }
        }

        private void BtnSearchProd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from Products where Product_Name like @ProdName", connection);
                cmd.Parameters.AddWithValue("@ProdName", txtsearchprod.Text+"%");
                
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter (cmd);
                sda.Fill(dt);
               
                i = dt.Rows.Count;
                dgViewAllProd.DataSource = dt;
                if (i == 0)
                {
                    MessageBox.Show("No Record found");
                }




            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select * from Products where Category like @Category", connection);
                cmd.Parameters.AddWithValue("@Category", textBox1.Text + "%");
               
                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                i = dt.Rows.Count;
                dgViewAllProd.DataSource = dt;
                if (i==0)
                {
                    MessageBox.Show("No Record found");
                }
               



            }
        }

        private void Btnserchbyname_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void Btnsearchbycat_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
         
        }

        private void DgViewAllProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string n;
            using (SqlConnection connection = new SqlConnection(CS))
            {
                
                n = dgViewAllProd.SelectedCells[0].Value.ToString();
                if (n==null|| n=="")
                {
                    ClearTxts();
                        MessageBox.Show("Select a valid Row!!!");

                   
                }
                else
                {

                
                SqlCommand cmd = new SqlCommand("select * from Products where Product_Id="+n.ToString()+"", connection);
                cmd.Parameters.AddWithValue("@Category", textBox1.Text + "%");

                connection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    textBox9.Text = row["Product_Name"].ToString();
                    textBox8.Text = row["Description"].ToString();
                    textBox7.Text = row["Property"].ToString();
                    textBox6.Text = row["Specifications"].ToString();
                    textBox5.Text = row["Quantity"].ToString();
                    textBox4.Text = row["Category"].ToString();
                }
            }

                
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string n;
            using (SqlConnection connection = new SqlConnection(CS))
            {
                n = dgViewAllProd.SelectedCells[0].Value.ToString();
                if (n == null || n == "" || textBox9.Text == "" || textBox8.Text == "" || textBox7.Text == "" || textBox6.Text == "" || textBox5.Text == "" || textBox4.Text == "")
                {              
                    MessageBox.Show("Select a valid Row!!!");
                   
                }
                else
                {
                  
                    SqlCommand cmd = new SqlCommand("editproduct", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Product_Name", textBox9.Text);
                    cmd.Parameters.AddWithValue("@Description", textBox8.Text);
                    cmd.Parameters.AddWithValue("@Property", textBox7.Text);
                    cmd.Parameters.AddWithValue("@Specifications", textBox6.Text);
                    cmd.Parameters.AddWithValue("@Quantity", textBox5.Text);
                    cmd.Parameters.AddWithValue("@Category", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Value", n);


                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Updated successfully!!!");
                    Refresh();
                    ClearTxts();
                }
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
