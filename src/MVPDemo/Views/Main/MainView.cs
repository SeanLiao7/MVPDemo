using System;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MVPDemo.Presenters;

namespace MVPDemo.Views
{
    public partial class MainView : MetroForm, IMainView
    {
        private readonly IMainPresenter _mainPresenter;

        public ISubView SubView
        {
            get => MainPanel.Controls.Count > 0
                    ? MainPanel.Controls[ 0 ] is ISubView view
                    ? view
                    : throw new InvalidCastException( $"Can't find relevant view, property name :{nameof( SubView )}" )
                    : default( ISubView );
            set
            {
                MainPanel.Controls.Clear( );
                if ( value is UserControl control )
                    MainPanel.Controls.Add( control );
                else
                    throw new InvalidCastException( $"Can't find relevant view, input name :{nameof( value )}" );
            }
        }

        public bool ToggleTheme => toggleTheme.getUiProperty( x => x.Checked );

        public MainView( IMainPresenter mainPresenter )
        {
            InitializeComponent( );
            mainPresenter.MainView = this;
            _mainPresenter = mainPresenter;
            StyleManager = mainStyleManager;
            Load += MainView_Load;
            toggleTheme.CheckedChanged += ToggleTheme_CheckedChanged;
        }

        public void setMaximumSize( )
        {
            this.updateUi( x =>
            {
                x.WindowState = FormWindowState.Normal;
                x.FormBorderStyle = FormBorderStyle.None;
            } );
        }

        public void updateTheme( MetroThemeStyle themeStyle )
        {
            this.updateUi( x => StyleManager.Theme = themeStyle );
        }

        private void MainView_Load( object sender, EventArgs e )
        {
            _mainPresenter.loadView( );
        }

        private void ToggleTheme_CheckedChanged( object sender, EventArgs e )
        {
            _mainPresenter.toggleTheme( );
        }
    }
}