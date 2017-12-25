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
                { ViewType.Setup, new SetupView( this ) },
                { ViewType.Position, new PositionView( this ) },
                { ViewType.Operation, new OperartionView( this ) },
            };
            changeSubView( ViewType.Setup );
        }

        public void changeSubView( ViewType viewType )
        {
            _mainView.SubView = _viewTable[ viewType ];
        }

        public void exit( )
        {
            Environment.Exit( 0 );
        }
    }
}