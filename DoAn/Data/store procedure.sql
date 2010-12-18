-- lntrung
create proc sp_NhanVien_IsNhanVienExist
	@maNhanVien varchar(10)
as
begin
	select * from NhanVien where maNhanVien like @maNhanVien
end

create proc sp_HocVien_Insert
	@tenHocVien nvarchar(30), @soDienThoaiHV varchar(20)
as
begin
	declare @maHocVien varchar(10)
	select top 1 @maHocVien = maHocVien from HocVien order by maHocVien DESC
	
	set @maHocVien = cast( (cast(right(@maHocVien,5) as int) + 1) as varchar(10)) 
	if (@maHocVien > 9999) set @maHocVien = '2010_' + @maHocVien
	else if (@maHocVien > 999) set @maHocVien = '2010_0' + @maHocVien
	else if (@maHocVien > 99) set @maHocVien = '2010_00' + @maHocVien
	else if (@maHocVien > 9) set @maHocVien = '2010_000' + @maHocVien
	else set @maHocVien = '2010_0000' + @maHocVien
		
	insert into hocvien values (@maHocVien, @tenHocVien, @soDienThoaiHV)
end


select * from hocVien