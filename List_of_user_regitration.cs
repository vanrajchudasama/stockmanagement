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
    public partial class List_of_user_regitration : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;       
        DataTable td=new DataTable();
        
        public List_of_user_regitration()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void List_of_user_regitration_Load(object sender, EventArgs e)
        {
            
           dataGridView1.EnableHeadersVisualStyles = false;
            
                da=new SqlDataAdapter("select user_id as 'Id',user_name as 'User Name',user_type as 'User Type',password as 'Password',name as 'Name',email_id as 'Email Id',contact_no as 'Contact No',active as 'Active',regitration_date as 'Regitration Date',image as 'Image' from user_regitation",db.cn);
              da.Fill(td);
            dataGridView1.DataSource=td;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch; 
                    break;
                }
            }
          
            
           // finddata();
        }
        public void finddata()
        {
;            string query = "select user_id as 'Id',user_name as 'User Name',user_type as 'User Type',password as 'Password',name as 'Name',email_id as 'Email Id',contact_no as 'Contact No',active as 'Active',regitration_date as 'Regitration Date',image as 'Image' from user_regitation where user_name='" + txtname.Text + "'";
            cmd = new SqlCommand(query, db.cn);
            da = new SqlDataAdapter(cmd);
            td = new DataTable(); 
            da.Fill(td);
            dataGridView1.DataSource = td;
            dataGridView1.DataSource = td;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
        }

       
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            User_regitration user = new User_regitration();
            user.txtid.Clear();
            user.txtid.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            user.txtruser.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            user.comboBox2.SelectedItem = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            user.txtrpass.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            user.txtrnm.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            user.txtremail.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //user.txtrcontact.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            user.cmbractiv.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            user.txtrdate.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[10].Value != null)
            {
                byte[] img = ((byte[])dataGridView1.CurrentRow.Cells[10].Value);
                MemoryStream ms = new MemoryStream(img);
                user.pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
               
            }
            //MemoryStream ms = new MemoryStream();
            //Bitmap img = (Bitmap)dataGridView1.CurrentRow.Cells[1].Value;
            //img.Save(ms, ImageFormat.jpg);
            //user.pictureBox1.Image = Image.FromStream(ms);
            user.Show();

            //user.pictureBox1.Image = user.DisPhoto((byte[])this.dataGridView1.CurrentRow.Cells[9].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string valuetosearch = textBox1.Text.ToString();
            
            finddata();
            txtname.Text = "";
        }

         

        private void button2_Click(object sender, EventArgs e)
        {
           
            string query = "select user_id as 'Id',user_name as 'User Name',user_type as 'User Type',password as 'Password',name as 'Name',email_id as 'Email Id',contact_no as 'Contact No',active as 'Active',regitration_date as 'Regitration Date',image as 'Image' from user_regitation where regitration_date='" + txtdate.Text + "'";
            cmd = new SqlCommand(query, db.cn);
            da = new SqlDataAdapter(cmd);
            td = new DataTable();



            da.Fill(td);
            dataGridView1.DataSource = td;
            dataGridView1.DataSource = td;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }

            dataGridView1.DataSource = td;
  
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = cmbd.Value.ToString("dd/MM/yyyy");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshj_Click(object sender, EventArgs e)
        {
          
            dataGridView1.EnableHeadersVisualStyles = false;
          
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);

            }
           
            
            da = new SqlDataAdapter("select user_id as 'Id',user_name as 'User Name',user_type as 'User Type',password as 'Password',name as 'Name',email_id as 'Email Id',contact_no as 'Contact No',active as 'Active',regitration_date as 'Regitration Date',image as 'Image' from user_regitation", db.cn);
            da.Fill(td);
            dataGridView1.DataSource = td;
           // dataGridView1.DataSource = td;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
        }

        private void dataGridView1_DockChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (bool.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()))
                {
                    cmd = new SqlCommand("delete from user_regitration where id='" + item.Cells[0].Value.ToString() + "'",db.cn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
       {
        //    for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
        //    {
                //bool d =(bool)dataGridView1.Rows[1].Cells[0].Value;
                //MessageBox.Show("hi;" + d);
                //if ( d == true)
                //{
                //    DataGridViewRow row = dataGridView1.Rows[i];
                //    dataGridView1.Rows.Remove(row);
                //}
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "Search By Name")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "Search By Name";
                txtname.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtdate.Text == "Search By Date")
            {
                txtdate.Text = "";
                txtdate.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtdate.Text == "")
            {
                txtdate.Text = "Search By Date";
                txtdate.ForeColor = Color.Silver;
            }
        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            finddatacontact();

        }
        public void finddatacontact()
        {
            ; string query = "select user_id as 'Id',user_name as 'User Name',user_type as 'User Type',password as 'Password',name as 'Name',email_id as 'Email Id',contact_no as 'Contact No',active as 'Active',regitration_date as 'Regitration Date',image as 'Image' from user_regitation where contact_no='" + txtcontact.Text + "'";
            cmd = new SqlCommand(query, db.cn);
            da = new SqlDataAdapter(cmd);
            td = new DataTable();
            da.Fill(td);
            dataGridView1.DataSource = td;
            dataGridView1.DataSource = td;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
        }

        private void txtcontact_Enter(object sender, EventArgs e)
        {
            if (txtcontact.Text == "Search By Contact")
            {
                txtcontact.Text = "";
                txtcontact.ForeColor = Color.Black;
            }
        }

        private void txtcontact_Leave(object sender, EventArgs e)
        {
            if (txtcontact.Text == "")
            {
                txtcontact.Text = "Search By Contact";
                txtcontact.ForeColor = Color.Silver;
            }
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
