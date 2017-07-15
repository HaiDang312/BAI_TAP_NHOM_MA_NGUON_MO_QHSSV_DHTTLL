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
    public partial class KhenThuongKyLuat : Form
    {
        

        public KhenThuongKyLuat()
        {
            InitializeComponent();
        }
        class BienKL
        {
            public static string maCN = "";
            public static string tenCN = "";

        }
        class BienKT
        {
            public static string maCN = "";
            public static string tenCN = "";

        }
       
        void themKL(string MaKL, string TenKL,string Ghichu)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO KYLUAT VALUES(N'" + MaKL + "',N'" + TenKL + "',N'" + Ghichu + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaKL(string MaKL, string TenKL, string Ghichu)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE KYLUAT SET TENKL='" + TenKL + "',GHICHU='" + Ghichu + "' WHERE MAKL='" + MaKL + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaKL(string MaKL)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM KYLUAT WHERE MAKL='" + MaKL + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }

        void themKT(string MaKT, string TenKT, string Ghichu)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO KHENTHUONG VALUES(N'" + MaKT + "',N'" + TenKT + "',N'" + Ghichu + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaKT(string MaKT, string TenKT, string Ghichu)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE KHENTHUONG SET TENKT='" + TenKT + "',GHICHU='" + Ghichu + "' WHERE MAKT='" + MaKT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaKT(string MaKT)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM KHENTHUONG WHERE MAKL='" + MaKT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaCN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radKL.Checked)
            {
                try 
                {
                    themKL(txtMa.Text, txtTen.Text, txtGhichu.Text);
                    labThongbao.Text = "Thêm thành công";
                }
                catch
                {
                    labThongbao.Text = "Thêm không thành công, vui lòng kiểm tra lại!";
                }
            }
            else
            {
                try
                {
                    themKT(txtMa.Text, txtTen.Text, txtGhichu.Text);
                    labThongbao.Text = "Thêm thành công";
                }
                catch
                {
                    labThongbao.Text = "Thêm không thành công, vui lòng kiểm tra lại!";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radKL.Checked)
            {
                try
                {
                    suaKL(txtMa.Text, txtTen.Text, txtGhichu.Text);
                    labThongbao.Text = "Sửa thành công";
                }
                catch
                {
                    labThongbao.Text = "Sửa không thành công, vui lòng kiểm tra lại!";
                }
            }
            else
            {
                try
                {
                    suaKT(txtMa.Text, txtTen.Text, txtGhichu.Text);
                    labThongbao.Text = "Sửa thành công";
                }
                catch
                {
                    labThongbao.Text = "Sửa không thành công, vui lòng kiểm tra lại!";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radKL.Checked)
            {
                try
                {
                    xoaKL(txtMa.Text);
                    labThongbao.Text = "Xóa thành công";
                }
                catch
                {
                    labThongbao.Text = "Xóa không thành công, vui lòng kiểm tra lại!";
                }
            }
            else
            {
                try
                {
                    xoaKT(txtMa.Text);
                    labThongbao.Text = "Xóa thành công";
                }
                catch
                {
                    labThongbao.Text = "Xóa không thành công, vui lòng kiểm tra lại!";
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void KhenThuongKyLuat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radKL.Checked)
            {
                    InDanhSach_KL f = new InDanhSach_KL();
                    f.Show();
            }
            else
            {
                InDanhSanh_KT f = new InDanhSanh_KT();
                f.Show();
            }
        }
    }
}
