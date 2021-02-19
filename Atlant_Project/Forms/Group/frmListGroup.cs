using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Atlant_Project.EntityFramework;
using Atlant_Project.Class;

namespace Atlant_Project.Forms.Group
{
    public partial class frmListGroup : Form
    {
        private AtlantEntities database;

        public int groupid;

        public frmListGroup()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateDatatoDatagrid()
        {
            var results = database.Client_in_Group.Select(r => r).Where(r => r.Groups.group_id == groupid);

            grid.Rows.Clear();
            lblCurGroup.Text = "Название группы: ";
            foreach (var group in results)
            {
                grid.Rows.Add(
                           new object[]
                           {
                                group.Customer.FirstName,
                                group.Customer.LastName,
                           }
                          );
                grid.Rows[grid.RowCount - 1].Tag = group;
            }

            lblCurGroup.Text = lblCurGroup.Text + database.Groups
                .Where(g => g.group_id == groupid)
                .Select(g => g.Name)
                .FirstOrDefault();
        }

        private void frmListGroup_Load(object sender, EventArgs e)
        {
            PopulateDatatoDatagrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {

                frmAddClientGroup frmADD = new frmAddClientGroup();
                frmADD.groupid = groupid;
                new PopupEffectForm.transparentBg(this, frmADD);
                PopulateDatatoDatagrid();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                string messege = string.Format("Удалить клиента {0} {1}", grid.CurrentRow.Cells[1].Value.ToString(), grid.CurrentRow.Cells[2].Value.ToString());
                if (MessageBox.Show(messege, "Подтверждение удаления",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in grid.SelectedRows)
                    {
                        var client = (Client_in_Group)row.Tag;
                        database.Client_in_Group.Remove(client);
                        grid.Rows.Remove(row);
                    }


                    if (database.ChangeTracker.HasChanges())
                    {
                        // Сохранить изменения
                        if (database.SaveChanges() > 0)
                        {
                            Bunifu.Snackbar.Show(this.FindForm(), "Клиент Успешно Удалён.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                        }
                        else
                        {
                            Bunifu.Snackbar.Show(this.FindForm(), "Не удалось проверить соединение с базой данных.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                        }
                    }
                }
            }
        }
    }
}
