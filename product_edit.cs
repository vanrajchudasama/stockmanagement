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
    public partial class product_edit : Form
    {

        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        // MemoryStream ms;
        SqlDataReader dr;
        public product_edit()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void product_edit_Load(object sender, EventArgs e)
        {
            cmbadd_record();

        }
        void cmbadd_record()
        {
            cmbupid.Items.Clear();
            cmd = new SqlCommand("select id from Product_entry", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cmbupid.Items.Add(dr["id"].ToString());
            }
            dr.Close();
        }



        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void cmbupid_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Product_entry where id='" + cmbupid.SelectedItem + "'", db.cn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtupid.Text = dr[0].ToString();
                txtupnm.Text = dr[1].ToString();
                cmbupcategory.SelectedItem = dr[2].ToString();
                cmbupsubcat.SelectedItem = dr[3].ToString();
                txtudescription.Text = dr[4].ToString();
                txtupcost.Text = dr[5].ToString();
                txtupsell.Text = dr[6].ToString();
                txtupreorder.Text = dr[7].ToString();
                txtupos.Text = dr[8].ToString();
                txtupdiscount.Text = dr[9].ToString();
                txtupgst.Text = dr[10].ToString();
                txtupdate.Text = dr[11].ToString();
                byte[] img = ((byte[])dr[12]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                // pictureBox1.Image = DisPhoto((byte []) dr[9]);

            }
            dr.Close();

        }




        private void txtupnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void txtupcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtupsell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtupreorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtupreorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtupdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtupgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtupid.Text == "")
            {
                MessageBox.Show("Please Select Id");
            }
            else
            {
                if (txtupnm.Text == "" || txtudescription.Text == "" || txtupcost.Text == "" || txtupsell.Text == "" || txtupreorder.Text == "" || txtupos.Text == "" || txtupdiscount.Text == "" || txtupgst.Text == "")
                {
                    MessageBox.Show("Please Insert Record......!");

                }

                else
                {
                    cmd = new SqlCommand("update Product_entry set product_nm='" + txtupnm.Text + "',category='" + cmbupcategory.SelectedItem + "',subcat='" + cmbupsubcat.SelectedItem + "',description='" + txtudescription.Text + "',cost_p='" + txtupcost.Text + "',selling_p='" + txtupsell.Text + "',reorder_p='" + txtupreorder.Text + "',opening_stock='" + txtupos.Text + "',discount='" + txtupdiscount.Text + "',gst='" + txtupgst.Text + "',date='" + txtupdate.Text + "',img=@Img where id='" + txtupid.Text + "'", db.cn);
                    cmd.Parameters.AddWithValue("Img", savePhoto1(pictureBox1));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update");

                    cmbadd_record();
                    txtupid.Clear();
                    txtupnm.Clear();
                    //cmbupcategory.SelectedIndex = 0;
                    //cmbupsubcat.SelectedIndex = 0;
                    txtudescription.Clear();
                    txtupcost.Clear();
                    txtupsell.Clear();
                    txtupreorder.Clear();
                    txtupdiscount.Clear();
                    txtupgst.Clear();
                    txtupos.Clear();
                    txtupdate.Clear();


                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtupid.Text == "")
            {
                MessageBox.Show("Please Select Id");
            }
            else
            {
                cmbadd_record();
                DialogResult result = MessageBox.Show("Aru you sure Delete.....!", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete from product_entry where id='" + txtupid.Text + "'", db.cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record is Delete", "Information", MessageBoxButtons.OK);
                    cmbadd_record();
                    txtupid.Clear();
                    txtupnm.Clear();
                    //cmbupcategory.SelectedIndex = 0;
                    //cmbupsubcat.SelectedIndex = 0;
                    txtudescription.Clear();
                    txtupcost.Clear();
                    txtupsell.Clear();
                    txtupreorder.Clear();
                    txtupdiscount.Clear();
                    txtupgst.Clear();
                    txtupos.Clear();
                    txtupdate.Clear();



                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
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







    
