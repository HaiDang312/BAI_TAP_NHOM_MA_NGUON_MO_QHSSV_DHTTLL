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
    public partial class ThongkeDS_SVDatHocBong : Form
    {
        BUS_Lop bus_lop = new BUS_Lop();
        public ThongkeDS_SVDatHocBong()
        {
            InitializeComponent();
        }

        private void ThongkeDS_SVDatHocBong_Load(object sender, EventArgs e)
        {
            comboLop.DataSource = bus_lop.LOP();
            comboLop.DisplayMember = "TENLOP";
            comboLop.ValueMember = "MALOP";
            comboLop.Text = "[Chọn lớp ...]";
            this.dataDT.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SV_Select_HocBongTableAdapter.Fill(this.QLHSSV_TTLLDataSet5.SV_Select_HocBong, comboLop.SelectedValue.ToString());
            this.dataDT.RefreshReport();
        }
    }
}
