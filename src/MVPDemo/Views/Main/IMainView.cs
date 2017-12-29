using MetroFramework;
using MetroFramework.Components;

namespace MVPDemo.Views
{
    public interface IMainView
    {
        MetroStyleManager StyleManager { get; }

        ISubView SubView { get; set; }

        bool ToggleTheme { get; }

        void setMaximumSize( );

        void updateTheme( MetroThemeStyle themeStyle );
    }
}