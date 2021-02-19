using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Atlant_Project.EntityFramework;
using DGVPrinterHelper;
using System.Data.SqlClient;
using System.Data.Entity.Core;
using Atlant_Project.Forms.ScheduleE;
using Atlant_Project.Class;

namespace Atlant_Project.Forms.UserInterface
{
    public partial class Schedule_uc : UserControl
    {
        private AtlantEntities database;

        #region Calendar
        private int Monthnow = DateTime.Today.Month; // Узнаём какой сейчас месяц
        private int Yearnow = DateTime.Today.Year; // Узнаём какой сейчас год
        private int Daynow = DateTime.Today.Day; // Узнаём какой сейчас день
        #endregion

        CultureInfo ru = CultureInfo.CreateSpecificCulture("ru-RU");

        private bool trainer_pick = false;
        private bool room_pick = false;

        public Schedule_uc()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private void PrintCurDayAndMonth()
        {
            lblCurDay.Text = Daynow.ToString();
            DateTime time = new DateTime(Yearnow, Monthnow, Daynow);
            lblCurMouth.Text = ru.DateTimeFormat.GetMonthName(Convert.ToInt32(Monthnow)).ToString() + " "
                + Yearnow.ToString()
                + Environment.NewLine
                + ru.DateTimeFormat.GetDayName(time.DayOfWeek);
        }
        //Загрузка с бд
        private void LoadData()
        {
            database.Configuration.ProxyCreationEnabled = false;
            var room = database.Rooms.Select(c => new {
                Display = c.Name,
                Value = c.room_id
            }).ToList();
            cmbSport.DataSource = room;
            cmbSport.ValueMember = "Value";
            cmbSport.DisplayMember = "Display";
            cmbSport.SelectedValue = -1;
            ///
            var trainer = database.Instructor.Select(c => new {
                Display = c.FirstName + " " + c.LastName,
                Value = c.trainer_id
            }).ToList();
            cmbTrainer.DataSource = trainer;
            cmbTrainer.ValueMember = "Value";
            cmbTrainer.DisplayMember = "Display";
            cmbTrainer.SelectedValue = -1;
        }

        public void PopulateDatatoDatagrid()
        {
            try
            {
                DateTime time = new DateTime(Yearnow, Monthnow, Daynow);
                var results = database.Schedule_Select(time);
                grid.DataSource = results.ToList();
                LoadData();
                grid.Columns["ID"].Visible = false;
                pnlSlide.Visible = false;
                this.Visible = true;
            }
            catch(EntityException ex)
            {
                Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                this.Visible = false;
            }
            
        }

        private void Schedule_uc_Load(object sender, EventArgs e)
        {
            PrintCurDayAndMonth();
        }

        private void btnPrevDay_Click(object sender, EventArgs e)
        {
            if (Daynow > 1)
            {
                Daynow --;
                lblCurDay.Text = Daynow.ToString();
            }
            else
            {
                if (Monthnow == 1)
                {
                    Monthnow = 12;
                    Yearnow -= 1;
                }
                else Monthnow -= 1;
                int dayz = DateTime.DaysInMonth(Convert.ToInt32(Yearnow), Convert.ToInt32(Monthnow)); // Узнаём сколько дней в текущем месяце
                lblCurDay.Text = dayz.ToString("D2");
            }
            DateTime time = new DateTime(Yearnow, Monthnow, Daynow);
            lblCurMouth.Text = ru.DateTimeFormat.GetMonthName(Convert.ToInt32(Monthnow)).ToString() + " " 
                + Yearnow.ToString() 
                + Environment.NewLine 
                + ru.DateTimeFormat.GetDayName(time.DayOfWeek);
            PopulateDatatoDatagrid();
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            int dayz = DateTime.DaysInMonth(Convert.ToInt32(Yearnow), Convert.ToInt32(Monthnow)); // Узнаём сколько дней в текущем месяце
            
            if(Daynow <= dayz)
            {
                Daynow++;
                lblCurDay.Text = Daynow.ToString("D2");
            }
            else
            {
                Daynow = 1;
                if (Monthnow == 12)
                {
                    Monthnow = 1;
                    Yearnow += 1;
                }
                else Monthnow += 1;
            }
            lblCurDay.Text = Daynow.ToString();
            DateTime time = new DateTime(Yearnow, Monthnow, Daynow);
            lblCurMouth.Text = ru.DateTimeFormat.GetMonthName(Convert.ToInt32(Monthnow)).ToString() + " " 
                + Yearnow.ToString() 
                + Environment.NewLine 
                + ru.DateTimeFormat.GetDayName(time.DayOfWeek);
            PopulateDatatoDatagrid();
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
            if (Settings.UserRole.guest || Settings.UserRole.manager_clientov || Settings.UserRole.manager_group || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_clientov || Settings.UserRole.manager_group || Settings.UserRole.manager_sections)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Расписание";
                printer.SubTitle = string.Format("Дата: {0} {1}", lblCurDay.Text, lblCurMouth.Text);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Спортивный комплекс «Атлант»";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(grid);
            }
        }

