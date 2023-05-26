namespace app
{
    partial class SuaThongTin
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
            txtTitle = new Label();
            panel1 = new Panel();
            txtNgaySinh = new DateTimePicker();
            label2 = new Label();
            txtMssv = new TextBox();
            label1 = new Label();
            btnLuu = new Button();
            btnXoa = new Button();
            txtDiaChi = new TextBox();
            txtTen = new TextBox();
            BoxLop = new ComboBox();
            BoxKhoa = new ComboBox();
            labelTen = new Label();
            labelLop = new Label();
            labelDiaChi = new Label();
            lableKhoa = new Label();
            txtSubTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.AllowDrop = true;
            txtTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(181, 9);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(260, 35);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Thông tin của sinh viên";
            txtTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtNgaySinh);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMssv);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(txtTen);
            panel1.Controls.Add(BoxLop);
            panel1.Controls.Add(BoxKhoa);
            panel1.Controls.Add(labelTen);
            panel1.Controls.Add(labelLop);
            panel1.Controls.Add(labelDiaChi);
            panel1.Controls.Add(lableKhoa);
            panel1.Location = new Point(12, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 304);
            panel1.TabIndex = 1;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Format = DateTimePickerFormat.Short;
            txtNgaySinh.Location = new Point(98, 167);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(175, 27);
            txtNgaySinh.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 167);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 12;
            label2.Text = "Sinh ngày ";
            // 
            // txtMssv
            // 
            txtMssv.BorderStyle = BorderStyle.FixedSingle;
            txtMssv.Location = new Point(344, 167);
            txtMssv.Name = "txtMssv";
            txtMssv.Size = new Size(189, 27);
            txtMssv.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(283, 167);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 10;
            label1.Text = "MSSV";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LimeGreen;
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = SystemColors.ButtonHighlight;
            btnLuu.Location = new Point(423, 249);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 40);
            btnLuu.TabIndex = 9;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.ButtonFace;
            btnXoa.Location = new Point(10, 249);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(344, 100);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(189, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(98, 101);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(175, 27);
            txtTen.TabIndex = 6;
            // 
            // BoxLop
            // 
            BoxLop.FormattingEnabled = true;
            BoxLop.Location = new Point(344, 30);
            BoxLop.Name = "BoxLop";
            BoxLop.Size = new Size(189, 28);
            BoxLop.TabIndex = 5;
            BoxLop.SelectedIndexChanged += BoxLop_SelectedIndexChanged;
            // 
            // BoxKhoa
            // 
            BoxKhoa.FormattingEnabled = true;
            BoxKhoa.Location = new Point(98, 29);
            BoxKhoa.Name = "BoxKhoa";
            BoxKhoa.Size = new Size(175, 28);
            BoxKhoa.TabIndex = 4;
            BoxKhoa.SelectedIndexChanged += BoxKhoa_SelectedIndexChanged;
            // 
            // labelTen
            // 
            labelTen.AutoSize = true;
            labelTen.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTen.Location = new Point(10, 100);
            labelTen.Name = "labelTen";
            labelTen.Size = new Size(87, 23);
            labelTen.TabIndex = 3;
            labelTen.Text = "Họ và Tên";
            // 
            // labelLop
            // 
            labelLop.AutoSize = true;
            labelLop.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelLop.Location = new Point(300, 34);
            labelLop.Name = "labelLop";
            labelLop.Size = new Size(38, 23);
            labelLop.TabIndex = 2;
            labelLop.Text = "Lớp";
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelDiaChi.Location = new Point(298, 100);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(40, 23);
            labelDiaChi.TabIndex = 1;
            labelDiaChi.Text = "Đ/C";
            // 
            // lableKhoa
            // 
            lableKhoa.AutoSize = true;
            lableKhoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lableKhoa.Location = new Point(10, 30);
            lableKhoa.Name = "lableKhoa";
            lableKhoa.Size = new Size(82, 23);
            lableKhoa.TabIndex = 0;
            lableKhoa.Text = "Khóa học";
            // 
            // txtSubTitle
            // 
            txtSubTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubTitle.ImageAlign = ContentAlignment.BottomRight;
            txtSubTitle.Location = new Point(211, 44);
            txtSubTitle.Name = "txtSubTitle";
            txtSubTitle.Size = new Size(204, 56);
            txtSubTitle.TabIndex = 2;
            txtSubTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // SuaThongTin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 450);
            Controls.Add(txtSubTitle);
            Controls.Add(panel1);
            Controls.Add(txtTitle);
            Name = "SuaThongTin";
            Text = "SuaThongTin";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label txtTitle;
        private Panel panel1;
        private ComboBox BoxKhoa;
        private Label labelTen;
        private Label labelLop;
        private Label labelDiaChi;
        private Label lableKhoa;
        private ComboBox BoxLop;
        private TextBox txtTen;
        private TextBox txtDiaChi;
        private Button btnLuu;
        private Button btnXoa;
        private Label txtSubTitle;
        private TextBox txtMssv;
        private Label label1;
        private Label label2;
        private DateTimePicker txtNgaySinh;
    }
}