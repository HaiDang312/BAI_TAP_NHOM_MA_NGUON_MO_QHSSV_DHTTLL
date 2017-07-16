using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace QLHSSV_DHTTLL_Vuong
{
    public partial class DSSVDoiTuong : Form
    {
        BUS_SVDoiTuong bus_svdt = new BUS_SVDoiTuong();
        BUS_TimKiemSVDT bus_tksv = new BUS_TimKiemSVDT();
        public DSSVDoiTuong()
        {
            InitializeComponent();
        }

        private void DSSVDoiTuong_Load(object sender, EventArgs e)
        {
            dgMG.DataSource = bus_svdt.DSSVDT(txtMaSV.Text);
            dgMG.Columns[0].HeaderText = "Mã Sinh Viên";
            dgMG.Columns[1].HeaderText = "Họ Sinh Viên";
            dgMG.Columns[2].HeaderText = "Tên Sinh Viên";
            dgMG.Columns[3].HeaderText = "Tên Lớp";
            dgMG.Columns[4].HeaderText = "Tên Khoa";
            dgMG.Columns[5].HeaderText = "Mã Đối Tượng";
            dgMG.Columns[6].HeaderText = "Tên Đối Tượng";
            dgMG.Columns[7].HeaderText = "Chế Độ Miễn Giảm";


            dgMG.Columns[0].Width = 100;
            dgMG.Columns[1].Width = 100;
            dgMG.Columns[2].Width = 150;
            dgMG.Columns[3].Width = 150;
            dgMG.Columns[4].Width = 150;
            dgMG.Columns[5].Width = 150;
            dgMG.Columns[6].Width = 150;
            dgMG.Columns[7].Width = 150;


            dgMG.AllowUserToAddRows = false;
            dgMG.AllowUserToDeleteRows = false;
            dgMG.Width = this.ClientSize.Width;
            dgMG.Height = this.ClientSize.Height;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bus_tksv.timSVDT(txtMaSV.Text);
            dgMG.DataSource = bus_svdt.DSSVDT(txtMaSV.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
