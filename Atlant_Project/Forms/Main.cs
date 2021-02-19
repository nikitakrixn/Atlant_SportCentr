using System;
using System.Drawing;
using System.Windows.Forms;
using Atlant_Project.EntityFramework;
using Atlant_Project.Class;

namespace Atlant_Project
{
    public partial class Main : Form
    {
        SQLRoles sqlhelp = new SQLRoles(); // Ссылка на класс с sql ролями

        public Main()
        {
            InitializeComponent();
        }

        private void Check_Role()
        {
            Settings.UserRole.admin = sqlhelp.Check_Admin();
            Settings.UserRole.admin_new = sqlhelp.Check_Admin_New();
            Settings.UserRole.guest = sqlhelp.Check_Guest();
            Settings.UserRole.manager_clientov = sqlhelp.Check_ManagerClient();
            Settings.UserRole.manager_trainer = sqlhelp.Check_ManagerTrainer();
            if (Settings.UserRole.admin == true) lblCurrentUser.Text = lblCurrentUser.Text + "Администратор";
            if (Settings.UserRole.admin_new == true) lblCurrentUser.Text = lblCurrentUser.Text + "Новый Администратор";
            if (Settings.UserRole.guest == true) lblCurrentUser.Text = lblCurrentUser.Text + "Гость";
            if (Settings.UserRole.manager_clientov == true) lblCurrentUser.Text = lblCurrentUser.Text + "Менеджер клиентов";
            if (Settings.UserRole.manager_trainer == true) lblCurrentUser.Text = lblCurrentUser.Text + "Менеджер тренеров";
        }

        // Скрыть видимое
        private void HideVisible()
        {
            //Админ
            if (Settings.UserRole.admin == true || Settings.UserRole.admin_new == true) btnAdmin.Visible = true;
            else btnAdmin.Visible = false;

            //Гость
            if (Settings.UserRole.guest == true)
            {
                //Скрыть лишние кнопки
                btnClients.Visible = false;
                btnTrainer.Visible = false;
                btnGroups.Visible = false;

                //Новое положение для видимой кнопки
                btnSections.Location = new Point(11, 63);
                btnSettings.Location = new Point(11, 108);
            }

            //Менеджер клиентов
            if(Settings.UserRole.manager_clientov == true)
            {
                //Скрыть лишние кнопки
                btnTrainer.Visible = false;

                //Новое положение для видимой кнопки
                btnGroups.Location = new Point(11, 108);
                btnSections.Location = new Point(11, 153);
                btnSettings.Location = new Point(11, 198);

            }

            if(Settings.UserRole.manager_trainer == true)
            {
                //Скрыть лишние кнопки
                btnClients.Visible = false;
                btnGroups.Visible = false;

                //Новое положение для видимой кнопки
                btnTrainer.Location = new Point(11, 63);
                btnSections.Location = new Point(11, 108);
                btnSettings.Location = new Point(11, 153);
            }
            clients_uc1.Visible = false;
            trainers_uc1.Visible = false;
            groups_uc1.Visible = false;
            schedule_uc1.Visible = false;
            sections_uc1.Visible = false;
            settings_uc1.Visible = false;
            admin_uc1.Visible = false;
            lblCurTab.Visible = false;
            lblDarkTheme.Visible = false;
            lblWhiteTheme.Visible = false;
            switchASd.Visible = false;
        }

        #region Buttons Click

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(-1);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //Свернуть
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            HideVisible();
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            schedule_uc1.PopulateDatatoDatagrid();
            schedule_uc1.Visible = true;
            lblCurTab.Visible = true;
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            HideVisible();
            if (Settings.UserRole.guest || Settings.UserRole.manager_trainer || Settings.UserRole.manager_sections)
            {
                MessageBox.Show("Не достаточно прав для просмотра данных");
            }
            else
            {
                lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
                clients_uc1.PopulateDatatoDatagrid();
                clients_uc1.Visible = true;
                lblCurTab.Visible = true;
            }
        }

