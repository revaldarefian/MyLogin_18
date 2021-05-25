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

namespace MyLogin_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        LinkQ1DataContext db = new LinkQ1DataContext();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = (from s in db.TB_M_USERs where s.username == txtUname.Text select s).First();
            if(user.password == txtPass.Text)
            {
                MessageBox.Show("Login Berhasil");
                this.Hide();
                MasterProduct a = new MasterProduct();
                a.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
