create table Khoa
(
	ma	varchar(10),
	tenKhoa		nvarchar(100),
	namThanhLap	int,
	constraint PK_Khoa_ma primary key(ma)
)

create table MonHoc
(
	ma	varchar(10),
	tenMonHoc	nvarchar(100),
	maKhoa	varchar(10),
	constraint PK_MonHoc_ma primary key(ma),
	constraint FK_MonHoc_Khoa_maKhoa_ma foreign key(maKhoa) references Khoa(ma)
)

create table KhoaHoc
(
	ma	varchar(10),
	namBatDau	int,
	namKetThuc	int,
	constraint PK_KhoaHoc_ma primary key(ma)
)

create table ChuongTrinh
(
	ma	varchar(10),
	tenChuongTrinh	 nvarchar(100),
	constraint PK_ChuongTrinh_ma primary key(ma)
)

create table Lop
(
	ma	varchar(10),
	maKhoaHoc	 varchar(10),
	maKhoa	varchar(10),
	maChuongTrinh	varchar(10),
	soThuTu	int,
	constraint PK_Lop_ma primary key(ma),
	constraint FK_Lop_Khoa_maKhoa_ma foreign key(maKhoa) references Khoa(ma),
	constraint FK_Lop_KhoaHoc_maKhoaHoc_ma foreign key(maKhoaHoc) references KhoaHoc(ma),
	constraint FK_Lop_ChuongTrinh_maChuongTrinh_ma foreign key(maChuongTrinh) references ChuongTrinh(ma)
)

create table SinhVien
(
	ma	varchar(10),
	hoTen	nvarchar(100),
	namSinh	int,
	danToc	nvarchar(20),
	maLop	varchar(10),
	constraint PK_SinhVien_ma primary key(ma),
	constraint FK_SinhVien_Lop_maLop_ma foreign key(maLop) references Lop(ma)
)

create table KetQua
(
	maSinhVien	varchar(10),
	maMonHoc	varchar(10),
	lanThi	int,
	diem	float,
	constraint PK_KetQua_maSinhVien_maMonHoc_lanThi primary key(maSinhVien, maMonHoc, lanThi),
	constraint FK_KetQua_SinhVien_maSinhVien_ma foreign key(maSinhVien) references SinhVien(ma),
	constraint FK_KetQua_MonHoc_maMonHoc_ma foreign key(maMonHoc) references MonHoc(ma)
)

create table GiangKhoa
(
	maChuongTrinh	varchar(10),
	maKhoa	varchar(10),
	maMonHoc	varchar(10),
	namHoc	int,
	hocKy	int,
	soTietLyThuyet	int,
	soTietThucHanh	int,
	soTinChi	int,
	constraint PK_GiangKhoa_maChuongTrinh_maKhoa_maMonHoc primary key(maChuongTrinh, maKhoa, maMonHoc),
	constraint FK_GiangKhoa_ChuongTrinh_maChuongTrinh_ma foreign key(maChuongTrinh) references ChuongTrinh(ma),
	constraint FK_GiangKhoa_Khoa_maKhoa_ma foreign key(maKhoa) references Khoa(ma),
	constraint FK_GiangKhoa_MonHoc_maMonHoc_ma foreign key(maMonHoc) references MonHoc(ma)
)

create table XepLoai
(
	maSinhVien varchar(10),
	diemTrungBinh float,
	ketQua	nvarchar(30),
	hocLuc	nvarchar(30),
	constraint PK_XepLoai_maSinhVien primary key(maSinhVien),
	constraint FK_XepLoai_SinhVien_maSinhVien_ma foreign key(maSinhVien) references SinhVien(ma)
)


insert into Khoa values('CNTT', N'Công nghệ thông tin', 1995)
insert into Khoa values('VL', N'Vật lý', 1970)

insert into KhoaHoc values('K2002', 2002, 2006)
insert into KhoaHoc values('K2003', 2003, 2007)
insert into KhoaHoc values('K2004', 2004, 2008)

insert into ChuongTrinh values('CQ', N'Chính Qui')

insert into Lop values('TH2002/01', 'K2002', 'CNTT', 'CQ', 1)
insert into Lop values('TH2002/02', 'K2002', 'CNTT', 'CQ', 2)
insert into Lop values('TH2003/01', 'K2003', 'VL', 'CQ', 1)

