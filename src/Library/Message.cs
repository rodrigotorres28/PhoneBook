namespace Library
{
    public class Message
    {
        protected Message(Contact from, Contact to)
        {
            this.From = from;
            this.To = to;
        }

        public string Text { get; set; }

        public Contact From { get; }

        public Contact To { get; }
    }
}