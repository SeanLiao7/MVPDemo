using MetroFramework.Controls;
using MVPDemo.Presenters;

namespace MVPDemo.Views
{
    public partial class SetupView : MetroUserControl, ISetupView
    {
        private readonly ISetupPresenter _setupPresenter;

        public string Result
        {
            get => txtCounter.Text;
            set => txtCounter.Text = value;
        }

        public SetupView( IMainPresenter mainPresenter )
        {
            InitializeComponent( );
            _setupPresenter = new SetupPresenter( this, mainPresenter );
            btnGoPosition.Click += btnGoPosition_Click;
            btnAddCounter.Click += btnAddCounter_Click;
            btnGoOperationView.Click += btnGoOperationView_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnAddCounter_Click( object sender, System.EventArgs e )
        {
            _setupPresenter.addCounter( );
        }

        private void btnExit_Click( object sender, System.EventArgs e )
        {
            _setupPresenter.exit( );
        }

        private void btnGoOperationView_Click( object sender, System.EventArgs e )
        {
            _setupPresenter.goOperationView( );
        }

        private void btnGoPosition_Click( object sender, System.EventArgs e )
        {
            _setupPresenter.goPositionView( );
        }
    }
}