using System;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public class SetupPresenter : ISetupPresenter
    {
        private readonly IMainPresenter _mainPresenter;
        private readonly ISetupView _setupView;

        public SetupPresenter( ISetupView setupView, IMainPresenter mainPresenter )
        {
            _setupView = setupView;
            _mainPresenter = mainPresenter;
        }

        public void addCounter( )
        {
            var x = new Random( );
            var result = x.Next( 100 );
            _setupView.Result = result.ToString( );
        }

        public void exit( )
        {
            _mainPresenter.exit( );
        }

        public void goOperationView( )
        {
            _mainPresenter.changeSubView( ViewType.Operation );
        }

        public void goPositionView( )
        {
            _mainPresenter.changeSubView( ViewType.Position );
        }
    }
}