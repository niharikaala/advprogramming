using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDental
{
    public partial class Registration : Form
    {
        client model = new client();
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {

            txtFname.Text = txtSname.Text = txtAddress.Text = txtAlergy.Text = txtcity.Text = txtEmail.Text = txtGP.Text = txtGPAd.Text = txtMed.Text = " ";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            model.Fname = txtFname.Text.Trim();
            model.Sname = txtSname.Text.Trim();
            model.Address = txtAddress.Text.Trim();
            model.Email = txtEmail.Text.Trim();
            model.city = txtcity.Text.Trim();
            model.Med = txtMed.Text.Trim();
            model.Alergies = txtAlergy.Text.Trim();
            model.NGP = txtGP.Text.Trim();
            model.AGP = txtGPAd.Text.Trim();
            model.TPlan = txtTplan.Text.Trim();



            
            using (RadiantEntities db = new RadiantEntities())
            { 
            
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
