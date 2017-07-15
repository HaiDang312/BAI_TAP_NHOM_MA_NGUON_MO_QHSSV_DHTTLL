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

namespace GUI
{
        
    public partial class InDanhSach_KL : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;
        public InDanhSach_KL()
        {
            InitializeComponent();
        }
        DataTable KYLUAT()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT * FROM KYLUAT", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InDanhSach_KT_KL_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = KYLUAT();
            dataGridView1.Columns[0].HeaderText = "Mã";
            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[2].HeaderText = "Ghi Chú";

            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
        }
    }
}
