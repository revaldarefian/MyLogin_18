using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MyLogin_18
{
    public partial class MasterProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog = MyPractice;Integrated Security = True;");

        public MasterProduct()
        {
            InitializeComponent();
        }
        LinkQ1DataContext db = new LinkQ1DataContext();

        private void MasterProduct_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (ID as int)),0) +1 from TB_M_PRODUCT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtProdID.Text = dt.Rows[0][0].ToString();
            LoadData();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProdID.Text);
            string item = txtItemName2.Text;
            string design = txtDesign2.Text;
            string col = cbColor.Text;
            DateTime expiredDate = DateTime.Parse(dtExpired.Text);
            var data = new TB_M_PRODUCT
            {
                ID = id,
                itemName = item,
                color = col,
                deisgn = design,
                expiredDate = expiredDate
            };
            db.TB_M_PRODUCTs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Sukses Menambahkan Barang");
            txtDesign2.Clear();
            txtItemName2.Clear();
            cbColor.Items.Clear();
            LoadData();
        }
        
        void LoadData()
        {
            var st = from tb in db.TB_M_PRODUCTs select tb;
            dgProd.DataSource = st;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var st = from s in db.TB_M_PRODUCTs where s.itemName == txtItemName1.Text || s.deisgn == txtDesign1.Text select s;
            dgProd.DataSource = st;
        }
    }
}
