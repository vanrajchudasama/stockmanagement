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
    public partial class list_of_customer : Form


    {


        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        DataTable ta = new DataTable();
        SqlDataAdapter da;

        public list_of_customer()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select cust_id as 'Id',cust_name as 'Costomer Name',cust_gender as 'Gender',cust_add as 'Address',cust_aadhar as 'Aadhar No',cust_city as 'City',cust_state as 'State',cust_country as 'Country', cust_date as 'Regitration Date ',cust_pin as 'Pin Code No',cust_contact as 'Contact',cust_email as'Email Id',cust_img as'Image' from cust_regitration where cust_date='" + txtdate.Text + "'";

            cmd = new SqlCommand(query, db.cn);
            da = new SqlDataAdapter(cmd);
            ta = new DataTable();
            da.Fill(ta);
            dataGridView1.DataSource = ta;
            dataGridView1.DataSource = ta;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdate_Enter(object sender, EventArgs e)
        {
            if (txtdate.Text == "Search By Date")
            {
                txtdate.Text = "";
                txtdate.ForeColor = Color.Black;
            }
        }


        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "Search By Name")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "Search By Name";
                txtname.ForeColor = Color.Silver;
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

        private void list_of_customer_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            da = new SqlDataAdapter("select cust_id as 'Id',cust_name as 'Costomer Name',cust_gender as 'Gender',cust_add as 'Address',cust_aadhar as 'Aadhar No',cust_city as 'City',cust_state as 'State',cust_country as 'Country', cust_date as 'Regitration Date',cust_pin as 'Pin Code No',cust_contact as 'Contact',cust_email as'Email Id',cust_img as'Image' from cust_regitration", db.cn);
            da.Fill(ta);
            dataGridView1.DataSource = ta;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
        }

        private void txtdate_Leave(object sender, EventArgs e)
        {
            if (txtdate.Text == "")
            {
                txtdate.Text = "Search By Date";
                txtdate.ForeColor = Color.Silver;
            }
        }

        public void finddata()
        {
            string query = "select cust_id as 'Id',cust_name as 'Costomer Name',cust_gender as 'Gender',cust_add as 'Address',cust_aadhar as 'Aadhar No',cust_city as 'City',cust_state as 'State',cust_country as 'Country',cust_date as'Regitration Date',cust_pin as 'Pin Code No',cust_contact as 'Contact',cust_email as'Email Id',cust_img as'Image' from cust_regitration where cust_name='" + txtname.Text + "'";
          
            cmd = new SqlCommand(query, db.cn);
            da = new SqlDataAdapter(cmd);
            ta= new DataTable();
            da.Fill(ta);
            dataGridView1.DataSource = ta;
            dataGridView1.DataSource = ta;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndate_Click(object sender, EventArgs e)
        {
            

            string query = "select cust_id as 'Id',cust_name as 'Costomer Name',cust_gender as 'Gender',cust_add as 'Address',cust_aadhar as 'Aadhar No',cust_city as 'City',cust_state as 'State',cust_country as 'Country',cust_date as'Regitration Date',cust_pin as 'Pin Code No',cust_contact as 'Contact',cust_email as'Email Id',cust_img as'Image' from cust_regitration where cust_date='" + txtdate.Text + "'";
            cmd = new SqlCommand(query, db.cn);
            da = new SqlDataAdapter(cmd);
            ta = new DataTable();



            da.Fill(ta);
            dataGridView1.DataSource = ta;
            dataGridView1.DataSource = ta;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
            txtdate.Clear();
        }



            

        

        private void btnname_Click(object sender, EventArgs e)
        {
            finddata();
            txtname.Clear();


        }

        private void btncontact_Click(object sender, EventArgs e)
        {
            string query = "select cust_id as 'Id',cust_name as 'Costomer Name',cust_gender as 'Gender',cust_add as 'Address',cust_aadhar as 'Aadhar No',cust_city as 'City',cust_state as 'State',cust_country as 'Country',cust_date as'Regitration Date',cust_pin as 'Pin Code No',cust_contact as 'Contact',cust_email as'Email Id',cust_img as'Image' from cust_regitration where cust_contact='" + txtcontact.Text + "'";

            cmd = new SqlCommand(query, db.cn);
            da = new SqlDataAdapter(cmd);
            ta = new DataTable();
            da.Fill(ta);
            dataGridView1.DataSource = ta;
            dataGridView1.DataSource = ta;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            }
            txtcontact.Clear();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtdate.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

       

        private void btnr_Click(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);

            }
         

            da = new SqlDataAdapter("select cust_id as 'Id',cust_name as 'Costomer Name',cust_gender as 'Gender',cust_add as 'Address',cust_aadhar as 'Aadhar No',cust_city as 'City',cust_state as 'State',cust_country as 'Country', cust_date as 'Regitration Date',cust_pin as 'Pin Code No',cust_contact as 'Contact',cust_email as'Email Id',cust_img as'Image' from cust_regitration", db.cn);
            da.Fill(ta);
            dataGridView1.DataSource = ta;
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
           Cust_edite customer = new Cust_edite();
            customer.txtid.Clear();
            customer.txtid.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            customer.txtname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Male")
            {
                customer.rdbm.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Female")
            {
                customer.rdbf.Checked = true;
            }
            else
            {
                customer.rdbo.Checked = true;
            }
            customer.txtaddress.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
           // customer.txtaadhar.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            customer.cmbcity.SelectedItem = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            customer.cmbstate.SelectedItem = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            customer.txtdate.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            customer.cmbcountry.SelectedItem= this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
           // customer.txtdate =Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value);
            customer.txtpin.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            //customer.txtcontact.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            customer.txtemail.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[12].Value != null)
            {
                byte[] img = ((byte[])dataGridView1.CurrentRow.Cells[12].Value);
                MemoryStream ms = new MemoryStream(img);
                customer.pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {

            }
            //MemoryStream ms = new MemoryStream();
            //Bitmap img = (Bitmap)dataGridView1.CurrentRow.Cells[1].Value;
            //img.Save(ms, ImageFormat.jpg);
            //user.pictureBox1.Image = Image.FromStream(ms);
            customer.Show();
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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
         

        
    }
}
