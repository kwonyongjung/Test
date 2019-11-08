using System;

class MainScene : Scene
{	
	private int m_nColor = 0;               //보스몬스터 총알과 플레이어 총알의 색 
							 
	private int m_nMake = 1;                //플레이어 생성 제한 

	private float m_MFps;                   //몬스터 생성속도
	private float m_BmFPS;                  //보스 몬스터 생성 횟수 제한 및 속도

	override public void Update(float a_fDelta)
    {
		float n_fMTimelimit;

		int n_nPosX = 0;                    //플레이어 위치 x
		int n_nPosY = 0;                    //플레이어 위치 y 

		if (m_nMake == 1)
		{
			AllManager.Get().PlayerClass();

			m_nMake = 0;
		}

		AllManager.Get().BulletUpdate(a_fDelta);
        AllManager.Get().Boss_Update(a_fDelta);
        AllManager.Get().MonsterUpdate(a_fDelta);
        AllManager.Get().BossBulletUpdate(a_fDelta);
		AllManager.Get().PUpdate(a_fDelta);

		if (eKey.Space.IsKeyDown() == true)
		{
			if (AllManager.Get().m_fBpPosX < 0)
			{
				AllManager.Get().m_fBpPosX = 0;
			}

			AllManager.Get().BulletClass(
				new AnotherVec2(AllManager.Get().m_fBpPosX + 6, AllManager.Get().m_fBpPosY - 1),
				new AnotherVec2(2, 2),
				20f, 'o');
		}

		if (eKey.Left.IsKeyDown() == true)
		{
			n_nPosX--;
		}
		else if (eKey.Right.IsKeyDown() == true)
		{
			n_nPosX++;
		}

		if (eKey.Up.IsKeyDown() == true)
		{
			n_nPosY--;
		}

		else if (eKey.Down.IsKeyDown() == true)
		{
			n_nPosY++;
		}

		//생성 속도를 0.MTimelimit마다 생성하게 함
		n_fMTimelimit = (int)Time.Mlimit * (float)0.1;

		if (m_MFps >= n_fMTimelimit)
        {
            if (m_BmFPS != -1)
            {
                AllManager.Get().MonsterClass(
                  new AnotherVec2(2, 2),
                  5f);
            }

			// 보스가 나올 시점부터는 몬스터가 아닌 보스 몬스터의 총알로 바꿀수 있게 지정함
			else
			{				
                AllManager.Get().BossBulletClass(
                    new AnotherVec2(1, 2),
                    10f, 'm');
            }

            m_MFps = 0; //일정한 생성 속도
        }
		//보스 생성속도를 Bmlimit마다 생성하게 함
		if (m_BmFPS > (int)Time.Bmlimit)	
        {
			AllManager.Get().BossClass(
			   new AnotherVec2(2, 2),
			   5f);
            m_BmFPS = -1; //한마리 제한

       }
        
       AllManager.Get().PosChange(ref n_nPosX,ref n_nPosY); //현재 x,y를 AllManager 클래스로 넘겨준다.

        n_nPosX = 0;
        n_nPosY = 0;
        m_MFps += a_fDelta;
       
		if (m_BmFPS != -1)
		{
            m_BmFPS += a_fDelta;
		}      
    }

	override public void Render()
	{		
		if (m_nColor == 1)
		{
			Console.ForegroundColor = ConsoleColor.Red;
		}

		else if (m_nColor == 2)
		{
			Console.ForegroundColor = ConsoleColor.Green;
		}

		else
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			m_nColor = 0;
		}

		//색 변경
		m_nColor++;
		AllManager.Get().Bb_Render();
		AllManager.Get().b_Render();

		Console.ForegroundColor = ConsoleColor.White;		
		AllManager.Get().p_Render();
		AllManager.Get().m_Render();
		AllManager.Get().Boss_Render();
	}
}
