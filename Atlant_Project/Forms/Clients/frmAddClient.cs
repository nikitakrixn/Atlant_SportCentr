using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atlant_Project.EntityFramework;
using Atlant_Project.Class;

namespace Atlant_Project.Forms.Clients
{
    public partial class frmAddClient : Form
    {
        private AtlantEntities database;
        private string gender;

        public frmAddClient()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (isMale.Checked == true) gender = "М";
            else gender = "Ж";
            if (txtName.Text.Length >= 3 && txtLastName.Text.Length >= 3 && txtPhone.Text.Length <= 12 && txtAddress.Text.Length > 3)
            {
                try
                {
                    database.Customer.Add(
                  new Customer()
                  {
                      customer_id = database.Customer.Count(),
                      FirstName = txtName.Text.Trim(),
                      LastName = txtLastName.Text.Trim(),
                      Phone = txtPhone.Text.Trim(),
                      Address = txtAddress.Text.Trim(),
                      Gender = gender,
                  }
                 );
                    if (database.SaveChanges() > 0)
                    {
                        Bunifu.Snackbar.Show(this.FindForm(), txtName.Text.Trim() + " Успешно Добавлен.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Ошибка, проверьте чтобы все поля были заполнены.");
        }

        private void isMale_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (isMale.Checked == true) isFemale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            else isFemale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
        }

        private void isFemale_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (isFemale.Checked == true) isMale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            else isMale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
        }
    }
}
