using WhatsAppApiUCU;

namespace Library
{
    public class WhatsAppChannel : IMessageChannel
    {
        public void Send(Message message)
        {
            const string accountSid = "ACa8395e7223e7719988c09db8dfb68f0f";
            const string authToken = "fdcaac12dc7e5b031908429ee402e7a4";

            var whatsApp = new WhatsAppApi(accountSid, authToken);
            whatsApp.Send(message.To.Phone, message.Text);
        }
    }
}