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
    public partial class ThongKeSinhVienTheoLop : Form
    {
        BUS_Lop bus_lop = new BUS_Lop();
        public ThongKeSinhVienTheoLop()
        {
            InitializeComponent();
        }

        private void ThongKeSinhVienTheoLop_Load(object sender, EventArgs e)
        {
            comboLop.DataSource = bus_lop.LOP();
            comboLop.DisplayMember = "TENLOP";
            comboLop.ValueMember = "MALOP";
            //comboLop.SelectedIndex = -1;
            comboLop.Text = "[Chọn lớp ...]";
            this.dataDT.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SV_Select_MaLopTableAdapter.Fill(this.QLHSSV_TTLLDataSet.SV_Select_MaLop, comboLop.SelectedValue.ToString());
            this.dataDT.RefreshReport(); 
        }
    }
}
