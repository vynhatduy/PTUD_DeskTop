﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
         // click đôi vào sẽ tự động tạo hàm sự kiện này
        private void btnOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;
            MessageBox.Show($"Xin chào bạn  {tenDaNhap}. Rất vui được gặp bạn.", "Thông điệp chào mừng");
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            textSaoChep.Text = txtTen.Text;
        }

      
     
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            textSaoChep.Text = txtTen.Text;
        }
    }
}
