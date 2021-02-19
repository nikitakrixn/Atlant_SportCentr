namespace Atlant_Project.Forms.Admin
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.chkPass = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.txtLogin = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lblCheckPass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccess = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoSize = true;
            this.lblCurTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurTab.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurTab.Location = new System.Drawing.Point(88, 111);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(45, 21);
            this.lblCurTab.TabIndex = 15;
            this.lblCurTab.Text = "Роль";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(1, 65);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(476, 35);
            this.bunifuSeparator1.TabIndex = 36;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(140, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Добавить Пользователя";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(438, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 34;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(311, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPassword.BorderRadius = 30;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Location = new System.Drawing.Point(85, 270);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPassword.Modified = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(311, 45);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 53;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginLeft = 5;
            this.txtPassword.TextPlaceholder = "";
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // chkPass
            // 
            this.chkPass.AllowBindingControlAnimation = true;
            this.chkPass.AllowBindingControlColorChanges = false;
            this.chkPass.AllowBindingControlLocation = true;
            this.chkPass.AllowCheckBoxAnimation = false;
            this.chkPass.AllowCheckmarkAnimation = true;
            this.chkPass.AllowOnHoverStates = true;
            this.chkPass.BackColor = System.Drawing.Color.Transparent;
            this.chkPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkPass.BackgroundImage")));
            this.chkPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkPass.BindingControl = null;
            this.chkPass.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkPass.Checked = true;
            this.chkPass.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.chkPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPass.CustomCheckmarkImage = null;
            this.chkPass.Location = new System.Drawing.Point(155, 336);
            this.chkPass.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkPass.Name = "chkPass";
            this.chkPass.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.chkPass.OnCheck.BorderRadius = 2;
            this.chkPass.OnCheck.BorderThickness = 2;
            this.chkPass.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.chkPass.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkPass.OnCheck.CheckmarkThickness = 2;
            this.chkPass.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkPass.OnDisable.BorderRadius = 2;
            this.chkPass.OnDisable.BorderThickness = 2;
            this.chkPass.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkPass.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkPass.OnDisable.CheckmarkThickness = 2;
            this.chkPass.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkPass.OnHoverChecked.BorderRadius = 2;
            this.chkPass.OnHoverChecked.BorderThickness = 2;
            this.chkPass.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkPass.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkPass.OnHoverChecked.CheckmarkThickness = 2;
            this.chkPass.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.chkPass.OnHoverUnchecked.BorderRadius = 2;
            this.chkPass.OnHoverUnchecked.BorderThickness = 2;
            this.chkPass.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkPass.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.chkPass.OnUncheck.BorderRadius = 2;
            this.chkPass.OnUncheck.BorderThickness = 2;
            this.chkPass.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkPass.Size = new System.Drawing.Size(21, 21);
            this.chkPass.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkPass.TabIndex = 52;
            this.chkPass.ThreeState = false;
            this.chkPass.ToolTipText = null;
            this.chkPass.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.chkPass_CheckedChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.AcceptsReturn = false;
            this.txtLogin.AcceptsTab = false;
            this.txtLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtLogin.BackgroundImage")));
            this.txtLogin.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtLogin.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtLogin.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtLogin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtLogin.BorderRadius = 30;
            this.txtLogin.BorderThickness = 1;
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLogin.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.DefaultText = "";
            this.txtLogin.FillColor = System.Drawing.Color.White;
            this.txtLogin.HideSelection = true;
            this.txtLogin.IconLeft = null;
            this.txtLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtLogin.IconPadding = 10;
            this.txtLogin.IconRight = null;
            this.txtLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtLogin.Location = new System.Drawing.Point(85, 196);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtLogin.Modified = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.ReadOnly = false;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(311, 45);
            this.txtLogin.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtLogin.TabIndex = 51;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLogin.TextMarginLeft = 5;
            this.txtLogin.TextPlaceholder = "";
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // lblCheckPass
            // 
            this.lblCheckPass.AutoSize = true;
            this.lblCheckPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCheckPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.lblCheckPass.Location = new System.Drawing.Point(182, 336);
            this.lblCheckPass.Name = "lblCheckPass";
            this.lblCheckPass.Size = new System.Drawing.Size(136, 21);
            this.lblCheckPass.TabIndex = 50;
            this.lblCheckPass.Text = "Показать пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(88, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(88, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Логин";
            // 
            // btnAccess
            // 
            this.btnAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnAccess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccess.BackgroundImage")));
            this.btnAccess.ButtonText = "Добавить";
            this.btnAccess.ButtonTextMarginLeft = 0;
            this.btnAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccess.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAccess.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAccess.DisabledForecolor = System.Drawing.Color.White;
            this.btnAccess.ForeColor = System.Drawing.Color.White;
            this.btnAccess.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccess.IconPadding = 10;
            this.btnAccess.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAccess.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(47)))));
            this.btnAccess.IdleBorderRadius = 33;
            this.btnAccess.IdleBorderThickness = 0;
            this.btnAccess.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(47)))));
            this.btnAccess.IdleIconLeftImage = null;
            this.btnAccess.IdleIconRightImage = null;
            this.btnAccess.Location = new System.Drawing.Point(85, 383);
            this.btnAccess.Name = "btnAccess";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 33;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAccess.onHoverState = stateProperties1;
            this.btnAccess.Size = new System.Drawing.Size(311, 45);
            this.btnAccess.TabIndex = 47;
            this.btnAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(476, 524);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkPass);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblCheckPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCurTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUser";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.ComboBox comboBox1;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuCheckBox chkPass;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCheckPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAccess;
    }
}