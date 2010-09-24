create table NHA_CUNG_CAP
(
	Ma	varchar(10),
	Ten	nvarchar(30),
	DiaChi nvarchar(30),
	DienThoai varchar(15)
	constraint PK_NHA_CUNG_CAP_Ma primary key(Ma)
)

create table MAT_HANG
(
	Ma	varchar(10),
	Ten	nvarchar(30),
	DonViTinh nvarchar(10),
	QuiCach nvarchar(30),
	SoLuongTon int,
	constraint PK_MAT_HANG_Ma primary key(Ma)
)

create table CUNG_UNG
(
	MaNhaCungCap	varchar(10),
	MaMatHang	varchar(10),
	constraint PK_CUNG_UNG_MaNhaCungCap_MaMatHang primary key(MaNhaCungCap, MaMatHang),
	constraint FK_CUNG_UNG_NHA_CUNG_CAP_MaNhaCungCap_Ma	foreign key(MaNhaCungCap) references NHA_CUNG_CAP (Ma),
	constraint FK_CUNG_CAP_MAT_HANG_MaMatHang_Ma foreign key(MaMatHang) references MAT_HANG(Ma)
)

create table DAT_HANG
(
	So	varchar(10),
	Ngay	datetime,
	MaNhaCungCap	varchar(10),
	GhiChu	nvarchar(30),
	SoMatHang	int,
	ThanhTien	int,
	constraint PK_DAT_HANG_So primary key(So),
	constraint FK_DAT_HANG_NHA_CUNG_CAP_MaNhaCungCap_Ma foreign key(MaNhaCungCap) references NHA_CUNG_CAP(Ma)
)

create table CHI_TIET_DAT_HANG
(
	SoDatHang	varchar(10),
	MaMatHang	varchar(10),
	SoLuongDat	int,
	DonGiaDat	int,
	constraint PK_CHI_TIET_DAT_HANG_SoDatHang_MaMatHang primary key(SoDatHang, MaMatHang),
	constraint FK_CHI_TIET_DAT_HANG_DAT_HANG_SoDatHang_So foreign key(SoDatHang) references DAT_HANG(So),
	constraint FK_CHI_TIET_DAT_HANG_MAT_HANG_MaMatHang_Ma foreign key(MaMatHang) references MAT_HANG(Ma)
)

create table GIAO_HANG
(
	So	varchar(10),
	Ngay	datetime,
	SoDatHang	varchar(10),
	constraint PK_GIAO_HANG_So	primary key(So),
	constraint FK_GIAO_HANG_DAT_HANG_SoDatHang_So	foreign key(SoDatHang) references DAT_HANG(So)
)

create table CHI_TIET_GIAO_HANG
(
	SoGiaoHang	varchar(10),
	MaMatHang	varchar(10),
	SoLuongGiao	int,
	constraint PK_CHI_TIET_GIAO_HANG_SoGiaoHang_MaMatHang primary key(SoGiaoHang, MaMatHang),
	constraint FK_CHI_TIET_GIAO_HANG_GIAO_HANG_SoGiaoHang_So foreign key(SoGiaoHang) references GIAO_HANG(So),
	constraint FK_CHI_TIET_GIAO_HANG_MAT_HANG_MaMatHang_Ma	foreign key(MaMatHang) references MAT_HANG(Ma)
)

-- Procedure :
-- Câu_3.1
create proc Cau_3_1
	@Ma	varchar(10)
as
begin
	select * from DAT_HANG where MaNhaCungCap like @Ma
end
go

-- Câu_3.2
create proc Cau_3_2
	@So	varchar(10), @ThanhTien	int output
as
begin
	declare @cur_Chi_Tiet_Dat_Hang cursor
	declare @Tien int
	set @ThanhTien = 0
	set @cur_Chi_Tiet_Dat_Hang = cursor for select SoLuongDat * DonGiaDat 
											from CHI_TIET_DAT_HANG where SoDatHang like @So
	open @cur_Chi_Tiet_Dat_Hang
	fetch next from @cur_Chi_Tiet_Dat_Hang into @Tien
	while @@fetch_status = 0
	begin
		set @ThanhTien = @ThanhTien + @Tien
		fetch next from @cur_Chi_Tiet_Dat_Hang into @Tien
	end

	close @cur_Chi_Tiet_Dat_Hang

	update DAT_HANG set ThanhTien = @ThanhTien where So = @So
	deallocate @cur_Chi_Tiet_Dat_Hang
end
go

