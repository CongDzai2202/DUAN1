using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Utilities
{
    public class MaHoaMK
    {

        public string MaHoaMk(string mk)
        {
            MD5 md5 = MD5.Create();// tạo MD5 (pt mã hóa mk)
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(mk); // Tạo mảng byte hứng mã hóa mk
            byte[] hash = md5.ComputeHash(inputBytes); // trả mã hóa mật khẩu về
            StringBuilder sb = new StringBuilder(); // khai báo 1 stringbuilder lm vc với 1 chuỗi lớn
            for (int i = 0; i < hash.Length; i++) // lặp qua tất giá trị trong mảng hash
            {
                sb.Append(hash[i].ToString("X2")); // đưa tất cả giá trị thành chuỗi //X2 để chuỗi viết hoa
            }

            return sb.ToString();
        }
    }
}

