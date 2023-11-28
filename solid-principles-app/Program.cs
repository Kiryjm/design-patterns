// See https://aka.ms/new-console-template for more information
using SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

var rc = new Rectangle(3, 2);
Helper.UseIt(rc);
//Expect area of 30, got 30

var sq = new Square(5);
Helper.UseIt(sq);
//Expect area of 50, got 100
// if we try to override Width, Height for Square