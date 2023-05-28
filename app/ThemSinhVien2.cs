using Microsoft.VisualBasic.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace app
{
    public partial class ThemSinhVien2 : Form
    {
        public ThemSinhVien2()
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
            }
        }

        public bool handleCheckMSSV(string mssv)
        {
            var collection = database.GetCollection<BsonDocument>("HocSinhs");
            var filter = Builders<BsonDocument>.Filter
                .Eq("mssv", mssv);
            var document = collection.Find(filter).FirstOrDefault();

            if (document != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void handleClearAllField()
        {
            BoxKhoa.Text = "";
            BoxLop.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
        }

        private void BoxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string khoa = cb.SelectedItem.ToString();
            BoxLop.Items.Clear();
            BoxLop.Text = "";

            handleGetLop(khoa);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (BoxKhoa.SelectedItem != null &&
                BoxLop.SelectedItem != null &&
                BoxKhoa.Text != "" &&
                BoxLop.Text != "" &&
                txtHoTen.Text != "" &&
                txtDiaChi.Text != ""
                )
            {
                string khoa = BoxKhoa.SelectedItem.ToString();
                string lop = BoxLop.SelectedItem.ToString();
                string ten = txtHoTen.Text;
                string ngaySinh = txtDate.Value.ToString();
                string diaChi = txtDiaChi.Text;

                 var collection = database.GetCollection<BsonDocument>("HocSinhs");
                 var documents = collection.AsQueryable().ToList();
                    HocSinh test = new HocSinh()
                    {
                        ten = ten,
                        lop = lop,
                        diachi = diaChi,
                        khoa = khoa,
                        mssv = (documents.Count + 1).ToString(),
                        ngaysinh = ngaySinh
                    };
                  await collection.InsertOneAsync(test.ToBsonDocument());
                  handleClearAllField();
                  MessageBox.Show("Thêm thành công", "Thông báo");
                }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            handleClearAllField();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
