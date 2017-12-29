namespace MVPDemo.Views
{
    partial class OperartionView
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
            this.txtResult = new MetroFramework.Controls.MetroTextBox();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnGoSetupView = new MetroFramework.Controls.MetroButton();
            this.btnReceiveProgramResult = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            // 
            // 
            // 
            this.txtResult.CustomButton.Image = null;
            this.txtResult.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.txtResult.CustomButton.Name = "";
            this.txtResult.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResult.CustomButton.TabIndex = 1;
            this.txtResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResult.CustomButton.UseSelectable = true;
            this.txtResult.CustomButton.Visible = false;
            this.txtResult.Lines = new string[] {
        "----"};
            this.txtResult.Location = new System.Drawing.Point(334, 259);
            this.txtResult.MaxLength = 32767;
            this.txtResult.Name = "txtResult";
            this.txtResult.PasswordChar = '\0';
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResult.SelectedText = "";
            this.txtResult.SelectionLength = 0;
            this.txtResult.SelectionStart = 0;
            this.txtResult.ShortcutsEnabled = true;
            this.txtResult.Size = new System.Drawing.Size(312, 23);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "----";
            this.txtResult.UseSelectable = true;
            this.txtResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnExit
            // 
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExit.Location = new System.Drawing.Point(1046, 592);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(165, 118);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            // 
            // btnGoSetupView
            // 
            this.btnGoSetupView.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGoSetupView.Location = new System.Drawing.Point(824, 592);
            this.btnGoSetupView.Name = "btnGoSetupView";
            this.btnGoSetupView.Size = new System.Drawing.Size(165, 118);
            this.btnGoSetupView.TabIndex = 7;
            this.btnGoSetupView.Text = "GoSetupView";
            this.btnGoSetupView.UseSelectable = true;
            // 
            // btnReceiveProgramResult
            // 
            this.btnReceiveProgramResult.Location = new System.Drawing.Point(671, 259);
            this.btnReceiveProgramResult.Name = "btnReceiveProgramResult";
            this.btnReceiveProgramResult.Size = new System.Drawing.Size(129, 23);
            this.btnReceiveProgramResult.TabIndex = 8;
            this.btnReceiveProgramResult.Text = "Program";
            this.btnReceiveProgramResult.UseSelectable = true;
            // 
            // OperartionView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnReceiveProgramResult);
            this.Controls.Add(this.btnGoSetupView);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1400, 820);
            this.Name = "OperartionView";
            this.Size = new System.Drawing.Size(1400, 820);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtResult;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnGoSetupView;
        private MetroFramework.Controls.MetroButton btnReceiveProgramResult;
    }
}
