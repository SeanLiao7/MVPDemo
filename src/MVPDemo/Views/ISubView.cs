namespace MVPDemo.Views
{
    public interface ISubView
    {
        bool IsEnable { get; set; }

        void reloadViewContent( );
    }
}