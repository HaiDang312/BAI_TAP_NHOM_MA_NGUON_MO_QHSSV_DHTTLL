using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class InDanhSachSinhVienTheoLop : Form
    {
        public InDanhSachSinhVienTheoLop()
        {
            InitializeComponent();
        }
        DataTable Lop_DS()
        {
            string cmd = "SELECT * FROM LOP";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }

        private void InDanhSachSinhVienTheoLop_Load(object sender, EventArgs e)
        {
            
           
            comboLop.DataSource = Lop_DS();
            comboLop.DisplayMember = "TENLOP";
            comboLop.ValueMember = "MALOP";
            //comboLop.SelectedIndex = -1;
            comboLop.Text = "[Chọn lớp ...]";
                
 
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SV_Select_MaLopTableAdapter.Fill(this.QLHSSV_TTLLDataSet4.SV_Select_MaLop,comboLop.SelectedValue.ToString());
            this.dataDT.RefreshReport(); 
        }
    }
}
