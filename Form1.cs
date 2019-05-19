using System;
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
    public partial class Form1 : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         btnc.Focus();

            
            

            txtpass.Text = "Password";

            panel2.Visible = false;
            panel10.Visible = false;

           // btnl.Visible = false;
            panel11.Visible = false;
            txtnewpass.Visible = false;
            if (i == 0)
            {
                
            }
            else
            {
                MessageBox.Show("not nconnection");
            }
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //if (txtnewpass.Text.Trim() != String.Empty)
            //{
            //    cmd = new SqlCommand("update user_regitation set password='" + txtnewpass.Text + "'", db.cn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Password Sucessfully Change");
            //    btnl.Visible = true;
            //    txtmo.Clear();
            //    txtnewpass.Clear();
            //    txtu.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("Enter password  ");
            //}

            
            cmd = new SqlCommand("select *from user_regitation where user_name='" + txtuser.Text + "' and password='" + txtpass.Text + "'",db.cn);
            dr = cmd.ExecuteReader();
           

            if (dr.Read())
            {
                this.Hide();
                Main_Form mdi1 = new Main_Form();
                mdi1.Show();
            }
            else
            {
                MessageBox.Show(" invalid username and password");
            }
            dr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
             
            panel2.Visible = true;
           

            label8.Text = "Reset Password";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select *from user_regitation where user_name='" + txtu.Text + "' and contact_no='"+txtmo.Text+"'", db.cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                panel11.Visible = true;

                txtmo.Visible = true;
               // label9.Visible = true;
                txtnewpass.Visible = true;
                button3.Visible = true;

                btnshow.Visible = true;
                btnhide.Visible = false;
            }
            else
            {
               // errorProvider1.SetError(txtmo,"Enter Correct Mobile Number");
            }
            dr.Close();
        
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label8.Text = "Login Form";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                cmd = new SqlCommand("select *from user_regitation where user_name='" + txtu.Text + "'", db.cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    panel10.Visible = true;
                    
                    txtmo.Visible = true;
                    button4.Visible = true;

                }
                else
                {
                    //errorProvider1.SetError(txtu, "Enter Correct user Name");
                }
               
              
                
                dr.Close();
            
        }

      
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnewpass.Text.Trim() != String.Empty)
            {
                cmd = new SqlCommand("update user_regitation set password='" + txtnewpass.Text + "'", db.cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Sucessfully Change");
                label8.Visible = true;
                label8.Text = "LOGIN....";


                txtmo.Clear();
                txtnewpass.Clear();
                txtu.Clear();

        

                txtpass.Text = "Password";
                txtmo.Visible = false;
                button4.Visible = false;
                panel2.Visible = false;
                panel10.Visible = false;


                panel11.Visible = false;
                txtnewpass.Visible = false;
                button3.Visible = false;
            }
            else
            {
                MessageBox.Show("Enter password  ");
            }

        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "User Name")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            txtpass.ForeColor = Color.Black;
            if (txtpass.Text == "Password")
            {
                txtpass.Clear();
                txtpass.PasswordChar = '*';


            }
            else
            {
                txtpass.PasswordChar = '*';
                txtpass.ForeColor = Color.Black;
            }

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "User Name";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {

            if (txtpass.Text != "Password")
            {

            }
            if (txtpass.Text == string.Empty)
            {

                txtpass.PasswordChar = '\0';
                // txtpass.PasswordChar = Convert.ToChar("");
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.Silver;
            }
           
        }

        private void txtnewpass_Enter(object sender, EventArgs e)
        {
            txtnewpass.ForeColor = Color.Black;
            if (txtnewpass.Text == "New Password")
            {
                txtnewpass.Clear();
                txtnewpass.PasswordChar = '*';


            }
            else
            {
                txtnewpass.PasswordChar = '*';
                txtnewpass.ForeColor = Color.Black;
            }
        }

        private void txtnewpass_Leave(object sender, EventArgs e)
        {
            if (txtnewpass.Text != "New password")
            {

            }
            if (txtnewpass.Text == string.Empty)
            {

                txtnewpass.PasswordChar = '\0';
                // txtpass.PasswordChar = Convert.ToChar("");
                txtnewpass.Text = "New Password";
                txtnewpass.ForeColor = Color.Silver;
            }
        }

        private void txtu_Enter(object sender, EventArgs e)
        {
            if (txtu.Text == "User Name")
            {
                txtu.Text = "";
                txtu.ForeColor = Color.Black;
            }
        }

        private void txtu_Leave(object sender, EventArgs e)
        {
            if (txtu.Text == "")
            {
                txtu.Text = "User Name";
                txtu.ForeColor = Color.Silver;
            }
        }

        private void txtmo_Enter(object sender, EventArgs e)
        {
            if (txtmo.Text == "Mobile Number")
            {
                txtmo.Text = "";
                txtmo.ForeColor = Color.Black;
            }
        }

        private void txtmo_Leave(object sender, EventArgs e)
        {
            if (txtmo.Text == "")
            {
                txtmo.Text = "Mobile Number";
                txtmo.ForeColor = Color.Silver;
            }
        }

       

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Navy;
        }

       

        private void abc_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();

        }

        private void txtmo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //    e.Handled = true;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            btnhide.Visible = true;
            btnshow.Visible = false;
            if (txtnewpass.UseSystemPasswordChar==false)

            {
                txtnewpass.UseSystemPasswordChar = true;
  
            }
            //else
            //{
            //    txtnewpass.UseSystemPasswordChar = true;
    
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpass.UseSystemPasswordChar == true)
            {
                txtpass.UseSystemPasswordChar = false;

            }
            else
            {
                txtpass.UseSystemPasswordChar = true;

            }
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            btnhide.Visible = false;
            btnshow.Visible = true;
            if (txtnewpass.UseSystemPasswordChar == true)
            {
                txtnewpass.UseSystemPasswordChar = false;

            }
            //else
            //{
            //    txtnewpass.UseSystemPasswordChar = true;

            //}
        }

        private void btnphide_Click(object sender, EventArgs e)
        {
            btnphide.Visible = false;
            btnpshow.Visible = true;
            if (txtpass.UseSystemPasswordChar == true)
            {
                txtpass.UseSystemPasswordChar = false;

            }
        }

        private void btnpshow_Click(object sender, EventArgs e)
        {
            btnphide.Visible = true;
            btnpshow.Visible = false;

            if (txtpass.UseSystemPasswordChar == false)
            {
                txtpass.UseSystemPasswordChar = true;

            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       

       

       
    }
}
