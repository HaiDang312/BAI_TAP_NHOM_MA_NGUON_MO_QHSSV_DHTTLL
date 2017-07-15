using BUS;
using DTO;
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
        BUS_DangNhap bus_DN = new BUS_DangNhap();
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }  
        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              try
              {
                  DTO_DangNhap dn = new DTO_DangNhap(txtID.Text, txtHoTen.Text, txtTenDN.Text, txtMK.Text);
                  bus_DN.themDN(dn);
                  txtID.Text = "";
                  txtHoTen.Text = "";
                  txtTenDN.Text = "";
                  txtMK.Text = "";
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
