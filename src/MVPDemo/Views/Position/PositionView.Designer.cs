namespace MVPDemo.Views
{
    partial class PositionView
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
            this.btnLearn = new MetroFramework.Controls.MetroButton();
            this.btnGoSetupView = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            // 
            // 
            // 
            this.txtResult.CustomButton.Image = null;
            this.txtResult.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtResult.CustomButton.Name = "";
            this.txtResult.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResult.CustomButton.TabIndex = 1;
            this.txtResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResult.CustomButton.UseSelectable = true;
            this.txtResult.CustomButton.Visible = false;
            this.txtResult.Lines = new string[] {
        "----"};
            this.txtResult.Location = new System.Drawing.Point(441, 269);
            this.txtResult.MaxLength = 32767;
            this.txtResult.Name = "txtResult";
            this.txtResult.PasswordChar = '\0';
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResult.SelectedText = "";
            this.txtResult.SelectionLength = 0;
            this.txtResult.SelectionStart = 0;
            this.txtResult.ShortcutsEnabled = true;
            this.txtResult.Size = new System.Drawing.Size(253, 23);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "----";
            this.txtResult.UseSelectable = true;
            this.txtResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(722, 269);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(119, 23);
            this.btnLearn.TabIndex = 4;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseSelectable = true;
            // 
            // btnGoSetupView
            // 
            this.btnGoSetupView.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnGoSetupView.Location = new System.Drawing.Point(1051, 640);
            this.btnGoSetupView.Name = "btnGoSetupView";
            this.btnGoSetupView.Size = new System.Drawing.Size(176, 99);
            this.btnGoSetupView.TabIndex = 5;
            this.btnGoSetupView.Text = "GoSetupView";
            this.btnGoSetupView.UseSelectable = true;
            // 
            // PositionView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnGoSetupView);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.txtResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1400, 820);
            this.Name = "PositionView";
            this.Size = new System.Drawing.Size(1400, 820);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtResult;
        private MetroFramework.Controls.MetroButton btnLearn;
        private MetroFramework.Controls.MetroButton btnGoSetupView;
    }
}
