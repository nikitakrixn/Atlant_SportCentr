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
    public partial class frmAddGroup : Form
    {
        private AtlantEntities database;

        public frmAddGroup()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            int maxkol = int.Parse(txtMaxKolvo.Text);
            if (txtName.Text.Length >= 3 && txtMaxKolvo.Text.Length >= 1)
            {
                try
                {
                    database.Groups.Add(
                      new Groups
                      {
                          group_id = database.Groups.Count(),
                          Name = txtName.Text.Trim(),
                          Max_kol = maxkol,
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

        private void txtMaxKolvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
