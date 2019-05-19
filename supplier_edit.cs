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
    public partial class supplier_edit : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        MemoryStream ms;
        SqlDataReader dr;
        public supplier_edit()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void supplier_edit_Load(object sender, EventArgs e)
        {
            cmbadd_record();
          
           // txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbcity.SelectedIndex = 0;
            cmbstate.SelectedIndex = 0;
            cmbcountry.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void cmbadd_record()
        {
            cmbsid.Items.Clear();
            cmd = new SqlCommand("select s_id from supplier_regitration", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cmbsid.Items.Add(dr["s_id"].ToString());
            }
            dr.Close();
        }
      
        private void cmbsid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rdbo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbcountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbcity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtaadhar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdbm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            //pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }
        
       

        private void btnbwose_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

       

        private void cmbsid_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtsid.ReadOnly = true;
            cmd = new SqlCommand("select *from supplier_regitration where s_id='" + cmbsid.SelectedItem + "'", db.cn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtsid.Text = dr[0].ToString();
                txtsname.Text = dr[1].ToString();
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
                txtsadd.Text = dr[3].ToString();
                txtsaadhar.Text = dr[4].ToString();
                cmbcity.SelectedItem = dr[5].ToString();
                //   cmbcity.SelectedText= dr[5].ToString();
                cmbstate.SelectedItem = dr[6].ToString();
                cmbcountry.SelectedItem = dr[7].ToString();
                txtdate.Text = dr[8].ToString();
                txtpincode.Text = dr[9].ToString();
                txtcontact.Text = dr[10].ToString();
                //pictureBox1.Image = DisPhoto((byte[])dr[9]);
                txtemail.Text = dr[11].ToString();
                byte[] img = ((byte[])dr[12]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            dr.Close();
        }

        private void btnsdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsid.Text == "")
                {
                    MessageBox.Show("Please Select Id");
                }
                else
                {
                    DialogResult d = MessageBox.Show("Are you sure Delete record..!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("delete from supplier_regitration where s_id='" + txtsid.Text + "'", db.cn);
                        cmd.ExecuteNonQuery();
                        //cmbadd_record();
                        txtsid.Clear();
                        txtsname.Clear();
                        txtsadd.Clear();
                        txtsaadhar.Clear();
                        rdbm.Checked = false;
                        rdbf.Checked = false;
                        rdbo.Checked = false;



                        cmbcity.SelectedIndex = 0;
                        cmbstate.SelectedIndex = 0;
                        cmbcountry.SelectedIndex = 0;
                        txtpincode.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            list_of_supplier s = new list_of_supplier();
            s.ShowDialog();
        }

        private void btnsupdate_Click(object sender, EventArgs e)
        {
            if (txtsid.Text == "")
            {
                MessageBox.Show("Please Select Id");
            }
            else
            {
                if (rdbm.Checked == true)
                {

                    if (txtsname.Text == string.Empty || txtsadd.Text == string.Empty || txtsaadhar.Text == "" || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpincode.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
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

                                    cmd = new SqlCommand("update supplier_regitration set s_id='" + txtsid.Text + "',s_name='" + txtsname.Text + "',s_gender='" + rdbm.Text + "',s_address='" + txtsadd.Text + "',s_aadhar='" + txtsaadhar.Text + "',s_city='" + cmbcity.SelectedItem + "',s_state='" + cmbstate.SelectedItem + "',s_country='" + cmbcountry.SelectedItem + "',s_pin='" + txtpincode.Text + "',s_contact='" + txtcontact.Text + "',s_email='" + txtemail.Text + "',s_img=@Image where s_id='" + txtsid.Text + "'", db.cn);
                                    cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Record Update");
                                    txtsid.Clear();
                                    txtsname.Clear();
                                    txtsadd.Clear();
                                    txtsaadhar.Clear();
                                    rdbm.Checked = false;
                                    rdbf.Checked = false;
                                    rdbo.Checked = false;


                                    txtdate.Clear();
                                    cmbcity.SelectedIndex = 0;
                                    cmbstate.SelectedIndex = 0;
                                    cmbcountry.SelectedIndex = 0;
                                    txtpincode.Clear();
                                    txtcontact.Clear();
                                    txtemail.Clear();
                                }
                            }
                        }
                    }
                }

                else if (rdbf.Checked == true)
                {


                    if (txtsname.Text == string.Empty || txtsadd.Text == string.Empty || txtsaadhar.Text == string.Empty || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpincode.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
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

                            cmd = new SqlCommand("update supplier_regitration set s_id='" + txtsid.Text + "',s_name='" + txtsname.Text + "',s_gender='" + rdbf.Text + "',s_address='" + txtsadd.Text + "',s_aadhar='" + txtsaadhar.Text + "',s_city='" + cmbcity.SelectedItem + "',s_state='" + cmbstate.SelectedItem + "',s_country='" + cmbcountry.SelectedItem + "',s_pin='" + txtpincode.Text + "',s_contact='" + txtcontact.Text + "',s_email='" + txtemail.Text + "',s_img=@Image where s_id='" + txtsid.Text + "'", db.cn);
                            cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Update");
                            txtsid.Clear();
                            txtsname.Clear();
                            txtsadd.Clear();
                            txtsaadhar.Clear();
                            rdbm.Checked = false;
                            rdbf.Checked = false;
                            rdbo.Checked = false;


                            txtdate.Clear();
                            cmbcity.SelectedIndex = 0;
                            cmbstate.SelectedIndex = 0;
                            cmbcountry.SelectedIndex = 0;
                            txtpincode.Clear();
                            txtcontact.Clear();
                            txtemail.Clear();

                        }
                    }
                }
                else if (rdbo.Checked == true)
                {

                    if (txtsname.Text == string.Empty || txtsadd.Text == string.Empty || txtsaadhar.Text == string.Empty || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpincode.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
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
                            cmd = new SqlCommand("update supplier_regitration set s_id='" + txtsid.Text + "',s_name='" + txtsname.Text + "',s_gender='" + rdbo.Text + "',s_address='" + txtsadd.Text + "',s_aadhar='" + txtsaadhar.Text + "',s_city='" + cmbcity.SelectedItem + "',s_state='" + cmbstate.SelectedItem + "',s_country='" + cmbcountry.SelectedItem + "',s_pin='" + txtpincode.Text + "',s_contact='" + txtcontact.Text + "',s_email='" + txtemail.Text + "',s_img=@Image where s_id='" + txtsid.Text + "'", db.cn);
                            cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Update");
                            txtsid.Clear();
                            txtsname.Clear();
                            txtsadd.Clear();
                            txtsaadhar.Clear();
                            rdbm.Checked = false;
                            rdbf.Checked = false;
                            rdbo.Checked = false;


                            txtdate.Clear();
                            cmbcity.SelectedIndex = 0;
                            cmbstate.SelectedIndex = 0;
                            cmbcountry.SelectedIndex = 0;
                            txtpincode.Clear();
                            txtcontact.Clear();
                            txtemail.Clear();
                        }
                    }
                }
            }
        }         
         private void btnsview_Click(object sender, EventArgs e)
        {
            list_of_supplier s = new list_of_supplier();
            s.ShowDialog();
        }

        private void btnsclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtsname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void txtsaadhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtspin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtspin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtscontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cmbscity_Enter(object sender, EventArgs e)
        {
            if (cmbcity.SelectedIndex == 0)
            {
                cmbcity.Text = "";
            }
        }

        private void cmbsstate_Enter(object sender, EventArgs e)
        {
            if (cmbstate.SelectedIndex == 0)
            {
                cmbstate.Text = "";
            }
        }

        private void cmbscountry_Enter(object sender, EventArgs e)
        {
            if (cmbcountry.SelectedIndex == 0)
            {
                cmbcountry.Text = "";
            }
        }

        private void cmbscity_Leave(object sender, EventArgs e)
        {
            if (cmbcity.Text == "")
            {
                cmbcity.Text = "Select City";
            }
        }

        private void cmbsstate_Leave(object sender, EventArgs e)
        {
            if (cmbstate.Text == "")
            {
                cmbstate.Text = "Select State";
            }
        }

        private void cmbscountry_Leave(object sender, EventArgs e)
        {
            if (cmbcountry.Text == "")
            {
                cmbcountry.Text = "Select Country";
            }
        }

        private void cmbscity_Enter_1(object sender, EventArgs e)
        {
            if (cmbcity.SelectedIndex == 0)
            {
                cmbcity.Text = "";
            }
        }

        private void cmbsstate_Enter_1(object sender, EventArgs e)
        {
            if (cmbstate.SelectedIndex == 0)
            {
                cmbstate.Text = "";
            }
        }

        private void cmbscountry_Enter_1(object sender, EventArgs e)
        {
            if (cmbcountry.SelectedIndex == 0)
            {
                cmbcountry.Text = "";
            }
        }

        private void txtsemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsname_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;
        }

        private void txtsname_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txtscontact_Enter(object sender, EventArgs e)
        {
            txtcontact.BackColor = Color.Yellow;

        }

        private void txtscontact_Leave(object sender, EventArgs e)
        {
            txtcontact.BackColor = Color.White;

        }

        private void txtsaadhar_Enter(object sender, EventArgs e)
        {
            txtsaadhar.BackColor = Color.Yellow;

        }

        private void txtsaadhar_Leave(object sender, EventArgs e)
        {
            txtsaadhar.BackColor = Color.White;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcontact_Enter(object sender, EventArgs e)
        {
            txtcontact.BackColor = Color.Yellow;
        }

        private void txtcontact_Leave(object sender, EventArgs e)
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
