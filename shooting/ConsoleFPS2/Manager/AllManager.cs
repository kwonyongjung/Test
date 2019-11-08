using System;
using System.Collections.Generic;
//이름 요약
//Bm 보스 몬스터
//M 몬스터
//Bb 보스 총알
//B 총알
//p 플레이어

class AllManager
{
	public int m_nScore = 0;				//스코어
	public int BmLife = 150;				//보스 라이프

	private float m_fPlayerX;
	private float m_fPlayerY;

	public float m_fBpPosX;			     	//bullet가 플레이어의 위치에 맞게 발사를 만들기 위한 변수
	public float m_fBpPosY;

	private const int nMAKE_DEFAULT_COUNT = 30;

	static public int PLife = 3;			//플레이어 라이프를 UI에서 사용하기 위해 Static 사용

	Clear clear = new Clear();
	Player player = null;
    
	#region SINGLETON

	static AllManager Instance = null;

	static public void CraeteInstance(int a_nAllMaked)
	{
		if (Instance == null)
		{
			Instance = new AllManager(a_nAllMaked);
		}
	}

	static public AllManager Get()
	{
		return Instance;
	}

	AllManager(int a_nAllMaked)
	{
		BMake(a_nAllMaked);
		BbMake(a_nAllMaked);
		MMake(a_nAllMaked);
		BmMake(a_nAllMaked);
	}

	#endregion SINGLETON
    //오브젝트 풀=> 총알, 보스총알, 몬스터, 보스몬스터
	public void BMake(int a_nMakedBullet)
	{
		for (int i = 0; i < a_nMakedBullet; ++i)
		{
			BliPool.Add(new Bullet());
		}
	}

	public void BbMake(int a_nMakedBullet)
	{
		for (int i = 0; i < a_nMakedBullet; ++i)
		{
			BbliPool.Add(new BossBullet());
		}
	}

	public void MMake(int a_nMakedBullet)
	{
		for (int i = 0; i < a_nMakedBullet; ++i)
		{
			MliPool.Add(new Monster());
		}
	}

	public void BmMake(int a_nMakedBullet)
	{
		for (int i = 0; i < a_nMakedBullet; ++i)
		{
			BossliPool.Add(new BossMonster());
		}
	}

	public void PlayerClass()
	{
		player = new Player(35, 50);
	}

	public void BulletClass(AnotherVec2 a_vcPos, AnotherVec2 a_vcDir, float a_fSpeed, char c)
	{
		if (BliPool.Count == 0)
		{
			BMake(nMAKE_DEFAULT_COUNT);
		}

		Bullet bullet = BliPool[BliPool.Count - 1];

		BliPool.RemoveAt(BliPool.Count - 1);

		bullet.Init(1.5F, a_vcPos, a_vcDir, a_fSpeed, c);
		BliActive.Add(bullet);
	}

	public void BossBulletClass(AnotherVec2 a_vcDir, float a_fSpeed, char c)
	{
		Random BbRandom = new Random();

		int nBbPosX = BbRandom.Next(10, 65);

		if (BliPool.Count == 0)
		{
			BbMake(nMAKE_DEFAULT_COUNT);
		}

		BossBullet Bbullet = BbliPool[BbliPool.Count - 1];

		BbliPool.RemoveAt(BbliPool.Count - 1);

		Bbullet.Init(4.0F, nBbPosX, 15, a_vcDir, a_fSpeed, c);
		BbliActive.Add(Bbullet);
	}

	public void MonsterClass(AnotherVec2 a_vcDir, float a_fSpeed)
	{
		
		Random MRandom = new Random();                  
		int nMPosX = MRandom.Next(4, 70);               //몬스터 X좌표 랜덤
        int nMmake = MRandom.Next(0, 3);                //몬스터 종류 랜덤

        if (MliPool.Count == 0)
		{
			MMake(nMAKE_DEFAULT_COUNT);
		}

		Monster monster = MliPool[MliPool.Count - 1];

		MliPool.RemoveAt(MliPool.Count - 1);

		monster.Init(nMmake,6.0F, nMPosX, 0, a_vcDir, a_fSpeed);
		MliActive.Add(monster);
	}

	public void BossClass(AnotherVec2 a_vcDir, float a_fSpeed)
	{
		if (BossliPool.Count == 0)
		{
			BmMake(nMAKE_DEFAULT_COUNT);
		}

		BossMonster Bossmonster = BossliPool[BossliPool.Count - 1];

		BossliPool.RemoveAt(BossliPool.Count - 1);

		Bossmonster.Init(6.0F, 10, 0, a_vcDir, a_fSpeed);
		BossliActive.Add(Bossmonster);
	}

    //MainScene 키 좌표-> 플레이어 좌표 입력
	public void PosChange(ref int a_PosX, ref int a_PosY)
	{
		m_fPlayerX = a_PosX;
		m_fPlayerY = a_PosY;
	}

	public void BulletUpdate(float a_fDelta)
	{
		BliTemp.Clear();

		foreach (var val in BliActive)
		{
			val.Update(a_fDelta);
			if (val.bIsDie == true)
			{
				val.RenderClear();
				BliTemp.Add(val);
			}
		}

		foreach (var val in BliTemp)
		{
			BliActive.Remove(val);
			BliPool.Add(val);
		}

		BliTemp.Clear();
	}

	public void BossBulletUpdate(float a_fDelta)
	{
		BbliTemp.Clear();

		foreach (var val in BbliActive)
		{
			val.Update(a_fDelta);
			if (val.bIsDie == true)
			{
				val.RenderClear();
				BbliTemp.Add(val);
			}
		}

		foreach (var val in BbliTemp)
		{
			BbliActive.Remove(val);
			BbliPool.Add(val);
		}

		BbliTemp.Clear();
	}

