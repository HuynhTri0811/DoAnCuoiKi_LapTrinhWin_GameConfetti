# Dồ án môn học cuối kì : Game Confetti 
## 1 . Giới thiệu 
`Game Confetti` mô phỏng theo game confetti nổi tiếng 1 thời trên facebook .
Game cho phép nhiều client chơi thông qua 1 server có chức năng gửi câu hỏi và nhận câu trả lời từ phía client . Client có khả năng đọc câu hỏi và câu và trả lời cho server
## 2 . Những điều bạn cần có để chơi 
`Game confetti` được viết bằng ngôn ngữ C# net framework `Window form` nên bạn không thể sử dụng trên các hệ điều hành khác ngoại trừ window 
Nếu bạn muốn xem code thì bạn phải có các IDE để đọc code . Nếu các bạn muốn debug thì cần phải có IDE Visual studio 2017 trở lên
## 3 . Cách cài đặt 
* Nếu bạn tải xuống bằng file zip thì bạn cần giải nén file đó .
* Nếu bạn clone về thì không cần làm gì cả 
## 4 . Cách để chơi
1. Server
	* Tìm kiếm trong thư mục server có 1 thư mục bin , trong thư mục bin có thư mục debug , vào thư mục debug kiếm file server.exe rồi mở lên 
	* Server cho bạn thêm câu hỏi , Xóa câu hỏi , Quản lý câu hỏi
	* Quản lý người chơi thông qua name , biết người chơi nào đang có bao nhiêu câu trả lời đúng 
	* Gửi câu hỏi và câu trả lời cho client
2. Client 
	* Tìm kiếm trong thư mục client có 1 thư muc bin , trong thư mục bin có thư mục debug , vào thư mục debug kiếm file client.exe rồi mở lên 
	* Client sẽ gửi name cho server biết 
	* Nhận câu hỏi và trả lời câu hỏi 
	* Thông báo cho người chơi khi thắng cuộc
3. Lưu ý
	* Đừng mở client trước khi mở server
	* Chỉ chơi được nếu địa chỉ IP client là : `127.0.0.1` và port:`3000` 
