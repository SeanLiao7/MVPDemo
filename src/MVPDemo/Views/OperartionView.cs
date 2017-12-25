using System.Windows.Forms;
using MetroFramework.Controls;
using MVPDemo.Presenters;

namespace MVPDemo.Views
{
    public partial class OperartionView : MetroUserControl, IOperationView
    {
        private readonly IOperationPresenter _operationPresenter;

        public string ProgramResult
        {
            get => txtResult.Text;
            set => txtResult.Text = value;
        }

        public OperartionView( IMainPresenter mainPresenter )
        {
            InitializeComponent( );
            _operationPresenter = new OperationPresenter( this, mainPresenter );
            btnReceiveProgramResult.Click += btnReceiveProgramResult_Click;
            btnGoSetupView.Click += btnGoSetupView_Click;
            btnExit.Click += btnExit_Click;
        }

        private void btnExit_Click( object sender, System.EventArgs e )
        {
            _operationPresenter.exit( );
        }

        private void btnGoSetupView_Click( object sender, System.EventArgs e )
        {
            _operationPresenter.goSetupView( );
        }

        private void btnReceiveProgramResult_Click( object sender, System.EventArgs e )
        {
            _operationPresenter.receiveProgramResult( );
        }
    }
}