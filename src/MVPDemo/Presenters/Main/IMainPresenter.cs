using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public interface IMainPresenter
    {
        IMainView MainView { get; set; }

        void changeSubView( ViewType viewType );

        void exit( );

        void loadView( );

        void toggleTheme( );
    }
}