using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace demo1
{
    public partial class ChucVu : Form
    {
        public ChucVu()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        ChucVuBUS customerBUS = new ChucVuBUS();
        BindingSource bs = new BindingSource();
        List<ChucVuDTO> dskh = new List<ChucVuDTO>();
        private void Load_Form()
        {
            Load_DSKH();
        }
        private void Load_DSKH()
        {
            dskh = customerBUS.LayDskh();
            bs.DataSource = dskh.ToList();
            dtgv_ttkh.DataSource = bs;
        }
        private void dtgv_ttkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ttkh.SelectedCells.Count > 0)
            {
                foreach (ChucVuDTO kh in dskh)
                {
                    txtMaChucVu.Text = kh.MaCV;
                    txtTenChucVu.Text = kh.TenChucVu;                  
                    break;
                }
            }
        }
        private ChucVuDTO layTTKH_moi()
        {
            ChucVuDTO NewKH = new ChucVuDTO();
            NewKH.MaCV = string.IsNullOrEmpty(txtMaChucVu.Text) ? "" : txtMaChucVu.Text;
            NewKH.TenChucVu = string.IsNullOrEmpty(txtTenChucVu.Text) ? "" : txtTenChucVu.Text;          
            return NewKH;
        }  
        private void reset()
        {
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";
        }
        private void Them_Click_1(object sender, EventArgs e)
        {
            ChucVuDTO khAdd = layTTKH_moi();
            if (khAdd.TenChucVu == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            bool kq = customerBUS.DKKH(khAdd);
            MessageBox.Show("Thêm thành công");
            reset();
            Load_Form();
        }
        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            reset();
        }
    }
}
