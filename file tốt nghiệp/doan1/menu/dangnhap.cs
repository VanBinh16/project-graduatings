using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class dangnhap : DevExpress.XtraEditors.XtraForm
    {
        public dangnhap()
        {
            InitializeComponent();
        }


        //An nut close tren form
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }


       
        
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
             ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);     
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string user = "binh";
            string pass = "1234";
            if (user.Equals(txtdangnhap.Text) && pass.Equals(txtpass.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }

        private void txtpass_TextChange(object sender, EventArgs e)
        {
            if (txtpass.TextLength.ToString()!=null)
            {
                txtpass.UseSystemPasswordChar = true;               
            }
            else
                txtpass.UseSystemPasswordChar = false;
           
        }
    }
}