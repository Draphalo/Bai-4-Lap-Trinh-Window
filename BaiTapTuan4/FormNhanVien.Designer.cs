namespace BaiTapTuan4
{
    partial class FormNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Acceptbtn = new Button();
            SkipBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 90);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "MSNV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 175);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 270);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 2;
            label3.Text = "Lương căn bản:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(272, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 169);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(361, 31);
            textBox3.TabIndex = 5;
            // 
            // Acceptbtn
            // 
            Acceptbtn.Location = new Point(190, 368);
            Acceptbtn.Name = "Acceptbtn";
            Acceptbtn.Size = new Size(145, 40);
            Acceptbtn.TabIndex = 6;
            Acceptbtn.Text = "Đồng ý";
            Acceptbtn.UseVisualStyleBackColor = true;
            // 
            // SkipBtn
            // 
            SkipBtn.Location = new Point(488, 368);
            SkipBtn.Name = "SkipBtn";
            SkipBtn.Size = new Size(145, 40);
            SkipBtn.TabIndex = 7;
            SkipBtn.Text = "Bỏ qua";
            SkipBtn.UseVisualStyleBackColor = true;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SkipBtn);
            Controls.Add(Acceptbtn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNhanVien";
            Text = "Nhân viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Acceptbtn;
        private Button SkipBtn;
    }
}