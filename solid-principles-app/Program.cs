// See https://aka.ms/new-console-template for more information
using SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

 var apple = new Product("Apple", Color.Green, Size.Small);
      var tree = new Product("Tree", Color.Green, Size.Large);
      var house = new Product("House", Color.Blue, Size.Large);

      Product[] products = {apple, tree, house};

      var pf = new ProductFilter();
      
      WriteLine("Green products (old):");
      foreach (var p in pf.FilterByColor(products, Color.Green))
        WriteLine($" - {p.Name} is green");

      // ^^ BEFORE

      // vv AFTER
      var bf = new BetterFilter();
      WriteLine("Green products (new):");
      foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
        WriteLine($" - {p.Name} is green");

      WriteLine("Large products");
      foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
        WriteLine($" - {p.Name} is large");

      var largeGreenSpec = new ColorSpecification(Color.Green) 
                           & new SizeSpecification(Size.Large);
      //var largeGreenSpec = Color.Green.And(Size.Large);
      
      WriteLine("Large blue items");
      foreach (var p in bf.Filter(products,
        new AndSpecification<Product>(new ColorSpecification(Color.Blue), 
          new SizeSpecification(Size.Large)))
      )
      {
        WriteLine($" - {p.Name} is big and blue");
      }
