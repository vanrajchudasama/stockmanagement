namespace stock_management_system
{
    partial class List_of_user_regitration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_of_user_regitration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbd = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btncontact = new System.Windows.Forms.Button();
            this.txtcontact = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(493, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 38);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Silver;
            this.txtname.Location = new System.Drawing.Point(304, 69);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(186, 35);
            this.txtname.TabIndex = 3;
            this.txtname.Text = "Search By Name";
            this.txtname.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtname.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(23, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 10);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(223, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 38);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.ForeColor = System.Drawing.Color.Silver;
            this.txtdate.Location = new System.Drawing.Point(34, 69);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(186, 35);
            this.txtdate.TabIndex = 1;
            this.txtdate.Text = "Search By Date";
            this.txtdate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtdate.Leave += new System.EventHandler(this.textBox2_Leave);
            this.txtdate.Enter += new System.EventHandler(this.textBox2_Enter);
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(881, 247);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ck
            // 
            this.ck.HeaderText = "Select";
            this.ck.Name = "ck";
            this.ck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmbd
            // 
            this.cmbd.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbd.Location = new System.Drawing.Point(203, 70);
            this.cmbd.MaxDate = new System.DateTime(2140, 12, 31, 0, 0, 0, 0);
            this.cmbd.MinDate = new System.DateTime(1958, 10, 28, 0, 0, 0, 0);
            this.cmbd.Name = "cmbd";
            this.cmbd.Size = new System.Drawing.Size(17, 32);
            this.cmbd.TabIndex = 4;
            this.cmbd.Value = new System.DateTime(2018, 6, 29, 0, 0, 0, 0);
            this.cmbd.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 39);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(848, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 6;
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
            this.label1.Location = new System.Drawing.Point(343, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "List of User";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(853, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 36);
            this.button3.TabIndex = 0;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.refreshj_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 10);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(920, 10);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 384);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(910, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 384);
            this.panel6.TabIndex = 12;
            // 
            // btncontact
            // 
            this.btncontact.BackColor = System.Drawing.Color.White;
            this.btncontact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncontact.BackgroundImage")));
            this.btncontact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncontact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontact.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontact.ForeColor = System.Drawing.Color.White;
            this.btncontact.Location = new System.Drawing.Point(777, 68);
            this.btncontact.Name = "btncontact";
            this.btncontact.Size = new System.Drawing.Size(70, 38);
            this.btncontact.TabIndex = 6;
            this.btncontact.UseVisualStyleBackColor = false;
            this.btncontact.Click += new System.EventHandler(this.btncontact_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.ForeColor = System.Drawing.Color.Silver;
            this.txtcontact.Location = new System.Drawing.Point(587, 70);
            this.txtcontact.Multiline = true;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(186, 35);
            this.txtcontact.TabIndex = 5;
            this.txtcontact.Text = "Search By Contact";
            this.txtcontact.Leave += new System.EventHandler(this.txtcontact_Leave);
            this.txtcontact.Enter += new System.EventHandler(this.txtcontact_Enter);
            // 
            // List_of_user_regitration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 404);
            this.Controls.Add(this.btncontact);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List_of_user_regitration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_of_user_regitration";
            this.Load += new System.EventHandler(this.List_of_user_regitration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker cmbd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ck;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btncontact;
        private System.Windows.Forms.TextBox txtcontact;
    }
}