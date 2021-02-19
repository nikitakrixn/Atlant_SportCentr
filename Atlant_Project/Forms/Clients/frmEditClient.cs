using Atlant_Project.EntityFramework;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Atlant_Project.Forms.Clients
{
    public partial class frmEditClient : Form
    {
        private AtlantEntities database;
        public int customerid;
        public string gender;

        public frmEditClient()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (isMale.Checked == true) gender = "М";
            else gender = "Ж";
            if (txtName.Text.Length > 3 && txtLastName.Text.Length > 3 && txtPhone.Text.Length > 3 && txtAddress.Text.Length > 3)
            {
                try
                {
                    var client = database.Customer
                      .Where(c => c.customer_id == customerid)
                      .FirstOrDefault();

                    client.customer_id = customerid;
                    client.FirstName = txtName.Text.Trim();
                    client.LastName = txtLastName.Text.Trim();
                    client.Phone = txtPhone.Text.Trim();
                    client.Gender = gender;
                    client.Address = txtAddress.Text.Trim();

                    if (database.SaveChanges() > 0)
                        Bunifu.Snackbar.Show(this.FindForm(), "Клиент " + txtName.Text.Trim() + " " + txtLastName.Text + " Успешно Изменён.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Ошибка, проверьте чтобы все поля были заполнены.");
        }

        private void FrmEditClient_Load(object sender, EventArgs e)
        {
            if (gender == "Ж") isFemale.Checked = true;
            if (gender == "М") isMale.Checked = true;
        }

        private void IsMale_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (isMale.Checked == true) isFemale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            else isFemale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
        }

        private void IsFemale_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (isFemale.Checked == true) isMale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            else isMale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
        }
    }
}
