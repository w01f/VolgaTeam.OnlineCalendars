namespace OnlineCalendars.Manager.PresentationClasses.CalendarList
{
	partial class CalendarListControl
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
			this.barManager = new DevExpress.XtraBars.BarManager(this.components);
			this.barMainToolbar = new DevExpress.XtraBars.Bar();
			this.barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemClone = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemHelp = new DevExpress.XtraBars.BarButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.gridControlList = new DevExpress.XtraGrid.GridControl();
			this.gridViewList = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
			this.gridBandName = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.bandedGridColumnName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.bandedGridColumnRange = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewList)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager
			// 
			this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMainToolbar});
			this.barManager.DockControls.Add(this.barDockControlTop);
			this.barManager.DockControls.Add(this.barDockControlBottom);
			this.barManager.DockControls.Add(this.barDockControlLeft);
			this.barManager.DockControls.Add(this.barDockControlRight);
			this.barManager.Form = this;
			this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItemAdd,
            this.barButtonItemClone,
            this.barButtonItemHelp,
            this.barButtonItemEdit,
            this.barButtonItemDelete});
			this.barManager.MaxItemId = 5;
			// 
			// barMainToolbar
			// 
			this.barMainToolbar.BarName = "Main Toolbar";
			this.barMainToolbar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
			this.barMainToolbar.DockCol = 0;
			this.barMainToolbar.DockRow = 0;
			this.barMainToolbar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.barMainToolbar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemClone),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemHelp)});
			this.barMainToolbar.OptionsBar.AllowQuickCustomization = false;
			this.barMainToolbar.OptionsBar.DisableClose = true;
			this.barMainToolbar.OptionsBar.DisableCustomization = true;
			this.barMainToolbar.OptionsBar.DrawDragBorder = false;
			this.barMainToolbar.OptionsBar.RotateWhenVertical = false;
			this.barMainToolbar.OptionsBar.UseWholeRow = true;
			this.barMainToolbar.Text = "Main Toolbar";
			// 
			// barButtonItemAdd
			// 
			this.barButtonItemAdd.Caption = "Add";
			this.barButtonItemAdd.Glyph = global::OnlineCalendars.Manager.Properties.Resources.AddCalendar;
			this.barButtonItemAdd.Id = 0;
			this.barButtonItemAdd.Name = "barButtonItemAdd";
			this.barButtonItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAdd_ItemClick);
			// 
			// barButtonItemEdit
			// 
			this.barButtonItemEdit.Caption = "Edit";
			this.barButtonItemEdit.Glyph = global::OnlineCalendars.Manager.Properties.Resources.EditCalendar;
			this.barButtonItemEdit.Id = 3;
			this.barButtonItemEdit.Name = "barButtonItemEdit";
			this.barButtonItemEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemEdit_ItemClick);
			// 
			// barButtonItemClone
			// 
			this.barButtonItemClone.Caption = "Clone";
			this.barButtonItemClone.Glyph = global::OnlineCalendars.Manager.Properties.Resources.CloneCalendar;
			this.barButtonItemClone.Id = 1;
			this.barButtonItemClone.Name = "barButtonItemClone";
			this.barButtonItemClone.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClone_ItemClick);
			// 
			// barButtonItemDelete
			// 
			this.barButtonItemDelete.Caption = "Delete";
			this.barButtonItemDelete.Glyph = global::OnlineCalendars.Manager.Properties.Resources.DeleteCalendar;
			this.barButtonItemDelete.Id = 4;
			this.barButtonItemDelete.Name = "barButtonItemDelete";
			this.barButtonItemDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDelete_ItemClick);
			// 
			// barButtonItemHelp
			// 
			this.barButtonItemHelp.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.barButtonItemHelp.Caption = "Help";
			this.barButtonItemHelp.Glyph = global::OnlineCalendars.Manager.Properties.Resources.HelpSmall;
			this.barButtonItemHelp.Id = 2;
			this.barButtonItemHelp.Name = "barButtonItemHelp";
			this.barButtonItemHelp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemHelp_ItemClick);
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(250, 48);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 510);
			this.barDockControlBottom.Size = new System.Drawing.Size(250, 0);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 462);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(250, 48);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 462);
			// 
			// gridControlList
			// 
			this.gridControlList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControlList.Location = new System.Drawing.Point(0, 48);
			this.gridControlList.MainView = this.gridViewList;
			this.gridControlList.MenuManager = this.barManager;
			this.gridControlList.Name = "gridControlList";
			this.gridControlList.Size = new System.Drawing.Size(250, 462);
			this.gridControlList.TabIndex = 4;
			this.gridControlList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewList});
			// 
			// gridViewList
			// 
			this.gridViewList.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBandName});
			this.gridViewList.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumnName,
            this.bandedGridColumnRange});
			this.gridViewList.GridControl = this.gridControlList;
			this.gridViewList.Name = "gridViewList";
			this.gridViewList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridViewList.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
			this.gridViewList.OptionsBehavior.AutoPopulateColumns = false;
			this.gridViewList.OptionsBehavior.AutoSelectAllInEditor = false;
			this.gridViewList.OptionsBehavior.Editable = false;
			this.gridViewList.OptionsBehavior.ReadOnly = true;
			this.gridViewList.OptionsCustomization.AllowFilter = false;
			this.gridViewList.OptionsCustomization.AllowGroup = false;
			this.gridViewList.OptionsCustomization.AllowQuickHideColumns = false;
			this.gridViewList.OptionsCustomization.AllowSort = false;
			this.gridViewList.OptionsCustomization.ShowBandsInCustomizationForm = false;
			this.gridViewList.OptionsMenu.EnableColumnMenu = false;
			this.gridViewList.OptionsMenu.EnableFooterMenu = false;
			this.gridViewList.OptionsMenu.EnableGroupPanelMenu = false;
			this.gridViewList.OptionsMenu.ShowAutoFilterRowItem = false;
			this.gridViewList.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
			this.gridViewList.OptionsMenu.ShowGroupSortSummaryItems = false;
			this.gridViewList.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridViewList.OptionsSelection.EnableAppearanceHideSelection = false;
			this.gridViewList.OptionsView.ColumnAutoWidth = true;
			this.gridViewList.OptionsView.ShowBands = false;
			this.gridViewList.OptionsView.ShowColumnHeaders = false;
			this.gridViewList.OptionsView.ShowDetailButtons = false;
			this.gridViewList.OptionsView.ShowGroupPanel = false;
			this.gridViewList.OptionsView.ShowIndicator = false;
			this.gridViewList.RowSeparatorHeight = 5;
			this.gridViewList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewList_RowClick);
			this.gridViewList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewList_FocusedRowChanged);
			// 
			// gridBandName
			// 
			this.gridBandName.Caption = "Name";
			this.gridBandName.Columns.Add(this.bandedGridColumnName);
			this.gridBandName.Columns.Add(this.bandedGridColumnRange);
			this.gridBandName.Name = "gridBandName";
			this.gridBandName.Width = 75;
			// 
			// bandedGridColumnName
			// 
			this.bandedGridColumnName.AppearanceCell.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bandedGridColumnName.AppearanceCell.Options.UseFont = true;
			this.bandedGridColumnName.Caption = "Name";
			this.bandedGridColumnName.FieldName = "Name";
			this.bandedGridColumnName.Name = "bandedGridColumnName";
			this.bandedGridColumnName.Visible = true;
			// 
			// bandedGridColumnRange
			// 
			this.bandedGridColumnRange.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bandedGridColumnRange.AppearanceCell.Options.UseFont = true;
			this.bandedGridColumnRange.Caption = "Range";
			this.bandedGridColumnRange.FieldName = "Range";
			this.bandedGridColumnRange.Name = "bandedGridColumnRange";
			this.bandedGridColumnRange.RowIndex = 1;
			this.bandedGridColumnRange.Visible = true;
			// 
			// CalendarListControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.gridControlList);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MinimumSize = new System.Drawing.Size(250, 0);
			this.Name = "CalendarListControl";
			this.Size = new System.Drawing.Size(250, 510);
			((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager;
		private DevExpress.XtraBars.Bar barMainToolbar;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
		private DevExpress.XtraBars.BarButtonItem barButtonItemClone;
		private DevExpress.XtraBars.BarButtonItem barButtonItemHelp;
		private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
		private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
		private DevExpress.XtraGrid.GridControl gridControlList;
		private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridViewList;
		private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandName;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnName;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumnRange;
	}
}
