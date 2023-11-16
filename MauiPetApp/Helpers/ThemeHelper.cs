namespace MauiPetApp.Helpers;

public class ThemeHelper
{
    public static Theme GetCurrentTheme()
    {
        Theme theme = Theme.Light;
        if (Preferences.ContainsKey("AppTheme"))
        {
            string themeStr = Preferences.Get("AppTheme", Theme.Light.ToString());
            Enum.TryParse<Theme>(themeStr, out theme);
        }

        return theme;
    }

    public static void SetTheme(Theme theme)
    {
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;

        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
        }

        switch (theme)
        {
            case Theme.Dark:
                mergedDictionaries.Add(new DarkTheme());
                Preferences.Set("AppTheme", Theme.Dark.ToString());
                break;
            case Theme.Light:
            default:
                mergedDictionaries.Add(new LightTheme());
                Preferences.Set("AppTheme", Theme.Light.ToString());
                break;
        }
    }
}
