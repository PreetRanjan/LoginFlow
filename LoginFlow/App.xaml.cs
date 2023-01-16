#if __ANDROID__
using Android.Content.Res;

using Microsoft.Maui.Controls.Compatibility.Platform.Android;

#endif
namespace LoginFlow;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderLine", (handler, view) =>
        {
#if __ANDROID__
            (handler.PlatformView as Android.Views.View).SetBackgroundColor(Microsoft.Maui.Graphics.Colors.Transparent.ToAndroid());
#endif
        });
    }
}
