namespace BaiTapTuan4
{
    partial class QLNV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            MSNV = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            LuongCB = new DataGridViewTextBoxColumn();
            Addbtn = new Button();
            Editbtn = new Button();
            Deletebtn = new Button();
            Closebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MSNV, TenNV, LuongCB });
            dataGridView1.Location = new Point(32, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(664, 614);
            dataGridView1.TabIndex = 0;
            // 
            // MSNV
            // 
            MSNV.HeaderText = "MSNV";
            MSNV.MinimumWidth = 8;
            MSNV.Name = "MSNV";
            MSNV.Width = 200;
            // 
            // TenNV
            // 
            TenNV.HeaderText = "Tên NV";
            TenNV.MinimumWidth = 8;
            TenNV.Name = "TenNV";
            TenNV.Width = 200;
            // 
            // LuongCB
            // 
            LuongCB.HeaderText = "Lương CB";
            LuongCB.MinimumWidth = 8;
            LuongCB.Name = "LuongCB";
            LuongCB.Width = 200;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(771, 66);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(181, 34);
            Addbtn.TabIndex = 1;
            Addbtn.Text = "Thêm";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Editbtn
            // 
            Editbtn.Location = new Point(771, 160);
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(181, 34);
            Editbtn.TabIndex = 2;
            Editbtn.Text = "Sửa";
            Editbtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(771, 272);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(181, 34);
            Deletebtn.TabIndex = 3;
            Deletebtn.Text = "Xoá";
            Deletebtn.UseVisualStyleBackColor = true;
            // 
            // Closebtn
            // 
            Closebtn.Location = new Point(771, 386);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(181, 34);
            Closebtn.TabIndex = 4;
            Closebtn.Text = "Đóng";
            Closebtn.UseVisualStyleBackColor = true;
            // 
            // QLNV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 678);
            Controls.Add(Closebtn);
            Controls.Add(Deletebtn);
            Controls.Add(Editbtn);
            Controls.Add(Addbtn);
            Controls.Add(dataGridView1);
            Name = "QLNV";
            Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Addbtn;
        private Button Editbtn;
        private Button Deletebtn;
        private Button Closebtn;
        private DataGridViewTextBoxColumn MSNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn LuongCB;
    }
}
