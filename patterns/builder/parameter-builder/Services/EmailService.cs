public class EmailService
{
    public class EmailBuilder
    {
        private readonly Email Email;
        public EmailBuilder(Email email)
        {
            this.Email = email;
        }

        public EmailBuilder From(string from)
        {
            Email.From = from;
            return this;
        }

        public EmailBuilder To(string to)
        {
            Email.To = to;
            return this;
        }

        public EmailBuilder Subject(string subject)
        {
            Email.Subject = subject;
            return this;
        }

        public EmailBuilder Body(string body)
        {
            Email.Body = body;
            return this;
        }
    }

    public class Email
    {
        public string From, To, Subject, Body;
    }

    private void SendEmailInternal(Email email)
    {

    }
    public void SendEmail(Action<EmailBuilder> builder)
    {
        var email = new Email();
        builder(new EmailBuilder(email));
        SendEmailInternal(email);
    }
}