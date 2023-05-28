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

namespace app
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            HandleConectDB();
        }

        private MongoClient client;
        private IMongoDatabase database;

        public void HandleConectDB()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("Quanlihocsinh");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTen.Text;
            string password = txtMatKhau.Text;

            var collection = database.GetCollection<BsonDocument>("TaiKhoans");
            var filter = Builders<BsonDocument>.Filter
                .Eq("userName", userName) & Builders<BsonDocument>.Filter
                .Eq("password", password);
            
            var document = collection.Find(filter).ToList();

            if(document.Count > 0)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Không tồn tại tài khoản này!!!", "Thông báo");
            }
        }
    }

}
