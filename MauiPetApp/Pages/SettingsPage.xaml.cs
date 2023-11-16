using MauiPetApp.Helpers;

namespace MauiPetApp.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();

        themePicker.SelectedItem = ThemeHelper.GetCurrentTheme();
        themePicker.SelectedIndexChanged += OnPickerSelectionChanged;
    }

    void OnPickerSelectionChanged(object sender, EventArgs e)
    {
        Picker picker = sender as Picker;
        Theme theme = (Theme)picker.SelectedItem;

        ThemeHelper.SetTheme(theme);
    }
}