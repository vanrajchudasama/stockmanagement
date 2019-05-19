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
    public partial class List_of_Salesman : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable td = new DataTable();

         
        public List_of_Salesman()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void List_of_Salesman_Load(object sender, EventArgs e)
        {
            //cmbd1.Format = DateTimePickerFormat.Custom;
            //cmbd1.CustomFormat = "dd/MM/yyyy";

            //cmbd2.Format = DateTimePickerFormat.Custom;
            //cmbd2.CustomFormat = "dd/MM/yyyy";

            dataGridView1.EnableHeadersVisualStyles = false;

            da = new SqlDataAdapter("select sa_id as 'Id',sa_name as 'Salesman Name',sa_contact as 'Contact',sa_address as 'Address',sa_gender as 'Gender',sa_city as 'City',sa_state as 'State',sa_country as 'Country', sa_aadhar as 'Aadhar No.',sa_email as 'Email',sa_date as 'Regitration Date',sa_pin as'Pin No.',sa_commision as 'Commision',img as'Image' from salesman_regitration",db.cn);
            da.Fill(td);
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);

            }


            da = new SqlDataAdapter("select sa_id as 'Id',sa_name as 'Salesman Name',sa_contact as 'Contact',sa_address as 'Address',sa_gender as 'Gender',sa_city as 'City',sa_state as 'State',sa_country as 'Country', sa_aadhar as 'Aadhar No.',sa_email as 'Email',sa_date as 'Regitration Date',sa_pin as'Pin No.',sa_commision as 'Commision',img as'Image' from salesman_regitration",db.cn);
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncontact_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndate_Click(object sender, EventArgs e)
        {
             string query = "select sa_id as 'Id',sa_name as 'Salesman Name',sa_contact as 'Contact',sa_address as 'Address',sa_gender as 'Gender',sa_city as 'City',sa_state as 'State',sa_country as 'Country', sa_aadhar as 'Aadhar No.',sa_email as 'Email',sa_date as 'Regitration Date',sa_pin as'Pin No.',sa_commision as 'Commision',img as'Image' from salesman_regitration where sa_date='" + txtdate2.Text + "'"; 

            //string query = "select sa_id as 'Id',sa_name as 'Salesman Name',sa_contact as 'Contact',sa_address as 'Address',sa_gender as 'Gender',sa_city as 'City',sa_state as 'State',sa_country as 'Country', sa_aadhar as 'Aadhar No.',sa_email as 'Email',sa_date as 'Regitration Date',sa_pin as'Pin No.',sa_commision as 'Commision',img as'Image' from salesman_regitration where sa_date between '" + cmbd1.Value.ToString() + "' and '" + cmbd2.Value.ToString() + "'";

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

        private void cmbd_ValueChanged(object sender, EventArgs e)
        {
            txtdate2.Text =cmbd2.Value.ToString("dd/MM/yyyy");
        }


        public void finddatacon()
        {
            string query = "select sa_id as 'Id',sa_name as 'Salesman Name',sa_contact as 'Contact',sa_address as 'Address',sa_gender as 'Gender',sa_city as 'City',sa_state as 'State',sa_country as 'Country', sa_aadhar as 'Aadhar No.',sa_email as 'Email',sa_date as 'Regitration Date',sa_pin as'Pin No.',sa_commision as 'Commision',img as'Image' from salesman_regitration where sa_contact='" + txtcontact.Text + "'"; ;

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


        private void btnname_Click(object sender, EventArgs e)
        {
            finddata();
            txtname.Clear();
        }
        public void finddata()
        {
            string query = "select sa_id as 'Id',sa_name as 'Salesman Name',sa_contact as 'Contact',sa_address as 'Address',sa_gender as 'Gender',sa_city as 'City',sa_state as 'State',sa_country as 'Country', sa_aadhar as 'Aadhar No.',sa_email as 'Email',sa_date as 'Regitration Date',sa_pin as'Pin No.',sa_commision as 'Commision',img as'Image' from salesman_regitration where sa_name='" + txtname.Text + "'"; ;

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

        private void btncontact_Click_1(object sender, EventArgs e)
        {

        }

        private void btncontact_Click_2(object sender, EventArgs e)
        {
            finddatacon();
            txtcontact.Clear();

        }

        private void txtdate_Enter(object sender, EventArgs e)
        {
            //if (txtdate1.Text == "Search By Date")
            //{
            //    txtdate1.Text = "";
            //    txtdate1.ForeColor = Color.Black;
            //}
        }

        private void txtdate_Leave(object sender, EventArgs e)
        {
            //if (txtdate1.Text == "")
            //{
            //    txtdate1.Text = "Search By Date";
            //    txtdate1.ForeColor = Color.Silver;
            //}
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

        private void cmbd1_ValueChanged(object sender, EventArgs e)
        {
            //txtdate1.Text = cmbd1.Value.ToString("dd/MM/yyyy");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtdate2_TextChanged(object sender, EventArgs e)
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

        private void cmbd2_ValueChanged(object sender, EventArgs e)
        {
            txtdate2.Text =cmbd2.Value.ToString("dd/MM/yyyy");
        }

        private void txtdate2_Enter(object sender, EventArgs e)
        {
            if (txtdate2.Text == "Search By Date")
            {
                txtdate2.Text = "";
                txtdate2.ForeColor = Color.Black;
            }
        }

        private void txtdate2_Leave(object sender, EventArgs e)
        {
            if (txtdate2.Text == "")
            {
                txtdate2.Text = "Search By Date";
                txtdate2.ForeColor = Color.Silver;
            }
        }

       
        }
    }

