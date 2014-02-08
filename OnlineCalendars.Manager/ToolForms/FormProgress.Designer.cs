namespace OnlineCalendars.Manager.ToolForms
{
    partial class FormProgress
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
			this.circularProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
			this.laProgress = new System.Windows.Forms.Label();
			this.pnInner = new System.Windows.Forms.Panel();
			this.pnBorder = new System.Windows.Forms.Panel();
			this.pnInner.SuspendLayout();
			this.pnBorder.SuspendLayout();
			this.SuspendLayout();
			// 
			// circularProgress
			// 
			this.circularProgress.AnimationSpeed = 50;
			this.circularProgress.BackColor = System.Drawing.Color.Transparent;
			// 
			// 
			// 
			this.circularProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.circularProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.circularProgress.Enabled = false;
			this.circularProgress.Location = new System.Drawing.Point(0, 45);
			this.circularProgress.Name = "circularProgress";
			this.circularProgress.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
			this.circularProgress.ProgressColor = System.Drawing.Color.Black;
			this.circularProgress.ProgressTextFormat = "";
			this.circularProgress.Size = new System.Drawing.Size(301, 39);
			this.circularProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
			this.circularProgress.TabIndex = 5;
			// 
			// laProgress
			// 
			this.laProgress.BackColor = System.Drawing.Color.Transparent;
			this.laProgress.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laProgress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laProgress.ForeColor = System.Drawing.Color.Black;
			this.laProgress.Location = new System.Drawing.Point(0, 0);
			this.laProgress.Name = "laProgress";
			this.laProgress.Size = new System.Drawing.Size(301, 45);
			this.laProgress.TabIndex = 6;
			this.laProgress.Text = "Loading data...";
			this.laProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.laProgress.UseMnemonic = false;
			this.laProgress.UseWaitCursor = true;
			// 
			// pnInner
			// 
			this.pnInner.BackColor = System.Drawing.SystemColors.Control;
			this.pnInner.Controls.Add(this.laProgress);
			this.pnInner.Controls.Add(this.circularProgress);
			this.pnInner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnInner.Location = new System.Drawing.Point(2, 2);
			this.pnInner.Name = "pnInner";
			this.pnInner.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnInner.Size = new System.Drawing.Size(301, 94);
			this.pnInner.TabIndex = 7;
			// 
			// pnBorder
			// 
			this.pnBorder.BackColor = System.Drawing.Color.White;
			this.pnBorder.Controls.Add(this.pnInner);
			this.pnBorder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnBorder.Location = new System.Drawing.Point(2, 2);
			this.pnBorder.Name = "pnBorder";
			this.pnBorder.Padding = new System.Windows.Forms.Padding(2);
			this.pnBorder.Size = new System.Drawing.Size(305, 98);
			this.pnBorder.TabIndex = 8;
			// 
			// FormProgress
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(309, 102);
			this.ControlBox = false;
			this.Controls.Add(this.pnBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormProgress";
			this.Opacity = 0.85D;
			this.Padding = new System.Windows.Forms.Padding(2);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProgressForm";
			this.Shown += new System.EventHandler(this.FormProgress_Shown);
			this.pnInner.ResumeLayout(false);
			this.pnBorder.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private DevComponents.DotNetBar.Controls.CircularProgress circularProgress;
		public System.Windows.Forms.Label laProgress;
		private System.Windows.Forms.Panel pnInner;
		private System.Windows.Forms.Panel pnBorder;
    }
}