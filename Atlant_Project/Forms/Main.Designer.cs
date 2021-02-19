namespace Atlant_Project
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSections = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGroups = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTrainer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClients = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSchedule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header = new Bunifu.Framework.UI.BunifuCards();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNameProgram = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblWhiteTheme = new System.Windows.Forms.Label();
            this.lblDarkTheme = new System.Windows.Forms.Label();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.switchASd = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.settings_uc1 = new Atlant_Project.Forms.UserInterface.Settings_uc();
            this.sections_uc1 = new Atlant_Project.Forms.UserInterface.Sections_uc();
            this.schedule_uc1 = new Atlant_Project.Forms.UserInterface.Schedule_uc();
            this.groups_uc1 = new Atlant_Project.Forms.UserInterface.Groups_uc();
            this.trainers_uc1 = new Atlant_Project.Forms.UserInterface.Trainers_uc();
            this.clients_uc1 = new Atlant_Project.Forms.UserInterface.Clients_uc();
            this.admin_uc1 = new Atlant_Project.Forms.UserInterface.Admin_uc();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlLeft.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.btnExit);
            this.pnlLeft.Controls.Add(this.btnAdmin);
            this.pnlLeft.Controls.Add(this.btnSections);
            this.pnlLeft.Controls.Add(this.btnGroups);
            this.pnlLeft.Controls.Add(this.btnSettings);
            this.pnlLeft.Controls.Add(this.btnTrainer);
            this.pnlLeft.Controls.Add(this.btnClients);
            this.pnlLeft.Controls.Add(this.btnSchedule);
            this.pnlLeft.Location = new System.Drawing.Point(17, 88);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(218, 551);
            this.pnlLeft.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.pnlLeft, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlLeft, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlLeft, "");
            // 
            // btnExit
            // 
            this.btnExit.Active = false;
            this.btnExit.Activecolor = System.Drawing.Color.White;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "      Сменить                 пользователя";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = global::Atlant_Project.Icons.exit;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 75D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(11, 497);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.White;
            this.btnExit.OnHovercolor = System.Drawing.Color.White;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(193, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "      Сменить                 пользователя";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Textcolor = System.Drawing.Color.DimGray;
            this.btnExit.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.SetToolTip(this.btnExit, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnExit, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnExit, "");
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Active = false;
            this.btnAdmin.Activecolor = System.Drawing.Color.White;
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.BorderRadius = 0;
            this.btnAdmin.ButtonText = "   Админ-Панель";
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdmin.Iconimage = global::Atlant_Project.Icons.admin;
            this.btnAdmin.Iconimage_right = null;
            this.btnAdmin.Iconimage_right_Selected = null;
            this.btnAdmin.Iconimage_Selected = null;
            this.btnAdmin.IconMarginLeft = 0;
            this.btnAdmin.IconMarginRight = 0;
            this.btnAdmin.IconRightVisible = true;
            this.btnAdmin.IconRightZoom = 0D;
            this.btnAdmin.IconVisible = true;
            this.btnAdmin.IconZoom = 75D;
            this.btnAdmin.IsTab = false;
            this.btnAdmin.Location = new System.Drawing.Point(11, 288);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Normalcolor = System.Drawing.Color.White;
            this.btnAdmin.OnHovercolor = System.Drawing.Color.White;
            this.btnAdmin.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnAdmin.selected = false;
            this.btnAdmin.Size = new System.Drawing.Size(193, 42);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "   Админ-Панель";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Textcolor = System.Drawing.Color.DimGray;
            this.btnAdmin.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.SetToolTip(this.btnAdmin, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnAdmin, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnAdmin, "");
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSections
            // 
            this.btnSections.Active = false;
            this.btnSections.Activecolor = System.Drawing.Color.White;
            this.btnSections.BackColor = System.Drawing.Color.White;
            this.btnSections.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSections.BorderRadius = 0;
            this.btnSections.ButtonText = "   Секции";
            this.btnSections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSections.DisabledColor = System.Drawing.Color.Gray;
            this.btnSections.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSections.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSections.Iconimage")));
            this.btnSections.Iconimage_right = null;
            this.btnSections.Iconimage_right_Selected = null;
            this.btnSections.Iconimage_Selected = null;
            this.btnSections.IconMarginLeft = 0;
            this.btnSections.IconMarginRight = 0;
            this.btnSections.IconRightVisible = true;
            this.btnSections.IconRightZoom = 0D;
            this.btnSections.IconVisible = true;
            this.btnSections.IconZoom = 75D;
            this.btnSections.IsTab = false;
            this.btnSections.Location = new System.Drawing.Point(11, 198);
            this.btnSections.Name = "btnSections";
            this.btnSections.Normalcolor = System.Drawing.Color.White;
            this.btnSections.OnHovercolor = System.Drawing.Color.White;
            this.btnSections.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSections.selected = false;
            this.btnSections.Size = new System.Drawing.Size(193, 42);
            this.btnSections.TabIndex = 5;
            this.btnSections.Text = "   Секции";
            this.btnSections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSections.Textcolor = System.Drawing.Color.DimGray;
            this.btnSections.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.SetToolTip(this.btnSections, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSections, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSections, "");
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Active = false;
            this.btnGroups.Activecolor = System.Drawing.Color.White;
            this.btnGroups.BackColor = System.Drawing.Color.White;
            this.btnGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroups.BorderRadius = 0;
            this.btnGroups.ButtonText = "   Группы";
            this.btnGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroups.DisabledColor = System.Drawing.Color.Gray;
            this.btnGroups.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGroups.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGroups.Iconimage")));
            this.btnGroups.Iconimage_right = null;
            this.btnGroups.Iconimage_right_Selected = null;
            this.btnGroups.Iconimage_Selected = null;
            this.btnGroups.IconMarginLeft = 0;
            this.btnGroups.IconMarginRight = 0;
            this.btnGroups.IconRightVisible = true;
            this.btnGroups.IconRightZoom = 0D;
            this.btnGroups.IconVisible = true;
            this.btnGroups.IconZoom = 73D;
            this.btnGroups.IsTab = false;
            this.btnGroups.Location = new System.Drawing.Point(11, 153);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Normalcolor = System.Drawing.Color.White;
            this.btnGroups.OnHovercolor = System.Drawing.Color.White;
            this.btnGroups.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnGroups.selected = false;
            this.btnGroups.Size = new System.Drawing.Size(193, 42);
            this.btnGroups.TabIndex = 4;
            this.btnGroups.Text = "   Группы";
            this.btnGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.Textcolor = System.Drawing.Color.DimGray;
            this.btnGroups.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.SetToolTip(this.btnGroups, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnGroups, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnGroups, "");
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Active = false;
            this.btnSettings.Activecolor = System.Drawing.Color.White;
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "   Настройки";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSettings.Iconimage")));
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 0;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 75D;
            this.btnSettings.IsTab = false;
            this.btnSettings.Location = new System.Drawing.Point(11, 243);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.White;
            this.btnSettings.OnHovercolor = System.Drawing.Color.White;
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSettings.selected = false;
            this.btnSettings.Size = new System.Drawing.Size(193, 42);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "   Настройки";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Textcolor = System.Drawing.Color.DimGray;
            this.btnSettings.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.SetToolTip(this.btnSettings, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSettings, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSettings, "");
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTrainer
            // 
            this.btnTrainer.Active = false;
            this.btnTrainer.Activecolor = System.Drawing.Color.White;
            this.btnTrainer.BackColor = System.Drawing.Color.White;
            this.btnTrainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrainer.BorderRadius = 0;
            this.btnTrainer.ButtonText = "   Тренеры";
            this.btnTrainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrainer.DisabledColor = System.Drawing.Color.Gray;
            this.btnTrainer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTrainer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTrainer.Iconimage")));
            this.btnTrainer.Iconimage_right = null;
            this.btnTrainer.Iconimage_right_Selected = null;
            this.btnTrainer.Iconimage_Selected = null;
            this.btnTrainer.IconMarginLeft = 0;
            this.btnTrainer.IconMarginRight = 0;
            this.btnTrainer.IconRightVisible = true;
            this.btnTrainer.IconRightZoom = 0D;
            this.btnTrainer.IconVisible = true;
            this.btnTrainer.IconZoom = 75D;
            this.btnTrainer.IsTab = false;
            this.btnTrainer.Location = new System.Drawing.Point(11, 108);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Normalcolor = System.Drawing.Color.White;
            this.btnTrainer.OnHovercolor = System.Drawing.Color.White;
            this.btnTrainer.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTrainer.selected = false;
            this.btnTrainer.Size = new System.Drawing.Size(193, 42);
            this.btnTrainer.TabIndex = 2;
            this.btnTrainer.Text = "   Тренеры";
            this.btnTrainer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainer.Textcolor = System.Drawing.Color.DimGray;
            this.btnTrainer.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.SetToolTip(this.btnTrainer, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnTrainer, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnTrainer, "");
            this.btnTrainer.Click += new System.EventHandler(this.btnTrainer_Click);
            // 
            // btnClients
            // 
            this.btnClients.Active = false;
            this.btnClients.Activecolor = System.Drawing.Color.White;
            this.btnClients.BackColor = System.Drawing.Color.White;
            this.btnClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClients.BorderRadius = 0;
            this.btnClients.ButtonText = "   Клиенты";
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.DisabledColor = System.Drawing.Color.Gray;
            this.btnClients.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClients.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClients.Iconimage")));
            this.btnClients.Iconimage_right = null;
            this.btnClients.Iconimage_right_Selected = null;
            this.btnClients.Iconimage_Selected = null;
            this.btnClients.IconMarginLeft = 0;
            this.btnClients.IconMarginRight = 0;
            this.btnClients.IconRightVisible = true;
            this.btnClients.IconRightZoom = 0D;
            this.btnClients.IconVisible = true;
            this.btnClients.IconZoom = 75D;
            this.btnClients.IsTab = false;
            this.btnClients.Location = new System.Drawing.Point(11, 63);
            this.btnClients.Name = "btnClients";
            this.btnClients.Normalcolor = System.Drawing.Color.White;
            this.btnClients.OnHovercolor = System.Drawing.Color.White;
            this.btnClients.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnClients.selected = false;
            this.btnClients.Size = new System.Drawing.Size(193, 42);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "   Клиенты";
            this.btnClients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Textcolor = System.Drawing.Color.DimGray;
            this.btnClients.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnClients, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnClients, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnClients, "");
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Active = false;
            this.btnSchedule.Activecolor = System.Drawing.Color.White;
            this.btnSchedule.BackColor = System.Drawing.Color.White;
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSchedule.BorderRadius = 0;
            this.btnSchedule.ButtonText = "   Расписание";
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchedule.DisabledColor = System.Drawing.Color.Gray;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSchedule.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSchedule.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Iconimage")));
            this.btnSchedule.Iconimage_right = null;
            this.btnSchedule.Iconimage_right_Selected = null;
            this.btnSchedule.Iconimage_Selected = null;
            this.btnSchedule.IconMarginLeft = 0;
            this.btnSchedule.IconMarginRight = 0;
            this.btnSchedule.IconRightVisible = true;
            this.btnSchedule.IconRightZoom = 0D;
            this.btnSchedule.IconVisible = true;
            this.btnSchedule.IconZoom = 75D;
            this.btnSchedule.IsTab = false;
            this.btnSchedule.Location = new System.Drawing.Point(11, 18);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Normalcolor = System.Drawing.Color.White;
            this.btnSchedule.OnHovercolor = System.Drawing.Color.White;
            this.btnSchedule.OnHoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSchedule.selected = false;
            this.btnSchedule.Size = new System.Drawing.Size(193, 42);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "   Расписание";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Textcolor = System.Drawing.Color.DimGray;
            this.btnSchedule.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuToolTip1.SetToolTip(this.btnSchedule, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSchedule, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSchedule, "");
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.White;
            this.header.BorderRadius = 5;
            this.header.BottomSahddow = true;
            this.header.color = System.Drawing.Color.White;
            this.header.Controls.Add(this.lblCurrentUser);
            this.header.Controls.Add(this.pctLogo);
            this.header.Controls.Add(this.btnMin);
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.lblNameProgram);
            this.header.LeftSahddow = false;
            this.header.Location = new System.Drawing.Point(-3, -5);
            this.header.Name = "header";
            this.header.RightSahddow = true;
            this.header.ShadowDepth = 20;
            this.header.Size = new System.Drawing.Size(1301, 75);
            this.header.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.header, "");
            this.bunifuToolTip1.SetToolTipIcon(this.header, null);
            this.bunifuToolTip1.SetToolTipTitle(this.header, "");
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentUser.Location = new System.Drawing.Point(717, 19);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(464, 35);
            this.lblCurrentUser.TabIndex = 5;
            this.lblCurrentUser.Text = "Вы авторизованы как ";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuToolTip1.SetToolTip(this.lblCurrentUser, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblCurrentUser, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblCurrentUser, "");
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(15, 17);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(64, 47);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 4;
            this.pctLogo.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pctLogo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pctLogo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pctLogo, "");
            // 
            // btnMin
            // 
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(1214, 28);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 35);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnMin, "Свернуть");
            this.bunifuToolTip1.SetToolTipIcon(this.btnMin, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnMin, "");
            this.btnMin.Zoom = 15;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1246, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnClose, "Закрыть");
            this.bunifuToolTip1.SetToolTipIcon(this.btnClose, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnClose, "");
            this.btnClose.Zoom = 15;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNameProgram
            // 
            this.lblNameProgram.AutoSize = true;
            this.lblNameProgram.BackColor = System.Drawing.Color.White;
            this.lblNameProgram.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblNameProgram.ForeColor = System.Drawing.Color.DimGray;
            this.lblNameProgram.Location = new System.Drawing.Point(75, 24);
            this.lblNameProgram.Name = "lblNameProgram";
            this.lblNameProgram.Size = new System.Drawing.Size(91, 32);
            this.lblNameProgram.TabIndex = 1;
            this.lblNameProgram.Text = "Атлант";
            this.bunifuToolTip1.SetToolTip(this.lblNameProgram, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblNameProgram, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblNameProgram, "");
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblWhiteTheme);
            this.pnlMain.Controls.Add(this.lblDarkTheme);
            this.pnlMain.Controls.Add(this.lblCurTab);
            this.pnlMain.Controls.Add(this.switchASd);
            this.pnlMain.Controls.Add(this.settings_uc1);
            this.pnlMain.Controls.Add(this.sections_uc1);
            this.pnlMain.Controls.Add(this.schedule_uc1);
            this.pnlMain.Controls.Add(this.groups_uc1);
            this.pnlMain.Controls.Add(this.trainers_uc1);
            this.pnlMain.Controls.Add(this.clients_uc1);
            this.pnlMain.Controls.Add(this.admin_uc1);
            this.pnlMain.Location = new System.Drawing.Point(256, 88);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1020, 551);
            this.pnlMain.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.pnlMain, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pnlMain, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pnlMain, "");
            // 
            // lblWhiteTheme
            // 
            this.lblWhiteTheme.AutoSize = true;
            this.lblWhiteTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblWhiteTheme.ForeColor = System.Drawing.Color.DimGray;
            this.lblWhiteTheme.Location = new System.Drawing.Point(41, 118);
            this.lblWhiteTheme.Name = "lblWhiteTheme";
            this.lblWhiteTheme.Size = new System.Drawing.Size(111, 21);
            this.lblWhiteTheme.TabIndex = 10;
            this.lblWhiteTheme.Text = "Светлая тема";
            this.bunifuToolTip1.SetToolTip(this.lblWhiteTheme, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblWhiteTheme, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblWhiteTheme, "");
            // 
            // lblDarkTheme
            // 
            this.lblDarkTheme.AutoSize = true;
            this.lblDarkTheme.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblDarkTheme.ForeColor = System.Drawing.Color.DimGray;
            this.lblDarkTheme.Location = new System.Drawing.Point(199, 117);
            this.lblDarkTheme.Name = "lblDarkTheme";
            this.lblDarkTheme.Size = new System.Drawing.Size(104, 21);
            this.lblDarkTheme.TabIndex = 9;
            this.lblDarkTheme.Text = "Темная тема";
            this.bunifuToolTip1.SetToolTip(this.lblDarkTheme, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblDarkTheme, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblDarkTheme, "");
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoSize = true;
            this.lblCurTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurTab.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurTab.Location = new System.Drawing.Point(75, 22);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(77, 21);
            this.lblCurTab.TabIndex = 3;
            this.lblCurTab.Text = "Клиенты";
            this.bunifuToolTip1.SetToolTip(this.lblCurTab, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblCurTab, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblCurTab, "");
            // 
            // switchASd
            // 
            this.switchASd.BackColor = System.Drawing.Color.Transparent;
            this.switchASd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchASd.BackgroundImage")));
            this.switchASd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchASd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchASd.Location = new System.Drawing.Point(158, 118);
            this.switchASd.Name = "switchASd";
            this.switchASd.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(177)))), ((int)(((byte)(252)))));
            this.switchASd.OnColor = System.Drawing.Color.DarkViolet;
            this.switchASd.Size = new System.Drawing.Size(35, 20);
            this.switchASd.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.switchASd, "");
            this.bunifuToolTip1.SetToolTipIcon(this.switchASd, null);
            this.bunifuToolTip1.SetToolTipTitle(this.switchASd, "");
            this.switchASd.Value = false;
            this.switchASd.OnValueChange += new System.EventHandler(this.switchASd_OnValueChange);
            // 
            // settings_uc1
            // 
            this.settings_uc1.BackColor = System.Drawing.Color.White;
            this.settings_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings_uc1.Location = new System.Drawing.Point(0, 0);
            this.settings_uc1.Name = "settings_uc1";
            this.settings_uc1.Size = new System.Drawing.Size(1020, 551);
            this.settings_uc1.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.settings_uc1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.settings_uc1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.settings_uc1, "");
            // 
            // sections_uc1
            // 
            this.sections_uc1.BackColor = System.Drawing.Color.White;
            this.sections_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sections_uc1.Location = new System.Drawing.Point(0, 0);
            this.sections_uc1.Name = "sections_uc1";
            this.sections_uc1.Size = new System.Drawing.Size(1020, 551);
            this.sections_uc1.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.sections_uc1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.sections_uc1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.sections_uc1, "");
            // 
            // schedule_uc1
            // 
            this.schedule_uc1.BackColor = System.Drawing.Color.White;
            this.schedule_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedule_uc1.Location = new System.Drawing.Point(0, 0);
            this.schedule_uc1.Name = "schedule_uc1";
            this.schedule_uc1.Size = new System.Drawing.Size(1020, 551);
            this.schedule_uc1.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.schedule_uc1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.schedule_uc1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.schedule_uc1, "");
            // 
            // groups_uc1
            // 
            this.groups_uc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groups_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groups_uc1.Location = new System.Drawing.Point(0, 0);
            this.groups_uc1.Name = "groups_uc1";
            this.groups_uc1.Size = new System.Drawing.Size(1020, 551);
            this.groups_uc1.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.groups_uc1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.groups_uc1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.groups_uc1, "");
            this.groups_uc1.Visible = false;
            // 
            // trainers_uc1
            // 
            this.trainers_uc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trainers_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trainers_uc1.Location = new System.Drawing.Point(0, 0);
            this.trainers_uc1.Name = "trainers_uc1";
            this.trainers_uc1.Size = new System.Drawing.Size(1020, 551);
            this.trainers_uc1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.trainers_uc1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.trainers_uc1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.trainers_uc1, "");
            this.trainers_uc1.Visible = false;
            // 
            // clients_uc1
            // 
            this.clients_uc1.BackColor = System.Drawing.Color.White;
            this.clients_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clients_uc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clients_uc1.Location = new System.Drawing.Point(0, 0);
            this.clients_uc1.Name = "clients_uc1";
            this.clients_uc1.Size = new System.Drawing.Size(1020, 551);
            this.clients_uc1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.clients_uc1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.clients_uc1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.clients_uc1, "");
            this.clients_uc1.Visible = false;
            // 
            // admin_uc1
            // 
            this.admin_uc1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_uc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_uc1.Location = new System.Drawing.Point(0, 0);
            this.admin_uc1.Name = "admin_uc1";
            this.admin_uc1.Size = new System.Drawing.Size(1020, 551);
            this.admin_uc1.TabIndex = 11;
            this.bunifuToolTip1.SetToolTip(this.admin_uc1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.admin_uc1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.admin_uc1, "");
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lblCurrentUser;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1296, 655);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atlant_Project";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.pnlLeft.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSettings;
        private Bunifu.Framework.UI.BunifuFlatButton btnTrainer;
        private Bunifu.Framework.UI.BunifuFlatButton btnClients;
        private Bunifu.Framework.UI.BunifuFlatButton btnSchedule;
        private Bunifu.Framework.UI.BunifuCards header;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lblNameProgram;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Forms.UserInterface.Clients_uc clients_uc1;
        private System.Windows.Forms.PictureBox pctLogo;
        private Forms.UserInterface.Trainers_uc trainers_uc1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSections;
        private Bunifu.Framework.UI.BunifuFlatButton btnGroups;
        private Forms.UserInterface.Groups_uc groups_uc1;
        private Forms.UserInterface.Schedule_uc schedule_uc1;
        private Forms.UserInterface.Sections_uc sections_uc1;
        private Forms.UserInterface.Settings_uc settings_uc1;
        private System.Windows.Forms.Label lblWhiteTheme;
        private System.Windows.Forms.Label lblDarkTheme;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchASd;
        private System.Windows.Forms.Label lblCurrentUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdmin;
        private Forms.UserInterface.Admin_uc admin_uc1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

