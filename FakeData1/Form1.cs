using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FakeData1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string isim = FakeData.NameData.GetFirstName();
            //string soyisim = FakeData.NameData.GetSurname();

            //MessageBox.Show(isim + " " + soyisim, " fake");


            Database db = new Database();

            List<Musteri> musteriListe = db.musteriListele();



            dataGridView1.DataSource = musteriListe;

            dataGridView1.Columns["id"].Visible = true;






            //dataGridView1.Columns[0].HeaderText = "Müşteri ID";
            //dataGridView1.Columns[1].HeaderText = "Müşteri isim";
            //dataGridView1.Columns[2].HeaderText = "Müşteri Tam Adı";



            var datagrliste = from I in musteriListe select new { ID=I.id, Isim = I.isim, Soyisim = I.soyisim };

            dataGridView1.DataSource = datagrliste.ToList();

        }
    }
}
