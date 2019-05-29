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
    public partial class Create_Product : Form
    {
        #region My Defined Methods
        //bool submit = false;
        public void ClearTxtBoxes()
        {
            txtProductName.Text = "";
            txtDesc.Text = "";
            txtProp.Text = "";
            txtQty.Text = "";
            txtSpecs.Text = "";
            cbCategory.SelectedIndex = 0;

        }

        #endregion


        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Create_Product()
        {
            InitializeComponent();
        }

        private void Create_Product_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("select CategoryId, category_name from Categories", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();


                cbCategory.Items.Add("Select a Category");

                cbCategory.SelectedIndex = 0;
                while (rdr.Read())
                {
                    //cbCategory.Items.Add(rdr.GetValue(1)).ToString();
                    //cbCategory.Items.Add(rdr.GetString(1));


                    cbCategory.Items.Add(rdr.GetValue(1));
                }


            }
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            ClearTxtBoxes();

        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {

            if (txtProductName.Text != "" && txtDesc.Text != "" && txtProp.Text != "" && txtQty.Text != "" && txtSpecs.Text != "" && cbCategory.SelectedIndex != 0)
            {


                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("addProduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Product_Name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
                    cmd.Parameters.AddWithValue("@Property", txtProp.Text);
                    cmd.Parameters.AddWithValue("@Specifications", txtSpecs.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQty.Text);
                   
                    cmd.Parameters.AddWithValue("@Category", cbCategory.SelectedItem);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product Added Successfully");
                    ClearTxtBoxes();

                }
            }
            else
            {
                if (cbCategory.SelectedIndex == 0)
                {
                    Categorylblmsg.Text = "Select Category or";
                    cat2lbl.Text = "add Category above";
                    addcatlink.Visible = true;
                }
                else
                {

                    MessageBox.Show("All Fields Are Required!!!");
                }

            }

        }

        private void TxtQty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       

        private void CbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex != 0)
            {
                Categorylblmsg.Text = "";
                cat2lbl.Text = "";
                addcatlink.Visible = false;
            }
        }

       
    }
}
