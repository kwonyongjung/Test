using System;

class SelectScene : Scene
{
    private int m_nChoicePosY = 30; //선택 화살표의 y값
    public void Run()
    {
        while (true)
        {
            Render();

            var Key = Console.ReadKey();
            eKey n_TileY = eKey.Max;

            if (Key.Key == ConsoleKey.UpArrow)
            {
                n_TileY = eKey.Up;
            }

            else if (Key.Key == ConsoleKey.DownArrow)
            {
                n_TileY = eKey.Down;
            }

            else if (Key.Key == ConsoleKey.Spacebar)
            {
                n_TileY = eKey.Space;
            }

            Update(n_TileY);
        }
    }

    public void Update(eKey p_Temp)
    {
        Console.Clear();

        switch (p_Temp)
        {
            case eKey.Up:
                m_nChoicePosY = 30;
                break;
            case eKey.Down:
                m_nChoicePosY = 32;
                break;

            //Spacebar로 선택
            //선택 후 m_nChoicePosY값이 30이면 다음 씬으로 넘어가고
            //아닐 경우 종료
            case eKey.Space:
                if (m_nChoicePosY == 30)
                {
                    Console.Clear();
					PlayerScene player = new PlayerScene();
					player.Run();

					break;
                }
                else if (m_nChoicePosY == 32)
                {
                    Environment.Exit(0);
                }
                break;
        }
    }

    public override void Render()
    {
        int[,] TileArr = new int[17, 17]
        {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,2,1,1,1,1,1,3,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,2,1,1,1,3,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},

        };

        for (int i = 0; i < 17; i++)
        {
            Console.SetCursorPosition(40, 10 + i);
            for (int j = 0; j < 17; j++)
            {
                switch (TileArr[i, j])
                {
                    case 0:
                        Console.Write("  ");
                        break;
                    case 1:
                        Console.Write("■");
                        break;
                    case 2:
                        Console.Write("◀");
                        break;
                    case 3:
                        Console.Write("▶");
                        break;
                }

            }
            Console.Write("\n");
        }
		Console.SetCursorPosition(0, 0);
		Console.WriteLine("이동 : 방향키");
		Console.WriteLine("※ 한번 누르고 다시 한번 꾹 눌러야 이동가능\n");
		Console.WriteLine("공격 : Spaceber");
		Console.SetCursorPosition(55, 30);
        Console.WriteLine("Start");
        Console.SetCursorPosition(56, 32);
        Console.WriteLine("End");
        Console.SetCursorPosition(62, m_nChoicePosY);
        Console.Write("◀");
    }
}

