using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : Form
    {

        public TrangChu(String hoTen)
        {
            InitializeComponent();
            labHoTen.Text = hoTen;
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khoa f = new Khoa();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTaiKoan f = new QuanLyTaiKoan();
            f.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void danhMụcĐầuVàoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop f = new Lop();
            f.Show();
        }

        private void quảnLýChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChuyenNganh f = new ChuyenNganh();
            f.Show();
        }

        private void quảnLýĐốiTượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhenThuong_KyLuat f = new KhenThuong_KyLuat();
            f.Show();
        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kỹLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonHoc f = new MonHoc();
            f.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lop f = new Lop();
            f.Show();
        }

        private void labHoTen_Click(object sender, EventArgs e)
        {
          
        }

        private void quảnLýHọcBổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HocBong f = new HocBong();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void điểmSinhViênTheoLớpkhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchĐốiTượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSSVDoiTuong f = new DSSVDoiTuong();
            f.Show();
        }

        private void danhSáchHọcBổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsSinhVienHocBong f = new dsSinhVienHocBong();
            f.Show();
        }

        private void danhSáchSinhViênLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsSinhVienTheoLopKhoa f = new dsSinhVienTheoLopKhoa();
            f.Show();
        }

        private void danhSáchSinhViênKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dsSingVienTheoKhoa f = new dsSingVienTheoKhoa();
            //f.Show();
        }

        private void danhSáchSinhViênBịKỹLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSSVKyLuat f = new DSSVKyLuat();
            f.Show();
        }

        private void danhSáchSinhViênKhenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSSVKhenThuong f = new DSSVKhenThuong();
            f.Show();
        }

        private void danhSáchSinhViênChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dsSingVienChuyenNganh f = new dsSingVienChuyenNganh();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyTaiKoan f = new QuanLyTaiKoan();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MonHoc f = new MonHoc();
            f.Show();
        }

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinhVien f = new SinhVien();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //diemSVTheoMonHoc f = new diemSVTheoMonHoc();
            //f.Show();
        }

        private void điểmSinhViênTheoMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeSinhVienTheoLop f = new ThongKeSinhVienTheoLop();
            f.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SinhVien f = new SinhVien();
            f.Show();
        }

        private void inDanhSáchSinhViênTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //InDanhSachSinhVienTheoLop f = new InDanhSachSinhVienTheoLop();
            //f.Show();
        }

        private void quảnLýĐiểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diem f = new Diem();
            f.Show();
        }

        private void quảnLýSinhViênĐạtHọcBổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            svHocBong f = new svHocBong();
            f.Show();
        }

        private void thốngKêĐiểmCủaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDiemSVTheoLop f = new ThongKeDiemSVTheoLop();
            f.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongkeDS_SVDatHocBong f = new ThongkeDS_SVDatHocBong();
            f.Show();
        }

        private void quảnLýSinhViênKhenThưởngKỹLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QTKhenThuong_KyLuat f = new QTKhenThuong_KyLuat();
            f.Show();
        }

        private void quảnLýSinhViênĐốiTượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SVDoiTuong f = new SVDoiTuong();
            f.Show();
        }

        private void quảnLýĐốiTượngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DoiTuong f = new DoiTuong();
            f.Show();
        }

        private void thốngKêSinhViênTheoĐốiTượngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKe_SV_DoiTuong f = new ThongKe_SV_DoiTuong();
            f.Show();
        }
    }
}
