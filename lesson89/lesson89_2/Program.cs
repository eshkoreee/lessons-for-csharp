namespace lesson89_2
{
    public delegate void Notify(string message);

    class MessagePublisher
    {
        public event Notify OnNotify;

        public void RaiseEvent(string message)
        {
            OnNotify?.Invoke(message); 
        }
    }

    class SmsSubscriper
    {
        public void ReceiveSms(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }

    class EmailSubscriber
    {
        public void ReceiveEmail(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var publisher = new MessagePublisher();

            var emailSubscriber = new EmailSubscriber();
            var smsSubscriber = new SmsSubscriper();

            publisher.OnNotify += smsSubscriber.ReceiveSms;
            publisher.OnNotify += emailSubscriber.ReceiveEmail;

            publisher.RaiseEvent("Hello World!");
            Console.WriteLine();
        }
    }
}
