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

namespace Atlant_Project.Forms.Group
{
    public partial class frmAddClientGroup : Form
    {
        private AtlantEntities database;

        public int groupid;

        private int clientid;

        public frmAddClientGroup()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddClientGroup_Load(object sender, EventArgs e)
        {
            var clients = database.Customer.Select(c => new {
            Display = c.FirstName + " " + c.LastName , Value = c.customer_id}).ToList();
            ddClients.DataSource = clients;
            ddClients.ValueMember = "Value";
            ddClients.DisplayMember = "Display";
            ddClients.SelectedValue = -1;
            ddClients.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            clientid = Convert.ToInt32(ddClients.SelectedValue);

            database.Client_in_Group.Add(
                new Client_in_Group()
                {
                    clients_group_id = database.Client_in_Group.Count(),
                    Client_id = clientid,
                    Group_id = groupid,
                }
            );

            // Сохранить изменения
            if (database.SaveChanges() > 0)
            {
                Bunifu.Snackbar.Show(this.FindForm(), ddClients.Text.Trim() + " Успешно Добавлен.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
            }
            else
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не удалось проверить соединение с базой данных.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
        }
    }
}
