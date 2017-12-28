using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private readonly Dictionary<ViewType, ISubView> _viewTable;

        public IMainView MainView { get; set; }

        public MainPresenter( )
        {
            _viewTable = new Dictionary<ViewType, ISubView>
            {
                { ViewType.Setup, new SetupView( new SetupPresenter( this ) ) },
                { ViewType.Position, new PositionView( new PositionPresenter( this ) ) },
                { ViewType.Operation, new OperartionView( new OperationPresenter( this ) ) },
            };
        }

        public async void changeSubView( ViewType viewType )
        {
            var currenView = MainView.SubView;
            if ( currenView != null )
                currenView.IsEnable = false;
            var view = _viewTable.TryGetValue( viewType, out var subView )
                ? subView : throw new KeyNotFoundException( $"Can't find subView by {viewType}." );
            await view.reloadViewContent( );
            view.IsEnable = true;
            MainView.SubView = view;
        }

        public void exit( )
        {
            Environment.Exit( 0 );
        }

        public void loadView( )
        {
            MainView.ViewWindowState = FormWindowState.Normal;
            MainView.ViewBorderStyle = FormBorderStyle.None;
            changeSubView( ViewType.Setup );
        }
    }
}