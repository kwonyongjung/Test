using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
class Clear
{
	Ending ending = new Ending();

	public void CRender()
	{
		ending.ClearEnding();
		int[,] n_ClearArr = new int[7, 18]
		{
		   {0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,0,0,0,0},
		   {0, 1, 1, 0, 1, 0, 1,1,1,0, 0,1,0,0,1,1,0,0},
		   {1, 0, 0, 0, 1, 0, 1,0,0,0,1,0,1,0,1,0,1,0},
		   {1, 0, 0, 0, 1, 0, 1,1,1,0,1,1,1,0,1,1,0,0},
		   {1, 0, 0, 0, 1, 0, 1,0,0,0,1,0,1,0,1,0,1,0},
		   { 0, 1, 1, 0, 1, 0, 1,1,1,0,1,0,1,0,1,0,1,0},
		   {0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0,0,0,0,0,0},
		};

		for (int i = 0; i < 7; i++)
		{
			Console.SetCursorPosition(5, 5 + i);
			for (int j = 0; j < 18; j++)
			{
				switch (n_ClearArr[i, j])
				{
					case 0:
						Console.Write("  ");
						break;
					case 1:
						Console.Write("■");
						break;
				}

			}
		}

		Console.SetCursorPosition(4, 15);
		Console.Write("닉네임을 등록 하시겠습니까?	 Y=1/N=0");

		while (true)
		{
			Console.SetCursorPosition(45, 15);
			var cki = Console.ReadKey();

			if (cki.Key == ConsoleKey.Y)
			{
				Console.SetCursorPosition(4, 18);
				Console.WriteLine("CLEAR Nick Name : ");
				Console.SetCursorPosition(4, 20);
				Console.WriteLine("※6글자만 출력됨");
				Console.SetCursorPosition(4, 21);
				Console.WriteLine("바로 엔터 시 ???출력");

				Console.SetCursorPosition(21, 18);
				Console.CursorVisible = true;
				OClear_List();
				break;
			}

			else if (cki.Key == ConsoleKey.N)
			{
				break;
			}
		}

		Console.SetCursorPosition(21, 25);
		Console.WriteLine("  ");
		Environment.Exit(0);
	}

	public void DRender()
	{
		ending.DieEnding();

		int[,] n_nDieArr = new int[7, 9]
		{
		   {0,0,0,0,0,0,0,0,0},
		   {1,1,0,0,1,0,1,1,1},
		   {1,0,1,0,1,0,1,0,0},
		   {1,0,1,0,1,0,1,1,1},
		   {1,0,1,0,1,0,1,0,0},
		   {1,1,0,0,1,0,1,1,1},
		   {0,0,0,0,0,0,0,0,0},
		};

		for (int i = 0; i < 7; i++)
		{
			Console.SetCursorPosition(5, 5 + i);
			for (int j = 0; j < 9; j++)
			{
				switch (n_nDieArr[i, j])
				{
					case 0:
						Console.Write("  ");
						break;
					case 1:
						Console.Write("■");
						break;
				}
			}
		}

		Console.WriteLine("  ");
		Environment.Exit(0);
	}

	static public void IClearList()
	{
		FileInfo fileInfo = new FileInfo(@"../../ClearList.txt");

		//Text가 없으면 오류
		if (fileInfo.Exists==false)
		{
			Debug.Assert(false);
		}

		string[] InputClear = File.ReadAllLines(@"../../ClearList.txt");
		
		List<int> nCSceor = new List<int>();				//내림차순 변경
		List<string> sCName = new List<string>();			//스코어 변경시 이름도 변경

		int n_nTemp;
		string n_sTemp = string.Empty;
		
		//각각 리스트에 추가
		for (int i = 0; i < InputClear.Length; i++)
		{
			string[] t = InputClear[i].Split(' ');
			sCName.Add(t[0]);
			nCSceor.Add(Convert.ToInt32(t[1]));

		}
		
		//순위 변경
		for (int i = 0; i < InputClear.Length; i++)
		{
			for (int j = 0; j < InputClear.Length; j++)
			{
				if (nCSceor[i] > nCSceor[j])
				{
					n_nTemp = nCSceor[i];
					nCSceor[i] = nCSceor[j];
					nCSceor[j] = n_nTemp;
					n_sTemp = sCName[i];
					sCName[i] = sCName[j];
					sCName[j] = n_sTemp;
				}
			}
		}

		for (int i = 0; i < InputClear.Length; i++)
		{
			Console.SetCursorPosition(93, 30 + i);
			Console.WriteLine(sCName[i] + " " + nCSceor[i]);
		}
	}

	public void OClear_List()
	{
		const int n_nLengthLimit = 6;						//콘솔 창 크기, 글자 수 제한
		int n_nOutScore = UI.m_nClearScore;
		string n_sOutputClear;								//원래 문자열
		string n_sReOutputClear;							//변환 후 문자열
		char[] n_cChange;									//변환을 하기 위해 만든 문자배열

		n_sOutputClear = Console.ReadLine();

		if (n_sOutputClear == "")
		{
			n_sOutputClear = "???";
		}		
        
		n_cChange = n_sOutputClear.ToCharArray();           //글자의 제한, 공백을 변경하기 위해 캐스팅

		//글자 수를 6으로 고정
		if (n_sOutputClear.Length > n_nLengthLimit)
		{
			Array.Resize(ref n_cChange, n_nLengthLimit);
		}

		//IClearList()에서 공백을 Split로 나누기 때문에 공백을 점으로 변경
		for (int i = 0; i < n_cChange.Length; i++)
		{
			if (n_cChange[i].Equals(' '))
			{
				//for (int j = i + 1; j < n_cChange.Length; j++)
				//{
				//	n_cChange[i] = n_cChange[j];
				//}
				n_cChange[i] = '.';
			}
		}

		n_sReOutputClear = new String(n_cChange);

		using (StreamWriter outputFile = new StreamWriter(@"../../ClearList.txt", true))
		{
			outputFile.WriteLine(n_sReOutputClear + " " + n_nOutScore);
			outputFile.Dispose();
		}
	}
}

