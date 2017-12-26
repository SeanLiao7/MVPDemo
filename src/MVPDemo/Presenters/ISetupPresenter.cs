using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public interface ISetupPresenter : ISubPresenter
    {
        ISetupView SetupView { get; set; }

        void addCounter( );

        void exit( );

        void goOperationView( );

        void goPositionView( );
    }
}