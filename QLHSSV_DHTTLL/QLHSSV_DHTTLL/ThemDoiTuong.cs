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
    public partial class ThemDoiTuong : Form
    {
        public ThemDoiTuong()
        {
            InitializeComponent();
        }

        void themSVDT(string maSV, string maDT)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO SV_DOITUONG VALUES('" + maSV + "','" + maDT + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaSVDT(string maSV, string maDT)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE SV_DOITUONG SET MASV=N'" + maSV + "',MADT=N'" + maDT + "' WHERE (MaMH='" + maSV + "') and (MADT=N'" + maDT + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaSVDT(string maSV, string maDT)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM SV_DOITUONG WHERE (MaMH='" + maSV + "') and (MADT=N'" + maDT + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        private void ThemDoiTuong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                themSVDT(txtTenSV.Text, txtTenDT.Text);
                labThongBao.Text = "Thêm thành công";
            }
            catch
            {
                labThongBao.Text = "Thêm không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                suaSVDT(txtTenSV.Text, txtTenDT.Text);
                labThongBao.Text = "Sửa thành công";
            }
            catch
            {
                labThongBao.Text = "Sửa không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                xoaSVDT(txtTenSV.Text, txtTenDT.Text);
                labThongBao.Text = "Xóa thành công";
            }
            catch
            {
                labThongBao.Text = "Xóa không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