-- Câu_3.3
create proc Cau_3_3
as
begin
	declare @cur_Dat_Hang cursor, @cur_Chi_Tiet_Dat_Hang cursor
	declare @So varchar(10), @ThanhTien int, @Tien int
	set @cur_Dat_Hang = cursor for select So from DAT_HANG
	open @cur_Dat_Hang
	fetch next from @cur_Dat_Hang into @So
	while @@fetch_status = 0
	begin
		set @ThanhTien = 0
		set @cur_Chi_Tiet_Dat_Hang = cursor for select SoLuongDat * DonGiaDat 
												from CHI_TIET_DAT_HANG where SoDatHang like @So
		open @cur_Chi_Tiet_Dat_Hang
		fetch next from @cur_Chi_Tiet_Dat_Hang into @Tien
		while @@fetch_status = 0
		begin
			set @ThanhTien = @ThanhTien + @Tien
			fetch next from @cur_Chi_Tiet_Dat_Hang into @Tien
		end

		close @cur_Chi_Tiet_Dat_Hang

		update DAT_HANG set ThanhTien = @ThanhTien where So = @So
		fetch next from @cur_Dat_Hang into @So
	end
	close @cur_Dat_Hang
	deallocate @cur_Dat_Hang
	deallocate @cur_Chi_Tiet_Dat_Hang
end
go

-- Câu 3.4


-- Câu 3.5
create proc Cau_3_5
as
begin
	declare @cur_Dat_Hang cursor, @cur_Chi_Tiet_Dat_Hang cursor
	declare @So varchar(10), @SoMatHang int, @ThanhTien int, @Tien int
	set @cur_Dat_Hang = cursor for select So from DAT_HANG
	open @cur_Dat_Hang
	fetch next from @cur_Dat_Hang into @So
	while @@fetch_status = 0
	begin
		set @SoMatHang = 0
		set @ThanhTien = 0
		set @cur_Chi_Tiet_Dat_Hang = cursor for select SoLuongDat * DonGiaDat 
												from CHI_TIET_DAT_HANG where SoDatHang like @So
		open @cur_Chi_Tiet_Dat_Hang
		fetch next from @cur_Chi_Tiet_Dat_Hang into @Tien
		while @@fetch_status = 0
		begin
			set @SoMatHang = @SoMatHang + 1
			set @ThanhTien = @ThanhTien + @Tien
			fetch next from @cur_Chi_Tiet_Dat_Hang into @Tien
		end

		close @cur_Chi_Tiet_Dat_Hang

		update DAT_HANG set SoMatHang = @SoMatHang, ThanhTien = @ThanhTien where So = @So
		fetch next from @cur_Dat_Hang into @So
	end
	close @cur_Dat_Hang
	deallocate @cur_Dat_Hang
	deallocate @cur_Chi_Tiet_Dat_Hang
end
go

-- RBTV :
-- Câu 2.1 : Số lượng tồn của một mặt hàng luôn luôn lớn hơn 0
alter table MAT_HANG
add constraint Cau_2_1 check (SoLuongTon > 0)

-- Câu 2.2 : Số lượng mặt hàng đặt không quá 10 mặt hàng
alter table DAT_HANG
add constraint Cau_2_2 check (SoMatHang <= 10)

-- Câu 2.3 : Đơn vị tính thuộc một trong các đơn vị sau : lốc, chai, thùng, túi, bao, bình, hộp, hũ, gói, kg
alter table MAT_HANG
add constraint Cau_2_3 check (DonViTinh in (N'lốc', N'chai', N'thùng', N'túi',
											  N'bao', N'bình', N'hộp', N'hũ', N'gói', N'kg'))

-- Câu 2.4 : Qhi cách đóng gói thuộc trong các qui cách sau : chai, gói, hộp, thùng
alter table MAT_HANG
add constraint Cau_2_4 check (QuiCach in (N'chai', N'gói', N'hộp', N'thùng'))

-- Câu 2.5 : Số điện thoại là chuỗi số gồm 10 ký số x, có dạng 'xxx-xxxxxx' hay 'xx-xxxxxxx'
alter table NHA_CUNG_CAP
add constraint Cau_2_5 check (DienThoai like '__-_______' or DienThoai like '___-______')

-- Câu 2.6 : Trong một lần đặt hàng, nhà cung cấp có thể giao hàng tối đa 3 lần
create trigger Cau_2_6
on GIAO_HANG
for insert, update
as
begin
	-- Đếm số lần giao hàng
	if (select count(*) from GIAO_HANG GH where GH.SoDatHang like (select SoDatHang from inserted)) > 3
	begin
		raiserror(N'Error : Giao hàng quá 3 lần',1,1)
		rollback
	end
end
go

-- Câu 2.7 : Không được phép giao hàng trễ hơn một tuần
create trigger Cau_2_7
on GIAO_HANG
for insert, update
as
begin
	declare @soDatHang varchar(10)
	declare @ngayDat datetime, @ngayGiao datetime
	select @soDatHang = SoDatHang from inserted
	select @ngayDat = Ngay from DAT_HANG where So like @soDatHang
	select @ngayGiao = Ngay from inserted
	if datediff(dd, @ngayDat, @ngayGiao) > 7
	begin
		raiserror(N'Error : giao hàng trễ hơn một tuần',1,1)
		rollback
	end
