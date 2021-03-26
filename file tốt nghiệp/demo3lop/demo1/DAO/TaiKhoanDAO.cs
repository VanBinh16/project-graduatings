using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        //ma hoa md5
        demoEntities demos = new demoEntities();
        public void themKH()
        {
            TaiKhoan kh = new TaiKhoan();
            kh.TaiKhoan1 = "";
            kh.MatKhau = "";
            demos.TaiKhoans.Add(kh);
            demos.SaveChanges();
        }

        public List<TaiKhoanDTO> layDSKH()
        {
            List<TaiKhoanDTO> Dskh = new List<TaiKhoanDTO>();
            Dskh = demos.TaiKhoans.Select(u => new TaiKhoanDTO
            {
                TaiKhoan = u.TaiKhoan1,
                MatKhau = u.MatKhau,
               
            }).ToList();
            return Dskh;
        }

        public TaiKhoanDTO layKH(string makh)
        {
            TaiKhoanDTO kh = new TaiKhoanDTO();
            kh = demos.TaiKhoans.Select(u => new TaiKhoanDTO
            {
                TaiKhoan = u.TaiKhoan1,
                MatKhau = u.MatKhau,
              
            }).SingleOrDefault();
            return kh;
        }

        public bool DKKH(TaiKhoanDTO kh)
        {
            TaiKhoan customer = new TaiKhoan();

            try
            {
                customer.TaiKhoan1 = kh.TaiKhoan;
                customer.MatKhau = kh.MatKhau;
                demos.TaiKhoans.Add(customer);
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
