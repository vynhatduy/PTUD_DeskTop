﻿using System;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;

            foreach (var hang in listBox2.Items)
            {
                switch(hang)
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn phím":
                        soTien += 150000 ;
                        break;
                    case "Máy in":
                        soTien += 2000000;
                        break;
                    case "USB kingmax":
                        soTien += 200000;
                        break;
                    default:
                        break;
                }
                lblSoTien.Text = soTien+" đồng";
            }
        }

        private void lblSoTien_Click(object sender, EventArgs e)
        {
            
        }
    }
}