end
go

-- Câu 2.8 : Chỉ có thể đặt các mặt hàng mà nhà cung cấp đó cung ứng
create trigger Cau_2_8
on CHI_TIET_DAT_HANG
for insert, update
as
begin
	declare @maNhaCungCap varchar(10), @maMatHang varchar(10)
	select @maNhaCungCap = MaNhaCungCap from DAT_HANG where So like (select SoDatHang from inserted)
	select @maMatHang = MaMatHang from inserted

	-- Kiểm tra mặt hàng này có nằm trong những mặt hàng của nhà cung cấp không
	if @maMatHang not in (select MaMatHang from CUNG_UNG where MaNhaCungCap like @maNhaCungCap)
	begin
		print N'Error : mặt hàng ' + @maMatHang + N' không thuộc nhà cung cấp ' + @maNhaCungCap
		rollback
	end
end
go

-- Câu 2.9 : Chỉ được giao các mặt hàng mà khách hàng có đặt
create trigger Cau_2_9
on CHI_TIET_GIAO_HANG
for insert, update
as
begin
	declare @soDatHang varchar(10), @maMatHang varchar(10)
	select @soDatHang = SoDatHang from GIAO_HANG where So like (select SoGiaoHang from inserted)
	select @maMatHang = MaMatHang from inserted
	
	-- Kiểm tra mặt hàng này có nằm trong những mặt hàng được đặt hay không
	if @maMatHang not in (select MaMatHang from CHI_TIET_DAT_HANG where SoDatHang like @soDatHang)
	begin
		print N'Mặt hàng ' + @maMatHang + N' không nằm trong những mặt hàng được đặt'
		rollback
	end
end
go

-- Câu 2.10 : Tổng số lượng giao của một mặt hàng trong một lần giao hàng phải nhỏ hơn hoặc bằng số lượng đặt
create trigger Cau_2_10
on CHI_TIET_GIAO_HANG
for insert, update
as
begin
	declare @soDatHang varchar(10), @maMatHang varchar(10), @soLuongGiao int
	select @soDatHang = SoDatHang from GIAO_HANG where So like (select SoGiaoHang from inserted)
	select @maMatHang = MaMatHang, @soLuongGiao = SoLuongGiao from inserted

	-- Kiểm tra xem số lượng hàng giao có nhiều hơn số lượng hàng được đặt hay không
	if @soLuongGiao > (select SoLuongDat from CHI_TIET_DAT_HANG 
					  where SoDatHang like @soDatHang and MaMatHang like @maMatHang)
	begin
		raiserror(N'Số lượng hàng giao lớn hơn số lượng hàng được đặt',1,1)
		rollback
	end
end
go

-- Câu 2.11 : Số mặt hàng trong đặt hàng phải bằng số các mặt hàng được đặt trong chi tiết đặt hàng
--			của cùng một lần đặt hàng
create trigger Cau_2_11
on CHI_TIET_DAT_HANG
for insert, update, delete
as
begin
	declare @soDatHang varchar(10), @soMatHang int
	set @soDatHang = ''
	select @soDatHang = SoDatHang from inserted

	-- Nếu @soDatHang like '' nghĩa là thao tác là delete
	if @soDatHang like ''
	begin
		select @soDatHang = SoDatHang from deleted
	end

	-- Đếm số mặt hàng được đặt
	select @soMatHang = count(*) from CHI_TIET_DAT_HANG where SoDatHang like @soDatHang

	-- Cập nhật tổng số mặt hàng được đặt
	update DAT_HANG set SoMatHang = @soMatHang where So like @soDatHang
end
go

-- Câu 2.12 : Cập nhật số lượng tồn của mặt hàng một cách tự động mỗi khi mặt hàng được giao
create trigger Cau_2_12
on CHI_TIET_GIAO_HANG
for insert, update, delete
as
begin
	declare @maMatHang varchar(10), @soLuongGiao int, @soLuongTon int
	set @maMatHang = ''
	set @soLuongGiao = 0
	select @maMatHang = MaMatHang, @soLuongGiao = SoLuongGiao from inserted

	-- Nếu @maMatHang like '' nghĩa là thao tác là delete
	if @maMatHang like ''
	begin
		select @maMatHang = MaMatHang, @soLuongGiao = SoLuongGiao from deleted
		
		-- Vì là delete nên tăng số lượng tồn lên lại
		set @soLuongGiao = 0 - @soLuongGiao
	end
	
	-- Lấy số lượng tồn của mặt hàng này
	select @soLuongTon = SoLuongTon from MAT_HANG where Ma like @maMatHang
	set @soLuongTon = @soLuongTon - @soLuongGiao

	-- Cập nhật số lượng tồn của mặt hàng này
	update MAT_HANG set SoLuongTon = @soLuongTon where Ma like @maMatHang
end
go

