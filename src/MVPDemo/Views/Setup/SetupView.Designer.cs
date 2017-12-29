namespace MVPDemo.Views
{
    partial class SetupView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.txtCounter = new MetroFramework.Controls.MetroTextBox();
            this.btnAddCounter = new MetroFramework.Controls.MetroButton();
            this.btnGoPositionView = new MetroFramework.Controls.MetroButton();
            this.btnGoOperationView = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtCounter
            // 
            // 
            // 
            // 
            this.txtCounter.CustomButton.Image = null;
            this.txtCounter.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.txtCounter.CustomButton.Name = "";
            this.txtCounter.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCounter.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCounter.CustomButton.TabIndex = 1;
            this.txtCounter.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCounter.CustomButton.UseSelectable = true;
            this.txtCounter.CustomButton.Visible = false;
            this.txtCounter.Lines = new string[] {
        "----"};
            this.txtCounter.Location = new System.Drawing.Point(251, 309);
            this.txtCounter.MaxLength = 32767;
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.PasswordChar = '\0';
            this.txtCounter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCounter.SelectedText = "";
            this.txtCounter.SelectionLength = 0;
            this.txtCounter.SelectionStart = 0;
            this.txtCounter.ShortcutsEnabled = true;
            this.txtCounter.Size = new System.Drawing.Size(247, 23);
            this.txtCounter.TabIndex = 5;
            this.txtCounter.Text = "----";
            this.txtCounter.UseSelectable = true;
            this.txtCounter.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCounter.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddCounter
            // 
            this.btnAddCounter.Location = new System.Drawing.Point(524, 308);
            this.btnAddCounter.Name = "btnAddCounter";
            this.btnAddCounter.Size = new System.Drawing.Size(130, 23);
            this.btnAddCounter.TabIndex = 6;
            this.btnAddCounter.Text = "Add";
            this.btnAddCounter.UseSelectable = true;
            // 
            // btnGoPositionView
            // 
            this.btnGoPositionView.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGoPositionView.Location = new System.Drawing.Point(637, 624);
            this.btnGoPositionView.Name = "btnGoPositionView";
            this.btnGoPositionView.Size = new System.Drawing.Size(186, 98);
            this.btnGoPositionView.TabIndex = 7;
            this.btnGoPositionView.Text = "GoPositionView";
            this.btnGoPositionView.UseSelectable = true;
            // 
            // btnGoOperationView
            // 
            this.btnGoOperationView.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGoOperationView.Location = new System.Drawing.Point(854, 624);
            this.btnGoOperationView.Name = "btnGoOperationView";
            this.btnGoOperationView.Size = new System.Drawing.Size(186, 98);
            this.btnGoOperationView.TabIndex = 8;
            this.btnGoOperationView.Text = "GoOperationView";
            this.btnGoOperationView.UseSelectable = true;
            // 
            // btnExit
            // 
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExit.Location = new System.Drawing.Point(1071, 624);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 98);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            // 
            // SetupView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoOperationView);
            this.Controls.Add(this.btnGoPositionView);
            this.Controls.Add(this.btnAddCounter);
            this.Controls.Add(this.txtCounter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1400, 820);
            this.Name = "SetupView";
            this.Size = new System.Drawing.Size(1400, 820);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCounter;
        private MetroFramework.Controls.MetroButton btnAddCounter;
        private MetroFramework.Controls.MetroButton btnGoPositionView;
        private MetroFramework.Controls.MetroButton btnGoOperationView;
        private MetroFramework.Controls.MetroButton btnExit;
    }
}
