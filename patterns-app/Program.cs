// See https://aka.ms/new-console-template for more information

// using BuilderParameter;

var ms = new MailService();
await ms.SendEmail(email => email.From("foo@bar.com")
    .To("bar@baz.com")
    .Body("Hello, how are you?"));
