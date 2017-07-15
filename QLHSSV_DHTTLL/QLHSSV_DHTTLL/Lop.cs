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
using DTO;
using BUS;
using DAL;

namespace GUI
{
    public partial class Lop : Form
    {
        //SqlConnection dbConn;
        //DataTable ds;
        //SqlDataAdapter adap;

        BUS_Lop bus_lop = new BUS_Lop();
 

        public Lop()
        {
            InitializeComponent();
        }

        //class Bien
        //{
        //    public static string maLop = "";
        //    public static string tenLop = "";

        //}
        //DataTable LOP()
        //{
        //    dbConn = new SqlConnection(Program.strConn);
        //    adap = new SqlDataAdapter();
        //    dbConn.Open();
        //    adap.SelectCommand = new SqlCommand("SELECT * FROM LOP", dbConn);
        //    ds = new DataTable();
        //    adap.Fill(ds);
        //    dbConn.Close();
        //    return ds;
        //}
        //DataTable Khoa_DS()
        //{
        //    string cmd = "SELECT * FROM KHOA";
        //    SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strConn);
        //    DataTable ds = new DataTable();
        //    adap.Fill(ds);
        //    return ds;
        //}
        //void themLop(string MaLop, string TenLop, string maKhoa)
        //{
        //    SqlConnection connDB = new SqlConnection(Program.strConn);
        //    connDB.Open();
        //    string cmd = "INSERT INTO LOP VALUES(N'" + MaLop + "',N'" + TenLop + "',N'" + maKhoa + "')";
        //    SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
        //    sqlCmd.ExecuteNonQuery();
        //    connDB.Close();
        //}
        //void suaLop(string maLop, string tenLop,string maKhoa)
        //{
        //    SqlConnection connDB = new SqlConnection(Program.strConn);
        //    connDB.Open();
        //    string cmd = "UPDATE LOP SET TENLOP=N'" + tenLop + "',MAKHOA='"+maKhoa+"' WHERE MALOP='" + maLop + "'";
        //    SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
        //    sqlCmd.ExecuteNonQuery();
        //    connDB.Close();
        //}
        //void xoaLop(string maLop)
        //{
        //    SqlConnection connDB = new SqlConnection(Program.strConn);
        //    connDB.Open();
        //    string cmd = "DELETE FROM LOP WHERE MALOP='" + maLop + "'";
        //    SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
        //    sqlCmd.ExecuteNonQuery();
        //    connDB.Close();
        //}

        private void binding()
        {
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dataGridView1.DataSource, "MALOP");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", dataGridView1.DataSource, "TENLOP");
            comKhoa.DataBindings.Clear();
            comKhoa.DataBindings.Add("Text", dataGridView1.DataSource, "MAKHOA");
        }
        private void Lop_Load(object sender, EventArgs e)
        {

            
            comKhoa.DataSource = bus_lop.KHOA();
            comKhoa.DisplayMember = "TenKhoa";
            comKhoa.ValueMember = "MaKhoa";

            dataGridView1.DataSource = bus_lop.LOP();
            dataGridView1.Columns[0].HeaderText = "Mã lớp";
            dataGridView1.Columns[1].HeaderText = "Tên lớp";
            dataGridView1.Columns[2].HeaderText = "Mã khoa";

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width =70;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;

            binding();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //themLop(txtMaLop.Text, txtTenLop.Text, comKhoa.SelectedValue.ToString());

            DTO_Lop Lop = new DTO_Lop(txtMaLop.Text, txtTenLop.Text, comKhoa.SelectedValue.ToString());
            bus_lop.themLop(Lop);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            this.Lop_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //adap.UpdateCommand = new SqlCommand("SP_LOP_Update", dbConn);
            //adap.UpdateCommand.CommandType = CommandType.StoredProcedure;
            //adap.UpdateCommand.Parameters.Add("@MALOP", SqlDbType.VarChar).SourceColumn = "MALOP";
            //adap.UpdateCommand.Parameters.Add("@TENLOP", SqlDbType.NVarChar).SourceColumn = "TENLOP";
            //adap.UpdateCommand.Parameters.Add("@MAKHOA", SqlDbType.NVarChar).SourceColumn = "MAKHOA";
            //adap.Update(ds);
            //dbConn.Close();
            //suaLop(txtMaLop.Text, txtTenLop.Text, comKhoa.SelectedValue.ToString());

            DTO_Lop Lop = new DTO_Lop(txtMaLop.Text, txtTenLop.Text, comKhoa.SelectedValue.ToString());
            bus_lop.suaLop(Lop);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            this.Lop_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //row = dataGridView1.CurrentRow;


            //Bien.maLop = row.Cells["MALOP"].Value.ToString();
            //Bien.tenLop = row.Cells["TENLOP"].Value.ToString();

            //MessageBox.Show("Bạn có chắc muốn thoát không?",
            //     "Error", MessageBoxButtons.YesNoCancel);
            //xoaLop(Bien.maLop);
            bus_lop.xoaLop(txtMaLop.Text);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            this.Lop_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Lop_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
