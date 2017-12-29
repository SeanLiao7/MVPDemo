using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public interface IOperationPresenter : ISubPresenter
    {
        IOperationView OperationView { get; set; }

        void exit( );

        void goSetupView( );

        void receiveProgramResult( );
    }
}