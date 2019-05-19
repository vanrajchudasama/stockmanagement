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
    public partial class customet_regitration : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        MemoryStream ms;
        SqlDataReader dr;



          
        public customet_regitration()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customet_regitration_Load(object sender, EventArgs e)
        {
            rdom.Checked = true;
            txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbcity.SelectedIndex = 0;
            cmbstate.SelectedIndex = 0;
            cmbcountry.SelectedIndex = 0;
            countdata();
        }

        void countdata()
        {
            int c = 1;
            cmd = new SqlCommand("select cust_id from cust_regitration", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c =c + 1;
            }
            dr.Close();
            if (c < 10)
            {
                txtcid.Text = "CN-0"+c.ToString();
            }
            else
            {
                txtcid.Text = "CN-" + c.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            list_of_customer lu = new list_of_customer();
            lu.ShowDialog();
        }
        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            //pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }
       

        private void txtpincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        string gen;
        public string  checkGen()
        {
            if (rdof.Checked)
            {
                gen = "Female";
            }
            else if (rdom.Checked)
            {
                gen = "Male";
            }
            else
            {
                gen = "Other";
            }
            return gen;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select cust_id from cust_regitration where cust_id='" + txtcid.Text + "'", db.cn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Exist=true;
                MessageBox.Show("alredy id is exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtcust_name.Clear();
                txtaddress.Clear();
                txtaadhar.Clear();
                rdom.Checked = false;
                rdof.Checked = false;
                rdoo.Checked = false;



                cmbcity.SelectedIndex = 0;
                cmbstate.SelectedIndex = 0;
                cmbcountry.SelectedIndex = 0;
                txtpincode.Clear();
                txtcontact.Clear();
                txtemail.Clear();

            }

            else
            {

                if (txtcust_name.Text == string.Empty || txtaddress.Text == string.Empty || txtaadhar.Text == string.Empty || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpincode.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
                {
                    MessageBox.Show("Please Insert Record......!");




                }
                else
                {

                    if (cmbcity.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select City");
                    }
                    else if (cmbstate.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select State");
                    }
                    else if (cmbcountry.SelectedIndex == 0)
                    {

                        MessageBox.Show("Please Select Country");
                    }
                    else
                    {


                        dr.Close();

                        System.Text.RegularExpressions.Regex remail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-z0-9][\w\.-]*[a-zA-z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                        if (txtemail.Text.Length > 0)
                        {
                            if (!remail.IsMatch(txtemail.Text))
                            {
                                MessageBox.Show("Invalid Email..!");
                                txtemail.SelectAll();
                            }
                            else
                            {
                                cmd = new SqlCommand("insert into cust_regitration(cust_id, cust_name,cust_gender,cust_add,cust_aadhar,cust_city,cust_state,cust_country,cust_date,cust_pin,cust_contact,cust_email,cust_img) values ('" + txtcid.Text + "','" + txtcust_name.Text + "','" + checkGen() + "','" + txtaddress.Text + "','" + txtaadhar.Text + "','" + cmbcity.SelectedItem + "','" + cmbstate.SelectedItem + "','" + cmbcountry.SelectedItem + "','" + txtdate.Text + "','" + txtpincode.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "',@Image)", db.cn);
                                //conv_photo();

                                cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                                //cmd.Parameters.AddWithValue("image",savePhoto1(pictureBox1));



                                txtcid.Clear();
                                //autoId();
                                //getData();

                                txtcust_name.Clear();
                                txtaddress.Clear();
                                txtaadhar.Clear();
                                cmbcity.SelectedText = "";
                                cmbstate.SelectedText = "";
                                cmbcountry.SelectedText = "";
                                txtpincode.Clear();
                                txtcontact.Clear();
                                txtemail.Clear();

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("save");
                                txtcust_name.Clear();
                                txtaddress.Clear();
                                txtaadhar.Clear();
                                rdom.Checked = false;
                                rdof.Checked = false;
                                rdoo.Checked = false;

                            }

                            cmbcity.SelectedIndex = 0;
                            cmbstate.SelectedIndex = 0;
                            cmbcountry.SelectedIndex = 0;
                            txtpincode.Clear();
                            txtcontact.Clear();
                            txtemail.Clear();
                            //comboBox2.SelectedIndex = 0;
                        }



                    }

                    dr.Close();
                    countdata();
                    rdom.Checked = true;

                }
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }


        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbcity_Enter(object sender, EventArgs e)
        {
            if (cmbcity.SelectedIndex == 0)
            {
                cmbcity.Text= "";
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

        private void txtaadhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cmbstate_Enter(object sender, EventArgs e)
        {
            if (cmbstate.SelectedIndex == 0)
            {
                cmbstate.Text = "";
            }
        }

        private void cmbcity_Leave(object sender, EventArgs e)
        {
            if (cmbcity.Text == "")
            {
                cmbcity.Text = "Select City";
            }
        }

        private void cmbstate_Leave(object sender, EventArgs e)
        {
            if (cmbstate.Text =="")
            {
                cmbstate.Text = "Select State";
            }
        }

        private void cmbcountry_Enter(object sender, EventArgs e)
        {
            if (cmbcountry.SelectedIndex == 0)
            {
                cmbcountry.Text = "";
            }
        }

        private void cmbcountry_Leave(object sender, EventArgs e)
        {
            if (cmbcountry.Text == "")
            {
                cmbcountry.Text = "Select Country";
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
          
            txtcid.Clear();
            txtcust_name.Clear();
            rdom.Checked = true;
            rdof.Checked = false;
            rdoo.Checked = false;

            txtaddress.Clear();
            txtaadhar.Clear();
            cmbcity.SelectedIndex = 0;
            cmbstate.SelectedIndex = 0;
            cmbcountry.SelectedIndex = 0;
            txtpincode.Clear();
            txtcontact.Clear();
            txtemail.Clear();
            countdata();
        }

        private void txtccust_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtccust_name_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpincode_Enter(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.Yellow;

        }

        private void txtpincode_Leave(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.White;

        }

        private void cmbcity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtaadhar_Enter(object sender, EventArgs e)
        {
            txtaadhar.BackColor = Color.Yellow;

        }

        private void txtaadhar_Leave(object sender, EventArgs e)
        {
            txtaadhar.BackColor = Color.White;

        }

        private void txtcontact_Enter(object sender, EventArgs e)
        {
            txtcontact.BackColor = Color.White;

        }

        private void txtcontact_Leave(object sender, EventArgs e)
        {
            txtcontact.BackColor = Color.White;

        }

        private void txtcontact_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcontact_Enter_1(object sender, EventArgs e)
        {
            txtcontact.BackColor = Color.Yellow;

        }

        private void txtcontact_Leave_1(object sender, EventArgs e)
        {
            txtcontact.BackColor = Color.White;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Navy;
        }
                    
                 

           
        }

       
       
    }

