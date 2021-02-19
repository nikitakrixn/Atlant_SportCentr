using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Atlant_Project.EntityFramework;
using Atlant_Project.Forms.Clients;
using Atlant_Project.Class;
using System.Data.Entity.Core;
using System.Data.SqlClient;

namespace Atlant_Project.Forms.UserInterface
{
    public partial class Clients_uc : UserControl
    {
        private AtlantEntities database;

        public Clients_uc()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }
        private DataTable Select()
        {
            DataTable dt = new DataTable();
            string query = "Exec Client_Select";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest ||  Settings.UserRole.manager_group || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                try
                {
                    new PopupEffect.transparentBg(this, new frmAddClient());
                }
                catch(Exception ex)
                {
                    Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                }
                finally
                {
                    PopulateDatatoDatagrid();
                }
                
            }
        }

        public void PopulateDatatoDatagrid()
        {
            //var results = database.Client_Select(null);
            grid.DataSource = Select();
            
        }

        private void Clients_uc_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_group || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                int id = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    string messege = string.Format("Удалить клиента {0} {1}", grid.CurrentRow.Cells[1].Value.ToString(), grid.CurrentRow.Cells[2].Value.ToString());
                    if (MessageBox.Show(messege, "Подтверждение удаления",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Удалить выбранные строку
                        Customer client = database.Customer
                        .Where(c => c.customer_id == id)
                        .FirstOrDefault();
                        database.Customer.Remove(client);
                    }
                    // Сохранить изменения
                    if (database.ChangeTracker.HasChanges())
                    {
                        if (database.SaveChanges() > 0)
                        {
                            Bunifu.Snackbar.Show(this.FindForm(), "Клиент успешно удалён.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                        }
                    }
                }
                catch (SqlException ex)
                { Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error); }
                finally
                {
                    PopulateDatatoDatagrid();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_group || Settings.UserRole.manager_raspisania || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                frmEditClient frmEdit = new frmEditClient();
                frmEdit.customerid = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                frmEdit.txtName.Text = grid.CurrentRow.Cells[1].Value.ToString();
                frmEdit.txtLastName.Text = grid.CurrentRow.Cells[2].Value.ToString();
                frmEdit.txtPhone.Text = grid.CurrentRow.Cells[3].Value.ToString();
                var str = grid.CurrentRow.Cells[4].Value.ToString();
                frmEdit.gender = str.Replace(" ", "");
                frmEdit.txtAddress.Text = grid.CurrentRow.Cells[5].Value.ToString();
                new PopupEffect.transparentBg(this, frmEdit);

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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_group || Settings.UserRole.manager_raspisania || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
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
            if(e.KeyChar == (char)13)
            {
                (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("firstname LIKE '%{0}%' OR lastname LIKE '%{1}%'", txtSearch.Text, txtSearch.Text);
            }
        }
    }
}
