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
    public partial class frmEditTrainer : Form
    {
        private AtlantEntities database;
        public int trainerid;

        public frmEditTrainer()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditTrainer_Click(object sender, EventArgs e)
        {
            try
            {
                database.Coachs_Update(txtName.Text.Trim(), txtLastName.Text.Trim(), txtPhone.Text.Trim(), int.Parse(txtExp.Text.Trim()), txtVidSporta.Text.Trim(), trainerid);
                Bunifu.Snackbar.Show(this.FindForm(), "Тренер " + txtName.Text.Trim() + txtLastName.Text + " Успешно Изменён.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
            }
            catch(Exception ex)
            {
                Bunifu.Snackbar.Show(this.FindForm(), ex.Message, 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
