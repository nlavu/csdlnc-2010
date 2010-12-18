-- Quản lý các lớp ngoại ngữ
create table NgonNgu
(
	maNgonNgu	varchar(10),
	tenNgonNgu	nvarchar(30),
	constraint PK_NgonNgu_maNgonNgu primary key(maNgonNgu)
)

create table ChuongTrinh
(
	maChuongTrinh	varchar(10),
	tenChuongTrinh	nvarchar(30),
	maNgonNgu		varchar(10),
	constraint PK_ChuongTrinh_maChuongTrinh primary key(maChuongTrinh),
	constraint FK_ChuongTrinh_NgonNgu_maNgonNgu_maNgonNgu foreign key (maNgonNgu) references NgonNgu (maNgonNgu)
)

create table Lop
(
	maLop			varchar(10),
	tenLop			nvarchar(30),
	soThangHoc		int,
	hocPhi			float,
	maChuongTrinh	varchar(10),
	constraint PK_Lop_maLop primary key (maLop),
	constraint FK_Lop_ChuongTrinh_maChuongTrinh_maChuongTrinh foreign key (maChuongTrinh) references ChuongTrinh (maChuongTrinh)
)

create table PhongHoc
(
	maPhongHoc	varchar(10),
	tenPhongHoc	nvarchar(30),
	constraint PK_PhongHoc_maPhongHoc primary key (maPhongHoc)
)

create table CaHoc
(
	maCaHoc		varchar(10),
	thoiGian	varchar(30),
	constraint PK_CaHoc_maCaHoc primary key (maCaHoc)
)

create table LopMo
(
	maLopMo			varchar(10),
	ngayBatDau		datetime,
	ngayKetThuc		datetime,
	siSo			int,
	giamGia			int,
	isDuNguoi		varchar(3),
	maLop			varchar(10),
	maPhongHoc		varchar(10),
	maCaHoc			varchar(10),
	constraint PK_LopMo_maLopMo primary key (maLopMo),
	constraint FK_LopMo_Lop_maLop_maLop foreign key (maLop) references Lop (maLop),
	constraint FK_LopMo_PhongHoc_maPhongHoc_maPhongHoc foreign key (maPhongHoc) references PhongHoc (maPhongHoc),
	constraint FK_LopMo_CaHoc_maCaHoc_maCaHoc foreign key (maCaHoc) references CaHoc (maCaHoc)
)

create table HocVien
(
	maHocVien		varchar(10),
	tenHocVien		nvarchar(30),
	soDienThoaiHV	varchar(20),
	constraint PK_HocVien_maHocVien primary key (maHocVien)
)

create table DangKy
(
	maLopMo		varchar(10),
	maHocVien	varchar(10),
	isGiamGia	varchar(3),
	constraint PK_DangKy_maLopMo_maHocVien primary key (maLopMo, maHocVien),
	constraint FK_DangKy_LopMo_maLopMo_maLopMo foreign key (maLopMo) references LopMo (maLopMo),
	constraint FK_DangKy_HocVien_maHocVien_maHocVien foreign key (maHocVien) references HocVien(maHocVien)
)

-- Quản lý việc đăng ký thi
create table LoaiChungChi
(
	maLoaiCC	varchar(10),
	tenLoaiCC	nvarchar(30),
	soLanThi	int,
	constraint PK_LoaiChungChi_maLoaiCC primary key (maLoaiCC)
)

create table ChungChi
(
	maChungChi	varchar(10),
	tenChungChi	nvarchar(30),
	maLoaiCC	varchar(10),
	constraint PK_ChungChi_maChungChi primary key (maChungChi),
	constraint FK_ChungChi_LoaiChungChi_maLoaiCC_maLoaiCC foreign key (maLoaiCC) references LoaiChungChi (maLoaiCC)
)

create table KyThi
(
	maKyThi		varchar(10),
	lePhi		float,
	ngayThi		datetime,
	diaDiem		nvarchar(50),
	maChungChi	varchar(10),
	constraint PK_KyThi_maKyThi primary key (maKyThi),
	constraint FK_KyThi_ChungChi foreign key (maChungChi) references ChungChi (maChungChi)
)

create table ThiVong2
(
	maKyThi			varchar(10),
	maThiVong2		varchar(10),
	lePhiVong2		float,
	ngayThiVong2	datetime,
	diaDiemVong2	nvarchar(50),
	constraint PK_ThiVong2_maKyThi_maThiVong2 primary key (maKyThi, maThiVong2),
	constraint FK_ThiVong2_KyThi_maKyThi_maKyThi foreign key (maKyThi) references KyThi (maKyThi)
)

create table ThiSinh
(
	maThiSinh		varchar(10),
	tenThiSinh		nvarchar(30),
	soDienThoaiTS	varchar(20),
	constraint PK_ThiSinh_maThiSinh primary key (maThiSinh)
)

create table DangKyThi
(
	maKyThi		varchar(10),
	maThiSinh	varchar(10),
	diemThi		float,
	constraint PK_DangKyThi_maKyThi_maThiSinh primary key (maKyThi, maThiSinh),
	constraint FK_DangKyThi_KyThi_maKyThi_maKyThi foreign key (maKyThi) references KyThi (maKyThi),
	constraint FK_DangKyThi_ThiSinh_maThiSinh_maThiSinh foreign key (maThiSinh) references ThiSinh (maThiSinh)
)

create table DangKyVong2
(
	maKyThi			varchar(10),
	maThiVong2		varchar(10),
	maThiSinh		varchar(10),
	diemThiVong2	float,
	constraint PK_DangKyVong2_maKyThi_maThiVong2_maThiSinh primary key (maKyThi, maThiVong2, maThiSinh),
	constraint FK_DangKyVong2_ThiVong2_maKyThi_maThiVong2_maKyThi_maThiVong2 foreign key (maKyThi, maThiVong2) references ThiVong2 (maKyThi, maThiVong2),
	constraint FK_DangKyVong2_DangKyThi_maKyThi_maThiSinh_maKyThi_maThiSinh foreign key (maKyThi, maThiSinh) references DangKyThi (maKyThi, maThiSinh),
	constraint FK_DangKyVong2_ThiSinh_maThiSinh_maThiSinh foreign key (maThiSinh) references ThiSinh (maThiSinh)
)

--	Quản lý nhân viên
create table ChucVu
(
	maChucVu	varchar(10),
	tenChucVu	nvarchar(30),
	constraint PK_ChucVu_maChucVu primary key (maChucVu)
)

create table NhanVien
(
	maNhanVien	varchar(10),
	hoTen		nvarchar(30),
	diaChi		nvarchar(50),
	soDienThoai	varchar(20),
	username	varchar(30),
	password	varchar(30),
	maChucVu	varchar(10),
	constraint PK_NhanVien_maNhanVien primary key (maNhanVien),
	constraint FK_NhanVien_ChucVu_maChucVu_maChucVu foreign key (maChucVu) references ChucVu (maChucVu)
)