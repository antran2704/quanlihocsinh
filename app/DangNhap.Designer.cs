namespace app
{
    partial class DangNhap
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
            txtTen = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(36, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(102, 91);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(250, 27);
            txtTen.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Location = new Point(102, 140);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(250, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.MenuHighlight;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = SystemColors.ButtonFace;
            btnDangNhap.Location = new Point(293, 218);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(138, 42);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 272);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "DangNhap";
            Text = "DangNhap";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTen;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
    }
}