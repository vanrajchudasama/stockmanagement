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
    public partial class salesman_update : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        // MemoryStream ms;
        SqlDataReader dr;


        public salesman_update()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void salesman_Edit_Load(object sender, EventArgs e)
        {

        }

        private void txtsacontact_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        void cmbadd_record()
        {
            cmbid.Items.Clear();
            cmd = new SqlCommand("select sa_id from salesman_regitration", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cmbid.Items.Add(dr["sa_id"].ToString());
            }
            dr.Close();
        }

        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            //pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void btnsabrowse_Click(object sender, EventArgs e)
        {

        }

        private void btnsupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnsdelete_Click(object sender, EventArgs e)
        {

        }

        private void btnsclose_Click(object sender, EventArgs e)
        {

        }

        private void salesman_Edit_Load_1(object sender, EventArgs e)
        {
            cmbadd_record();
           // txtdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cmbcity.SelectedIndex = 0;
            cmbstate.SelectedIndex = 0;
            cmbcountry.SelectedIndex = 0;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnsupdate_Click_1(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please Select Id");
            }
            else
            {
                if (rdom.Checked == true)
                {
                    if (txtname.Text == string.Empty || txtadd.Text == string.Empty || txtaadhar.Text == string.Empty || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpin.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
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
                                    cmd = new SqlCommand("update salesman_regitration set sa_id='" + txtid.Text + "',sa_name='" + txtname.Text + "',sa_contact='" + txtcontact.Text + "',sa_address='" + txtid.Text + "',sa_gender='" + rdom.Text + "',sa_city='" + cmbcity.SelectedItem + "',sa_state='" + cmbstate.SelectedItem + "',sa_country='" + cmbcountry.SelectedItem + "',sa_aadhar='" + txtaadhar.Text + "',sa_email='" + txtemail.Text + "',sa_pin='" + txtpin.Text + "',sa_commision='" + txtcommision.Text + "',img=@Image where sa_id='" + txtid.Text + "'", db.cn);
                                    cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Record Update");
                                    txtname.Clear();
                                    txtadd.Clear();
                                    txtaadhar.Clear();
                                    rdom.Checked = false;
                                    rdof.Checked = false;
                                    rdoo.Checked = false;



                                    cmbcity.SelectedIndex = 0;
                                    cmbstate.SelectedIndex = 0;
                                    cmbcountry.SelectedIndex = 0;
                                    txtpin.Clear();
                                    txtcontact.Clear();
                                    txtemail.Clear();
                                    txtcommision.Clear();
                                    txtid.Clear();
                                    txtdate.Clear();


                                    cmbadd_record();
                                }
                            }
                        }
                    }
                }

                else if (rdof.Checked == true)
                {
                    if (txtname.Text == string.Empty || txtadd.Text == string.Empty || txtaadhar.Text == string.Empty || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpin.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
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

                            cmd = new SqlCommand("update salesman_regitration set sa_id='" + txtid.Text + "',sa_name='" + txtname.Text + "',sa_contact='" + txtcontact.Text + "',sa_address='" + txtadd.Text + "',sa_gender='" + rdof.Text + "',sa_city='" + cmbcity.SelectedItem + "',sa_state='" + cmbstate.SelectedItem + "',sa_country='" + cmbcountry.SelectedItem + "',sa_aadhar='" + txtaadhar.Text + "',sa_email='" + txtemail.Text + "',sa_pin='" + txtpin.Text + "',sa_commision='" + txtcommision.Text + "',img=@Image where sa_id='" + txtid.Text + "'", db.cn);
                            cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Update");
                            txtname.Clear();
                            txtadd.Clear();
                            txtaadhar.Clear();
                            rdom.Checked = false;
                            rdof.Checked = false;
                            rdoo.Checked = false;



                            cmbcity.SelectedIndex = 0;
                            cmbstate.SelectedIndex = 0;
                            cmbcountry.SelectedIndex = 0;
                            txtpin.Clear();
                            txtcontact.Clear();
                            txtemail.Clear();
                            txtcommision.Clear();
                            txtid.Clear();
                            txtdate.Clear();

                            cmbadd_record();

                        }
                    }


                }
                else if (rdoo.Checked == true)
                {
                    if (txtname.Text == string.Empty || txtadd.Text == string.Empty || txtaadhar.Text == string.Empty || cmbcity.Text == string.Empty || cmbstate.Text == string.Empty || cmbcountry.Text == string.Empty || txtpin.Text == string.Empty || txtcontact.Text == string.Empty || txtemail.Text == string.Empty)
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

                            cmd = new SqlCommand("update salesman_regitration set sa_id='" + txtid.Text + "',sa_name='" + txtname.Text + "',sa_contact='" + txtcontact.Text + "',sa_address='" + txtadd.Text + "',sa_gender='" + rdoo.Text + "',sa_city='" + cmbcity.SelectedItem + "',sa_state='" + cmbstate.SelectedItem + "',sa_country='" + cmbcountry.SelectedItem + "',sa_aadhar='" + txtaadhar.Text + "',sa_email='" + txtemail.Text + "',sa_pin='" + txtpin.Text + "',sa_commision='" + txtcommision.Text + "',img=@Image where sa_id='" + txtid.Text + "'", db.cn);
                            cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Update");

                            txtname.Clear();
                            txtadd.Clear();
                            txtaadhar.Clear();
                            rdom.Checked = false;
                            rdof.Checked = false;
                            rdoo.Checked = false;



                            cmbcity.SelectedIndex = 0;
                            cmbstate.SelectedIndex = 0;
                            cmbcountry.SelectedIndex = 0;
                            txtpin.Clear();
                            txtcontact.Clear();
                            txtemail.Clear();
                            txtcommision.Clear();
                            txtid.Clear();
                            txtdate.Clear();

                            cmbadd_record();

                        }
                    }
                }
            }

        }
       

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtid.ReadOnly = true;
            cmd = new SqlCommand("select *from salesman_regitration where sa_id='" + cmbid.SelectedItem + "'", db.cn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtid.Text = dr[0].ToString();
                txtname.Text = dr[1].ToString();
                if (dr[4].ToString() == "Male")
                {
                    rdom.Checked = true;
                }
                else if (dr[4].ToString() == "Female")
                {
                    rdof.Checked = true;
                }
                else
                {
                    rdoo.Checked = true;
                }
                txtadd.Text = dr[3].ToString();
                txtcontact.Text = dr[2].ToString();
                cmbcity.SelectedItem = dr[5].ToString();
                //   cmbcity.SelectedText= dr[5].ToString();
                cmbstate.SelectedItem = dr[6].ToString();
                cmbcountry.SelectedItem = dr[7].ToString();
                txtdate.Text = dr[10].ToString();
                txtpin.Text = dr[11].ToString();
                txtaadhar.Text = dr[8].ToString();
                //pictureBox1.Image = DisPhoto((byte[])dr[9]);
                txtemail.Text = dr[9].ToString();
                txtcommision.Text=dr[12].ToString();

                byte[] img = ((byte[])dr[13]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            dr.Close();

        }

        private void btnbwose_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnsdelete_Click_1(object sender, EventArgs e)
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
                        cmd = new SqlCommand("delete from salesman_regitration where sa_id='" + txtid.Text + "'", db.cn);
                        cmd.ExecuteNonQuery();
                        //cmbadd_record();
                        txtname.Clear();
                        txtadd.Clear();
                        txtaadhar.Clear();
                        rdom.Checked = false;
                        rdof.Checked = false;
                        rdoo.Checked = false;



                        cmbcity.SelectedIndex = 0;
                        cmbstate.SelectedIndex = 0;
                        cmbcountry.SelectedIndex = 0;
                        txtpin.Clear();
                        txtcontact.Clear();
                        txtemail.Clear();
                        txtcommision.Clear();
                        txtid.Clear();
                        txtdate.Clear();

                        cmbadd_record();
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

        private void btnsclose_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtsaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnsview_Click(object sender, EventArgs e)
        {
            List_of_Salesman list = new List_of_Salesman();
            list.ShowDialog();

        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcontact_Enter(object sender, EventArgs e)
        {

        }

        private void txtcontact_Leave(object sender, EventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void txtpin_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcommision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtadd_Enter(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.Yellow;

        }

        private void txtadd_Leave(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.White;

        }

        private void txtaadhar_Enter(object sender, EventArgs e)
        {
            txtaadhar.BackColor = Color.Yellow;

        }

        private void txtaadhar_Leave(object sender, EventArgs e)
        {
            txtaadhar.BackColor = Color.White;
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

