use dbSoftQuanLyNhaHang
Go
--  drop procedure spInsertDangNhap

					/*-- BANG DANG NHAP -- */
					
/*-------------- Insert DangNhap -------------------------*/
create procedure spInsertDangNhap
(
			@IdDangNhap			varchar(100),
			@MatKhau			varchar(200),
			@TrangThai			bit
)
as
Begin
		insert into DangNhap(IdDangNhap, MatKhau, TrangThai)
		values(@IdDangNhap, @MatKhau, @TrangThai)
End
-- Gọi lại thủ tục:
/*
execute spInsertDangNhap				@IdDangNhap='anh1' ,
										@MatKhau ='123',
										@TrangThai= 1

*/

/*------------- Doi mat khau DangNhap ----------------*/
go
create procedure spUpdateDangNhap_MatKhau
(
			@IdDangNhap	varchar(100),
			@MatKhau		    varchar(250)				
)
as
Begin
		   update DangNhap set MatKhau=@MatKhau
		   where IdDangNhap = @IdDangNhap
End

/*---------------- Xoa DangNhap -------------------------*/
Go
create procedure spDeleteDangNhapByIdDangNhap
(
		 @IdDangNhap	varchar(100)							
)
as
Begin
		 delete from DangNhap 
		 where IdDangNhap =@IdDangNhap
End
/*----------- Tim kiem thong tin theo IdDangNhap ----------*/
Go
create procedure spgetDangNhapByIdDangNhap
(
		 @IdDangNhap	varchar(100)							
)
as
Begin
		 select IdDangNhap, MatKhau, TrangThai
		 from DangNhap
		 where IdDangNhap =@IdDangNhap
End
Go
/*--------- Hien thi thong tin DangNhap ----------------------*/ 
Go
create procedure spgetDangNhap
as
Begin
		 select IdDangNhap, MatKhau, TrangThai
		 from DangNhap		 
End
go
/*------------------ Kiem tra DangNhap -----------------------*/
create procedure spCheckDangNhap
(
		@IdDangNhap		varchar(100),
		@MatKhau		nvarchar(200)
)
	as
	Begin
				select	* from DangNhap dn
				where		dn.idDangNhap= @IdDangNhap
				and			dn.MatKhau=@MatKhau				
	End
Go
						/*-- BANG NHAN VIEN  -- */
						
/*------------- Hien thi thong tin NhanVien -------------------*/
create procedure spgetNhanVien
as
Begin
	select *from NhanVien
	--IdNhanVien as 'Id Nhân Viên ',HoLot + + Ten as ' Họ Tên ',Ngaysinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',DienThoai as 'Điện Thoại',Email,DiaChi as 'Địa chỉ' 
End
Go
-- drop procedure spgetNhanVien
/*----------- Hien thi thong tin NhanVien bang IdNhanVien --------------*/
create procedure spgetNhanVienByIdNhanVien
(
	@IdNhanVien varchar(10)
)
as
Begin
	select * from NhanVien where IdNhanVien =@IdNhanVien
End

Go

/*-------------- Insert NhanVien -----------------------------*/
create procedure spInsertNhanVien
( 
		@IdNhanVien			varchar(10),
		@HoLot				nvarchar(100),
		@Ten				nvarchar(100),
		@Ngaysinh			datetime,
		@GioiTinh			nvarchar(10),
		@DienThoai			varchar(15),
		@Email				varchar(100),
		@DiaChi				nvarchar(100)  
)
as
Begin
	insert into NhanVien(IdNhanVien, HoLot, Ten, Ngaysinh, GioiTinh, DienThoai,Email,DiaChi)
	values(@IdNhanVien, @HoLot, @Ten, @Ngaysinh, @GioiTinh, @DienThoai,@Email,@DiaChi)
