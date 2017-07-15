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
    public partial class xemThongTinSinhVien : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;
        public xemThongTinSinhVien()
        {
            InitializeComponent();
        }
        DataTable SinhVien()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT MASV,HOSV+' '+TENSV AS HoTen FROM SINHVIEN", dbConn);
            ds = new DataTable();
           // adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        private void xemThongTinSinhVien_Load(object sender, EventArgs e)
        {
         

            dataGridView1.DataSource = SinhVien();
            DataColumn col = new DataColumn();
            col.DataType = System.Type.GetType("System.Int32");
            col.AllowDBNull = false;
            col.Caption = "STT";
            col.ColumnName = "STT";
            col.AutoIncrement = true;
            col.AutoIncrementSeed = 1;
            col.AutoIncrementStep = 1;
            ds.Columns.Add(col);
            adap.Fill(ds);
            dataGridView1.Columns[1].HeaderText = "Mã sinh viên";
            dataGridView1.Columns[2].HeaderText = "Tên sinh viên";
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 270;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;
            BienSinhVien.maSV = row.Cells["MASV"].Value.ToString();
            BienSinhVien.hoTenSV = row.Cells["HoTen"].Value.ToString();
           chiTietThogTinSinhVien frm = new chiTietThogTinSinhVien();
            frm.ShowDialog();
        }
    }
}