        private void btnTrainer_Click(object sender, EventArgs e)
        {
            HideVisible();
            if (Settings.UserRole.guest || Settings.UserRole.manager_group || Settings.UserRole.manager_sections || Settings.UserRole.manager_clientov)
            {
                MessageBox.Show("Не достаточно прав для просмотра данных");
            }
            else
            {
                lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
                trainers_uc1.PopulateDatatoDatagrid();
                trainers_uc1.Visible = true;
                lblCurTab.Visible = true;
            }
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            HideVisible();
            if (Settings.UserRole.manager_trainer|| Settings.UserRole.manager_sections)
            {
                MessageBox.Show("Не достаточно прав для просмотра данных");
            }
            else
            {
                lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
                groups_uc1.PopulateDatatoDatagrid();
                groups_uc1.Visible = true;
                lblCurTab.Visible = true;
            }
            
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            HideVisible();
            if (Settings.UserRole.manager_group)
            {
                MessageBox.Show("Не достаточно прав для просмотра данных");
            }
            else
            {
                lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
                sections_uc1.PopulateDatatoDatagrid();
                sections_uc1.Visible = true;
                lblCurTab.Visible = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HideVisible();
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            settings_uc1.Visible = true;
            lblCurTab.Visible = true;
            lblDarkTheme.Visible = true;
            lblWhiteTheme.Visible = true;
            switchASd.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            HideVisible();
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            if (Settings.UserRole.admin_new)
            {
                //Забыл проверку
            }
            else
            {
                admin_uc1.PopulateDatatoDatagrid();
            }
            
            admin_uc1.Visible = true;
            lblCurTab.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #endregion

        private void Main_Shown(object sender, EventArgs e)
        {
            Check_Role();
            HideVisible();
        }

        #region Смена Цвета
        private void switchASd_OnValueChange(object sender, EventArgs e)
        {
            if(switchASd.Value == true)
            {
                Settings.Interface.DarkTheme = true;
                Settings.Interface.LightTheme = false;
                this.BackColor = Color.FromArgb(53, 64, 86);
                header.BackColor = Color.FromArgb(26, 41, 64);
                header.BottomSahddow = false;
                pnlLeft.BackColor = Color.FromArgb(26, 41, 64);
                pnlMain.BackColor = Color.FromArgb(26, 41, 64);
                lblNameProgram.ForeColor = Color.White;
                lblNameProgram.BackColor = Color.FromArgb(26, 41, 64);
                lblCurTab.ForeColor = Color.White;
                lblCurTab.BackColor = Color.FromArgb(26, 41, 64);
                lblDarkTheme.ForeColor = Color.White;
                lblWhiteTheme.ForeColor = Color.White;
                lblCurrentUser.ForeColor = Color.White;

                //Clients
                btnClients.BackColor = Color.FromArgb(26, 41, 64);
                btnClients.OnHovercolor = Color.FromArgb(26, 41, 64);
                btnClients.Normalcolor = Color.FromArgb(26, 41, 64);
                btnClients.Activecolor = Color.FromArgb(26, 41, 64);
                btnClients.Textcolor = Color.White;

                //Groups
                btnGroups.BackColor = Color.FromArgb(26, 41, 64);
                btnGroups.OnHovercolor = Color.FromArgb(26, 41, 64);
                btnGroups.Normalcolor = Color.FromArgb(26, 41, 64);
                btnGroups.Activecolor = Color.FromArgb(26, 41, 64);
                btnGroups.Textcolor = Color.White;

                //Raspisanie
                btnSchedule.BackColor = Color.FromArgb(26, 41, 64);
                btnSchedule.OnHovercolor = Color.FromArgb(26, 41, 64);
                btnSchedule.Normalcolor = Color.FromArgb(26, 41, 64);
                btnSchedule.Activecolor = Color.FromArgb(26, 41, 64);
                btnSchedule.Textcolor = Color.White;

                //Settings
                btnSettings.BackColor = Color.FromArgb(26, 41, 64);
                btnSettings.OnHovercolor = Color.FromArgb(26, 41, 64);
                btnSettings.Normalcolor = Color.FromArgb(26, 41, 64);
                btnSettings.Activecolor = Color.FromArgb(26, 41, 64);
                btnSettings.Textcolor = Color.White;

                //Trainer
                btnTrainer.BackColor = Color.FromArgb(26, 41, 64);
                btnTrainer.OnHovercolor = Color.FromArgb(26, 41, 64);
                btnTrainer.Normalcolor = Color.FromArgb(26, 41, 64);
                btnTrainer.Activecolor = Color.FromArgb(26, 41, 64);
                btnTrainer.Textcolor = Color.White;

                //Sections
                btnSections.BackColor = Color.FromArgb(26, 41, 64);
                btnSections.OnHovercolor = Color.FromArgb(26, 41, 64);
                btnSections.Normalcolor = Color.FromArgb(26, 41, 64);
                btnSections.Activecolor = Color.FromArgb(26, 41, 64);
                btnSections.Textcolor = Color.White;

                //Admin
                btnAdmin.BackColor = Color.FromArgb(26, 41, 64);
                btnAdmin.OnHovercolor = Color.FromArgb(26, 41, 64);
                btnAdmin.Normalcolor = Color.FromArgb(26, 41, 64);
                btnAdmin.Activecolor = Color.FromArgb(26, 41, 64);
                btnAdmin.Textcolor = Color.White;

                //Exit
                btnExit.BackColor = Color.FromArgb(26, 41, 64);
                btnExit.OnHovercolor = Color.FromArgb(26, 41, 64);
                btnExit.Normalcolor = Color.FromArgb(26, 41, 64);
                btnExit.Activecolor = Color.FromArgb(26, 41, 64);
                btnExit.Textcolor = Color.White;

                //Control
                btnClose.BackColor = Color.FromArgb(26, 41, 64);
                btnMin.BackColor = Color.FromArgb(26, 41, 64);
                btnClose.Image = Icons.close_white_test;
                btnMin.Image = Icons.min_white;

                //UserInterface
                settings_uc1.BackColor = Color.FromArgb(26, 41, 64);

                admin_uc1.BackColor = Color.FromArgb(26, 41, 64);

                clients_uc1.BackColor = Color.FromArgb(26, 41, 64);
                clients_uc1.txtSearch.BackColor = Color.FromArgb(26, 41, 64);
                clients_uc1.txtSearch.FillColor = Color.FromArgb(26, 41, 64);
                clients_uc1.txtSearch.ForeColor = Color.White;
                clients_uc1.grid.BackgroundColor = Color.FromArgb(26, 41, 64);

                trainers_uc1.BackColor = Color.FromArgb(26, 41, 64);
                trainers_uc1.txtSearch.BackColor = Color.FromArgb(26, 41, 64);
                trainers_uc1.txtSearch.FillColor = Color.FromArgb(26, 41, 64);
                trainers_uc1.txtSearch.ForeColor = Color.White;
                trainers_uc1.grid.BackgroundColor = Color.FromArgb(26, 41, 64);

                groups_uc1.BackColor = Color.FromArgb(26, 41, 64);
                groups_uc1.txtSearch.BackColor = Color.FromArgb(26, 41, 64);
                groups_uc1.txtSearch.FillColor = Color.FromArgb(26, 41, 64);
                groups_uc1.txtSearch.ForeColor = Color.White;
                groups_uc1.grid.BackgroundColor = Color.FromArgb(26, 41, 64);
                

                schedule_uc1.BackColor = Color.FromArgb(26, 41, 64);
                schedule_uc1.grid.BackgroundColor = Color.FromArgb(26, 41, 64);

                sections_uc1.BackColor = Color.FromArgb(26, 41, 64);
                sections_uc1.txtSearch.BackColor = Color.FromArgb(26, 41, 64);
                sections_uc1.txtSearch.FillColor = Color.FromArgb(26, 41, 64);
                sections_uc1.txtSearch.ForeColor = Color.White;
                sections_uc1.grid.BackgroundColor = Color.FromArgb(26, 41, 64);
                //
            }
            else
            {
                Settings.Interface.DarkTheme = false;
                Settings.Interface.LightTheme = true;
                this.BackColor = Color.FromArgb(236, 239, 244);

                header.BackColor = Color.White;
                header.BottomSahddow = true;
                pnlLeft.BackColor = Color.White;
                pnlMain.BackColor = Color.White;
                lblNameProgram.ForeColor = Color.DimGray;
                lblNameProgram.BackColor = Color.White;
                lblCurTab.ForeColor = Color.DimGray;
                lblCurTab.BackColor = Color.White;
                lblDarkTheme.ForeColor = Color.DimGray;
                lblWhiteTheme.ForeColor = Color.DimGray;
                lblCurrentUser.ForeColor = Color.DimGray;

                //Clients
                btnClients.BackColor = Color.White;
                btnClients.OnHovercolor = Color.White;
                btnClients.Normalcolor = Color.White;
                btnClients.Activecolor = Color.White;
                btnClients.Textcolor = Color.DimGray;

                //Groups
                btnGroups.BackColor = Color.White;
                btnGroups.OnHovercolor = Color.White;
                btnGroups.Normalcolor = Color.White;
                btnGroups.Activecolor = Color.White;
                btnGroups.Textcolor = Color.DimGray;

                //Raspisanie
                btnSchedule.BackColor = Color.White;
                btnSchedule.OnHovercolor = Color.White;
                btnSchedule.Normalcolor = Color.White;
                btnSchedule.Activecolor = Color.White;
                btnSchedule.Textcolor = Color.DimGray;

                //Settings
                btnSettings.BackColor = Color.White;
                btnSettings.OnHovercolor = Color.White;
                btnSettings.Normalcolor = Color.White;
                btnSettings.Activecolor = Color.White;
                btnSettings.Textcolor = Color.DimGray;

                //Trainer
                btnTrainer.BackColor = Color.White;
                btnTrainer.OnHovercolor = Color.White;
                btnTrainer.Normalcolor = Color.White;
                btnTrainer.Activecolor = Color.White;
                btnTrainer.Textcolor = Color.DimGray;

                //Sections
                btnSections.BackColor = Color.White;
                btnSections.OnHovercolor = Color.White;
                btnSections.Normalcolor = Color.White;
                btnSections.Activecolor = Color.White;
                btnSections.Textcolor = Color.DimGray;

                //Admin
                btnAdmin.BackColor = Color.White;
                btnAdmin.OnHovercolor = Color.White;
                btnAdmin.Normalcolor = Color.White;
                btnAdmin.Activecolor = Color.White;
                btnAdmin.Textcolor = Color.DimGray;

                //Exit
                btnExit.BackColor = Color.White;
                btnExit.OnHovercolor = Color.White;
                btnExit.Normalcolor = Color.White;
                btnExit.Activecolor = Color.White;
                btnExit.Textcolor = Color.DimGray;

                //Control
                btnClose.BackColor = Color.White;
                btnMin.BackColor = Color.White;
                btnClose.Image = Icons.close_gray;
                btnMin.Image = Icons.min_gray;

                //UserInterface
                settings_uc1.BackColor = Color.White;

                admin_uc1.BackColor = Color.White;

                clients_uc1.BackColor = Color.White;
                clients_uc1.txtSearch.BackColor = Color.White;
                clients_uc1.txtSearch.FillColor = Color.White;
                clients_uc1.txtSearch.ForeColor = Color.Black;
                clients_uc1.grid.BackgroundColor = Color.White;

                trainers_uc1.BackColor = Color.White;
                trainers_uc1.txtSearch.BackColor = Color.White;
                trainers_uc1.txtSearch.FillColor = Color.White;
                trainers_uc1.txtSearch.ForeColor = Color.Black;
                trainers_uc1.grid.BackgroundColor = Color.White;

                groups_uc1.BackColor = Color.White;
                groups_uc1.txtSearch.BackColor = Color.White;
                groups_uc1.txtSearch.FillColor = Color.White;
                groups_uc1.txtSearch.ForeColor = Color.Black;
                groups_uc1.grid.BackgroundColor = Color.White;

                schedule_uc1.BackColor = Color.White;
                schedule_uc1.grid.BackgroundColor = Color.White;

                sections_uc1.BackColor = Color.White;
                sections_uc1.txtSearch.BackColor = Color.White;
                sections_uc1.txtSearch.FillColor = Color.White;
                sections_uc1.txtSearch.ForeColor = Color.Black;
                sections_uc1.grid.BackgroundColor = Color.White;
            }
        }
        #endregion

        
    }
}
