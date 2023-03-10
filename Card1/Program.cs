using System;
using System.Collections.Generic;

public class Card1
{
	static string n = null;
	static List<int> clist = new List<int>();
	static List<int> rlist = new List<int>();

	static void Input()
	{
		n = Console.ReadLine();
		
		for (int i = 1; i <= int.Parse(n); i++)
			clist.Add(i);
	}

	static void Solution()
	{
		while (clist.Count != 1)
		{
			rlist.Add(clist[0]);
			clist.RemoveAt(0);
			if (clist.Count == 1)
				break ;
			clist.Add(clist[0]);
			clist.RemoveAt(0);
		}
		rlist.Add(clist[0]);
	}

	static void Output()
	{
        string res = "";
        
		for (int i = 0; i < int.Parse(n); i++)
		{
			res += rlist[i].ToString();
			if (i != int.Parse(n) - 1)
				res += " ";
		}
        Console.Write(res);
	}

	public static void Main()
	{
		Input();
		Solution();
		Output();
	}
}