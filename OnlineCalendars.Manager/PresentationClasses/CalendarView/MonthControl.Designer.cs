namespace OnlineCalendars.Manager.PresentationClasses.CalendarView
{
    partial class MonthControl
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
			this.pnData = new System.Windows.Forms.Panel();
			this.pnMain = new System.Windows.Forms.Panel();
			this.pnHeader = new System.Windows.Forms.Panel();
			this.pnSaturday = new System.Windows.Forms.Panel();
			this.laSaturday = new System.Windows.Forms.Label();
			this.pnFriday = new System.Windows.Forms.Panel();
			this.laFriday = new System.Windows.Forms.Label();
			this.pnThursday = new System.Windows.Forms.Panel();
			this.laThursday = new System.Windows.Forms.Label();
			this.pnWednesday = new System.Windows.Forms.Panel();
			this.laWednesday = new System.Windows.Forms.Label();
			this.pnTuesday = new System.Windows.Forms.Panel();
			this.laTuesday = new System.Windows.Forms.Label();
			this.pnMonday = new System.Windows.Forms.Panel();
			this.laMonday = new System.Windows.Forms.Label();
			this.pnSunday = new System.Windows.Forms.Panel();
			this.laSunday = new System.Windows.Forms.Label();
			this.pnEmpty = new System.Windows.Forms.Panel();
			this.pnMain.SuspendLayout();
			this.pnHeader.SuspendLayout();
			this.pnSaturday.SuspendLayout();
			this.pnFriday.SuspendLayout();
			this.pnThursday.SuspendLayout();
			this.pnWednesday.SuspendLayout();
			this.pnTuesday.SuspendLayout();
			this.pnMonday.SuspendLayout();
			this.pnSunday.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnData
			// 
			this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnData.Location = new System.Drawing.Point(0, 26);
			this.pnData.Name = "pnData";
			this.pnData.Size = new System.Drawing.Size(1000, 474);
			this.pnData.TabIndex = 1;
			// 
			// pnMain
			// 
			this.pnMain.Controls.Add(this.pnData);
			this.pnMain.Controls.Add(this.pnHeader);
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnMain.Location = new System.Drawing.Point(0, 0);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(1000, 500);
			this.pnMain.TabIndex = 2;
			// 
			// pnHeader
			// 
			this.pnHeader.BackColor = System.Drawing.SystemColors.Control;
			this.pnHeader.Controls.Add(this.pnSaturday);
			this.pnHeader.Controls.Add(this.pnFriday);
			this.pnHeader.Controls.Add(this.pnThursday);
			this.pnHeader.Controls.Add(this.pnWednesday);
			this.pnHeader.Controls.Add(this.pnTuesday);
			this.pnHeader.Controls.Add(this.pnMonday);
			this.pnHeader.Controls.Add(this.pnSunday);
			this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnHeader.Location = new System.Drawing.Point(0, 0);
			this.pnHeader.Name = "pnHeader";
			this.pnHeader.Size = new System.Drawing.Size(1000, 26);
			this.pnHeader.TabIndex = 2;
			// 
			// pnSaturday
			// 
			this.pnSaturday.BackColor = System.Drawing.Color.DarkGray;
			this.pnSaturday.Controls.Add(this.laSaturday);
			this.pnSaturday.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnSaturday.Location = new System.Drawing.Point(556, 0);
			this.pnSaturday.Name = "pnSaturday";
			this.pnSaturday.Padding = new System.Windows.Forms.Padding(1);
			this.pnSaturday.Size = new System.Drawing.Size(99, 26);
			this.pnSaturday.TabIndex = 13;
			// 
			// laSaturday
			// 
			this.laSaturday.BackColor = System.Drawing.SystemColors.Control;
			this.laSaturday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laSaturday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laSaturday.Location = new System.Drawing.Point(1, 1);
			this.laSaturday.Name = "laSaturday";
			this.laSaturday.Size = new System.Drawing.Size(97, 24);
			this.laSaturday.TabIndex = 5;
			this.laSaturday.Text = "Saturday";
			this.laSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnFriday
			// 
			this.pnFriday.BackColor = System.Drawing.Color.DarkGray;
			this.pnFriday.Controls.Add(this.laFriday);
			this.pnFriday.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnFriday.Location = new System.Drawing.Point(457, 0);
			this.pnFriday.Name = "pnFriday";
			this.pnFriday.Padding = new System.Windows.Forms.Padding(1);
			this.pnFriday.Size = new System.Drawing.Size(99, 26);
			this.pnFriday.TabIndex = 12;
			// 
			// laFriday
			// 
			this.laFriday.BackColor = System.Drawing.SystemColors.Control;
			this.laFriday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laFriday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laFriday.Location = new System.Drawing.Point(1, 1);
			this.laFriday.Name = "laFriday";
			this.laFriday.Size = new System.Drawing.Size(97, 24);
			this.laFriday.TabIndex = 4;
			this.laFriday.Text = "Friday";
			this.laFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnThursday
			// 
			this.pnThursday.BackColor = System.Drawing.Color.DarkGray;
			this.pnThursday.Controls.Add(this.laThursday);
			this.pnThursday.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnThursday.Location = new System.Drawing.Point(358, 0);
			this.pnThursday.Name = "pnThursday";
			this.pnThursday.Padding = new System.Windows.Forms.Padding(1);
			this.pnThursday.Size = new System.Drawing.Size(99, 26);
			this.pnThursday.TabIndex = 11;
			// 
			// laThursday
			// 
			this.laThursday.BackColor = System.Drawing.SystemColors.Control;
			this.laThursday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laThursday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laThursday.Location = new System.Drawing.Point(1, 1);
			this.laThursday.Name = "laThursday";
			this.laThursday.Size = new System.Drawing.Size(97, 24);
			this.laThursday.TabIndex = 1;
			this.laThursday.Text = "Thursday";
			this.laThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnWednesday
			// 
			this.pnWednesday.BackColor = System.Drawing.Color.DarkGray;
			this.pnWednesday.Controls.Add(this.laWednesday);
			this.pnWednesday.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnWednesday.Location = new System.Drawing.Point(259, 0);
			this.pnWednesday.Name = "pnWednesday";
			this.pnWednesday.Padding = new System.Windows.Forms.Padding(1);
			this.pnWednesday.Size = new System.Drawing.Size(99, 26);
			this.pnWednesday.TabIndex = 10;
			// 
			// laWednesday
			// 
			this.laWednesday.BackColor = System.Drawing.SystemColors.Control;
			this.laWednesday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laWednesday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laWednesday.Location = new System.Drawing.Point(1, 1);
			this.laWednesday.Name = "laWednesday";
			this.laWednesday.Size = new System.Drawing.Size(97, 24);
			this.laWednesday.TabIndex = 2;
			this.laWednesday.Text = "Wednesday";
			this.laWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnTuesday
			// 
			this.pnTuesday.BackColor = System.Drawing.Color.DarkGray;
			this.pnTuesday.Controls.Add(this.laTuesday);
			this.pnTuesday.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnTuesday.Location = new System.Drawing.Point(160, 0);
			this.pnTuesday.Name = "pnTuesday";
			this.pnTuesday.Padding = new System.Windows.Forms.Padding(1);
			this.pnTuesday.Size = new System.Drawing.Size(99, 26);
			this.pnTuesday.TabIndex = 9;
			// 
			// laTuesday
			// 
			this.laTuesday.BackColor = System.Drawing.SystemColors.Control;
			this.laTuesday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laTuesday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laTuesday.Location = new System.Drawing.Point(1, 1);
			this.laTuesday.Name = "laTuesday";
			this.laTuesday.Size = new System.Drawing.Size(97, 24);
			this.laTuesday.TabIndex = 3;
			this.laTuesday.Text = "Tuesday";
			this.laTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnMonday
			// 
			this.pnMonday.BackColor = System.Drawing.Color.DarkGray;
			this.pnMonday.Controls.Add(this.laMonday);
			this.pnMonday.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnMonday.Location = new System.Drawing.Point(79, 0);
			this.pnMonday.Name = "pnMonday";
			this.pnMonday.Padding = new System.Windows.Forms.Padding(1);
			this.pnMonday.Size = new System.Drawing.Size(81, 26);
			this.pnMonday.TabIndex = 8;
			// 
			// laMonday
			// 
			this.laMonday.BackColor = System.Drawing.SystemColors.Control;
			this.laMonday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laMonday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laMonday.Location = new System.Drawing.Point(1, 1);
			this.laMonday.Name = "laMonday";
			this.laMonday.Size = new System.Drawing.Size(79, 24);
			this.laMonday.TabIndex = 0;
			this.laMonday.Text = "Monday";
			this.laMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnSunday
			// 
			this.pnSunday.BackColor = System.Drawing.Color.DarkGray;
			this.pnSunday.Controls.Add(this.laSunday);
			this.pnSunday.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnSunday.Location = new System.Drawing.Point(0, 0);
			this.pnSunday.Name = "pnSunday";
			this.pnSunday.Padding = new System.Windows.Forms.Padding(1);
			this.pnSunday.Size = new System.Drawing.Size(79, 26);
			this.pnSunday.TabIndex = 7;
			// 
			// laSunday
			// 
			this.laSunday.BackColor = System.Drawing.SystemColors.Control;
			this.laSunday.Dock = System.Windows.Forms.DockStyle.Fill;
			this.laSunday.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laSunday.Location = new System.Drawing.Point(1, 1);
			this.laSunday.Name = "laSunday";
			this.laSunday.Size = new System.Drawing.Size(77, 24);
			this.laSunday.TabIndex = 6;
			this.laSunday.Text = "Sunday";
			this.laSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnEmpty
			// 
			this.pnEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnEmpty.Location = new System.Drawing.Point(0, 0);
			this.pnEmpty.Name = "pnEmpty";
			this.pnEmpty.Size = new System.Drawing.Size(1000, 500);
			this.pnEmpty.TabIndex = 3;
			// 
			// MonthControl
			// 
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.pnMain);
			this.Controls.Add(this.pnEmpty);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "MonthControl";
			this.Size = new System.Drawing.Size(1000, 500);
			this.pnMain.ResumeLayout(false);
			this.pnHeader.ResumeLayout(false);
			this.pnSaturday.ResumeLayout(false);
			this.pnFriday.ResumeLayout(false);
			this.pnThursday.ResumeLayout(false);
			this.pnWednesday.ResumeLayout(false);
			this.pnTuesday.ResumeLayout(false);
			this.pnMonday.ResumeLayout(false);
			this.pnSunday.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnEmpty;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnSaturday;
        private System.Windows.Forms.Label laSaturday;
        private System.Windows.Forms.Panel pnFriday;
        private System.Windows.Forms.Label laFriday;
        private System.Windows.Forms.Panel pnThursday;
        private System.Windows.Forms.Label laThursday;
        private System.Windows.Forms.Panel pnWednesday;
        private System.Windows.Forms.Label laWednesday;
        private System.Windows.Forms.Panel pnTuesday;
        private System.Windows.Forms.Label laTuesday;
        private System.Windows.Forms.Panel pnMonday;
        private System.Windows.Forms.Label laMonday;
        private System.Windows.Forms.Panel pnSunday;
        private System.Windows.Forms.Label laSunday;
    }
}
