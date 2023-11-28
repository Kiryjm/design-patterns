// See https://aka.ms/new-console-template for more information
using SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

var parent = new Person { Name = "John" };
var child1 = new Person { Name = "Chris" };
var child2 = new Person { Name = "Matt" };

var relationships = new Relationships();
relationships.AddParentAndChild(parent, child1);
relationships.AddParentAndChild(parent, child2);

new Research(relationships);
// Output:
//John has child called Chris
// John has child called Matt