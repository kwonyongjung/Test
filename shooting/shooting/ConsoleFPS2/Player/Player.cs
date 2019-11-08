using System;

class Player
{
    private string[] m_sRender = new string[6]
    {
      "            ",
      "     ■     ",
      " ◀■■■▶ ",
      "     ■    ",
      "   ■■■   ",
      "            "
	};

    public Vec2 m_vPos;

    public Player(int x, int y)
    {
        m_vPos.x = x;
        m_vPos.y = y;
    }

    public void Update(float a_fDelta)
    {
        Render();
    }  

    public void Render()
    {		
		if (Util.ConsoleBoundaryCheck(m_vPos) == false)
		{
			return;
		}

        for (int i = 0; i < m_sRender.Length; i++)
        {                   
            Console.SetCursorPosition((int)m_vPos.x, (int)m_vPos.y + i);
            Console.WriteLine(m_sRender[i]);
        }
    }	
}