insert into SinhVien values('0212001', N'Nguyễn Vĩnh An', 1984, N'Kinh', 'TH2002/01')
insert into SinhVien values('0212002', N'Nguyễn Thanh Bình', 1985, N'Kinh', 'TH2002/01')
insert into SinhVien values('0212003', N'Nguyễn Thanh Cường', 1984, N'Kinh', 'TH2002/02')
insert into SinhVien values('0212004', N'Nguyễn Quốc Duy', 1983, N'Kinh', 'TH2002/02')
insert into SinhVien values('0311001', N'Phan Tuấn Anh', 1985, N'Kinh', 'VL2003/01')
insert into SinhVien values('0311002', N'Huỳnh Thanh Sang', 1984, N'Kinh', 'VL2003/01')

insert into MonHoc values('THT01', N'Toán cao cấp A1', 'CNTT')
insert into MonHoc values('VLT01', N'Toán cao cấp A1', 'VL')
insert into MonHoc values('THT02', N'Toán rời rạc', 'CNTT')
insert into MonHoc values('THCS01', N'Cấu trúc dữ liệu 1', 'CNTT')
insert into MonHoc values('THCS02', N'Hệ điều hành', 'CNTT')

insert into KetQua values('0212001', 'THT01', 1, 4)
insert into KetQua values('0212001', 'THT01', 2, 7)
insert into KetQua values('0212002', 'THT01', 1, 8)
insert into KetQua values('0212003', 'THT01', 1, 6)
insert into KetQua values('0212004', 'THT01', 1, 9)
insert into KetQua values('0212001', 'THT02', 1, 8)
insert into KetQua values('0212002', 'THT02', 1, 5.5)
insert into KetQua values('0212003', 'THT02', 1, 4)
insert into KetQua values('0212003', 'THT02', 2, 6)
insert into KetQua values('0212001', 'THCS01', 1, 6.5)
insert into KetQua values('0212002', 'THCS01', 1, 4)
insert into KetQua values('0212003', 'THCS01', 1, 7)

insert into GiangKhoa values('CQ', 'CNTT', 'THT01', 2003, 1, 60, 0, 5)
insert into GiangKhoa values('CQ', 'CNTT', 'THT02', 2003, 2, 45, 0, 4)
insert into GiangKhoa values('CQ', 'CNTT', 'THCS01', 2004, 1, 45, 30, 4)

-- Procedure
-- Câu 6.1
create proc Cau_6_1
	@maLop varchar(10)
as
begin
	select * from SinhVien where maLop like @maLop
end
go
-- Câu 6.2
create proc Cau_6_2
	@maSinhVien1 varchar(10), @maSinhVien2 varchar(10), @maMonHoc varchar(10)
as
begin
	if @maSinhVien1 like @maSinhVien2
		print N'Mã sinh viên trùng nhau'
	else
	begin
		declare @diem1 float, @diem2 float
		set @diem1 = -1
		set @diem2 = -1
		select @diem1 = diem from KetQua where maSinhVien like @maSinhVien1 
										   and maMonHoc like @maMonHoc
										   and lanThi = 1
		if @diem1 = -1
		begin
			print N'Sinh vien ' + @maSinhVien1 + N' chưa thi môn ' + @maMonHoc
			return
		end

		select @diem2 = diem from KetQua where maSinhVien like @maSinhVien2 
										   and maMonHoc like @maMonHoc
										   and lanThi = 1
		if @diem2 = -1
		begin
			print N'Sinh vien ' + @maSinhVien2 + N' chưa thi môn ' + @maMonHoc
			return
		end

		if @diem1 = @diem2
			print N'Cả hai bằng điểm'
		else if @diem1 > @diem2
			print N'Sinh viên ' + @maSinhVien1 + N' có điểm cao hơn'
		else
			print N'Sinh viên ' + @maSinhVien2 + N' có điểm cao hơn'
	end
end
go

-- Câu 6.3
create proc Cau_6_3
	@maMonHoc varchar(10), @maSinhVien varchar(10)
as
begin
	declare @diem float
	set @diem = -1
	select @diem = diem from KetQua where maSinhVien like @maSinhVien 
										   and maMonHoc like @maMonHoc
										   and lanThi = 1
	if @diem = -1
	begin
		print N'Sinh vien ' + @maSinhVien + N' chưa thi môn ' + @maMonHoc
		return
	end

	if @diem >= 5
		print N'Đậu'
	else
		print N'Không Đậu'
end
go

-- Câu 6.4
create proc Cau_6_4
	@maKhoa varchar(10)
