using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public interface IMainPresenter
    {
        void changeSubView( ViewType viewType );

        void exit( );
    }
}