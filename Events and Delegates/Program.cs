using Events_and_Delegates;
using Events_and_Delegates.Models;
using Events_and_Delegates.Subscribers;

internal class Program
{
    static void Main(string[] args)
    {
        var message = new Message() { MessageBody = "Message content" };
        var mainTask = new MainTask(); //Publisher
        var mailService = new MailService(); //Subscriber 1
        var messageService = new MessageService(); //Subscriber 2

        mainTask.StartingTaskFinished += mailService.WhenMainTaskFinished; //Pointer to method
        mainTask.StartingTaskFinished += messageService.WhenMainTaskFinished; //Pointer to method

        //Flow:
        // 1 StartingTask
        // 2 OnStartingTaskFinished
        // 3 StartingTaskFinished (subscribers) 

        mainTask.StartingTask(message);
    }
}