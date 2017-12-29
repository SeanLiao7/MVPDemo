using System;
using System.Collections.Generic;
using MetroFramework;
using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private readonly Dictionary<ViewType, ISubView> _viewTable = new Dictionary<ViewType, ISubView>( );

        public IMainView MainView { get; set; }

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
            _viewTable.Add( ViewType.Setup, new SetupView( new SetupPresenter( this ) ) { StyleManager = MainView.StyleManager } );
            _viewTable.Add( ViewType.Position, new PositionView( new PositionPresenter( this ) ) { StyleManager = MainView.StyleManager } );
            _viewTable.Add( ViewType.Operation, new OperartionView( new OperationPresenter( this ) ) { StyleManager = MainView.StyleManager } );

            MainView.setMaximumSize( );
            changeSubView( ViewType.Setup );
        }

        public void toggleTheme( )
        {
            if ( MainView.ToggleTheme )
                MainView.updateTheme( MetroThemeStyle.Dark );
            else
                MainView.updateTheme( MetroThemeStyle.Light );
        }
    }
}