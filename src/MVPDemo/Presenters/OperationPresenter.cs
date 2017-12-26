using System;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public class OperationPresenter : IOperationPresenter
    {
        private readonly IMainPresenter _mainPresenter;
        private readonly IOperationView _operartionView;

        public OperationPresenter( IOperationView operartionView, IMainPresenter mainPresenter )
        {
            _operartionView = operartionView;
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
            _operartionView.ProgramResult = result.ToString( );
        }

        public void reloadContent( )
        {
            _operartionView.ProgramResult = "";
        }
    }
}