as
begin
	select SV.ma, SV.hoTen, SV.namSinh
	from SinhVien SV, Lop L
	where L.maKhoa like @maKhoa and L.ma like SV.maLop
end
go

-- Câu 6.5
create proc Cau_6_5
	@maSinhVien varchar(10), @maMonHoc varchar(10)
as
begin
	declare @cur_KetQua cursor, @diem float, @lan int
	set @lan = 0
	set @cur_KetQua = cursor for select diem from KetQua 
								 where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc
	open @cur_KetQua
	fetch next from @cur_KetQua into @diem
	while @@fetch_status = 0
	begin
		set @lan = @lan + 1
		print N'Lần ' + cast(@lan as varchar(10)) + ' : ' + cast(@diem as varchar(10))
		fetch next from @cur_KetQua into @diem
	end
	close @cur_KetQua
	deallocate @cur_KetQua
end
go

-- Câu 6.6
create proc Cau_6_6
	@maSinhVien varchar(10)
as
begin
	select MH.ma, MH.tenMonHoc
	from MonHoc MH, Lop L, SinhVien SV
	where SV.ma like @maSinhVien and SV.maLop like L.ma
		and L.maKhoa like MH.maKhoa
end
go

-- Câu 6.7
create proc Cau_6_7
	@maMonHoc varchar(10)
as
begin
	select KQ.maMonHoc, SV.ma as maSinhVien, SV.hoTen
	from SinhVien SV, KetQua KQ
	where SV.ma like KQ.maSinhVien and KQ.maMonHoc like @maMonHoc and KQ.lanThi = 1
end
go

-- Câu 6.8
-- 6.8.1
create proc Cau_6_8_1
	@maSinhVien varchar(10)
as
begin
	declare @cur_maMonHoc cursor, @maMonHoc varchar(10), @diem float
	set @cur_maMonHoc = cursor for select MH.ma from SinhVien SV, Lop L, MonHoc MH
								where SV.ma like @maSinhVien and SV.maLop like L.ma
									and L.maKhoa like MH.maKhoa
	open @cur_maMonHoc
	fetch next from @cur_maMonHoc into @maMonHoc
	while @@fetch_status = 0
	begin
		set @diem = -1
		select top 1 @diem = diem from KetQua where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc
											order by lanThi DESC

		if @diem != -1
			print @maMonHoc + '	' + cast(@diem as varchar(10))

		fetch next from @cur_maMonHoc into @maMonHoc
	end
	close @cur_maMonHoc
	deallocate @cur_maMonHoc
end
go

-- 6.8.2
create proc Cau_6_8_2
	@maSinhVien varchar(10)
as
begin
	declare @cur_maMonHoc cursor, @maMonHoc varchar(10), @diem float
	set @cur_maMonHoc = cursor for select MH.ma from SinhVien SV, Lop L, MonHoc MH
								where SV.ma like @maSinhVien and SV.maLop like L.ma
									and L.maKhoa like MH.maKhoa
	open @cur_maMonHoc
	fetch next from @cur_maMonHoc into @maMonHoc
	while @@fetch_status = 0
	begin
		set @diem = -1
		select top 1 @diem = diem from KetQua where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc
											order by lanThi DESC

		if @diem != -1
			print @maMonHoc + '	' + cast(@diem as varchar(10))
		else
			print @maMonHoc + '	null'

		fetch next from @cur_maMonHoc into @maMonHoc
	end
	close @cur_maMonHoc
	deallocate @cur_maMonHoc
end
go

-- 6.8.3
create proc Cau_6_8_3
	@maSinhVien varchar(10)
as
begin
	declare @cur_maMonHoc cursor, @maMonHoc varchar(10), @diem float
	set @cur_maMonHoc = cursor for select MH.ma from SinhVien SV, Lop L, MonHoc MH
								where SV.ma like @maSinhVien and SV.maLop like L.ma
									and L.maKhoa like MH.maKhoa
	open @cur_maMonHoc
	fetch next from @cur_maMonHoc into @maMonHoc
	while @@fetch_status = 0
	begin
		set @diem = -1
		select top 1 @diem = diem from KetQua where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc
											order by lanThi DESC

		if @diem != -1
			print @maMonHoc + '	' + cast(@diem as varchar(10))
		else
			print @maMonHoc + N'	<chưa có điểm>'

		fetch next from @cur_maMonHoc into @maMonHoc
	end
	close @cur_maMonHoc
	deallocate @cur_maMonHoc
end
go

