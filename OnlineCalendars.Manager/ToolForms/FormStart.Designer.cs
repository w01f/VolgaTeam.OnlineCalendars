namespace OnlineCalendars.Manager.ToolForms
{
    partial class FormStart
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
			this.laTitle = new System.Windows.Forms.Label();
			this.simpleButtonNew = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonOpen = new DevExpress.XtraEditors.SimpleButton();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.SuspendLayout();
			// 
			// laTitle
			// 
			this.laTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.laTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.laTitle.Location = new System.Drawing.Point(8, 9);
			this.laTitle.Name = "laTitle";
			this.laTitle.Size = new System.Drawing.Size(431, 73);
			this.laTitle.TabIndex = 0;
			this.laTitle.Text = "Do you want to Create a NEW Calendar configuration, or Open a Saved configuration" +
    "?";
			this.laTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// simpleButtonNew
			// 
			this.simpleButtonNew.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.simpleButtonNew.Appearance.Options.UseFont = true;
			this.simpleButtonNew.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.simpleButtonNew.Location = new System.Drawing.Point(12, 90);
			this.simpleButtonNew.Name = "simpleButtonNew";
			this.simpleButtonNew.Size = new System.Drawing.Size(125, 32);
			this.simpleButtonNew.TabIndex = 6;
			this.simpleButtonNew.Text = "New Configuration";
			// 
			// simpleButtonCancel
			// 
			this.simpleButtonCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.simpleButtonCancel.Appearance.ForeColor = System.Drawing.Color.Red;
			this.simpleButtonCancel.Appearance.Options.UseFont = true;
			this.simpleButtonCancel.Appearance.Options.UseForeColor = true;
			this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.simpleButtonCancel.Location = new System.Drawing.Point(309, 90);
			this.simpleButtonCancel.Name = "simpleButtonCancel";
			this.simpleButtonCancel.Size = new System.Drawing.Size(125, 32);
			this.simpleButtonCancel.TabIndex = 5;
			this.simpleButtonCancel.Text = "CANCEL && EXIT";
			// 
			// simpleButtonOpen
			// 
			this.simpleButtonOpen.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.simpleButtonOpen.Appearance.Options.UseFont = true;
			this.simpleButtonOpen.DialogResult = System.Windows.Forms.DialogResult.No;
			this.simpleButtonOpen.Location = new System.Drawing.Point(160, 90);
			this.simpleButtonOpen.Name = "simpleButtonOpen";
			this.simpleButtonOpen.Size = new System.Drawing.Size(125, 32);
			this.simpleButtonOpen.TabIndex = 7;
			this.simpleButtonOpen.Text = "Open Configuration";
			// 
			// FormStart
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(446, 135);
			this.Controls.Add(this.simpleButtonOpen);
			this.Controls.Add(this.simpleButtonNew);
			this.Controls.Add(this.simpleButtonCancel);
			this.Controls.Add(this.laTitle);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormStart";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calendar Manager";
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Label laTitle;
		private DevExpress.XtraEditors.SimpleButton simpleButtonNew;
		private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
		public DevExpress.XtraEditors.SimpleButton simpleButtonOpen;
    }
}