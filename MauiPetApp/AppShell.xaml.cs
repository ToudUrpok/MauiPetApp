using MauiPetApp.Pages;

namespace MauiPetApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("addpost", typeof(AddPostPage));
    }
}