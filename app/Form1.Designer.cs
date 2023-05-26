namespace app
{
    partial class Form1
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
            FTitle = new Label();
            panel1 = new Panel();
            BoxLop = new ComboBox();
            BoxKhoa = new ComboBox();
            BtnSearch = new Button();
            BtnClear = new Button();
            TxtLop = new Label();
            TxtKhoa = new Label();
            Title = new Label();
            listView1 = new ListView();
            ColMSSV = new ColumnHeader();
            ColHoTen = new ColumnHeader();
            ColNgaySinh = new ColumnHeader();
            ColDiaChi = new ColumnHeader();
            currentLop = new Label();
            btnAdd = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FTitle
            // 
            FTitle.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FTitle.Location = new Point(12, 9);
            FTitle.Name = "FTitle";
            FTitle.Size = new Size(180, 64);
            FTitle.TabIndex = 0;
            FTitle.Text = "Trường đại học Gia Định";
            FTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BoxLop);
            panel1.Controls.Add(BoxKhoa);
            panel1.Controls.Add(BtnSearch);
            panel1.Controls.Add(BtnClear);
            panel1.Controls.Add(TxtLop);
            panel1.Controls.Add(TxtKhoa);
            panel1.Location = new Point(12, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 196);
            panel1.TabIndex = 1;
            // 
            // BoxLop
            // 
            BoxLop.FormattingEnabled = true;
            BoxLop.Location = new Point(77, 93);
            BoxLop.Name = "BoxLop";
            BoxLop.Size = new Size(249, 28);
            BoxLop.TabIndex = 7;
            BoxLop.SelectedIndexChanged += BoxLop_SelectedIndexChanged;
            // 
            // BoxKhoa
            // 
            BoxKhoa.FormattingEnabled = true;
            BoxKhoa.Location = new Point(77, 29);
            BoxKhoa.Name = "BoxKhoa";
            BoxKhoa.Size = new Size(249, 28);
            BoxKhoa.TabIndex = 6;
            BoxKhoa.SelectedIndexChanged += BoxKhoa_SelectedIndexChanged;
            // 
            // BtnSearch
            // 
            BtnSearch.Enabled = false;
            BtnSearch.FlatStyle = FlatStyle.Popup;
            BtnSearch.Location = new Point(232, 143);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(94, 29);
            BtnSearch.TabIndex = 5;
            BtnSearch.Text = "Tìm";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.Red;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.ForeColor = SystemColors.Control;
            BtnClear.Location = new Point(21, 143);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(94, 29);
            BtnClear.TabIndex = 4;
            BtnClear.Text = "Xóa";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // TxtLop
            // 
            TxtLop.AutoSize = true;
            TxtLop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtLop.Location = new Point(21, 88);
            TxtLop.Name = "TxtLop";
            TxtLop.Size = new Size(45, 28);
            TxtLop.TabIndex = 2;
            TxtLop.Text = "Lớp";
            // 
            // TxtKhoa
            // 
            TxtKhoa.AutoSize = true;
            TxtKhoa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtKhoa.Location = new Point(21, 25);
            TxtKhoa.Name = "TxtKhoa";
            TxtKhoa.Size = new Size(57, 28);
            TxtKhoa.TabIndex = 0;
            TxtKhoa.Text = "Khóa";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(755, 9);
            Title.Name = "Title";
            Title.Size = new Size(269, 38);
            Title.TabIndex = 3;
            Title.Text = "Danh sách học sinh";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColMSSV, ColHoTen, ColNgaySinh, ColDiaChi });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(479, 105);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(772, 384);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ColMSSV
            // 
            ColMSSV.Text = "MSSV";
            // 
            // ColHoTen
            // 
            ColHoTen.Text = "Họ và tên";
            // 
            // ColNgaySinh
            // 
            ColNgaySinh.Text = "Ngày sinh";
            ColNgaySinh.Width = 100;
            // 
            // ColDiaChi
            // 
            ColDiaChi.Text = "Địa chỉ";
            // 
            // currentLop
            // 
            currentLop.AutoSize = true;
            currentLop.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            currentLop.Location = new Point(847, 66);
            currentLop.Name = "currentLop";
            currentLop.Size = new Size(0, 28);
            currentLop.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LimeGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(1149, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 35);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+ Thêm ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1263, 539);
            Controls.Add(btnAdd);
            Controls.Add(currentLop);
            Controls.Add(listView1);
            Controls.Add(Title);
            Controls.Add(panel1);
            Controls.Add(FTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FTitle;
        private Panel panel1;
        private Label TxtLop;
        private Label TxtKhoa;
        private Button BtnSearch;
        private Button BtnClear;
        private Label Title;
        private ListView listView1;
        private ColumnHeader ColMSSV;
        private ColumnHeader ColHoTen;
        private ColumnHeader ColNgaySinh;
        private ColumnHeader ColDiaChi;
        private ComboBox BoxLop;
        private ComboBox BoxKhoa;
        private Label currentLop;
        private Button btnAdd;
    }
}