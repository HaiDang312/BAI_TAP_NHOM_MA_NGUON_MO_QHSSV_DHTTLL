using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace QLHSSV_DHTTLL
{
    public partial class ChuyenNganh : Form
    {
        BUS_ChuyenNganh bus_ChuyenNganh = new BUS_ChuyenNganh();

        public ChuyenNganh()
        {
            InitializeComponent();
        }
        class Bien
        {
            public static string maCN = "";
            public static string tenCN = "";

        }
        
        private void binding()
        {
            txtMaCN.DataBindings.Clear();
            txtMaCN.DataBindings.Add("Text", gridDS.DataSource, "MANGANH");
            txtTenCN.DataBindings.Clear();
            txtTenCN.DataBindings.Add("Text", gridDS.DataSource, "TENNGANH");
        }

        private void ChuyenNganh_Load(object sender, EventArgs e)
        {

            gridDS.DataSource = bus_ChuyenNganh.ChuyenNganh();
            gridDS.Columns[0].HeaderText = "Mã CN";
            gridDS.Columns[1].HeaderText = "Tên chuyên ngành";

            gridDS.Columns[0].Width = 10;
            gridDS.Columns[1].Width = 150;

            gridDS.AllowUserToAddRows = false;
            gridDS.AllowUserToDeleteRows = false;
            gridDS.Width = this.ClientSize.Width;
            gridDS.Height = this.ClientSize.Height;

            binding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTO_ChuyenNganh dto_ChuyenNganh = new DTO_ChuyenNganh(txtMaCN.Text, txtTenCN.Text);
            bus_ChuyenNganh.themCN(dto_ChuyenNganh);
            ChuyenNganh_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_ChuyenNganh dto_ChuyenNganh = new DTO_ChuyenNganh(txtMaCN.Text, txtTenCN.Text);
            bus_ChuyenNganh.suaCN(dto_ChuyenNganh);
            ChuyenNganh_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bus_ChuyenNganh.xoaCN(txtMaCN.Text);
            ChuyenNganh_Load(sender, e);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
