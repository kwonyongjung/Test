using System;

class Ending
{
	 public string[] m_sCRender = new string[8]
	 {
	   "            ",
	   "      ■     ",
       "  ◀■■■▶ ",
	   "      ■    ",
	   "    ■■■   ",
	   "            ",
	   "  C l E A R !",
	   "               ",
	 };
	 public string[] m_sDRender = new string[8]
	 {
	   "            ",
	   "      □     ",
	   "  ◁■■  ▶ ",
	   "      ■    ",
	   "      □■   ",
	   "      ▒       ",
	   "     D I E",
	   "               ",
	 };

	public float m_fCSpeedY = 50;
	public float m_fDSpeedY = 0;

	public float m_fSpeed= 10 * 0.001f;

	public void ClearEnding()
	{
		while (true)
		{
			m_fCSpeedY -= m_fSpeed;

			for (int i = 0; i < m_sCRender.Length; i++)
			{
				Console.SetCursorPosition(50, (int)m_fCSpeedY + i);
				Console.WriteLine(m_sCRender[i]);
			}

			if (m_fCSpeedY < 0)
			{
				break;
			}
		}
	}

	public void DieEnding()
	{
		while (true)
		{
			m_fDSpeedY += m_fSpeed;

			for (int i = 0; i < m_sCRender.Length; i++)
			{
				Console.SetCursorPosition(50, (int)m_fDSpeedY + i);
				Console.WriteLine(m_sDRender[i]);
			}

			if (m_fDSpeedY > 50)
			{
				break;
			}
		}
	}
}

