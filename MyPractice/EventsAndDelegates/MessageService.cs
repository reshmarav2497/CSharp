namespace MyPractice.EventsAndDelegates;

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs args)
    {
        Console.WriteLine("MessageService: Sending an text message " + args.Video.Title);
    }
}