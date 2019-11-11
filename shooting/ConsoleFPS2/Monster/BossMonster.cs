using System;

class BossMonster:All
{
	private string[] m_sBmRender = new string[10]
    {
		  "         ■■■■■■■■■■■■■■■■■■ ",
		  "           ■■■■■■■■■■■■■■■■ ",
		  "  ■■■■■■■■■■■■□■□■■■■■■■■■■■",
		  "■■■■■■■■■■■■■□□□■■■■■■■■■■■■",
		  "■■■■■■■■■■■■■■□■■■■■■■■■■■■■",
		  "■■■■■■■■■■■■■■■■■■■■■■■■■■■■",
		  "■■■□■■■■■■■■■■□■■■■■■■■■□■■■",
		  "■■■□■■■■■■■■■■□■■■■■■■■■□■■■",
		  "■■■□■■■■■■■■■■□■■■■■■■■■□■■■",
		  "  ■■▽■■■■■■■■■■▽■■■■■■■■■▽■■",
	};
	private string[] m_sBmnullRender = new string[10] 
	{
		  "                                                       ",
		  "                                                       ",
		  "                                                       ",
		  "                                                       ",
		  "                                                       ",
		  "                                                       ",
		  "                                                       ",
		  "                                                       ",
		  "                                                       ",
		  "                                                       ",
    };

	private float m_fBmSpeed;
	public float m_fBmLife;

	public AnotherVec2 m_vBmPos;
	public AnotherVec2 m_vBmDir;

	public bool bIsDie => (m_fBmLife <= 0);

	public void Init(float life, int x, int y, AnotherVec2 dir, float speed)
	{
		m_fBmLife = life;
		m_vBmPos.x = x;
		m_vBmPos.y = y;
		m_vBmDir = dir;
		m_fBmSpeed = speed;
	}

	override public void Update(float a_fDelta)
	{
		RenderClear();

		m_vBmPos += (m_vBmDir * m_fBmSpeed * a_fDelta);

		//보스 Y의 위치 제한
		if (m_vBmPos.y >= (int)ConsoleLimitXY.BmPos_y)
		{
			m_vBmPos.y = (int)ConsoleLimitXY.BmPos_y;
		}
	}

	override public void RenderClear()
	{
		if (Util.ConsoleBoundaryCheck(m_vBmPos) == false)
		{
			return;
		}

		for (int i = 0; i < m_sBmnullRender.Length; i++)
		{
			Console.SetCursorPosition((int)m_vBmPos.x, (int)m_vBmPos.y + i);
			Console.Write(m_sBmnullRender[i]);
		}
	}

	override public void Render()
	{
		if (Util.ConsoleBoundaryCheck(m_vBmPos) == false)
		{
			return;
		}

		for (int i = 0; i < m_sBmRender.Length; i++)
		{
			Console.SetCursorPosition((int)m_vBmPos.x, (int)m_vBmPos.y + i);
			Console.Write(m_sBmRender[i]);
		}
	}
}
