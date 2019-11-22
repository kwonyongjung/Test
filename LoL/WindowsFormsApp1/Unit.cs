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
        public virtual int Element { get { return 0; } }
        public virtual int Element2 { get { return 0; } }
        public virtual int Element3 { get { return 0; } }
        public virtual int Element4 { get { return 0; } }
    }
	class ChamAatrox : Unit
	{
		public int Sword = 0;
		public override int Job_1 { get { return Sword; } }
        public int Light = 3;
        public override int Element { get { return Light; } }
    }
	class ChamMasterYi : Unit
	{
		public int Sword = 0;
		public int Mystery = 6;

		public override int Job_1 { get { return Sword; } }
		public override int Job_2 { get { return Mystery; } }
		public int Shadow = 9;
		public override int Element { get { return Shadow; } }
	}
	class ChamSivir : Unit
	{
		public int sword = 0;
		public override int Job_1 { get { return sword; } }
		public int Desert = 11;
		public override int Element { get { return Desert; } }
	}
	class ChamYasuo : Unit
	{
		public int sword = 0;      
        public override int Job_1 { get { return sword; } }
        public int Wind = 2;
        public override int Element { get { return Wind; } }
    }
	class ChamRenekton : Unit
	{
		public int Warrior = 1;
		public override int Job_1 { get { return Warrior; } }
		public int Desert = 11;
		public override int Element { get { return Desert; } }
	}
	class ChamVolibear : Unit
	{
		public int Warrior = 1;
		public override int Job_1 { get { return Warrior; } }
        public int Electric = 5;
        public int Glacial = 8;
        public override int Element { get { return Electric; } }
        public override int Element2 { get { return Glacial; } }
    }
	class ChamDrMundo : Unit
	{
		public int Warrior = 1;
        public int Poison = 1;    
        public override int Element { get { return Poison; } }
        public override int Job_1 { get { return Warrior; } }
	}
	class ChamSion : Unit
	{
		public int Warrior = 1;
		public override int Job_1 { get { return Warrior; } }
		public int Shadow = 9;
		public override int Element { get { return Shadow; } }
	}
	class ChamOlaf : Unit
	{
		public int Warrior = 1;
		public override int Job_1 { get { return Warrior; } }
		public int Glacial = 8;
		public override int Element { get { return Glacial; } }
	}
	class ChamIvern : Unit
	{
		public int Plant = 2;
		public override int Job_1 { get { return Plant; } }
		public int Forest = 10;
		public override int Element { get { return Forest; } }	
	}
    class ChamJax : Unit
    {

        public int Warrior = 1;
        public override int Job_1 { get { return Warrior; } }
        public int Light = 3;
        public override int Element { get { return Light; } }
    }
    class ChamMaokai : Unit
	{
		public int Plant = 2;
		public override int Job_1 { get { return Plant; } }
		public int Forest = 10;
		public override int Element { get { return Forest; } }
	}
	class ChamNeeko : Unit
	{
		public int Plant = 2;
		public override int Job_1 { get { return Plant; } }
		public int Forest = 10;
		public override int Element { get { return Forest; } }
}
	class ChamZyra : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
		public int Inferno = 12;
		public override int Element { get { return Inferno; } }
	}
	class ChamMalzahar : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
		public int Shadow = 9;
		public override int Element { get { return Shadow; } }
	}
	class ChamAzir : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
		public int Desert = 11;
		public override int Element { get { return Desert; } }
	}
	class ChamAnnie : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
		public int Inferno = 12;
		public override int Element { get { return Inferno; } }
	}
	class ChamYorick : Unit
	{
		public int Summoner = 3;
		public override int Job_1 { get { return Summoner; } }
        public int Light = 3;
        public override int Element { get { return Light; } }
    }
	class ChamZed : Unit
	{
		public int Summoner = 3;
		public int Assassin = 8;
		public override int Job_1 { get { return Summoner; } }
		public override int Job_2 { get { return Assassin; } }
        public int Electric = 5;
        public override int Element { get { return Electric; } }
    }
	class ChamVladimir : Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
		public int Ocean = 7;
		public override int Element { get { return Ocean; } }

	}
	class ChamTaliyah : Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
		public int Mountain = 6;
		public override int Element { get { return Mountain; } }
	}
	class ChamLeBlanc : Unit
	{
		public int Magician = 4;
		public int Assassin = 8;
		public override int Job_1 { get { return Magician; } }
		public override int Job_2 { get { return Assassin; } }
		public int Forest = 10;
		public override int Element { get { return Forest; } }
	}
	class ChamSyndra : Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
		public int Ocean = 7;
		public override int Element { get { return Ocean; } }
	}
	class ChamVeigar: Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
		public int Shadow = 9;
		public override int Element { get { return Shadow; } }
	}
	class ChamBrand : Unit
	{
		public int Magician = 4;
		public override int Job_1 { get { return Magician; } }
		public int Inferno = 12;
		public override int Element { get { return Inferno; } }
	}
	class ChamSinged : Unit
	{
		public int Alchemy = 5;
		public override int Job_1 { get { return Alchemy; } }
        public int Poison = 1;
        public override int Element { get { return Poison; } }
    }
	class ChamSoraka : Unit
	{
		public int Mystery = 6;
		public override int Job_1 { get { return Mystery; } }
        public int Light = 3;
        public override int Element { get { return Light; } }
    }
	class ChamJanna : Unit
	{
		public int Mystery = 6;
		public override int Job_1 { get { return Mystery; } }
        public int Wind = 2;
        public override int Element { get { return Wind; } }
    }
	class ChamNami : Unit
	{
		public int Mystery = 6;
		public override int Job_1 { get { return Mystery; } }
		public int Ocean = 7;
		public override int Element { get { return Ocean; } }
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
		public int Inferno = 12;
		public override int Element { get { return Inferno; } }
	}
	class ChamNocturne : Unit
	{
		public int Assassin = 8;
		public int Steel = 0;
		public override int Job_1 { get { return Assassin; } }
        public override int Element { get { return Steel; } }
    }
	class ChamQiyana : Unit
	{
		public int Assassin = 8;
		public override int Job_1 { get { return Assassin; } }
        public int Wind = 2;
        public int Mountain = 6;
        public int Ocean = 7;
        public int Inferno = 12;
		
		public override int Element { get { return Wind; } }
		public override int Element2 { get { return Mountain; } }
		public override int Element3 { get { return Ocean; } }
		public override int Element4 { get { return Inferno; } }
    }
	class ChamKhazix : Unit
	{
		public int Assassin = 8;
		public override int Job_1 { get { return Assassin; } }
		public int Desert = 11;
		public override int Element { get { return Desert; } }
	}
	class ChamWarwick : Unit
	{
		public int Gluttony = 9;
		public override int Job_1 { get { return Gluttony; } }
		public int Glacial = 8;
		public override int Element { get { return Glacial; } }

	}
	class ChamKogMaw : Unit
	{
		public int Gluttony = 9;		
		public override int Job_1 { get { return Gluttony; } }
        public int Poison = 1;
        public override int Element { get { return Poison; } }
    }
	class ChamRekSai : Unit
	{
		public int Gluttony = 9;
		public int Steel = 0;
		public override int Job_1 { get { return Gluttony; } }
		public override int Element { get { return Steel; } }
	}
	class ChamSkarner : Unit
	{
		public int Gluttony = 9;
		public override int Job_1 { get { return Gluttony; } }
        public int Crystal = 4;
        public override int Element { get { return Crystal; } }
    }
    class ChamVayne : Unit
    {
        public int Recon = 10;
        public override int Job_1 { get { return Recon; } }
        public int Light = 3;
        public override int Element { get { return Light; } }
    }
    class ChamVarus : Unit
    {
        public int Recon = 10;
        public override int Job_1 { get { return Recon; } }
		public int Inferno = 12;
		public override int Element { get { return Inferno; } }
	}
    class ChamEzreal : Unit
    {
        public int Recon = 10;
        public override int Job_1 { get { return Recon; } }
		public int Glacial = 8;
		public override int Element { get { return Glacial; } }
	}
    class ChamKindred : Unit
    {
        public int Recon = 10;
        public override int Job_1 { get { return Recon; } }
		public int Shadow = 9;
		public int Inferno = 12;
		public override int Element { get { return Shadow; } }
		public override int Element2 { get { return Inferno; } }
	}
    class ChamAshe : Unit
    {
        public int Recon = 10;
        public override int Job_1 { get { return Recon; } }
        public int Crystal = 4;
        public override int Element { get { return Crystal; } }
    }
    class chamTwitch : Unit
    {
        public int Recon = 10;
        public override int Job_1 { get { return Recon; } }
        public int Poison = 1;
        public override int Element { get { return Poison; } }
    }
    class ChamNasus : Unit
    {
        public int Warden = 11;
        public override int Job_1 { get { return Warden; } }
        public int Light= 3;
        public override int Element { get { return Light; } }
    }
    class ChamOrnn : Unit
    {
        public int Warden = 11;
        public override int Job_1 { get { return Warden; } }
        public int Electric = 5;
        public override int Element { get { return Electric; } }
    }
    class ChamBraum : Unit
    {        
        public int Warden = 11;
        public override int Job_1 { get { return Warden; } }
		public int Glacial = 8;
		public override int Element { get { return Glacial; } }
	}
    class ChamThresh : Unit
    {
        public int Warden = 11;
        public override int Job_1 { get { return Warden; } }
		public int Ocean = 7;
		public override int Element { get { return Ocean; } }
	}
    class ChamNautilus : Unit
    {
        public int Warden = 11;
        public override int Job_1 { get { return Warden; } }
		public int Ocean = 7;
		public override int Element { get { return Ocean; } }
	}
    class ChamMalphite : Unit
    {
        public int Warden = 11;
        public override int Job_1 { get { return Warden; } }
		public int Mountain = 6;
		public override int Element { get { return Mountain; } }
	}
    class ChamTaric : Unit
    {
        public int Warden = 11;
        public override int Job_1 { get { return Warden; } }
        public int Crystal = 4;
        public override int Element { get { return Crystal; } }
    }


}
