
using System;

namespace MyNameSpace
{

class MyClass
{
int field1 = 1;
int field2 = 2;
public void MyMethod()
{
Console.WriteLine("MyNameSpace.MyClass fields:");
Console.WriteLine("Value of field1 = {0}", field1);
Console.WriteLine("Value of field2 = {0}", field2);
}
static void Main()
{
// Create an object of MyClassNameSpace.MyClass:
MyClass mc1 = new MyClass();
// Invoke MyMethod on the mc1 object:
mc1.MyMethod();
// Create an object of YourNameSpace.MyClass:
// Notice the use of the fully qualified name:
YourNameSpace.MyClass mc2 = new YourNameSpace.MyClass();
// Invoke MyMethod on the mc2 object:
mc2.MyMethod();
}
}
}
namespace YourNameSpace
{

class MyClass
{
int field1 = 3;
int field2 =4;
public void MyMethod()
{
Console.WriteLine("YourNameSpace.MyClass fields:");
Console.WriteLine("Value of field1 = {0}", field1);
Console.WriteLine("Value of field2 = {0}", field2);
}
}
}