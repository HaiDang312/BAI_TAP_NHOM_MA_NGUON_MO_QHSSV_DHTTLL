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
    public partial class diemSVTheoMonHoc : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;

        public diemSVTheoMonHoc()
        {
            InitializeComponent();
        }
        
        DataTable MONHOC()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT * FROM MONHOC", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void diemSVTheoMonHoc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MONHOC();
            dataGridView1.Columns[0].HeaderText = "Mã môn học";
            dataGridView1.Columns[1].HeaderText = "Tên môn học";
            dataGridView1.Columns[2].HeaderText = "Số tiết";

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 70;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;


            BienMH.maMonHoc = row.Cells["MAMH"].Value.ToString();
            BienMH.tenMonHoc = row.Cells["TENMH"].Value.ToString();
            BienMH.soTiet = row.Cells["SOTIET"].Value.ToString();

            nhapDiem f = new nhapDiem();
            f.Show();
            
            //txtMaMon.Text = BienMH.maMonHoc;
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
