using BUS;
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
    public partial class DSSVKyLuat : Form
    {
        BUS_QTKyLuat bus_qtkl = new BUS_QTKyLuat();
        BUS_TimKiemSVKTKL bus_timkiem = new BUS_TimKiemSVKTKL();
        public DSSVKyLuat()
        {
            InitializeComponent();
        }

        private void DSSVKyLuat_Load(object sender, EventArgs e)
        {
            dtgSVKL.DataSource = bus_qtkl.DSKL(txtMaSV.Text);
            dtgSVKL.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgSVKL.Columns[1].HeaderText = "Họ Sinh Viên";
            dtgSVKL.Columns[2].HeaderText = "Tên Sinh Viên";
            dtgSVKL.Columns[3].HeaderText = "Tên Lớp";
            dtgSVKL.Columns[4].HeaderText = "Tên Khoa";
            dtgSVKL.Columns[5].HeaderText = "Mã Kỷ luật";
            dtgSVKL.Columns[6].HeaderText = "Tên Kỷ Luật";
            dtgSVKL.Columns[7].HeaderText = "Ngày Kỷ Luật";
            dtgSVKL.Columns[8].HeaderText = "Ngày Hết Hạn KL";
            dtgSVKL.Columns[9].HeaderText = "Ghi Chú";

            dtgSVKL.Columns[0].Width = 100;
            dtgSVKL.Columns[1].Width = 100;
            dtgSVKL.Columns[2].Width = 150;
            dtgSVKL.Columns[3].Width = 150;
            dtgSVKL.Columns[4].Width = 150;
            dtgSVKL.Columns[5].Width = 150;
            dtgSVKL.Columns[6].Width = 150;
            dtgSVKL.Columns[7].Width = 150;
            dtgSVKL.Columns[8].Width = 150;
            dtgSVKL.Columns[9].Width = 150;

            dtgSVKL.AllowUserToAddRows = false;
            dtgSVKL.AllowUserToDeleteRows = false;
            dtgSVKL.Width = this.ClientSize.Width;
            dtgSVKL.Height = this.ClientSize.Height;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bus_timkiem.timSVKL(txtMaSV.Text);
            dtgSVKL.DataSource = bus_qtkl.DSKL(txtMaSV.Text);
        }
    }
}
