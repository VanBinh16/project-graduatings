using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChucVuDAO
    {
        demoEntities demos = new demoEntities();
        public void themKH()
        {
            ChucVu chucvu = new ChucVu();
            chucvu.MaCV = "";
            chucvu.TenChucVu = "";
           
            demos.ChucVus.Add(chucvu);
            demos.SaveChanges();
        }

        public List<ChucVuDTO> layDSKH()
        {
            List<ChucVuDTO> Dskh = new List<ChucVuDTO>();
            Dskh = demos.ChucVus.Select(u => new ChucVuDTO
            {
                MaCV = u.MaCV,
                TenChucVu = u.TenChucVu, 
            }).ToList();
            return Dskh;
        }

        public ChucVuDTO layKH(string makh)
        {
            ChucVuDTO kh = new ChucVuDTO();
            kh = demos.ChucVus.Select(u => new ChucVuDTO
            {
                MaCV = u.MaCV,
                TenChucVu = u.TenChucVu,               
            }).SingleOrDefault();
            return kh;
        }

        public bool DKKH(ChucVuDTO kh)
        {
            ChucVu customer = new ChucVu();

            try
            {
                customer.MaCV = kh.MaCV;
                customer.TenChucVu = kh.TenChucVu;              
                demos.ChucVus.Add(customer);
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
