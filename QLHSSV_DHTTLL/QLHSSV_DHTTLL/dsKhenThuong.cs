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

namespace QLHSSV_DHTTLL
{
    public partial class dsKhenThuong : Form
    {
        BUS_KhenThuong bus_kt = new BUS_KhenThuong();

        public dsKhenThuong()
        {
            InitializeComponent();
        }

        private void dsKhenThuong_Load(object sender, EventArgs e)
        {
            dtgKT.DataSource = bus_kt.KT();
            dtgKT.Columns[0].HeaderText = "Mã khen thưởng";
            dtgKT.Columns[1].HeaderText = "Tên khen thưởng";
            dtgKT.Columns[2].HeaderText = "Ghi Chú";

            dtgKT.Columns[0].Width = 50;
            dtgKT.Columns[1].Width = 100;
            dtgKT.Columns[2].Width = 150;

            dtgKT.AllowUserToAddRows = false;
            dtgKT.AllowUserToDeleteRows = false;
            dtgKT.Width = this.ClientSize.Width;
            dtgKT.Height = this.ClientSize.Height;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
