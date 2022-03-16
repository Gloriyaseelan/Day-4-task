using System;
class addsub
{
public void add()
{
Console.WriteLine("addition");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ans="+(num1+num2));
}
public  void sub()
{
Console.WriteLine("subtraction");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ans="+(num1-num2));
}
}
class muldiv:addsub
{
public void mul()
{
Console.WriteLine("multiplication");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ans="+(num1*num2));
}
public  void div()
{
Console.WriteLine("division");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ans="+(num1/num2));
}
}
class operation
{
public static void Main()
{
addsub obj=new addsub();
obj.add();
obj.sub();
muldiv obj1=new muldiv();
obj1.mul();
obj1.div();
}
}
