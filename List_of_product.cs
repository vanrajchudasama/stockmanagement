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
    public partial class List_of_product : Form
    {
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable td = new DataTable();

        public List_of_product()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void List_of_product_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            da = new SqlDataAdapter("select id as 'Id',Product_nm as 'Product Name',category as 'category',subcat as 'Subcategory',description as 'description',cost_p as 'Cost Price',selling_p as 'Selling price',reorder_p as'Reorder',opening_stock as 'Opening_stock',discount as 'Discount',gst as 'GST',date as 'Date',img as 'Img' from product_entry", db.cn);
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

     

        private void btnref_Click(object sender, EventArgs e)
        {

            dataGridView1.EnableHeadersVisualStyles = false;

            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);

            }


            da = new SqlDataAdapter("select id as 'Id',Product_nm as 'Product Name',category as 'category',subcat as 'Subcategory',description as 'description',cost_p as 'Cost Price',selling_p as 'Selling price',reorder_p as'Reorder',opening_stock as 'Opening_stock',discount as 'Discount',gst as 'GST',date as'Date',img as 'Img' from product_entry", db.cn);
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

        private void txtproductnm_Leave(object sender, EventArgs e)
        {
            if (txtproductnm.Text == "")
            {
                txtproductnm.Text = "Search By Product Name";
                txtproductnm.ForeColor = Color.Silver;
            }
        }

        private void txtproductnm_Enter(object sender, EventArgs e)
        {
            if (txtproductnm.Text == "Search By Product Name")
            {
                txtproductnm.Text = "";
                txtproductnm.ForeColor = Color.Black;
            }
        }

        private void btnname_Click(object sender, EventArgs e)
        {

            string query = "select id as 'Id',Product_nm as 'Product Name',category as 'category',subcat as 'Subcategory',description as 'description',cost_p as 'Cost Price',selling_p as 'Selling price',reorder_p as'Reorder',opening_stock as 'Opening_stock',discount as 'Discount',gst as 'GST',date as'Date',img as 'Img' from product_entry where product_nm='" + txtproductnm.Text + "'";
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

        public void data()
        {
            string query = "select id as 'Id',Product_nm as 'Product Name',category as 'category',subcat as 'Subcategory',description as 'description',cost_p as 'Cost Price',selling_p as 'Selling price',reorder_p as'Reorder',opening_stock as 'Opening_stock',discount as 'Discount',gst as 'GST',date as'Date',img as 'Img' from product_entry where date='" + txtpdate.Text + "'";
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
        private void txtproductnm_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbdate_ValueChanged(object sender, EventArgs e)
        {
            txtpdate.Text = cmbdate.Value.ToString("dd/MM/yyyy");
        }

        private void cmbpdate_Click(object sender, EventArgs e)
        {
            data();

        }

        private void txtpdate_Enter(object sender, EventArgs e)
        {
            if (txtpdate.Text == "Search By Date")
            {
                txtpdate.Text = "";
                txtpdate.ForeColor = Color.Black;
            }
        }

        private void txtpdate_Leave(object sender, EventArgs e)
        {
            if (txtpdate.Text == "")
            {
                txtpdate.Text = "Search By Date";
                txtpdate.ForeColor = Color.Silver;
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


