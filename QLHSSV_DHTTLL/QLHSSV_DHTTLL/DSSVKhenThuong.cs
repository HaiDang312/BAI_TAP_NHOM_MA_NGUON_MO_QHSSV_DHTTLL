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
using System.Data.SqlClient;

namespace QLHSSV_DHTTLL
{
    public partial class DSSVKhenThuong : Form
    {
       
        BUS_QTKhenThuong bus_qtkt = new BUS_QTKhenThuong();
        BUS_TimKiemSVKTKL bus_timkiem = new BUS_TimKiemSVKTKL();
        public DSSVKhenThuong()
        {
            InitializeComponent();
        }

        private void DSSVKhenThuong_Load(object sender, EventArgs e)
        {
            dtgSVKT.DataSource = bus_qtkt.DSSVKT(txtMaSV.Text);
            dtgSVKT.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgSVKT.Columns[1].HeaderText = "Họ Sinh Viên";
            dtgSVKT.Columns[2].HeaderText = "Tên Sinh Viên";
            dtgSVKT.Columns[3].HeaderText = "Tên Lớp";
            dtgSVKT.Columns[4].HeaderText = "Tên Khoa";
            dtgSVKT.Columns[5].HeaderText = "Mã Khen Thưởng";
            dtgSVKT.Columns[6].HeaderText = "Tên Khen Thưởng";
            dtgSVKT.Columns[7].HeaderText = "Ngày Khen Thưởng";
            dtgSVKT.Columns[8].HeaderText = "Ghi Chú";

            dtgSVKT.Columns[0].Width = 100;
            dtgSVKT.Columns[1].Width = 100;
            dtgSVKT.Columns[2].Width = 150;
            dtgSVKT.Columns[3].Width = 150;
            dtgSVKT.Columns[4].Width = 150;
            dtgSVKT.Columns[5].Width = 150;
            dtgSVKT.Columns[6].Width = 150;
            dtgSVKT.Columns[7].Width = 150;
            dtgSVKT.Columns[8].Width = 150;

            dtgSVKT.AllowUserToAddRows = false;
            dtgSVKT.AllowUserToDeleteRows = false;
            dtgSVKT.Width = this.ClientSize.Width;
            dtgSVKT.Height = this.ClientSize.Height;
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            bus_timkiem.timSVKT(txtMaSV.Text);
            dtgSVKT.DataSource = bus_qtkt.DSSVKT(txtMaSV.Text);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
