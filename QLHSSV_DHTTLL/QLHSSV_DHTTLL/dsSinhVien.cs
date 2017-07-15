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

namespace GUI
{

    public partial class dsSinhVien : Form
    {
        //SqlConnection dbConn;
        //DataTable ds;
        //SqlDataAdapter adap;
        //BindingSource bindSinhVien;
        //string imgLocation;
        public dsSinhVien()
        {
            InitializeComponent();
        }
        DataTable Lop_DS()
        {
            string cmd = "SELECT * FROM LOP";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        DataTable Khoa_DS()
        {
            string cmd = "SELECT * FROM KHOA";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        DataTable ChuyenNganh_DS()
        {
            string cmd = "SELECT * FROM CHUYENNGANH";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        void themSV(string MaSV, string hoSV, string tenSV, string maLop, string maKhoa, string maNganh, string ngaySinh, string gioiTinh, string diaChi, string doanVien, string ngayKetNap, string noiKetNap, string SCMND, string ngayCap, string noiCap, string heDaoTao, string namTuyenSinh, string danToc)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO SINHVIEN VALUES('" + MaSV + "',N'" + hoSV + "', N'" + tenSV + "',N'" + maLop + "', '" + maKhoa + "', '" + maNganh + "', '" + ngaySinh + "', '" + gioiTinh + "', N'" + diaChi + "', '" + doanVien + "', '" + ngayKetNap + "', N'" + noiKetNap + "', '" + SCMND + "', '" + ngayCap + "', N'" + noiCap + "','" + heDaoTao + "', '" + namTuyenSinh + "', N'" + danToc + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaSV(string MaSV, string hoSV, string tenSV, string maLop, string maKhoa, string maNganh, string ngaySinh, string gioiTinh, string diaChi, string doanVien, string ngayKetNap, string noiKetNap, string SCMND, string ngayCap, string noiCap, string heDaoTao, string namTuyenSinh, string danToc)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE SINHVIEN SET HOSV=N'" + hoSV + "', TENSV=N'" + tenSV + "',MALOP='" + maLop + "', MAKHOA='" + maKhoa + "', MANGANH='" + maNganh + "', NGAYSINH='" + ngaySinh + "', GIOITINH='" + gioiTinh + "', DIACHI=N'" + diaChi + "', DOANVIEN='" + doanVien + "', NGAYVD='" + ngayKetNap + "', NOIKETNAP=N'" + noiKetNap + "', SOCMND='" + SCMND + "', NGAYCAP'" + ngayCap + "', NOICAP=N'" + noiCap + "',HEDAOTAO='" + heDaoTao + "', NAMTUYENSINH='" + namTuyenSinh + "', DANTOC=N'" + danToc + "' WHERE MASV='" + MaSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaSV(string MaSV)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM SINHVIEN WHERE MASV='" + MaSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        //private byte[] chuyenDoiAnh()
        //{
        //    FileStream fs;
        //    fs = new FileStream(, FileMode.Open, FileAccess.Read);
        //    byte[] picbyte = new byte[fs.Length];
        //    fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
        //    fs.Close();
        //    return picbyte;
        //}
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dsSinhVien_Load(object sender, EventArgs e)
        {
            comboLop.DataSource = Lop_DS();
            comboLop.DisplayMember = "TENLOP";
            comboLop.ValueMember = "MALOP";
            comboLop.SelectedIndex = -1;
            comboLop.Text = "[Chọn lớp ...]";

            comboKhoa.DataSource = Khoa_DS();
            comboKhoa.DisplayMember = "TENKHOA";
            comboKhoa.ValueMember = "MAKHOA";
            comboKhoa.SelectedIndex = -1;
            comboKhoa.Text = "[ Chọn khoa ...]";

            comboNganh.DataSource = ChuyenNganh_DS();
            comboNganh.DisplayMember = "TENNGANH";
            comboNganh.ValueMember = "MANGANH";
            comboNganh.SelectedIndex = -1;
            comboNganh.Text = "[Chọn ngành ...]"; 
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
             
            //try
            //{
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

                //byte[] images = null;
                //FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                //BinaryReader brs = new BinaryReader(Streem);
                //images = brs.ReadBytes((int)Streem.Length);
                //SqlConnection connDB = new SqlConnection(Program.strConn);
                //connDB.Open();
                //string cmd = "INSERT INTO SINHVIEN(MASV,HOSV,TENSV,MALOP,MAKHOA,MANGANH,NGAYSINH,GIOITINH,DIACHI,DOANVIEN,NGAYVD,NOIKETNAP,SOCMND,NGAYCAP,NOICAP,HEDAOTAO,NAMTUYENSINH,DANTOC) VALUES('" + txtMaSV.Text + "',N'" + txtHoSV.Text + "', N'" + txtTenSV.Text + "','@ANHSINHVIEN ',N'" + comboLop.SelectedValue.ToString() + "', '" + comboKhoa.SelectedValue.ToString() + "', '" + comboNganh.SelectedValue.ToString() + "', '" + txtNgaySinh.Text + "', '" + gt.ToString() + "', N'" + txtDiaChi.Text + "', '" + dv.ToString() + "', '" + txtNgayVaoDoan.Text + "', N'" + txtNoiKetnap.Text + "', '" + txtSoCMND.Text + "', '" + txtNgayCap.Text + "', N'" + txtNoiCap.Text + "','" + dt.ToString() + "', '" + txtNamtuyenSinh.Text + "', N'" + txtDanToc.Text + "')";
                //SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
                ////sqlCmd.Parameters.AddWithValue("@ANHSINHVIEN", images);
                //sqlCmd.ExecuteNonQuery();
                //connDB.Close();

                themSV(txtMaSV.Text, txtHoSV.Text, txtTenSV.Text, comboLop.SelectedValue.ToString(), comboKhoa.SelectedValue.ToString(), comboNganh.SelectedValue.ToString(), txtNgaySinh.Text, gt.ToString(), txtDiaChi.Text, dv.ToString(), txtNgayVaoDoan.Text, txtNoiKetnap.Text, txtSoCMND.Text, txtNgayCap.Text, txtNoiCap.Text, dt.ToString(), txtNamtuyenSinh.Text, txtDanToc.Text);
                lbThongBao.Text = "Thêm thành công";
            //}
            //catch
            //{
            //    lbThongBao.Text = "Thêm không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog File = new OpenFileDialog();
            //ofdOpenFile.ShowDialog();
            //File.Filter = File.Filter = "JPG file (*.jpg)|*.jpg|All file (*_*) | *.*";
            //File.FilterIndex = 1;
            //File.RestoreDirectory = true;
            //if (File.ShowDialog() == DialogResult.OK)
            //{
            //    imgLocation = File.FileName.ToString();
            //    txtAnh.Text = File.FileName;
            //}
            //themSV(txtMaSV.Text, txtHoSV.Text, txtTenSV.Text, comboLop.SelectedValue.ToString(), comboKhoa.SelectedValue.ToString(), comboNganh.SelectedValue.ToString(), txtNgaySinh.Text, gt.ToString(), txtDiaChi.Text, dv.ToString(), txtNgayVaoDoan.Text, txtNoiKetnap.Text, txtSoCMND.Text, txtNgayCap.Text, txtNoiCap.Text, dt.ToString(), txtNamtuyenSinh.Text, txtDanToc.Text);

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

                //byte[] images = null;
                //FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                //BinaryReader brs = new BinaryReader(Streem);
                //images = brs.ReadBytes((int)Streem.Length);

                //SqlConnection connDB = new SqlConnection(Program.strConn);
                //connDB.Open();
                //string cmd = "UPDATE SINHVIEN SET HOSV=N'" + txtHoSV.Text + "', TENSV=N'" + txtTenSV.Text + "', MALOP='" + comboLop.SelectedValue.ToString() + "', MAKHOA='" + comboKhoa.SelectedValue.ToString() + "', MANGANH='" + comboNganh.SelectedValue.ToString() + "', NGAYSINH='" + txtNgaySinh.Text + "', GIOITINH='" + gt.ToString() + "', DIACHI=N'" + txtDiaChi.Text + "', DOANVIEN='" + dv.ToString() + "', NGAYVD='" + txtNgayVaoDoan.Text + "', NOIKETNAP=N'" + txtNoiKetnap.Text + "', SOCMND='" + txtSoCMND.Text + "', NGAYCAP='" + txtNgayCap.Text + "', NOICAP=N'" + txtNoiCap.Text + "',HEDAOTAO='" + dt.ToString() + "', NAMTUYENSINH='" + txtNamtuyenSinh.Text + "', DANTOC=N'" + txtDanToc.Text + "' WHERE MASV='" + txtMaSV.Text + "'";
                //SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
                //sqlCmd.ExecuteNonQuery();
                //connDB.Close();
                suaSV(txtMaSV.Text, txtHoSV.Text, txtTenSV.Text, comboLop.SelectedValue.ToString(), comboKhoa.SelectedValue.ToString(), comboNganh.SelectedValue.ToString(), txtNgaySinh.Text, gt.ToString(), txtDiaChi.Text, dv.ToString(), txtNgayVaoDoan.Text, txtNoiKetnap.Text, txtSoCMND.Text, txtNgayCap.Text, txtNoiCap.Text, dt.ToString(), txtNamtuyenSinh.Text, txtDanToc.Text);
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
                xoaSV(txtMaSV.Text);
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
            xemThongTinSinhVien f = new xemThongTinSinhVien();
            f.Show();
        }
    }
}
 