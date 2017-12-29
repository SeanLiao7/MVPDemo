using System.Threading.Tasks;
using MetroFramework.Components;

namespace MVPDemo.Views
{
    public interface ISubView
    {
        bool IsEnable { get; set; }

        MetroStyleManager StyleManager { get; set; }

        Task reloadViewContent( );
    }
}