	public void MonsterUpdate(float a_fDelta)
	{
		MliTemp.Clear();

		foreach (var val in MliActive)
		{
			val.Update(a_fDelta);
			foreach (var Bval in BliActive)
			{
				//몬스터와 플레이어 총알 충돌
				//범위 값 이유: rect()의 한쪽 부분을 생각하면 됨
				if ((int)val.m_vMPos.x >= (int)Bval.m_vBPos.x - 4
					&& (int)val.m_vMPos.x <= (int)Bval.m_vBPos.x + 4
					&& (int)val.m_vMPos.y >= (int)Bval.m_vBPos.y - 3
					&& (int)val.m_vMPos.y <= (int)Bval.m_vBPos.y + 3)
				{
					val.m_fMLife = 0;
					Bval.m_fBLife = 0;
					m_nScore += 10;
				}
			}

			if (val.bIsDie == true)
			{
				val.RenderClear();
				MliTemp.Add(val);
			}
		}

		foreach (var val in MliTemp)
		{
			MliActive.Remove(val);
			MliPool.Add(val);
		}
		MliTemp.Clear();
	}

	public void PUpdate()
	{
		player.m_vPos.x += m_fPlayerX;
		player.m_vPos.y += m_fPlayerY;

		//x값 제한
		if (player.m_vPos.x >= (int)ConsoleLimitXY.max_x)
		{
			player.m_vPos.x = (int)ConsoleLimitXY.max_x;
		}
		else if (player.m_vPos.x <= (int)ConsoleLimitXY.min_x)
		{
			player.m_vPos.x = (int)ConsoleLimitXY.min_x;
		}

		//y값 제한
		if (player.m_vPos.y >= (int)ConsoleLimitXY.max_y)
		{
			player.m_vPos.y = (int)ConsoleLimitXY.max_y;
		}
		else if (player.m_vPos.x <= (int)ConsoleLimitXY.min_y)
		{
			player.m_vPos.x = (int)ConsoleLimitXY.min_y;
		}

		m_fBpPosX = player.m_vPos.x;
		m_fBpPosY = player.m_vPos.y;

		foreach (var val in MliActive)
		{
			//몬스터와 플레이어 충돌부분
			if ((int)player.m_vPos.x >= (int)val.m_vMPos.x - 10
				&& (int)player.m_vPos.x <= (int)val.m_vMPos.x + 6
				&& (int)player.m_vPos.y >= (int)val.m_vMPos.y - 3
				&& (int)player.m_vPos.y <= (int)val.m_vMPos.y)
			{
				val.m_fMLife = 0;
				PLife--;

				Console.Clear();

				if (PLife <= 0)
				{

					clear.DRender();
				}
			}
		}

		foreach (var val in BbliActive)
		{
			//플레이어와 보스 총알 충돌부분
			if ((int)player.m_vPos.x >= (int)val.m_vBbPos.x - 10
				&& (int)player.m_vPos.x <= (int)val.m_vBbPos.x
				&& (int)player.m_vPos.y >= (int)val.m_vBbPos.y - 3
				&& (int)player.m_vPos.y <= (int)val.m_vBbPos.y)
			{
				val.m_fBbLife = 0;
				PLife--;

				Console.Clear();
				if (PLife <= 0)
				{
					clear.DRender();
				}
			}
		}
	}

	public void Boss_Update(float a_fDelta)
	{
		BossliTemp.Clear();
		foreach (var val in BossliActive)
		{

			val.Update(a_fDelta);

			foreach (var b_val in BliActive)
			{
				//보스와 플레이어 총알 충돌부분
				if ((int)val.m_vBmPos.x <= (int)b_val.m_vBPos.x
					&& (int)val.m_vBmPos.x + 56 >= (int)b_val.m_vBPos.x
					&& (int)val.m_vBmPos.y + 7 >= (int)b_val.m_vBPos.y)
				{
					BmLife--;
					b_val.m_fBLife = 0;

					if (BmLife < 0)
					{
						val.m_fBmLife = 0;
						BmLife = 0;

						Console.Clear();
						clear.CRender();
					}
				}
			}

			if (val.bIsDie == true)
			{
				val.RenderClear();
				BossliTemp.Add(val);
			}
		}

		foreach (var val in BossliTemp)
		{
			BossliActive.Remove(val);
			BossliPool.Add(val);
		}

		BossliTemp.Clear();
	}

	public void b_Render()
	{
		foreach (var val in BliActive)
		{
			val.Render();
		}
	}

	public void Bb_Render()
	{
		foreach (var val in BbliActive)
		{
			val.Render();
		}
	}

	public void m_Render()
	{
		foreach (var val in MliActive)
		{
			val.Render();
		}
	}

	public void Boss_Render()
	{
		foreach (var val in BossliActive)
		{
			val.Render();
		}
	}

	public void p_Render()
	{
		player.Render();
	}

	List<Bullet> BliTemp = new List<Bullet>();
	List<Bullet> BliPool = new List<Bullet>();
	List<Bullet> BliActive = new List<Bullet>();

	List<BossBullet> BbliTemp = new List<BossBullet>();
	List<BossBullet> BbliPool = new List<BossBullet>();
	List<BossBullet> BbliActive = new List<BossBullet>();

	List<Monster> MliTemp = new List<Monster>();
	List<Monster> MliPool = new List<Monster>();
	List<Monster> MliActive = new List<Monster>();

	List<BossMonster> BossliTemp = new List<BossMonster>();
	List<BossMonster> BossliPool = new List<BossMonster>();
	List<BossMonster> BossliActive = new List<BossMonster>();
}
