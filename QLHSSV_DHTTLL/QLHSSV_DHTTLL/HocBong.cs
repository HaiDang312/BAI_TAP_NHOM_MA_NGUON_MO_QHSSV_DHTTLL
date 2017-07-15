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
    public partial class HocBong : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;

        public HocBong()
        {
            InitializeComponent();
        }

        class Bien
        {
            public static string maHB = "";
            public static string mucHB = "";
            public static string soTien = "";
            public static string tenHB = "";

        }
        DataTable LoaiHocBong()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT MAHB,TENHB,MUCHB,SOTIEN FROM LOAIHOCBONG", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        void themHocBong(string MaHB, string MucHB,string SoTien, string TenHB )
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO LOAIHOCBONG VALUES(N'" + MaHB + "',N'" + MucHB + "',N'" + SoTien + "',N'" + TenHB + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaHocBong(string MaHB, string MucHB, string SoTien, string TenHB)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE LOAIHOCBONG SET MUCHB='" + MucHB + "', SOTIEN='" + SoTien + "', TENHB='" + TenHB + "' WHERE MAHB='" + MaHB + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaHocBong(string MaHB)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM LOAIHOCBONG WHERE MAHB='" + MaHB + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        private void HocBong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoaiHocBong();
            dataGridView1.Columns[0].HeaderText = "Mã HB";
            dataGridView1.Columns[1].HeaderText = "Tên HB";
            dataGridView1.Columns[2].HeaderText = "Mức HB";
            dataGridView1.Columns[3].HeaderText = "Số tiền";

            dataGridView1.Columns[0].Width = 10;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 10;
            dataGridView1.Columns[3].Width = 110;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            themHocBong(txtMaHB.Text,txtMucHB.Text,txtSoTien.Text,txtTenHB.Text);
            txtMaHB.Text = "";
            txtTenHB.Text = "";
            txtMucHB.Text = "";
            txtSoTien.Text = "";
            this.HocBong_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adap.UpdateCommand = new SqlCommand("SP_loaiHocBong_Update", dbConn);
            adap.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adap.UpdateCommand.Parameters.Add("@MAHB", SqlDbType.VarChar).SourceColumn = "MAHB";
            adap.UpdateCommand.Parameters.Add("@TENHB", SqlDbType.NVarChar).SourceColumn = "TENHB";
            adap.UpdateCommand.Parameters.Add("@MUCHB", SqlDbType.VarChar).SourceColumn = "MUCHB";
            adap.UpdateCommand.Parameters.Add("@SOTIEN", SqlDbType.NVarChar).SourceColumn = "SOTIEN";
            adap.Update(ds);
            dbConn.Close();
            suaHocBong(txtMaHB.Text, txtMucHB.Text, txtSoTien.Text, txtTenHB.Text);
            txtMaHB.Text = "";
            txtTenHB.Text = "";
            txtMucHB.Text = "";
            txtSoTien.Text = "";
            this.HocBong_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;


            Bien.maHB = row.Cells["MAHB"].Value.ToString();
            Bien.tenHB = row.Cells["TENHB"].Value.ToString();
            Bien.mucHB = row.Cells["MUCHB"].Value.ToString();
            Bien.soTien = row.Cells["SOTIEN"].Value.ToString();

            MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            xoaHocBong(Bien.maHB);
            txtMaHB.Text = "";
            txtTenHB.Text = "";
            txtMucHB.Text = "";
            txtSoTien.Text = "";
            this.HocBong_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.HocBong_Load(sender, e);
        }
    }
}
