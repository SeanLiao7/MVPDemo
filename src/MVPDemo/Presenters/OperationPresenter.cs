using System;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public class OperationPresenter : IOperationPresenter
    {
        private readonly IMainPresenter _mainPresenter;

        public IOperationView OperationView { get; set; }

        public OperationPresenter( IMainPresenter mainPresenter )
        {
            _mainPresenter = mainPresenter;
        }

        public void exit( )
        {
            _mainPresenter.exit( );
        }

        public void goSetupView( )
        {
            _mainPresenter.changeSubView( ViewType.Setup );
        }

        public void receiveProgramResult( )
        {
            var rnd = new Random( );
            var result = rnd.Next( 2 ) > 0;
            OperationView.ProgramResult = result.ToString( );
        }

        public void reloadContent( )
        {
            OperationView.ProgramResult = "";
        }
    }
}