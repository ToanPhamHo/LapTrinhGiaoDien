using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace LapTrinhCoSoDuLieu
{
    class DAONhanVien
    {
        DataClasses1DataContext DB = new DataClasses1DataContext();

        //public IEnumerable<NHANVIEN> trichDSNhanVienTuDB()
        //{
        //    return DB.NHANVIENs.ToList();
        //}

        public dynamic trichDSNhanVienTuDB()
        {
            //var nv = from n in DB.NHANVIENs
            //         join b in DB.BANGCAPs on n.MaBangCap equals b.MaBangCap
            //         select new
            //         {
            //             n.MaNhanVien,
            //             n.HoTenNhanVien,
            //             n.NgaySinh,
            //             n.DiaChi,
            //             n.DienThoai,
            //             b.TenBangCap
            //         };

            var nv2 = DB.NHANVIENs.Join(DB.BANGCAPs, n => n.MaBangCap, 
                                                     b => b.MaBangCap, 
                                                     (n, b) => new {
                                                         n.MaNhanVien,
                                                         n.HoTenNhanVien,
                                                         n.NgaySinh,
                                                         n.DiaChi,
                                                         n.DienThoai,
                                                         b.TenBangCap
                                                     });

            return nv2;
        }

        public IEnumerable<BANGCAP> trichDSBangCapTuDB()
        {
            return DB.BANGCAPs.ToList();
        }
        public void themNV(string hoTen, string ngaySinh, string diaChi, string sdt, string bangCap)
        {

            NHANVIEN nv = new NHANVIEN();
            nv.HoTenNhanVien = hoTen;
            nv.NgaySinh = DateTime.Parse(ngaySinh);
            nv.DiaChi = diaChi;
            nv.DienThoai = sdt;
            nv.MaBangCap = bangCap;
            try
            {
                DB.NHANVIENs.InsertOnSubmit(nv);
                DB.SubmitChanges();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }   
        }

        public void suaNV(string maNV, string hoTen, string ngaySinh, string diaChi, string sdt, string bangCap)
        {
            NHANVIEN nv = DB.NHANVIENs.FirstOrDefault(s => s.MaNhanVien.Equals(maNV));
            nv.HoTenNhanVien = hoTen;
            nv.NgaySinh = DateTime.Parse(ngaySinh);
            nv.DiaChi = diaChi;
            nv.DienThoai = sdt;

            BANGCAP bc = DB.BANGCAPs.Single(b => b.MaBangCap.Equals(bangCap));
            bc.NHANVIENs.Add(nv);

            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void xoaNV(string maNV)
        {
            NHANVIEN nv = DB.NHANVIENs.FirstOrDefault(s => s.MaNhanVien.Equals(maNV));
            try
            {
                DB.NHANVIENs.DeleteOnSubmit(nv);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
