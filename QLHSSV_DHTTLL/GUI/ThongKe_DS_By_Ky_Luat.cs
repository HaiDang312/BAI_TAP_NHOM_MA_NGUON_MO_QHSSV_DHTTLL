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
    public partial class ThongKe_DS_By_Ky_Luat : Form
    {
        BUS_Lop bus_Lop = new BUS_Lop();
        BUS_KyLuat bus_KL = new BUS_KyLuat();
        public ThongKe_DS_By_Ky_Luat()
        {
            InitializeComponent();
        }

        private void ThongKe_DS_By_Ky_Luat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLHSSV_TTLLDataSet2.SV_Select_KyLuat' table. You can move, or remove it, as needed.
            
            comboLop.DataSource = bus_Lop.LOP();
            comboLop.DisplayMember = "MALOP";
            comboLop.ValueMember = "MALOP";
            comboLop.Text = "[Chọn lớp ...]";

            comboKT.DataSource = bus_KL.KL();
            comboKT.DisplayMember = "MAKL";
            comboKT.ValueMember = "MAKL";
            comboLop.Text = "[Chọn ...]";
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SV_Select_KyLuatTableAdapter.Fill(this.QLHSSV_TTLLDataSet2.SV_Select_KyLuat, comboLop.SelectedValue.ToString(), comboKT.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
