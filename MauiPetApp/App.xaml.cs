using MauiPetApp.Helpers;

namespace MauiPetApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        ThemeHelper.InitTheme();

        MainPage = new AppShell();
    }
}