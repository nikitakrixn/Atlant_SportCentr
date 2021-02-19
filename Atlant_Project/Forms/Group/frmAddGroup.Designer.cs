namespace Atlant_Project.Forms.Group
{
    partial class frmAddGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddGroup));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btnAddGroup = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.txtMaxKolvo = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddGroup.BackgroundImage")));
            this.btnAddGroup.ButtonText = "Добавить Группу";
            this.btnAddGroup.ButtonTextMarginLeft = 0;
            this.btnAddGroup.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddGroup.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddGroup.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddGroup.IconPadding = 10;
            this.btnAddGroup.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddGroup.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddGroup.IdleBorderRadius = 35;
            this.btnAddGroup.IdleBorderThickness = 0;
            this.btnAddGroup.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddGroup.IdleIconLeftImage = null;
            this.btnAddGroup.IdleIconRightImage = null;
            this.btnAddGroup.Location = new System.Drawing.Point(81, 284);
            this.btnAddGroup.Name = "btnAddGroup";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 35;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddGroup.onHoverState = stateProperties1;
            this.btnAddGroup.Size = new System.Drawing.Size(311, 45);
            this.btnAddGroup.TabIndex = 42;
            this.btnAddGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.btnAddGroup, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnAddGroup, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnAddGroup, "");
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
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
            this.lblCurTab.Location = new System.Drawing.Point(163, 32);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(138, 21);
            this.lblCurTab.TabIndex = 40;
            this.lblCurTab.Text = "Добавить Группу";
            this.bunifuToolTip1.SetToolTip(this.lblCurTab, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblCurTab, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblCurTab, "");
            // 
            // txtMaxKolvo
            // 
            this.txtMaxKolvo.AcceptsReturn = false;
            this.txtMaxKolvo.AcceptsTab = false;
            this.txtMaxKolvo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMaxKolvo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMaxKolvo.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxKolvo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMaxKolvo.BackgroundImage")));
            this.txtMaxKolvo.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtMaxKolvo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtMaxKolvo.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtMaxKolvo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtMaxKolvo.BorderRadius = 30;
            this.txtMaxKolvo.BorderThickness = 1;
            this.txtMaxKolvo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMaxKolvo.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxKolvo.DefaultText = "";
            this.txtMaxKolvo.FillColor = System.Drawing.Color.White;
            this.txtMaxKolvo.HideSelection = true;
            this.txtMaxKolvo.IconLeft = null;
            this.txtMaxKolvo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtMaxKolvo.IconPadding = 10;
            this.txtMaxKolvo.IconRight = null;
            this.txtMaxKolvo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtMaxKolvo.Location = new System.Drawing.Point(81, 196);
            this.txtMaxKolvo.MaxLength = 32767;
            this.txtMaxKolvo.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtMaxKolvo.Modified = false;
            this.txtMaxKolvo.Name = "txtMaxKolvo";
            this.txtMaxKolvo.PasswordChar = '\0';
            this.txtMaxKolvo.ReadOnly = false;
            this.txtMaxKolvo.SelectedText = "";
            this.txtMaxKolvo.SelectionLength = 0;
            this.txtMaxKolvo.SelectionStart = 0;
            this.txtMaxKolvo.ShortcutsEnabled = true;
            this.txtMaxKolvo.Size = new System.Drawing.Size(311, 35);
            this.txtMaxKolvo.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtMaxKolvo.TabIndex = 38;
            this.txtMaxKolvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMaxKolvo.TextMarginLeft = 5;
            this.txtMaxKolvo.TextPlaceholder = "Максимальное количество человек";
            this.bunifuToolTip1.SetToolTip(this.txtMaxKolvo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtMaxKolvo, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtMaxKolvo, "");
            this.txtMaxKolvo.UseSystemPasswordChar = false;
            this.txtMaxKolvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxKolvo_KeyPress);
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
            this.txtName.Location = new System.Drawing.Point(81, 131);
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
            this.txtName.TabIndex = 37;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "Название";
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
            // frmAddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 375);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.txtMaxKolvo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddGroup";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddGroup;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtMaxKolvo;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}