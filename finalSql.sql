-------------------------------TẠO CSDL, TẠO BẢNG, ...
use master

CREATE DATABASE QuanLyQuanCafe
GO
USE QuanLyQuanCafe
GO


--Ban
--ThanhVien
--DanhMucMatHang
--MatHang
--HoaDon
--ThongTinHoaDon

CREATE TABLE UserLogin
(
	ID INT IDENTITY (1,1) PRIMARY KEY,
	Username NVARCHAR(100) NOT NULL,
	Password NVARCHAR(100) NOT NULL,
)

INSERT INTO UserLogin VALUES(N'admin',N'admin')

CREATE TABLE Ban
(
	ID VARCHAR(5) PRIMARY KEY NOT NULL DEFAULT 'B000',
	TenBan NVARCHAR(100) NOT NULL DEFAULT N'Tên bàn',
	TrangThai INT NOT NULL DEFAULT 0, -- 0: Trống || --1 Đã có người đặt bàn
)
GO

CREATE TABLE BanGopChung
(
	ID VARCHAR(5) NOT NULL,
	IDBanGop VARCHAR(5),
	PRIMARY KEY (ID, IDBanGop),
	FOREIGN KEY (ID) REFERENCES dbo.Ban(ID),
	FOREIGN KEY (IDBanGop) REFERENCES dbo.Ban(ID)
)

GO


CREATE TABLE ThanhVien
(
	ID VARCHAR(5) PRIMARY KEY DEFAULT 'TV000' ,
	HoTen NVARCHAR(100) NOT NULL,
	SDT VARCHAR(100) NOT NULL,
	NgayDK smalldatetime NOT NULL DEFAULT GETDATE(),
	LoaiThanhVien NVARCHAR(10) NOT NULL,-- 2. Gold ||1. Silver || 0. Thuong
	TienTichLuy FLOAT NOT NULL DEFAULT 0
)
GO


CREATE TABLE MatHang
(
	ID VARCHAR(5) PRIMARY KEY DEFAULT 'D000',
	TenMatHang NVARCHAR(100) NOT NULL,
	LoaiMatHang NVARCHAR(50),
	DonViTinh NVARCHAR(50),
	Gia INT NOT NULL DEFAULT 0
)
GO
CREATE TABLE HoaDon
(
	ID VARCHAR(5) PRIMARY KEY DEFAULT 'HD000',
	NgayThanhToan DATE NOT NULL DEFAULT GETDATE(),
	GiamGia FLOAT NOT NULL DEFAULT 0,
	IDBan VARCHAR(5) NOT NULL,
	IDThanhVien VARCHAR(5) DEFAULT NULL,
	TrangThai INT NOT NULL DEFAULT 0, -- 1. Da Thanh Toan || 0. Chua Thanh Toan
	TongTien Float NOT NULL DEFAULT 0,
	ThanhTien Float NOT NULL DEFAULT 0,

	FOREIGN KEY (IDBan) REFERENCES dbo.Ban(ID),
	FOREIGN KEY (IDThanhVien) REFERENCES dbo.ThanhVien(ID)
)
GO


CREATE TABLE ThongTinHoaDon
(
	IDMatHang VARCHAR(5) NOT NULL,
	IDHoaDon VARCHAR(5) NOT NULL,
	SL INT NOT NULL DEFAULT 0 -- Số lượng đồ uống
	
	PRIMARY KEY (IDMatHang, IDHoaDon),
	FOREIGN KEY (IDMatHang) REFERENCES dbo.MatHang(ID),
	FOREIGN KEY (IDHoaDon) REFERENCES dbo.HoaDon(ID),
)
GO
------------------------------------------------------ NHẬP DỮ LIỆU----------------------------------------------------


