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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtgv_ttkh.AutoGenerateColumns = false;
            Load_Form();
        }
        NhanVienBUS customerBUS = new NhanVienBUS();
        BindingSource bs = new BindingSource();
        List<NhanVienDTO> dskh = new List<NhanVienDTO>();
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
                foreach (NhanVienDTO kh in dskh)
                {
                        txtMaNV.Text = kh.MaNV;
                        txtTenNV.Text = kh.TenNV;
                        txtSoDienThoai.Text = kh.SDT;
                        txtchucvu.Text = kh.MaCV;
                        break;                  
                }
            }
        }
        private NhanVienDTO layTTKH_moi()
        {
            NhanVienDTO NewKH = new NhanVienDTO();           
            NewKH.MaNV = string.IsNullOrEmpty(txtMaNV.Text) ? "" : txtMaNV.Text;
            NewKH.TenNV = string.IsNullOrEmpty(txtTenNV.Text) ? "" : txtTenNV.Text;
            NewKH.SDT = string.IsNullOrEmpty(txtSoDienThoai.Text) ? "" : txtSoDienThoai.Text;
            NewKH.MaCV = string.IsNullOrEmpty(txtchucvu.Text) ? "" : txtchucvu.Text;
            return NewKH;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            NhanVienDTO khAdd = layTTKH_moi();
            if (khAdd.TenNV == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            bool kq = customerBUS.DKKH(khAdd);
            MessageBox.Show("Thêm thành công");
            reset();
            Load_Form();
        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DSKH();
            int intMaNV = dtgv_ttkh.Rows.Count;
            if (cmbchucvu.Text == "Quản Lý")
            {
                txtMaNV.Text = "QL-0" + intMaNV;
            }
            else
            {
                txtMaNV.Text = "NV-0" + intMaNV;
            }
        }
        private void reset()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSoDienThoai.Text = "";
            txtchucvu.Text = "";
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
