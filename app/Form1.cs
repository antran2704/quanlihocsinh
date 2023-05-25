using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;

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
                { Text = document["ngaysinh"].ToString() }
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
            }
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string lop = BoxLop.SelectedItem.ToString();
            currentLop.Text = lop;
            handleGetHocSinh(lop);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
        }

        private void BoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string khoa = cb.SelectedItem.ToString();

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
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
