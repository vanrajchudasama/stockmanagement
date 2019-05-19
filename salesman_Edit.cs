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
    public partial class salesman_Edit : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        // MemoryStream ms;
        SqlDataReader dr;


        public salesman_Edit()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtid.ReadOnly = true;
            cmd = new SqlCommand("select *from salesman_regitration where sa_id='" + cmbid.SelectedItem + "'", db.cn);

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
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
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
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnsupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please Fill Record...!");
            }
            else
            {
                if (rdbm.Checked == true)
                {
                    cmd = new SqlCommand("update salesman_regitration set sa_id='" + txtid.Text + "',sa_name='" + txtname.Text + "',sa_contact='" + txtcontact.Text + "',sa_address='" + txtaddress.Text + "',sa_gender='" + rdbm.Text + "',sa_city='" + cmbcity.SelectedItem + "',sa_state='" + cmbstate.SelectedItem + "',sa_country='" + cmbcountry.SelectedItem + "',sa_aadhar='" + txtaadhar.Text + "',sa_email='" + txtemail.Text + "',sa_pin='" + txtpin.Text + "',sa_commision='" + txtsacommision.Text + "',sa_img=@Image where sa_id='" + txtid.Text + "'", db.cn);
                    cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update");
                }
                else if (rdbf.Checked == true)
                {
                    cmd = new SqlCommand("update salesman_regitration set sa_id='" + txtid.Text + "',sa_name='" + txtname.Text + "',sa_contact='" + txtcontact.Text + "',sa_address='" + txtaddress.Text + "',sa_gender='" + rdbm.Text + "',sa_city='" + cmbcity.SelectedItem + "',sa_state='" + cmbstate.SelectedItem + "',sa_country='" + cmbcountry.SelectedItem + "',sa_aadhar='" + txtaadhar.Text + "',sa_email='" + txtemail.Text + "',sa_pin='" + txtpin.Text + "',sa_commision='" + txtsacommision.Text + "',sa_img=@Image where sa_id='" + txtid.Text + "'", db.cn);
                    cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update");

                }
                else if (rdbo.Checked == true)
                {
                    cmd = new SqlCommand("update salesman_regitration set sa_id='" + txtid.Text + "',sa_name='" + txtname.Text + "',sa_contact='" + txtcontact.Text + "',sa_address='" + txtaddress.Text + "',sa_gender='" + rdbm.Text + "',sa_city='" + cmbcity.SelectedItem + "',sa_state='" + cmbstate.SelectedItem + "',sa_country='" + cmbcountry.SelectedItem + "',sa_aadhar='" + txtaadhar.Text + "',sa_email='" + txtemail.Text + "',sa_pin='" + txtpin.Text + "',sa_commision='" + txtsacommision.Text + "',sa_img=@Image where sa_id='" + txtid.Text + "'", db.cn);
                    cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update");
                }
            }
        }

        private void btnsdelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtid.Text == "")
                {
                    MessageBox.Show("Please Select record...!");
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

        private void btnsclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
