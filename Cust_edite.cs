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
    public partial class Cust_edite : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
       // MemoryStream ms;
        SqlDataReader dr;


        public Cust_edite()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cust_edite_Load(object sender, EventArgs e)
        {
            cmbadd_record();
            //rdbm.Checked = true;
            //txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbcity.SelectedIndex = 0;
            cmbstate.SelectedIndex = 0;
            cmbcountry.SelectedIndex = 0;
           
        }
        void cmbadd_record()
        {
            cmbid.Items.Clear();
            cmd = new SqlCommand("select cust_id from cust_regitration", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read() )
            {
              
                cmbid.Items.Add(dr["cust_id"].ToString());
            }
            dr.Close();
        }
      

        

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtid.ReadOnly = true;
            cmd = new SqlCommand("select *from cust_regitration where cust_id='" + cmbid.SelectedItem + "'", db.cn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtid.Text = dr[0].ToString();
                txtname.Text = dr[1].ToString();
                if (dr[2].ToString() == "Male")
                {
                    rdbm.Checked = true;
                }
                else if (dr[2].ToString() == "Female")
                {
                    rdbf.Checked = true;
                }
                else
                {
                    rdbo.Checked = true;
                }
                txtaddress.Text = dr[3].ToString();
                txtaadhar.Text = dr[4].ToString();
                cmbcity.SelectedItem = dr[5].ToString();
             //   cmbcity.SelectedText= dr[5].ToString();
                cmbstate.SelectedItem = dr[6].ToString();
                cmbcountry.SelectedItem = dr[7].ToString();
                txtdate.Text = dr[8].ToString();
                txtpin.Text = dr[9].ToString();
                txtcontact.Text = dr[10].ToString();
                //pictureBox1.Image = DisPhoto((byte[])dr[9]);
                txtemail.Text = dr[11].ToString();
                byte[] img = ((byte[])dr[12]);
                MemoryStream ms=new MemoryStream(img);
                pictureBox1.Image=Image.FromStream(ms);
            }
            dr.Close();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please Select Id");
            }
            else
            {
               
                   
                if (rdbm.Checked == true)
                {
                    if (txtname.Text == string.Empty || txtaddress.Text == string.Empty || txtaadhar.Text == string.Empty || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpin.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
                    {
                        MessageBox.Show("Please Insert Record......!");




                    }
                    else
                    {
                        if (cmbcity.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please Select City...!");
                        }
                        else if (cmbstate.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please Select State...!");
                        }
                        else if (cmbcountry.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please Select Country...!");
                        }
                        else
                        {

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
                                    cmd = new SqlCommand("update cust_regitration set cust_id='" + txtid.Text + "',cust_name='" + txtname.Text + "',cust_gender='" + rdbm.Text + "',cust_add='" + txtaddress.Text + "',cust_aadhar='" + txtaadhar.Text + "',cust_city='" + cmbcity.SelectedItem + "',cust_state='" + cmbstate.SelectedItem + "',cust_country='" + cmbcountry.SelectedItem + "',cust_pin='" + txtpin.Text + "',cust_contact='" + txtcontact.Text + "',cust_email='" + txtemail.Text + "',cust_img=@Image where cust_id='" + txtid.Text + "'", db.cn);
                                    cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Record Update");
                                    txtid.Clear();
                                    txtname.Clear();
                                    txtaddress.Clear();
                                    txtaadhar.Clear();
                                    rdbm.Checked = false;
                                    rdbf.Checked = false;
                                    rdbo.Checked = false;


                                    txtdate.Clear();

                                    cmbcity.SelectedIndex = 0;
                                    cmbstate.SelectedIndex = 0;
                                    cmbcountry.SelectedIndex = 0;
                                    txtpin.Clear();
                                    txtcontact.Clear();
                                    txtemail.Clear();
                                }
                            }
                        }
                    }


                }
                else if (rdbf.Checked == true)
                {
                    if (txtname.Text == string.Empty || txtaddress.Text == string.Empty || txtaadhar.Text == string.Empty || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpin.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
                    {
                        MessageBox.Show("Please Insert Record......!");




                    }

                    else
                    {
                         if (cmbcity.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please Select City...!");
                        }
                        else if (cmbstate.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please Select State...!");
                        }
                         else if (cmbcountry.SelectedIndex == 0)
                         {
                             MessageBox.Show("Please Select Country...!");
                         }
                         else
                         {
                             cmd = new SqlCommand("update cust_regitration set cust_id='" + txtid.Text + "',cust_name='" + txtname.Text + "',cust_gender='" + rdbf.Text + "',cust_add='" + txtaddress.Text + "',cust_aadhar='" + txtaadhar.Text + "',cust_city='" + cmbcity.SelectedItem + "',cust_state='" + cmbstate.SelectedItem + "',cust_country='" + cmbcountry.SelectedItem + "',cust_pin='" + txtpin.Text + "',cust_contact='" + txtcontact.Text + "',cust_email='" + txtemail.Text + "',cust_img=@Image where cust_id='" + txtid.Text + "'", db.cn);
                             cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                             cmd.ExecuteNonQuery();
                             MessageBox.Show("Record Update");
                             txtid.Clear();
                             txtname.Clear();
                             txtaddress.Clear();
                             txtaadhar.Clear();
                             rdbm.Checked = false;
                             rdbf.Checked = false;
                             rdbo.Checked = false;


                             txtdate.Clear();
                             cmbcity.SelectedIndex = 0;
                             cmbstate.SelectedIndex = 0;
                             cmbcountry.SelectedIndex = 0;
                             txtpin.Clear();
                             txtcontact.Clear();
                             txtemail.Clear();
                         }
                    }
                

                }
                else if (rdbo.Checked == true)
                {
                    if (txtname.Text == string.Empty || txtaddress.Text == string.Empty || txtaadhar.Text == string.Empty || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpin.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
                    {
                        MessageBox.Show("Please Insert Record......!");




                    }
                    else
                    {
                        if (cmbcity.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please Select City...!");
                        }
                        else if (cmbstate.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please Select State...!");
                        }
                        else if (cmbcountry.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please Select Country...!");
                        }
                        else
                        {
                            cmd = new SqlCommand("update cust_regitration set cust_id='" + txtid.Text + "',cust_name='" + txtname.Text + "',cust_gender='" + rdbo.Text + "',cust_add='" + txtaddress.Text + "',cust_aadhar='" + txtaadhar.Text + "',cust_city='" + cmbcity.SelectedItem + "',cust_state='" + cmbstate.SelectedItem + "',cust_country='" + cmbcountry.SelectedItem + "',cust_pin='" + txtpin.Text + "',cust_contact='" + txtcontact.Text + "',cust_email='" + txtemail.Text + "',cust_img=@Image where cust_id='" + txtid.Text + "'", db.cn);
                            cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Update");
                            txtid.Clear();
                            txtdate.Clear();
                            txtname.Clear();
                            txtaddress.Clear();
                            txtaadhar.Clear();
                            rdbm.Checked = false;
                            rdbf.Checked = false;
                            rdbo.Checked = false;



                            cmbcity.SelectedIndex = 0;
                            cmbstate.SelectedIndex = 0;
                            cmbcountry.SelectedIndex = 0;
                            txtpin.Clear();
                            txtcontact.Clear();
                            txtemail.Clear();
                        }
                    }
                }
            }
        }
        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            //pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("Please Select Id");
                }
                else
                {
                    DialogResult d = MessageBox.Show("Are you sure Delete record..!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("delete from cust_regitration where cust_id='" + txtid.Text + "'", db.cn);
                        cmd.ExecuteNonQuery();
                        //cmbadd_record();
                        txtname.Clear();
                        txtaddress.Clear();
                        txtaadhar.Clear();
                        rdbm.Checked = false;
                        rdbf.Checked = false;
                        rdbo.Checked = false;



                        cmbcity.SelectedIndex = 0;
                        cmbstate.SelectedIndex = 0;
                        cmbcountry.SelectedIndex = 0;
                        txtpin.Clear();
                        txtcontact.Clear();
                        txtemail.Clear();
                        //pictureBox1.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Record not Delete..!");
                    }
                }
            }
            catch (Exception)
            {
                cmbadd_record();
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
            list_of_customer lu = new list_of_customer();
            lu.ShowDialog();
        }

        private void txtdate_Enter(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.Yellow;

        }

        private void txtdate_Leave(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.White;

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void txtaadhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cmbcity_Enter(object sender, EventArgs e)
        {
            if (cmbcity.SelectedIndex == 0)
            {
                cmbcity.Text = "";
            }
        }

        private void cmbstate_Enter(object sender, EventArgs e)
        {
            if (cmbstate.SelectedIndex == 0)
            {
                cmbstate.Text = "";
            }
        }

        private void cmbcountry_Enter(object sender, EventArgs e)
        {
            if (cmbcountry.SelectedIndex == 0)
            {
                cmbcountry.Text = "";
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
            if (cmbstate.Text == "")
            {
                cmbstate.Text = "Select State";
            }
        }

        private void cmbcountry_Leave(object sender, EventArgs e)
        {
            if (cmbcountry.Text == "")
            {
                cmbcountry.Text = "Select Country";
            }
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
            txtcontact.BackColor = Color.Yellow;

        }

        private void txtcontact_Leave(object sender, EventArgs e)
        {
            txtcontact.BackColor = Color.White;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
