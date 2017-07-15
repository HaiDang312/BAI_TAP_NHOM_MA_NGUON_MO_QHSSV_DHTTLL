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
    public partial class dsKyLuat : Form
    {
        BUS_KyLuat bus_kl = new BUS_KyLuat();
        public dsKyLuat()
        {
            InitializeComponent();
        }

        private void dsKyLuat_Load(object sender, EventArgs e)
        {
            dtgKL.DataSource = bus_kl.KL();
            dtgKL.Columns[0].HeaderText = "Mã kỷ luật";
            dtgKL.Columns[1].HeaderText = "Tên kỷ luật";
            dtgKL.Columns[2].HeaderText = "Ghi Chú";

            dtgKL.Columns[0].Width = 50;
            dtgKL.Columns[1].Width = 100;
            dtgKL.Columns[2].Width = 150;

            dtgKL.AllowUserToAddRows = false;
            dtgKL.AllowUserToDeleteRows = false;
            dtgKL.Width = this.ClientSize.Width;
            dtgKL.Height = this.ClientSize.Height;
        }
    }
}
