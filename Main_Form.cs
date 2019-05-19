using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stock_management_system
{
    public partial class Main_Form : Form
    {
        private int childFormNumber = 0;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_regitration ud = new User_regitration();
            ud.ShowDialog();
            ud.MdiParent = this;
        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }


        private void fileMenu_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void fileMenu_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            customet_regitration user = new customet_regitration();
            user.ShowDialog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Cust_edite user = new Cust_edite();
            user.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            User_regitration user = new User_regitration();
            user.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            user_Edite user = new user_Edite();
            user.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Company_Info c = new Company_Info();
            c.ShowDialog();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void yujToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void fggfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_regitration user = new User_regitration();

            user.ShowDialog();

              
        }

        private void viweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List_of_user_regitration list = new List_of_user_regitration();

            list.ShowDialog();

        }

        private void fghfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_Edite edit = new user_Edite();

            edit.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customet_regitration cust = new customet_regitration();

            cust.ShowDialog();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list_of_customer list = new list_of_customer();

            list.ShowDialog();

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supplier_edit s = new supplier_edit();
            s.ShowDialog();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
           // this.Close();

            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cust_edite edit = new Cust_edite();

            edit.ShowDialog();

        }

        private void nEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Company_Registration company = new Company_Registration();

            company.ShowDialog();

        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Supplier_Regitration Supplier = new Supplier_Regitration();
            Supplier.ShowDialog();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            list_of_supplier list = new list_of_supplier();

            list.ShowDialog();

        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            salesman_regitration sal = new salesman_regitration();

            sal.ShowDialog();

        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            List_of_Salesman list = new List_of_Salesman();
            list.ShowDialog();

        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            salesman_update update = new salesman_update();
            update.ShowDialog();

        }

        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Company_Info info = new Company_Info();

            info.ShowDialog();

        }

        private void hgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            company_edit edit = new company_edit();
            edit.ShowDialog();

        }
    }
}
