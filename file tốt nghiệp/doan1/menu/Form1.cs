﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace menu
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }
       
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //this form is a parent MDI window
            this.IsMdiContainer = true;
            dangnhap f = new dangnhap();
           
            f.MdiParent = this;
            f.Show();
        }

       
    }
}
