namespace Events_and_Delegates.Subscribers;

public class MailService
{
    //Should be 'void (object sender, EventArgs e)'
    public void WhenMainTaskFinished(object source, EventArgs e)
    {
        Console.WriteLine(" Subscriber 1: was notified...");
    }
}
