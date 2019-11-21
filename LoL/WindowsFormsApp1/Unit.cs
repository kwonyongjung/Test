using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Unit
    {
        public virtual int Job_1 { get { return 0; } }
		public virtual int Job_2 { get { return 0; } }
	}
	class ChamAatrox : Unit
	{
		public int Sword = 0;
		public override int Job_1 { get { return Sword; } }
	}
	class ChamMasterYi : Unit
	{
		public int Sword = 0;
		public int Mystery = 6;

		public override int Job_1 { get { return Sword; } }
		public override int Job_2 { get { return Mystery; } }
	}
	class ChamSivir : Unit
	{
		public int sword = 0;
		public override int Job_1 { get { return sword; } }
	}
	class ChamYasuo : Unit
	{
		public int sword = 0;
		public override int Job_1 { get { return sword; } }
	}
	class ChamRenekton : Unit
	{
		public int Warrior = 1;
		public override int Job_1 { get { return Warrior; } }
	}
	class ChamVolibear : Unit
	{
		public int Warrior = 1;
		public override int Job_1 { get { return Warrior; } }
	}
	class ChamDrMundo : Unit
	{
		public int Warrior = 1;
		public override int Job_1 { get { return Warrior; } }
	}
	class ChamSion : Unit
	{
		public int Warrior = 1;
		public override int Job_1 { get { return Warrior; } }
	}
	class ChamOlaf : Unit
	{
		public int Warrior = 1;
		public override int Job_1 { get { return Warrior; } }
	}
	class ChamIvern : Unit
	{
		public int Plant = 2;
		public override int Job_1 { get { return Plant; } }
	}
	class ChamMaokai : Unit
	{
		public int Plant = 2;
		public override int Job_1 { get { return Plant; } }
	}
	class ChamNeeko : Unit
	{
		public int Plant = 2;
		public override int Job_1 { get { return Plant; } }
	}
	class ChamZyra : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
	}
	class ChamMalzahar : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
	}
	class ChamAzir : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
	}
	class ChamAnnie : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
	}
	class ChamYorick : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
	}
	class ChamZed : Unit
	{
		public int Summoner = 3;
		public int Assassin = 8;
		public override int Job_1 { get { return Summoner; } }
		public override int Job_2 { get { return Assassin; } }
	}
	class ChamVladimir : Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
	}
	class ChamTaliyah : Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
	}
	class ChamLeBlanc : Unit
	{
		public int Magician = 4;
		public int Assassin = 8;
		public override int Job_1 { get { return Magician; } }
		public override int Job_2 { get { return Assassin; } }
	}
	class ChamSyndra : Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
	}
	class ChamVeigar: Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
	}
	class ChamBrand : Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
	}
	class ChamSinged : Unit
	{
		public int Alchemy = 5;
		public override int Job_1 { get { return Alchemy; } }
	}
	class ChamSoraka : Unit
	{
		public int Mystery = 6;
		public override int Job_1 { get { return Mystery; } }
	}
	class ChamJanna : Unit
	{
		public int Mystery = 6;
		public override int Job_1 { get { return Mystery; } }
	}
	class ChamNami : Unit
	{
		public int Mystery = 6;
		public override int Job_1 { get { return Mystery; } }
	}
	class ChamLux : Unit
	{
		public int Avatar = 7;
		public override int Job_1 { get { return Avatar; } }
	}
	class ChamDiana : Unit
	{
		public int Assassin = 8;
		public override int Job_1 { get { return Assassin; } }
	}
	class ChamNocturne : Unit
	{
		public int Assassin = 8;
		public override int Job_1 { get { return Assassin; } }
	}
	class ChamQiyana : Unit
	{
		public int Assassin = 8;
		public override int Job_1 { get { return Assassin; } }
	}
	class ChamKhazix : Unit
	{
		public int Assassin = 8;
		public override int Job_1 { get { return Assassin; } }
	}
	class ChamWarwick : Unit
	{
		public int Gluttony = 9;
		public override int Job_1 { get { return Gluttony; } }
	}
	class ChamKogMaw : Unit
	{
		public int Gluttony = 9;
		public override int Job_1 { get { return Gluttony; } }
	}
	class ChamRekSai : Unit
	{
		public int Gluttony = 9;
		public override int Job_1 { get { return Gluttony; } }
	}
	class ChamSkarner : Unit
	{
		public int Gluttony = 9;
		public override int Job_1 { get { return Gluttony; } }
	}

}
