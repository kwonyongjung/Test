using System;

	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.CursorVisible = false;			 //커서 지우기
			Console.SetWindowSize(126, 63);
			SelectScene select = new SelectScene();
			select.Run();
		}
	}


