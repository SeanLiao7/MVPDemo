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
            this.btnGoSetupView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReceiveProgramResult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGoSetupView
            // 
            this.btnGoSetupView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoSetupView.Location = new System.Drawing.Point(846, 606);
            this.btnGoSetupView.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoSetupView.Name = "btnGoSetupView";
            this.btnGoSetupView.Size = new System.Drawing.Size(181, 103);
            this.btnGoSetupView.TabIndex = 1;
            this.btnGoSetupView.Text = "GoSetupView";
            this.btnGoSetupView.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Location = new System.Drawing.Point(1078, 606);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 103);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReceiveProgramResult
            // 
            this.btnReceiveProgramResult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReceiveProgramResult.Location = new System.Drawing.Point(602, 272);
            this.btnReceiveProgramResult.Margin = new System.Windows.Forms.Padding(2);
            this.btnReceiveProgramResult.Name = "btnReceiveProgramResult";
            this.btnReceiveProgramResult.Size = new System.Drawing.Size(91, 32);
            this.btnReceiveProgramResult.TabIndex = 4;
            this.btnReceiveProgramResult.Text = "Program";
            this.btnReceiveProgramResult.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(340, 276);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(228, 28);
            this.txtResult.TabIndex = 3;
            // 
            // OperartionView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnReceiveProgramResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoSetupView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1400, 820);
            this.Name = "OperartionView";
            this.Size = new System.Drawing.Size(1400, 820);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoSetupView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReceiveProgramResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}
