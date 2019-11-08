using System;

class Monster
{
    private string[] m_sMRender1 = new string[2]
    {
         "■■■",
         "  ▼  "
    };
    private string[] m_sMRender2 = new string[2]
    {
         "□★□",
         "  ▽  "
    };
    private string[] m_sMRender3 = new string[2]
    {
         "○〓○",
         "  ▼  "
    };
    private string[] m_sMnullRender = new string[2]
      {
          "      ",
          "      "
    };

    private int m_nSelect;

    private float m_fMSpeed;
    public float m_fMLife;

    public AnotherVec2 m_vMPos;
    public AnotherVec2 m_vMDir;

    public bool bIsDie => (m_fMLife <= 0);

    public void Init(int select, float life, int x, int y, AnotherVec2 dir, float speed)
    {
        m_nSelect = select;
        m_fMLife = life;
        m_vMPos.x = x;
        m_vMPos.y = y;
        m_vMDir = dir;
        m_fMSpeed = speed;
    }

    public void Update(float a_fDelta)
    {
        RenderClear();

        m_fMLife -= a_fDelta;
        m_vMPos += (m_vMDir * m_fMSpeed * a_fDelta);
    }

    public void RenderClear()
    {
        if (Util.ConsoleBoundaryCheck(m_vMPos) == false)
        {
            return;
        }

        for (int i = 0; i < m_sMnullRender.Length; i++)
        {
            Console.SetCursorPosition((int)m_vMPos.x, (int)m_vMPos.y + i);
            Console.Write(m_sMnullRender[i]);
        }
    }

    public void Render()
    {
        if (Util.ConsoleBoundaryCheck(m_vMPos) == false)
        {
            return;
        }

        for (int i = 0; i < m_sMRender1.Length; i++)
        {
            Console.SetCursorPosition((int)m_vMPos.x, (int)m_vMPos.y + i);
            if (m_nSelect == 0)
            {
                Console.Write(m_sMRender1[i]);
            }

            else if (m_nSelect == 1)
            {
                Console.Write(m_sMRender2[i]);
            }

            else
            {
                Console.Write(m_sMRender3[i]);
            }
        }
    }
}