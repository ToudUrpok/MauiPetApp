using MauiPetApp.Helpers;

namespace MauiPetApp.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();

        bool isSystemThemeUsed = ThemeHelper.IsSystemThemeUsed();

        useSystemTheme.IsChecked = isSystemThemeUsed;
        useSystemTheme.CheckedChanged += OnCheckedChanged;

        themePicker.IsEnabled = !isSystemThemeUsed;
        themePicker.SelectedItem = ThemeHelper.GetCurrentAppTheme();
        themePicker.SelectedIndexChanged += OnPickerSelectionChanged;
    }

    void OnCheckedChanged(object sender, EventArgs e)
    {
        CheckBox cb = sender as CheckBox;

        themePicker.IsEnabled = !cb.IsChecked;
        ThemeHelper.SetTheme(cb.IsChecked);
    }

    void OnPickerSelectionChanged(object sender, EventArgs e)
    {
        Picker picker = sender as Picker;
        Theme theme = (Theme)picker.SelectedItem;

        ThemeHelper.SetAppTheme(theme);
    }
}