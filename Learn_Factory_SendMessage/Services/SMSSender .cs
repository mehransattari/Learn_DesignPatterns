namespace Learn_Factory_SendMessage.Services
{
    public class SMSSender : IMessageSender
    {
        public string SendMessage(string message)
        {
            return "Sending SMS: " + message;
        }
    }
}
