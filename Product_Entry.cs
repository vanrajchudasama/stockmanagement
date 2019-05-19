using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace stock_management_system
{
    public partial class Product_Entry : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        MemoryStream ms;
        SqlDataReader dr;

        public Product_Entry()
        {
            i = db.connection();

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void countdata()
        {
            int c = 1;
            cmd = new SqlCommand("select id from Product_Entry", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c = c + 1;
            }
            dr.Close();
            if (c < 10)
            {
                txtpid.Text = "PI-0" + c.ToString();
            }
            else
            {
                txtpid.Text = "PI-" + c.ToString();
            }
        }
        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }





        private void btnregitration_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }


        private void btnpsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpid.Text == string.Empty || txtprnm.Text == string.Empty || cmbpcategory.Text == string.Empty || txtpsell.Text == string.Empty || txtdescription.Text == string.Empty || txtpcost.Text == string.Empty || txtpsell.Text == string.Empty || txtpreorder.Text == string.Empty || txtpos.Text == string.Empty || txtpdiscount.Text == string.Empty || txtpgst.Text == string.Empty)
                {

                    MessageBox.Show("Please Fill Record...!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {

                    cmd = new SqlCommand("insert into Product_Entry(id, product_nm,category,subcat,description,cost_p,selling_p,reorder_p,opening_stock,discount,gst,date,img)values('" + txtpid.Text + "','" + txtprnm.Text + "','" + cmbpcategory.Text + "','" + cmbpsubcat.Text + "','" + txtdescription.Text + "','" + txtpcost.Text + "','" + txtpsell.Text + "','" + txtpreorder.Text + "','" + txtpos.Text + "','" + txtpdiscount.Text + "','" + txtpgst.Text + "','" + txtpdate.Text + "',@image)", db.cn);
                    cmd.Parameters.AddWithValue("image", savePhoto1(pictureBox1));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("save");
                    countdata();
                    txtprnm.Clear();
                    cmbpcategory.SelectedIndex = 0;
                    cmbpsubcat.SelectedIndex = 0;
                    txtdescription.Clear();
                    txtpdiscount.Clear();
                    txtpcost.Clear();
                    txtpgst.Clear();
                    txtpos.Clear();
                    txtpreorder.Clear();
                    txtpsell.Clear();


                }
            }
            catch (Exception)
            {
                //MessageBox.Show("ddf");
            }

        }

        private void Product_Entry_Load(object sender, EventArgs e)
        {
            countdata();
            txtpdate.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void txtpcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtpsell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtpreorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtpos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtpdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtpgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtprnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnrclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();

            }


        }

        private void btnget_Click(object sender, EventArgs e)
        {
            
            List_of_product product = new List_of_product();
            product.ShowDialog();

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Navy;


        }
    }

}
       
       
    

