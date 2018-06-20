
	Use dbSoftQuanLyNhaHang
	Go

-- Bảng : NHÂN VIÊN
	Go
		Create function fcgetIdNhanVien()
		returns varchar(10)
		
		
		As
		Begin
			Declare @IdNhanVien varchar(10)
			Declare @MaxIdNhanVien varchar(10)
			Declare @Max float
			
			
			Select @MaxIdNhanVien = MAX(IdNhanVien) from NhanVien
			
			if exists (select IdNhanVien from NhanVien)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdNhanVien,3,8)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdNhanVien='NV' + '0000000' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @IdNhanVien='NV' + '000000' + Convert(varchar(2),@Max)
			else
			if (@Max < 1000)
						set @IdNhanVien='NV' + '00000' + Convert(varchar(3),@Max)
			else
			if (@Max < 10000)
						set @IdNhanVien='NV' + '0000' + Convert(varchar(4),@Max)
			else
			if (@Max < 100000)
						set @IdNhanVien ='NV' + '000' + Convert(varchar(5),@Max)
			else
			if (@Max < 1000000)
						set @IdNhanVien  ='NV' + '00' + Convert(varchar(6),@Max)
			else	
			if (@Max < 10000000)
						set @IdNhanVien ='NV' + '0' + Convert(varchar(7),@Max)
			else
						set @IdNhanVien ='NV' +  Convert(varchar(8),@Max)
			Return @IdNhanVien
	End
	Go
	-- select IdNhanVien=dbo.fcgetIdNhanVien()
 ---- BANG KHACHHANG ----------------
 Go
		Create function fcgetIdKhachHang()
		returns varchar(10)
		
		
		As
		Begin
			Declare @IdKhachHang varchar(10)
			Declare @MaxIdKhachHang varchar(10)
			Declare @Max float
			
			
			Select @MaxIdKhachHang = MAX(IdKhachHang) from KhachHang
			
			if exists (select IdKhachHang from KhachHang)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdKhachHang,3,8)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdKhachHang='KH' + '0000000' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @IdKhachHang='KH' + '000000' + Convert(varchar(2),@Max)
			else
			if (@Max < 1000)
						set @IdKhachHang='KH' + '00000' + Convert(varchar(3),@Max)
			else
			if (@Max < 10000)
						set @IdKhachHang='KH' + '0000' + Convert(varchar(4),@Max)
			else
			if (@Max < 100000)
						set @IdKhachHang ='KH' + '000' + Convert(varchar(5),@Max)
			else
			if (@Max < 1000000)
						set @IdKhachHang  ='KH' + '00' + Convert(varchar(6),@Max)
			else	
			if (@Max < 10000000)
						set @IdKhachHang ='KH' + '0' + Convert(varchar(7),@Max)
			else
						set @IdKhachHang ='KH' +  Convert(varchar(8),@Max)
			Return @IdKhachHang
	End
	Go
	-- select IdKhachHang=dbo.fcgetIdKhachHang()
	
	/*--------------- BANG KHU VUC ------------*/
	
	Create function fcgetIdkhuVuc()
		returns varchar(5)
		
		
		As
		Begin
			Declare @IdKhuVuc varchar(5)
			Declare @MaxIdKhuVuc varchar(5)
			Declare @Max float
			
			
			Select @MaxIdKhuVuc = MAX(IdKhuVuc) from KhuVuc
			
			if exists (select IdKhuVuc from KhuVuc)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdKhuVuc,3,3)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdKhuVuc='KV' + '00' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @IdKhuVuc='KV' + '0' + Convert(varchar(2),@Max)
			else
						set @IdKhuVuc ='KV' +  Convert(varchar(3),@Max)
			Return @IdKhuVuc
	End
	Go
	-- select IdKhachHang=dbo.fcgetIdKhuVuc()
	
					/*-------- BANG BAN ---------*/

	
	Create function fcgetIdBan()
		returns varchar(5)
		
		
		As
		Begin
			Declare @IdBan varchar(5)
			Declare @MaxIdBan varchar(5)
			Declare @Max float
			
			
			Select @MaxIdBan = MAX(IdBan) from Ban
			
			if exists (select IdBan from Ban)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdBan,4,2)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdBan='BAN' + '0' + Convert(varchar(1),@Max)
			else
						set @IdBan ='BAN' +  Convert(varchar(3),@Max)
			Return @IdBan
	End
	Go
	-- select IdBan=dbo.fcgetIdBan()
	
			/*----- BANG LOAITHUCDON ----------*/
			
		Create function fcgetIdLoaiThucDon()
		returns varchar(5)
		
		
		As
		Begin
			Declare @IdLoaiThucDon		varchar(5)
			Declare @MaxIdLoaiThucDon	varchar(5)
			Declare @Max float
			
			
			Select @MaxIdLoaiThucDon = MAX(IdLoaiThucDon) from LoaiThucDon
			
			if exists (select IdLoaiThucDon from LoaiThucDon)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdLoaiThucDon,4,2)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdLoaiThucDon='LTD' + '0' + Convert(varchar(1),@Max)
			else
						set @IdLoaiThucDon ='LTD' +  Convert(varchar(3),@Max)
			Return @IdLoaiThucDon
	End
	Go
	-- select IdLoaiThucDon=dbo.fcgetIdLoaiThucDon()
	
	
			/*----- BANG THUCDON ----------*/
			
		Create function fcgetIdThucDon()
		returns varchar(5)
		
		
		As
		Begin
			Declare @IdThucDon		varchar(5)
			Declare @MaxIdThucDon	varchar(5)
			Declare @Max float
			
			
			Select @MaxIdThucDon = MAX(IdThucDon) from ThucDon
			
			if exists (select IdThucDon from ThucDon)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdThucDon,3,3)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdThucDon='TD' + '00' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @IdThucDon='TD' + '0' + Convert(varchar(2),@Max)
			else
						set @IdThucDon ='TD' +  Convert(varchar(3),@Max)
			Return @IdThucDon
	End
	Go
	-- select IdThucDon=dbo.fcgetIdThucDon()