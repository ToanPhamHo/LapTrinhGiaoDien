using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;

namespace LapTrinhCoSoDuLieu
{
    class DAOvsBUSLogin
    {
        DataClasses1DataContext DB = new DataClasses1DataContext();

        public IEnumerable<DANGNHAP> trichDangNhap()
        {
            return DB.DANGNHAPs.ToList();
        }

        public bool kt(string tk, string mk)
        {
            var q = DB.DANGNHAPs.Where(s => s.TenTaiKhoan == tk && s.MatKhau == mk).SingleOrDefault();

            if (q != null)
                return true;          
            else
                return false;
        }

        public string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}

