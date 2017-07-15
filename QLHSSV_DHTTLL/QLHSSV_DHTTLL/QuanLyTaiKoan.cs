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
    public partial class QuanLyTaiKoan : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;
        public QuanLyTaiKoan()
        {
            InitializeComponent();
        }

        DataTable DangKy()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT * FROM DANGNHAP", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }

        void xoaKhoa(string ID)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM DANGNHAP WHERE id='" + ID + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        private void QuanLyTaiKoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DangKy();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns[3].HeaderText = "Mật khẩu";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 225;
            dataGridView1.Columns[2].Width = 255;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemTaiKhoan f = new ThemTaiKhoan();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;
            BienDN.id = row.Cells["id"].Value.ToString();
            BienDN.hoTen = row.Cells["hoTen"].Value.ToString();
            BienDN.tenDN = row.Cells["tenDangNhap"].Value.ToString();
            BienDN.MK = row.Cells["matKhau"].Value.ToString();
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            xoaKhoa(BienDN.id);
            this.QuanLyTaiKoan_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adap.UpdateCommand = new SqlCommand("SP_DANGNHAP_Update", dbConn);
            adap.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adap.UpdateCommand.Parameters.Add("@id", SqlDbType.VarChar).SourceColumn = "id";
            adap.UpdateCommand.Parameters.Add("@hoTen", SqlDbType.NVarChar).SourceColumn = "hoTen";
            adap.UpdateCommand.Parameters.Add("@tenDangNhap", SqlDbType.NVarChar).SourceColumn = "tenDangNhap";
            adap.UpdateCommand.Parameters.Add("@matKhau", SqlDbType.NVarChar).SourceColumn = "matKhau";
            adap.Update(ds);
            dbConn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
