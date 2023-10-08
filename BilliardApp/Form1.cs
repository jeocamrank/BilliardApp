using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
<<<<<<< HEAD
=======
//Tung ngu bu dai
>>>>>>> df2ae5d46e672938cb5c684ae1fffe33a1693e22

namespace BilliardApp
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
        }

        #region panelSlide
        public void customizeDesing()
        {
            panelSubUser.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubUser.Visible == true)
            {
                panelSubUser.Visible = false;
            }
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #endregion panelSlide

<<<<<<< HEAD
=======
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitle.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


>>>>>>> df2ae5d46e672938cb5c684ae1fffe33a1693e22
        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubUser);
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnUserAccount_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            openChildForm(new Table());
            hideSubMenu();
>>>>>>> df2ae5d46e672938cb5c684ae1fffe33a1693e22
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {

        }

        private void btnServices_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
