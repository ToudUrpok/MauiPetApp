using MauiPetApp.ViewModels;

namespace MauiPetApp.Pages;

public partial class PostsPage : ContentPage
{
	public PostsPage()
	{
		InitializeComponent();
        BindingContext = new PostsViewModel();
    }
}