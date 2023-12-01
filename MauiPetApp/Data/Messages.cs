using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiPetApp.Data;

public class RefreshMessage : ValueChangedMessage<bool>
{
    public RefreshMessage(bool value) : base(value)
    {
    }
}
