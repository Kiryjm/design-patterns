// See https://aka.ms/new-console-template for more information
using SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

var j = new Journal();
j.AddEntry("I cried today");
j.AddEntry("I write code");
Console.WriteLine();

 var p = new PersistenceManager();
      var filename = @"D:\My programs\journal.txt";
      p.SaveToFile(j, filename);
      
      var psi = new ProcessStartInfo();
      psi.FileName = filename;
      psi.UseShellExecute = true;
      Process.Start(psi);
