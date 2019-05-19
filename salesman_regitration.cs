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
using System.Text.RegularExpressions;



namespace stock_management_system
{
    public partial class salesman_regitration : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        MemoryStream ms;
        SqlDataReader dr;


        public salesman_regitration()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
        string gen;
        public string checkGen()
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
        private void salesman_regitration_Load(object sender, EventArgs e)
        {

            rdom.Checked = true;
            txtsadate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbsacity.SelectedIndex = 0;
            cmbsastate.SelectedIndex = 0;
            cmbsacountry.SelectedIndex = 0;
            countdata();
        }

        void countdata()
        {
            int c = 1;
            cmd = new SqlCommand("select sa_id from salesman_regitration", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c = c + 1;
            }
            dr.Close();
            if (c < 10)
            {
                txtsaid.Text = "CN-0" + c.ToString();
            }
            else
            {
                txtsaid.Text = "CN-" + c.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtsaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtscontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rdof_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtsemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtspincode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbsstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            List_of_Salesman list = new List_of_Salesman();
            list.ShowDialog();

        }

        private void btnsanew_Click(object sender, EventArgs e)
        {
            txtsaid.Clear();
            txtsal_name.Clear();
            rdom.Checked = true;
            rdof.Checked = false;
            rdoo.Checked = false;

            txtsaaddress.Clear();
            txtsaadhar.Clear();
            cmbsacity.SelectedIndex = 0;
            cmbsastate.SelectedIndex = 0;
            cmbsacountry.SelectedIndex = 0;
            txtsapincode.Clear();
            txtsacontact.Clear();
            txtsaemail.Clear();
            countdata();
        }

        private void btnsasave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select sa_id from salesman_regitration where sa_id='" + txtsaid.Text + "'", db.cn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Exist=true;
                MessageBox.Show("alredy id is exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtsal_name.Clear();
                txtsaaddress.Clear();
               txtsaadhar.Clear();
                rdom.Checked = false;
                rdof.Checked = false;
                rdoo.Checked = false;



                cmbsacity.SelectedIndex = 0;
                cmbsastate.SelectedIndex = 0;
                cmbsacountry.SelectedIndex = 0;
                txtsapincode.Clear();
                txtsacontact.Clear();
                txtsaemail.Clear();

            }

            else
            {

                if (txtsal_name.Text == string.Empty || txtsaaddress.Text == string.Empty || txtsaadhar.Text == string.Empty || cmbsacity.Text == string.Empty || cmbsastate.Text == string.Empty || cmbsacountry.Text == string.Empty || txtsapincode.Text == string.Empty || txtsacontact.Text == string.Empty || txtsaemail.Text == string.Empty)
                {
                    MessageBox.Show("Please Insert Record......!");




                }
                else
                {

                    if (cmbsacity.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select City");
                    }
                    else if (cmbsastate.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select State");
                    }
                    else if (cmbsacountry.SelectedIndex == 0)
                    {

                        MessageBox.Show("Please Select Country");
                    }
                    else
                    {
                       
                            dr.Close();
                            System.Text.RegularExpressions.Regex remail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-z0-9][\w\.-]*[a-zA-z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                            if (txtsaemail.Text.Length > 0)
                            {
                                if (!remail.IsMatch(txtsaemail.Text))
                                {
                                    MessageBox.Show("Invalid Email..!");
                                    txtsaemail.SelectAll();
                                }
                                else
                                {

                                    cmd = new SqlCommand("insert into salesman_regitration(sa_id,sa_name,sa_contact,sa_address,sa_gender,sa_city,sa_state,sa_country,sa_aadhar,sa_email,sa_date,sa_pin,sa_commision,img) values ('" + txtsaid.Text + "','" + txtsal_name.Text + "','" + txtsacontact.Text + "','" + txtsaaddress.Text + "','" + checkGen() + "','" + cmbsacity.SelectedItem + "','" + cmbsastate.SelectedItem + "','" + cmbsacountry.SelectedItem + "','" + txtsaadhar.Text + "','" + txtsaemail.Text + "','" + txtsadate.Text + "','" + txtsapincode.Text + "','" + txtsacommision.Text + "',@Image)", db.cn);
                                    //conv_photo();

                                    cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                                    //cmd.Parameters.AddWithValue("image",savePhoto1(pictureBox1));



                                    txtsaid.Clear();
                                    //autoId();
                                    //getData();

                                    txtsal_name.Clear();
                                    txtsaaddress.Clear();
                                    txtsaadhar.Clear();
                                    cmbsacity.SelectedText = "";
                                    cmbsastate.SelectedText = "";
                                    cmbsacountry.SelectedText = "";
                                    txtsapincode.Clear();
                                    txtsacontact.Clear();
                                    txtsaemail.Clear();

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Save Record");
                                    txtsal_name.Clear();
                                    txtsaaddress.Clear();

                                    rdom.Checked = false;
                                    rdof.Checked = false;
                                    rdoo.Checked = false;



                                    cmbsacity.SelectedIndex = 0;
                                    cmbsastate.SelectedIndex = 0;
                                    cmbsacountry.SelectedIndex = 0;
                                    txtsapincode.Clear();
                                    txtsacontact.Clear();
                                    txtsaemail.Clear();
                                    //comboBox2.SelectedIndex = 0;

                                }
                            }

                            

                        }



                }

                dr.Close();
                countdata();
                rdom.Checked = true;

            }
        }

