using System;
					
public class Program
{
	public static string[] data = {
		" \u000810x \u000810","100x100",
		" \u000811x \u000811","110x110"
	};
	
	public static void Main()
	{
		Array.Sort(data);
		foreach(string s in data)
		{
		  Console.WriteLine(s);
		}
	}
}