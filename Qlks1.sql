create database thlvn
use thlvn
create table Qlks1(
	Taikhoan nchar(10) primary key,
	MatKhau nchar(20) NOT NULL,);
insert Qlks1(Taikhoan,MatKhau)
values (N'thanhxuan',N'xuanxi')
insert Qlks1(Taikhoan,MatKhau)
values (N'songnhan',N'nhan')
select * from Qlks1