End
Go
/*------------------- Update NhanVien -----------------------*/
create procedure spUpdateNhanVien
(
		@IdNhanVien			varchar(10),
		@HoLot				nvarchar(100),
		@Ten				nvarchar(100),
		@Ngaysinh			datetime,
		@GioiTinh			nvarchar(10),
		@DienThoai			varchar(15),
		@Email				varchar(100),
		@DiaChi				nvarchar(100)  	 
)
as
Begin
	update NhanVien set 
						HoLot = @HoLot,
						Ten =@Ten,
						Ngaysinh =@Ngaysinh,
						GioiTinh =@GioiTinh,
						DienThoai =@DienThoai,
						Email	=@Email,
						DiaChi	=@DiaChi
											 
		where IdNhanVien =@IdNhanVien
End
Go
/*--------------- Delete NhanVien ---------------------*/
create procedure spDeleteNhanVien
(
	@idNhanVien varchar (10)
)
as
Begin
	delete from NhanVien where IdNhanVien=@idNhanVien
End
go

/*--------------TIM KIEM NHAN VIEN THEO IDNHANVIEN -----------*/
create procedure spSearchNVByIdNV
(
	@IdNhanVien varchar (10)
)
as
Begin
	select *from NhanVien where IdNhanVien like  '%'+@IdNhanVien+'%'
End 
Go

--drop  procedure spSearchNVByIdNV

/*--------------TIM KIEM NHAN VIEN THEO TEN -----------*/
create procedure spSearchNVByTenNV
(
	@Ten			nvarchar(100)
)
as
Begin
	select *from NhanVien where Ten like  N'%'+@Ten+'%'
End 
Go
--drop  procedure spSearchNVByTenNV

						/*-- BANG KHACH HANG -- */
						
/*--------- Hien thi thong tin KhachHang ----------------*/
create procedure spgetKhachHang
as
Begin
	select IdKhachHang, TenKhachHang,  DienThoai, Email,DiaChi
	from Khachhang
End
go
/*----------- Hien thi thong tin KhachHang bang IdKhachHang --------------*/
create procedure spgetKhachHangByIdKhachHang
(
	@IdKhachHang		varchar (10)
)
as
begin
	select * from Khachhang where IdKhachHang = @IdKhachHang
end
go
/*---------------- Insert KhachHang -------------------*/
create procedure spInsertKhachHang
( 
		@IdKhachHang			varchar(10),
		@TenKhachHang			nvarchar(100),
		@DienThoai				varchar(15),
		@Email					varchar(100),
		@DiaChi					nvarchar(100)
)
as
Begin
	insert into KhachHang(IdKhachHang, TenKhachHang, DienThoai, Email, DiaChi)
	values(@IdKhachHang, @TenKhachHang, @DienThoai, @Email, @DiaChi)
End
Go


-- DROP PROCEDURE spgetKhachhang
/*---------------- Update KhachHang -----------------*/
create procedure spUpdateKhachHang
(
		@IdKhachHang			varchar(10),
		@TenKhachHang			nvarchar(100),
		@DienThoai				varchar(15),
		@Email					varchar(100),
		@DiaChi					nvarchar(100)
)
as
Begin
	update Khachhang set 
						TenKhachHang = @TenKhachHang,
						DienThoai =@DienThoai,
						Email	=@Email,
						DiaChi	=@DiaChi
											 
		where IdKhachHang =@IdKhachHang
End
Go
/*-------------------- Delete KhachHang -------------------*/
create procedure spDeleteKhachHang
(
	@IdKhachHang		varchar(10)
)
as
begin
	delete Khachhang where IdKhachHang = @IdKhachHang
end
go

						/*----------- BANG LOAITHUCDON --------------*/
						
/*--------- Hien thi thong tin LoaiThucDon ----------------*/
create procedure spgetLoaiThucDon
as
Begin
	select * from LoaiThucDon
End
Go
/*----------- Hien thi thong tin LoaiThucDon bang IdLoaiThucDon --------------*/
create procedure spgetLoaiThucDonByIdLoaiThucDon
(
	@IdLoaiThucDon			varchar (5)
)
as
begin
	select * from LoaiThucDon where IdLoaiThucDon = @IdLoaiThucDon
