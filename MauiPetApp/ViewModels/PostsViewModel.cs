using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiPetApp.Data;
using System.Collections.ObjectModel;

namespace MauiPetApp.ViewModels;

public partial class PostsViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Post> _posts;


    [ObservableProperty]
    bool _isRefreshing = false;


    [ObservableProperty]
    bool _isBusy = false;


    [ObservableProperty]
    Post _selectedPost;

    public PostsViewModel()
    {
        _posts = new ObservableCollection<Post>();

        WeakReferenceMessenger.Default.Register<RefreshMessage>(this, async (r, m) =>
        {
            await LoadData();
        });

        Task.Run(LoadData);
    }

    [RelayCommand]
    async Task PostSelected()
    {
        if (SelectedPost == null)
            return;

        var navigationParameter = new Dictionary<string, object>()
        {
            { "post", SelectedPost }
        };

        await Shell.Current.GoToAsync("addpost", navigationParameter);

        MainThread.BeginInvokeOnMainThread(() => SelectedPost = null);
    }

    [RelayCommand]
    async Task LoadData()
    {
        if (IsBusy)
            return;

        try
        {
            IsRefreshing = true;
            IsBusy = true;

            var postsCollection = await PostsManager.GetAll();

            MainThread.BeginInvokeOnMainThread(() =>
            {
                Posts.Clear();

                foreach (Post post in postsCollection)
                {
                    Posts.Add(post);
                }
            });
        }
        finally
        {
            IsRefreshing = false;
            IsBusy = false;
        }
    }

    [RelayCommand]
    async Task AddNewPost()
    {
        await Shell.Current.GoToAsync("addpost");
    }
}
