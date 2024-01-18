var ms = new EmailService();
ms.SendEmail(builder =>
    builder.From("abc@xyz.com")
    .To("bar@baz.com")
    .Body("Hello")
    .Subject("Greeting"));
