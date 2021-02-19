using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atlant_Project.EntityFramework;
using Atlant_Project.Class;
using Atlant_Project.Forms.Trainer;
using System.Data.SqlClient;

namespace Atlant_Project.Forms.UserInterface
{
    public partial class Trainers_uc : UserControl
    {
        private AtlantEntities database;

        public Trainers_uc()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            string query = "Exec Coachs_Select";
            SqlConnection connect = new SqlConnection(Settings.SettingsConnect.ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                connect.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return dt;
        }

        public void PopulateDatatoDatagrid()
        {
           
            grid.DataSource = Select();
        }

        private void copyAlltoClipboard()
        {
            grid.SelectAll();
            DataObject dataObj = grid.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_clientov || Settings.UserRole.manager_raspisania || Settings.UserRole.manager_sections || Settings.UserRole.manager_group)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_clientov || Settings.UserRole.manager_sections || Settings.UserRole.manager_group)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                new PopupEffect.transparentBg(this, new frmAddTrainer());
                PopulateDatatoDatagrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_clientov || Settings.UserRole.manager_raspisania || Settings.UserRole.manager_sections || Settings.UserRole.manager_group)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                int id = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    string messege = string.Format("Удалить тренера {0} {1}", grid.CurrentRow.Cells[1].Value.ToString(), grid.CurrentRow.Cells[2].Value.ToString());
                    if (MessageBox.Show(messege, "Подтверждение удаления",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Удалить выбранные строку
                        Instructor trainer = database.Instructor
                        .Where(c => c.trainer_id == id)
                        .FirstOrDefault();

                        database.Instructor.Remove(trainer);
                    }
                }
                catch (Exception ex)
                { Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error); }
                finally
                {
                    // Сохранить изменения
                    if (database.ChangeTracker.HasChanges())
                    {
                        if (database.SaveChanges() > 0)
                        {
                            Bunifu.Snackbar.Show(this.FindForm(), "Тренер успешно удалён.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                        }
                    }
                    PopulateDatatoDatagrid();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_clientov || Settings.UserRole.manager_raspisania || Settings.UserRole.manager_sections || Settings.UserRole.manager_group)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                frmEditTrainer frmEdit = new frmEditTrainer();
                frmEdit.trainerid = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                frmEdit.txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
                frmEdit.txtLastName.Text = grid.CurrentRow.Cells[2].Value.ToString();
                frmEdit.txtPhone.Text = grid.CurrentRow.Cells[3].Value.ToString();
                frmEdit.txtExp.Text = grid.CurrentRow.Cells[4].Value.ToString();
                frmEdit.txtVidSporta.Text = grid.CurrentRow.Cells[5].Value.ToString();
                new PopupEffect.transparentBg(this, frmEdit);
                PopulateDatatoDatagrid();
            }
        }

        private void txtSearch_TextChange(object sender, EventArgs e)
        {
            (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Имя LIKE '%{0}%' OR Фамилия Like '%{1}%'", txtSearch.Text, txtSearch.Text);
        }
    }
}
