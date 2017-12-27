using System.Threading.Tasks;

namespace MVPDemo.Presenters
{
    public interface ISubPresenter
    {
        Task reloadContent( );
    }
}