using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atlant_Project.Forms.Admin;
using Atlant_Project.EntityFramework;
using Atlant_Project.Class;

namespace Atlant_Project.Forms.UserInterface
{
    public partial class Admin_uc : UserControl
    {
        private AtlantEntities database;

        public Admin_uc()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new PopupEffect.transparentBg(this, new frmAddUser());
            PopulateDatatoDatagrid();
        }

        public void PopulateDatatoDatagrid()
        {
            var results = database.Users_Select();
            grid.DataSource = results.ToList();
        }

        private void btnVivod_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.admin_new)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                PopulateDatatoDatagrid();
            }
        }
    }
}
