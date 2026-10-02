using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiTapTuan4
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            Acceptbtn.Click += Acceptbtn_Click;
            SkipBtn.Click += SkipBtn_Click;
        }
        public NhanVien GetNhanVien()
        {
            return new NhanVien
            {
                MSNV = textBox1.Text.Trim(),
                TenNV = textBox2.Text.Trim(),
                LuongCB = textBox3.Text.Trim()
            };
        }

        public void SetNhanVien(NhanVien nv)
        {
            if (nv == null) return;
            textBox1.Text = nv.MSNV ?? string.Empty;
            textBox2.Text = nv.TenNV ?? string.Empty;
            textBox3.Text = nv.LuongCB ?? string.Empty;
        }

        private void Acceptbtn_Click(object? sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("MSNV không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SkipBtn_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
