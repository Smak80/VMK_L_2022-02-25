// See https://aka.ms/new-console-template for more information

using VMK_L_2022_02_25;

MyStruct s1 = new MyStruct(1, 1.5);
MyStruct s2 = new MyStruct(2, -9.65);
var class1 = new MyClass();
Console.WriteLine(class1);
class1.Add(s1);
Console.WriteLine(class1);
class1.Add(s2);
Console.WriteLine(class1);
class1.Add(new []{new MyStruct(3, 9.88), new MyStruct(4, -34.11)});
Console.WriteLine(class1);