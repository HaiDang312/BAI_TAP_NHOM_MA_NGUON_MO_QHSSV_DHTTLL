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
    public partial class ThemTaiKhoan : Form
    {
        
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }
        void themTaiKhoan(string id, string hoTen, String tenDN, String MK)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO DANGNHAP VALUES('" + id + "',N'" + hoTen + "',N'" + tenDN + "',N'" + MK + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        
        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              try
              {
                  this.Hide();
                  themTaiKhoan(txtID.Text, txtHoTen.Text, txtTenDN.Text, txtMK.Text);
                  QuanLyTaiKoan f = new QuanLyTaiKoan();
                  f.Show();
              }
              catch
              {
                  labThongBao.Text = "Thêm không thành công xin kiểm tra lại";
              }
                
        }
    }
}
