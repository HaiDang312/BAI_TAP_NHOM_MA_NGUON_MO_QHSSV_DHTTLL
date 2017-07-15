# Tài Liệu cho nhà phát triển
-Tài liệu hướng dẫn phát triển mẫu của nhóm gồm có nhiều bài viết, nhiều câu hỏi và hướng dẫn.
## B1: Tạo 1 project và thiết kế project theo mô hình 3 lớp (DAL,BUS,GUI) có thể có DTO để liên kết với các Bảng trong CSDL
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20068411_852585661557962_979308003_n.png?oh=c6c52fe73cbe93736f9a8317f6ece553&oe=596C8288"></p>

## B2: Tạo class trong DTO để liên kết với các bảng trong csdl
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20120945_852588238224371_1288922867_n.png?oh=9e9e6e3c876be5f733869bf9a70119f9&oe=596C0AB3"></p>

## B3: Tạo class trong DAL. 
Trong DAL có các class chứa các chức năng kết nối với csdl
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20121114_852590174890844_752063993_n.png?oh=6de3e301dbd0b1589f8f5c655f7da190&oe=596B5A79"></p>

## B4: Tạo class trong BUS. 
Trong BUS có các class chứa các chức năng thực thi truy vấn như thêm, sửa, xóa, cập nhật vào csdl.
Ở đây câu lệnh truy vấn được đặt bên DAL và ta chỉ việc gọi lại bên BUS
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20117451_852593561557172_1016729950_n.png?oh=7e336c35146e5e5cf8be45cb6813fd28&oe=596C652C"></p>
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20117380_852593598223835_400839047_n.png?oh=da511dff43b5a065d549486827e91df0&oe=596CA3EC"></p>

## B5: Thiết kế form.
Viết các câu lệnh truy xuất để lấy các dữ liệu đã có từ BUS,DAL,DTO
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20120835_852596484890213_989527591_n.png?oh=68b05e4bc65c4d8dcd32aa3607535ce4&oe=596C46F3"></p>
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20067787_852596514890210_207400274_n.png?oh=9d2a706b9e36052d959ccca68f7dd2a8&oe=596C1D54"></p>

Làm tương tự với các form còn lại.

# Một số câu hỏi thường gặp:

## -Làm thế nào để lấy dữ liệu vào combobox?

## -Trả lời:

-Để lấy dữ liệu vào combobox ta làm các bước sau:

## -B1: Tạo 1 hàm DataTable ở 1 class trong DAL
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20134589_852606398222555_1257883421_n.png?oh=de6734e706f5a5a088110aa9a296a9f8&oe=596C9D26"></p>

## -B2: Truy xuất hàm DataTable vừa tạo ở 1 class trong BUS
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20117256_852607494889112_1822966492_n.png?oh=cf3c9a6f9fcabc6e70395826a9cb2c01&oe=596C5FD6"></p>

## -B3: Gọi các hàm vừa tạo và set thuộc tính cho combobox trong GUI
<p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20067719_852609094888952_1036496991_n.png?oh=d5c8f2a7aec5756359097ab43ce90071&oe=596C5018"></p>

## -Làm thế nào đặt chế độ chỉ đọc khi tích radial button?

## -Trả lời: Ta làm như sau:
- Ta viết code trực tiếp cho radial button

         txtNgayHH.ReadOnly = true;
         
- Trong đó: 
    txtNgayHH là textbox mà bạn muốn đặt chế độ chỉ đọc
    <p><img src="https://scontent.fsgn2-1.fna.fbcdn.net/v/t34.0-12/20136698_852612421555286_379781211_n.png?oh=bf0db357b830b7b68a564fded8318a00&oe=596C92AB"></p>
