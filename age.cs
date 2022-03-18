using System;
class members
{
int age;
string name;

public members()
{
Console.WriteLine("enter ur age:");
 age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your name:");
 name=Console.ReadLine();

}

public members(int age,string name)
{
this.age=age;
this.name=name;
}


public static void Main()
{
members obj=new members();\n
members obj1=new members(22,"gayu");\n
Console.WriteLine(obj1.age);/n
Console.WriteLine(obj1.name);/n


}
}
