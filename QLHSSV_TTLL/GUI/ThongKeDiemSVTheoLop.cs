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
    public partial class ThongKeDiemSVTheoLop : Form
    {
        BUS_Lop bus_lop = new BUS_Lop();
        BUS_MonHoc bus_MH = new BUS_MonHoc();
        public ThongKeDiemSVTheoLop()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.SV_Select_DiemMonHocTheoLopTableAdapter.Fill(this.QLHSSV_TTLLDataSet1.SV_Select_DiemMonHocTheoLop, comboLop.SelectedValue.ToString(), combMon.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void ThongKeDiemSVTheoLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLHSSV_TTLLDataSet1.SV_Select_DiemMonHocTheoLop' table. You can move, or remove it, as needed.
            
            comboLop.DataSource = bus_lop.LOP();
            comboLop.DisplayMember = "TENLOP";
            comboLop.ValueMember = "MALOP";
            comboLop.Text = "[Chọn lớp ...]";

            combMon.DataSource = bus_MH.MonHoc();
            combMon.DisplayMember = "TENMH";
            combMon.ValueMember = "MAMH";
            combMon.Text = "[Chọn môn ...]";


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
