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
using System.Text.RegularExpressions;


namespace stock_management_system
{
    public partial class company_edit : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        // MemoryStream ms;
        SqlDataReader dr;

        public company_edit()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void company_edit_Load(object sender, EventArgs e)
        {
            cmbadd_record();

        }
        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            companyimg.Image.Save(ms, pb.Image.RawFormat);
            //pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }
        void cmbadd_record()
        {
            comboBox1.Items.Clear();
            cmd = new SqlCommand("select id from company_info", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox1.Items.Add(dr["id"].ToString());
            }
            dr.Close();
        }

        private void btncbrows_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                companyimg.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btncupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please Select Id");
            }
            else
            {
                if (txtnme.Text == "" || txtcon.Text == "" || txtdate.Text==""||txtemail.Text == "" || txtdate.Text == "" || txtpin.Text == "" || txtcgst.Text == "")
                {
                    MessageBox.Show("Please Insert Record......!");

                }
                else
                {
                    if (cmbcity.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select City..!");
                    }
                    else if (cmbsate.SelectedIndex == 0)
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

                                cmd = new SqlCommand("update company_info set company_name='" + txtnme.Text + "',address='" + txtadd.Text + "',contact_no='" + txtcon.Text + "',email_id='" + txtemail.Text + "',city='" + cmbcity.SelectedIndex + "',state='" + cmbsate.SelectedIndex + "',country='" + cmbcountry.SelectedItem + "',date='" + txtdate.Text + "',pincode='" + txtpin + "',gst='" + txtcgst + "',img=@Image where id='" + txtid.Text + "'", db.cn);
                                cmd.Parameters.AddWithValue("Image", savePhoto1(companyimg));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Update");
                                cmbadd_record();
                                txtid.Clear();
                                txtnme.Clear();
                                cmbcity.SelectedIndex = 0;
                                cmbsate.SelectedIndex = 0;
                                cmbcountry.SelectedIndex = 0;

                                txtadd.Clear();
                                txtcon.Clear();
                                txtemail.Clear();
                                txtpin.Clear();
                                txtdate.Clear();
                                txtcgst.Clear();
                            }
                        }
                    }

                }

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from company_info where id='" +comboBox1.SelectedItem + "'", db.cn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtid.Text = dr[0].ToString();
                txtnme.Text = dr[1].ToString();
                cmbsate.SelectedItem = dr[6].ToString();
                txtadd.Text = dr[2].ToString();
                txtcon.Text = dr[3].ToString();
                cmbcountry.SelectedItem = dr[7].ToString();
                txtemail.Text = dr[4].ToString();
                cmbcity.SelectedItem = dr[5].ToString();
                txtdate.Text = dr[8].ToString();
                txtpin.Text=dr[9].ToString();
                 txtcgst.Text=dr[10].ToString();
                byte[] img = ((byte[])dr[11]);
                MemoryStream ms = new MemoryStream(img);
                companyimg.Image = Image.FromStream(ms);
                // pictureBox1.Image = DisPhoto((byte []) dr[9]);

            }
            dr.Close();
        }

        }
    }


