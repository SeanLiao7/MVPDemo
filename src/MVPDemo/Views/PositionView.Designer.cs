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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnGoSetupView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(449, 270);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(228, 22);
            this.txtResult.TabIndex = 0;
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(718, 269);
            this.btnLearn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(91, 21);
            this.btnLearn.TabIndex = 1;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = true;
            // 
            // btnGoSetupView
            // 
            this.btnGoSetupView.Location = new System.Drawing.Point(1112, 623);
            this.btnGoSetupView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoSetupView.Name = "btnGoSetupView";
            this.btnGoSetupView.Size = new System.Drawing.Size(181, 103);
            this.btnGoSetupView.TabIndex = 2;
            this.btnGoSetupView.Text = "GoSetupView";
            this.btnGoSetupView.UseVisualStyleBackColor = true;
            // 
            // PositionView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnGoSetupView);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.txtResult);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1400, 820);
            this.Name = "PositionView";
            this.Size = new System.Drawing.Size(1400, 820);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnGoSetupView;
    }
}
