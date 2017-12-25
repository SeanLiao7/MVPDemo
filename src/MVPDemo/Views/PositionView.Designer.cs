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
            this.txtResult.Location = new System.Drawing.Point(386, 168);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(303, 28);
            this.txtResult.TabIndex = 0;
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(735, 161);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(121, 35);
            this.btnLearn.TabIndex = 1;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = true;
            // 
            // btnGoSetupView
            // 
            this.btnGoSetupView.Location = new System.Drawing.Point(1064, 597);
            this.btnGoSetupView.Name = "btnGoSetupView";
            this.btnGoSetupView.Size = new System.Drawing.Size(241, 172);
            this.btnGoSetupView.TabIndex = 2;
            this.btnGoSetupView.Text = "GoSetupView";
            this.btnGoSetupView.UseVisualStyleBackColor = true;
            // 
            // PositionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoSetupView);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.txtResult);
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
