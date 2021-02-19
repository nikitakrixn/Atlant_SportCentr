namespace Atlant_Project.Forms.ScheduleE
{
    partial class frmAddSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSchedule));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.btnEditClient = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.cmbVidSporta = new System.Windows.Forms.ComboBox();
            this.cmbTrainer = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEndTime = new System.Windows.Forms.ComboBox();
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
            this.bunifuSeparator1.TabIndex = 49;
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
            this.lblCurTab.Size = new System.Drawing.Size(189, 21);
            this.lblCurTab.TabIndex = 48;
            this.lblCurTab.Text = "Добавить в расписание";
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.Color.Transparent;
            this.btnEditClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditClient.BackgroundImage")));
            this.btnEditClient.ButtonText = "Добавить в расписание";
            this.btnEditClient.ButtonTextMarginLeft = 0;
            this.btnEditClient.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnEditClient.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnEditClient.DisabledForecolor = System.Drawing.Color.White;
            this.btnEditClient.ForeColor = System.Drawing.Color.White;
            this.btnEditClient.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditClient.IconPadding = 10;
            this.btnEditClient.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditClient.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnEditClient.IdleBorderRadius = 3;
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
            this.btnEditClient.TabIndex = 50;
            this.btnEditClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
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
            this.btnClose.TabIndex = 43;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(81, 270);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(311, 21);
            this.cmbRoom.TabIndex = 52;
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(81, 174);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(311, 21);
            this.cmbTime.TabIndex = 52;
            // 
            // cmbGroup
            // 
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(81, 318);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(311, 21);
            this.cmbGroup.TabIndex = 52;
            // 
            // cmbVidSporta
            // 
            this.cmbVidSporta.FormattingEnabled = true;
            this.cmbVidSporta.Location = new System.Drawing.Point(81, 366);
            this.cmbVidSporta.Name = "cmbVidSporta";
            this.cmbVidSporta.Size = new System.Drawing.Size(311, 21);
            this.cmbVidSporta.TabIndex = 52;
            // 
            // cmbTrainer
            // 
            this.cmbTrainer.FormattingEnabled = true;
            this.cmbTrainer.Location = new System.Drawing.Point(81, 414);
            this.cmbTrainer.Name = "cmbTrainer";
            this.cmbTrainer.Size = new System.Drawing.Size(311, 21);
            this.cmbTrainer.TabIndex = 52;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(311, 20);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(78, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(78, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Время Начала Занятия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(78, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Спортзал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(78, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(78, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Вид спорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(78, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Тренер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(78, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Время Окончания Занятия";
            // 
            // cmbEndTime
            // 
            this.cmbEndTime.FormattingEnabled = true;
            this.cmbEndTime.Location = new System.Drawing.Point(81, 222);
            this.cmbEndTime.Name = "cmbEndTime";
            this.cmbEndTime.Size = new System.Drawing.Size(311, 21);
            this.cmbEndTime.TabIndex = 55;
            // 
            // frmAddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(476, 524);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbEndTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.cmbTrainer);
            this.Controls.Add(this.cmbVidSporta);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddSchedule";
            this.Load += new System.EventHandler(this.frmAddSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditClient;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbVidSporta;
        private System.Windows.Forms.ComboBox cmbTrainer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEndTime;
    }
}