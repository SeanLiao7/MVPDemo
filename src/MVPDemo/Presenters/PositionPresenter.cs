using System;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public class PositionPresenter : IPositionPresenter
    {
        private readonly IMainPresenter _mainPresenter;
        private readonly IPositionView _positionView;

        public PositionPresenter( IPositionView positionView, IMainPresenter mainPresenter )
        {
            _positionView = positionView;
            _mainPresenter = mainPresenter;
        }

        public void goSetupView( )
        {
            _mainPresenter.changeSubView( ViewType.Setup );
        }

        public void learn( )
        {
            var rnd = new Random( );
            var result = rnd.Next( 2 ) > 0;
            _positionView.LearnResult = result.ToString( );
        }
    }
}