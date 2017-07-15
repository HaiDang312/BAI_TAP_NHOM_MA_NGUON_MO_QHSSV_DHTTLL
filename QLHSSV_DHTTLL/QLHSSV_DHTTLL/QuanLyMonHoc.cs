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
    public partial class QuanLyMonHoc : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;

        public QuanLyMonHoc()
        {
            InitializeComponent();
        }

        class Bien
        {
            public static string maMonHoc = "";
            public static string tenMonHoc = "";
            public static string soTiet = "";

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
 
        void themMonHoc(string maMonHoc, string tenMonHoc, string soTiet)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO MONHOC VALUES(N'" + maMonHoc + "',N'" + tenMonHoc + "',N'" + soTiet + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaMonHoc(string maMonHoc, string tenMonHoc, string soTiet)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE MONHOC SET TENMH=N'" + tenMonHoc + "', SOTIET='" + soTiet + "' WHERE MAMH='" + maMonHoc + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaMonHoc(string maMonHoc)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM MONHOC WHERE MAMH='" + maMonHoc + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        private void binding()
        {
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dataGridView1.DataSource, "MAMH");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", dataGridView1.DataSource, "TENMH");
            txtSoTiet.DataBindings.Clear();
            txtSoTiet.DataBindings.Add("Text", dataGridView1.DataSource, "SOTIET");
        }
        private void QuanLyMonHoc_Load(object sender, EventArgs e)
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

            binding();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            themMonHoc(txtMaLop.Text, txtTenLop.Text, txtSoTiet.Text);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtSoTiet.Text = "";
            this.QuanLyMonHoc_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adap.UpdateCommand = new SqlCommand("SP_MONHOC_Update", dbConn);
            adap.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adap.UpdateCommand.Parameters.Add("@MaMH", SqlDbType.VarChar).SourceColumn = "MAMH";
            adap.UpdateCommand.Parameters.Add("@TenMH", SqlDbType.NVarChar).SourceColumn = "TENMH";
            adap.UpdateCommand.Parameters.Add("@SoTiet", SqlDbType.Real).SourceColumn = "SOTIET";
            adap.Update(ds);
            dbConn.Close();
            suaMonHoc(txtMaLop.Text, txtTenLop.Text, txtSoTiet.Text);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtSoTiet.Text = "";
            this.QuanLyMonHoc_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;


            Bien.maMonHoc = row.Cells["MAMH"].Value.ToString();
            Bien.tenMonHoc = row.Cells["TENMH"].Value.ToString();
            Bien.soTiet = row.Cells["SOTIET"].Value.ToString();

            MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            xoaMonHoc(Bien.maMonHoc);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtSoTiet.Text = "";
            this.QuanLyMonHoc_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.QuanLyMonHoc_Load(sender, e);
        }
    }
}
