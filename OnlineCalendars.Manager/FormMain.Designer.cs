namespace OnlineCalendars.Manager
{
	partial class FormMain
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
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
			this.ribbonPanelSiteUsers = new DevComponents.DotNetBar.RibbonPanel();
			this.ribbonBarSiteUsersExit = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonBarSiteUsersHelp = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonBarSiteUsersRefresh = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonBarSiteUsersDelete = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonBarSiteUsersEdit = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonBarSiteUsersAdd = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonPanelCalendarEditor = new DevComponents.DotNetBar.RibbonPanel();
			this.ribbonBarCalendarEditorExit = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonBarCalendarEditorHelp = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonBarCalendarSync = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonBarCalendarSite = new DevComponents.DotNetBar.RibbonBar();
			this.buttonEditCalendarSiteName = new DevExpress.XtraEditors.ButtonEdit();
			this.styleController = new DevExpress.XtraEditors.StyleController(this.components);
			this.buttonEditCalendarSiteLogin = new DevExpress.XtraEditors.ButtonEdit();
			this.buttonEditCalendarSitePassword = new DevExpress.XtraEditors.ButtonEdit();
			this.itemContainerCalendarSiteName = new DevComponents.DotNetBar.ItemContainer();
			this.labelItemCalendarSiteName = new DevComponents.DotNetBar.LabelItem();
			this.itemContainerIPadSiteValue = new DevComponents.DotNetBar.ItemContainer();
			this.controlContainerItemIPadSite = new DevComponents.DotNetBar.ControlContainerItem();
			this.itemContainerCalendarSiteCredentials = new DevComponents.DotNetBar.ItemContainer();
			this.itemContainerCalendarSiteLogin = new DevComponents.DotNetBar.ItemContainer();
			this.labelItemCalendarSiteLogin = new DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
			this.itemContainerCalendarSitePassword = new DevComponents.DotNetBar.ItemContainer();
			this.labelItemCalendarSitePassword = new DevComponents.DotNetBar.LabelItem();
			this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
			this.ribbonBarCalendarEditorConfiguration = new DevComponents.DotNetBar.RibbonBar();
			this.ribbonTabItemCalendarEditor = new DevComponents.DotNetBar.RibbonTabItem();
			this.ribbonTabItemSiteUsers = new DevComponents.DotNetBar.RibbonTabItem();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
			this.pnMain = new System.Windows.Forms.Panel();
			this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
			this.pnEmpty = new System.Windows.Forms.Panel();
			this.buttonItemSiteUsersExit = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemSiteUsersHelp = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemSiteUsersRefresh = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemSiteUsersDelete = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemSiteUsersEdit = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemSiteUsersAdd = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemCalendarEditorExit = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemCalendarEditorHelp = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemCalendarSync = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemCalendarEditorConfigurationNew = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItemCalendarEditorConfigurationOpen = new DevComponents.DotNetBar.ButtonItem();
			this.ribbonControl.SuspendLayout();
			this.ribbonPanelSiteUsers.SuspendLayout();
			this.ribbonPanelCalendarEditor.SuspendLayout();
			this.ribbonBarCalendarSite.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.buttonEditCalendarSiteName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEditCalendarSiteLogin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEditCalendarSitePassword.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl
			// 
			this.ribbonControl.AutoExpand = false;
			this.ribbonControl.BackColor = System.Drawing.Color.White;
			// 
			// 
			// 
			this.ribbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonControl.CanCustomize = false;
			this.ribbonControl.Controls.Add(this.ribbonPanelCalendarEditor);
			this.ribbonControl.Controls.Add(this.ribbonPanelSiteUsers);
			this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.ribbonControl.EnableQatPlacement = false;
			this.ribbonControl.ForeColor = System.Drawing.Color.Black;
			this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItemCalendarEditor,
            this.ribbonTabItemSiteUsers});
			this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
			this.ribbonControl.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl.MdiSystemItemVisible = false;
			this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.ribbonControl.Size = new System.Drawing.Size(984, 165);
			this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonControl.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
			this.ribbonControl.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
			this.ribbonControl.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
			this.ribbonControl.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
			this.ribbonControl.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
			this.ribbonControl.SystemText.QatDialogAddButton = "&Add >>";
			this.ribbonControl.SystemText.QatDialogCancelButton = "Cancel";
			this.ribbonControl.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
			this.ribbonControl.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
			this.ribbonControl.SystemText.QatDialogOkButton = "OK";
			this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
			this.ribbonControl.SystemText.QatDialogRemoveButton = "&Remove";
			this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
			this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
			this.ribbonControl.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
			this.ribbonControl.TabGroupHeight = 14;
			this.ribbonControl.TabIndex = 1;
			// 
			// ribbonPanelSiteUsers
			// 
			this.ribbonPanelSiteUsers.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonPanelSiteUsers.Controls.Add(this.ribbonBarSiteUsersExit);
			this.ribbonPanelSiteUsers.Controls.Add(this.ribbonBarSiteUsersHelp);
			this.ribbonPanelSiteUsers.Controls.Add(this.ribbonBarSiteUsersRefresh);
			this.ribbonPanelSiteUsers.Controls.Add(this.ribbonBarSiteUsersDelete);
			this.ribbonPanelSiteUsers.Controls.Add(this.ribbonBarSiteUsersEdit);
			this.ribbonPanelSiteUsers.Controls.Add(this.ribbonBarSiteUsersAdd);
			this.ribbonPanelSiteUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ribbonPanelSiteUsers.Location = new System.Drawing.Point(0, 25);
			this.ribbonPanelSiteUsers.Name = "ribbonPanelSiteUsers";
			this.ribbonPanelSiteUsers.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.ribbonPanelSiteUsers.Size = new System.Drawing.Size(984, 137);
			// 
			// 
			// 
			this.ribbonPanelSiteUsers.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonPanelSiteUsers.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonPanelSiteUsers.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonPanelSiteUsers.TabIndex = 10;
			this.ribbonPanelSiteUsers.Visible = false;
			// 
			// ribbonBarSiteUsersExit
			// 
			this.ribbonBarSiteUsersExit.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarSiteUsersExit.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersExit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarSiteUsersExit.ContainerControlProcessDialogKey = true;
			this.ribbonBarSiteUsersExit.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarSiteUsersExit.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSiteUsersExit});
			this.ribbonBarSiteUsersExit.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarSiteUsersExit.Location = new System.Drawing.Point(424, 0);
			this.ribbonBarSiteUsersExit.Name = "ribbonBarSiteUsersExit";
			this.ribbonBarSiteUsersExit.Size = new System.Drawing.Size(84, 134);
			this.ribbonBarSiteUsersExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarSiteUsersExit.TabIndex = 63;
			this.ribbonBarSiteUsersExit.Text = "EXIT";
			// 
			// 
			// 
			this.ribbonBarSiteUsersExit.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersExit.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonBarSiteUsersHelp
			// 
			this.ribbonBarSiteUsersHelp.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarSiteUsersHelp.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersHelp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarSiteUsersHelp.ContainerControlProcessDialogKey = true;
			this.ribbonBarSiteUsersHelp.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarSiteUsersHelp.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSiteUsersHelp});
			this.ribbonBarSiteUsersHelp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarSiteUsersHelp.Location = new System.Drawing.Point(345, 0);
			this.ribbonBarSiteUsersHelp.Name = "ribbonBarSiteUsersHelp";
			this.ribbonBarSiteUsersHelp.Size = new System.Drawing.Size(79, 134);
			this.ribbonBarSiteUsersHelp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarSiteUsersHelp.TabIndex = 64;
			this.ribbonBarSiteUsersHelp.Text = "HELP";
			// 
			// 
			// 
			this.ribbonBarSiteUsersHelp.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersHelp.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonBarSiteUsersRefresh
			// 
			this.ribbonBarSiteUsersRefresh.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarSiteUsersRefresh.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersRefresh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarSiteUsersRefresh.ContainerControlProcessDialogKey = true;
			this.ribbonBarSiteUsersRefresh.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarSiteUsersRefresh.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSiteUsersRefresh});
			this.ribbonBarSiteUsersRefresh.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarSiteUsersRefresh.Location = new System.Drawing.Point(249, 0);
			this.ribbonBarSiteUsersRefresh.Name = "ribbonBarSiteUsersRefresh";
			this.ribbonBarSiteUsersRefresh.Size = new System.Drawing.Size(96, 134);
			this.ribbonBarSiteUsersRefresh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarSiteUsersRefresh.TabIndex = 6;
			this.ribbonBarSiteUsersRefresh.Text = "Refresh";
			// 
			// 
			// 
			this.ribbonBarSiteUsersRefresh.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersRefresh.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonBarSiteUsersDelete
			// 
			this.ribbonBarSiteUsersDelete.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarSiteUsersDelete.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersDelete.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarSiteUsersDelete.ContainerControlProcessDialogKey = true;
			this.ribbonBarSiteUsersDelete.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarSiteUsersDelete.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSiteUsersDelete});
			this.ribbonBarSiteUsersDelete.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarSiteUsersDelete.Location = new System.Drawing.Point(169, 0);
			this.ribbonBarSiteUsersDelete.Name = "ribbonBarSiteUsersDelete";
			this.ribbonBarSiteUsersDelete.Size = new System.Drawing.Size(80, 134);
			this.ribbonBarSiteUsersDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarSiteUsersDelete.TabIndex = 7;
			this.ribbonBarSiteUsersDelete.Text = "Delete";
			// 
			// 
			// 
			this.ribbonBarSiteUsersDelete.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersDelete.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonBarSiteUsersEdit
			// 
			this.ribbonBarSiteUsersEdit.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarSiteUsersEdit.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersEdit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarSiteUsersEdit.ContainerControlProcessDialogKey = true;
			this.ribbonBarSiteUsersEdit.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarSiteUsersEdit.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSiteUsersEdit});
			this.ribbonBarSiteUsersEdit.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarSiteUsersEdit.Location = new System.Drawing.Point(83, 0);
			this.ribbonBarSiteUsersEdit.Name = "ribbonBarSiteUsersEdit";
			this.ribbonBarSiteUsersEdit.Size = new System.Drawing.Size(86, 134);
			this.ribbonBarSiteUsersEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarSiteUsersEdit.TabIndex = 5;
			this.ribbonBarSiteUsersEdit.Text = "Edit";
			// 
			// 
			// 
			this.ribbonBarSiteUsersEdit.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersEdit.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonBarSiteUsersAdd
			// 
			this.ribbonBarSiteUsersAdd.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarSiteUsersAdd.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersAdd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarSiteUsersAdd.ContainerControlProcessDialogKey = true;
			this.ribbonBarSiteUsersAdd.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarSiteUsersAdd.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemSiteUsersAdd});
			this.ribbonBarSiteUsersAdd.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarSiteUsersAdd.Location = new System.Drawing.Point(3, 0);
			this.ribbonBarSiteUsersAdd.Name = "ribbonBarSiteUsersAdd";
			this.ribbonBarSiteUsersAdd.Size = new System.Drawing.Size(80, 134);
			this.ribbonBarSiteUsersAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarSiteUsersAdd.TabIndex = 4;
			this.ribbonBarSiteUsersAdd.Text = "Add";
			// 
			// 
			// 
			this.ribbonBarSiteUsersAdd.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarSiteUsersAdd.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonPanelCalendarEditor
			// 
			this.ribbonPanelCalendarEditor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonPanelCalendarEditor.Controls.Add(this.ribbonBarCalendarEditorExit);
			this.ribbonPanelCalendarEditor.Controls.Add(this.ribbonBarCalendarEditorHelp);
			this.ribbonPanelCalendarEditor.Controls.Add(this.ribbonBarCalendarSync);
			this.ribbonPanelCalendarEditor.Controls.Add(this.ribbonBarCalendarSite);
			this.ribbonPanelCalendarEditor.Controls.Add(this.ribbonBarCalendarEditorConfiguration);
			this.ribbonPanelCalendarEditor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ribbonPanelCalendarEditor.Location = new System.Drawing.Point(0, 25);
			this.ribbonPanelCalendarEditor.Name = "ribbonPanelCalendarEditor";
			this.ribbonPanelCalendarEditor.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.ribbonPanelCalendarEditor.Size = new System.Drawing.Size(984, 137);
			// 
			// 
			// 
			this.ribbonPanelCalendarEditor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonPanelCalendarEditor.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonPanelCalendarEditor.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonPanelCalendarEditor.TabIndex = 9;
			// 
			// ribbonBarCalendarEditorExit
			// 
			this.ribbonBarCalendarEditorExit.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarCalendarEditorExit.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarEditorExit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarCalendarEditorExit.ContainerControlProcessDialogKey = true;
			this.ribbonBarCalendarEditorExit.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarCalendarEditorExit.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemCalendarEditorExit});
			this.ribbonBarCalendarEditorExit.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarCalendarEditorExit.Location = new System.Drawing.Point(643, 0);
			this.ribbonBarCalendarEditorExit.Name = "ribbonBarCalendarEditorExit";
			this.ribbonBarCalendarEditorExit.Size = new System.Drawing.Size(84, 134);
			this.ribbonBarCalendarEditorExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarCalendarEditorExit.TabIndex = 60;
			this.ribbonBarCalendarEditorExit.Text = "EXIT";
			// 
			// 
			// 
			this.ribbonBarCalendarEditorExit.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarEditorExit.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonBarCalendarEditorHelp
			// 
			this.ribbonBarCalendarEditorHelp.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarCalendarEditorHelp.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarEditorHelp.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarCalendarEditorHelp.ContainerControlProcessDialogKey = true;
			this.ribbonBarCalendarEditorHelp.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarCalendarEditorHelp.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemCalendarEditorHelp});
			this.ribbonBarCalendarEditorHelp.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarCalendarEditorHelp.Location = new System.Drawing.Point(564, 0);
			this.ribbonBarCalendarEditorHelp.Name = "ribbonBarCalendarEditorHelp";
			this.ribbonBarCalendarEditorHelp.Size = new System.Drawing.Size(79, 134);
			this.ribbonBarCalendarEditorHelp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarCalendarEditorHelp.TabIndex = 62;
			this.ribbonBarCalendarEditorHelp.Text = "HELP";
			// 
			// 
			// 
			this.ribbonBarCalendarEditorHelp.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarEditorHelp.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonBarCalendarSync
			// 
			this.ribbonBarCalendarSync.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarCalendarSync.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarSync.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarCalendarSync.ContainerControlProcessDialogKey = true;
			this.ribbonBarCalendarSync.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarCalendarSync.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemCalendarSync});
			this.ribbonBarCalendarSync.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarCalendarSync.Location = new System.Drawing.Point(476, 0);
			this.ribbonBarCalendarSync.Name = "ribbonBarCalendarSync";
			this.ribbonBarCalendarSync.Size = new System.Drawing.Size(88, 134);
			this.ribbonBarCalendarSync.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarCalendarSync.TabIndex = 64;
			this.ribbonBarCalendarSync.Text = "Sync";
			// 
			// 
			// 
			this.ribbonBarCalendarSync.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarSync.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonBarCalendarSite
			// 
			this.ribbonBarCalendarSite.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarCalendarSite.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarSite.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarCalendarSite.ContainerControlProcessDialogKey = true;
			this.ribbonBarCalendarSite.Controls.Add(this.buttonEditCalendarSiteName);
			this.ribbonBarCalendarSite.Controls.Add(this.buttonEditCalendarSiteLogin);
			this.ribbonBarCalendarSite.Controls.Add(this.buttonEditCalendarSitePassword);
			this.ribbonBarCalendarSite.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarCalendarSite.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainerCalendarSiteName,
            this.itemContainerCalendarSiteCredentials});
			this.ribbonBarCalendarSite.ItemSpacing = 20;
			this.ribbonBarCalendarSite.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.ribbonBarCalendarSite.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarCalendarSite.Location = new System.Drawing.Point(168, 0);
			this.ribbonBarCalendarSite.Name = "ribbonBarCalendarSite";
			this.ribbonBarCalendarSite.Size = new System.Drawing.Size(308, 134);
			this.ribbonBarCalendarSite.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarCalendarSite.TabIndex = 63;
			this.ribbonBarCalendarSite.Text = "Site Settings";
			// 
			// 
			// 
			this.ribbonBarCalendarSite.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarSite.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarCalendarSite.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
			// 
			// buttonEditCalendarSiteName
			// 
			this.buttonEditCalendarSiteName.Location = new System.Drawing.Point(4, 37);
			this.buttonEditCalendarSiteName.Name = "buttonEditCalendarSiteName";
			this.buttonEditCalendarSiteName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
			this.buttonEditCalendarSiteName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic;
			this.buttonEditCalendarSiteName.Properties.Mask.EditMask = "http://([a-zA-Z0-9.]|%[0-9A-Za-z]|/|:[0-9]?)*";
			this.buttonEditCalendarSiteName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.buttonEditCalendarSiteName.Properties.NullText = "Type...";
			this.buttonEditCalendarSiteName.Size = new System.Drawing.Size(294, 20);
			this.buttonEditCalendarSiteName.StyleController = this.styleController;
			this.buttonEditCalendarSiteName.TabIndex = 0;
			// 
			// buttonEditCalendarSiteLogin
			// 
			this.buttonEditCalendarSiteLogin.Location = new System.Drawing.Point(42, 79);
			this.buttonEditCalendarSiteLogin.Name = "buttonEditCalendarSiteLogin";
			this.buttonEditCalendarSiteLogin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
			this.buttonEditCalendarSiteLogin.Properties.NullText = "Type...";
			this.buttonEditCalendarSiteLogin.Size = new System.Drawing.Size(90, 20);
			this.buttonEditCalendarSiteLogin.StyleController = this.styleController;
			this.buttonEditCalendarSiteLogin.TabIndex = 1;
			// 
			// buttonEditCalendarSitePassword
			// 
			this.buttonEditCalendarSitePassword.Location = new System.Drawing.Point(207, 79);
			this.buttonEditCalendarSitePassword.Name = "buttonEditCalendarSitePassword";
			this.buttonEditCalendarSitePassword.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
			this.buttonEditCalendarSitePassword.Properties.NullText = "Type...";
			this.buttonEditCalendarSitePassword.Size = new System.Drawing.Size(90, 20);
			this.buttonEditCalendarSitePassword.StyleController = this.styleController;
			this.buttonEditCalendarSitePassword.TabIndex = 2;
			// 
			// itemContainerCalendarSiteName
			// 
			// 
			// 
			// 
			this.itemContainerCalendarSiteName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.itemContainerCalendarSiteName.ItemSpacing = 3;
			this.itemContainerCalendarSiteName.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
			this.itemContainerCalendarSiteName.Name = "itemContainerCalendarSiteName";
			this.itemContainerCalendarSiteName.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItemCalendarSiteName,
            this.itemContainerIPadSiteValue});
			// 
			// 
			// 
			this.itemContainerCalendarSiteName.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// labelItemCalendarSiteName
			// 
			this.labelItemCalendarSiteName.ForeColor = System.Drawing.Color.Black;
			this.labelItemCalendarSiteName.Name = "labelItemCalendarSiteName";
			this.labelItemCalendarSiteName.Text = "Site Web Address:";
			// 
			// itemContainerIPadSiteValue
			// 
			// 
			// 
			// 
			this.itemContainerIPadSiteValue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.itemContainerIPadSiteValue.Name = "itemContainerIPadSiteValue";
			this.itemContainerIPadSiteValue.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItemIPadSite});
			// 
			// 
			// 
			this.itemContainerIPadSiteValue.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// controlContainerItemIPadSite
			// 
			this.controlContainerItemIPadSite.AllowItemResize = false;
			this.controlContainerItemIPadSite.Control = this.buttonEditCalendarSiteName;
			this.controlContainerItemIPadSite.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItemIPadSite.Name = "controlContainerItemIPadSite";
			// 
			// itemContainerCalendarSiteCredentials
			// 
			// 
			// 
			// 
			this.itemContainerCalendarSiteCredentials.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.itemContainerCalendarSiteCredentials.ItemSpacing = 12;
			this.itemContainerCalendarSiteCredentials.Name = "itemContainerCalendarSiteCredentials";
			this.itemContainerCalendarSiteCredentials.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainerCalendarSiteLogin,
            this.itemContainerCalendarSitePassword});
			// 
			// 
			// 
			this.itemContainerCalendarSiteCredentials.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// itemContainerCalendarSiteLogin
			// 
			// 
			// 
			// 
			this.itemContainerCalendarSiteLogin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.itemContainerCalendarSiteLogin.ItemSpacing = 5;
			this.itemContainerCalendarSiteLogin.Name = "itemContainerCalendarSiteLogin";
			this.itemContainerCalendarSiteLogin.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItemCalendarSiteLogin,
            this.controlContainerItem2});
			// 
			// 
			// 
			this.itemContainerCalendarSiteLogin.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// labelItemCalendarSiteLogin
			// 
			this.labelItemCalendarSiteLogin.ForeColor = System.Drawing.Color.Black;
			this.labelItemCalendarSiteLogin.Name = "labelItemCalendarSiteLogin";
			this.labelItemCalendarSiteLogin.Text = "Login:";
			// 
			// controlContainerItem2
			// 
			this.controlContainerItem2.AllowItemResize = false;
			this.controlContainerItem2.Control = this.buttonEditCalendarSiteLogin;
			this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem2.Name = "controlContainerItem2";
			// 
			// itemContainerCalendarSitePassword
			// 
			// 
			// 
			// 
			this.itemContainerCalendarSitePassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.itemContainerCalendarSitePassword.ItemSpacing = 5;
			this.itemContainerCalendarSitePassword.Name = "itemContainerCalendarSitePassword";
			this.itemContainerCalendarSitePassword.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItemCalendarSitePassword,
            this.controlContainerItem3});
			// 
			// 
			// 
			this.itemContainerCalendarSitePassword.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// labelItemCalendarSitePassword
			// 
			this.labelItemCalendarSitePassword.ForeColor = System.Drawing.Color.Black;
			this.labelItemCalendarSitePassword.Name = "labelItemCalendarSitePassword";
			this.labelItemCalendarSitePassword.Text = "Password:";
			// 
			// controlContainerItem3
			// 
			this.controlContainerItem3.AllowItemResize = false;
			this.controlContainerItem3.Control = this.buttonEditCalendarSitePassword;
			this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
			this.controlContainerItem3.Name = "controlContainerItem3";
			// 
			// ribbonBarCalendarEditorConfiguration
			// 
			this.ribbonBarCalendarEditorConfiguration.AutoOverflowEnabled = true;
			// 
			// 
			// 
			this.ribbonBarCalendarEditorConfiguration.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarEditorConfiguration.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.ribbonBarCalendarEditorConfiguration.ContainerControlProcessDialogKey = true;
			this.ribbonBarCalendarEditorConfiguration.Dock = System.Windows.Forms.DockStyle.Left;
			this.ribbonBarCalendarEditorConfiguration.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemCalendarEditorConfigurationNew,
            this.buttonItemCalendarEditorConfigurationOpen});
			this.ribbonBarCalendarEditorConfiguration.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			this.ribbonBarCalendarEditorConfiguration.Location = new System.Drawing.Point(3, 0);
			this.ribbonBarCalendarEditorConfiguration.Name = "ribbonBarCalendarEditorConfiguration";
			this.ribbonBarCalendarEditorConfiguration.Size = new System.Drawing.Size(165, 134);
			this.ribbonBarCalendarEditorConfiguration.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.ribbonBarCalendarEditorConfiguration.TabIndex = 61;
			this.ribbonBarCalendarEditorConfiguration.Text = "Configuration";
			// 
			// 
			// 
			this.ribbonBarCalendarEditorConfiguration.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// 
			// 
			this.ribbonBarCalendarEditorConfiguration.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// ribbonTabItemCalendarEditor
			// 
			this.ribbonTabItemCalendarEditor.Checked = true;
			this.ribbonTabItemCalendarEditor.Name = "ribbonTabItemCalendarEditor";
			this.ribbonTabItemCalendarEditor.Panel = this.ribbonPanelCalendarEditor;
			this.ribbonTabItemCalendarEditor.Text = "Home";
			// 
			// ribbonTabItemSiteUsers
			// 
			this.ribbonTabItemSiteUsers.Name = "ribbonTabItemSiteUsers";
			this.ribbonTabItemSiteUsers.Panel = this.ribbonPanelSiteUsers;
			this.ribbonTabItemSiteUsers.Text = "Users";
			// 
			// superTooltip
			// 
			this.superTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
			// 
			// pnMain
			// 
			this.pnMain.BackColor = System.Drawing.SystemColors.Control;
			this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnMain.Location = new System.Drawing.Point(0, 165);
			this.pnMain.Name = "pnMain";
			this.pnMain.Size = new System.Drawing.Size(984, 523);
			this.pnMain.TabIndex = 2;
			// 
			// styleManager
			// 
			this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
			this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
			// 
			// pnEmpty
			// 
			this.pnEmpty.BackColor = System.Drawing.SystemColors.Control;
			this.pnEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnEmpty.Location = new System.Drawing.Point(0, 165);
			this.pnEmpty.Name = "pnEmpty";
			this.pnEmpty.Size = new System.Drawing.Size(984, 523);
			this.pnEmpty.TabIndex = 3;
			// 
			// buttonItemSiteUsersExit
			// 
			this.buttonItemSiteUsersExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonItemSiteUsersExit.Image = global::OnlineCalendars.Manager.Properties.Resources.Exit;
			this.buttonItemSiteUsersExit.Name = "buttonItemSiteUsersExit";
			this.buttonItemSiteUsersExit.SubItemsExpandWidth = 14;
			this.superTooltip.SetSuperTooltip(this.buttonItemSiteUsersExit, new DevComponents.DotNetBar.SuperTooltipInfo("EXIT", "", "Close the application", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
			this.buttonItemSiteUsersExit.Click += new System.EventHandler(this.buttonItemExit_Click);
			// 
			// buttonItemSiteUsersHelp
			// 
			this.buttonItemSiteUsersHelp.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonItemSiteUsersHelp.Image = global::OnlineCalendars.Manager.Properties.Resources.Help;
			this.buttonItemSiteUsersHelp.Name = "buttonItemSiteUsersHelp";
			this.buttonItemSiteUsersHelp.SubItemsExpandWidth = 14;
			this.buttonItemSiteUsersHelp.Text = "buttonItem1";
			// 
			// buttonItemSiteUsersRefresh
			// 
			this.buttonItemSiteUsersRefresh.Image = global::OnlineCalendars.Manager.Properties.Resources.RefreshUsers;
			this.buttonItemSiteUsersRefresh.Name = "buttonItemSiteUsersRefresh";
			this.buttonItemSiteUsersRefresh.SubItemsExpandWidth = 14;
			this.buttonItemSiteUsersRefresh.Text = "buttonItem1";
			// 
			// buttonItemSiteUsersDelete
			// 
			this.buttonItemSiteUsersDelete.Image = global::OnlineCalendars.Manager.Properties.Resources.DeleteUser;
			this.buttonItemSiteUsersDelete.Name = "buttonItemSiteUsersDelete";
			this.buttonItemSiteUsersDelete.SubItemsExpandWidth = 14;
			this.buttonItemSiteUsersDelete.Text = "buttonItem1";
			// 
			// buttonItemSiteUsersEdit
			// 
			this.buttonItemSiteUsersEdit.Image = global::OnlineCalendars.Manager.Properties.Resources.EditUser;
			this.buttonItemSiteUsersEdit.Name = "buttonItemSiteUsersEdit";
			this.buttonItemSiteUsersEdit.SubItemsExpandWidth = 14;
			this.buttonItemSiteUsersEdit.Text = "buttonItem1";
			// 
			// buttonItemSiteUsersAdd
			// 
			this.buttonItemSiteUsersAdd.Image = global::OnlineCalendars.Manager.Properties.Resources.AddUser;
			this.buttonItemSiteUsersAdd.Name = "buttonItemSiteUsersAdd";
			this.buttonItemSiteUsersAdd.SubItemsExpandWidth = 14;
			this.buttonItemSiteUsersAdd.Text = "buttonItem1";
			// 
			// buttonItemCalendarEditorExit
			// 
			this.buttonItemCalendarEditorExit.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonItemCalendarEditorExit.Image = global::OnlineCalendars.Manager.Properties.Resources.Exit;
			this.buttonItemCalendarEditorExit.Name = "buttonItemCalendarEditorExit";
			this.buttonItemCalendarEditorExit.SubItemsExpandWidth = 14;
			this.superTooltip.SetSuperTooltip(this.buttonItemCalendarEditorExit, new DevComponents.DotNetBar.SuperTooltipInfo("EXIT", "", "Close the application", null, null, DevComponents.DotNetBar.eTooltipColor.Gray));
			this.buttonItemCalendarEditorExit.Click += new System.EventHandler(this.buttonItemExit_Click);
			// 
			// buttonItemCalendarEditorHelp
			// 
			this.buttonItemCalendarEditorHelp.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonItemCalendarEditorHelp.Image = global::OnlineCalendars.Manager.Properties.Resources.Help;
			this.buttonItemCalendarEditorHelp.Name = "buttonItemCalendarEditorHelp";
			this.buttonItemCalendarEditorHelp.SubItemsExpandWidth = 14;
			this.buttonItemCalendarEditorHelp.Text = "buttonItem1";
			// 
			// buttonItemCalendarSync
			// 
			this.buttonItemCalendarSync.Image = global::OnlineCalendars.Manager.Properties.Resources.SyncData;
			this.buttonItemCalendarSync.Name = "buttonItemCalendarSync";
			this.buttonItemCalendarSync.SubItemsExpandWidth = 14;
			this.buttonItemCalendarSync.Text = "buttonItem1";
			// 
			// buttonItemCalendarEditorConfigurationNew
			// 
			this.buttonItemCalendarEditorConfigurationNew.Image = global::OnlineCalendars.Manager.Properties.Resources.NewConfiguration;
			this.buttonItemCalendarEditorConfigurationNew.Name = "buttonItemCalendarEditorConfigurationNew";
			this.buttonItemCalendarEditorConfigurationNew.SubItemsExpandWidth = 14;
			this.buttonItemCalendarEditorConfigurationNew.Text = "New";
			this.buttonItemCalendarEditorConfigurationNew.Click += new System.EventHandler(this.buttonItemHomeNewSchedule_Click);
			// 
			// buttonItemCalendarEditorConfigurationOpen
			// 
			this.buttonItemCalendarEditorConfigurationOpen.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonItemCalendarEditorConfigurationOpen.Image = global::OnlineCalendars.Manager.Properties.Resources.OpenConfiguration;
			this.buttonItemCalendarEditorConfigurationOpen.Name = "buttonItemCalendarEditorConfigurationOpen";
			this.buttonItemCalendarEditorConfigurationOpen.SubItemsExpandWidth = 14;
			this.buttonItemCalendarEditorConfigurationOpen.Text = "Open";
			this.buttonItemCalendarEditorConfigurationOpen.Click += new System.EventHandler(this.buttonItemHomeOpenSchedule_Click);
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(984, 688);
			this.Controls.Add(this.pnMain);
			this.Controls.Add(this.pnEmpty);
			this.Controls.Add(this.ribbonControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MinimumSize = new System.Drawing.Size(1000, 726);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calendar Manager";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Shown += new System.EventHandler(this.FormMain_Shown);
			this.ribbonControl.ResumeLayout(false);
			this.ribbonControl.PerformLayout();
			this.ribbonPanelSiteUsers.ResumeLayout(false);
			this.ribbonPanelCalendarEditor.ResumeLayout(false);
			this.ribbonBarCalendarSite.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.buttonEditCalendarSiteName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEditCalendarSiteLogin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.buttonEditCalendarSitePassword.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public DevComponents.DotNetBar.RibbonControl ribbonControl;
		private DevComponents.DotNetBar.RibbonPanel ribbonPanelCalendarEditor;
		private DevComponents.DotNetBar.RibbonTabItem ribbonTabItemCalendarEditor;
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
		public DevComponents.DotNetBar.SuperTooltip superTooltip;
		private DevExpress.XtraEditors.StyleController styleController;
		private DevComponents.DotNetBar.RibbonBar ribbonBarCalendarEditorExit;
		private DevComponents.DotNetBar.ButtonItem buttonItemCalendarEditorExit;
		private System.Windows.Forms.Panel pnMain;
		private DevComponents.DotNetBar.StyleManager styleManager;
		private DevComponents.DotNetBar.RibbonBar ribbonBarCalendarEditorConfiguration;
		private DevComponents.DotNetBar.ButtonItem buttonItemCalendarEditorConfigurationNew;
		private DevComponents.DotNetBar.ButtonItem buttonItemCalendarEditorConfigurationOpen;
		private DevComponents.DotNetBar.RibbonBar ribbonBarCalendarEditorHelp;
		private DevComponents.DotNetBar.ButtonItem buttonItemCalendarEditorHelp;
		private System.Windows.Forms.Panel pnEmpty;
		public DevComponents.DotNetBar.RibbonBar ribbonBarCalendarSite;
		public DevExpress.XtraEditors.ButtonEdit buttonEditCalendarSiteName;
		public DevExpress.XtraEditors.ButtonEdit buttonEditCalendarSiteLogin;
		public DevExpress.XtraEditors.ButtonEdit buttonEditCalendarSitePassword;
		private DevComponents.DotNetBar.ItemContainer itemContainerCalendarSiteName;
		private DevComponents.DotNetBar.LabelItem labelItemCalendarSiteName;
		private DevComponents.DotNetBar.ItemContainer itemContainerIPadSiteValue;
		private DevComponents.DotNetBar.ControlContainerItem controlContainerItemIPadSite;
		private DevComponents.DotNetBar.ItemContainer itemContainerCalendarSiteCredentials;
		private DevComponents.DotNetBar.ItemContainer itemContainerCalendarSiteLogin;
		private DevComponents.DotNetBar.LabelItem labelItemCalendarSiteLogin;
		private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
		private DevComponents.DotNetBar.ItemContainer itemContainerCalendarSitePassword;
		private DevComponents.DotNetBar.LabelItem labelItemCalendarSitePassword;
		private DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
		private DevComponents.DotNetBar.RibbonPanel ribbonPanelSiteUsers;
		private DevComponents.DotNetBar.RibbonBar ribbonBarSiteUsersExit;
		private DevComponents.DotNetBar.ButtonItem buttonItemSiteUsersExit;
		private DevComponents.DotNetBar.RibbonBar ribbonBarSiteUsersHelp;
		private DevComponents.DotNetBar.ButtonItem buttonItemSiteUsersHelp;
		private DevComponents.DotNetBar.RibbonBar ribbonBarSiteUsersRefresh;
		public DevComponents.DotNetBar.ButtonItem buttonItemSiteUsersRefresh;
		private DevComponents.DotNetBar.RibbonBar ribbonBarSiteUsersDelete;
		public DevComponents.DotNetBar.ButtonItem buttonItemSiteUsersDelete;
		private DevComponents.DotNetBar.RibbonBar ribbonBarSiteUsersEdit;
		public DevComponents.DotNetBar.ButtonItem buttonItemSiteUsersEdit;
		private DevComponents.DotNetBar.RibbonBar ribbonBarSiteUsersAdd;
		public DevComponents.DotNetBar.ButtonItem buttonItemSiteUsersAdd;
		private DevComponents.DotNetBar.RibbonBar ribbonBarCalendarSync;
		private DevComponents.DotNetBar.ButtonItem buttonItemCalendarSync;
		private DevComponents.DotNetBar.RibbonTabItem ribbonTabItemSiteUsers;
	}
}

