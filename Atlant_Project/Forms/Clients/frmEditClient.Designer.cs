namespace Atlant_Project.Forms.Clients
{
    partial class frmEditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditClient));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btnEditClient = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.txtAddress = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtPhone = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtLastName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.isFemale = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.isMale = new Bunifu.UI.WinForms.BunifuCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.Transparent;
            this.btnEditClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditClient.BackgroundImage")));
            this.btnEditClient.ButtonText = "Редактировать Клиента";
            this.btnEditClient.ButtonTextMarginLeft = 0;
            this.btnEditClient.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnEditClient.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnEditClient.DisabledForecolor = System.Drawing.Color.White;
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditClient.IconPadding = 10;
            this.btnEditClient.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditClient.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEditClient.IdleBorderRadius = 35;
            this.btnEditClient.IdleBorderThickness = 0;
            this.btnEditClient.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEditClient.IdleIconLeftImage = null;
            this.btnEditClient.IdleIconRightImage = null;
            this.btnEditClient.Location = new System.Drawing.Point(81, 453);
            this.btnEditClient.Name = "btnEditClient";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 35;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnEditClient.onHoverState = stateProperties1;
            this.btnEditClient.Size = new System.Drawing.Size(311, 45);
            this.btnEditClient.TabIndex = 42;
            this.btnEditClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.btnEditClient, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnEditClient, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnEditClient, "");
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 69);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(476, 35);
            this.bunifuSeparator1.TabIndex = 41;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator1, "");
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoSize = true;
            this.lblCurTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurTab.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurTab.Location = new System.Drawing.Point(145, 32);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(188, 21);
            this.lblCurTab.TabIndex = 40;
            this.lblCurTab.Text = "Редактировать Клиента";
            this.bunifuToolTip1.SetToolTip(this.lblCurTab, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblCurTab, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblCurTab, "");
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = false;
            this.txtAddress.AcceptsTab = false;
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAddress.BackgroundImage")));
            this.txtAddress.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtAddress.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAddress.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtAddress.BorderRadius = 30;
            this.txtAddress.BorderThickness = 1;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.DefaultText = "";
            this.txtAddress.FillColor = System.Drawing.Color.White;
            this.txtAddress.HideSelection = true;
            this.txtAddress.IconLeft = null;
            this.txtAddress.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.IconPadding = 10;
            this.txtAddress.IconRight = null;
            this.txtAddress.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.Location = new System.Drawing.Point(81, 287);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtAddress.Modified = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(311, 35);
            this.txtAddress.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAddress.TabIndex = 39;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextMarginLeft = 5;
            this.txtAddress.TextPlaceholder = "Адрес";
            this.bunifuToolTip1.SetToolTip(this.txtAddress, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtAddress, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtAddress, "");
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            this.txtPhone.AcceptsReturn = false;
            this.txtPhone.AcceptsTab = false;
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPhone.BackgroundImage")));
            this.txtPhone.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtPhone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPhone.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPhone.BorderRadius = 30;
            this.txtPhone.BorderThickness = 1;
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhone.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.DefaultText = "";
            this.txtPhone.FillColor = System.Drawing.Color.White;
            this.txtPhone.HideSelection = true;
            this.txtPhone.IconLeft = null;
            this.txtPhone.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.IconPadding = 10;
            this.txtPhone.IconRight = null;
            this.txtPhone.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.Location = new System.Drawing.Point(81, 228);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPhone.Modified = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ReadOnly = false;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(311, 35);
            this.txtPhone.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPhone.TabIndex = 38;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.TextMarginLeft = 5;
            this.txtPhone.TextPlaceholder = "Телефон";
            this.bunifuToolTip1.SetToolTip(this.txtPhone, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtPhone, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtPhone, "");
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // txtLastName
            // 
            this.txtLastName.AcceptsReturn = false;
            this.txtLastName.AcceptsTab = false;
            this.txtLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLastName.BackgroundImage")));
            this.txtLastName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtLastName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtLastName.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtLastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtLastName.BorderRadius = 30;
            this.txtLastName.BorderThickness = 1;
            this.txtLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLastName.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.DefaultText = "";
            this.txtLastName.FillColor = System.Drawing.Color.White;
            this.txtLastName.HideSelection = true;
            this.txtLastName.IconLeft = null;
            this.txtLastName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtLastName.IconPadding = 10;
            this.txtLastName.IconRight = null;
            this.txtLastName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtLastName.Location = new System.Drawing.Point(81, 169);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtLastName.Modified = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.ReadOnly = false;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(311, 35);
            this.txtLastName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtLastName.TabIndex = 37;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.TextMarginLeft = 5;
            this.txtLastName.TextPlaceholder = "Фамилия";
            this.bunifuToolTip1.SetToolTip(this.txtLastName, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtLastName, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtLastName, "");
            this.txtLastName.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtName.BorderRadius = 30;
            this.txtName.BorderThickness = 1;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = null;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(81, 110);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtName.Modified = false;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(311, 35);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtName.TabIndex = 36;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "Имя";
            this.bunifuToolTip1.SetToolTip(this.txtName, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtName, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtName, "");
            this.txtName.UseSystemPasswordChar = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(431, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 35;
            this.btnClose.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnClose, "Выход");
            this.bunifuToolTip1.SetToolTipIcon(this.btnClose, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnClose, "");
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(196, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Женский";
            this.bunifuToolTip1.SetToolTip(this.label4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label4, "");
            // 
            // isFemale
            // 
            this.isFemale.AllowBindingControlAnimation = true;
            this.isFemale.AllowBindingControlColorChanges = false;
            this.isFemale.AllowBindingControlLocation = true;
            this.isFemale.AllowCheckBoxAnimation = false;
            this.isFemale.AllowCheckmarkAnimation = true;
            this.isFemale.AllowOnHoverStates = true;
            this.isFemale.BackColor = System.Drawing.Color.Transparent;
            this.isFemale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isFemale.BackgroundImage")));
            this.isFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isFemale.BindingControl = null;
            this.isFemale.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isFemale.Checked = false;
            this.isFemale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.isFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isFemale.CustomCheckmarkImage = null;
            this.isFemale.Location = new System.Drawing.Point(164, 389);
            this.isFemale.MinimumSize = new System.Drawing.Size(17, 17);
            this.isFemale.Name = "isFemale";
            this.isFemale.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFemale.OnCheck.BorderRadius = 2;
            this.isFemale.OnCheck.BorderThickness = 2;
            this.isFemale.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFemale.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isFemale.OnCheck.CheckmarkThickness = 2;
            this.isFemale.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isFemale.OnDisable.BorderRadius = 2;
            this.isFemale.OnDisable.BorderThickness = 2;
            this.isFemale.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFemale.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isFemale.OnDisable.CheckmarkThickness = 2;
            this.isFemale.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFemale.OnHoverChecked.BorderRadius = 2;
            this.isFemale.OnHoverChecked.BorderThickness = 2;
            this.isFemale.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFemale.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isFemale.OnHoverChecked.CheckmarkThickness = 2;
            this.isFemale.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFemale.OnHoverUnchecked.BorderRadius = 2;
            this.isFemale.OnHoverUnchecked.BorderThickness = 2;
            this.isFemale.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFemale.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFemale.OnUncheck.BorderRadius = 2;
            this.isFemale.OnUncheck.BorderThickness = 2;
            this.isFemale.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFemale.Size = new System.Drawing.Size(21, 21);
            this.isFemale.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isFemale.TabIndex = 45;
            this.isFemale.ThreeState = false;
            this.bunifuToolTip1.SetToolTip(this.isFemale, "");
            this.bunifuToolTip1.SetToolTipIcon(this.isFemale, null);
            this.isFemale.ToolTipText = null;
            this.bunifuToolTip1.SetToolTipTitle(this.isFemale, "");
            this.isFemale.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.IsFemale_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(196, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Мужской";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // isMale
            // 
            this.isMale.AllowBindingControlAnimation = true;
            this.isMale.AllowBindingControlColorChanges = false;
            this.isMale.AllowBindingControlLocation = true;
            this.isMale.AllowCheckBoxAnimation = false;
            this.isMale.AllowCheckmarkAnimation = true;
            this.isMale.AllowOnHoverStates = true;
            this.isMale.BackColor = System.Drawing.Color.Transparent;
            this.isMale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isMale.BackgroundImage")));
            this.isMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isMale.BindingControl = null;
            this.isMale.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isMale.Checked = false;
            this.isMale.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.isMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isMale.CustomCheckmarkImage = null;
            this.isMale.Location = new System.Drawing.Point(164, 349);
            this.isMale.MinimumSize = new System.Drawing.Size(17, 17);
            this.isMale.Name = "isMale";
            this.isMale.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isMale.OnCheck.BorderRadius = 2;
            this.isMale.OnCheck.BorderThickness = 2;
            this.isMale.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isMale.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isMale.OnCheck.CheckmarkThickness = 2;
            this.isMale.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isMale.OnDisable.BorderRadius = 2;
            this.isMale.OnDisable.BorderThickness = 2;
            this.isMale.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isMale.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isMale.OnDisable.CheckmarkThickness = 2;
            this.isMale.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isMale.OnHoverChecked.BorderRadius = 2;
            this.isMale.OnHoverChecked.BorderThickness = 2;
            this.isMale.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isMale.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isMale.OnHoverChecked.CheckmarkThickness = 2;
            this.isMale.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isMale.OnHoverUnchecked.BorderRadius = 2;
            this.isMale.OnHoverUnchecked.BorderThickness = 2;
            this.isMale.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isMale.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isMale.OnUncheck.BorderRadius = 2;
            this.isMale.OnUncheck.BorderThickness = 2;
            this.isMale.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isMale.Size = new System.Drawing.Size(21, 21);
            this.isMale.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isMale.TabIndex = 43;
            this.isMale.ThreeState = false;
            this.bunifuToolTip1.SetToolTip(this.isMale, "");
            this.bunifuToolTip1.SetToolTipIcon(this.isMale, null);
            this.isMale.ToolTipText = null;
            this.bunifuToolTip1.SetToolTipTitle(this.isMale, "");
            this.isMale.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.IsMale_CheckedChanged);
            // 
            // frmEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 524);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isFemale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isMale);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditClient";
            this.Load += new System.EventHandler(this.FrmEditClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditClient;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAddress;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPhone;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtLastName;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuCheckBox isFemale;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuCheckBox isMale;
    }
}