INSERT INTO MatHang VALUES('D001', N'Trà sữa truyền thống', N'Đồ uống', 'Ly', 12000)
INSERT INTO MatHang VALUES('D002', N'Trà sữa trà xanh', N'Đồ uống', 'Ly', 14000)
INSERT INTO MatHang VALUES('D003', N'Trà sữa Chocolate bạc hà', N'Đồ uống', 'Ly', 14000)
INSERT INTO MatHang VALUES('D004', N'Trà sữa trân châu', N'Đồ uống', 'Ly', 14000)
INSERT INTO MatHang VALUES('D005', N'Trà sữa thái xanh', N'Đồ uống', 'Ly', 16000)
INSERT INTO MatHang VALUES('D006', N'Trà sữa Chocolate', N'Đồ uống', 'Ly', 12000)
INSERT INTO MatHang VALUES('D007', N'Trà sữa bạc hà', N'Đồ uống', 'Ly', 12000)
INSERT INTO MatHang VALUES('D008', N'Trà sữa Caramen', N'Đồ uống', 'Ly', 18000)
INSERT INTO MatHang VALUES('D009', N'Trà sữa khoai môn', N'Đồ uống', 'Ly', 15000)
INSERT INTO MatHang VALUES('D010', N'Trà sữa dâu', N'Đồ uống', 'Ly', 18000)
INSERT INTO MatHang VALUES('D011', N'Trà sữa kiwi', N'Đồ uống', 'Ly', 20000)
INSERT INTO MatHang VALUES('D012', N'Trà sữa Việt quất', N'Đồ uống', 'Ly', 14000)
INSERT INTO MatHang VALUES('D013', N'Trà sữa sâm dứa', N'Đồ uống', 'Ly', 15000)
INSERT INTO MatHang VALUES('D014', N'Trà sữa hoa hồng', N'Đồ uống', 'Ly', 25000)
INSERT INTO MatHang VALUES('D015', N'Trà sữa hạt thủy tinh', N'Đồ uống', 'Ly', 22000)
INSERT INTO MatHang VALUES('D016', N'Trà sữa thạch', N'Đồ uống', 'Ly', 21000)
INSERT INTO MatHang VALUES('D017', N'Trà sữa phô mai', N'Đồ uống', 'Ly', 27000)
INSERT INTO MatHang VALUES('D018', N'Trà đào cam sả', N'Đồ uống', 'Ly', 25000)
INSERT INTO MatHang VALUES('D019', N'Trà vải', N'Đồ uống', 'Ly', 23000)
INSERT INTO MatHang VALUES('D020', N'Cà phê đá xay', N'Đồ uống', 'Ly', 25000)
INSERT INTO MatHang VALUES('D021', N'Cà phê sữa đá', N'Đồ uống', 'Ly', 28000)
INSERT INTO MatHang VALUES('D022', N'Sinh tố dâu', N'Đồ uống', 'Ly', 10000)
INSERT INTO MatHang VALUES('D023', N'Sinh tố cam', N'Đồ uống', 'Ly', 16000)
INSERT INTO MatHang VALUES('D024', N'Sinh tố trà xanh', N'Đồ uống', 'Ly', 14000)
INSERT INTO MatHang VALUES('D025', N'Sinh tố chanh dây', N'Đồ uống', 'Ly', 12000)
INSERT INTO MatHang VALUES('D026', N'Soda kiwi', N'Đồ uống', 'Ly', 17000)
INSERT INTO MatHang VALUES('D027', N'Soda chanh bạc hà', N'Đồ uống', 'Ly', 20000)
INSERT INTO MatHang VALUES('D028', N'Soda Việt quất', N'Đồ uống', 'Ly', 19000)
INSERT INTO MatHang VALUES('F001', N'Bánh tráng trộn', N'Đồ ăn', N'Đĩa', 10000)
INSERT INTO MatHang VALUES('F002', N'Bánh bông lan', N'Đồ ăn', N'Đĩa', 14000)
INSERT INTO MatHang VALUES('F003', N'Bánh hambuger', N'Đồ ăn', N'Đĩa', 18000)
INSERT INTO MatHang VALUES('F004', N'Bánh gạo', N'Đồ ăn', N'Đĩa', 10000)
INSERT INTO MatHang VALUES('F005', N'Xúc xích chiên', N'Đồ ăn', N'Đĩa', 14000)
INSERT INTO MatHang VALUES('F006', N'Khoai tây chiên', N'Đồ ăn', N'Đĩa', 8000)
INSERT INTO MatHang VALUES('F007', N'Nem chua rán', N'Đồ ăn', N'Đĩa', 12000)
INSERT INTO MatHang VALUES('F008', N'Chả ram tôm đất', N'Đồ ăn', N'Đĩa', 15000)
INSERT INTO MatHang VALUES('F009', N'Hồ lô', N'Đồ ăn', N'Đĩa', 10000)
INSERT INTO MatHang VALUES('F010', N'Cơm chiên muối é', N'Đồ ăn', N'Đĩa', 19000)
INSERT INTO MatHang VALUES('F011', N'Khô gà', N'Đồ ăn', N'Đĩa', 17000)
INSERT INTO MatHang VALUES('A001', N'Cafe bột', N'Khác', N'Gói', 17000)
INSERT INTO MatHang VALUES('A002', N'Cafe hạt', N'Khác', N'Gói', 20000)



