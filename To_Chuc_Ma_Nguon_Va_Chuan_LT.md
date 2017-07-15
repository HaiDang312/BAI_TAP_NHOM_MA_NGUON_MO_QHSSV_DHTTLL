# THÔNG TIN TỔ CHỨC MÃ NGUỒN VÀ CHUẨN LẬP TRÌNH

Để thống nhất và tuân thủ quy tắc đặt tên sẽ giúp dễ dàng quản lý project của mình, tăng khả năng sử dụng lại code, thuận tiện trong việc trao đổi với nhóm, dễ dàng mở rộng nhóm. 
Cách đặt tên dễ hiểu, dễ nhớ còn giúp bạn “nhẹ đầu” hơn khi phải đọc lại code của chính mình.
Thì các thành viên trong nhóm chúng xẻ thống nhất với nhau xẻ làm việc theo chuẩn sau:

## **+ Tổ chức lập trình:** Chúng ta xẻ triển khai dự án theo mô hình 3 lớp.

**- Preject DTO:** DTO chứa các Class đại diện cho các đối tượng được lưu trữ trong Database.
	
Ví du Class DTO_Lop:
	
		namespace DTO
		{
			public class DTO_Lop
			{
				private string maLop;

				public string MaLop
				{
					get { return maLop; }
					set { maLop = value; }
				}
				
				private string tenLop;

				public string TenLop
				{
					get { return tenLop; }
					set { tenLop = value; }
				}

				private string maKhoa;

				public string MaKhoa
				{
					get { return maKhoa; }
					set { maKhoa = value; }
				}

				public DTO_Lop(string pmaLop,string ptenLop, string pmaKhoa)
				{
					this.maLop = pmaLop;
					this.tenLop = ptenLop;
					this.maKhoa = pmaKhoa;
				}
			}
		}
    
**- Preject DAL:** DAL chứa các Class và các Class này có chức năng giao tiếp với hệ quản trị CSDL như thực hiện các công việc liên quan đến lưu trữ và truy vấn dữ liệu ( tìm kiếm, thêm, xóa, sửa,…).
	
Ví du Class Dal_Lop:
		
		namespace DAL
		{
			public class Dal_Lop:connect
			{
				SqlDataAdapter adap;
				DataTable dt;

				public DataTable LOP()
				{
					adap = new SqlDataAdapter("SELECT * FROM LOP", dbConn);
					dt = new DataTable();
					adap.Fill(dt);
					dbConn.Close();
					return dt;
				}
				public DataTable Khoa_DS()
				{
					string cmd = "SELECT * FROM KHOA";
					adap = new SqlDataAdapter(cmd, dbConn);
					dt = new DataTable();
					adap.Fill(dt);
					return dt;
				}
		 
				public bool  themLop(DTO_Lop pLop)
				{
					dbConn.Open();
					string cmd = "INSERT INTO LOP VALUES(N'" + pLop.MaLop + "',N'" + pLop.TenLop + "',N'" + pLop.MaKhoa + "')";
					SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
					sqlCmd.ExecuteNonQuery();
					dbConn.Close();
					return true;
				}
				public bool suaLop(DTO_Lop pLop)
				{
					dbConn.Open();
					string cmd = "UPDATE LOP SET TENLOP=N'" + pLop.TenLop + "',MAKHOA='" + pLop.MaKhoa + "' WHERE MALOP='" + pLop.MaLop + "'";
					SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
					sqlCmd.ExecuteNonQuery();
					dbConn.Close();
					return true;
				}
				public bool xoaLop(String maLop)
				{
					dbConn.Open();
					string cmd = "DELETE FROM LOP WHERE MALOP='" + maLop + "'";
					SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
					sqlCmd.ExecuteNonQuery();
					dbConn.Close();
					return true;
				}

			}
		}

**- Preject BUS:** BUS chứa các Class là cầu nối giửa DTO và DAL
	
Ví du Class BUS_Lop:
	
		namespace BUS
		{
			public class BUS_Lop
			{
				Dal_Lop dal_Lop = new Dal_Lop();

				public bool themLop(DTO_Lop pLop)
				{
					return dal_Lop.themLop(pLop);
				}

				public bool suaLop(DTO_Lop pLop)
				{
					return dal_Lop.suaLop(pLop);
				}

				public bool xoaLop(String maLop)
				{
					return dal_Lop.xoaLop(maLop);
				}

				public DataTable LOP()
				{
					return dal_Lop.LOP();
				}
				public DataTable KHOA()
				{
					return dal_Lop.Khoa_DS();
				}
			}
		}

**- Preject GUI:** GUI là nơi có nhiệm vụ chính giao tiếp với người dùng. Nó gồm các thành phần giao diện và thực hiện các công việc như nhập liệu, hiển thị dữ liêu, kiểm tra tính đúng đắn dữ liệu trước khi gọi lớp BLL.
##  + Chuẩn lập trình: Chúng ta xẻ dùng quy tắc Camel để đặt tên hàm và biến trong chương trình
** Quy tắc Camel:** Chữ cái đầu tiên của từ đầu tiên viết thường. Các từ còn lại viết hoa chữ cái đầu tiên.
	
	Ví dụ:
	namespace DTO
	{
		public class DTO_Lop
		{
		private string maLop;

		private string tenLop;

		private string maKhoa;
		}
	}
