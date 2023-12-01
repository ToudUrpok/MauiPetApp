using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiPetApp.Data;

namespace MauiPetApp.ViewModels;

public partial class AddPostViewModel : ObservableObject
{
    [ObservableProperty]
    long _id;

    [ObservableProperty]
    long _userID;

    [ObservableProperty]
    string _title;

    [ObservableProperty]
    string _body;

    public AddPostViewModel()
    {
    }

    [RelayCommand]
    async Task SaveData()
    {
        if (Id == 0)
            await InsertPost();
        else
            await UpdatePost();
    }


    [RelayCommand]
    async Task InsertPost()
    {
        await PostsManager.Add(0, Title, Body);

        WeakReferenceMessenger.Default.Send(new RefreshMessage(true));

        await Shell.Current.GoToAsync("..");
    }


    [RelayCommand]
    async Task UpdatePost()
    {
        Post postToSave = new()
        {
            Id = Id,
            UserID = UserID,
            Title = Title,
            Body = Body
        };

        await PostsManager.Update(postToSave);

        WeakReferenceMessenger.Default.Send(new RefreshMessage(true));

        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    private async Task DeletePost()
    {
        if (Id == 0)
            return;

        await PostsManager.Delete(Id);

        WeakReferenceMessenger.Default.Send(new RefreshMessage(true));

        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    private async Task DoneEditing()
    {
        await Shell.Current.GoToAsync("..");
    }
}