end
go
-- drop proc spgetLoaiThucDonByIdLoaiThucDon
/*---------------- Insert LoaiThucDon -------------------*/
create procedure spInsertLoaiThucDon
( 
		@IdLoaiThucDon			varchar (5),
		@TenLoaiThucDon			nvarchar(100),
		@DienGiai				nvarchar(100),
		@TrangThai				nvarchar(30)
)
as
Begin
	insert into LoaiThucDon(IdLoaiThucDon,TenLoaiThucDon,DienGiai,TrangThai)
	values(@IdLoaiThucDon,@TenLoaiThucDon,@DienGiai,@TrangThai)
End
Go

-- DROP PROCEDURE spInsertLoaiThucDon
/*---------------- Update LoaiThucDon -----------------*/
create procedure spUpdateLoaiThucDon
(
		@IdLoaiThucDon			varchar (5),
		@TenLoaiThucDon			nvarchar(100),
		@DienGiai				nvarchar(100),
		@TrangThai				nvarchar(30)
)
as
Begin
	update LoaiThucDon set 
						TenLoaiThucDon=@TenLoaiThucDon,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai						 
		where IdLoaiThucDon =@IdLoaiThucDon
End
Go
-- drop procedure spUpdateLoaiThucDon
/*-------------------- Delete LoaiThucDon -------------------*/
create procedure spDeleteLoaiThucDon
(
	@IdLoaiThucDon			varchar (5)
)
as
begin
	delete LoaiThucDon where IdLoaiThucDon = @IdLoaiThucDon
end
go
/* ----------------------- Get TenLoaiThucDon ----------------*/
create procedure spgetTenLoaiThucDon
as
begin
	select TenLoaiThucDon from LoaiThucDon
end
go
--   drop proc spgetTenLoaiThucDon
-- drop procedure spgetTenLoaiThucDonByIdThucDon


							/*-- BANG THUC DON -- */
							
/*--------- Hien thi thong tin ThucDon ----------------*/
create procedure spgetThucDon
as
Begin
	select IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TonToiThieu,TrangThai	
	from ThucDon
End
Go
-- drop proc spgetThucDon

/*--------- Hien thi thong tin ThucDon NOT TonToiThieu ----------------*/
create procedure spgetThucDonNotTTT
as
Begin
	select IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TrangThai	
	from ThucDon
End
Go
-- drop proc spgetThucDonNotTTT
/*----------- Hien thi thong tin ThucDon bang IdThucDon --------------*/
create procedure spgetThucDonByIdThucDon
(
	@IdThucDon		varchar (5)
)
as
begin
	select * from ThucDon where IdThucDon = @IdThucDon
end
go
/*---------------- Insert ThucDon -------------------*/
create procedure spInsertThucDon
( 
		@IdThucDon			varchar(5) ,
		@TenLoaiThucDon		nvarchar(100),
		@TenThucDon			nvarchar(100),
		@DonViTinh			nvarchar(10),
		@SoLuongTon			float,
		@DonGiaTon			float,
		@TonToiThieu		float,
		@TrangThai			nvarchar(30)
)
as
Begin
	insert into ThucDon(IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TonToiThieu,TrangThai)
	values(@IdThucDon,@TenLoaiThucDon,@TenThucDon,@DonViTinh,@SoLuongTon,@DonGiaTon,@TonToiThieu,@TrangThai)
End
Go

-- DROP PROCEDURE spgetThucDon
/*---------------- Update ThucDon -----------------*/
create procedure spUpdateThucDon
(
		@IdThucDon			varchar(5) ,
		@TenLoaiThucDon		nvarchar(100),
		@TenThucDon			nvarchar(100),
		@DonViTinh			nvarchar(10),
		@SoLuongTon			float,
		@DonGiaTon			float,
		@TonToiThieu		float,
		@TrangThai			nvarchar(30)
)
as
Begin
	update ThucDon set 
						TenLoaiThucDon=@TenLoaiThucDon,
						TenThucDon=@TenThucDon,
						DonViTinh=@DonViTinh,
						SoLuongTon=@SoLuongTon,
						DonGiaTon=@DonGiaTon,
						TonToiThieu=@TonToiThieu,
						TrangThai=@TrangThai
											 
		where IdThucDon =@IdThucDon
