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
    
    public partial class Khoa : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;
        public Khoa()
        {
            InitializeComponent();
        }
        class Bien
        {
            public static string maKhoa = "";
            public static string tenKhoa = "";

        }
        DataTable KHOA()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT * FROM KHOA", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        void themKhoa(string MaKhoa, string TenKhoa)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO KHOA VALUES(N'" + MaKhoa + "',N'" + TenKhoa + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaKhoa(string MaKhoa, string TenKhoa)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE KHOA SET TENKHOA='" + TenKhoa + "' WHERE MAKHOA='" + MaKhoa + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaKhoa(string MaKhoa)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM KHOA WHERE MAKHOA='" + MaKhoa + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        private void binding()
        {
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dataGridView1.DataSource, "MAKHOA");
            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("Text", dataGridView1.DataSource, "TENKHOA");
        }
        private void Khoa_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = KHOA();
            dataGridView1.Columns[0].HeaderText = "Mã khoa";
            dataGridView1.Columns[1].HeaderText = "Tên khoa";

            dataGridView1.Columns[0].Width = 10;
            dataGridView1.Columns[1].Width = 150;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;

            binding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            themKhoa(txtMaKhoa.Text, txtTenKhoa.Text);
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            this.Khoa_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adap.UpdateCommand = new SqlCommand("SP_KHOA_Update", dbConn);
            adap.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adap.UpdateCommand.Parameters.Add("@MAKHOA", SqlDbType.VarChar).SourceColumn = "MAKHOA";
            adap.UpdateCommand.Parameters.Add("@TENKHOA", SqlDbType.NVarChar).SourceColumn = "TENKHOA";
            adap.Update(ds);
            dbConn.Close();
            suaKhoa(txtMaKhoa.Text, txtTenKhoa.Text);
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            this.Khoa_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;
           

            Bien.maKhoa = row.Cells["MAKHOA"].Value.ToString();
            Bien.tenKhoa = row.Cells["TENKHOA"].Value.ToString();
            
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            xoaKhoa(Bien.maKhoa);
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            this.Khoa_Load(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Khoa_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
