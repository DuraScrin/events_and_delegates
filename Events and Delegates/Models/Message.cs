
namespace Events_and_Delegates.Models;

internal class Message
{
    public string MessageBody { get; set; }
}

internal class CustomEventArgs : EventArgs
{
    public Message Message { get; set; }
}