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
            this.btnGoPosition.Location = new System.Drawing.Point(525, 590);
            this.btnGoPosition.Name = "btnGoPosition";
            this.btnGoPosition.Size = new System.Drawing.Size(241, 172);
            this.btnGoPosition.TabIndex = 0;
            this.btnGoPosition.Text = "goPositionView";
            this.btnGoPosition.UseVisualStyleBackColor = true;
            // 
            // txtCounter
            // 
            this.txtCounter.Location = new System.Drawing.Point(252, 193);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.Size = new System.Drawing.Size(364, 28);
            this.txtCounter.TabIndex = 1;
            // 
            // btnAddCounter
            // 
            this.btnAddCounter.Location = new System.Drawing.Point(645, 183);
            this.btnAddCounter.Name = "btnAddCounter";
            this.btnAddCounter.Size = new System.Drawing.Size(156, 47);
            this.btnAddCounter.TabIndex = 2;
            this.btnAddCounter.Text = "Add";
            this.btnAddCounter.UseVisualStyleBackColor = true;
            // 
            // btnGoOperationView
            // 
            this.btnGoOperationView.Location = new System.Drawing.Point(818, 590);
            this.btnGoOperationView.Name = "btnGoOperationView";
            this.btnGoOperationView.Size = new System.Drawing.Size(241, 172);
            this.btnGoOperationView.TabIndex = 3;
            this.btnGoOperationView.Text = "goOperationView";
            this.btnGoOperationView.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1101, 590);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(241, 172);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // SetupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoOperationView);
            this.Controls.Add(this.btnAddCounter);
            this.Controls.Add(this.txtCounter);
            this.Controls.Add(this.btnGoPosition);
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.Name = "SetupView";
            this.Size = new System.Drawing.Size(1400, 800);
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