-- Câu 6.9
create proc Cau_6_9
as
begin
	declare @cur_SinhVien_ma cursor, @cur_MonHoc_ma cursor
	declare @maSinhVien varchar(10), @maMonHoc varchar(10)
	declare @diemTB float, @tongDiem float, @diem float, @soMon int, @soMonKhongDat int

	set @cur_SinhVien_ma = cursor for select ma from SinhVien
	open @cur_SinhVien_ma
	fetch next from @cur_SinhVien_ma into @maSinhVien
	while @@fetch_status = 0
	begin
		set @diemTB = 0
		set @tongDiem = 0
		set @soMon = 0
		set @soMonKhongDat = 0
		set @cur_MonHoc_ma = cursor for select MH.ma from SinhVien SV, Lop L, MonHoc MH
								where SV.ma like @maSinhVien and SV.maLop like L.ma
									and L.maKhoa like MH.maKhoa
		open @cur_MonHoc_ma
		fetch next from @cur_MonHoc_ma into @maMonHoc
		while @@fetch_status = 0
		begin
			set @diem = -1
			select top 1 @diem = diem from KetQua where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc
											order by lanThi DESC
			
			if @diem != -1
			begin
				set @tongDiem = @tongDiem + @diem
				set @soMon = @soMon + 1
				if @diem < 4
					set @soMonKhongDat = @soMonKhongDat + 1
			end
			fetch next from @cur_MonHoc_ma into @maMonHoc
		end
		close @cur_MonHoc_ma
			
		set @diemTB = @tongDiem / @soMon
		if @diemTB >= 5 and @soMonKhongDat < 3
		begin
			if @diemTB >= 8
				insert into XepLoai values(@maSinhVien, @diemTB, N'Đạt', N'Giỏi')	
			else if @diemTB >= 7
				insert into XepLoai values(@maSinhVien, @diemTB, N'Đạt', N'Khá')	
			else
				insert into XepLoai values(@maSinhVien, @diemTB, N'Đạt', N'Trung bình')	
		end
		else
			insert into XepLoai values(@maSinhVien, @diemTB, N'Không đạt', null)
	
		fetch next from @cur_SinhVien_ma into @maSinhVien	
	end
	close @cur_SinhVien_ma
	deallocate @cur_SinhVien_ma
	deallocate @cur_MonHoc_ma
end
go

-- Câu 6.10
create proc Cau_6_10
as
begin
	declare @cur_SinhVien_ma cursor
	declare @maSinhVien varchar(10), @maMonHoc varchar(10)
	declare @diem float, @temp int, @diemTB float

	set @cur_SinhVien_ma = cursor for select ma from SinhVien
	open @cur_SinhVien_ma
	fetch next from @cur_SinhVien_ma into @maSinhVien
	while @@fetch_status = 0
	begin
		set @temp = 0
		set @diemTB = 0
		declare @cur_GiangKhoa_maMonHoc cursor
		set @cur_GiangKhoa_maMonHoc = cursor for select GK.maMonHoc from SinhVien SV, Lop L, GiangKhoa GK
									where SV.ma like @maSinhVien and SV.maLop like L.ma
									and L.maKhoa like GK.maKhoa
		open @cur_GiangKhoa_maMonHoc
		fetch next from @cur_GiangKhoa_maMonHoc into @maMonHoc
		while @@fetch_status = 0
		begin
			print @maMonHoc
			set @temp = 1
			set @diem = -1
			select top 1 @diem = diem from KetQua where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc
											order by lanThi DESC
			if @diem = -1
			begin
				set @temp = 2
				break
			end
			fetch next from @cur_GiangKhoa_maMonHoc into @maMonHoc
		end
		close @cur_GiangKhoa_maMonHoc
				
		if @temp = 1
		begin
			select @diemTB = diemTrungBinh from XepLoai where maSinhVien like @maSinhVien
			print @maSinhVien + '	' + cast(@diemTB as varchar(10))
		end

		fetch next from @cur_SinhVien_ma into @maSinhVien
	end
	close @cur_SinhVien_ma
	deallocate @cur_GiangKhoa_maMonHoc
	deallocate @cur_SinhVien_ma
end
go

