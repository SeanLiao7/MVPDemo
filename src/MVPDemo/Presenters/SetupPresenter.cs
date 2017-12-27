using System;
using System.Threading.Tasks;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public class SetupPresenter : ISetupPresenter
    {
        private readonly IMainPresenter _mainPresenter;

        public ISetupView SetupView { get; set; }

        public SetupPresenter( IMainPresenter mainPresenter )
        {
            _mainPresenter = mainPresenter;
        }

        public void addCounter( )
        {
            var x = new Random( );
            var result = x.Next( 100 );
            SetupView.Result = result.ToString( );
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

        public Task reloadContent( )
        {
            return Task.Run( ( ) => SetupView.Result = "" );
        }
    }
}