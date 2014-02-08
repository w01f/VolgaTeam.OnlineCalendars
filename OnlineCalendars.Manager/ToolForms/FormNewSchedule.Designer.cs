namespace OnlineCalendars.Manager.ToolForms
{
    partial class FormNewSchedule
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
			this.laLogo = new System.Windows.Forms.Label();
			this.textEditName = new DevExpress.XtraEditors.TextEdit();
			this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.pbLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// laLogo
			// 
			this.laLogo.Location = new System.Drawing.Point(90, 12);
			this.laLogo.Name = "laLogo";
			this.laLogo.Size = new System.Drawing.Size(282, 41);
			this.laLogo.TabIndex = 1;
			this.laLogo.Text = "Before you begin, you must set a name for your new Configuration:";
			// 
			// textEditName
			// 
			this.textEditName.Location = new System.Drawing.Point(90, 65);
			this.textEditName.Name = "textEditName";
			this.textEditName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textEditName.Properties.Appearance.Options.UseFont = true;
			this.textEditName.Properties.NullText = "Type here";
			this.textEditName.Size = new System.Drawing.Size(282, 22);
			this.textEditName.TabIndex = 0;
			this.textEditName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditScheduleName_KeyDown);
			// 
			// simpleButtonCancel
			// 
			this.simpleButtonCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.simpleButtonCancel.Appearance.Options.UseFont = true;
			this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.simpleButtonCancel.Location = new System.Drawing.Point(285, 95);
			this.simpleButtonCancel.Name = "simpleButtonCancel";
			this.simpleButtonCancel.Size = new System.Drawing.Size(87, 32);
			this.simpleButtonCancel.TabIndex = 3;
			this.simpleButtonCancel.Text = "Cancel";
			// 
			// simpleButtonOK
			// 
			this.simpleButtonOK.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.simpleButtonOK.Appearance.Options.UseFont = true;
			this.simpleButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.simpleButtonOK.Location = new System.Drawing.Point(172, 95);
			this.simpleButtonOK.Name = "simpleButtonOK";
			this.simpleButtonOK.Size = new System.Drawing.Size(87, 32);
			this.simpleButtonOK.TabIndex = 4;
			this.simpleButtonOK.Text = "OK";
			// 
			// pbLogo
			// 
			this.pbLogo.Image = global::OnlineCalendars.Manager.Properties.Resources.NewConfiguration;
			this.pbLogo.Location = new System.Drawing.Point(12, 12);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(72, 75);
			this.pbLogo.TabIndex = 0;
			this.pbLogo.TabStop = false;
			// 
			// FormNewSchedule
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(384, 134);
			this.Controls.Add(this.simpleButtonOK);
			this.Controls.Add(this.simpleButtonCancel);
			this.Controls.Add(this.textEditName);
			this.Controls.Add(this.laLogo);
			this.Controls.Add(this.pbLogo);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormNewSchedule";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Configuration";
			((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.PictureBox pbLogo;
        private DevExpress.XtraEditors.TextEdit textEditName;
        public System.Windows.Forms.Label laLogo;
		private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
		private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
    }
}