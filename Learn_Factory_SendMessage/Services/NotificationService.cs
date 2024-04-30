namespace Learn_Factory_SendMessage.Services
{
    public class NotificationService
    {
        private readonly IMessageSender _messageSender;

        public NotificationService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Notify(string message)
        {
            _messageSender.SendMessage(message);
        }
    }

}
