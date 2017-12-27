using System.Threading.Tasks;

namespace MVPDemo.Views
{
    public interface ISubView
    {
        bool IsEnable { get; set; }

        Task reloadViewContent( );
    }
}