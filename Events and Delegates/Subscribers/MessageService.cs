namespace Events_and_Delegates.Subscribers;

internal class MessageService
{
    //Should be 'void (object sender, EventArgs e)'
    public void WhenMainTaskFinished(object source, EventArgs e)
    {
        Console.WriteLine("  Subscriber 2: was notified...");
    }
}