-- Function
-- Câu 5.3 : 
create function Cau_5_3
(
	@maSinhVien varchar(10)
)
returns float
as
begin
	declare @cur_MonHoc_ma cursor
	declare @maMonHoc varchar(10)
	declare @diemTB float, @tongDiem float, @diem float, @soMon int

	set @diemTB = 0
	set @tongDiem = 0
	set @soMon = 0
	set @cur_MonHoc_ma = cursor for select KQ.maMonHoc from KetQua KQ where KQ.maSinhVien like @maSinhVien
	open @cur_MonHoc_ma
	fetch next from @cur_MonHoc_ma into @maMonHoc
	while @@fetch_status = 0
	begin
		set @diem = -1
		select top 1 @diem = diem from KetQua where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc
										order by lanThi DESC
		
		if @diem != -1
		begin
			set @tongDiem = @tongDiem + @diem
			set @soMon = @soMon + 1
		end
		fetch next from @cur_MonHoc_ma into @maMonHoc
	end
	close @cur_MonHoc_ma
	deallocate @cur_MonHoc_ma
	set @diemTB = @tongDiem / @soMon
	return @diemTB
end
go

-- Câu 5.4 :
create function Cau_5_4
(
	@maSinhVien varchar(10), @maMonHoc varchar(10)
)
returns table
as
	return (select lanThi, diem from KetQua where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc)
go

-- Câu 5.5 :
create function Cau_5_5
(
	@maSinhVien varchar(10)
)
returns table
as
	return (select GK.maMonHoc from SinhVien SV, Lop L, GiangKhoa GK
			where SV.ma like @maSinhVien and SV.maLop like L.ma
				and L.maKhoa like GK.maKhoa)
go

-- RBTV :
-- Câu 7.1 : ChuongTrinh.ma chỉ có thể là 'CQ' hoặc 'CD' hoặc 'TC'
alter table ChuongTrinh
add constraint Cau_7_1 check (ma in('CQ', 'CD', 'TC'))

-- Câu 7.2 : Chỉ có 2 học kỳ là 'HK1' và 'HK2'
-- Do trong cấu trúc CSDL trong đề hocKy là kiểu int nên miền giá trị em sẽ xét là 1 và 2
alter table GiangKhoa
add constraint Cau_7_2 check (hocKy in (1, 2))

-- Câu 7.3 : Số tiết lý thuyết (GiangKhoa.soTietLyThuyet) tối đa là 120
alter table GiangKhoa
add constraint Cau_7_3 check (soTietLyThuyet <= 120)

-- Câu 7.4 : Số tiết thực hành (GiangKhoa.soTietThucHanh) tối đa là 120
alter table GiangKhoa
add constraint Cau_7_4 check (soTietThucHanh <= 120)

-- Câu 7.5 : Số tín chỉ (GiangKhoa.soTinChi) của một môn học tối đa là 6
alter table GiangKhoa
add constraint Cau_7_5 check (soTinChi <= 6)

-- Câu 7.6 : Điểm thi (KetQua.diem) được chấm theo thang điểm 10 và chính xác đến 0.5
-- Cách 1 : kiểm tra và báo lỗi nếu không đúng quy định
create trigger Cau_7_6_1
on KetQua
for insert, update
as
begin
	declare @diem float, @diemx2 float
	set @diem = 0
	select @diem = diem from inserted
	if @diem < 0 or @diem > 10
	begin
		raiserror(N'Error : Điểm phải từ 0 - 10',1,1)
		rollback
	end

	set @diemx2 = @diem * 2
	if @diemx2 - cast(@diemx2 as int) != 0
	begin
		raiserror(N'Điểm phải chính xác tới 0.5',1,1)
		rollback
	end
end
go

-- Cách 2 : tự động làm tròn nếu không đúng quy định về độ chính xác
create trigger Cau_7_6_2
on KetQua
for insert, update
as
begin
	declare @diem float, @diemx2 float
	set @diem = 0
	select @diem = diem from inserted
	if @diem < 0 or @diem > 10
	begin
		raiserror(N'Error : Điểm phải từ 0 - 10',1,1)
		rollback
	end

	set @diemx2 = @diem * 2
	if @diemx2 - cast(@diemx2 as int) != 0
	begin
		declare @maSinhVien varchar(10), @maMonHoc varchar(10), @lanThi int
		select @maSinhVien = maSinhVien, @maMonHoc = maMonHoc, @lanThi = lanThi from inserted
		set @diemx2 = cast(@diemx2 as decimal(2))
		set @diem = @diemx2 / 2
		update KetQua set diem = @diem where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc and lanThi = @lanThi
	end
end
go

-- Câu 7.7 : Năm kết thúc khóa học phải lớn hơn hoặc bằng năm bắt đầu
alter table KhoaHoc
add constraint Cau_7_7 check (namKetThuc >= namBatDau)

