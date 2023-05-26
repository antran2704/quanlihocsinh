namespace app
{
    partial class ThemSinhVien2
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
            panel1 = new Panel();
            btnSave = new Button();
            btnBack = new Button();
            btnClear = new Button();
            txtDiaChi = new TextBox();
            label6 = new Label();
            txtDate = new DateTimePicker();
            label5 = new Label();
            txtHoTen = new TextBox();
            label4 = new Label();
            BoxLop = new ComboBox();
            label3 = new Label();
            BoxKhoa = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 0;
            label1.Text = "Thêm sinh viên";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtHoTen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BoxLop);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BoxKhoa);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(5, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 330);
            panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.YellowGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(414, 287);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 40);
            btnSave.TabIndex = 12;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Highlight;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(8, 287);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 40);
            btnBack.TabIndex = 11;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(414, 197);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 39);
            btnClear.TabIndex = 10;
            btnClear.Text = "Hủy";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Location = new Point(353, 119);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(171, 27);
            txtDiaChi.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(298, 119);
            label6.Name = "label6";
            label6.Size = new Size(40, 23);
            label6.TabIndex = 8;
            label6.Text = "Đ/C";
            // 
            // txtDate
            // 
            txtDate.Format = DateTimePickerFormat.Short;
            txtDate.Location = new Point(101, 197);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(171, 27);
            txtDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 200);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 6;
            label5.Text = "Ngày sinh";
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Location = new Point(101, 115);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(171, 27);
            txtHoTen.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 116);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 4;
            label4.Text = "Họ và Tên";
            // 
            // BoxLop
            // 
            BoxLop.FormattingEnabled = true;
            BoxLop.Location = new Point(353, 26);
            BoxLop.Name = "BoxLop";
            BoxLop.Size = new Size(171, 28);
            BoxLop.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.6F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(298, 26);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 2;
            label3.Text = "Lớp";
            // 
            // BoxKhoa
            // 
            BoxKhoa.FormattingEnabled = true;
            BoxKhoa.Location = new Point(101, 26);
            BoxKhoa.Name = "BoxKhoa";
            BoxKhoa.Size = new Size(171, 28);
            BoxKhoa.TabIndex = 1;
            BoxKhoa.SelectedIndexChanged += BoxKhoa_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.6F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 26);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 0;
            label2.Text = "Khóa học";
            // 
            // ThemSinhVien2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ThemSinhVien2";
            Text = "ThemSinhVien2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private ComboBox BoxKhoa;
        private Label label2;
        private Label label4;
        private ComboBox BoxLop;
        private Button btnSave;
        private Button btnBack;
        private Button btnClear;
        private TextBox txtDiaChi;
        private Label label6;
        private DateTimePicker txtDate;
        private Label label5;
        private TextBox txtHoTen;
    }
}