// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using VMK_L_2022_02_25;

MyStruct s1 = new MyStruct(1, 1.5);
MyStruct s2 = new MyStruct(2, -9.65);
var class1 = new MyClass();
Console.WriteLine(class1);
class1.Add(s1);
Console.WriteLine(class1);
class1.Add(s2);
Console.WriteLine(class1);
class1.Add(new []{new MyStruct(2, 9.88), new MyStruct(4, -34.11)});
Console.WriteLine(class1);
class1.Remove(2);
Console.WriteLine(class1);
var l = class1.MyList;
l.Add(new MyStruct(0, 0.87));
Console.WriteLine(class1);
Stopwatch sw = new Stopwatch();
sw.Start();
for (int i = 0; i < 5000000; i++)
{
    class1.Add(new MyStruct(i, (double)i/10));
}
sw.Stop();
//Console.WriteLine(class1);
Console.WriteLine("Время создания списка и его вывода: {0}мс.", sw.ElapsedMilliseconds);
