using System;
using System.Windows.Forms;
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

        public FormBorderStyle ViewBorderStyle
        {
            get => this.getUiProperty( ( ) => FormBorderStyle );
            set => this.updateUi( ( ) => FormBorderStyle = value );
        }

        public FormWindowState ViewWindowState
        {
            get => this.getUiProperty( ( ) => WindowState );
            set => this.updateUi( ( ) => WindowState = value );
        }

        public MainView( IMainPresenter mainPresenter )
        {
            InitializeComponent( );
            mainPresenter.MainView = this;
            _mainPresenter = mainPresenter;
            Load += MainView_Load;
        }

        private void MainView_Load( object sender, EventArgs e )
        {
            _mainPresenter.loadView( );
        }
    }
}