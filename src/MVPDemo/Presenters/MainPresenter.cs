using System;
using System.Collections.Generic;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView _mainView;

        private readonly Dictionary<ViewType, ISubView> _viewTable;

        public MainPresenter( IMainView mainView )
        {
            _mainView = mainView;
            _viewTable = new Dictionary<ViewType, ISubView>
            {
                { ViewType.Setup, new SetupView( new SetupPresenter( this ) ) },
                { ViewType.Position, new PositionView( new PositionPresenter( this ) ) },
                { ViewType.Operation, new OperartionView( new OperationPresenter( this ) ) },
            };
            changeSubView( ViewType.Setup );
        }

        public void changeSubView( ViewType viewType )
        {
            _mainView.SubView?.reloadViewContent( );
            _mainView.SubView = _viewTable.TryGetValue( viewType, out var subView )
                ? subView : throw new KeyNotFoundException( $"Can't find subView by {viewType}." );
        }

        public void exit( )
        {
            Environment.Exit( 0 );
        }
    }
}