using System.Windows.Forms;

namespace MVPDemo.Views
{
    public interface IMainView
    {
        ISubView SubView { get; set; }

        FormBorderStyle ViewBorderStyle { get; set; }

        FormWindowState ViewWindowState { get; set; }
    }
}