        private void cmbSport_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DateTime time = new DateTime(Yearnow, Monthnow, Daynow);
                grid.DataSource = database.Schedule_Select_Room(Convert.ToInt32(cmbSport.SelectedValue), time);
                grid.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
        }

        private void cmbTrainer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DateTime time = new DateTime(Yearnow, Monthnow, Daynow);
                grid.DataSource = database.Schedule_Select_Trainer(Convert.ToInt32(cmbTrainer.SelectedValue), time);
                grid.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            btnPrevDay.Visible = true;
            btnNextDay.Visible = true;
            lblCurDay.Visible = true;
            lblCurMouth.Visible = true;
            PopulateDatatoDatagrid();
            LoadData();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Settings.UserRole.guest || Settings.UserRole.manager_clientov || Settings.UserRole.manager_group || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                new PopupEffect.transparentBg(this, new frmAddSchedule());
                PopulateDatatoDatagrid();
            }
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Settings.UserRole.guest || Settings.UserRole.manager_clientov || Settings.UserRole.manager_group || Settings.UserRole.manager_sections || Settings.UserRole.manager_trainer)
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Не достаточно прав для этого действия", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
            }
            else
            {
                int id = int.Parse(grid.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    string messege = string.Format("Удалить расписание за {0} {1} : {2}", grid.CurrentRow.Cells[1].Value.ToString(), grid.CurrentRow.Cells[2].Value.ToString(), grid.CurrentRow.Cells[3].Value.ToString());
                    if (MessageBox.Show(messege, "Подтверждение удаления",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Удалить выбранные строку
                        Schedule raspisanie = database.Schedule
                        .Where(c => c.schedule_id == id)
                        .FirstOrDefault();

                        database.Schedule.Remove(raspisanie);
                    }
                }
                catch (SqlException ex)
                { Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error); }
                finally
                {
                    // Сохранить изменения
                    if (database.ChangeTracker.HasChanges())
                    {
                        if (database.SaveChanges() > 0)
                        {
                            Bunifu.Snackbar.Show(this.FindForm(), "Расписание успешно удалёно.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                        }
                    }
                    PopulateDatatoDatagrid();
                }
            }
        }

        private void btnVivodMes_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime time = new DateTime(Yearnow, Monthnow, 1);
                int dayz = DateTime.DaysInMonth(Convert.ToInt32(Yearnow), Convert.ToInt32(Monthnow));
                DateTime time2 = new DateTime(Yearnow, Monthnow, dayz);
                var results = database.Schedule_Select_Period(time, time2);
                grid.DataSource = results.ToList();
                LoadData();
                btnPrevDay.Visible = false;
                btnNextDay.Visible = false;
                lblCurDay.Visible = false;
                lblCurMouth.Visible = false;
                grid.Columns["ID"].Visible = false;
                pnlSlide.Visible = false;
            }
            catch (EntityException ex)
            {
                Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                this.Visible = false;
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            if (pnlSlide.Visible == false) pnlSlide.Visible = true;
            else pnlSlide.Visible = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            try
            {
                //monthCalendar1.SelectionRange.Start.ToString();
                DateTime time = monthCalendar1.SelectionRange.Start;
                    Daynow = time.Day;
                    Monthnow = time.Month;
                    Yearnow = time.Year;
                    PrintCurDayAndMonth();
                    var results = database.Schedule_Select(time);
                    grid.DataSource = results.ToList();
                
                
                LoadData();
                grid.Columns["ID"].Visible = false;
                pnlSlide.Visible = false;
                this.Visible = true;
            }
            catch (Exception ex)
            {
                Bunifu.Snackbar.Show(this.FindForm(), ex.Message + "Ошибка.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                this.Visible = false;
            }
        }
    }
}
