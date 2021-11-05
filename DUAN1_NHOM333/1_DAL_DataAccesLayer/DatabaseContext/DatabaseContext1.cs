using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAccesLayer.DatabaseContext
{
    public class DatabaseContext1:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Khi cấu hình đổi tên DATABASE mà các bạn muốn nó tạo ra
                optionsBuilder.UseSqlServer("Data Source=JWTMM5OHEEIIJGK\\SQLEXPRESS;Initial Catalog=DuAn1;Persist Security Info=True;User ID=cong;Password=123");
            }
        }
        public DbSet<CHUCVU> CHUCVUS { get; set; }
        public DbSet<NHANVIEN> NHANVIENS { get; set; }
        public DbSet<HOADON> HOADONS { get; set; }
        public DbSet<HOADONCHITIET> HOADONCHITIETS { get; set; }
        public DbSet<NHACUNGCAP> NHACUNGCAPS { get; set; }
        public DbSet<PHIEUNHAP> PHIEUNHAPS { get; set; }
        public DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPS { get; set; }
        public DbSet<HANGHOA> HANGHOAS { get; set; }
        public DbSet<THONGTINHANGHOA> THONGTINHANGHOAS { get; set; }
        public DbSet<KICHTHUOC> KICHTHUOCS { get; set; }
        public DbSet<LOAIHANG> LOAIHANGS { get; set; }




    }
}
