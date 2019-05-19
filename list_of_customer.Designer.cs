namespace stock_management_system
{
    partial class list_of_customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_of_customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnr = new System.Windows.Forms.Button();
            this.btncontact = new System.Windows.Forms.Button();
            this.btnname = new System.Windows.Forms.Button();
            this.btndate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 40);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(934, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "List   of   Customer";
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.ForeColor = System.Drawing.Color.Silver;
            this.txtdate.Location = new System.Drawing.Point(52, 73);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(138, 30);
            this.txtdate.TabIndex = 1;
            this.txtdate.Text = "Search By Date";
            this.txtdate.TextChanged += new System.EventHandler(this.txtdate_TextChanged);
            this.txtdate.Leave += new System.EventHandler(this.txtdate_Leave);
            this.txtdate.Enter += new System.EventHandler(this.txtdate_Enter);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Silver;
            this.txtname.Location = new System.Drawing.Point(355, 75);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(138, 28);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "Search By Name";
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            this.txtname.Enter += new System.EventHandler(this.txtname_Enter);
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.ForeColor = System.Drawing.Color.Silver;
            this.txtcontact.Location = new System.Drawing.Point(644, 75);
            this.txtcontact.Multiline = true;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(150, 28);
            this.txtcontact.TabIndex = 3;
            this.txtcontact.Text = "Search By Contact";
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            this.txtcontact.Leave += new System.EventHandler(this.txtcontact_Leave);
            this.txtcontact.Enter += new System.EventHandler(this.txtcontact_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(16, 27);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnr
            // 
            this.btnr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnr.BackgroundImage")));
            this.btnr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr.ForeColor = System.Drawing.Color.White;
            this.btnr.Location = new System.Drawing.Point(940, 70);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(48, 36);
            this.btnr.TabIndex = 0;
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btncontact
            // 
            this.btncontact.BackColor = System.Drawing.Color.White;
            this.btncontact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncontact.BackgroundImage")));
            this.btncontact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncontact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontact.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontact.ForeColor = System.Drawing.Color.White;
            this.btncontact.Location = new System.Drawing.Point(812, 68);
            this.btncontact.Name = "btncontact";
            this.btncontact.Size = new System.Drawing.Size(70, 38);
            this.btncontact.TabIndex = 2;
            this.btncontact.UseVisualStyleBackColor = false;
            this.btncontact.Click += new System.EventHandler(this.btncontact_Click);
            // 
            // btnname
            // 
            this.btnname.BackColor = System.Drawing.Color.White;
            this.btnname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnname.BackgroundImage")));
            this.btnname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnname.ForeColor = System.Drawing.Color.White;
            this.btnname.Location = new System.Drawing.Point(508, 68);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(70, 38);
            this.btnname.TabIndex = 2;
            this.btnname.UseVisualStyleBackColor = false;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // btndate
            // 
            this.btndate.BackColor = System.Drawing.Color.White;
            this.btndate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndate.BackgroundImage")));
            this.btndate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndate.ForeColor = System.Drawing.Color.White;
            this.btndate.Location = new System.Drawing.Point(209, 69);
            this.btndate.Name = "btndate";
            this.btndate.Size = new System.Drawing.Size(70, 38);
            this.btndate.TabIndex = 2;
            this.btndate.UseVisualStyleBackColor = false;
            this.btndate.Click += new System.EventHandler(this.btndate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 10);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1003, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 399);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 399);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(993, 10);
            this.panel5.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ck});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(24, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(969, 259);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.VirtualMode = true;
            // 
            // ck
            // 
            this.ck.HeaderText = "Select";
            this.ck.Name = "ck";
            this.ck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(25, 118);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(970, 10);
            this.panel6.TabIndex = 12;
            // 
            // list_of_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 409);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btncontact);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.btndate);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "list_of_customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "list_of_customer";
            this.Load += new System.EventHandler(this.list_of_customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Button btndate;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Button btncontact;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ck;
        private System.Windows.Forms.Panel panel6;
    }
}