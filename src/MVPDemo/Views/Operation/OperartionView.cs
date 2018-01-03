using System;
using System.Threading.Tasks;
using MetroFramework.Controls;
using MVPDemo.Presenters;

namespace MVPDemo.Views
{
    public partial class OperartionView : MetroUserControl, IOperationView
    {
        private readonly IOperationPresenter _operationPresenter;

        public bool IsEnable
        {
            get => Enabled;
            set => this.updateUi( x => x.Enabled = value );
        }

        public string ProgramResult
        {
            get => txtResult.Text;
            set => txtResult.updateUi( x => x.Text = value );
        }

        public OperartionView( IOperationPresenter operationPresenter )
        {
            InitializeComponent( );
            operationPresenter.OperationView = this;
            _operationPresenter = operationPresenter;
            btnReceiveProgramResult.Click += btnReceiveProgramResult_Click;
            btnGoSetupView.Click += btnGoSetupView_Click;
            btnExit.Click += btnExit_Click;
        }

        public Task reloadViewContent( )
        {
            return _operationPresenter.reloadContent( );
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            _operationPresenter.exit( );
        }

        private void btnGoSetupView_Click( object sender, EventArgs e )
        {
            _operationPresenter.goSetupView( );
        }

        private void btnReceiveProgramResult_Click( object sender, EventArgs e )
        {
            _operationPresenter.receiveProgramResult( );
        }
    }
}