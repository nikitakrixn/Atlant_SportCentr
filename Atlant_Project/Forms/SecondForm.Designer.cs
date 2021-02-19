namespace Atlant_Project.Forms
{
    partial class SecondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameBD = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.cmbServer = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAccess = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlSlide.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(80, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "Название базы данных";
            // 
            // txtNameBD
            // 
            this.txtNameBD.AcceptsReturn = false;
            this.txtNameBD.AcceptsTab = false;
            this.txtNameBD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNameBD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNameBD.BackColor = System.Drawing.Color.White;
            this.txtNameBD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNameBD.BackgroundImage")));
            this.txtNameBD.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtNameBD.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtNameBD.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtNameBD.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtNameBD.BorderRadius = 30;
            this.txtNameBD.BorderThickness = 1;
            this.txtNameBD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNameBD.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameBD.DefaultText = "";
            this.txtNameBD.FillColor = System.Drawing.Color.White;
            this.txtNameBD.HideSelection = true;
            this.txtNameBD.IconLeft = null;
            this.txtNameBD.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtNameBD.IconPadding = 10;
            this.txtNameBD.IconRight = null;
            this.txtNameBD.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtNameBD.Location = new System.Drawing.Point(77, 225);
            this.txtNameBD.MaxLength = 32767;
            this.txtNameBD.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtNameBD.Modified = false;
            this.txtNameBD.Name = "txtNameBD";
            this.txtNameBD.PasswordChar = '\0';
            this.txtNameBD.ReadOnly = false;
            this.txtNameBD.SelectedText = "";
            this.txtNameBD.SelectionLength = 0;
            this.txtNameBD.SelectionStart = 0;
            this.txtNameBD.ShortcutsEnabled = true;
            this.txtNameBD.Size = new System.Drawing.Size(311, 45);
            this.txtNameBD.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtNameBD.TabIndex = 48;
            this.txtNameBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNameBD.TextMarginLeft = 5;
            this.txtNameBD.TextPlaceholder = "";
            this.txtNameBD.UseSystemPasswordChar = false;
            // 
            // cmbServer
            // 
            this.cmbServer.BackColor = System.Drawing.Color.Transparent;
            this.cmbServer.BorderRadius = 3;
            this.cmbServer.DisabledColor = System.Drawing.Color.Gray;
            this.cmbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbServer.ForeColor = System.Drawing.Color.Black;
            this.cmbServer.items = new string[0];
            this.cmbServer.Location = new System.Drawing.Point(6, 3);
            this.cmbServer.Margin = new System.Windows.Forms.Padding(6);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.NomalColor = System.Drawing.Color.White;
            this.cmbServer.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.cmbServer.selectedIndex = -1;
            this.cmbServer.Size = new System.Drawing.Size(299, 38);
            this.cmbServer.TabIndex = 49;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Atlant_Project.Icons.close_gray;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(412, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 50;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 15;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnAccess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccess.BackgroundImage")));
            this.btnAccess.ButtonText = "Принять";
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
            this.btnAccess.Location = new System.Drawing.Point(77, 321);
            this.btnAccess.Name = "btnAccess";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 33;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAccess.onHoverState = stateProperties2;
            this.btnAccess.Size = new System.Drawing.Size(311, 45);
            this.btnAccess.TabIndex = 51;
            this.btnAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(80, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Сервер";
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.pnlSlide.Controls.Add(this.cmbServer);
            this.pnlSlide.Location = new System.Drawing.Point(77, 138);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(311, 44);
            this.pnlSlide.TabIndex = 53;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(464, 423);
            this.Controls.Add(this.pnlSlide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNameBD);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.Load += new System.EventHandler(this.SecondForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlSlide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtNameBD;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown cmbServer;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSlide;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}