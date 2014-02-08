namespace OnlineCalendars.Manager.PresentationClasses.CalendarList
{
	partial class FormCalendarEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendarEdit));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
			this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
			this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
			this.pnButtons = new System.Windows.Forms.Panel();
			this.styleController = new DevExpress.XtraEditors.StyleController(this.components);
			this.textEditName = new DevExpress.XtraEditors.TextEdit();
			this.labelControlName = new DevExpress.XtraEditors.LabelControl();
			this.dateEditStart = new DevExpress.XtraEditors.DateEdit();
			this.labelControlStart = new DevExpress.XtraEditors.LabelControl();
			this.labelControlEnd = new DevExpress.XtraEditors.LabelControl();
			this.dateEditEnd = new DevExpress.XtraEditors.DateEdit();
			this.pnButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// simpleButtonSave
			// 
			this.simpleButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButtonSave.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.simpleButtonSave.Appearance.Options.UseFont = true;
			this.simpleButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.simpleButtonSave.Location = new System.Drawing.Point(252, 8);
			this.simpleButtonSave.Name = "simpleButtonSave";
			this.simpleButtonSave.Size = new System.Drawing.Size(87, 32);
			this.simpleButtonSave.TabIndex = 6;
			this.simpleButtonSave.Text = "Save";
			this.simpleButtonSave.ToolTipController = this.toolTipController;
			// 
			// toolTipController
			// 
			this.toolTipController.InitialDelay = 1;
			this.toolTipController.Rounded = true;
			this.toolTipController.ToolTipLocation = DevExpress.Utils.ToolTipLocation.TopRight;
			this.toolTipController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
			// 
			// simpleButtonCancel
			// 
			this.simpleButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.simpleButtonCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.simpleButtonCancel.Appearance.Options.UseFont = true;
			this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.simpleButtonCancel.Location = new System.Drawing.Point(365, 8);
			this.simpleButtonCancel.Name = "simpleButtonCancel";
			this.simpleButtonCancel.Size = new System.Drawing.Size(87, 32);
			this.simpleButtonCancel.TabIndex = 5;
			this.simpleButtonCancel.Text = "Cancel";
			// 
			// pnButtons
			// 
			this.pnButtons.Controls.Add(this.simpleButtonSave);
			this.pnButtons.Controls.Add(this.simpleButtonCancel);
			this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnButtons.Location = new System.Drawing.Point(0, 92);
			this.pnButtons.Name = "pnButtons";
			this.pnButtons.Size = new System.Drawing.Size(461, 49);
			this.pnButtons.TabIndex = 8;
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
			// textEditName
			// 
			this.textEditName.Location = new System.Drawing.Point(111, 9);
			this.textEditName.Name = "textEditName";
			this.textEditName.Properties.MaxLength = 30;
			this.textEditName.Size = new System.Drawing.Size(341, 22);
			this.textEditName.StyleController = this.styleController;
			this.textEditName.TabIndex = 9;
			// 
			// labelControlName
			// 
			this.labelControlName.Location = new System.Drawing.Point(12, 12);
			this.labelControlName.Name = "labelControlName";
			this.labelControlName.Size = new System.Drawing.Size(93, 16);
			this.labelControlName.StyleController = this.styleController;
			this.labelControlName.TabIndex = 10;
			this.labelControlName.Text = "Calendar Name:";
			// 
			// dateEditStart
			// 
			this.dateEditStart.EditValue = null;
			this.dateEditStart.Location = new System.Drawing.Point(111, 58);
			this.dateEditStart.Name = "dateEditStart";
			this.dateEditStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("dateEditStart.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
			this.dateEditStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.dateEditStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dateEditStart.Size = new System.Drawing.Size(112, 22);
			this.dateEditStart.StyleController = this.styleController;
			this.dateEditStart.TabIndex = 11;
			// 
			// labelControlStart
			// 
			this.labelControlStart.Location = new System.Drawing.Point(12, 61);
			this.labelControlStart.Name = "labelControlStart";
			this.labelControlStart.Size = new System.Drawing.Size(87, 16);
			this.labelControlStart.StyleController = this.styleController;
			this.labelControlStart.TabIndex = 12;
			this.labelControlStart.Text = "Calendar Start:";
			// 
			// labelControlEnd
			// 
			this.labelControlEnd.Location = new System.Drawing.Point(241, 61);
			this.labelControlEnd.Name = "labelControlEnd";
			this.labelControlEnd.Size = new System.Drawing.Size(82, 16);
			this.labelControlEnd.StyleController = this.styleController;
			this.labelControlEnd.TabIndex = 14;
			this.labelControlEnd.Text = "Calendar End:";
			// 
			// dateEditEnd
			// 
			this.dateEditEnd.EditValue = null;
			this.dateEditEnd.Location = new System.Drawing.Point(340, 58);
			this.dateEditEnd.Name = "dateEditEnd";
			this.dateEditEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("dateEditEnd.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
			this.dateEditEnd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.dateEditEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.dateEditEnd.Size = new System.Drawing.Size(112, 22);
			this.dateEditEnd.StyleController = this.styleController;
			this.dateEditEnd.TabIndex = 13;
			// 
			// FormCalendarEdit
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(461, 141);
			this.Controls.Add(this.labelControlEnd);
			this.Controls.Add(this.dateEditEnd);
			this.Controls.Add(this.labelControlStart);
			this.Controls.Add(this.dateEditStart);
			this.Controls.Add(this.labelControlName);
			this.Controls.Add(this.textEditName);
			this.Controls.Add(this.pnButtons);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCalendarEdit";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormCalendarEdit";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalendarEdit_FormClosing);
			this.pnButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditStart.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateEditEnd.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
		private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
		private System.Windows.Forms.Panel pnButtons;
		private DevExpress.XtraEditors.StyleController styleController;
		private DevExpress.XtraEditors.LabelControl labelControlName;
		private DevExpress.XtraEditors.LabelControl labelControlStart;
		private DevExpress.XtraEditors.LabelControl labelControlEnd;
		public DevExpress.XtraEditors.TextEdit textEditName;
		public DevExpress.XtraEditors.DateEdit dateEditStart;
		public DevExpress.XtraEditors.DateEdit dateEditEnd;
		private DevExpress.Utils.ToolTipController toolTipController;
	}
}