End
Go
----   drop proc spUpdateThucDon
/*-------------------- Delete ThucDon -------------------*/
create procedure spDeleteThucDon
(
	@IdThucDon		varchar (5)
)
as
begin
	delete ThucDon where IdThucDon = @IdThucDon
end
go
/*-------------------- get DonGiaTon tu TenThucDon -------------------*/
create procedure spgetDonGiaByTenThucDon
(
	@TenThucDon			nvarchar(100)
)
as
begin
	select DonGiaTon as 'Đơn giá' from ThucDon where TenThucDon=@TenThucDon
end
							/*--- BANG KHU VUC ---*/
go
							
/*--------- Hien thi thong tin KhuVuc ----------------*/
create procedure spgetKhuVuc
as
Begin
	select * from KhuVuc
End
Go
/*----------- Hien thi thong tin KhuVuc bang IdKhuVuc --------------*/
create proc spgetKhuVucByIdKhuVuc
(
	@IdKhuVuc		varchar (5)
)
as
begin
	select * from KhuVuc where IdKhuVuc = @IdKhuVuc
end
go
-- drop proc spgetKhuVucByIdKhuVuc
/*---------------- Insert KhuVuc -------------------*/
create procedure spInsertKhuVuc
( 
		@IdKhuVuc			varchar (5),
		@TenKhuVuc			nvarchar(100),
		@DienGiai			nvarchar(100),
		@TrangThai			nvarchar(30)
)
as
Begin
	insert into KhuVuc(IdKhuVuc, TenKhuVuc, DienGiai, TrangThai)
	values(@IdKhuVuc, @TenKhuVuc, @DienGiai, @TrangThai)
End
Go

-- DROP PROCEDURE spInsertKhuVuc
/*---------------- Update KhuVuc -----------------*/
create procedure spUpdateKhuVuc
(
		@IdKhuVuc			varchar (5) ,
		@TenKhuVuc			nvarchar(100),
		@DienGiai			nvarchar(100),
		@TrangThai			nvarchar(30)
)
as
Begin
	update KhuVuc set 
						TenKhuVuc=@TenKhuVuc,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai						 
		where IdKhuVuc =@IdKhuVuc
End
Go
-- drop procedure spUpdateKhuVuc
/*-------------------- Delete KhuVuc -------------------*/
create procedure spDeleteKhuVuc
(
	@IdKhuVuc		varchar(5)
)
as
begin
	delete KhuVuc where IdKhuVuc = @IdKhuVuc
end
-- drop procedure spDeleteKhuVuc
go

						/*----------- BANG BAN --------------*/
						
/*--------- Hien thi thong tin Ban ----------------*/
create procedure spgetBan
as
Begin
	select IdBan,TenBan,TenKhuVuc,DienGiai,TrangThai from Ban
End
Go
--drop  procedure spgetBan
/*----------- Hien thi thong tin Ban bang IdBan --------------*/
create procedure spgetBanByIdBan
(
	@IdBan	varchar (5)
)
as
begin
	select * from Ban where IdBan = @IdBan
end
go
-- drop proc spgetBanByIdBan
/*---------------- Insert Ban -------------------*/
create procedure spInsertBan
( 
		@IdBan			varchar (5) ,
		@TenKhuVuc		nvarchar(100) ,
		@TenBan			nvarchar(100),
		@DienGiai		nvarchar(100),
		@TrangThai		nvarchar(30)
)
as
Begin
	insert into Ban(IdBan,TenKhuVuc, TenBan, DienGiai, TrangThai)
	values(@IdBan,@TenKhuVuc,@TenBan,@DienGiai,@TrangThai)
End
Go

