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
    public partial class user_Edite : Form
    {

        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        MemoryStream ms;
        SqlDataReader dr;
        public user_Edite()
        {
              i = db.connection(); 
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

        private void cmbuid_SelectedIndexChanged(object sender, EventArgs e)
        {

          //  cmbuid.SelectedText = "";
            
            cmd = new SqlCommand("select * from user_regitation where user_id='" + cmbuid.SelectedItem + "'", db.cn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtuid.Text = dr[0].ToString();
                txtuname.Text = dr[4].ToString();
                cmbutype.SelectedItem = dr[2].ToString();
                txtuemail.Text = dr[5].ToString();
                txtucontactno.Text = dr[6].ToString();
                cmbuactive.SelectedItem = dr[7].ToString();
                txtudate.Text = dr[8].ToString();
                txtuusername.Text = dr[1].ToString();
                txtupass.Text = dr[3].ToString();
                byte[] img = ((byte[])dr[9]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                // pictureBox1.Image = DisPhoto((byte []) dr[9]);

            }
            dr.Close();
        }

        private void user_Edite_Load(object sender, EventArgs e)
        {
            cmbadd_record();
            cmbutype.SelectedIndex = 0;
        }
        private void getData()
        {
            cmbuid.Items.Clear();
            cmd = new SqlCommand("select user_id from user_regitation", db.cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbuid.Items.Add(dr[0].ToString());
            }
            dr.Close();

        }
        void cmbadd_record()
        {
            cmbuid.Items.Clear();
            cmd = new SqlCommand("select user_id from user_regitation", db.cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbuid.Items.Add(dr["user_id"].ToString());
            }
            dr.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtuid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtuid.Text == "")
            {
                MessageBox.Show("Please Select Id");
            }
            else
            {
                if (txtucontactno.Text == "" || txtuname.Text == "" || txtuemail.Text == "" || txtuusername.Text == "" || txtupass.Text == "")
                {
                    MessageBox.Show("Please Insert Record......!");

                }
                else
                {
                    if (cmbutype.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select Usertype...!");
                    }

                    else
                    {
                        System.Text.RegularExpressions.Regex remail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-z0-9][\w\.-]*[a-zA-z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                        if (txtuemail.Text.Length > 0)
                        {
                              if (!remail.IsMatch(txtuemail.Text))
                            {
                                MessageBox.Show("Invalid Email..!");
                                txtuemail.SelectAll();
                            }
                            else
                            {

                                cmd = new SqlCommand("update user_regitation set user_name='" + txtuusername.Text + "',user_type='" + cmbutype.SelectedItem + "',password='" + txtupass.Text + "',name='" + txtuname.Text + "',email_id='" + txtuemail.Text + "',contact_no='" + txtucontactno.Text + "',active='" + cmbuactive.SelectedItem + "',image=@Image where user_id='" + txtuid.Text + "'", db.cn);
                                cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Update");
                                cmbadd_record();
                                txtuid.Clear();
                                txtuname.Clear();
                                cmbutype.SelectedIndex = 0;
                                txtupass.Clear();
                                txtuusername.Clear();
                                txtuemail.Clear();
                                txtucontactno.Clear();
                                cmbuactive.Text = "";
                                txtudate.Clear();
                            }
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

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtuid.Text == "")
            {
                MessageBox.Show("Please Select Id");
            }
            else
            {
                cmbadd_record();
                DialogResult result = MessageBox.Show("Aru you sure Delete.....!", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete from user_regitation where user_id='" + txtuid.Text + "'", db.cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record is Delete", "Information", MessageBoxButtons.OK);

                    // getData();
                    txtuid.Clear();
                    txtuname.Clear();
                    cmbutype.SelectedIndex = 0;
                    txtupass.Clear();
                    txtuusername.Clear();
                    txtuemail.Clear();
                    txtucontactno.Clear();
                    cmbuactive.Text = "";
                    txtudate.Clear();

                }
                else
                {
                    MessageBox.Show("Record is not Delete.....!", "Information", MessageBoxButtons.OK);
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

       

        

        private void cmbutype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtucontactno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtudate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtupass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuusername_Enter(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.Yellow;

        }

        private void txtucontactno_Leave(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.White;

        }

        private void cmbutype_Leave(object sender, EventArgs e)
        {
            if (cmbutype.Text == "")
            {
                cmbutype.Text = "Select user type";
            }
        }

        private void cmbutype_Enter(object sender, EventArgs e)
        {
            if (cmbutype.SelectedIndex == 0)
            {
                cmbutype.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtucontactno_Enter(object sender, EventArgs e)
        {
            txtucontactno.BackColor=Color.Yellow;

        }

        private void txtucontactno_Leave_1(object sender, EventArgs e)
        {
            txtucontactno.BackColor = Color.White;

        }

        private void txtuname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void txtucontactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtucontactno_Enter_1(object sender, EventArgs e)
        {
            txtucontactno.BackColor = Color.Yellow;

        }

        private void txtucontactno_Leave_2(object sender, EventArgs e)
        {
            txtucontactno.BackColor = Color.White;

        }

        private void txtuusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {


            }
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            List_of_user_regitration lu = new List_of_user_regitration();
            lu.ShowDialog();
        }

        private void lax_MouseHover(object sender, EventArgs e)
        {
            lax.BackColor = Color.Red;
        }

        private void lax_MouseLeave(object sender, EventArgs e)
        {
            lax.BackColor = Color.Navy;


        }

        private void txtupass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {


            }
        }

      
        }
    }

