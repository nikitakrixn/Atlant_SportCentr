namespace Atlant_Project.Forms.Group
{
    partial class frmAddClientGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddClientGroup));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAddClient = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.ddClients = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
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
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 67);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(476, 35);
            this.bunifuSeparator1.TabIndex = 44;
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
            this.lblCurTab.Location = new System.Drawing.Point(167, 30);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(150, 21);
            this.lblCurTab.TabIndex = 43;
            this.lblCurTab.Text = "Добавить Клиента";
            this.bunifuToolTip1.SetToolTip(this.lblCurTab, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblCurTab, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblCurTab, "");
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(431, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 42;
            this.btnClose.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.btnClose, "Выход");
            this.bunifuToolTip1.SetToolTipIcon(this.btnClose, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnClose, "");
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddClient.BackgroundImage")));
            this.btnAddClient.ButtonText = "Добавить Клиента";
            this.btnAddClient.ButtonTextMarginLeft = 0;
            this.btnAddClient.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddClient.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddClient.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddClient.IconPadding = 10;
            this.btnAddClient.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddClient.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddClient.IdleBorderRadius = 35;
            this.btnAddClient.IdleBorderThickness = 0;
            this.btnAddClient.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddClient.IdleIconLeftImage = null;
            this.btnAddClient.IdleIconRightImage = null;
            this.btnAddClient.Location = new System.Drawing.Point(83, 216);
            this.btnAddClient.Name = "btnAddClient";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 35;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddClient.onHoverState = stateProperties1;
            this.btnAddClient.Size = new System.Drawing.Size(311, 37);
            this.btnAddClient.TabIndex = 46;
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.btnAddClient, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnAddClient, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnAddClient, "");
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // ddClients
            // 
            this.ddClients.FormattingEnabled = true;
            this.ddClients.Location = new System.Drawing.Point(83, 132);
            this.ddClients.Name = "ddClients";
            this.ddClients.Size = new System.Drawing.Size(311, 21);
            this.ddClients.TabIndex = 47;
            this.bunifuToolTip1.SetToolTip(this.ddClients, "");
            this.bunifuToolTip1.SetToolTipIcon(this.ddClients, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ddClients, "");
            // 
            // frmAddClientGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 314);
            this.Controls.Add(this.ddClients);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddClientGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddClientGroup";
            this.Load += new System.EventHandler(this.frmAddClientGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddClient;
        private System.Windows.Forms.ComboBox ddClients;
    }
}