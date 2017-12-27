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
            this.btnGoPosition = new System.Windows.Forms.Button();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.btnAddCounter = new System.Windows.Forms.Button();
            this.btnGoOperationView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoPosition
            // 
            this.btnGoPosition.Location = new System.Drawing.Point(610, 624);
            this.btnGoPosition.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoPosition.Name = "btnGoPosition";
            this.btnGoPosition.Size = new System.Drawing.Size(181, 103);
            this.btnGoPosition.TabIndex = 0;
            this.btnGoPosition.Text = "goPositionView";
            this.btnGoPosition.UseVisualStyleBackColor = true;
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(184, 309);
            this.txtCounter.Margin = new System.Windows.Forms.Padding(2);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(274, 22);
            this.txtCounter.TabIndex = 1;
            // 
            // btnAddCounter
            // 
            this.btnAddCounter.Location = new System.Drawing.Point(513, 309);
            this.btnAddCounter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCounter.Name = "btnAddCounter";
            this.btnAddCounter.Size = new System.Drawing.Size(117, 28);
            this.btnAddCounter.TabIndex = 2;
            this.btnAddCounter.Text = "Add";
            this.btnAddCounter.UseVisualStyleBackColor = true;
            // 
            // btnGoOperationView
            // 
            this.btnGoOperationView.Location = new System.Drawing.Point(870, 624);
            this.btnGoOperationView.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoOperationView.Name = "btnGoOperationView";
            this.btnGoOperationView.Size = new System.Drawing.Size(181, 103);
            this.btnGoOperationView.TabIndex = 3;
            this.btnGoOperationView.Text = "goOperationView";
            this.btnGoOperationView.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1104, 624);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 103);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // SetupView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoOperationView);
            this.Controls.Add(this.btnAddCounter);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.btnGoPosition);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1400, 820);
            this.Name = "SetupView";
            this.Size = new System.Drawing.Size(1400, 820);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoPosition;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.Button btnAddCounter;
        private System.Windows.Forms.Button btnGoOperationView;
        private System.Windows.Forms.Button btnExit;
    }
}
