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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public void kiemTra(string tenDN, string MK)
        {
            SqlConnection dbConn = new SqlConnection(@"Data Source=HUUTHUAN\SQLEXPRESS;Initial Catalog=QLHSSV_TTLL;Integrated Security=True");
            string cmd = "SELECT hoTen FROM DANGNHAP WHERE tenDangNhap = '" + tenDN + "' AND matKhau = '" + MK + "'";
            SqlDataAdapter sql = new SqlDataAdapter(cmd, dbConn);
            DataTable ds = new DataTable();
            sql.Fill(ds);
            if (ds.Rows.Count == 1)
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                if (ds.Rows[0][0].ToString() != "admin")
                {
                    TrangChu f = new TrangChu(ds.Rows[0][0].ToString());
                    f.Show();
                }

            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.Xin vui lòng kiểm tra lại!");
                txtMK.Text = "";
                txtTenDN.Text = "";
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string st = label5.Text;
            label5.Text = st.Substring(1, st.Length - 4) + st.Substring(0, 4);
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            kiemTra(txtTenDN.Text, txtMK.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
