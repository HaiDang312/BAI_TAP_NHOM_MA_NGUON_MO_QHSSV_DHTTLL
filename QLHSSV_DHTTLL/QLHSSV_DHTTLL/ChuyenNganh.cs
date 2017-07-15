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

    public partial class ChuyenNganh : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;
        public ChuyenNganh()
        {
            InitializeComponent();
        }
        class Bien
        {
            public static string maCN = "";
            public static string tenCN = "";

        }
        DataTable CHUYENNGANH()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT * FROM CHUYENNGANH", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        void themNganh(string MaCN, string TenCN)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "INSERT INTO CHUYENNGANH VALUES(N'" + MaCN + "',N'" + TenCN + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void suaNganh(string MaCN, string TenCN)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "UPDATE CHUYENNGANH SET TENNGANH='" + TenCN + "' WHERE MANGANH='" + MaCN + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        void xoaNganh(string MaCN)
        {
            SqlConnection connDB = new SqlConnection(Program.strConn);
            connDB.Open();
            string cmd = "DELETE FROM CHUYENNGANH WHERE MANGANH='" + MaCN + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, connDB);
            sqlCmd.ExecuteNonQuery();
            connDB.Close();
        }
        private void binding()
        {
            txtMaCN.DataBindings.Clear();
            txtMaCN.DataBindings.Add("Text", dataGridView1.DataSource, "MANGANH");
            txtTenCN.DataBindings.Clear();
            txtTenCN.DataBindings.Add("Text", dataGridView1.DataSource, "TENNGANH");
        }
        private void ChuyenNganh_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CHUYENNGANH();
            dataGridView1.Columns[0].HeaderText = "Mã CN";
            dataGridView1.Columns[1].HeaderText = "Tên chuyên ngành";

            dataGridView1.Columns[0].Width = 10;
            dataGridView1.Columns[1].Width = 150;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;

            binding();
        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            themNganh(txtMaCN.Text, txtTenCN.Text);
            txtMaCN.Text = "";
            txtTenCN.Text = "";
            this.ChuyenNganh_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adap.UpdateCommand = new SqlCommand("SP_CHUYENNGANH_Update", dbConn);
            adap.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adap.UpdateCommand.Parameters.Add("@MANGANH", SqlDbType.VarChar).SourceColumn = "MANGANH";
            adap.UpdateCommand.Parameters.Add("@TENNGANH", SqlDbType.NVarChar).SourceColumn = "TENNGANH";
            adap.Update(ds);
            dbConn.Close();
            suaNganh(txtMaCN.Text, txtTenCN.Text);
            txtMaCN.Text = "";
            txtTenCN.Text = "";
            this.ChuyenNganh_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;


            Bien.maCN = row.Cells["MANGANH"].Value.ToString();
            Bien.tenCN = row.Cells["TENNGANH"].Value.ToString();

            MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            xoaNganh(Bien.maCN);
            txtMaCN.Text = "";
            txtTenCN.Text = "";
            this.ChuyenNganh_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
