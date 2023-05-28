using MongoDB.Bson;
using MongoDB.Driver;

namespace app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HandleConectDB();
            HandleGetKhoa();
        }

        private MongoClient client;
        private IMongoDatabase database;

        public void HandleConectDB()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("Quanlihocsinh");
        }

        public void HandleGetKhoa()
        {
            var collection = database.GetCollection<BsonDocument>("Khoas");
            var documents = collection.AsQueryable().ToList();

            if (documents.Count > 0)
            {
                foreach (BsonDocument document in documents)
                {
                    BoxKhoa.Items.Add(document["ten"]);
                }
            }
            else
            {
                BoxKhoa.Items.Clear();
            }
        }

        public void handleGetHocSinh(string Lop)
        {
            var collection = database.GetCollection<BsonDocument>("HocSinhs");
            var filter = Builders<BsonDocument>.Filter
                .Eq("lop", Lop);
            var documents = collection.Find(filter).ToList();
            listView1.Items.Clear();

            foreach (BsonDocument document in documents)
            {
                ListViewItem item = new ListViewItem();
                item.Text = document["mssv"].ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                { Text = document["ten"].ToString() }
                );
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                { Text = DateTime.Parse(document["ngaysinh"].ToString()).ToShortDateString() }
                );
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                { Text = document["diachi"].ToString() }
                );
                listView1.Items.Add(item);
            }
        }

        public void handleGetLop(string Khoa)
        {
            var collection = database.GetCollection<BsonDocument>("Lops");
            var filter = Builders<BsonDocument>.Filter
                .Eq("khoa", Khoa);
            var documents = collection.Find(filter).ToList();

            if (documents.Count > 0)
            {
                foreach (BsonDocument document in documents)
                {
                    BoxLop.Items.Add(document["ten"]);
                }
            }
            else
            {
                BoxLop.Text = "";
                BoxLop.Items.Clear();
                BtnSearch.Enabled = false;
                BtnReport.Enabled = false;
            }
        }


        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            string lop = BoxLop.SelectedItem.ToString();
            currentLop.Text = lop;
            BtnReport.Enabled = true;
            handleGetHocSinh(lop);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            BoxKhoa.Text = "";
            BoxLop.Text = "";
            BoxLop.Items.Clear();
            BtnSearch.Enabled = false;
            BtnReport.Enabled = false;
        }

        private void BoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string khoa = cb.SelectedItem.ToString();
            BoxLop.Text = "";
            BoxLop.Items.Clear();
            handleGetLop(khoa);
        }

        private void BoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string value = cb.SelectedItem.ToString();

            if (value != null)
            {
                BtnSearch.Enabled = true;
            }
            else
            {
                BtnSearch.Enabled = false;
                BtnReport.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[1].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[2].Width = (int)(listView1.Width * 0.25);
            listView1.Columns[3].Width = (int)(listView1.Width * 0.25);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string mssv = listView1.SelectedItems[0].SubItems[0].Text;
                string ten = listView1.SelectedItems[0].SubItems[1].Text;
                string ngaysinh = listView1.SelectedItems[0].SubItems[2].Text;
                string diachi = listView1.SelectedItems[0].SubItems[3].Text;

                HocSinh data = new HocSinh()
                {
                    ten = ten,
                    mssv = mssv,
                    diachi = diachi,
                    khoa = BoxKhoa.SelectedItem.ToString(),
                    lop = BoxLop.SelectedItem.ToString(),
                    ngaysinh = ngaysinh
                };

                SuaThongTin form = new SuaThongTin(data);
                form.Show();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ThemSinhVien2 form = new ThemSinhVien2();
            this.Hide();
            form.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string khoa = BoxKhoa.SelectedItem.ToString();
            string lop = BoxLop.SelectedItem.ToString();
            string ngaythangnam = "Ngày " + DateTime.Now.Day.ToString() +
                                    " tháng " + DateTime.Now.Month.ToString() +
                                    " năm " + DateTime.Now.Year.ToString();
            Report reportForm = new Report(khoa, lop, ngaythangnam);
            reportForm.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap form = new DangNhap();
            form.Show();
            this.Close();
        }
    }
}
