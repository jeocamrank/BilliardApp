using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardApp
{
    public partial class Table : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();

        public Table()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        public void LoadTable()
        {
            dgvEmployee.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM TABLES ORDER BY TABLENAME", cn);
        }
    }
}
