﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_HinhChuNhat_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
        }

        private void btnDientich_Click(object sender, EventArgs e)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.chieuCao = double.Parse(txtCao.Text);
            hcn.chieuRong = double.Parse(txtRong.Text);

            txtKQ.Text = hcn.TinhDienTich().ToString(); 
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.chieuCao = double.Parse(txtCao.Text);
            hcn.chieuRong = double.Parse(txtRong.Text);

            txtKQ.Text = hcn.TinhChuVi().ToString();
        }
    }
}
