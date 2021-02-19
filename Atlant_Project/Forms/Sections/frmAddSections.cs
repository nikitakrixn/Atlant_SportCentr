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

namespace Atlant_Project.Forms.Sections
{
    public partial class frmAddSections : Form
    {
        private AtlantEntities database;
        public frmAddSections()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            try
            {
                database.Sections.Add(
              new EntityFramework.Sections()
              {
                  sections_id = database.Sections.Count(),
                  Name = txtName.Text.Trim(),
                  Description = txtDesc.Text.Trim(),
              }
             );
            }
            catch (Exception ex)
            {
                Bunifu.Snackbar.Show(this.FindForm(), ex.Message, 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            finally
            {
                if (database.SaveChanges() > 0)
                {
                    Bunifu.Snackbar.Show(this.FindForm(), txtName.Text.Trim() + " Успешно Добавлен.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                }
            }
        }
    }
}
