using Atlant_Project.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlant_Project.Forms.Trainer
{
    public partial class frmAddTrainer : Form
    {
        private AtlantEntities database;

        public frmAddTrainer()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            try
            {
                database.Instructor.Add(
              new Instructor()
              {
                  trainer_id = database.Instructor.Count(),
                  FirstName = txtName.Text.Trim(),
                  LastName = txtLastName.Text.Trim(),
                  Phone = txtPhone.Text.Trim(),
                  Vid_sporta = txtVidSporta.Text.Trim(),
                  Exp = int.Parse(txtExp.Text.Trim()),
              }
             );
            }
            catch (EntityException ex)
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
