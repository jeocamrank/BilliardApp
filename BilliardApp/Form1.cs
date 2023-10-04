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
//Tung ngu

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
            panelSubProduct.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelSubProduct.Visible == true)
            {
                panelSubProduct.Visible = false;
            }
        }

        private void showSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible= false;
            }
        }
        #endregion panelSlide

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProduct);
        }
        private void btnProductList_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

    }
}
