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
    public partial class Company_Info : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        SqlDataReader dr;
        MemoryStream ms;
        public Company_Info()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Company_Info_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
            if (txtcname.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtcname, "Please Enter Name");
            }
        }

        private void Company_Info_Enter(object sender, EventArgs e)
        {

        }

       

        private void txtccontact_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cmbccity_Enter(object sender, EventArgs e)
        {
           
            if (cmbccity.SelectedIndex == 0)
            {
                cmbccity.Text = "";
            }
            

        }

        private void cmbccity_Leave(object sender, EventArgs e)
        {
            cmbccity.BackColor = Color.White;
            //if (cmbccity.Text == "")
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(cmbccity, "Please select City");
            //}
            if (cmbccity.Text == "")
            {
                cmbccity.Text = "Select City";
            }
        }

        private void cmbcstate_Leave(object sender, EventArgs e)
        {
            cmbcstate.BackColor = Color.White;
            //if (cmbccity.Text == "")
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(cmbccity, "Please select City");
            //}
            if (cmbcstate.Text == "")
            {
                cmbcstate.Text = "Select State";
            }
        }

        private void cmbcstate_Enter(object sender, EventArgs e)
        {
           
            if (cmbcstate.SelectedIndex == 0)
            {
                cmbcstate.Text = "";
            }
        }

        private void cmbccounty_Leave(object sender, EventArgs e)
        {
            cmbccounty.BackColor = Color.White;
            //if (cmbccounty.Text == "")
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(cmbccounty, "Please select country");
            //}
            if (cmbccounty.Text == "")
            {
                cmbccounty.Text = "Select Country";
            }
        }

       

        private void txtccontact_Leave(object sender, EventArgs e)
        {

        }

        private void txtccontact_Enter(object sender, EventArgs e)
        {

        }

        private void txtcaddress_Leave(object sender, EventArgs e)
        {

        }

        private void txtcemail_Enter(object sender, EventArgs e)
        {

        }

        private void txtcemail_Leave(object sender, EventArgs e)
        {

        }

        private void cmbccounty_Enter(object sender, EventArgs e)
        {
           
            if (cmbccounty.SelectedIndex == 0)
            {
                cmbccounty.Text = "";
            }
        }

        private void txtcpincode_Enter(object sender, EventArgs e)
        {
            txtcpincode.BackColor = Color.Yellow;
        }

        private void txtcpincode_Leave(object sender, EventArgs e)
        {

        }

        private void txtcgst_Enter(object sender, EventArgs e)
        {

        }

        private void txtcgst_Leave(object sender, EventArgs e)
        {

        }
        void conv_photo()
        {
           
            try
            {
                Image img = Image.FromFile("F:/BCA/project/logo/avatar.jpg");
                if (companyimg.Image != null)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    byte[] photo_array = new byte[fs.Length];
                    fs.Read(photo_array, 0, photo_array.Length);
                    cmd.Parameters.AddWithValue("@photo", photo_array);
                }
            }
            catch (Exception)
            {

            }
            

        }
        private void btncbrows_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File *.png|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               companyimg.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btncregitration_Click(object sender, EventArgs e)
        {
            if (txtcid.Text == "" || txtcname.Text == ""||txtcaddress.Text==""||txtccontact.Text==""||txtcemail.Text==""||cmbccity.Text==""||cmbcstate.Text==""||cmbccounty.Text==""||txtcpincode.Text==""||txtcgst.Text=="")

            {
                MessageBox.Show("please insert Record.....!");

            }
            else
            {
                cmd = new SqlCommand("insert into company_info (id,company_name,address,contact_no,email_id,city,state,country,pincode,gst,img) values('" + txtcid.Text + "','" + txtcname.Text + "','" + txtcaddress.Text + "','" + txtccontact.Text + "','" + txtcemail.Text + "','" + cmbccity.SelectedItem + "','" + cmbcstate.SelectedItem + "','" + cmbccounty.SelectedItem + "','" + txtcpincode.Text + "','" + txtcgst.Text + "',@img)", db.cn);
                //conv_photo();
                cmd.Parameters.AddWithValue("img",savePhoto1(companyimg));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record save");
                txtcname.Clear();
                txtcaddress.Clear();
                txtccontact.Clear();
                txtcemail.Clear();
                cmbccity.Text = "";
                cmbcstate.Text = "";
                cmbccounty.Text = "";
                txtcpincode.Clear();
                txtcgst.Clear();
                txtcid.Focus();
            }
        }
        public byte[] savePhoto1(PictureBox pb)
        {

            MemoryStream ms = new MemoryStream();
            companyimg.Image.Save(ms, pb.Image.RawFormat);
            return ms.GetBuffer();
        }
        private void btncupdate_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("update company_info set id='"+txtcid+"',company_name='" + txtcname.Text + "',address='" + txtcaddress.Text + "',contact_no='" + txtccontact.Text + "',email_id='" + txtcemail.Text + "',city='" + cmbccity.SelectedItem + "',state='" + cmbcstate.SelectedItem + "',country='" + cmbccounty.SelectedItem + "',pincode='" + txtcpincode.Text + "',gst='"+txtcgst.Text+"' where company_name='"+txtcname.Text+"'",db.cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Update");
            txtcid.Clear();

            txtcname.Clear();
            txtcaddress.Clear();
            txtccontact.Clear();
            txtcemail.Clear();
            cmbccity.Text = "";
            cmbcstate.Text = "";
            cmbccounty.Text = "";
            txtcpincode.Clear();
            txtcgst.Clear();
            txtcid.Focus();
        }

        private void btncew_Click(object sender, EventArgs e)
        {
            txtcid.Clear();
            txtcname.Clear();
            txtcaddress.Clear();
            txtccontact.Clear();
            txtcemail.Clear();
            cmbccity.Text = "";
            cmbcstate.Text = "";
            cmbccounty.Text = "";
            txtcpincode.Clear();
            txtcgst.Clear();
            txtcid.Focus();
        }

        private void btncdelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure this :"+txtcname.Text+"Record is Delete...!", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from company_info where id='"+txtcid+"'", db.cn);
                cmd.ExecuteNonQuery();
                txtcid.Clear();
                txtcname.Clear();
                txtcaddress.Clear();
                txtccontact.Clear();
                txtcemail.Clear();
                cmbccity.Text = "";
                cmbcstate.Text = "";
                cmbccounty.Text = "";
                txtcpincode.Clear();
                txtcgst.Clear();
                txtcid.Focus();

            }
            else if(dr==DialogResult.No)
            {
                MessageBox.Show("Record not Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Company_Info_Load(object sender, EventArgs e)
        {
            cmbadd_record();

            cmbccity.SelectedIndex = 0;
            cmbcstate.SelectedIndex = 0;
            cmbccounty.SelectedIndex = 0;
            
        }


        void cmbadd_record()
        {

            comboBox1.Items.Clear();
            cmd = new SqlCommand("select id from company_info", db.cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["id"].ToString());
            }
            dr.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from company_info where id='" + comboBox1.SelectedItem + "'", db.cn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtcid.Text = dr[0].ToString();
                txtcname.Text = dr[1].ToString();
                txtcaddress.Text = dr[2].ToString();
                txtccontact.Text = dr[3].ToString();
                txtcemail.Text = dr[4].ToString();
                cmbccity.SelectedItem = dr[5].ToString();
                cmbcstate.SelectedItem = dr[6].ToString();
                cmbccounty.SelectedItem = dr[7].ToString();
                txtcodate.Text = dr[8].ToString();
                txtcpincode.Text = dr[9].ToString();
                txtcgst.Text = dr[10].ToString();

                byte[] img = ((byte[])dr[11]);
                MemoryStream ms = new MemoryStream(img);
               companyimg.Image = Image.FromStream(ms);
                // pictureBox1.Image = DisPhoto((byte []) dr[9]);

            }
            dr.Close();
        }

        private void btncclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtcpincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtcgst_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            //    e.Handled = true;
        }

        private void txtcaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcpincode_Enter_1(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.Yellow;

        }

        private void txtcpincode_Leave_1(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            text.BackColor = Color.White;

        }

        private void txtcname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != (' '))
            {
                e.Handled = true;
            }
        }

        private void Company_Info_MouseHover(object sender, EventArgs e)
        {
            
        
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Navy;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

       
    }
}
