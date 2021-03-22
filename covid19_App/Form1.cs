using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace covid19_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\90538\Desktop\Excel ile veri çekme\TürkiyeCovid19.xlsx;Extended Properties='Excel 12.0 Xml; HDR=YES;'");
        void veriler()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Table 0$]",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            veriler();
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateSecili_onValueChanged(object sender, EventArgs e)
        {
            

            
            

        }

        private void datee_onValueChanged(object sender, EventArgs e)
        {

        }

        private void dateSecili_ValueChanged(object sender, EventArgs e)
        {

            TimeSpan fark;
            fark = DateTime.Parse(date2.Text) - DateTime.Parse(dateSecili.Text);
            int x = int.Parse(fark.TotalDays.ToString());

            int i = x;

            string tar = Properties.Settings.Default.covTarih = dataGridView1.Rows[i].Cells[0].Value.ToString(); // tarih
            int ttest = Properties.Settings.Default.covToplaTest = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()); // toplam test
            int tvaka = Properties.Settings.Default.covToplamVaka = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()); // toplam vaka
            int tvefat = Properties.Settings.Default.covToplamVefat = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()); // toplam vefat 
            double zatur = Properties.Settings.Default.covZature = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()); // zatürre
            int agir = Properties.Settings.Default.covAgirHasta = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()); // ağır hasta sayısı
            int tiyiles = Properties.Settings.Default.covToplamİyilesen = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()); // toplam iyileşen
            int bhasta = Properties.Settings.Default.covBugunkuHasta = int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()); // bugünkü hasta
            int btest = Properties.Settings.Default.covBugunkuTest = int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()); // bugünkü test
            int bvefat = Properties.Settings.Default.covBugunVefat = int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString()); // bugun vefat eden sayısı
            int biyiles = Properties.Settings.Default.covBugunİyilesen = int.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()); // bugun iyileşen sayısı.

            ////////////////////////////////

            lblAgirHasta.Text = agir.ToString();
            lblBugunHasta.Text = bhasta.ToString();
            lblBugunTest.Text = btest.ToString();
            lblBugunVefat.Text = bvefat.ToString();
            lblBugunİyilesen.Text = biyiles.ToString();
            lblTarih.Text = tar;
            lblToplamTest.Text = ttest.ToString();
            lblToplamVaka.Text = tvaka.ToString();
            lblToplamVefat.Text = tvefat.ToString();
            lblToplamİyilesen.Text = tiyiles.ToString();
            lblZaturre.Text = zatur.ToString();

            ///////////////////////////////////
            int vk, ol, zt, iy;
            vk = ((ttest) / (tvaka));
            barVaka.Value = vk;
            //
            zt = Convert.ToInt32(zatur);
            barZaturre.Value = zt;
            //
            ol = (bhasta) / (bvefat);
            barOlum.Value = ol;
            iy = (biyiles) / (bhasta);
            barİyilesen.Value = iy;
        }
    }
}
