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
    public partial class ThongKe_SV_DoiTuong : Form
    {
        BUS_Lop bus_Lop = new BUS_Lop();
        BUS_DoiTuong bus_DT = new BUS_DoiTuong();
        public ThongKe_SV_DoiTuong()
        {
            InitializeComponent();
        }

        private void ThongKe_SV_DoiTuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLHSSV_TTLLDataSet4.SV_Select_SVDoiTuongTheoLop' table. You can move, or remove it, as needed.
            
            comboLop.DataSource = bus_Lop.LOP();
            comboLop.DisplayMember = "MALOP";
            comboLop.ValueMember = "MALOP";
            comboLop.Text = "[Chọn lớp ...]";

            comboDT.DataSource = bus_DT.DoiTuong();
            comboDT.DisplayMember = "MADT";
            comboDT.ValueMember = "MADT";
            comboDT.Text = "[Chọn ...]";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SV_Select_SVDoiTuongTheoLopTableAdapter.Fill(this.QLHSSV_TTLLDataSet4.SV_Select_SVDoiTuongTheoLop,comboLop.SelectedValue.ToString(), comboDT.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
