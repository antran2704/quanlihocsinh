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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace app
{
    public partial class Report : Form
    {
        int stt = 1;
        public Report(string khoa, string lop, string ngaythangnam)
        {
            InitializeComponent();
            HandleConectDB();
            handleGetHocSinh(lop);

            txtKhoa.Text = khoa;
            txtLop.Text = lop;
            txtNgay.Text = ngaythangnam;
        }

        private MongoClient client;
        private IMongoDatabase database;

        public void HandleConectDB()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("Quanlihocsinh");
        }

        public void handleGetHocSinh(string Lop)
        {
            var collection = database.GetCollection<BsonDocument>("HocSinhs");
            var filter = Builders<BsonDocument>.Filter
                .Eq("lop", Lop);
            var documents = collection.Find(filter).ToList();

            txtSL.Text = documents.Count.ToString();

            foreach (BsonDocument document in documents)
            {
                var index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = stt;
                dataGridView1.Rows[index].Cells[1].Value = document["mssv"];
                dataGridView1.Rows[index].Cells[2].Value = document["ten"];
                dataGridView1.Rows[index].Cells[3].Value = DateTime.Parse(document["ngaysinh"].ToString()).ToShortDateString();
                dataGridView1.Rows[index].Cells[4].Value = document["diachi"];

                stt++;
            }
        }
    }
}
