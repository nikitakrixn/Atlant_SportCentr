namespace Atlant_Project.Forms
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.lblPreloadText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadAD = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Preload = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TimerLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoad
            // 
            this.pnlLoad.BackColor = System.Drawing.Color.Black;
            this.pnlLoad.Controls.Add(this.pnlLoading);
            this.pnlLoad.Location = new System.Drawing.Point(220, 308);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(248, 5);
            this.pnlLoad.TabIndex = 4;
            // 
            // pnlLoading
            // 
            this.pnlLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(180)))), ((int)(((byte)(235)))));
            this.pnlLoading.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlLoading.Location = new System.Drawing.Point(206, 0);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(42, 5);
            this.pnlLoading.TabIndex = 2;
            // 
            // lblPreloadText
            // 
            this.lblPreloadText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblPreloadText.ForeColor = System.Drawing.Color.Black;
            this.lblPreloadText.Location = new System.Drawing.Point(168, 329);
            this.lblPreloadText.Name = "lblPreloadText";
            this.lblPreloadText.Size = new System.Drawing.Size(360, 46);
            this.lblPreloadText.TabIndex = 3;
            this.lblPreloadText.Text = "Загрузка, пожалуйста подождите ...";
            this.lblPreloadText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atlant_Project.Properties.Resources.preload;
            this.pictureBox1.Location = new System.Drawing.Point(291, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoadAD
            // 
            this.LoadAD.ElipseRadius = 5;
            this.LoadAD.TargetControl = this.pnlLoading;
            // 
            // Preload
            // 
            this.Preload.ElipseRadius = 5;
            this.Preload.TargetControl = this.pnlLoad;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(96)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(696, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.lblPreloadText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.pnlLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLoad;
        private System.Windows.Forms.Panel pnlLoading;
        private System.Windows.Forms.Label lblPreloadText;
        private Bunifu.Framework.UI.BunifuElipse LoadAD;
        private Bunifu.Framework.UI.BunifuElipse Preload;
        private System.Windows.Forms.Timer TimerLoad;
    }
}