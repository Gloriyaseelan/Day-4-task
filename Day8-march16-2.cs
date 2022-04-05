using System;
class vat
{
public virtual void taxcalculation()
{

Console.WriteLine("enter the amt to calculate vat");
int amt=Convert.ToInt32(Console.ReadLine());
float  vat=(amt*20/100);
Console.WriteLine("VAT="+vat);
}
}
class  gst:vat
{
public override void taxcalculation()
{

Console.WriteLine("enter the amt to calculate gst");
int  amt=Convert.ToInt32(Console.ReadLine());
float gst=(amt*12/100);
Console.WriteLine("GST="+gst);
}
}
class inherit
{
public static void Main()
{
vat obj=new vat();
obj.taxcalculation();
gst obj1=new gst();
obj1.taxcalculation();

}
}


