namespace OnlineCalendars.Manager.PresentationClasses.CalendarView
{
    partial class DayControl
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
			this.components = new System.ComponentModel.Container();
			this.laSmallDayCaption = new System.Windows.Forms.Label();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemClone = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.pnData = new System.Windows.Forms.Panel();
			this.xtraScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
			this.memoEditSimpleComment = new DevExpress.XtraEditors.MemoEdit();
			this.styleController = new DevExpress.XtraEditors.StyleController(this.components);
			this.labelControlData = new DevExpress.XtraEditors.LabelControl();
			this.contextMenuStrip.SuspendLayout();
			this.pnData.SuspendLayout();
			this.xtraScrollableControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.memoEditSimpleComment.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
			this.SuspendLayout();
			// 
			// laSmallDayCaption
			// 
			this.laSmallDayCaption.BackColor = System.Drawing.SystemColors.Control;
			this.laSmallDayCaption.ContextMenuStrip = this.contextMenuStrip;
			this.laSmallDayCaption.Dock = System.Windows.Forms.DockStyle.Top;
			this.laSmallDayCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laSmallDayCaption.Location = new System.Drawing.Point(1, 1);
			this.laSmallDayCaption.Name = "laSmallDayCaption";
			this.laSmallDayCaption.Size = new System.Drawing.Size(274, 20);
			this.laSmallDayCaption.TabIndex = 0;
			this.laSmallDayCaption.Text = "label1";
			this.laSmallDayCaption.DoubleClick += new System.EventHandler(this.Control_DoubleClick);
			this.laSmallDayCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseDown);
			this.laSmallDayCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseMove);
			this.laSmallDayCaption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseUp);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemPaste,
            this.toolStripMenuItemClone,
            this.toolStripMenuItemDelete,
            this.toolStripSeparator1});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(163, 162);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
			this.contextMenuStrip.Opened += new System.EventHandler(this.contextMenuStrip_Opened);
			// 
			// toolStripMenuItemCopy
			// 
			this.toolStripMenuItemCopy.Enabled = false;
			this.toolStripMenuItemCopy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItemCopy.Image = global::OnlineCalendars.Manager.Properties.Resources.CopyData;
			this.toolStripMenuItemCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
			this.toolStripMenuItemCopy.Size = new System.Drawing.Size(162, 38);
			this.toolStripMenuItemCopy.Text = "Copy Data";
			this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
			// 
			// toolStripMenuItemPaste
			// 
			this.toolStripMenuItemPaste.Enabled = false;
			this.toolStripMenuItemPaste.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItemPaste.Image = global::OnlineCalendars.Manager.Properties.Resources.PasteData;
			this.toolStripMenuItemPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItemPaste.Name = "toolStripMenuItemPaste";
			this.toolStripMenuItemPaste.Size = new System.Drawing.Size(162, 38);
			this.toolStripMenuItemPaste.Text = "Paste Data";
			this.toolStripMenuItemPaste.Click += new System.EventHandler(this.toolStripMenuItemPaste_Click);
			// 
			// toolStripMenuItemClone
			// 
			this.toolStripMenuItemClone.Enabled = false;
			this.toolStripMenuItemClone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItemClone.Image = global::OnlineCalendars.Manager.Properties.Resources.CloneData;
			this.toolStripMenuItemClone.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItemClone.Name = "toolStripMenuItemClone";
			this.toolStripMenuItemClone.Size = new System.Drawing.Size(162, 38);
			this.toolStripMenuItemClone.Text = "Clone Day...";
			this.toolStripMenuItemClone.Click += new System.EventHandler(this.toolStripMenuItemClone_Click);
			// 
			// toolStripMenuItemDelete
			// 
			this.toolStripMenuItemDelete.Enabled = false;
			this.toolStripMenuItemDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripMenuItemDelete.Image = global::OnlineCalendars.Manager.Properties.Resources.DeleteData;
			this.toolStripMenuItemDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
			this.toolStripMenuItemDelete.Size = new System.Drawing.Size(162, 38);
			this.toolStripMenuItemDelete.Text = "Delete Data";
			this.toolStripMenuItemDelete.Click += new System.EventHandler(this.toolStripMenuItemDelete_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
			// 
			// pnData
			// 
			this.pnData.BackColor = System.Drawing.SystemColors.Control;
			this.pnData.Controls.Add(this.xtraScrollableControl);
			this.pnData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnData.Location = new System.Drawing.Point(1, 21);
			this.pnData.Name = "pnData";
			this.pnData.Size = new System.Drawing.Size(274, 225);
			this.pnData.TabIndex = 1;
			// 
			// xtraScrollableControl
			// 
			this.xtraScrollableControl.AlwaysScrollActiveControlIntoView = false;
			this.xtraScrollableControl.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.xtraScrollableControl.Appearance.Options.UseBackColor = true;
			this.xtraScrollableControl.ContextMenuStrip = this.contextMenuStrip;
			this.xtraScrollableControl.Controls.Add(this.memoEditSimpleComment);
			this.xtraScrollableControl.Controls.Add(this.labelControlData);
			this.xtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraScrollableControl.Location = new System.Drawing.Point(0, 0);
			this.xtraScrollableControl.Name = "xtraScrollableControl";
			this.xtraScrollableControl.Padding = new System.Windows.Forms.Padding(3);
			this.xtraScrollableControl.Size = new System.Drawing.Size(274, 225);
			this.xtraScrollableControl.TabIndex = 0;
			this.xtraScrollableControl.DoubleClick += new System.EventHandler(this.Control_DoubleClick);
			this.xtraScrollableControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseDown);
			this.xtraScrollableControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseMove);
			this.xtraScrollableControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseUp);
			// 
			// memoEditSimpleComment
			// 
			this.memoEditSimpleComment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.memoEditSimpleComment.Location = new System.Drawing.Point(3, 19);
			this.memoEditSimpleComment.Name = "memoEditSimpleComment";
			this.memoEditSimpleComment.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
			this.memoEditSimpleComment.Properties.Appearance.Options.UseBackColor = true;
			this.memoEditSimpleComment.Size = new System.Drawing.Size(268, 203);
			this.memoEditSimpleComment.StyleController = this.styleController;
			this.memoEditSimpleComment.TabIndex = 2;
			this.memoEditSimpleComment.Visible = false;
			this.memoEditSimpleComment.EditValueChanged += new System.EventHandler(this.memoEditSimpleComment_EditValueChanged);
			this.memoEditSimpleComment.Leave += new System.EventHandler(this.memoEditSimpleComment_Leave);
			this.memoEditSimpleComment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseDown);
			this.memoEditSimpleComment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseUp);
			// 
			// styleController
			// 
			this.styleController.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.styleController.Appearance.Options.UseFont = true;
			this.styleController.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceDisabled.Options.UseFont = true;
			this.styleController.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceDropDown.Options.UseFont = true;
			this.styleController.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceDropDownHeader.Options.UseFont = true;
			this.styleController.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceFocused.Options.UseFont = true;
			this.styleController.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
			this.styleController.AppearanceReadOnly.Options.UseFont = true;
			// 
			// labelControlData
			// 
			this.labelControlData.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.labelControlData.ContextMenuStrip = this.contextMenuStrip;
			this.labelControlData.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelControlData.Location = new System.Drawing.Point(3, 3);
			this.labelControlData.Name = "labelControlData";
			this.labelControlData.Size = new System.Drawing.Size(268, 16);
			this.labelControlData.StyleController = this.styleController;
			this.labelControlData.TabIndex = 0;
			this.labelControlData.Text = "Data";
			this.labelControlData.DoubleClick += new System.EventHandler(this.Control_DoubleClick);
			this.labelControlData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseDown);
			this.labelControlData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseMove);
			this.labelControlData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseUp);
			// 
			// DayControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.Controls.Add(this.pnData);
			this.Controls.Add(this.laSmallDayCaption);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Arial", 9.75F);
			this.Name = "DayControl";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.Size = new System.Drawing.Size(276, 247);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DayControl_MouseUp);
			this.contextMenuStrip.ResumeLayout(false);
			this.pnData.ResumeLayout(false);
			this.xtraScrollableControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.memoEditSimpleComment.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label laSmallDayCaption;
        private System.Windows.Forms.Panel pnData;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl;
        private DevExpress.XtraEditors.LabelControl labelControlData;
		private DevExpress.XtraEditors.StyleController styleController;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaste;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
		public System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClone;
		private DevExpress.XtraEditors.MemoEdit memoEditSimpleComment;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
