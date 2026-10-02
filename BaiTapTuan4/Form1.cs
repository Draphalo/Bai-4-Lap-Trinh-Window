namespace BaiTapTuan4
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();

            Addbtn.Click += Addbtn_Click;
            Editbtn.Click += Editbtn_Click;
            Deletebtn.Click += Deletebtn_Click;
            Closebtn.Click += Closebtn_Click;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            using var form = new FormNhanVien();
            form.Text = "Thêm nhân viên";
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var nv = form.GetNhanVien();
                dataGridView1.Rows.Add(nv.MSNV, nv.TenNV, nv.LuongCB);
            }
        }

        private void Editbtn_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            var msnv = row.Cells[0].Value?.ToString() ?? string.Empty;
            var ten = row.Cells[1].Value?.ToString() ?? string.Empty;
            var luong = row.Cells[2].Value?.ToString() ?? string.Empty;

            using var form = new FormNhanVien();
            form.Text = "Sửa nhân viên";
            form.SetNhanVien(new NhanVien { MSNV = msnv, TenNV = ten, LuongCB = luong });

            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var nvUpdated = form.GetNhanVien();
                row.Cells[0].Value = nvUpdated.MSNV;
                row.Cells[1].Value = nvUpdated.TenNV;
                row.Cells[2].Value = nvUpdated.LuongCB;
            }
        }

        private void Deletebtn_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            var msnv = row.Cells[0].Value?.ToString() ?? "";
            var confirm = MessageBox.Show($"Bạn có chắc muốn xoá nhân viên {msnv}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void Closebtn_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
