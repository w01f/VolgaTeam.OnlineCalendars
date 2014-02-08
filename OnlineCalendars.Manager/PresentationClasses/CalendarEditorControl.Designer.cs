namespace OnlineCalendars.Manager.PresentationClasses
{
	sealed partial class CalendarEditorControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
			this.laCalendarListTitle = new System.Windows.Forms.Label();
			this.pnEmpty = new System.Windows.Forms.Panel();
			this.calendarListControl = new OnlineCalendars.Manager.PresentationClasses.CalendarList.CalendarListControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
			this.splitContainerControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainerControl
			// 
			this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl.Name = "splitContainerControl";
			this.splitContainerControl.Panel1.Controls.Add(this.calendarListControl);
			this.splitContainerControl.Panel1.Controls.Add(this.laCalendarListTitle);
			this.splitContainerControl.Panel1.MinSize = 250;
			this.splitContainerControl.Panel1.Text = "Panel1";
			this.splitContainerControl.Panel2.Controls.Add(this.pnEmpty);
			this.splitContainerControl.Panel2.Text = "Panel2";
			this.splitContainerControl.Size = new System.Drawing.Size(887, 598);
			this.splitContainerControl.TabIndex = 0;
			this.splitContainerControl.Text = "splitContainerControl1";
			// 
			// laCalendarListTitle
			// 
			this.laCalendarListTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.laCalendarListTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laCalendarListTitle.Location = new System.Drawing.Point(0, 0);
			this.laCalendarListTitle.Name = "laCalendarListTitle";
			this.laCalendarListTitle.Size = new System.Drawing.Size(250, 30);
			this.laCalendarListTitle.TabIndex = 1;
			this.laCalendarListTitle.Text = "Calendar List";
			this.laCalendarListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnEmpty
			// 
			this.pnEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnEmpty.Location = new System.Drawing.Point(0, 0);
			this.pnEmpty.Name = "pnEmpty";
			this.pnEmpty.Size = new System.Drawing.Size(632, 598);
			this.pnEmpty.TabIndex = 0;
			// 
			// calendarListControl
			// 
			this.calendarListControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.calendarListControl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.calendarListControl.Location = new System.Drawing.Point(0, 30);
			this.calendarListControl.MinimumSize = new System.Drawing.Size(250, 0);
			this.calendarListControl.Name = "calendarListControl";
			this.calendarListControl.Size = new System.Drawing.Size(250, 568);
			this.calendarListControl.TabIndex = 0;
			// 
			// CalendarEditorControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.splitContainerControl);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "CalendarEditorControl";
			this.Size = new System.Drawing.Size(887, 598);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
			this.splitContainerControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
		private CalendarList.CalendarListControl calendarListControl;
		private System.Windows.Forms.Label laCalendarListTitle;
		private System.Windows.Forms.Panel pnEmpty;
	}
}