SET DATEFORMAT DMY
INSERT INTO ThanhVien VALUES( 'TV001', N'Nguyễn Xuân Tú', '0389878809', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV002', N'Huỳnh Thị Kim Trâm', '0389873409', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV003', N'Hà Thúy Hằng', '0384578809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV004', N'Phan Lê Na', '0389878809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV005', N'Nguyễn Xuân Tiến', '038987864', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV006', N'Lê Anh Tú', '0389878809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV007', N'Lê Anh Trung', '0383458809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV008', N'Bùi Thu Trà', '0389864565', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV009', N'Nguyễn Thị Giang', '0983866669', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV010', N'Ngô Nữ Bảo Trâm', '0389444409', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV011', N'Nguyễn Ngọc Ánh', '0389822209', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV012', N'Hà Thị Giang', '0981118809', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV013', N'Nguyễn Thị Minh Hải', '0322273409', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV014', N'Võ Thị Liên', '038944409', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV015', N'Huỳnh Thị Kim Trúc', '0987777809', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV016', N'Trần Thị Huỳnh Ngọc', '0389888809', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV017', N'Lê Xuân Sơn', '03478809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV018', N'Nguyễn David Tuấn', '0897578809', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV019', N'Nguyễn Ken Shin', '0983873409', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV020', N'Nguyễn Lê Bảo Bình', '0397258809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV021', N'Lê Hoàng Liêm', '0985678809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV022', N'Hoàng Thái Bảo', '0984878809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV023', N'Trương Ngọc Hiếu', '054278809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV024', N'Võ Kim Sơn', '0975878809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV025', N'Nguyễn Nhật Chiêu', '0389866809', '13/11/2023', N'Thường', 0) 
INSERT INTO ThanhVien VALUES( 'TV026', N'Nguyễn Xuân Dương', '0983878809', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV027', N'Nguyễn Thiện Quang', '0389873409', '13/11/2023', N'Thường', 0)
INSERT INTO ThanhVien VALUES( 'TV028', N'Lê Anh Tuấn', '0369636841', '16/12/2023', N'Bạc', 0)
Go



------------------------------------------------------------------TẠO CÁC THỦ TỤC CẦN THIẾT
create procedure InsertThongTinHoaDon --Thêm CTHD, Chỉnh sửa số lượng.
	@IDBan varchar(5),
	@IDMatHang varchar(5),
	@SL int
as
BEGIN
	declare @IDHoaDon varchar(5) = (select ID from HoaDon where IDBan = @IDBan and TrangThai = 0)

	IF(exists(select * from ThongTinHoaDon where IDHoaDon = @IDHoaDon and IDMatHang = @IDMatHang))
	BEGIN
		declare @CurrSL int = (select SL from ThongTinHoaDon where IDHoaDon = @IDHoaDon and IDMatHang = @IDMatHang)
		IF(@CurrSL + @SL <= 0)
			delete from ThongTinHoaDon where IDHoaDon = @IDHoaDon and IDMatHang = @IDMatHang
		ELSE
			update ThongTinHoaDon
			set SL = SL + @SL
			where IDHoaDon = @IDHoaDon and IDMatHang = @IDMatHang
	END
	ELSE
		insert into ThongTinHoaDon values(@IDMatHang, @IDHoaDon, @SL)
END
go


create procedure DeleteThongTinHoaDon -- Xoá CTHD
	@IDBan varchar(5),
	@IDMatHang varchar(5)
as
BEGIN
	declare @IDHoaDon varchar(5) = (select ID from HoaDon where IDBan = @IDBan and TrangThai = 0)
	delete from ThongTinHoaDon where IDHoaDon = @IDHoaDon and IDMatHang = @IDMatHang
END
go

create procedure Delete_HoaDon_CTHD -- Xoá HOADON, CTHD TƯƠNG ỨNG
	@IDBan varchar(5)
as
BEGIN
	declare @IDHoaDon varchar(5) = (select ID from HoaDon where IDBan = @IDBan and TrangThai = 0)
	delete from ThongTinHoaDon where IDHoaDon = @IDHoaDon
	delete from HoaDon where ID = @IDHoaDon
END
go

create procedure GetThongTinHoaDonData -- Lấy thông tin hoá đơn
	@IDBan varchar(5)
as
	declare @IDHoaDon varchar(5) = (select ID from HoaDon where IDBan = @IDBan and TrangThai = 0)
	select IDMatHang as ID, TenMatHang, SL, ( Gia * SL) as TongTien
	from ThongTinHoaDon, MatHang where IDHoaDon = @IDHoaDon and ThongTinHoaDon.IDMatHang = MatHang.ID
go

create procedure GetLoaiThanhVien -- Tìm kiếm thông tin thành viên
	@SDT varchar(100),
	@Type int OUT,
	@ID varchar(5) OUT
as
BEGIN
	IF(exists(select * from ThanhVien where SDT = @SDT))
	BEGIN
		declare @LoaiTV nvarchar(10)

		set @ID = (select top 1 ID from ThanhVien where SDT = @SDT)
		set @LoaiTV = (select LoaiThanhVien from ThanhVien where ID = @ID)

		set @Type = case
						when @LoaiTV = N'Thường' then '0'
						when @LoaiTV = N'Bạc' then '1'
						else '2'
		end
	END
	ELSE
	BEGIN
		set @ID = NULL;
		set @Type = -1
	END
END
go

create procedure DeleteBanGop
	@IDBan varchar(5), @RESULT int OUT -- 1: success, 0: fail 
as
BEGIN
	if(exists(select * from BanGopChung where ID = @IDBan))
	BEGIN
		set @RESULT = 0
		return
	END
	ELSE
	BEGIN
		set @RESULT = 1
		delete from BanGopChung where IDBanGop = @IDBan
	END
END
go

create procedure DeleteAllBanGop
	@IDBan varchar(5)
as
BEGIN
	update Ban
	set TrangThai = 0
	where ID in (select IDBanGop from BanGopChung where ID = @IDBan) or ID = @IDBan

	EXEC Delete_HoaDon_CTHD @IDBan = @IDBan

	delete from BanGopChung where ID = @IDBan
END
go

create procedure DeleteAllBanGop_ThanhToan
	@IDBan varchar(5)
as
BEGIN
	if(exists(select * from BanGopChung where ID = @IDBan))
	BEGIN
		update Ban
		set TrangThai = 0
		where ID in (select IDBanGop from BanGopChung where ID = @IDBan)
	END

	delete from BanGopChung where ID = @IDBan
END
go

create procedure GetBanDaiDien
	@ID varchar(5), @RESULT varchar(5) OUT
as
BEGIN
	if(exists(select * from BanGopChung where IDBanGop = @ID))
	BEGIN
		set @RESULT = (select ID from BanGopChung where IDBanGop = @ID)
	END
	ELSE
		set @RESULT = @ID
END
go

create procedure CheckExistenceBanGop
	@ID varchar(5), @RESULT int OUT
as
BEGIN
	if(exists(select * from BanGopChung where IDBanGop = @ID) or exists(select * from BanGopChung where ID = @ID))
		set @RESULT = 1
	else 
		set @RESULT = 0
END
go

create procedure DeleteThanhVien
	@ID varchar(5)
as
BEGIN
	if(exists(select * from HoaDon where IDThanhVien = @ID))
	BEGIN
		update HoaDon
		set IDThanhVien = null
		where IDThanhVien = @ID
	END
	delete from ThanhVien where ID = @ID
END
go

------------------------------------------------TẠO CÁC RÀNG BUỘC TOÀN VẸN, XỬ LÍ RÀNG BUỘC TOÀN VẸN

create TRIGGER  TG_INS_HOADON --Tự tạo mã số hoá đơn
ON HOADON
FOR INSERT
AS
BEGIN
	DECLARE @preID VARCHAR(5), @currID VARCHAR(5), @IDTHANHVIEN VARCHAR(5), @TONGTIEN FLOAT

	SELECT @currID = ID, @IDTHANHVIEN= IDThanhVien, @TONGTIEN= TongTien  FROM INSERTED

	IF(NOT EXISTS (SELECT * FROM Ban WHERE ID != @currID))
	BEGIN
		UPDATE HoaDon
		SET ID = 'HD001'
		WHERE ID = @currID
	END
	ELSE
	BEGIN
		SELECT @preID = (SELECT MAX(A.ID_NUMBER) FROM (SELECT SUBSTRING(ID, 3, 3) AS ID_NUMBER FROM HoaDon) AS A)
		SET @preID = @preID + 1
		DECLARE @tmpID VARCHAR(5) = FORMAT(CAST(@preID AS INT), '000')
		UPDATE HoaDon
		SET ID = CONCAT('HD', @tmpID)
		WHERE ID = @currID
	END
END
GO


create trigger trigger_IDBAN_BAN on Ban for insert
as
BEGIN
	declare @preID varchar(5), @currID varchar(5)

	select @currID = ID from INSERTED

	if(not exists(select * from Ban where ID != @currID))
	BEGIN
		update Ban
		set ID = 'B001', TenBan = N'Bàn 1'
		where ID = @currID
	END
	ELSE
	BEGIN
		select @preID = (select MAX(A.ID_NUMBER) from (select SUBSTRING(ID, 2, 3) as ID_NUMBER from Ban) as A)
		set @preID = @preID + 1
		declare @tmpID varchar(5) = FORMAT(CAST(@preID as INT), '000')
		update Ban
		set ID = CONCAT('B', @tmpID), TenBan = CONCAT(N'Bàn ', @preID)
		where ID = @currID
	END
END
go


create trigger trigger_SL_CTHD on ThongTinHoaDon for insert, delete, update -- Tự động cập nhật TONGTIEN của HOADON khi có thay đổi về CTHD
as
BEGIN
	declare @type char(1) = case
	when (not exists(select * from INSERTED)) then 'D'
	when(exists(select * from DELETED)) then 'U'
	else 'I'
	end

	declare @IDHD varchar(5), @IDMH varchar(5), @SL int
	IF(@type = 'I')
	BEGIN
		select @IDHD = IDHoaDon, @IDMH = IDMatHang, @SL = SL from INSERTED
		update HoaDon
		set TongTien = TongTien + @SL * (select Gia from MatHang where ID = @IDMH)
		where ID = @IDHD
	END
	IF(@type = 'D')
	BEGIN
		select @IDHD = IDHoaDon, @IDMH = IDMatHang, @SL = SL from DELETED
		update HoaDon
		set TongTien = TongTien - @SL * (select Gia from MatHang where ID = @IDMH)
		where ID = @IDHD
	END
	IF(@type = 'U')
	BEGIN
		select @IDHD = IDHoaDon, @IDMH = IDMatHang, @SL = SL from INSERTED
		declare @SL_CU int = (select SL from DELETED)
		update HoaDon
		set TongTien = TongTien - (@SL_CU * (select Gia from MatHang where ID = @IDMH)) + (@SL * (select Gia from MatHang where ID = @IDMH))
		where ID = @IDHD
	END
END
go



create trigger ThanhTien_HD on HoaDon for insert, update -- Cập nhật THANHTIEN, TICHLUY
as
BEGIN

	-- Tự động cập nhật THANHTIEN = TONGTIEN - GIAMGIA
	declare @ID varchar(5) = (select ID from INSERTED)

	BEGIN
		update HoaDon
		set ThanhTien = TongTien - GiamGia
		where ID = @ID
	END


	-- Cập nhật lại tích luỹ thành viên khi hoá đơn tương ứng được thanh toán
	if(exists(select * from INSERTED) and exists(select * from DELETED))
	BEGIN
		declare @IDThanhVien varchar(5), @TrangThai int, @TongTien float
		select @IDThanhVien = IDThanhVien, @TrangThai = TrangThai, @TongTien = TongTien from INSERTED
		IF(@TrangThai = 1)
		BEGIN
			update ThanhVien
			set TienTichLuy = TienTichLuy + @TongTien
			where ID = @IDThanhVien
		END
	END
END
go


create trigger trigger_chuyenhoadon_gopban on BanGopChung for insert -- Cập nhật lại hoá đơn, thông tin hoá đơn liên quan đến những bàn được gộp.
as
BEGIN
	declare @ID varchar(5), @IDBanGop varchar(5)
	select @ID = ID, @IDBanGop = IDBanGop from inserted
	if(exists(select * from HoaDon where IDBan = @IDBanGop and TrangThai = 0))
	BEGIN
		declare @IDHoaDon varchar(5) = (select ID from HoaDon where IDBan = @IDBanGop and TrangThai = 0)
		declare @IDHoaDonMoi varchar(5)

		if(not exists(select * from HoaDon where IDBan = @ID and TrangThai = 0))
			insert into HoaDon (IDBan) values (@ID)

		set @IDHoaDonMoi = (select ID from HoaDon where IDBan = @ID and TrangThai = 0)

		if(exists(select * from ThongTinHoaDon where IDHoaDon = @IDHoaDon))
		BEGIN
			declare @IDMH varchar(5), @SL int
			declare cs_cthd cursor for (select IDMatHang, SL from ThongTinHoaDon where IDHoaDon = @IDHoaDon)
			open cs_cthd
			fetch next from cs_cthd into @IDMH, @SL

			while(@@FETCH_STATUS = 0)
			BEGIN
				EXEC InsertThongTinHoaDon @IDBan = @ID, @IDMatHang = @IDMH, @SL = @SL
				fetch next from cs_cthd into @IDMH, @SL
			END
			delete from ThongTinHoaDon where IDHoaDon = @IDHoaDon
		END

		delete from HoaDon where ID = @IDHoaDon
		
	END
END
go



CREATE TRIGGER TRIG_ID_TV ON THANHVIEN --Tự động đặt ID thành viên khi thêm vào
FOR INSERT
AS 
BEGIN
    DECLARE @PRE_ID NVARCHAR(5), @CUR_ID NVARCHAR(5)
	SELECT @CUR_ID=ID FROM INSERTED
	IF(SELECT COUNT(ID) FROM dbo.ThanhVien)=0
		BEGIN
			UPDATE dbo.ThanhVien
			SET ID='TV001'
			WHERE ID=@CUR_ID
		END
	ELSE
		BEGIN
			SELECT @PRE_ID = MAX(RIGHT(ID,3)) FROM dbo.ThanhVien
			SET @PRE_ID = @PRE_ID + 1
			DECLARE @TEMP_ID NVARCHAR(5) = FORMAT(CAST(@PRE_ID AS INT),'000')
			UPDATE dbo.ThanhVien
			SET ID =CONCAT('TV',@TEMP_ID)
			WHERE ID=@CUR_ID
		END
END
GO

CREATE TRIGGER TRIG_LTV_TV ON THANHVIEN --Tự động chuyển loại thành viên
FOR INSERT, UPDATE
AS 
BEGIN 
	DECLARE @LOAI_TV NVARCHAR(10), @TIEN_TL FLOAT, @ID VARCHAR(5)
	SELECT @LOAI_TV = LoaiThanhVien, @TIEN_TL = TienTichLuy, @ID = ID FROM INSERTED
	IF(@TIEN_TL>500000 AND @TIEN_TL<2000000)
		BEGIN
		    UPDATE dbo.ThanhVien SET LoaiThanhVien=N'Bạc'
			WHERE @ID = ID
		END
	ELSE IF (@TIEN_TL>2000000)
		BEGIN
		    UPDATE dbo.ThanhVien SET LoaiThanhVien=N'Vàng'
			WHERE @ID = ID
		END
END
GO

--AUTO ID CHO MAT HANG
CREATE TRIGGER TRIG_ID_MH ON MATHANG --Tự động đặt ID cho mặt hàng khi thêm vào kho
FOR INSERT
AS 
BEGIN
    DECLARE @PRE_ID NVARCHAR(5), @CUR_ID NVARCHAR(5), @LOAIMATHANG NVARCHAR(50)
	SELECT @CUR_ID=ID, @LOAIMATHANG=LoaiMatHang FROM INSERTED
	IF (@LOAIMATHANG=N'Đồ ăn')
		BEGIN
			IF (SELECT COUNT(ID) FROM dbo.MatHang WHERE LoaiMatHang=N'Đồ ăn')=0
				BEGIN	
					UPDATE dbo.MatHang
					SET ID='F001'
					WHERE ID=@CUR_ID
				END
			ELSE
				BEGIN
					SELECT @PRE_ID = MAX(RIGHT(ID,2)) FROM dbo.MatHang
					WHERE LoaiMatHang=N'Đồ ăn'
					SET @PRE_ID = @PRE_ID + 1
					DECLARE @TEMP_ID_1 NVARCHAR(5) = FORMAT(CAST(@PRE_ID AS INT),'000')
					UPDATE dbo.MatHang
					SET ID =CONCAT('F',@TEMP_ID_1)
					WHERE ID=@CUR_ID
				END
		END
	ELSE
		BEGIN
			IF (@LOAIMATHANG=N'Đồ uống')
				BEGIN
					IF (SELECT COUNT(ID) FROM dbo.MatHang WHERE LoaiMatHang=N'Đồ uống')=0
						BEGIN	
							UPDATE dbo.MatHang
							SET ID='D001'
							WHERE ID=@CUR_ID
						END
					ELSE
						BEGIN
							SELECT @PRE_ID = MAX(RIGHT(ID,2)) FROM dbo.MatHang
							WHERE LoaiMatHang=N'Đồ uống'
							SET @PRE_ID = @PRE_ID + 1
							DECLARE @TEMP_ID_2 NVARCHAR(5) = FORMAT(CAST(@PRE_ID AS INT),'000')
							UPDATE dbo.MatHang
							SET ID =CONCAT('D',@TEMP_ID_2)
							WHERE ID=@CUR_ID
						END
				END
			ELSE
				BEGIN
					IF (SELECT COUNT(ID) FROM dbo.MatHang WHERE LoaiMatHang=N'Khác')=0
						BEGIN	
							UPDATE dbo.MatHang
							SET ID='A001'
							WHERE ID=@CUR_ID
						END
					ELSE
						BEGIN
							SELECT @PRE_ID = MAX(RIGHT(ID,2)) FROM dbo.MatHang
							WHERE LoaiMatHang=N'Khác'
							SET @PRE_ID = @PRE_ID + 1
							DECLARE @TEMP_ID_3 NVARCHAR(5) = FORMAT(CAST(@PRE_ID AS INT),'000')
							UPDATE dbo.MatHang
							SET ID =CONCAT('A',@TEMP_ID_3)
							WHERE ID=@CUR_ID
						END
				END
		END  
END
GO


insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values
insert into Ban default values



-------------------------------------------------------Test

--declare @Type int, @ID varchar(5)
--declare @SDT varchar(100) = '0389878809'

--EXEC GetLoaiThanhVien @SDT = @SDT, @Type = @Type OUT, @ID = @ID OUT

--print @Type
--print @ID

--select * from ThanhVien
--use QuanLyQuanCafe




--select * from ThanhVien


--insert into Ban default values
--insert into Ban default values
--insert into Ban default values

--select * from ThongTinHoaDon
--select * from HoaDon

--select * from Ban
--select * from BanGopChung

--update HoaDon set NgayThanhToan='13/12/2023'
--where ID = 'HD001'

--delete from BanGopChung

--delete from Ban
--delete from ThongTinHoaDon
--delete from HoaDon



--SELECT  
--    name,
--    is_instead_of_trigger
--FROM 
--    sys.triggers  
--WHERE 
--    type = 'TR';

--set dateformat DMY

--SELECT * 
--  FROM QuanLyQuanCafe.INFORMATION_SCHEMA.ROUTINES
-- WHERE ROUTINE_TYPE = 'PROCEDURE'

-- SELECT * FROM sys.procedures

--select TenMatHang, DonViTinh, Gia, COUNT(SL) as SL
--from HoaDon, ThongTinHoaDon, MatHang 
--where HoaDon.ID = ThongTinHoaDon.IDHoaDon 
--and MatHang.ID = ThongTinHoaDon.IDMatHang 
--and NgayThanhToan >= '01/12/2023'
--group by TenMatHang, DonViTinh, Gia

--set dateformat dmy select CONVERT(varchar(7), NgayThanhToan, 120) as ThangThanhToan , SUM(ThanhTien) as DoanhThu from HoaDon
--group by CONVERT(varchar(7), NgayThanhToan, 120)
