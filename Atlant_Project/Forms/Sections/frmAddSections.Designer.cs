namespace Atlant_Project.Forms.Sections
{
    partial class frmAddSections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSections));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btnAddSection = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtDesc = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSection
            // 
            this.btnAddSection.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSection.BackgroundImage")));
            this.btnAddSection.ButtonText = "Добавить Секцию";
            this.btnAddSection.ButtonTextMarginLeft = 0;
            this.btnAddSection.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddSection.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddSection.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddSection.ForeColor = System.Drawing.Color.White;
            this.btnAddSection.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddSection.IconPadding = 10;
            this.btnAddSection.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddSection.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddSection.IdleBorderRadius = 35;
            this.btnAddSection.IdleBorderThickness = 0;
            this.btnAddSection.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddSection.IdleIconLeftImage = null;
            this.btnAddSection.IdleIconRightImage = null;
            this.btnAddSection.Location = new System.Drawing.Point(89, 253);
            this.btnAddSection.Name = "btnAddSection";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 35;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddSection.onHoverState = stateProperties1;
            this.btnAddSection.Size = new System.Drawing.Size(311, 45);
            this.btnAddSection.TabIndex = 48;
            this.btnAddSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 78);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(476, 35);
            this.bunifuSeparator1.TabIndex = 47;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoSize = true;
            this.lblCurTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurTab.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurTab.Location = new System.Drawing.Point(163, 41);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(148, 21);
            this.lblCurTab.TabIndex = 46;
            this.lblCurTab.Text = "Добавить Секцию";
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
            this.txtName.Location = new System.Drawing.Point(89, 128);
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
            this.txtName.TabIndex = 44;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "Название";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(431, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 43;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.AcceptsReturn = false;
            this.txtDesc.AcceptsTab = false;
            this.txtDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDesc.BackgroundImage")));
            this.txtDesc.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtDesc.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDesc.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtDesc.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtDesc.BorderRadius = 30;
            this.txtDesc.BorderThickness = 1;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDesc.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.DefaultText = "";
            this.txtDesc.FillColor = System.Drawing.Color.White;
            this.txtDesc.HideSelection = true;
            this.txtDesc.IconLeft = null;
            this.txtDesc.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtDesc.IconPadding = 10;
            this.txtDesc.IconRight = null;
            this.txtDesc.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtDesc.Location = new System.Drawing.Point(89, 169);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtDesc.Modified = false;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.ReadOnly = false;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(311, 78);
            this.txtDesc.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtDesc.TabIndex = 49;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.TextMarginLeft = 5;
            this.txtDesc.TextPlaceholder = "Описание";
            this.txtDesc.UseSystemPasswordChar = false;
            // 
            // frmAddSections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(476, 366);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddSections";
            this.Text = "frmAddSections";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddSection;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtDesc;
    }
}