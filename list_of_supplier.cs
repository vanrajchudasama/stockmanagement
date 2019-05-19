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
    public partial class list_of_supplier : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        DataTable ta = new DataTable();
        SqlDataAdapter da;
        public list_of_supplier()
        {
            i = db.connection();
            InitializeComponent();
        }
        public void finddata()
        {
            string query = "select s_id as 'Id',s_name as 'Supplier Name',s_gender as 'Gender',s_address as 'Address',s_aadhar as 'Aadhar No',s_city as 'City',s_state as 'State',s_country as 'Country',s_date as'Regitration Date',s_pin as 'Pin Code No',s_contact as 'Contact',s_email as'Email Id',s_img as'Image' from supplier_regitration where s_name='" + txtsname.Text + "'";

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

        private void list_of_supplier_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            da = new SqlDataAdapter("select s_id as 'Id',s_name as 'Supplier Name',s_gender as 'Gender',s_address as 'Address',s_aadhar as 'Aadhar No',s_city as 'City',s_state as 'State',s_country as 'Country', s_date as 'Regitration Date',s_pin as 'Pin Code No',s_contact as 'Contact',s_email as'Email Id',s_img as'Image' from supplier_regitration", db.cn);
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btndate_Click(object sender, EventArgs e)
        {
            string query = "select s_id as 'Id',s_name as 'Supplier Name',s_gender as 'Gender',s_address as 'Address',s_aadhar as 'Aadhar No',s_city as 'City',s_state as 'State',s_country as 'Country',s_date as'Regitration Date',s_pin as 'Pin Code No',s_contact as 'Contact',s_email as'Email Id',s_img as'Image' from supplier_regitration where s_date='" + txtsdate.Text + "'";

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
            txtsdate.Clear();


        }

        private void txtsdate_Enter(object sender, EventArgs e)
        {
            if (txtsdate.Text == "Search By Date")
            {
                txtsdate.Text = "";
                txtsdate.ForeColor = Color.Black;
            }
        }

        private void txtsdate_Leave(object sender, EventArgs e)
        {
            if (txtsdate.Text == "")
            {
                txtsdate.Text = "Search By Date";
                txtsdate.ForeColor = Color.Silver;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtsdate.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void btnname_Click(object sender, EventArgs e)
        {
            finddata();

            txtsname.Clear();

        }

        private void txtsname_Enter(object sender, EventArgs e)
        {
            if (txtsname.Text == "Search By Name")
            {
                txtsname.Text = "";
                txtsname.ForeColor = Color.Black;
            }
        }

        private void txtsname_Leave(object sender, EventArgs e)
        {
            if (txtsname.Text == "")
            {
                txtsname.Text = "Search By Name";
                txtsname.ForeColor = Color.Silver;
            }
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);

            }


            da = new SqlDataAdapter("select s_id as 'Id',s_name as 'Supplier Name',s_gender as 'Gender',s_address as 'Address',s_aadhar as 'Aadhar No',s_city as 'City',s_state as 'State',s_country as 'Country', s_date as 'Regitration Date',s_pin as 'Pin Code No',s_contact as 'Contact',s_email as'Email Id',s_img as'Image' from supplier_regitration", db.cn);
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

        private void btncontact_Click(object sender, EventArgs e)
        {
            string query = "select s_id as 'Id',s_name as 'Supplier Name',s_gender as 'Gender',s_address as 'Address',s_aadhar as 'Aadhar No',s_city as 'City',s_state as 'State',s_country as 'Country',s_date as'Regitration Date',s_pin as 'Pin Code No',s_contact as 'Contact',s_email as'Email Id',s_img as'Image' from supplier_regitration where s_contact='" + txtscontact.Text + "'";

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
            txtscontact.Clear();
        }

        private void txtscontact_Enter(object sender, EventArgs e)
        {
            if (txtscontact.Text == "Search By Contact")
            {
                txtscontact.Text = "";
                txtscontact.ForeColor = Color.Black;
            }
        }

        private void txtsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtscontact_Leave(object sender, EventArgs e)
        {
            if (txtscontact.Text == "")
            {
                txtscontact.Text = "Search By Contact";
                txtscontact.ForeColor = Color.Silver;
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
