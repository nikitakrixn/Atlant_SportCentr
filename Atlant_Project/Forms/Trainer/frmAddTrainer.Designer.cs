namespace Atlant_Project.Forms.Trainer
{
    partial class frmAddTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddTrainer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.btnAddTrainer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtExp = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtPhone = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtLastName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtVidSporta = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
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
            this.lblCurTab.Size = new System.Drawing.Size(150, 21);
            this.lblCurTab.TabIndex = 40;
            this.lblCurTab.Text = "Добавить Тренера";
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTrainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTrainer.BackgroundImage")));
            this.btnAddTrainer.ButtonText = "Добавить Тренера";
            this.btnAddTrainer.ButtonTextMarginLeft = 0;
            this.btnAddTrainer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTrainer.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddTrainer.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddTrainer.ForeColor = System.Drawing.Color.White;
            this.btnAddTrainer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddTrainer.IconPadding = 10;
            this.btnAddTrainer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddTrainer.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddTrainer.IdleBorderRadius = 35;
            this.btnAddTrainer.IdleBorderThickness = 0;
            this.btnAddTrainer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddTrainer.IdleIconLeftImage = null;
            this.btnAddTrainer.IdleIconRightImage = null;
            this.btnAddTrainer.Location = new System.Drawing.Point(81, 453);
            this.btnAddTrainer.Name = "btnAddTrainer";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 35;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAddTrainer.onHoverState = stateProperties2;
            this.btnAddTrainer.Size = new System.Drawing.Size(311, 45);
            this.btnAddTrainer.TabIndex = 42;
            this.btnAddTrainer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // txtExp
            // 
            this.txtExp.AcceptsReturn = false;
            this.txtExp.AcceptsTab = false;
            this.txtExp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtExp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtExp.BackColor = System.Drawing.Color.Transparent;
            this.txtExp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtExp.BackgroundImage")));
            this.txtExp.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtExp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtExp.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtExp.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtExp.BorderRadius = 30;
            this.txtExp.BorderThickness = 1;
            this.txtExp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtExp.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExp.DefaultText = "";
            this.txtExp.FillColor = System.Drawing.Color.White;
            this.txtExp.HideSelection = true;
            this.txtExp.IconLeft = null;
            this.txtExp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtExp.IconPadding = 10;
            this.txtExp.IconRight = null;
            this.txtExp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtExp.Location = new System.Drawing.Point(81, 287);
            this.txtExp.MaxLength = 32767;
            this.txtExp.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtExp.Modified = false;
            this.txtExp.Name = "txtExp";
            this.txtExp.PasswordChar = '\0';
            this.txtExp.ReadOnly = false;
            this.txtExp.SelectedText = "";
            this.txtExp.SelectionLength = 0;
            this.txtExp.SelectionStart = 0;
            this.txtExp.ShortcutsEnabled = true;
            this.txtExp.Size = new System.Drawing.Size(311, 35);
            this.txtExp.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtExp.TabIndex = 39;
            this.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtExp.TextMarginLeft = 5;
            this.txtExp.TextPlaceholder = "Опыт";
            this.txtExp.UseSystemPasswordChar = false;
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
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtVidSporta
            // 
            this.txtVidSporta.AcceptsReturn = false;
            this.txtVidSporta.AcceptsTab = false;
            this.txtVidSporta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtVidSporta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtVidSporta.BackColor = System.Drawing.Color.Transparent;
            this.txtVidSporta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtVidSporta.BackgroundImage")));
            this.txtVidSporta.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtVidSporta.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtVidSporta.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtVidSporta.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtVidSporta.BorderRadius = 30;
            this.txtVidSporta.BorderThickness = 1;
            this.txtVidSporta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtVidSporta.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVidSporta.DefaultText = "";
            this.txtVidSporta.FillColor = System.Drawing.Color.White;
            this.txtVidSporta.HideSelection = true;
            this.txtVidSporta.IconLeft = null;
            this.txtVidSporta.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtVidSporta.IconPadding = 10;
            this.txtVidSporta.IconRight = null;
            this.txtVidSporta.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtVidSporta.Location = new System.Drawing.Point(81, 343);
            this.txtVidSporta.MaxLength = 32767;
            this.txtVidSporta.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtVidSporta.Modified = false;
            this.txtVidSporta.Name = "txtVidSporta";
            this.txtVidSporta.PasswordChar = '\0';
            this.txtVidSporta.ReadOnly = false;
            this.txtVidSporta.SelectedText = "";
            this.txtVidSporta.SelectionLength = 0;
            this.txtVidSporta.SelectionStart = 0;
            this.txtVidSporta.ShortcutsEnabled = true;
            this.txtVidSporta.Size = new System.Drawing.Size(311, 35);
            this.txtVidSporta.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtVidSporta.TabIndex = 39;
            this.txtVidSporta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVidSporta.TextMarginLeft = 5;
            this.txtVidSporta.TextPlaceholder = "Вид спорта";
            this.txtVidSporta.UseSystemPasswordChar = false;
            // 
            // frmAddTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(476, 524);
            this.Controls.Add(this.btnAddTrainer);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.txtVidSporta);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddTrainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddTrainer";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddTrainer;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtExp;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPhone;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtLastName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtVidSporta;
    }
}