namespace MVPDemo.Views
{
    partial class MainView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.toggleTheme = new MetroFramework.Controls.MetroToggle();
            this.mainStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(15, 68);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.MaximumSize = new System.Drawing.Size(1400, 820);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1400, 820);
            this.MainPanel.TabIndex = 0;
            // 
            // toggleTheme
            // 
            this.toggleTheme.Appearance = System.Windows.Forms.Appearance.Button;
            this.toggleTheme.AutoSize = true;
            this.toggleTheme.Location = new System.Drawing.Point(183, 29);
            this.toggleTheme.Name = "toggleTheme";
            this.toggleTheme.Size = new System.Drawing.Size(80, 22);
            this.toggleTheme.TabIndex = 1;
            this.toggleTheme.Text = "Off";
            this.toggleTheme.UseSelectable = true;
            // 
            // mainStyleManager
            // 
            this.mainStyleManager.Owner = this;
            // 
            // MainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.ControlBox = false;
            this.Controls.Add(this.toggleTheme);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1440, 900);
            this.Movable = false;
            this.Name = "MainView";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 12);
            this.Resizable = false;
            this.Text = "MVP Demo";
            ((System.ComponentModel.ISupportInitialize)(this.mainStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private MetroFramework.Controls.MetroToggle toggleTheme;
        private MetroFramework.Components.MetroStyleManager mainStyleManager;
    }
}

