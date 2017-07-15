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
    public partial class nhapDiem : Form
    {
        SqlConnection dbConn;
        DataTable dsKQ;
        SqlDataAdapter adapKQ;
        public nhapDiem()
        {
            InitializeComponent();
        }

        private void nhapDiem_Load(object sender, EventArgs e)
        {

            lblMaMH.Text = "- Mã môn học: " + BienMH.maMonHoc;
            lblTenMH.Text = "- Tên môn học: " + BienMH.tenMonHoc;
            lblSoTiet.Text = "- Số ĐVHT: " + BienMH.soTiet;
            dbConn = new SqlConnection(Program.strConn);
            dbConn.Open();
            adapKQ = new SqlDataAdapter("SELECT DIEM.MASV, HOSV+' '+ TENSV as [Họ Tên SV], NGAYSINH, CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END AS GioiTinh,TENMH,SOTIET,DIEM,HOCKY FROM SINHVIEN,MONHOC,DIEM WHERE (DIEM.MAMH= '" + BienMH.maMonHoc + "') AND (SINHVIEN.MASV=DIEM.MASV) AND (DIEM.MAMH=MONHOC.MAMH)", dbConn);
            dsKQ = new DataTable();
            //Thiết lập cột số thứ tự
            DataColumn col = new DataColumn();
            col.DataType = System.Type.GetType("System.Int32");
            col.AllowDBNull = false;
            col.Caption = "STT";
            col.ColumnName = "STT";
            col.AutoIncrement = true;
            col.AutoIncrementSeed = 1;
            col.AutoIncrementStep = 1;
            dsKQ.Columns.Add(col);
            adapKQ.Fill(dsKQ);//Lấy và lưu trữ dữ liệu kết quả học tập
            dataDiem.DataSource = dsKQ;
            dataDiem.Columns[1].HeaderText = "Mã SV";
            dataDiem.Columns[2].HeaderText = "Họ tên SV";
            dataDiem.Columns[3].HeaderText = "Ngày sinh";
            dataDiem.Columns[4].HeaderText = "Giới tính";
            dataDiem.Columns[5].HeaderText = "Môn học";
            dataDiem.Columns[6].HeaderText = "Số tiết";
            dataDiem.Columns[7].HeaderText = "Điêm";
            dataDiem.Columns[8].HeaderText = "Học kỳ";
           
            //Có thể thiết lập độ rộng của từng cột
            dataDiem.Columns[0].Width = 60;
            dataDiem.Columns[1].Width = 50;
            dataDiem.Columns[2].Width = 90;
            dataDiem.Columns[3].Width = 120;
            dataDiem.Columns[4].Width = 100;
            dataDiem.Columns[5].Width = 60;
            dataDiem.Columns[6].Width = 100;
            dataDiem.Columns[7].Width = 100;
            dataDiem.Columns[8].Width = 100;
            dataDiem.Columns[8].Width = 100;
            dataDiem.AllowUserToAddRows = false;
            dataDiem.AllowUserToDeleteRows = false;
            dataDiem.Width = this.ClientSize.Width;
            dataDiem.Height = this.ClientSize.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapKQ.UpdateCommand = new SqlCommand("SP_DIEM_Update", dbConn);
            adapKQ.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adapKQ.UpdateCommand.Parameters.Add("@MASV", SqlDbType.NChar).SourceColumn = "MASV";
            adapKQ.UpdateCommand.Parameters.Add("@MAMH", SqlDbType.NVarChar).SourceColumn = "MAMH";
            adapKQ.UpdateCommand.Parameters.Add("@HOCKY", SqlDbType.Real).SourceColumn = "HOCKY";
            adapKQ.UpdateCommand.Parameters.Add("@DIEM", SqlDbType.Real).SourceColumn = "DIEM";
            adapKQ.Update(dsKQ);
            dbConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
