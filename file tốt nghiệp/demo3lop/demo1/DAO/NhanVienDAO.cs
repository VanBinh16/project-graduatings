using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhanVienDAO
    {
        demoEntities demos = new demoEntities();
        public void themKH()
        {
            NhanVien kh = new NhanVien();
            kh.MaNV = "";
            kh.TenNV = "";
            kh.SDT = "";
            kh.MaCV = "";
            demos.NhanViens.Add(kh);
            demos.SaveChanges();
        }

        public List<NhanVienDTO> layDSKH()
        {
            List<NhanVienDTO> Dskh = new List<NhanVienDTO>();
            Dskh = demos.NhanViens.Select(u => new NhanVienDTO
            {
                MaNV = u.MaNV,
                TenNV = u.TenNV,    
                SDT = u.SDT,
                MaCV=u.MaCV,
            }).ToList();
            return Dskh;
        }

        public NhanVienDTO layKH(string makh)
        {
            NhanVienDTO kh = new NhanVienDTO();
            kh = demos.NhanViens.Select(u => new NhanVienDTO
            {
                MaNV = u.MaNV,
                TenNV = u.TenNV,
                SDT = u.SDT,
                MaCV=u.MaCV,
            }).SingleOrDefault();
            return kh;
        }

        public bool DKKH(NhanVienDTO kh)
        {
            NhanVien customer = new NhanVien();

            try
            {
                customer.MaNV = kh.MaNV;
                customer.TenNV = kh.TenNV;
                customer.SDT = kh.SDT;
                customer.MaCV = kh.MaCV;
                demos.NhanViens.Add(customer);
                demos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
