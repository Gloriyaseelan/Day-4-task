using System;
class employee
{
public void details()
{
Console.WriteLine("Enter employee id: ");
string id=Console.ReadLine();
Console.WriteLine("Enter your name: ");
string name=Console.ReadLine();
Console.WriteLine("Enter male/female: ");
string gender=Console.ReadLine();
Console.WriteLine("enter year of experiance: ");
int yox=Convert.ToInt32(Console.ReadLine());

}
}


class salary:employee
{
public void calci()
{
Console.WriteLine("enter salary: ");
int salary=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter your department (sales/production): ");
string dept=Console.ReadLine();
if(dept=="sales")
{
int total=((salary*20)/100)+salary;
Console.WriteLine("TOTAL SALARY="+" "+total);
}
else
{
int total=((salary*10)/100)+salary;
Console.WriteLine("TOTAL SALARY="+" "+total);
}
}
}




class inherit
{
public static void Main()
{
salary obj=new salary();
obj.details();
obj.calci();
}
}







