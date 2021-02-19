namespace Atlant_Project.Forms.Admin
{
    partial class frmEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUser));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAccess = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.chkPass = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblCheckPass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 69);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(476, 35);
            this.bunifuSeparator1.TabIndex = 48;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(129, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "Редактировать Пользователя";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(437, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 46;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnAccess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccess.BackgroundImage")));
            this.btnAccess.ButtonText = "Редактировать пользователя";
            this.btnAccess.ButtonTextMarginLeft = 0;
            this.btnAccess.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAccess.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAccess.DisabledForecolor = System.Drawing.Color.White;
            this.btnAccess.ForeColor = System.Drawing.Color.White;
            this.btnAccess.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccess.IconPadding = 10;
            this.btnAccess.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAccess.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAccess.IdleBorderRadius = 1;
            this.btnAccess.IdleBorderThickness = 0;
            this.btnAccess.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(198)))));
            this.btnAccess.IdleIconLeftImage = null;
            this.btnAccess.IdleIconRightImage = null;
            this.btnAccess.Location = new System.Drawing.Point(97, 383);
            this.btnAccess.Name = "btnAccess";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnAccess.onHoverState = stateProperties3;
            this.btnAccess.Size = new System.Drawing.Size(289, 45);
            this.btnAccess.TabIndex = 45;
            this.btnAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(100, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(100, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Логин";
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoSize = true;
            this.lblCurTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurTab.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurTab.Location = new System.Drawing.Point(100, 110);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(45, 21);
            this.lblCurTab.TabIndex = 42;
            this.lblCurTab.Text = "Роль";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.txtLogin);
            this.panel2.Location = new System.Drawing.Point(97, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 41);
            this.panel2.TabIndex = 38;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(7, 12);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(274, 17);
            this.txtLogin.TabIndex = 1;
            // 
            // chkPass
            // 
            this.chkPass.BackColor = System.Drawing.Color.DodgerBlue;
            this.chkPass.ChechedOffColor = System.Drawing.Color.DodgerBlue;
            this.chkPass.Checked = false;
            this.chkPass.CheckedOnColor = System.Drawing.Color.DeepSkyBlue;
            this.chkPass.ForeColor = System.Drawing.Color.White;
            this.chkPass.Location = new System.Drawing.Point(152, 337);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(20, 20);
            this.chkPass.TabIndex = 44;
            this.chkPass.OnChange += new System.EventHandler(this.chkPass_OnChange);
            // 
            // lblCheckPass
            // 
            this.lblCheckPass.AutoSize = true;
            this.lblCheckPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCheckPass.ForeColor = System.Drawing.Color.DimGray;
            this.lblCheckPass.Location = new System.Drawing.Point(178, 337);
            this.lblCheckPass.Name = "lblCheckPass";
            this.lblCheckPass.Size = new System.Drawing.Size(136, 21);
            this.lblCheckPass.TabIndex = 43;
            this.lblCheckPass.Text = "Показать пароль";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(97, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 41);
            this.panel1.TabIndex = 39;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(7, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(274, 17);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(476, 524);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkPass);
            this.Controls.Add(this.lblCheckPass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditUser";
            this.Text = "frmEditUser";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAccess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurTab;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtLogin;
        private Bunifu.Framework.UI.BunifuCheckbox chkPass;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCheckPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
    }
}