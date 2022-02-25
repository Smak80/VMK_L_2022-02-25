// See https://aka.ms/new-console-template for more information

using VMK_L_2022_02_25;

Console.WriteLine("Hello, World!");
MyStruct s1 = new MyStruct(1, 1.5);
MyStruct s2 = new MyStruct(2, -9.65);
var class1 = new MyClass();
Console.WriteLine(class1);
class1.Add(s1);
Console.WriteLine(class1);
class1.Add(s2);
Console.WriteLine(class1);