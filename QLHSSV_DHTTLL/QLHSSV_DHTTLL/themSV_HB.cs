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
    public partial class themSV_HB : Form
    {
        public themSV_HB()
        {
            InitializeComponent();
        }
        void themSVHB(string maHB, string maSV, string hocKy)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO HOCBONG VALUES('" + maHB + "','" + maSV + "','" + hocKy + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaSVHB(string maHB, string maSV, string hocKy)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE HOCBONG SET HOCBONG.MAHB='" + maHB + "',HOCBONG.MASV='" + maSV + "',HOCKY='" + hocKy + "' WHERE (MAHB='" + maHB + "')and (HOCBONG.MASV='" + maSV + "') and (HOCKY='" + hocKy + "') ";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaSVHB(string maHB, string maSV, string hocKy)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM HOCBONG WHERE (HOCBONG.MAHB='" + maHB + "') and (HOCBONG.MASV='" + maSV + "') and (HOCKY='" + hocKy + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        private void themSV_HB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                themSVHB(txtMaHB.Text, txtMaSV.Text, txtHocKy.Text);
                labTB.Text = "Thêm thành công";
            }
            catch
            {
                labTB.Text = "Thêm không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                suaSVHB(txtMaHB.Text, txtMaSV.Text, txtHocKy.Text);
                labTB.Text = "Sửa thành công";
            }
            catch
            {
                labTB.Text = "Sửa không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                xoaSVHB(txtMaHB.Text, txtMaSV.Text, txtHocKy.Text);
                labTB.Text = "Xóa thành công";
            }
            catch
            {
                labTB.Text = "Xóa không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
