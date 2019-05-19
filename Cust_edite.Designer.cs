namespace stock_management_system
{
    partial class Cust_edite
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cust_edite));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbm = new System.Windows.Forms.RadioButton();
            this.rdbf = new System.Windows.Forms.RadioButton();
            this.rdbo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbstate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbcountry = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbwose = new System.Windows.Forms.Button();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtaadhar = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 44);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(648, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(207, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Customer Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(233, 23);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(85, 27);
            this.txtid.TabIndex = 1;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Navy;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(0, 19);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(102, 36);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer Name  :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(233, 67);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(186, 29);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtname.Leave += new System.EventHandler(this.txtdate_Leave);
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            this.txtname.Enter += new System.EventHandler(this.txtdate_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Gender  :";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // rdbm
            // 
            this.rdbm.AutoSize = true;
            this.rdbm.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbm.Location = new System.Drawing.Point(225, 111);
            this.rdbm.Name = "rdbm";
            this.rdbm.Size = new System.Drawing.Size(62, 27);
            this.rdbm.TabIndex = 3;
            this.rdbm.TabStop = true;
            this.rdbm.Text = "Male";
            this.rdbm.UseVisualStyleBackColor = true;
            // 
            // rdbf
            // 
            this.rdbf.AutoSize = true;
            this.rdbf.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbf.Location = new System.Drawing.Point(293, 111);
            this.rdbf.Name = "rdbf";
            this.rdbf.Size = new System.Drawing.Size(81, 27);
            this.rdbf.TabIndex = 5;
            this.rdbf.TabStop = true;
            this.rdbf.Text = "Female";
            this.rdbf.UseVisualStyleBackColor = true;
            // 
            // rdbo
            // 
            this.rdbo.AutoSize = true;
            this.rdbo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbo.Location = new System.Drawing.Point(380, 111);
            this.rdbo.Name = "rdbo";
            this.rdbo.Size = new System.Drawing.Size(66, 27);
            this.rdbo.TabIndex = 6;
            this.rdbo.TabStop = true;
            this.rdbo.Text = "Other";
            this.rdbo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address  :";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(233, 159);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(186, 96);
            this.txtaddress.TabIndex = 4;
            this.txtaddress.Leave += new System.EventHandler(this.txtdate_Leave);
            this.txtaddress.Enter += new System.EventHandler(this.txtdate_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Aadhar No :";
            this.label7.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbcity
            // 
            this.cmbcity.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.Items.AddRange(new object[] {
            "Select City",
            "Una",
            "Dhokadva",
            "Rajkot"});
            this.cmbcity.Location = new System.Drawing.Point(233, 325);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(186, 33);
            this.cmbcity.TabIndex = 6;
            this.cmbcity.Leave += new System.EventHandler(this.cmbcity_Leave);
            this.cmbcity.Enter += new System.EventHandler(this.cmbcity_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "City  :";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 27);
            this.label9.TabIndex = 1;
            this.label9.Text = "State  :";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbstate
            // 
            this.cmbstate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.Items.AddRange(new object[] {
            "Select State",
            "Gujarat",
            "up"});
            this.cmbstate.Location = new System.Drawing.Point(233, 373);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(186, 33);
            this.cmbstate.TabIndex = 7;
            this.cmbstate.Leave += new System.EventHandler(this.cmbstate_Leave);
            this.cmbstate.Enter += new System.EventHandler(this.cmbstate_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(100, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 27);
            this.label10.TabIndex = 1;
            this.label10.Text = "Country  :";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbcountry
            // 
            this.cmbcountry.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcountry.FormattingEnabled = true;
            this.cmbcountry.Items.AddRange(new object[] {
            "Select Country",
            "Indian"});
            this.cmbcountry.Location = new System.Drawing.Point(233, 418);
            this.cmbcountry.Name = "cmbcountry";
            this.cmbcountry.Size = new System.Drawing.Size(186, 33);
            this.cmbcountry.TabIndex = 8;
            this.cmbcountry.Leave += new System.EventHandler(this.cmbcountry_Leave);
            this.cmbcountry.Enter += new System.EventHandler(this.cmbcountry_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 27);
            this.label11.TabIndex = 1;
            this.label11.Text = "Registration Date  :";
            this.label11.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.White;
            this.txtdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(233, 465);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(186, 27);
            this.txtdate.TabIndex = 9;
            this.txtdate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtdate.Leave += new System.EventHandler(this.txtdate_Leave);
            this.txtdate.Enter += new System.EventHandler(this.txtdate_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 510);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 27);
            this.label12.TabIndex = 1;
            this.label12.Text = "Pincode No  :";
            this.label12.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtpin
            // 
            this.txtpin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpin.Location = new System.Drawing.Point(233, 510);
            this.txtpin.MaxLength = 6;
            this.txtpin.Name = "txtpin";
            this.txtpin.Size = new System.Drawing.Size(186, 29);
            this.txtpin.TabIndex = 10;
            this.txtpin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtpin.Leave += new System.EventHandler(this.txtdate_Leave);
            this.txtpin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpin_KeyPress);
            this.txtpin.Enter += new System.EventHandler(this.txtdate_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(65, 549);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 27);
            this.label13.TabIndex = 1;
            this.label13.Text = "Contact No  :";
            this.label13.Click += new System.EventHandler(this.label4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(91, 589);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 27);
            this.label14.TabIndex = 1;
            this.label14.Text = "Email  Id  :";
            this.label14.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(233, 589);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(186, 29);
            this.txtemail.TabIndex = 12;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtemail.Leave += new System.EventHandler(this.txtdate_Leave);
            this.txtemail.Enter += new System.EventHandler(this.txtdate_Enter);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Navy;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(0, 61);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(102, 36);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Navy;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(0, 143);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(102, 36);
            this.btnclose.TabIndex = 17;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Location = new System.Drawing.Point(573, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 188);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "View Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbwose
            // 
            this.btnbwose.BackColor = System.Drawing.Color.Navy;
            this.btnbwose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbwose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbwose.ForeColor = System.Drawing.Color.White;
            this.btnbwose.Location = new System.Drawing.Point(25, 125);
            this.btnbwose.Name = "btnbwose";
            this.btnbwose.Size = new System.Drawing.Size(90, 32);
            this.btnbwose.TabIndex = 13;
            this.btnbwose.Text = "Browse...";
            this.btnbwose.UseVisualStyleBackColor = false;
            this.btnbwose.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // cmbid
            // 
            this.cmbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(339, 23);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(80, 28);
            this.cmbid.TabIndex = 0;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 730);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 10);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 730);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(706, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 730);
            this.panel4.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(696, 10);
            this.panel5.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcontact);
            this.groupBox2.Controls.Add(this.txtaadhar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbid);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rdbo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbcountry);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtpin);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.cmbstate);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbcity);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Controls.Add(this.rdbm);
            this.groupBox2.Controls.Add(this.rdbf);
            this.groupBox2.Location = new System.Drawing.Point(25, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 636);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // txtcontact
            // 
            this.txtcontact.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(233, 549);
            this.txtcontact.MaxLength = 10;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(186, 29);
            this.txtcontact.TabIndex = 11;
            this.txtcontact.Leave += new System.EventHandler(this.txtcontact_Leave_1);
            this.txtcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontact_KeyPress_1);
            this.txtcontact.Enter += new System.EventHandler(this.txtcontact_Enter_1);
            // 
            // txtaadhar
            // 
            this.txtaadhar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaadhar.Location = new System.Drawing.Point(233, 277);
            this.txtaadhar.Mask = "0000 0000 0000";
            this.txtaadhar.Name = "txtaadhar";
            this.txtaadhar.Size = new System.Drawing.Size(186, 29);
            this.txtaadhar.TabIndex = 5;
            this.txtaadhar.Leave += new System.EventHandler(this.txtaadhar_Leave);
            this.txtaadhar.Enter += new System.EventHandler(this.txtaadhar_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btnbwose);
            this.groupBox3.Location = new System.Drawing.Point(549, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 160);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // Cust_edite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 740);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cust_edite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cust_edite";
            this.Load += new System.EventHandler(this.Cust_edite_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbwose;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.RadioButton rdbm;
        public System.Windows.Forms.RadioButton rdbf;
        public System.Windows.Forms.RadioButton rdbo;
        public System.Windows.Forms.TextBox txtaddress;
        public System.Windows.Forms.ComboBox cmbcity;
        public System.Windows.Forms.ComboBox cmbstate;
        public System.Windows.Forms.ComboBox cmbcountry;
        public System.Windows.Forms.TextBox txtdate;
        public System.Windows.Forms.TextBox txtpin;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtaadhar;
        public System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}