-- DROP PROCEDURE spInsertBan
/*---------------- Update Ban -----------------*/
create procedure spUpdateBan
(
		@IdBan			varchar (5) ,
		@TenKhuVuc		nvarchar(100) ,
		@TenBan			nvarchar(100),
		@DienGiai		nvarchar(100),
		@TrangThai		nvarchar(30)
)
as
Begin
	update Ban set		
						
						TenKhuVuc = @TenKhuVuc,
						TenBan=@TenBan,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai						 
		where IdBan=@IdBan
End
Go
-- drop procedure spUpdateBan
/*-------------------- Delete Ban -------------------*/
create procedure spDeleteBan
(
	@IdBan		varchar(5)
)
as
begin
	delete Ban where IdBan = @IdBan
end
go
/*-------------------- get TenBan  -------------------*/
create procedure spgetTenBan
as
begin
	select TenBan from Ban
end
go
-- drop procedure spDeleteBan
/* ----------------------- Get TenKhuVuc ------------------- */
create procedure spgetTenKhuVuc
as
begin
	select TenKhuVuc from KhuVuc
end
go

/*-------------------- get TenThucDon -------------------*/
create procedure spgetTenThucDon
as
begin
	select TenThucDon from ThucDon
end
go
/*-------------------- get DanhSachBan_GoiMon -------------------*/
create procedure spgetDanhSachBan_GoiMon
as
begin
	select  DISTINCT b.IdBan as 'Id Bàn' , TenBan as 'Tên Bàn',  TenKhuVuc as 'Tên Khu Vực',DienGiai as 'Diễn Giải'
	from Ban b,GoiMon gm
	where b.IdBan = gm.IdBan
	ORDER BY b.IdBan
end
go
-- drop proc spgetDanhSachBan_GoiMon

/*-------------------- get DanhSachBan_ChuaGoiMon -------------------*/
create procedure spgetDanhSachBan_ChuaGoiMon
as
begin
	select  distinct IdBan as 'Id Bàn',TenBan as 'Tên Bàn',TenKhuVuc as 'Tên Khu Vực',DienGiai as 'Diễn Giải'
	from Ban where IdBan not in (select IdBan from GoiMon)
	ORDER BY IdBan,TenBan,TenKhuVuc,DienGiai
end
-- drop proc spgetDanhSachBan_ChuaGoiMon

go
						/*----- BANG GOIMON-----*/

/*--------- Hien thi thong tin GoiMon ----------------*/
create procedure spgetGoiMon
as
Begin
	select IdBan,TenThucDon,DonGiaTon,SoLuong,ThoiGian,(SoLuong*DonGiaTon)as ThanhTien
	from GoiMon
	ORDER BY IdBan
End
Go
-- drop procedure spgetGoiMon
/*----------- Hien thi thong tin GoiMon bang IdBan --------------*/
create procedure spgetGoiMonByIdBan
(
	@IdBan	varchar (5)
)
as
begin
	select  IdBan as 'Id Bàn', TenThucDon as 'Tên Thực Đơn',DonGiaTon as 'Đơn Giá',SoLuong as 'Số Lượng ',ThoiGian as 'Thời Gian',(SoLuong*DonGiaTon)as 'Thành Tiền'
	from GoiMon where IdBan = @IdBan
end
go
-- drop proc spgetGoiMonByIdBan
/*---------------- Insert GoiMon -------------------*/
create procedure spInsertGoiMon
( 
		@IdBan				varchar (5),
		@TenThucDon			nvarchar(100),
		@DonGiaTon			decimal ,
		@SoLuong			int,
		@ThoiGian			datetime,
		@ThanhTien			decimal
)
as
Begin
	insert into GoiMon(IdBan,TenThucDon, DonGiaTon, SoLuong, ThoiGian,ThanhTien)
	values(@IdBan,@TenThucDon, @DonGiaTon, @SoLuong, @ThoiGian,@ThanhTien )
End
Go