-- Câu 7.8 : Số tiết lý thuyết của mỗi giảng khoa không nhỏ hơn số tiết thực hành
alter table GiangKhoa
add constraint Cau_7_8 check (soTietLyThuyet >= soTietThucHanh)

-- Câu 7.9 : Tên chương trình phải phân biệt
create trigger Cau_7_9
on ChuongTrinh
for insert, update
as
begin
	declare @tenChuongTrinh nvarchar(100)
	select @tenChuongTrinh = tenChuongTrinh from inserted
	if (select count(*) from ChuongTrinh where tenChuongTrinh like @tenChuongTrinh) >= 2
	begin
		raiserror(N'Error : Tên chương trình này đã tồn tại',1,1)
		rollback
	end
end
go

-- Câu 7.10 : Tên khoa phải phân biệt
create trigger Cau_7_10
on Khoa
for insert, update
as
begin
	declare @tenKhoa nvarchar(100)
	select @tenKhoa = tenKhoa from inserted
	if (select count(*) from Khoa where tenKhoa like @tenKhoa) >= 2
	begin
		raiserror(N'Error : Tên khoa này đã tồn tại',1,1)
		rollback
	end
end
go

-- Câu 7.11 : Tên môn học phải duy nhất
create trigger Cau_7_11
on MonHoc
for insert, update
as
begin
	declare @tenMonHoc nvarchar(100)
	select @tenMonHoc = tenMonHoc from inserted
	if (select count(*) from MonHoc where tenMonHoc like @tenMonHoc) >= 2
	begin
		raiserror(N'Error : Tên môn học này đã tồn tại',1,1)
		rollback
	end
end
go

-- Câu 7.12 : Sinh viên chỉ được thi tối đa 2 lần cho 1 môn học
create trigger Cau_7_12
on KetQua
for insert, update
as
begin
	declare @maSinhVien varchar(10), @maMonHoc varchar(10)
	select @maSinhVien = maSinhVien, @maMonHoc = maMonHoc from inserted
	if (select count(*) from KetQua where maSinhVien like @maSinhVien and maMonHoc like @maMonHoc) > 2
	begin
		raiserror(N'Error : Sinh viên chỉ được thi tối đa 2 lần cho 1 môn học',1,1)
		rollback
	end
end
go

-- Câu 7.13

-- Câu 7.14 : Năm bắt đầu khóa học của một lớp không thể nhỏ hơn năm thành lập của khoa quản lý lớp đó
create trigger Cau_7_14
on Lop
for insert, update
as
begin
	declare @maKhoaHoc varchar(10), @maKhoa varchar(10)
	select @maKhoaHoc = maKhoaHoc, @maKhoa = maKhoa from inserted
	if (select namBatDau from KhoaHoc where ma like @maKhoaHoc) <
		(select namThanhLap from Khoa where ma like @maKhoa)
	begin
		raiserror(N'Error : Năm thành lập của khoa phải nhỏ hơn năm bắt đầu của khóa học',1,1)
		rollback
	end
end
go

-- Câu 7.15 : Sinh viên chỉ có thể dự thi các môn học có trong chương trình và thuộc về khoa mà sinh viên đó đang theo học
create trigger Cau_7_15
on KetQua
for insert, update
as
begin
	declare @maSinhVien varchar(10), @maMonHoc varchar(10)
	select @maSinhVien = maSinhVien, @maMonHoc = maMonHoc from inserted
	if @maMonHoc not in (select MH.ma from MonHoc MH, SinhVien SV, Lop L 
						 where SV.ma like @maSinhVien and SV.maLop like L.ma and L.maKhoa like MH.maKhoa)
	begin
		raiserror(N'Error : Môn học này không có trong chương trình hoặc không thuộc về khoa mà sinh viên này theo học',1,1)
		rollback
	end
end
go

-- Câu 7.16 : Hãy bổ sung vào quan hệ Lop thuộc tính siSo và kiểm tra sĩ số của một lớp 
--			phải bằng số lượng sinh viên đang theo học lớp đó
create trigger Cau_7_16
on SinhVien
for insert, update, delete
as
begin
	declare @maLop varchar(10), @siSo int
	set @maLop = ''
	select @maLop = maLop from inserted

	-- Kiểm tra, nếu thỏa thì là đang thực hiện delete
	if @maLop like ''
	begin
		select @maLop = maLop from deleted
	end

	select @siSo = count(*) from SinhVien where maLop like @maLop
	update Lop set siSo = @siSo where ma like @maLop
end
go

