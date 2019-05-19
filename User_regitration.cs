using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace stock_management_system
{
    public partial class User_regitration : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        MemoryStream ms;


        public User_regitration()
        {
            i = db.connection();
            InitializeComponent();
        }
        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {


        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtrdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void autoId()
        {
            int id;
            //try
            //{
            //    cmd = new SqlCommand("select MAX(user_id) from user_regitation", db.cn);
            //    id = Convert.ToInt32(cmd.ExecuteScalar());
            //    int enroll = id + 1;
            //    txtid.Text = enroll.ToString();
            //}
            //catch
            //{
            //    txtid.Text = "1";
            //}

            cmd = new SqlCommand("select MAX(user_id) from user_regitation",db.cn);
            string s = Convert.ToString(cmd.ExecuteScalar());
            if (s == "")
            {
                txtid.Text = "1";
            }
            else
            {
                int no = Convert.ToInt32(s);
                id = no + 1;
                txtid.Text = id.ToString();
            }
        }

        private void User_regitration_Load(object sender, CancelEventArgs e)
        {
            autoId();
        }

        //bool Exist=false;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select user_id from user_regitation where user_id='" + txtid.Text + "'", db.cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //Exist=true;
                    MessageBox.Show("alredy id is exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            //if(Exist)
                //{

            //}

                else
                {
                    if (txtrnm.Text == string.Empty || txtremail.Text == string.Empty || txtrcontact.Text == string.Empty || txtrdate.Text == string.Empty || txtruser.Text == string.Empty || txtrpass.Text == string.Empty)
                    {
                        MessageBox.Show("Please Insert Record......!");

                    }
                    else
                    {

                        if (comboBox2.SelectedIndex == 0)
                        {
                            MessageBox.Show("Please Select User type");
                        }

                        else
                        {

                            dr.Close();
                            System.Text.RegularExpressions.Regex remail=new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-z0-9][\w\.-]*[a-zA-z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
                            if (txtremail.Text.Length >0)
                            {
                                if (!remail.IsMatch(txtremail.Text))
                                {
                                    MessageBox.Show("Invalid Email..!");
                                    txtremail.SelectAll();
                                }
                                else
                                {
                                   
                                    cmd = new SqlCommand("insert into user_regitation(user_id, user_name,user_type,password,name,email_id,contact_no,active,regitration_date,image)values('" + txtid.Text + "','" + txtruser.Text + "','" + comboBox2.SelectedItem + "','" + txtrpass.Text + "','" + txtrnm.Text + "','" + txtremail.Text + "','" + txtrcontact.Text + "','" + cmbractiv.Text + "','" + txtrdate.Text + "',@image)", db.cn);
                                    //conv_photo();

                                    cmd.Parameters.AddWithValue("Image", savePhoto1(pictureBox1));
                                    //cmd.Parameters.AddWithValue("image",savePhoto1(pictureBox1));
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("save");
                                    pictureBox1.Image.Clone(); ;
                                    txtid.Clear();
                                    autoId();


                                    txtruser.Clear();

                                    txtrpass.Clear();
                                    txtrnm.Clear();
                                    txtremail.Clear();
                                    txtrcontact.Clear();
                                    cmbractiv.Text = "";
                                    txtrdate.Clear();
                                    comboBox2.SelectedIndex = 0;
                                }
                            }
                           
                        }


                    }
                    txtrdate.Text = DateTime.Now.ToString("dd/MM/yyyy");

                }
                dr.Close();
            }
            catch
            {
                MessageBox.Show("alredy User_name exist");
            }
            
        }

        void conv_photo()
        {
            //if (pictureBox1.Image != null)
            //{
            try
            {
                Image img = Image.FromFile("F:/BCA/project/logo/avatar.jpg");
                if (pictureBox1.Image != null)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    byte[] photo_array = new byte[fs.Length];
                    fs.Read(photo_array, 0, photo_array.Length);
                    cmd.Parameters.AddWithValue("@photo", photo_array);
                }
            }
            catch(Exception)
            {

            }
                //ms.=new MemoryStream();
                //pictureBox1.Image.Save(ms);
                //byte[] photo_array=new byte[ms.Length];
                //ms.Position=0;
                //ms.Read(photo_array,0,photo_array.Length);
                //cmd.Parameters.AddWithValue("@photo",photo_array);
            
        }

           


        

       

        private void button1_Click_1(object sender, EventArgs e)
        {
             
        }

        private void txtrdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_regitration_Load(object sender, EventArgs e)
        {
           
            txtrdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            autoId();
            cmd = new SqlCommand("select user_id from user_regitation",db.cn);
            comboBox2.SelectedIndex = 0;

          
             
        }
       
       

        private void txtid_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;
        }

        private void Textbox_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void btnrdelet_Click(object sender, EventArgs e)
        {
          

        }

        private void btnget_Click(object sender, EventArgs e)
        {
            List_of_user_regitration list = new List_of_user_regitration();
            list.Show();
        }

        private void btnrclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //display photo
        public Image DisPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        //private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        //{
        //    comboBox2.SelectedText = "";
        //    cmd = new SqlCommand("select * from user_regitation where user_id='" + comboBox1.SelectedItem + "'", db.cn);

        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        txtid.Text = dr[0].ToString();
        //        txtruser.Text = dr[1].ToString();
        //        comboBox2.SelectedItem = dr[2].ToString();
        //        txtrpass.Text = dr[3].ToString();
        //        txtrnm.Text = dr[4].ToString();
        //        txtremail.Text = dr[5].ToString();
        //        txtrcontact.Text = dr[6].ToString();
        //        txtrdate.Text = dr[8].ToString();
        //       // pictureBox1.Image = DisPhoto((byte []) dr[9]);
               
        //    }
        //    dr.Close();
        //}

        private void btnrup_Click_1(object sender, EventArgs e)
        {
            if (txtrnm.Text == string.Empty || txtremail.Text == string.Empty || txtrcontact.Text == string.Empty || txtrdate.Text == string.Empty || txtruser.Text == string.Empty || txtrpass.Text == string.Empty)
            {
                MessageBox.Show("Please Insert Record......!");

            }
            else
            {
                cmd = new SqlCommand("update user_regitation set user_id='" + txtid.Text + "',user_name='" + txtruser.Text + "',user_type='" + comboBox2.SelectedItem + "',password='" + txtrpass.Text + "',name='" + txtrnm.Text + "',email_id='" + txtremail.Text + "',contact_no='" + txtrcontact.Text + "',active='" + cmbractiv.Text + "',regitration_date='" + txtrdate.Text + "' where user_id='" + txtid.Text + "'", db.cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Upadate.....", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtruser.Clear();

                txtrpass.Clear();
                txtrnm.Clear();
                txtremail.Clear();
                txtrcontact.Clear();
                cmbractiv.Text = "";
                txtrdate.Clear();
                comboBox2.SelectedIndex = 0;
                txtrdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        private void btnrdelet_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Aru you sure Delete.....!", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from user_regitation where user_id='" + txtid.Text + "'", db.cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is Delete", "Information", MessageBoxButtons.OK);

             
                txtruser.Clear();
                comboBox2.SelectedIndex = 0;
                txtrpass.Clear();
                txtrnm.Clear();
                txtremail.Clear();
                txtrcontact.Clear();
                cmbractiv.Text = "";
                txtrdate.Clear();

            }
            else
            {
                MessageBox.Show("Record is not Delete.....!", "Information", MessageBoxButtons.OK);
            }
        }

        private void btnrnew_Click(object sender, EventArgs e)
        {
            txtruser.Clear();
             
            txtrpass.Clear();
            txtrnm.Clear();
            txtremail.Clear();
            txtrcontact.Clear();
            cmbractiv.Text = "";
            txtrdate.Clear();
            txtrnm.Focus();
           
           
            autoId();
            comboBox2.SelectedIndex = 0;
            txtrdate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txtrcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            e.Handled=true;
        }

        private void txtrnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
           
        }

        private void txtid_Enter_1(object sender, EventArgs e)
        {
           TextBox tb=(TextBox)sender;
           tb.BackColor = Color.Yellow;
        }

        private void txtid_Leave_1(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txtremail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrdate_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtruser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtrpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnget_Click_1(object sender, EventArgs e)
        {
            List_of_user_regitration lu = new List_of_user_regitration();
            lu.ShowDialog();
        }
       // bool EMPTY=false;
        private void txtruser_Leave(object sender, EventArgs e)
        {
            txtruser.BackColor = Color.White;

            //if (txtruser.Text == string.Empty)
            //{ 
            //MessageBox.Show("Enter User name");
            //EMPTY = true;
            //}
        }

        private void txtrpass_Leave(object sender, EventArgs e)
        {
            txtrpass.BackColor = Color.White;

            //if ( txtrpass.Text == string.Empty)
            //{
            //    MessageBox.Show("Enter password");
            //    EMPTY = true;
            //}
        }

        private void btnrclose_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtruser_Enter(object sender, EventArgs e)
        {
            txtruser.BackColor = Color.Yellow;

        }

        private void txtrpass_Enter(object sender, EventArgs e)
        {
            txtrpass.BackColor = Color.Yellow;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_Leave_1(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.Text = "Select user type";
            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                comboBox2.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtrcontact_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtrcontact_Enter(object sender, EventArgs e)
        {
            txtrcontact.BackColor = Color.Yellow;

        }

        private void txtrcontact_Leave(object sender, EventArgs e)
        {
            txtrcontact.BackColor = Color.White;

        }

        private void txtruser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {
 

            }
        }

        private void txtrcontact_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtrcontact_Enter_1(object sender, EventArgs e)
        {
            txtrcontact.BackColor = Color.Yellow;

        }

        private void txtrcontact_Leave_1(object sender, EventArgs e)
        {
            txtrcontact.BackColor = Color.White;

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Navy;
        }

        private void txtrpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = (e.KeyChar == (char)Keys.Space))
            {


            }
        }

       

        

         
    }
}
