USE BookStore
GO

INSERT dbo.CategoryGroup
        ( GroupID, GroupName )
VALUES
( 'GC-001' , N'THỂ LOẠI'),
( 'GC-002' , N'ĐƯỢC YÊU THÍCH NHẤT'),
( 'GC-003' , N'TRỌN BỘ')
GO

INSERT dbo.Category
        ( CategoryID , CategoryName, CategoryDescription, Url, CateGroupID
        )
VALUES
( 'CT-001' , N'Kinh Tế', '', 'kinh-te', 'GC-001'),
( 'CT-002' , N'Văn Học', '', 'van-hoc', 'GC-001'),
( 'CT-003' , N'Nấu Ăn', '', 'nau-an', 'GC-001'),
( 'CT-004' , N'Sức Khoẻ & Thể Thao', '', 'suc-khoe-the-thao', 'GC-001'),
( 'CT-005' , N'Lịch Sử', '', 'lich-su', 'GC-001'),
( 'CT-006' , N'Tiểu thuyết', '', 'tieu-thuyet', 'GC-002'),
( 'CT-007' , N'Tôn Giáo', '', 'ton-giao', 'GC-002'),
( 'CT-008' , N'Lãng Mạng', '', 'lang-mang', 'GC-002'),
( 'CT-009' , N'Viễn Tưởng', '', 'vien-tuong', 'GC-002'),
( 'CT-010' , N'Tiểu Sử', '', 'tieu-su', 'GC-002'),
( 'CT-011' , N'Khoa Học', '', 'doi-song', 'GC-003'),
( 'CT-012' , N'Đời Sống', '', 'doi-song', 'GC-003'),
( 'CT-013' , N'Hoàn Thiện Bản Thân', '', 'hoan-thien', 'GC-003'),
( 'CT-014' , N'Bất Động Sản', '', 'bat-dong-san', 'GC-003'),
( 'CT-015' , N'Danh Nhân', '', 'doanh-nhan', 'GC-003'),
( 'CT-016' , N'Trinh Thám', '', 'trinh-tham', 'GC-003')
GO

INSERT dbo.Author
        ( AuthorID , AuthorName , PhoneNumber , Url )
VALUES
		( 'AU-001' , N'J.K Rowling', '', 'jk-rowling'),
		( 'AU-002' ,N'La Quán Trung' ,'' ,'laquantrung'),
		( 'AU-003' ,N'Thị Nại Am' ,'' ,'thinaiam'),
		( 'AU-004' ,N'Ngô Thừa Ân' ,'' ,'ngothuaan'),
		( 'AU-005' ,N'Tào Huyết Cần' ,'' ,'taohuyetcan'),
		( 'AU-006' ,N'Kim Dung' ,'' ,'kimdung'),
		( 'AU-007' ,N'Trần Thanh Phong' ,'' ,'tran-thanh-phong'),
		( 'AU-008' ,N'Roger E. A. Farmer' ,'' ,'roger-e-a-farmer'),
		( 'AU-009' ,N'Quỳnh Chi' ,'' ,'quynh-chi'),
		( 'AU-010' ,N'Christine Hà' ,'' ,'christine-ha'),
		( 'AU-011' ,N'Bill Henderson' ,'' ,'bill-henderson'),
		( 'AU-012' ,N'Guillem Balague' ,'' ,'Guillem-Balague'),
		( 'AU-013' ,N'Paul Giran' ,'' ,'paul-giran'),
		( 'AU-014' ,N'Arnold J Toynbee' ,'' ,'arnold-j-oynbee'),
		( 'AU-015' ,N'Vladimir Nabokov' ,'' ,'vladimir-nabokov'),
		( 'AU-016' ,N'Nguyễn Nhật Ánh' ,'' ,'nguyen-nhat-anh'),
		( 'AU-017' ,N'Herbert P.Bix' ,'' ,'herbert-p-bix'),
		( 'AU-018' ,N'Nguyễn Khuê' ,'' ,'nguyen-khue'),
		( 'AU-019' ,N'Paul Knoepfler' ,'' ,'paul-knoepfler'),
		( 'AU-020' ,N'Michael Talbot' ,'' ,'michael-talbot'),
		( 'AU-021' ,N'Victor E. Frankl' ,'' ,'victor e. frankl'),
		( 'AU-022' ,N'Jim Rohn' ,'' ,'jim-rohn'),
		( 'AU-023' ,N'Nguyễn Hữu Vũ' ,'' ,'nguyen-huu-vu'),
		( 'AU-024' ,N'Nguyễn Thị Cúc' ,'' ,'nguyen-thi-cuc')
