using Atlant_Project.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlant_Project.Forms.Admin
{
    public partial class frmEditUser : Form
    {
        private AtlantEntities database;

        public frmEditUser()
        {
            InitializeComponent();
            database = new AtlantEntities();
        }
        private void LoadData()
        {
            comboBox1.DataSource = database.Users_Role(1).ToList();
            comboBox1.DisplayMember = "name";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chkPass_OnChange(object sender, EventArgs e)
        {
            if (chkPass.Checked == true) { txtPassword.UseSystemPasswordChar = false; }
            else { txtPassword.UseSystemPasswordChar = true; }
        }
    }
}
