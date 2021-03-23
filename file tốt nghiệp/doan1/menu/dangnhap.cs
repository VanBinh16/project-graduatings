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


        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}