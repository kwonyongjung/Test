using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlayerScene : Scene
{
	static public int m_nSelectPlayer;		//0,1에 대한 캐릭 선택
	private int m_nChoicePosX = 45;			//선택 화살표의 X값

	public string[] m_sRender1 = new string[4]
	{
	  "     ■     ",
	  " ◀■■■▶ ",
	  "     ■    ",
	  "   ■■■   ",
	};
	public string[] m_sRender2 = new string[4]
	{
	  "     ▲     ",
	  " §■○■§ ",
	  "     ■    ",
	  "   §■§   ",
	};

	public void Run()
	{
		while (true)
		{
			Render();

			var Key = Console.ReadKey();
			eKey n_TileX = eKey.Max;

			if (Key.Key == ConsoleKey.LeftArrow)
			{
				n_TileX = eKey.Left;
			}

			else if (Key.Key == ConsoleKey.RightArrow)
			{
				n_TileX = eKey.Right;
			}

			else if (Key.Key == ConsoleKey.Spacebar)
			{
				n_TileX = eKey.Space;
			}

			Update(n_TileX);
		}
	}

	override public void Update(eKey p_Temp)
	{
		Console.Clear();

		switch (p_Temp)
		{
			case eKey.Left:
				m_nChoicePosX = 45;
				break;
			case eKey.Right:
				m_nChoicePosX = 65;
				break;

			case eKey.Space:
				if (m_nChoicePosX == 45)
				{
					m_nSelectPlayer = 0;
				}
				else
				{
					m_nSelectPlayer = 1;
				}

				Console.Clear();
				GameFPS gameFPS = new GameFPS();
				GameFPS.Open();
				break;
		}	
	}

	public override void Render()
	{
		for (int i = 0; i < m_sRender1.Length; i++)
		{
			Console.SetCursorPosition(40, 15 + i);
			Console.WriteLine(m_sRender1[i]);
		}

		for (int i = 0; i < m_sRender2.Length; i++)
		{
			Console.SetCursorPosition(60, 15 + i);
			Console.WriteLine(m_sRender2[i]);
		}
		Console.SetCursorPosition(m_nChoicePosX ,13);
		Console.Write("▼");
	}
}
