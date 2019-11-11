using System;

class Player:AllObject
{
	private string[] m_sRender1 = new string[6]
	{
	  "            ",
	  "     ■     ",
	  " ◀■■■▶ ",
	  "     ■    ",
	  "   ■■■   ",
	  "            "
	};
	public string[] m_sRender2 = new string[6]
	{
	  "            ",
	  "     ▲     ",
	  " §■○■§ ",
	  "     ■    ",
	  "   §■§   ",
	  "            "
	};
	public Vec2 m_vPos;

	public Player(int x, int y)
	{
		m_vPos.x = x;
		m_vPos.y = y;
	}

	override public void Render()
	{
		if (Util.ConsoleBoundaryCheck(m_vPos) == false)
		{
			return;
		}

		if (PlayerScene.m_nSelectPlayer == 0)
		{
			for (int i = 0; i < m_sRender1.Length; i++)
			{
				Console.SetCursorPosition((int)m_vPos.x, (int)m_vPos.y + i);
				Console.WriteLine(m_sRender1[i]);
			}
		}
		else
		{
			for (int i = 0; i < m_sRender2.Length; i++)
			{
				Console.SetCursorPosition((int)m_vPos.x, (int)m_vPos.y + i);
				Console.WriteLine(m_sRender2[i]);
			}
		}
	}
}

