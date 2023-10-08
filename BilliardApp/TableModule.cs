﻿using System;
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
    public partial class TableModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Table table;

        public TableModule(Table tb)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            table = tb;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Dùng để chèn tên bàn vào bảng bàn
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có chắc muốn thêm bàn này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO TABLES(TableName, status) VALUES(@TableName, 'Ready')", cn);
                    cm.Parameters.AddWithValue("@TableName", txtTableName.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Bản ghi đã được lưu thành công", "POS");
                    Clear();
                    table.LoadTable();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtTableName.Clear();
<<<<<<< HEAD
=======
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtTableName.Focus();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // update Table name
            if(MessageBox.Show("Bạn có chắc muốn chỉnh sửa bàn này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE TABLES SET TableName = @TableName WHERE TableId LIKE '"+ lblid.Text +"'", cn);
                cm.Parameters.AddWithValue("@TableName", txtTableName.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Bản ghi đã được chỉnh sửa thành công", "POS");
                Clear();
                this.Dispose(); // Để đóng form TableModule sau khi update
            }
>>>>>>> df2ae5d46e672938cb5c684ae1fffe33a1693e22
        }
    }
}
