using System;

class UI
{
	static public int m_nClearScore;                 //OutClear에게 Score를 넘겨주기 위한 변수

	static public void Render()
	{
		int[,] ar = new int[7, 7]
		{
			{0, 0, 0, 1, 0, 0, 0 },
			{0, 0, 0, 1, 0, 0, 0 },
			{2, 1, 1, 1, 1, 1, 3 },
			{0, 0, 0, 1, 0, 0, 0 },
			{0, 0, 0, 1, 0, 0, 0 },
			{0, 0, 0, 1, 0, 0, 0 },
			{0, 2, 1, 1, 1, 3, 0 }
		};

		for (int i = 0; i < 60; i++)
		{
			Console.SetCursorPosition(80, i);
			Console.WriteLine("□");
		}

		for (int i = 0; i < 7; i++)
		{
			Console.SetCursorPosition(93, 5 + i);
			for (int j = 0; j < 7; j++)
			{
				switch (ar[i, j])
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
		}

		Console.SetCursorPosition(94, 29);
		Console.WriteLine("CLEAR LIST");

		Clear.IClearList();
	}
	static public void Score(int a_nScore)
	{
		m_nClearScore = a_nScore;

		Console.SetCursorPosition(93, 20);
		Console.WriteLine(" S C O R E: " + m_nClearScore);
	}
	static public void Life(int a_nLife)
	{
		int n_nLife = a_nLife;

		Console.SetCursorPosition(93, 15);
		Console.Write("L I F E : ");

		for (int i = 1; i <= n_nLife; i++)
		{
			Console.Write("◆");
		}
		Console.Write("\n");
	}
}

