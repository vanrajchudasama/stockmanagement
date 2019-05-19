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
    public partial class Category : Form
    {
       
        int i;
        stock_management_system.Connection.con_file db = new stock_management_system.Connection.con_file();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable td = new DataTable();
       


        public Category()
        {
            i = db.connection();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void adddata()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);

            }
            da = new SqlDataAdapter("select id as 'Id',category as 'Category' from Category", db.cn);
            da.Fill(td);
            dataGridView1.DataSource = td;
            
            
        }
    protected  void  count()
        {
            
        }
        private void Category_Load(object sender, EventArgs e)
        {
            btncdelete.Enabled = false;
            btncupdate.Enabled = false;
            
            
            adddata();

        }

        private void btncnew_Click(object sender, EventArgs e)
        {
            txtcategory.Clear();
        }

        private void btncsave_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("select category from Category where category='" + txtcategory.Text + "'", db.cn);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                //Exist=true;
                MessageBox.Show("alredy category is exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int c = 1;
                cmd = new SqlCommand("select id from Category", db.cn);
                dr.Close();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    c = c + 1;
                }
                
                cmd = new SqlCommand("insert into Category(id,category) values('"+c+"','" + txtcategory.Text + "')", db.cn);
                dr.Close();
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Save");
                txtcategory.Text = "";
                adddata();
                
            }
            
        }

        private void btncdelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from Category where category='" +dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", db.cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete....!");
            adddata();
        }

        private void txtcategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txtcategory.Text.Length > 0)
            //{
            //    btncupdate.Enabled = true;
            //    btncdelete.Enabled = true;
            //}
            cmd = new SqlCommand("select category from Category where category='" + txtcategory.Text + "'", db.cn);
            
            SqlDataReader dr = cmd.ExecuteReader();
           
            if (dr.Read())
            {
                if (txtcategory.Text == dr[0].ToString())
                {
                    if (txtcategory.Text.Length > 0)
                    {
                        // MessageBox.Show(dr[0].ToString());
                        dr.Close();
                        btncupdate.Enabled = true;
                        btncdelete.Enabled = true;
                    }
                }
            }
            else
            {
                if (txtcategory.Text.Length > 0)
                {
                    dr.Close();
                    btncupdate.Enabled = false;
                    btncdelete.Enabled = false;
                }
            }
            dr.Close();
            
        }

        private void txtcategory_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btncupdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select category from Category where category='" + txtcategory.Text + "'", db.cn);
            dr = cmd.ExecuteReader();
            if (txtcategory.Text.Length > 0)
            {
                if (dr.Read())
                {
                    btncdelete.Enabled = true;
                    btncupdate.Enabled = true;
                    dr.Close();
                    cmd = new SqlCommand("update  Category set category='" + txtcategory.Text + "' where id='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", db.cn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Update Successfully.........!");
                    adddata();
                }
                else
                {
                    btncdelete.Enabled = false;
                    btncupdate.Enabled = false;
                    MessageBox.Show("Record not Match...!");
                    dr.Close();

                }
            }
            else
            {
                MessageBox.Show("Please Select record");
            }
            //txtcategory.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           // MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString());
           

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure Exit...!", "Worrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtcategory.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            btncupdate.Enabled = true;
            btncdelete.Enabled = true;
        }

        private void txtcategory_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (txtcategory.Text.Length > 1)
            {

            }
            else
            {
                btncdelete.Enabled = false;
                btncupdate.Enabled = false;
            }
        }

        private void txtcategory_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (txtcategory.Text.Length > 1)
            {
                cmd = new SqlCommand("select category from Category where category='" + txtcategory.Text + "'", db.cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // MessageBox.Show(txtcategory.Text);
                    if (txtcategory.Text == dr[0].ToString())
                    {
                        // MessageBox.Show(dr[0].ToString());
                        btncsave.Enabled = false;
                        btncdelete.Enabled = true;
                        btncupdate.Enabled = true;
                        dr.Close();
                    }

                }
                else
                {
                    btncsave.Enabled = true;
                    btncdelete.Enabled = false;
                    btncupdate.Enabled = false;
                    dr.Close();
                }


            }
            else
            {
                btncdelete.Enabled = false;
                btncupdate.Enabled = false;
                dr.Close();
            }
            cmd = new SqlCommand("select category from Category where category='" + txtcategory.Text + "'", db.cn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                btncsave.Enabled = false;
                dr.Close();
            }
            else
            {
                btncsave.Enabled = true;
                dr.Close();
            }
        }
    }
}
