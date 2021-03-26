using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class TaiKhoanBUS
     {

        TaiKhoanDAO demo = new TaiKhoanDAO();
        public List<TaiKhoanDTO> LayDskh()
        {
            return demo.layDSKH();
        }

        public TaiKhoanDTO layKH(string makh)
        {
            return demo.layKH(makh);
        }

        public bool DKKH(TaiKhoanDTO kh)
        {
            return demo.DKKH(kh);
        }
    }
}
