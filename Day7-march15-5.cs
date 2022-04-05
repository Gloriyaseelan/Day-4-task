using System;
public class product
{
public static void Main()
{
string[][]store=new string[3][];
store[0]=new string[]{"biscuit","biscuit","biscuit","biscuit"};
store[1]=new string[]{"chocolate","chocolate","chocolate","chocolate","chocolate"};
store[2]=new string[]{"drinks","drinks","drinks","drinks","drinks"};
for (int i=0;i<store.Length;i++)
{
for(int j=0;j<store[i].Length;j++)
Console.Write(store[i][j]+"\t");
Console.WriteLine();
}
}
}
