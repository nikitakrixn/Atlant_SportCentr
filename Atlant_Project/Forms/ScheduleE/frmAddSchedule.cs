using Atlant_Project.Class;
using Atlant_Project.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlant_Project.Forms.ScheduleE
{
    public partial class frmAddSchedule : Form
    {
        private AtlantEntities database;
        public frmAddSchedule()
        {
            database = new AtlantEntities();
            InitializeComponent();
        }

        private bool Insert_Team()
        {
            bool isReady = false;
            string sql_query = "EXEC Raspisanie_Insert @Day, @Start_Time_id, @End_Time_id, @Room_id, @Group_id, @Section_id, @Trainer_id";
            SqlConnection connect = new SqlConnection(Settings.SettingsConnect.ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.Parameters.AddWithValue("@Day", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@Start_Time_id", Convert.ToInt32(cmbTime.SelectedValue));
                cmd.Parameters.AddWithValue("@End_Time_id", Convert.ToInt32(cmbEndTime.SelectedValue));
                cmd.Parameters.AddWithValue("@Room_id", Convert.ToInt32(cmbRoom.SelectedValue));
                cmd.Parameters.AddWithValue("@Group_id", Convert.ToInt32(cmbGroup.SelectedValue));
                cmd.Parameters.AddWithValue("@Section_id", Convert.ToInt32(cmbVidSporta.SelectedValue));
                cmd.Parameters.AddWithValue("@Trainer_id", Convert.ToInt32(cmbTrainer.SelectedValue));
                connect.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) isReady = true;
                else isReady = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connect.Close();
            }
            return isReady;

        }

        //Загрузка с бд
        private void LoadData()
        {
            database.Configuration.ProxyCreationEnabled = false;
            var time = database.Time.Select(c => new
            {
                Display = c.Time1,
                Value = c.time_id
            }).ToList();
            cmbTime.DataSource = time;
            cmbTime.ValueMember = "Value";
            cmbTime.DisplayMember = "Display";
            cmbTime.SelectedValue = -1;
            ///
            var timeend = database.Time.Select(c => new
            {
                Display = c.Time1,
                Value = c.time_id
            }).ToList();
            cmbEndTime.DataSource = timeend;
            cmbEndTime.ValueMember = "Value";
            cmbEndTime.DisplayMember = "Display";
            cmbEndTime.SelectedValue = -1;
            ///
            var room = database.Rooms.Select(c => new {
                Display = c.Name,
                Value = c.room_id
            }).ToList();
            cmbRoom.DataSource = room;
            cmbRoom.ValueMember = "Value";
            cmbRoom.DisplayMember = "Display";
            cmbRoom.SelectedValue = -1;
            ///
            var group = database.Groups.Select(c => new
            {
                Display = c.Name,
                Value = c.group_id,
            }).ToList();
            cmbGroup.DataSource = group;
            cmbGroup.ValueMember = "Value";
            cmbGroup.DisplayMember = "Display";
            cmbGroup.SelectedValue = -1;
            ///
            var sections = database.Sections.Select(c => new
            {
                Display = c.Name,
                Value = c.sections_id,
            }).ToList();
            cmbVidSporta.DataSource = sections;
            cmbVidSporta.ValueMember = "Value";
            cmbVidSporta.DisplayMember = "Display";
            cmbVidSporta.SelectedIndex = -1;
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

        private void frmAddSchedule_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = Insert_Team();
                if (success == true)
                {
                    Bunifu.Snackbar.Show(this.FindForm(), "Успешно добавлено.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                }
                else Bunifu.Snackbar.Show(this.FindForm(), "Ошибка при добавлении.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
