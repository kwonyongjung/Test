using System;
using System.Windows.Input;

enum eScene
{
    Main,
    Select,
	Player
}

enum eKey
{
    Up = Key.Up,
    Down = Key.Down,

    Right = Key.Right,
    Left = Key.Left,

    Space = Key.Space,
	
    Max = 1,
}

[Flags]
enum eKeyState
{
    Unpress = 0b00,
    Down = 0b11,
    Press = 0b01,
    Up = 0b10,
}

//위치 제한
enum ConsoleLimitXY
{
    max_x = 65, //플레이어 위치 제한
    max_y = 50,

    min_x = 0,
    min_y = 0,  ///////////////////

    BmPos_y=5,  //보스몬스터 Y 고정 
}
//몬스터, 보스몬스터 생성 시간
enum Time
{
    Mlimit = 3,
    Bmlimit = 7,
}
enum Make
{
	make = 30,
}
static class Util
{
	static public bool ConsoleBoundaryCheck(Vec2 v)
	{
		return !(
			(v.x < 0 || v.x > Console.WindowWidth) ||
			(v.y < 0 || v.y > Console.WindowHeight));
	}

	static public bool ConsoleBoundaryCheck(AnotherVec2 v)
	{
		return !(
			(v.x < 0 || v.x > Console.WindowWidth) ||
			(v.y < 0 || v.y > Console.WindowHeight));
	}
}

