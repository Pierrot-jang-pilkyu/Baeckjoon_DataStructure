using System;
using System.Collections.Generic;

public class Stack
{
	static int size = 0;
	static string n = null;
	static string[] cmd = null;
	static List<int> slist = new List<int>();
	static List<int> rlist = new List<int>();

	static int Top()
	{
		if (size > 0)
			return (slist[size - 1]);
		else
			return (-1);
	}

	static int Pop()
	{
		int res = -1;
	
		if (size > 0)
		{
			res = slist[size - 1];
			slist.RemoveAt(size - 1);
			size--;
		}
		return (res);
	}

	static int Size()
	{
		return (size);
	}

	static int Empty()
	{
		if (size == 0)
			return (1);
		else
			return (0);
	}

	static void Push(int nb)
	{
		slist.Add(nb);
		size++;
	}

	static void Input()
	{
		n = Console.ReadLine();
		
		for (int i = 0; i < int.Parse(n); i++)
		{
			cmd = Console.ReadLine().Split(' ');
			Solution();
		}
	}

	static void Solution()
	{
		if (cmd[0].CompareTo("top") == 0)
			rlist.Add(Top());
		if (cmd[0].CompareTo("pop") == 0)
			rlist.Add(Pop());
		if (cmd[0].CompareTo("size") == 0)
			rlist.Add(Size());
		if (cmd[0].CompareTo("empty") == 0)
			rlist.Add(Empty());
		if (cmd[0].CompareTo("push") == 0)
			Push(int.Parse(cmd[1]));
	}

	static void Output()
	{
		string res = "";

		for (int i = 0; i < rlist.Count; i++)
		{
			res += rlist[i].ToString();
			if (i != rlist.Count - 1)
				res += "\n";
		}

		Console.Write(res);
	}

	public static void Main()
	{
		Input();
		Output();
	}
}