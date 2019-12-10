-- viet cac store


-- viet 1 store lay danh sach sinh vien
create proc sp_LayDSSV
as
  select * from SINHVIEN

-- them vao mot khoa
create proc sp_Themkhoa(@ma char(6),@ten nvarchar(30))
as
 insert into KHOA(MAKHOA,TENKHOA)
 values(@ma,@ten)
 -- Xoa 

 create proc sp_Xoakhoa(@ma char(6))
 as
   delete  Khoa 
   where MAKHOA=@ma

   --sua
   create proc sp_Suakhoa(@ma char(6),@ten nvarchar(30))
   as
    update khoa
	set TENKHOA =@ten
	where MAKHOA =@ma

exec sp_Suakhoa 'TH',N'Cong nghe thong tin'

-- Lay danh sach khoa
create proc sp_LayDSkhoa
as
  select *
 from Khoa

exec sp_Xoakhoa'NN'
-- them khoa 
exec sp_Themkhoa 'NN', N'Tieng nhat'

-- xem ket qua chay cua store

exec sp_LayDSSV