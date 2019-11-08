using System;

class Bullet
{
	private char m_cBRender;

	private float m_fBSpeed;
	public float m_fBLife;

	public AnotherVec2 m_vBPos;
	public AnotherVec2 m_vBDir;

	public bool bIsDie => (m_fBLife <= 0);

	public void Init(float life, AnotherVec2 pos, AnotherVec2 dir, float speed, char c)
	{
		m_fBLife = life;
		m_vBPos = pos;
		m_vBDir = dir;
		m_fBSpeed = speed;
		m_cBRender = c;
	}

	public void Update(float a_fDelta)
	{
		RenderClear();

		m_fBLife -= a_fDelta;
		m_vBPos -= (m_vBDir * m_fBSpeed * a_fDelta);
	}

	public void RenderClear()
	{
		if (Util.ConsoleBoundaryCheck(m_vBPos) == false)
		{
			return;
		}

		Console.SetCursorPosition((int)m_vBPos.x, (int)m_vBPos.y);
		Console.Write(' ');
	}

	public void Render()
	{
		if (Util.ConsoleBoundaryCheck(m_vBPos) == false)
		{
			return;
		}

		Console.SetCursorPosition((int)m_vBPos.x, (int)m_vBPos.y);
		Console.Write(m_cBRender);
	}
}