-- DROP PROCEDURE spInsertGoiMon
/*---------------- Update GoiMon -----------------*/
create procedure spUpdateGoiMon
(		
		@IdBan				varchar (5),
		@TenThucDon			nvarchar(100),
		@DonGiaTon			decimal ,
		@SoLuong			int,
		@ThoiGian			datetime,
		@ThanhTien			decimal
)
as
Begin
	update GoiMon set	
						TenThucDon = @TenThucDon,
						DonGiaTon=@DonGiaTon,
						SoLuong=@SoLuong,
						ThoiGian=@ThoiGian,
						ThanhTien=@ThanhTien
	where IdBan = @IdBan			 
End
Go
-- drop procedure spUpdateGoiMon
/*-------------------- Delete GoiMon -------------------*/
create procedure spDeleteGoiMon
(
	@IdBan				varchar (5)
)
as
begin
	Delete GoiMon where IdBan = @IdBan
end
go




/*---------- TRIGER RANG BUOC SO LUONG THUC DON ---------- */

create trigger trigger_Valid_insertUpdateGoiMon
on GoiMon FOR INSERT
as
begin
	if update (SoLuong)
	begin
		declare @SoLuongBan int 
		declare @SoLuongCon int
		declare @TenThucDon nvarchar(100)
		select @SoLuongBan = SoLuong,@TenThucDon = TenThucDon  from INSERTED
		select @SoLuongCon= SoLuongTon from ThucDon 
			where TenThucDon = @TenThucDon 
			if((@SoLuongCon-@SoLuongBan)<0)
			begin
				PRINT ('So Luong Thuc Don Khong Du!')
				rollback transaction
			end
			else 
				update ThucDon set SoLuongTon = @SoLuongCon -  @SoLuongBan 
					where TenThucDon = @TenThucDon 
	end			
end
go
-- drop trigger  trigger_Valid_insertUpdateGoiMon


						/*----- BANG PHANQUYEN-----*/

/*--------- Hien thi thong tin PHANQUYEN ----------------*/
create procedure spgetPhanQuyen
as
Begin
	select pq.IdTaiKhoan as 'Id Tài Khoản',MatKhau as 'Mật Khẩu',nv.IdNhanVien as 'Id Nhân Viên',HoLot + + Ten as 'Họ Tên'
	from PhanQuyen pq,NhanVien nv
	where pq.IdNhanVien = nv.IdNhanVien
End
Go
-- drop procedure spgetPhanQuyen
/*----------- Hien thi thong tin spgetPhanQuyenByIdTaiKhoan --------------*/
create procedure spgetPhanQuyenByIdTaiKhoan
(
	@IdTaiKhoan	varchar (10)
)
as
begin
	select pq.IdTaiKhoan,MatKhau,nv.IdNhanVien,HoLot + + Ten as 'Họ Tên'
	from PhanQuyen pq,NhanVien nv
	where IdTaiKhoan = @IdTaiKhoan
end
go
 --drop proc spgetPhanQuyenByIdTaiKhoan
/*---------------- Insert PHANQUYEN -------------------*/
create procedure spInsertPhanQuyen
( 
		@IdTaiKhoan			varchar (10),
		@MatKhau				varchar(200),
		@IdNhanVien			varchar(10)
)
as
Begin
	insert into PhanQuyen
	values(@IdTaiKhoan,@MatKhau,@IdNhanVien )
End
Go

-- DROP PROCEDURE spInsertPhanQuyen
/*---------------- Update PHANQUYEN -----------------*/
create procedure spUpdatePhanQuyen
(		
		@IdTaiKhoan			varchar (10),
		@MatKhau			varchar(200),
		@IdNhanVien			varchar(10)
)
as
Begin
	update PhanQuyen set	
						MatKhau = @MatKhau,
						IdNhanVien=@IdNhanVien
	where IdTaiKhoan = @IdTaiKhoan	 
End
Go
-- drop procedure spUpdatePhanQuyen
/*-------------------- Delete PHANQUYEN -------------------*/
create procedure spDeletePhanQuyen
(
	@IdTaiKhoan			varchar (10)
)
as
begin
	Delete PhanQuyen where IdTaiKhoan = @IdTaiKhoan	 
end
go
-- drop proc spDeletePhanQuyen