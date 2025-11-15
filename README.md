Bài 1: Viết chương trình minh họa các sự kiện trong vòng đời của form

Bài 2: Viết chương trình minh họa sự kiện Paint trên Form
- Mỗi khi sự kiện Paint xảy ra sẽ vẽ lại chuỗi “Paint Event” tại một vị trí x, y ngẫu nhiên
trên Form

Bài 3: Viết chương trình minh họa sự kiện Click trên Button
- Khi nhấn vào nút Change Color sẽ tiến hành chuyển màu nền của Form sang một màu
ngẫu nhiên.

Bài 4: Viết chương trình minh họa sử dụng Menu và hộp thoại ColorDialog
- Khi chọn chức năng Color trong menu Format sẽ mở ra hộp thoại ColorDialog
- Sau khi chọn màu trong hộp thoại ColorDialog sẽ tiến hành đổi màu nền của Form
theo màu đã chọn

Bài 5: Xây dựng ứng ựng GUI có giao diện tương tự như sau:

Bài 6: Xây dựng ứng Calculator có giao diện tương tự Calculator của Window

Bài 7: Xây dựng ứng dụng giúp cho rạp chiếu phim quản lý việc bán vé của mình với giao
diện như sau:
Rạp có 3 hàng ghế, mỗi hàng có 5 ghế, các ghế được đánh số từ 1 đến 15 và được phân thành
3 dãy như (hình trên):
- Giá vé lô A 5000/vé
- Giá vé lô B 6500/vé
- Giá vé lô C 8000/vé
Trên Form trình bày một sơ đồ các chỗ ngồi để người sử dụng chọn vị trí muốn mua. Trên sơ
đồ này cũng thể hiện những vị trí đã bán vé và những vị trí chưa bán vé bằng cách thể hiện
màu khác nhau (ghế chưa bán vé màu trắng, ghế đã bán vé màu vàng).
Khi người sử dụng click chuột tại một vị trí trên sơ đồ thì:
- Nếu đây là vị trí chưa bán vé thì đổi màu của vị trí này sang màu xanh để cho biết
đây là vị trí đang chọn.
- Nếu đây là vị trí đang chọn (có màu xanh) thì đổi màu của vị trí này trở về màu trắng
- Nếu đây là một vị trí đã bán vé (có màu vàng) thì xuất hiện một Message box thông
báo cho người sử dụng biết vé ở vị trí này đã được bán. Sau khi đã chọn các vị trí
người sử sụng có thể click chuột vào nút CHỌN hoặc HỦY BỎ
Nếu click vào nút CHỌN thì:
- Đổi màu các vị trí đã chọn (màu xanh) trên sơ đồ sang màu vàng (cho biết vị trí đã
bán vé)
- Xuất lên một Label tổng số tiền phải trả cho số vé đã mua (phụ thuộc vào các vị trí
đã chọn)
Nếu click vào nút HỦY BỎ thì:
- Đổi màu các vị trí đã chọn (màu xanh) trên sơ đồ sang màu trắng trở lại
- Xuất lên Label giá trị 0

Bài 8: Xây dựng chương trình quản lý thông tin tài khoản cần lưu trữ các thông tin sau: số tài
khoản, tên khách hàng, địa chỉ khách hàng và số tiền trong tài khoản. Thiết kế chương trình
quản lý thông tin tài khoản cho một ngân hàng có giao diện tương tự như sau:
Khi nhấn vào nút “Thêm/Cập Nhật”
- Kiểm tra các thông tin bắt buộc phải nhập liệu cho số tài khoản, tên, địa chỉ và số tiền.
Xuất hiện thông báo lỗi “Vui lòng nhập đầy đủ thông tin!”.- Nếu chưa có dữ liệu số tài khoản trong ListView thì Thêm mới dữ liệu nhập vào
ListView, tính lại tổng tiền và thông báo “Thêm mới dữ liệu thành công!”
- Nếu đã tồn tại số tài khoản trong ListView thì Cập nhật dữ liệu vào ListView và tính
lại tổng tiền và thông báo “Cập nhật dữ liệu thành công!”
Khi nhấn vào nút “Xóa”
- Kiểm tra nếu số tài khoản cần xóa tồn tại trong ListView, thì xuất hiện cảnh báo
YES/NO. Nhấn YES sẽ thực hiện xóa dòng dữ liệu tài khoản trong ListView và thông
báo “Xóa tài khoản thành công”.
- Nếu số tài khoản cần xóa không tồn tại thì thông báo lỗi “Không tìm thấy số tài khoản
cần xóa”.
- Viết code cho sự kiện ở ListView khi người dùng chọn 1 dòng thì thể hiện ngược lại ở
phần nhập liệu đúng thông tin trên.

Bài 9: Xây dựng chương trình cho phép nhập thông tin sinh viên với giao diện tương tự như
sau:
