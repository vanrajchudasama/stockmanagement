namespace stock_management_system
{
    partial class list_of_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_of_supplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnr = new System.Windows.Forms.Button();
            this.btncontact = new System.Windows.Forms.Button();
            this.btndate = new System.Windows.Forms.Button();
            this.txtscontact = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtsdate = new System.Windows.Forms.TextBox();
            this.btnname = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnr
            // 
            this.btnr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnr.BackgroundImage")));
            this.btnr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr.ForeColor = System.Drawing.Color.White;
            this.btnr.Location = new System.Drawing.Point(935, 71);
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
            this.btncontact.Location = new System.Drawing.Point(787, 68);
            this.btncontact.Name = "btncontact";
            this.btncontact.Size = new System.Drawing.Size(70, 38);
            this.btncontact.TabIndex = 10;
            this.btncontact.UseVisualStyleBackColor = false;
            this.btncontact.Click += new System.EventHandler(this.btncontact_Click);
            // 
            // btndate
            // 
            this.btndate.BackColor = System.Drawing.Color.White;
            this.btndate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndate.BackgroundImage")));
            this.btndate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndate.ForeColor = System.Drawing.Color.White;
            this.btndate.Location = new System.Drawing.Point(194, 67);
            this.btndate.Name = "btndate";
            this.btndate.Size = new System.Drawing.Size(70, 38);
            this.btndate.TabIndex = 9;
            this.btndate.UseVisualStyleBackColor = false;
            this.btndate.Click += new System.EventHandler(this.btndate_Click);
            // 
            // txtscontact
            // 
            this.txtscontact.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscontact.ForeColor = System.Drawing.Color.Silver;
            this.txtscontact.Location = new System.Drawing.Point(631, 72);
            this.txtscontact.Multiline = true;
            this.txtscontact.Name = "txtscontact";
            this.txtscontact.Size = new System.Drawing.Size(150, 28);
            this.txtscontact.TabIndex = 11;
            this.txtscontact.Text = "Search By Contact";
            this.txtscontact.Leave += new System.EventHandler(this.txtscontact_Leave);
            this.txtscontact.Enter += new System.EventHandler(this.txtscontact_Enter);
            // 
            // txtsname
            // 
            this.txtsname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsname.ForeColor = System.Drawing.Color.Silver;
            this.txtsname.Location = new System.Drawing.Point(346, 73);
            this.txtsname.Multiline = true;
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(138, 28);
            this.txtsname.TabIndex = 8;
            this.txtsname.Text = "Search By Name";
            this.txtsname.TextChanged += new System.EventHandler(this.txtsname_TextChanged);
            this.txtsname.Leave += new System.EventHandler(this.txtsname_Leave);
            this.txtsname.Enter += new System.EventHandler(this.txtsname_Enter);
            // 
            // txtsdate
            // 
            this.txtsdate.BackColor = System.Drawing.Color.White;
            this.txtsdate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdate.ForeColor = System.Drawing.Color.Silver;
            this.txtsdate.Location = new System.Drawing.Point(53, 72);
            this.txtsdate.Multiline = true;
            this.txtsdate.Name = "txtsdate";
            this.txtsdate.ReadOnly = true;
            this.txtsdate.Size = new System.Drawing.Size(138, 28);
            this.txtsdate.TabIndex = 7;
            this.txtsdate.Text = "Search By Date";
            this.txtsdate.Leave += new System.EventHandler(this.txtsdate_Leave);
            this.txtsdate.Enter += new System.EventHandler(this.txtsdate_Enter);
            // 
            // btnname
            // 
            this.btnname.BackColor = System.Drawing.Color.White;
            this.btnname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnname.BackgroundImage")));
            this.btnname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnname.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnname.ForeColor = System.Drawing.Color.White;
            this.btnname.Location = new System.Drawing.Point(490, 68);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(70, 38);
            this.btnname.TabIndex = 13;
            this.btnname.UseVisualStyleBackColor = false;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 40);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(932, 4);
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
            this.label1.Location = new System.Drawing.Point(378, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "List   of   Supplier";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(16, 27);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(997, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 413);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 413);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(987, 10);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 403);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(987, 10);
            this.panel5.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(20, 117);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(970, 10);
            this.panel6.TabIndex = 21;
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(969, 259);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.VirtualMode = true;
            // 
            // ck
            // 
            this.ck.HeaderText = "Select";
            this.ck.Name = "ck";
            this.ck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // list_of_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btncontact);
            this.Controls.Add(this.btndate);
            this.Controls.Add(this.txtscontact);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.txtsdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "list_of_supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "list_of_supplier";
            this.Load += new System.EventHandler(this.list_of_supplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button btncontact;
        private System.Windows.Forms.Button btndate;
        private System.Windows.Forms.TextBox txtscontact;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.TextBox txtsdate;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ck;
    }
}