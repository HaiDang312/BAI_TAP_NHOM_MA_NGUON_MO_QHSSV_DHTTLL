using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
using System.Data.Common;
using System.Data.SqlClient;
namespace QLHSSV_DHTTLL
{
    public partial class TKDiemSV : Form
    {
        protected SqlConnection dbConn = new SqlConnection(@"Data Source=1RQ9PQOOHJNY2OJ\SQLEXPRESS;Initial Catalog=QLHSSV;Integrated Security=True");

        DataTable dt;
        SqlDataAdapter da;
        DAL_TKDiemSV dal_tk = new DAL_TKDiemSV();
        BUS_TKDiemSV bus_tk = new BUS_TKDiemSV();
        public TKDiemSV()
        {
            InitializeComponent();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select MASV, MAMH, HOCKY, DIEMCC, DIEMTX, DIEMGK, DIEMCK, ( DIEMCC + DIEMTX + DIEMGK*3 + DIEMCK*5 )/10 as DiemTongKet From DIEM where MASV LIKE '%" + txtMaSV.Text + "%'", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            gridDS.DataSource = dt;
        }

        private void TKDiemSV_Load(object sender, EventArgs e)
        {
            gridDS.DataSource = bus_tk.Diem();
            gridDS.Columns[0].HeaderText = "Mã SV";
            gridDS.Columns[1].HeaderText = "Mã MH";
            gridDS.Columns[2].HeaderText = "Học Kỳ";
            gridDS.Columns[3].HeaderText = "Điểm CC";
            gridDS.Columns[4].HeaderText = "Điểm TX";
            gridDS.Columns[5].HeaderText = "Điểm GK";
            gridDS.Columns[6].HeaderText = "Điểm CK";
            gridDS.Columns[7].HeaderText = "Điểm TK";

            gridDS.Columns[0].Width = 60;
            gridDS.Columns[1].Width = 60;
            gridDS.Columns[2].Width = 60;
            gridDS.Columns[3].Width = 60;
            gridDS.Columns[4].Width = 60;
            gridDS.Columns[5].Width = 60;
            gridDS.Columns[6].Width = 60;
            gridDS.Columns[7].Width = 60;

            gridDS.AllowUserToAddRows = false;
            gridDS.AllowUserToDeleteRows = false;
            gridDS.Width = this.ClientSize.Width;
            gridDS.Height = this.ClientSize.Height;
        }
    }
}
