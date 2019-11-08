//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Initials 
//{
//	 public int a = 65;
//	 public string s;
//	 public void Run()
//	{
//		int i = 1;
//		while (i == 3)
//		{
//			var Key = Console.ReadKey();

//			eKey p_Temp = eKey.Max;
//			if (Key.Key == ConsoleKey.UpArrow)
//			{
//				p_Temp = eKey.Up;
//			}
//			else if (Key.Key == ConsoleKey.DownArrow)
//			{
//				p_Temp = eKey.Down;
//			}
//			else if (Key.Key == ConsoleKey.Enter)
//			{
//				p_Temp = eKey.Space;
//				i++;
//			}
//			Update(p_Temp);
//		}
//	}
//	 public void Update(eKey p_Temp)
//	{
//		Console.Clear();
//		switch (p_Temp)
//		{
//			case eKey.Up:
//				a++;
//				break;
//			case eKey.Down:
//				a--;
//				break;
//			case eKey.Enter:
//				s += (char)a;
//				break;
//		}
//	}
//}


