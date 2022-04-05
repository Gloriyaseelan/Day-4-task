using System;
class marks
{
public static void Main()
{
int []marks=new int[5];
Console.WriteLine("enter a student name:");
string name=Console.ReadLine();
int sum=0;
Console.WriteLine("enter the marks:");
for(int i=0;i<5;i++)
{
marks[i]=Convert.ToInt32(Console.ReadLine());
sum=sum+marks[i];
}
Console.WriteLine("sum="+sum);
int percentage=(sum/5);
Console.WriteLine("percentage="+percentage+"%");

}
}