        private void btnsaclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnsabrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void txtsal_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void txtsacontact_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
           
        }

        private void txtsaaadhar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

           
        }

        private void txtsapincode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
           
        }

        private void txtsacommision_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
           
        }

        private void cmbsacity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void cmbsastate_Enter(object sender, EventArgs e)
        {
            if (cmbsastate.SelectedIndex == 0)
            {
                cmbsastate.Text = "";
            }
        }

        private void cmbsacountry_Enter(object sender, EventArgs e)
        {
            if (cmbsacountry.SelectedIndex == 0)
            {
                cmbsacountry.Text = "";
            }
        }

        private void cmbsacity_Leave(object sender, EventArgs e)
        {
            if (cmbsacity.Text == "")
            {
                cmbsacity.Text = "Select City";
            }
        }

        private void cmbsastate_Leave(object sender, EventArgs e)
        {
            if (cmbsastate.Text == "")
            {
                cmbsastate.Text = "Select State";
            }
        }

        private void cmbsacountry_Leave(object sender, EventArgs e)
        {
            if (cmbsacountry.Text == "")
            {
                cmbsacountry.Text = "Select Country";
            }
        }

        private void txtsapincode_Enter(object sender, EventArgs e)
        {

           
        }

        private void txtsaaadhar_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbsacity_Enter_1(object sender, EventArgs e)
        {
            if (cmbsacity.SelectedIndex == 0)
            {
                cmbsacity.Text = "";
            }
        }

        private void txtsal_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsaaadhar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsadate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsacommision_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;
        }

        private void txtsacommision_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txtsaadhar_Enter(object sender, EventArgs e)
        {
            txtsaadhar.BackColor = Color.Yellow;

        }

        private void txtsaadhar_Leave(object sender, EventArgs e)
        {
            txtsaadhar.BackColor = Color.White;
        }

        private void txtsacontact_Enter(object sender, EventArgs e)
        {
            txtsacontact.BackColor = Color.Yellow;

        }

        private void txtsacontact_Leave(object sender, EventArgs e)
        {
            txtsacontact.BackColor = Color.White;
        }

        private void txtsacontact_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtsacontact_Enter_1(object sender, EventArgs e)
        {
            txtsacontact.BackColor = Color.Yellow;

        }

        private void txtsacontact_Leave_1(object sender, EventArgs e)
        {
            txtsacontact.BackColor = Color.White;
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
