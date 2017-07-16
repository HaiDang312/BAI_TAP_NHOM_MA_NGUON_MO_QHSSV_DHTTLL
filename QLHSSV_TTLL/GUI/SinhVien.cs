using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;

namespace GUI
{
    public partial class SinhVien : Form
    {
        BUS_SinhVien sv = new BUS_SinhVien(); // Tạo đối tượng sv
        public SinhVien()
        {
            InitializeComponent();
        }
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dsSinhVien_Load(object sender, EventArgs e)
        {
            comboLop.DataSource = sv.Lop(); // gọi hàm lớp bên BUS_SinhVien
            comboLop.DisplayMember = "TENLOP"; // Hiện tên lớp ra comboLop
            comboLop.ValueMember = "MALOP";
            comboLop.SelectedIndex = -1;
            comboLop.Text = "[Chọn lớp ...]";

            comboKhoa.DataSource = sv.Khoa(); // gọi hàm khoa bên BUS_SinhVien
            comboKhoa.DisplayMember = "TENKHOA"; // Hiện tên khoa ra comboLop
            comboKhoa.ValueMember = "MAKHOA";
            comboKhoa.SelectedIndex = -1;
            comboKhoa.Text = "[ Chọn khoa ...]";

            comboNganh.DataSource = sv.Nganh(); // gọi hàm ngành bên BUS_SinhVien
            comboNganh.DisplayMember = "TENNGANH"; // Hiện tên ngành ra comboLop
            comboNganh.ValueMember = "MANGANH";
            comboNganh.SelectedIndex = -1;
            comboNganh.Text = "[Chọn ngành ...]"; 
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             
            try
            {
            bool gt = true; // tao biện giới tính gán đúng thi là nam

            if (radNam.Checked) // kiểm tra 
                gt = true; 
            else
                gt = false;

            bool dv = true;

            if (radDVCO.Checked)
                dv = true;
            else
                dv = false;

            bool dt = true;
            if (radDanSu.Checked)
                dt = true;
            else
                dt = false;
                // tạo đối tương sinh viên với các thuộc tính được người dùng nhập vào ở giao diện
                DTO_SinhVien SinhVien = new DTO_SinhVien(txtMaSV.Text, txtHoSV.Text, txtTenSV.Text, comboLop.SelectedValue.ToString(), comboKhoa.SelectedValue.ToString(), comboNganh.SelectedValue.ToString(), txtNgaySinh.Text, gt.ToString(), txtDiaChi.Text, dv.ToString(), txtNgayVaoDoan.Text, txtNoiKetnap.Text, txtSoCMND.Text, txtNgayCap.Text, txtNoiCap.Text, dt.ToString(), txtNamtuyenSinh.Text, txtDanToc.Text);
                sv.themSV(SinhVien); // Gọi hàm thêm bên BUS_SinhVien
                lbThongBao.Text = "Thêm thành công"; // Thông báo 
            }
            catch
            {
                lbThongBao.Text = "Thêm không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void txtAnh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                bool gt = true;

                if (radNam.Checked)
                    gt = true;
                else
                    gt = false;

                bool dv = true;
                if (radDVCO.Checked)
                    dv = true;
                else
                    dv = false;

                bool dt = true;
                if (radDanSu.Checked)
                    dt = true;
                else
                    dt = false;

                DTO_SinhVien SinhVien = new DTO_SinhVien(txtMaSV.Text, txtHoSV.Text, txtTenSV.Text, comboLop.SelectedValue.ToString(), comboKhoa.SelectedValue.ToString(), comboNganh.SelectedValue.ToString(), txtNgaySinh.Text, gt.ToString(), txtDiaChi.Text, dv.ToString(), txtNgayVaoDoan.Text, txtNoiKetnap.Text, txtSoCMND.Text, txtNgayCap.Text, txtNoiCap.Text, dt.ToString(), txtNamtuyenSinh.Text, txtDanToc.Text);
                sv.suaSV(SinhVien);
                lbThongBao.Text = "Sửa thành công";
            }
            catch
            {
                lbThongBao.Text = "Sửa không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                sv.xoaSV(txtMaSV.Text);
                lbThongBao.Text = "Xóa thành công";
            }
            catch
            {
                lbThongBao.Text = "Xóa không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemTT_Click(object sender, EventArgs e)
        {
            ThongTinSinhVien f = new ThongTinSinhVien(); // gọi tới giao diện thông tin sinh viên
            f.Show();
        }
    }
}
 