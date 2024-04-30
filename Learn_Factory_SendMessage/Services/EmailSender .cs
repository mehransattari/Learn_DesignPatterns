namespace Learn_Factory_SendMessage.Services
{
    public class EmailSender : IMessageSender
    {
        public string SendMessage(string message)
        {
            return "Sending email: " + message;
        }
    }
}
