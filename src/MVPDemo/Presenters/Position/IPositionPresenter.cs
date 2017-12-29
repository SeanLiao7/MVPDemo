using MVPDemo.Views;

namespace MVPDemo.Presenters
{
    public interface IPositionPresenter : ISubPresenter
    {
        IPositionView PositionView { get; set; }

        void goSetupView( );

        void learn( );
    }
}