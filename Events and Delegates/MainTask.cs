using Events_and_Delegates.Models;

namespace Events_and_Delegates;

internal class MainTask
{
    public void StartingTask(Message message)
    {
        Console.WriteLine("Main task is started...");
        Thread.Sleep(2000);

        OnStartingTaskFinished();
    }


    // 1 Declare delegate
    public delegate void StartingTask_EventHandler(object sender, EventArgs e);

    //2 Define an event based on that delegate
    public event StartingTask_EventHandler StartingTaskFinished; //StartingTaskFinishing

    //3 Raise the event
    protected virtual void OnStartingTaskFinished()
    {
        //check is any subscribers
        if (StartingTaskFinished is not null)
            StartingTaskFinished(this, EventArgs.Empty);
    }
}