GO

INSERT dbo.Producer
        ( ProducerID , ProducerName , ProducerAddress , PhoneNumber , FAX , Email , Website , Url )
VALUES
( 'PD-001' , N'Tiki', '', '', '', '', 'tiki.vn', 'tiki')
GO

INSERT dbo.Book
        ( BookID, BookName, Price, DiscountPercent, Quantity, TotalSell, Avatar, CreateByDate, Url,
		  Publisher, PublicByDate, BookCover, Pages, BookDescription, 
		  AuthorID, ProducerID)
VALUES
( 'BK-00001' , N'Harry Potter và Hòn đá Phù thuỷ', 10000, 10, 10, 0, 'BK-00001.jpg', GETDATE(),
  'harry-potter-va-ham-chua-bi-mat',
   N'NXB Kim Đồng', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-001', 'PD-001'),
( 'BK-00002' , N'Harry Potter và Hầm chứa bí mật', 10000, 10, 10, 0, 'BK-00002.jpg', GETDATE(),
  'harry-potter-va-ham-chua-bi-mat',
   N'NXB Kim Đồng', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-001', 'PD-001'),
( 'BK-00003' , N'Harry Potter và Tù nhân Azkaban', 10000, 10, 10, 0, 'BK-00003.jpg', GETDATE(),
  'harry-potter-va-tu-nhan-azkaban',
   N'NXB Kim Đồng', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-001', 'PD-001'),
( 'BK-00004' , N'Harry Potter và Chiếc cốc lửa', 10000, 10, 10, 0, 'BK-00004.jpg', GETDATE(),
  'harry-potter-va-chiec-coc-lua',
   N'NXB Kim Đồng', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-001', 'PD-001'),
( 'BK-00005' , N'Harry Potter và Mệnh lệnh Phượng hoàng', 10000, 10, 10, 0, 'BK-00005.jpg', GETDATE(),
  'harry-potter-va-menh-lenh-phuong-hoang',
   N'NXB Kim Đồng', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-001', 'PD-001'),
( 'BK-00006' , N'Harry Potter và Hoàng tử lai', 10000, 10, 10, 0, 'BK-00006.jpg', GETDATE(),
  'harry-potter-va-hoang-tu-lai',
   N'NXB Kim Đồng', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-001', 'PD-001'),
( 'BK-00007' , N'Harry Potter và Bảo bối Tử thần', 10000, 10, 10, 0, 'BK-00007.jpg', GETDATE(),
  'harry-potter-va-bao-boi-tu-than',
   N'NXB Kim Đồng', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-001', 'PD-001'),
( 'BK-00008' , N'Khởi Nghiệp Bán Lẻ', 10000, 10, 10000, 0, 'BK-00008.jpg', GETDATE(),
  'khoi-nghiep-ban-le',
   N'Nhà Xuất Bản Đà Nẵng', '2001-01-11', N'Bìa cứng', 200, 'Sách Khởi Nghiệp',
  'AU-007', 'PD-001'),
( 'BK-00009' , N'Cách Nền Kinh Tế Vận Hành', 300000, 10, 100, 0, 'BK-00009.jpg', GETDATE(),
  'cach-nen-kinh-te-van-hanh',
   N'Nhà Xuất Bản Tri Thức', '2010-05-12', N'Bìa cứng', 300, 'Sách Kinh Tế',
  'AU-008', 'PD-001'),
( 'BK-00010' , N'Thủy Hử', 10000, 10, 1000, 0, 'BK-00010.jpg', GETDATE(),
  'thuy-hu',
   N'Nhà Xuất Bản Văn Học', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-003', 'PD-001'),
( 'BK-00011' , N'Tây Du Ký', 30000, 10, 1000, 0, 'BK-00011.jpg', GETDATE(),
  'tay-du-ky',
   N'NXB Trẻ', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-004', 'PD-001'),
( 'BK-00012' , N'Nấu Ăn Gia Đình', 10000, 10, 10, 0, 'BK-00012.jpg', GETDATE(),
  'nau-an-gia-dinh',
   N'NXB Trẻ', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-009', 'PD-001'),
( 'BK-00013' , N'Nấu Ăn Bằng Cả Trái Tim', 10000, 10, 10, 0, 'BK-00013.jpg', GETDATE(),
  'nau-an-bang-ca-trai-tim',
   N'NXB Hồng Đức', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-010', 'PD-001'),
( 'BK-00014' , N'Thoát Khỏi Ung Thư', 10000, 10, 10, 0, 'BK-00014.jpg', GETDATE(),
  'thoat-khoi-ung-thu',
   N'NXB Văn Hóa', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-011', 'PD-001'),
( 'BK-00015' , N'CR7 Hành Trình Lên Đỉnh Thể Giới', 10000, 10, 10, 0, 'BK-00015.jpg', GETDATE(),
  'cr7-hanh-trinh-len-dinh-the-gioi',
   N'NXB Thể Thao', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-012', 'PD-001'),
( 'BK-00016' , N'Tâm Lý Người Dân An Nam', 10000, 10, 10, 0, 'BK-00016.jpg', GETDATE(),
  'tam-ly-nguoi-dan-an-nam',
   N'NXB Văn Hóa', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-013', 'PD-001'),
( 'BK-00017' , N'Nghiên Cứu Lịch Sử Nhân Loại', 10000, 10, 10, 0, 'BK-00017.jpg', GETDATE(),
  'nghien-cu-lich-su-nhan-loai',
   N'NXB Lịch Sử', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-014', 'PD-001'),
( 'BK-00018' , N'Lolita', 10000, 10, 10, 0, 'BK-00018.jpg', GETDATE(),
  'lo-li-ta',
   N'NXB Văn Hóa', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-015', 'PD-001'),
( 'BK-00019' , N'Mắt Biếc', 10000, 10, 10, 0, 'BK-00019.jpg', GETDATE(),
  'mat-biec',
   N'NXB Văn Hóa', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-016', 'PD-001'),
( 'BK-00020' , N'Những Cô Em Gái', 10000, 10, 10, 0, 'BK-00020.jpg', GETDATE(),
  'nhung-co-em-gai',
   N'NXB Văn Hóa', '2010-05-12', N'Bìa cứng', 200, '',
  'AU-016', 'PD-001'),
( 'BK-00021' , N'Tiểu Sử Nhật Hoàng Hirohito', 10000, 10, 10000, 0, 'BK-00021.jpg', GETDATE(),
  'tieu-su-nhat-hoang-hirohito',
   N'Nhà Xuất Bản Đà Nẵng', '2001-01-11', N'Bìa cứng', 200, 'Sách Khởi Nghiệp',
  'AU-017', 'PD-001'),
  ( 'BK-00022' , N'Biên Niên Tiểu Sử Hồ Chí Minh', 10000, 10, 10000, 0, 'BK-00022.jpg', GETDATE(),
  'tieu-su-ho-chi-minh',
   N'Nhà Xuất Bản Khoa Học', '2001-01-11', N'Bìa cứng', 200, '',
  'AU-018', 'PD-001'),
  ( 'BK-00023' , N'Tế bào Gốc', 10000, 10, 10000, 0, 'BK-00023.jpg', GETDATE(),
  'te-bao-goc',
   N'Nhà Xuất Bản Khoa Học', '2001-01-11', N'Bìa cứng', 200, 'Sách Khoa học',
  'AU-019', 'PD-001'),
  ( 'BK-00024' , N'Vũ Trụ Toàn Ảnh', 10000, 10, 10000, 0, 'BK-00024.jpg', GETDATE(),
  'vu-tru-toan-anh',
   N'Nhà Xuất Bản Khoa Học', '2001-01-11', N'Bìa cứng', 200, 'Sách Khoa học',
  'AU-020', 'PD-001'),
  ( 'BK-00025' , N'Đi Tìm Lẽ Sống', 10000, 10, 10000, 0, 'BK-00025.jpg', GETDATE(),
  'di-tim-le-song',
   N'Nhà Xuất Bản Đời Sống', '2001-01-11', N'Bìa cứng', 200, 'Sách Đời Sống',
  'AU-021', 'PD-001'),
  ( 'BK-00026' , N'Triết Lý Cuộc Đời', 10000, 10, 10000, 0, 'BK-00026.jpg', GETDATE(),
  'triet-ly-cuoc-doi',
   N'Nhà Xuất Bản Đời Sống', '2001-01-11', N'Bìa cứng', 200, 'Sách Đời Sống',
  'AU-022', 'PD-001'),
  ( 'BK-00027' , N'Pháp Lý Bất Động Sản', 10000, 10, 10000, 0, 'BK-00027.jpg', GETDATE(),
  'phap-ly-bat-dong-san',
   N'Nhà Xuất Bản Pháp Luât', '2001-01-11', N'Bìa cứng', 200, 'Sách Pháp Luật',
  'AU-023', 'PD-001'),
  ( 'BK-00028' , N'Đầu Tư Kinh Doanh Bất Động Sản', 10000, 10, 10000, 0, 'BK-00028.jpg', GETDATE(),
  'dau-tu-kinh-doanh-bat-dong-san',
   N'Nhà Xuất Bản Pháp Luât', '2001-01-11', N'Bìa cứng', 200, 'Sách Pháp Luật',
  'AU-024', 'PD-001'),
  ( 'BK-00029' , N'Tam Quốc Diễn Nghĩa', 10000, 10, 10000, 0, 'BK-00029.jpg', GETDATE(),
  'tam-quoc-dien-nghia',
   N'NXB Văn Học', '2001-01-11', N'Bìa cứng', 200, 'Sách Văn Học',
  'AU-002', 'PD-001'),
  ( 'BK-00030' , N'Hồng Lâu Mộng', 10000, 10, 10000, 0, 'BK-00030.jpg', GETDATE(),
  'hong-long-mong',
   N'NXB Văn Học', '2001-01-11', N'Bìa cứng', 200, 'Sách Văn Học',
  'AU-005', 'PD-001')
GO

INSERT dbo.Book_Category
        ( CategoryID, BookID )
VALUES  ( 'CT-006', 'BK-00001' ),
		( 'CT-009', 'BK-00001' ),
		( 'CT-006', 'BK-00002' ),
		( 'CT-009', 'BK-00002' ),
		( 'CT-006', 'BK-00003' ),
		( 'CT-009', 'BK-00003' ),
		( 'CT-006', 'BK-00004' ),
		( 'CT-009', 'BK-00004' ),
		( 'CT-006', 'BK-00005' ),
		( 'CT-009', 'BK-00005' ),
		( 'CT-006', 'BK-00006' ),
		( 'CT-009', 'BK-00006' ),
		( 'CT-006', 'BK-00007' ),
		( 'CT-009', 'BK-00007' ),
		( 'CT-001', 'BK-00008' ),
		( 'CT-001', 'BK-00009' ),
		( 'CT-002', 'BK-00010' ),
		( 'CT-016', 'BK-00010' ),
		( 'CT-002', 'BK-00011' ),
		( 'CT-016', 'BK-00011' ),
		( 'CT-002', 'BK-00029' ),
		( 'CT-016', 'BK-00029' ),
		( 'CT-002', 'BK-00030' ),
		( 'CT-016', 'BK-00030' ),
		( 'CT-003', 'BK-00012' ),
		( 'CT-003', 'BK-00013' ),
		( 'CT-004', 'BK-00014' ),
		( 'CT-004', 'BK-00015' ),
		( 'CT-005', 'BK-00016' ),
		( 'CT-005', 'BK-00017' ),
		( 'CT-006', 'BK-00018' ),
		( 'CT-008', 'BK-00018' ),
		( 'CT-006', 'BK-00019' ),
		( 'CT-008', 'BK-00019' ),
		( 'CT-006', 'BK-00020' ),
		( 'CT-008', 'BK-00020' ),
		( 'CT-010', 'BK-00021' ),
		( 'CT-010', 'BK-00022' ),
		( 'CT-011', 'BK-00023' ),
		( 'CT-011', 'BK-00024' ),
		( 'CT-012', 'BK-00025' ),
		( 'CT-012', 'BK-00026' ),
		( 'CT-014', 'BK-00027' ),
		( 'CT-014', 'BK-00028' ),
		( 'CT-015', 'BK-00021' ),
		( 'CT-015', 'BK-00022' )
GO

INSERT dbo.News
        ( NewsID , NewsName, Content, PostByDate )
VALUES  ( 'NS-001', N'Bài viết số 1', N'Bài viết này chưa có gì cả' ,  GETDATE() ),
		( 'NS-002', N'Bài viết số 2', N'Bài viết này chưa có gì cả' ,  GETDATE() ),
		( 'NS-003', N'Bài viết số 3', N'Bài viết này chưa có gì cả' ,  GETDATE() )
GO

INSERT dbo.[Role]
        ( RoleID , RoleName )
VALUES  ( 'RL-001', N'Quản trị' ),
		( 'RL-002', N'Nhân viên' ),
		( 'RL-003', N'Khách hàng' )
GO

INSERT dbo.[User]
        ( UserID , UserName , [Password] , CreatedByDate , RoleID )
VALUES  ( 'US-001', 'admin' , '123456' , GETDATE() , 'RL-001' ),
		( 'US-002', 'nv1' , '123456' , GETDATE() , 'RL-002' ),
		( 'US-003', 'khachhang' , '123456' , '2020/06/24' , 'RL-003' ),
		( 'US-004', 'khachhang2' , '123456' , '2020/06/27' , 'RL-003' ),
		( 'US-005', 'khachhang3' , '123456' ,'2020/07/02' , 'RL-003' ),
		( 'US-006', 'khachhang4' , '123456' , '2020/07/04' , 'RL-003' ),
		( 'US-007', 'khachhang5' , '123456' , '2020/07/10' , 'RL-003' ),
		( 'US-008', 'khachhang6' , '123456' , '2020/07/14' , 'RL-003' ),
		( 'US-009', 'khachhang7' , '123456' , '2020/07/15' , 'RL-003' ),
		( 'US-010', 'khachhang8' , '123456' , '2020/07/16' , 'RL-003' ),
		( 'US-011', 'khachhang9' , '123456' , '2020/07/18' , 'RL-003' ),
		( 'US-012', 'khachhang10' , '123456' , '2020/07/19' , 'RL-003' )
GO

INSERT dbo.Customer
        ( CustomerID, CustomerAddress , CustomerName , Gender , Birth , PhoneNumber , Email , UserID )
VALUES
( 'CS-001', N'Nha Trang' , N'Trương Quốc Huy' ,  1 , '2001/12/23' , '0392594134' , 'tqhuy@gmail.com' , 'US-003' ),
( 'CS-002', N'Nha Trang' , N'Hàng Minh Sơn' ,  1 , '2001/03/12' , '0392594134' , 'hmson@gmail.com' , 'US-004' ),
( 'CS-003', N'Nha Trang' , N'Nguyễn Thành Đạt' ,  1 , '2001/01/29' , '0392594134' , 'ntdat@gmail.com' , 'US-005' ),
( 'CS-004', N'Nha Trang' , N'Trần Duy Liêm' ,  1 , '2001/04/16' , '0392594134' , 'tdliem@gmail.com' , 'US-006' ),
( 'CS-005', N'Nha Trang' , N'Nguyễn Thành Sang' ,  1 , '2001/12/23' , '0392594134' , 'ntsang@gmail.com' , 'US-007' ),
( 'CS-006', N'Nha Trang' , N'Lê Lâm Nhàn' ,  1 , '2001/12/23' , '0392594134' , 'lelamnhan@gmail.com' , 'US-008' ),
( 'CS-007', N'Nha Trang' , N'Cao Hào Kiệt' ,  1 , '2001/12/23' , '0392594134' , 'chkiet@gmail.com' , 'US-009' ),
( 'CS-008', N'Nha Trang' , N'Trần Đức Tín' ,  1 , '2001/12/23' , '0392594134' , 'tdtin@gmail.com' , 'US-010' ),
( 'CS-009', N'Nha Trang' , N'Nguyễn Huỳnh Đạt' ,  1 , '2001/12/23' , '0392594134' , 'nhdat@gmail.com' , 'US-011' ),
( 'CS-010', N'Nha Trang' , N'Trần Hoàng Minh' ,  1 , '2001/12/23' , '0392594134' , 'thminh@gmail.com' , 'US-012' )
GO

INSERT dbo.Wishlist
        ( CustomerID, BookID )
VALUES  ( 'CS-001', 'BK-00001' ),
		( 'CS-001', 'BK-00002' )
GO

INSERT dbo.Payment
        ( PaymentID, PaymentName )
VALUES  ( 'PM-001', N'Thanh toán tiền mặt' ),
		( 'PM-002', N'Thanh toán qua thẻ ngân hàng')
GO

INSERT dbo.[Order]
        ( OrderID, [Address] , OrderByDate , [Status] , Notes, Total, CustomerID , PaymentID )
VALUES  ( 'OD-000001', 'Nha Trang' , '2020/06/24' ,  N'Đã duyệt' , '', 20000 , 'CS-001' , 'PM-001' ),
		( 'OD-000002',  'Nha Trang' , '2020/06/26' ,  N'Đã duyệt' , '', 20000 , 'CS-001' , 'PM-001' ),
		( 'OD-000003',  'Nha Trang' , '2020/06/25' ,  N'Đã duyệt' , '', 10000 , 'CS-002' , 'PM-001' ),
		( 'OD-000004',  'Nha Trang' , '2020/06/25' ,  N'Đã duyệt' , '', 9000 , 'CS-003' , 'PM-001' ),
		( 'OD-000005',  'Nha Trang' , '2020/06/25' ,  N'Đã duyệt' , '', 10000 , 'CS-004' , 'PM-001' ),
		( 'OD-000006',  'Nha Trang' , '2020/06/25' ,  N'Đã duyệt' , '', 20000 , 'CS-005' , 'PM-001' ),
		( 'OD-000007',  'Nha Trang' , '2020/06/25' ,  N'Đã duyệt' , '', 27000 , 'CS-006' , 'PM-001' ),
		( 'OD-000008',  'Nha Trang' , '2020/06/25' ,  N'Đã duyệt' , '', 18000 , 'CS-007' , 'PM-001' ),
		( 'OD-000009',  'Nha Trang' , '2020/06/25' ,  N'Đã duyệt' , '', 19000 , 'CS-008' , 'PM-001' ),
		( 'OD-000010',  'Nha Trang' , '2020/06/25' ,  N'Đã duyệt' , '', 21000 , 'CS-003' , 'PM-001' ),
		( 'OD-000011',  'Nha Trang' , '2020/06/25' ,  N'Chờ duyệt' , '', 30000 , 'CS-003' , 'PM-001' ),
		( 'OD-000012',  'Nha Trang' , '2020/06/25' ,  N'Chờ duyệt' , '', 9000 , 'CS-004' , 'PM-001' )
GO

INSERT dbo.OrderDetail
        ( Quantity, Price, OrderID, BookID )
VALUES  ( 1, 10000 , 'OD-000001' , 'BK-00001' ),
		( 1, 10000 , 'OD-000001' , 'BK-00002' ),
		( 1, 10000 , 'OD-000002' , 'BK-00003' ),
		( 1, 10000 , 'OD-000002' , 'BK-00004' ),
		( 1, 10000 , 'OD-000002' , 'BK-00015' ),
		( 1,  9000 , 'OD-000003' , 'BK-00017' ),
		( 1, 90000 , 'OD-000004' , 'BK-00009' ),
		( 1, 10000 , 'OD-000005' , 'BK-00004' ),
		( 1, 10000 , 'OD-000006' , 'BK-00001' ),
		( 1, 10000 , 'OD-000006' , 'BK-00007' ),
		( 1,  8000 , 'OD-000007' , 'BK-00011' ),
		( 1, 10000 , 'OD-000007' , 'BK-00012' ),
		( 1,  9000 , 'OD-000007' , 'BK-00013' ),
		( 1,  9000 , 'OD-000008' , 'BK-00007' ),
		( 1,  9000 , 'OD-000008' , 'BK-00008' ),
		( 1, 10000 , 'OD-000009' , 'BK-00022' ),
		( 1,  9000 , 'OD-000009' , 'BK-00019' ),
		( 1, 11000 , 'OD-000010' , 'BK-00015' ),
		( 1, 10000 , 'OD-000010' , 'BK-00016' ),
		( 1, 10000 , 'OD-000011' , 'BK-00014' ),
		( 2, 10000 , 'OD-000011' , 'BK-00019' ),
		( 1,  9000 , 'OD-000011' , 'BK-00021' )
GO

INSERT dbo.Review
        ( ReviewID, ReviewByDate , Content , BookID , CustomerID )
VALUES  ( 'RV-0001', GETDATE() , N'Sách này hay tuyệt' , 'BK-00001' , 'CS-001' ),
		( 'RV-0002', GETDATE() , N'Cuốn Harry Potter này đọc hay kinh' , 'BK-00001' , 'CS-001' )
GO