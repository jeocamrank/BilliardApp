using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
>>>>>>> df2ae5d46e672938cb5c684ae1fffe33a1693e22
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardApp
{
    internal class DBConnect
    {
        private string con;
        public string myConnection()
        {
<<<<<<< HEAD
            con = @"Data Source=DESKTOP-8EJEBRE;Initial Catalog=BillardApp;Integrated Security=True";
=======
            con = @"Data Source=DESKTOP-FC6I5GK;Initial Catalog=BilliardApp;Integrated Security=True";
>>>>>>> df2ae5d46e672938cb5c684ae1fffe33a1693e22
            return con;
        }
    }
}
