// See https://aka.ms/new-console-template for more information

 var pb = new PersonBuilder();
      Person person = pb
        .Lives
          .At("123 London Road")
          .In("London")
          .WithPostcode("SW12BC")
        .Works
          .At("Fabrikam")
          .AsA("Engineer")
          .Earning(123000);

      Console.WriteLine(person);
