using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace stock_management_system
{
    public partial class Company_Registration : Form
    {

        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        SqlDataReader dr;
        MemoryStream ms;
        public Company_Registration()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void btncew_Click(object sender, EventArgs e)
        {
           // txtcoid.Clear();
            txtconm.Clear();
            txtcoaddress.Clear();
            txtcocontact.Clear();
            txtcoemail.Clear();
            cmbcocity.Text = "";
            cmbcostate.Text = "";
            cmbcocounty.Text = "";
            txtcopincode.Clear();
            txtcogst.Clear();
            txtcoid.Focus();
        }

        private void btncbrows_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                companyimg.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            companyimg.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void Company_Registration_Load(object sender, EventArgs e)
        {
            txtcodate.Text = DateTime.Now.ToString("dd/MM/yyyy");
          
            cmbcocity.SelectedIndex = 0;
            cmbcostate.SelectedIndex = 0;
            cmbcocounty.SelectedIndex = 0;
            countdata();
        }
        void countdata()
        {
            int c = 1;
            cmd = new SqlCommand("select id from company_info", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c = c + 1;
            }
            dr.Close();
            if (c < 10)
            {
                txtcoid.Text = "CI-0" + c.ToString();
            }
            else
            {
                txtcoid.Text = "CI-" + c.ToString();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btncclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btncosave_Click(object sender, EventArgs e)
        {

            if (txtcoid.Text == "" || txtconm.Text == "" || txtcoaddress.Text == "" || txtcocontact.Text == "" || txtcoemail.Text == "" || cmbcocity.Text == "" || cmbcostate.Text == "" || cmbcocounty.Text == "" || txtcopincode.Text == "" || txtcogst.Text == "")
            {
                MessageBox.Show("please insert Record.....!");

            }
            else
            {
                System.Text.RegularExpressions.Regex remail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-z0-9][\w\.-]*[a-zA-z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                if (txtcoemail.Text.Length > 0)
                {
                    if (!remail.IsMatch(txtcoemail.Text))
                    {
                        MessageBox.Show("Invalid Email..!");
                        txtcoemail.SelectAll();
                    }
                    else
                    {

                        cmd = new SqlCommand("insert into company_info (id,company_name,address,contact_no,email_id,city,state,country,date,pincode,gst,img) values('" + txtcoid.Text + "','" + txtconm.Text + "','" + txtcoaddress.Text + "','" + txtcocontact.Text + "','" + txtcoemail.Text + "','" + cmbcocity.SelectedItem + "','" + cmbcostate.SelectedItem + "','" + cmbcocounty.SelectedItem + "','"+txtcodate.Text+"' ,'"+ txtcopincode.Text + "','" + txtcogst.Text + "',@img)", db.cn);
                        //conv_photo();
                        cmd.Parameters.AddWithValue("img", savePhoto1(companyimg));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record save");
                        txtconm.Clear();
                        txtcoaddress.Clear();
                        txtcocontact.Clear();
                        txtcoemail.Clear();
                        cmbcocity.Text = "";
                        cmbcostate.Text = "";
                        cmbcocounty.Text = "";
                        txtcopincode.Clear();
                        txtcogst.Clear();
                        txtcoid.Focus();
                        countdata();

                    }
                }
            }


            }
        private void cmbcocity_Enter(object sender, EventArgs e)
        {

            if (cmbcocity.SelectedIndex == 0)
            {
                cmbcocity.Text = "";
            }
        }

        private void cmbcocity_Leave(object sender, EventArgs e)
        {
            if (cmbcocity.Text == "")
            {
                cmbcocity.Text = "Select City";
            }
        }

        private void cmbcostate_Enter(object sender, EventArgs e)
        {
            if (cmbcostate.SelectedIndex == 0)
            {
                cmbcostate.Text = "";
            }
        }

        private void cmbcostate_Leave(object sender, EventArgs e)
        {
            if (cmbcostate.Text == "")
            {
                cmbcostate.Text = "Select State";
            }
        }

        private void cmbcocounty_Enter(object sender, EventArgs e)
        {
            if (cmbcocounty.SelectedIndex == 0)
            {
                cmbcocounty.Text = "";
            }
        }

        private void cmbcocounty_Leave(object sender, EventArgs e)
        {
             if (cmbcocounty.Text == "")
            {
                cmbcocounty.Text = "Select Country";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Navy;
        }

        private void txtconm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void txtcopincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcogst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {


            }
        }

        private void txtconm_Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;
        }

        private void txtconm_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.White;
        }

        private void txtcocontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        }
        }
    

