namespace MVPDemo.Presenters
{
    public interface IOperationPresenter
    {
        void exit( );

        void goSetupView( );

        void receiveProgramResult( );

        void reloadContent( );
    }
}