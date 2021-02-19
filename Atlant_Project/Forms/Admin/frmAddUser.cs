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
    public partial class frmAddUser : Form
    {
        private AtlantEntities database;

        public frmAddUser()
        {
            InitializeComponent();
            database = new AtlantEntities();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData()
        {
            comboBox1.DataSource = database.Users_Role(1).ToList();
            comboBox1.DisplayMember = "name";
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            try
            {
                database.Users_Insert(txtLogin.Text, txtPassword.Text, comboBox1.Text);
                Bunifu.Snackbar.Show(this.FindForm(), txtLogin.Text.Trim() + " Успешно Добавлен.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
            }
            catch (Exception ex)
            {
                Bunifu.Snackbar.Show(this.FindForm(), ex.Message, 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
        }

        private void chkPass_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (chkPass.Checked == true) { txtPassword.UseSystemPasswordChar = false; }
            else { txtPassword.UseSystemPasswordChar = true; }
        }
    }
}
