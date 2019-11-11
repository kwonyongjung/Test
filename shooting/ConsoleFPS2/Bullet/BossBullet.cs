using System;

class BossBullet:AllObject
{
	private char m_cBbRender; 

    private float m_fBbSpeed;
	public float m_fBbLife;
    
    public AnotherVec2 m_vBbDir;
    public AnotherVec2 m_vBbPos;

    public bool bIsDie => (m_fBbLife <= 0);

    public void Init(float life, int x, int y, AnotherVec2 dir, float speed, char c)
    {
        m_fBbLife = life;
        m_vBbPos.x = x;
        m_vBbPos.y = y;
        m_vBbDir = dir;
        m_fBbSpeed = speed;
        m_cBbRender = c;
    }

    override public void Update(float a_fDelta)
    {
        RenderClear();

        m_fBbLife -= a_fDelta;
        m_vBbPos += (m_vBbDir * m_fBbSpeed * a_fDelta);
    }

	override public void RenderClear()
    {
        if (Util.ConsoleBoundaryCheck(m_vBbPos) == false) { return; }

        Console.SetCursorPosition((int)m_vBbPos.x, (int)m_vBbPos.y);
        Console.Write(' ');
    }

	override public void Render()
    {     
        if (Util.ConsoleBoundaryCheck(m_vBbPos) == false) { return; }

        Console.SetCursorPosition((int)m_vBbPos.x, (int)m_vBbPos.y);
        Console.Write(m_cBbRender);
    }
}
