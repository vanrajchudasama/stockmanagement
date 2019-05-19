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
    public partial class Supplier_Regitration : Form
    {

        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        MemoryStream ms;
        SqlDataReader dr;


        public Supplier_Regitration()
        {
            i = db.connection();
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Supplier_Regitration_Load(object sender, EventArgs e)
        {
            rdom.Checked = true;
            txtsdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbscity.SelectedIndex = 0;
            cmbsstate.SelectedIndex = 0;
            cmbscountry.SelectedIndex = 0;
            countdata();
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
        void countdata()
        {
            int c = 1;
            cmd = new SqlCommand("select s_id from supplier_regitration", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                c = c + 1;
            }
            dr.Close();
            if (c < 10)
            {
                txtsid.Text = "CN-0" + c.ToString();
            }
            else
            {
                txtsid.Text = "CN-" + c.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            //pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }
        private void rdof_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select s_id from supplier_regitration where s_id='" + txtsid.Text + "'", db.cn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Exist=true;
                MessageBox.Show("alredy id is exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtsup_name.Clear();
                txtsaddress.Clear();
                txtsaadhar.Clear();
                rdom.Checked = false;
                rdof.Checked = false;
                rdoo.Checked = false;



                cmbscity.SelectedIndex = 0;
                cmbsstate.SelectedIndex = 0;
                cmbscountry.SelectedIndex = 0;
                txtspincode.Clear();
                txtscontact.Clear();
                txtsemail.Clear();

            }

            else
            {

                if (txtsup_name.Text == string.Empty || txtsaddress.Text == string.Empty || txtsaadhar.Text == string.Empty || cmbscity.Text == string.Empty || cmbsstate.Text == string.Empty || cmbscountry.Text == string.Empty || txtspincode.Text == string.Empty || txtscontact.Text == string.Empty || txtsemail.Text == string.Empty)
                {
                    MessageBox.Show("Please Insert Record......!");




                }
                else
                {

                    if (cmbscity.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select City");
                    }
                    else if (cmbsstate.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select State");
                    }
                    else if (cmbscountry.SelectedIndex == 0)
                    {

                        MessageBox.Show("Please Select Country");
                    }
                    else
                    {

                        dr.Close();

                        System.Text.RegularExpressions.Regex remail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-z0-9][\w\.-]*[a-zA-z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                        if (txtsemail.Text.Length > 0)
                        {
                            if (!remail.IsMatch(txtsemail.Text))
                            {
                                MessageBox.Show("Invalid Email..!");
                                txtsemail.SelectAll();
                            }
                            else
                            {

                                cmd = new SqlCommand("insert into supplier_regitration(s_id, s_name,s_gender,s_address,s_aadhar,s_city,s_state,s_country,s_date,s_pin,s_contact,s_email,s_img) values ('" + txtsid.Text + "','" + txtsup_name.Text + "','" + checkGen() + "','" + txtsaddress.Text + "','" + txtsaadhar.Text + "','" + cmbscity.SelectedItem + "','" + cmbsstate.SelectedItem + "','" + cmbscountry.SelectedItem + "','" + txtsdate.Text + "','" + txtspincode.Text + "','" + txtscontact.Text + "','" + txtsemail.Text + "',@Image)", db.cn);
                                //conv_photo();

                                cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                                //cmd.Parameters.AddWithValue("image",savePhoto1(pictureBox1));



                                txtsid.Clear();
                                //autoId();
                                //getData();

                                txtsup_name.Clear();
                                txtsaddress.Clear();
                                txtsaadhar.Clear();
                                cmbscity.SelectedText = "";
                                cmbsstate.SelectedText = "";
                                cmbscountry.SelectedText = "";
                                txtspincode.Clear();
                                txtscontact.Clear();
                                txtsemail.Clear();

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Save Record");
                                txtsup_name.Clear();
                                txtsaddress.Clear();
                                txtsaadhar.Clear();
                                rdom.Checked = false;
                                rdof.Checked = false;
                                rdoo.Checked = false;



                                cmbscity.SelectedIndex = 0;
                                cmbsstate.SelectedIndex = 0;
                                cmbscountry.SelectedIndex = 0;
                                txtspincode.Clear();
                                txtscontact.Clear();
                                txtsemail.Clear();
                                //comboBox2.SelectedIndex = 0;
                            }


                        }

                    }

                    dr.Close();
                    countdata();
                    rdom.Checked = true;

                }


            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtsid.Clear();
            txtsup_name.Clear();
            rdom.Checked = true;
            rdof.Checked = false;
            rdoo.Checked = false;

            txtsaddress.Clear();
            txtsaadhar.Clear();
            cmbscity.SelectedIndex = 0;
            cmbsstate.SelectedIndex = 0;
            cmbscountry.SelectedIndex = 0;
            txtspincode.Clear();
            txtscontact.Clear();
            txtsemail.Clear();
            countdata();
        }

        private void txtsup_name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtscontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtspincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtsaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsup_name_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void cmbscity_Leave(object sender, EventArgs e)
        {
            if (cmbscity.Text == "")
            {
                cmbscity.Text = "Select City";
            }
        }

        private void cmbsstate_Leave(object sender, EventArgs e)
        {
            if (cmbsstate.Text == "")
            {
                cmbsstate.Text = "Select State";
            }
        }

        private void cmbscountry_Leave(object sender, EventArgs e)
        {
            if (cmbscountry.Text == "")
            {
                cmbscountry.Text = "Select Country";
            }
        }

        private void cmbscity_Enter(object sender, EventArgs e)
        {
            if (cmbscity.SelectedIndex == 0)
            {
                cmbscity.Text = "";
            }
        }

        private void cmbsstate_Enter(object sender, EventArgs e)
        {
            if (cmbsstate.SelectedIndex == 0)
            {
                cmbsstate.Text = "";
            }
        }

        private void cmbscountry_Enter(object sender, EventArgs e)
        {
            if (cmbscountry.SelectedIndex == 0)
            {
                cmbscountry.Text = "";
            }
        }

        private void txtsid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbsstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsemail_Enter(object sender, EventArgs e)
        {

        }

        private void txtsdate_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txtsaddress_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;
        }

        private void txtsaddress_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txtsaadhar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtscontact_Enter(object sender, EventArgs e)
        {
            txtscontact.BackColor = Color.Yellow;

        }

        private void txtscontact_Leave(object sender, EventArgs e)
        {
            txtscontact.BackColor = Color.White;

        }

        private void txtsaadhar_Enter(object sender, EventArgs e)
        {
            txtsaadhar.BackColor = Color.Yellow;

        }

        private void txtsaadhar_Leave(object sender, EventArgs e)
        {
            txtsaadhar.BackColor = Color.White;

        }

        private void btngetdata_Click(object sender, EventArgs e)
        {
            list_of_supplier list = new list_of_supplier();
            list.ShowDialog();

        }

        private void txtsup_name_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{

            //    if (this.GetNextControl(ActiveControl, true) != null)
            //    {
            //        e.Handled = false;
            //        this.GetNextControl(ActiveControl, true).Focus();
            //    }
            //}
        }

        private void txtscontact_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtscontact_Enter_1(object sender, EventArgs e)
        {
            txtscontact.BackColor = Color.Yellow;

        }

        private void txtscontact_Leave_1(object sender, EventArgs e)
        {
            txtscontact.BackColor = Color.White;
        }

       

        private void label15_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            label15.BackColor = Color.Red;

        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.BackColor = Color.Navy;
        }

        
            
    }
}
