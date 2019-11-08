using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

class Initsol
{
	//public string s = string.Empty;
	//public int[] a = new int[3] {65,65,65 };
	//public void Info()
	//{
	//	for (int i = 0; i < 3; i++) {
	//		Console.Write((char)a[i]);
	//	}
	//}
	//public void Run()
	//{
	//	int k = 0;
	//	while (k ==2)
	//	{
	//		Info();
	//		var Key = Console.ReadKey();

	//		eKey p_Temp = eKey.Max;
	//		if (Key.Key == ConsoleKey.UpArrow)
	//		{
	//			p_Temp = eKey.Up;
	//		}
	//		else if (Key.Key == ConsoleKey.DownArrow)
	//		{
	//			p_Temp = eKey.Down;
	//		}
	//		else if (Key.Key == ConsoleKey.Enter)
	//		{
	//			p_Temp = eKey.Enter;
	//			k++;
	//		}
	//		Update(p_Temp,k);
	//	}
	//}
	//public void Update(eKey p_Temp,int k)
	//{
	//	switch (p_Temp)
	//	{
	//		case eKey.Up:
	//			a[k]--;
	//			break;
	//		case eKey.Down:
	//			a[k]++;
	//			break;
	//		case eKey.Enter:
	//			s += (char)a[k];
	//			break;
	//	}
	//}
	int i = 1;
	int y = 30;
	public void Info()
	{
		int[,] ar = new int[17, 17]
		{
			{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
			{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,2,1,1,1,1,1,3,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,2,1,1,1,3,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
			{1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
			{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },

		};
		for (int i = 0; i < 17; i++)
		{
			Console.SetCursorPosition(40, 10 + i);
			for (int j = 0; j < 17; j++)
			{
				switch (ar[i, j])
				{
					case 0:
						Console.Write("  ");
						break;
					case 1:
						Console.Write("■");
						break;
					case 2:
						Console.Write("◀");
						break;
					case 3:
						Console.Write("▶");
						break;
				}

			}
			Console.Write("\n");
		}
		Console.SetCursorPosition(55, 30);
		Console.WriteLine("Start");
		Console.SetCursorPosition(56, 32);
		Console.WriteLine("End");
		Console.SetCursorPosition(62, y);
		Console.Write("◀");

	}
	public void Run()
	{
		while (i == 1)
		{
			Info();
			var Key = Console.ReadKey();

			eKey p_Temp = eKey.Max;
			if (Key.Key == ConsoleKey.UpArrow)
			{
				p_Temp = eKey.Up;
			}
			else if (Key.Key == ConsoleKey.DownArrow)
			{
				p_Temp = eKey.Down;
			}
			else if (Key.Key == ConsoleKey.Spacebar)
			{
				p_Temp = eKey.Space;
			}
			Update(p_Temp);
		}
	}
	public void Update(eKey p_Temp)
	{
		Console.Clear();
		switch (p_Temp)
		{
			case eKey.Up:
				y = 30;
				break;
			case eKey.Down:
				y = 32;
				break;
			case eKey.Space:
				if (y == 30)
				{
					Console.Clear();
					OpenScene openScene = new OpenScene();
					OpenScene.Open();
					i--;
				}
				else if (y == 32)
				{
					Environment.Exit(0);
				}
				break;
		}
	}
}

