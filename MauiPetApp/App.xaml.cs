using MauiPetApp.Helpers;

namespace MauiPetApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var theme = ThemeHelper.GetCurrentTheme();

        ThemeHelper.SetTheme(theme);
        //if (Preferences.Get("UseSystemTheme", false))
        //{
        //    mergedDictionaries.Add(new SystemTheme());
        //}
        //else
        //{

        //}

        MainPage = new AppShell();
    }
}