using MauiPetApp.Data;
using MauiPetApp.ViewModels;

namespace MauiPetApp.Pages;

[QueryProperty("PostToDisplay", "post")]
public partial class AddPostPage : ContentPage
{
    AddPostViewModel viewModel;
    public AddPostPage()
	{
		InitializeComponent();

        viewModel = new AddPostViewModel();
        BindingContext = viewModel;
    }

    Post _postToDisplay;
    public Post PostToDisplay
    {
        get => _postToDisplay;
        set
        {
            if (_postToDisplay == value)
                return;

            _postToDisplay = value;

            viewModel.Id = _postToDisplay.Id;
            viewModel.Title = _postToDisplay.Title;
            viewModel.Body = _postToDisplay.Body;
            viewModel.UserID = _postToDisplay.UserID;
        }
    }
}