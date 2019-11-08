using System;

struct Vec2 //플레이어를 위한 Vec
{
	public float x;
	public float y;

	public Vec2(float _x, float _y)
	{
		x = _x; y = _y;
	}
	public static Vec2 operator -(Vec2 a, Vec2 b)
	{
		return new Vec2(a.x, a.y - b.y);
	}
	public static Vec2 operator *(Vec2 a, float b)
	{
		return new Vec2(a.x * b, a.y * b);
	}
}

struct AnotherVec2 //플레이어를 제외한 나머지 Vec
{
	public float x;
	public float y;

	public AnotherVec2(float _x, float _y)
	{
		x = _x; y = _y;
	}
	public static AnotherVec2 operator +(AnotherVec2 a, AnotherVec2 b)
	{
		return new AnotherVec2(a.x, a.y + b.y);
	}
	public static AnotherVec2 operator -(AnotherVec2 a, AnotherVec2 b)
	{
		return new AnotherVec2(a.x, a.y - b.y);
	}
	public static AnotherVec2 operator *(AnotherVec2 a, float b)
	{
		return new AnotherVec2(a.x * b, a.y * b);
	}
}

class GameFPS
{
	public static float GetTargetFPS()
	{
		const float nTarget = 30;
		return 10000 * 1000 / nTarget;
	}

	public static void Open()
	{
		SceneManager.CraeteInstance();
		SceneManager sceneMng = SceneManager.Get();
		DateTime Old = DateTime.Now;

		long FPS = 0;
		long TargetFPS = (long)GetTargetFPS();

		while (true)
		{
			long Temp = (DateTime.Now - Old).Ticks;

			Old = DateTime.Now;
			FPS += Temp;

			if (FPS > TargetFPS)
			{
				sceneMng.Update(FPS / (float)(10000 * 1000));
				sceneMng.Render();

				FPS -= TargetFPS;
			}
		}
	}
}

