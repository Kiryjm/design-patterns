public class MailService
{
    public class EmailBuilder
    {
        public class Email
        {
            public string From, To, Subject, Body;
        }

        private readonly Email email;

        public EmailBuilder(Email email) => this.email = email;

        public EmailBuilder From(string from)
        {
            email.From = from;
            return this;
        }

        public EmailBuilder To(string to)
        {
            email.To = to;
            return this;
        }

        public EmailBuilder Subject(string subject)
        {
            email.Subject = subject;
            return this;
        }

        public EmailBuilder Body(string body)
        {
            email.Body = body;
            return this;
        }
    }

    private async Task SendEmailInternal(EmailBuilder.Email email)
    {
        Console.WriteLine("Sending email...");
        await Task.Delay(3000);
        Console.WriteLine("Email was sent");
    }

    public async Task SendEmail(Action<EmailBuilder> builder)
    {
        var email = new EmailBuilder.Email();
        builder(new EmailBuilder(email));
        await SendEmailInternal(email);
    }
}