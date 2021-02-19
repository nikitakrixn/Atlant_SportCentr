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
using Atlant_Project.Forms.Group;
using Atlant_Project.Class;
using System.Data.SqlClient;
using System.Data.Entity.Core;

namespace Atlant_Project.Forms.UserInterface
{
    public partial class Groups_uc : UserControl
    {
        private AtlantEntities database;

        public Groups_uc()
        {
            database = new AtlantEntities();

            InitializeComponent();
        }
        private DataTable Select()
        {
            DataTable dt = new DataTable();
            string query = "Exec Group_Select";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_raspisania || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                int id = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    string messege = string.Format("Удалить группу {0}", grid.CurrentRow.Cells[1].Value.ToString());
                    if (MessageBox.Show(messege, "Подтверждение удаления",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Удалить выбранные строку
                        Groups group = database.Groups
                        .Where(g => g.group_id == id)
                        .FirstOrDefault();

                        database.Groups.Remove(group);
                    }
                    // Сохранить изменения
                    if (database.ChangeTracker.HasChanges())
                    {
                        if (database.SaveChanges() > 0)
                        {
                            Bunifu.Snackbar.Show(this.FindForm(), "Группа успешно удалёна.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                        }
                        else
                        {
                            Bunifu.Snackbar.Show(this.FindForm(), "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                        }
                    }
                }
                catch (Exception ex)
                { Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error); }
                finally
                {
                    PopulateDatatoDatagrid();
                }
            }
        }

        private void btnListGroup_Click(object sender, EventArgs e)
        {
            frmListGroup frmListGroup = new frmListGroup();
            frmListGroup.groupid = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
            new PopupEffect.transparentBg(this, frmListGroup);
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
                new PopupEffect.transparentBg(this, new frmAddGroup());
                PopulateDatatoDatagrid();
            }
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
            if (Settings.UserRole.guest || Settings.UserRole.manager_clientov || Settings.UserRole.manager_raspisania || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
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

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearch.Text);
        }

        private void TxtSearch_TextChange(object sender, EventArgs e)
        {
            (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", txtSearch.Text);
        }
    }
}
