using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		ChamSivir chamSivir = new ChamSivir();
		ChamYasuo chamYasuo = new ChamYasuo();
		ChamAatrox chamAatrox = new ChamAatrox();
		ChamMasterYi chamMasterYi = new ChamMasterYi();
		ChamRenekton chamRenekton = new ChamRenekton();
		ChamVolibear chamVolibear = new ChamVolibear();
		ChamDrMundo chamDrMundo = new ChamDrMundo();
		ChamSion chamSion = new ChamSion();
		ChamJax chamJax = new ChamJax();
		ChamOlaf chamOlaf = new ChamOlaf();
		ChamIvern chamIvern = new ChamIvern();
		ChamMaokai chamMaokai = new ChamMaokai();
		ChamNeeko chamNeeko = new ChamNeeko();
		ChamZyra chamZyra = new ChamZyra();
		ChamMalzahar chamMalzahar = new ChamMalzahar();
		ChamAzir chamAzir = new ChamAzir();
		ChamAnnie chamAnnie = new ChamAnnie();
		ChamYorick chamYorick = new ChamYorick();
		ChamZed chamZed = new ChamZed();
		ChamVladimir chamVladimir = new ChamVladimir();
		ChamTaliyah chamTaliyah = new ChamTaliyah();
		ChamLeBlanc chamLeBlanc = new ChamLeBlanc();
		ChamSyndra chamSyndra = new ChamSyndra();
		ChamVeigar chamVeigar = new ChamVeigar();
		ChamBrand chamBrand = new ChamBrand();
		ChamSinged chamSinged = new ChamSinged();
		ChamSoraka chamSoraka = new ChamSoraka();
		ChamJanna chamJanna = new ChamJanna();
		ChamNami chamNami = new ChamNami();
		ChamLux chamLux = new ChamLux();
		ChamDiana chamDiana = new ChamDiana();
		ChamNocturne chamNocturne = new ChamNocturne();
		ChamQiyana chamQiyana = new ChamQiyana();
		ChamKhazix chamKhazix = new ChamKhazix();
		ChamWarwick chamWarwick = new ChamWarwick();
		ChamKogMaw chamKogMaw = new ChamKogMaw();
		ChamRekSai chamRekSai = new ChamRekSai();
		ChamSkarner chamSkarner = new ChamSkarner();
		ChamVayne chamVayne = new ChamVayne();
		ChamVarus chamVarus = new ChamVarus();
		ChamEzreal chamEzreal = new ChamEzreal();
		ChamKindred chamKindred = new ChamKindred();
		ChamAshe chamAshe = new ChamAshe();
		chamTwitch chamTwitch = new chamTwitch();
		ChamNasus chamNasus = new ChamNasus();
		ChamOrnn chamOrnn = new ChamOrnn();
		ChamBraum chamBraum = new ChamBraum();
		ChamThresh chamThresh = new ChamThresh();
		ChamNautilus chamNautilus = new ChamNautilus();
		ChamMalphite chamMalphite = new ChamMalphite();
		ChamTaric chamTaric = new ChamTaric();


		Dictionary<int, PictureBox> m_dlist = new Dictionary<int, PictureBox>();
		int[] m_arrSet = new int[20] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
		int[] m_arrChampionNumber = new int[50]
		{
			9, 9, 9, 9, 9, 9, 9, 9, 9,9,
			9, 9, 9, 9, 9, 9, 9, 9, 9,9,
			9, 9, 9, 9, 9, 9, 9, 9, 9,9,
			9, 9, 9, 9, 9, 9, 9, 9, 9,9,
			9, 9, 9, 9, 9, 9, 9, 9, 9,9
		};
		int m_nIndex = 0;
		int m_nSeti = 0;
		Dictionary<int, string> m_dicJobName = new Dictionary<int, string>();
		Dictionary<int, string> m_dicElementName = new Dictionary<int, string>();
		Dictionary<int, int> m_dicJobCount = new Dictionary<int, int>();

		List<int> m_liJobCount = new List<int>();
		List<int> m_liElemenCount = new List<int>();
		public Form1()
		{
			InitializeComponent();
			m_dicJobName[0] = "검사";
			m_liJobCount.Add(0);
			m_dicJobName[1] = "광전사";
			m_liJobCount.Add(0);
			m_dicJobName[2] = "드루이드";
			m_liJobCount.Add(0);
			m_dicJobName[3] = "소환사";
			m_liJobCount.Add(0);
			m_dicJobName[4] = "요술사";
			m_liJobCount.Add(0);
			m_dicJobName[5] = "연굼술사";
			m_liJobCount.Add(0);
			m_dicJobName[6] = "신비술사";
			m_liJobCount.Add(0);
			m_dicJobName[7] = "아바타";
			m_liJobCount.Add(0);
			m_dicJobName[8] = "암살자";
			m_liJobCount.Add(0);
			m_dicJobName[9] = "포식자";
			m_liJobCount.Add(0);
			m_dicJobName[10] = "정찰대";
			m_liJobCount.Add(0);
			m_dicJobName[11] = "파수꾼";
			m_liJobCount.Add(0);
			m_dicElementName[0] = "강철";
			m_liElemenCount.Add(0);
			m_dicElementName[1] = "맹독";
			m_liElemenCount.Add(0);
			m_dicElementName[2] = "바람";
			m_liElemenCount.Add(0);
			m_dicElementName[3] = "빛";
			m_liElemenCount.Add(0);
			m_dicElementName[4] = "수정";
			m_liElemenCount.Add(0);
			m_dicElementName[5] = "전기";
			m_liElemenCount.Add(0);
			m_dicElementName[6] = "대지";
			m_liElemenCount.Add(0);
			m_dicElementName[7] = "바다";
			m_liElemenCount.Add(0);
			m_dicElementName[8] = "빙하";
			m_liElemenCount.Add(0);
			m_dicElementName[9] = "그림자";
			m_liElemenCount.Add(0);
			m_dicElementName[10] = "숲";
			m_liElemenCount.Add(0);
			m_dicElementName[11] = "사막";
			m_liElemenCount.Add(0);
			m_dicElementName[12] = "지옥불";
			m_liElemenCount.Add(0);

		}
		public int Range(int count)
		{
			int k = 0;
			switch (count)
			{
				case 0:
					k = 1150;
					break;
				case 1:
					k = 1200;
					break;
				case 2:
					k = 1250;
					break;
				case 3:
					k = 1300;
					break;
				case 4:
					k = 1350;
					break;
				case 5:
					k = 1400;
					break;
				case 6:
					k = 1450;
					break;
				case 7:
					k = 1500;
					break;
				case 8:
					k = 1550;
					break;
			}
			return k;
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void Runing(PictureBox champion, int num, int ChampionPos_x, int ChampionPos_y, Unit Cham)
		{
			int sum = 0;
			if (champion.Left < 1100)
			{
				if (m_dlist.Count < 9)
				{					
					m_liJobCount[Cham.Job_1]++;
					m_liElemenCount[Cham.Element]++;
					for (int i = 0; i < 20; i++)
					{
						if (m_arrSet[i] != 9)
						{
							m_nIndex = m_arrSet[i];
							m_arrSet[i] = 9;
							break;
						}
					}//순차등록
					if (sum == 0)
					{
						m_dlist[m_nIndex] = champion;
						m_dlist[m_nIndex].Left = Range(m_nIndex);
						m_dlist[m_nIndex].Top = 88;
						m_arrChampionNumber[num] = m_nIndex;
						sum++;
						m_nIndex++;
					}
				}
			}
			else
			{
				m_liJobCount[Cham.Job_1]--;				
				m_liElemenCount[Cham.Element]--;
				sum = 0;
				m_dlist.Remove(m_arrChampionNumber[num]);
				m_arrSet[m_nSeti] = m_arrChampionNumber[num];
				m_nSeti++;
				if (m_nSeti >= 9)
				{
					m_nSeti = 0;
				}
				champion.Top = ChampionPos_x;
				champion.Left = ChampionPos_y;
			}
			switch (Cham.Element)
			{
				case 0:
					SteeldBox(Cham.Element);
					break;
				case 1:
					PoisonBox(Cham.Element);
					break;
				case 2:
					WindBox(Cham.Element);
					break;
				case 3:
					LightBox(Cham.Element);
					break;
				case 4:
					CrystalBox(Cham.Element);
					break;
				case 5:
					ElectricBox(Cham.Element);
					break;
				case 6:
					MountainBox(Cham.Element);
					break;
				case 7:
					OceanBox(Cham.Element);
					break;
				case 8:
					GlacialBox(Cham.Element);
					break;
				case 9:
					ShadowBox(Cham.Element);
					break;
				case 10:
					ForestBox(Cham.Element);
					break;
				case 11:
					DesertBox(Cham.Element);
					break;
				case 12:
					InfernoBox(Cham.Element);
					break;
			}
			switch (Cham.Job_1)
			{
				case 0:
					SwordBox(Cham.Job_1);
					break;
				case 1:
					WarriorBox(Cham.Job_1);
					break;
				case 2:
					PlantBox(Cham.Job_1);
					break;
				case 3:
					SummonerBox(Cham.Job_1);
					break;
				case 4:
					MagicianBox(Cham.Job_1);
					break;
				case 5:
					AlchemyBox(Cham.Job_1);
					break;
				case 6:
					MysteryBox(Cham.Job_1);
					break;
				case 7:
					AvatarBox(Cham.Job_1);
					break;
				case 8:
					AssassinBox(Cham.Job_1);
					break;
				case 9:
					GluttonyBox(Cham.Job_1);
					break;
				case 10:
					ReconBox(Cham.Job_1);
					break;
				case 11:
					WardenBox(Cham.Job_1);
					break;
			}
		}
		private void DualRuning(PictureBox champion, int num, int ChampionPos_x, int ChampionPos_y, Unit Cham)
		{
			int sum = 0;
			if (champion.Left < 1100)
			{
				if (m_dlist.Count < 9)
				{
					m_liJobCount[Cham.Job_1]++;
					m_liJobCount[Cham.Job_2]++;
					m_liElemenCount[Cham.Element]++;
					for (int i = 0; i < 10; i++)
					{
						if (m_arrSet[i] != 9)
						{
							m_nIndex = m_arrSet[i];
							m_arrSet[i] = 9;
							break;
						}
					}//순차등록
					if (sum == 0)
					{
						m_dlist[m_nIndex] = champion;
						m_dlist[m_nIndex].Left = Range(m_nIndex);
						m_dlist[m_nIndex].Top = 88;
						m_arrChampionNumber[num] = m_nIndex;
						sum++;
						m_nIndex++;
					}
				}
			}
			else
			{
				m_liJobCount[Cham.Job_1]--;
				m_liJobCount[Cham.Job_2]--;
				m_liElemenCount[Cham.Element]--;
				sum = 0;
				m_dlist.Remove(m_arrChampionNumber[num]);
				m_arrSet[m_nSeti] = m_arrChampionNumber[num];
				m_nSeti++;
				if (m_nSeti >= 9)
				{
					m_nSeti = 0;
				}
				champion.Top = ChampionPos_x;
				champion.Left = ChampionPos_y;
			}
			switch (Cham.Element)
			{
				case 5:
					ElectricBox(Cham.Element);
					break;
				case 9:
					ShadowBox(Cham.Element);
					break;
				case 10:
					ForestBox(Cham.Element);
					break;
			}
			switch (Cham.Job_1)
			{
				case 0:
					SwordBox(Cham.Job_1);
					MysteryBox(Cham.Job_2);
					break;
				case 1:
					WarriorBox(Cham.Job_1);
					break;
				case 2:
					PlantBox(Cham.Job_1);
					break;
				case 3:
					SummonerBox(Cham.Job_1);
					AssassinBox(Cham.Job_2);
					break;
				case 4:
					MagicianBox(Cham.Job_1);
					AssassinBox(Cham.Job_2);
					break;
				case 5:
					AlchemyBox(Cham.Job_1);
					break;
			}
		}
		private void TwoRuning(PictureBox champion, int num, int ChampionPos_x, int ChampionPos_y, Unit Cham)
		{
			int sum = 0;
			if (champion.Left < 1100)
			{
				if (m_dlist.Count < 9)
				{
					m_liJobCount[Cham.Job_1]++;
					m_liElemenCount[Cham.Element]++;
					m_liElemenCount[Cham.Element2]++;
					for (int i = 0; i < 10; i++)
					{
						if (m_arrSet[i] != 9)
						{
							m_nIndex = m_arrSet[i];
							m_arrSet[i] = 9;
							break;
						}
					}//순차등록
					if (sum == 0)
					{
						m_dlist[m_nIndex] = champion;
						m_dlist[m_nIndex].Left = Range(m_nIndex);
						m_dlist[m_nIndex].Top = 88;
						m_arrChampionNumber[num] = m_nIndex;
						sum++;
						m_nIndex++;
					}
				}
			}
			else
			{
				m_liJobCount[Cham.Job_1]--;
				m_liElemenCount[Cham.Element]--;
				sum = 0;
				m_dlist.Remove(m_arrChampionNumber[num]);
				m_arrSet[m_nSeti] = m_arrChampionNumber[num];
				m_nSeti++;
				if (m_nSeti >= 9)
				{
					m_nSeti = 0;
				}
				champion.Top = ChampionPos_x;
				champion.Left = ChampionPos_y;
			}
			switch (Cham.Element)
			{

				case 5:
					ElectricBox(Cham.Element);
					GlacialBox(Cham.Element2);
					break;
			}
			switch (Cham.Job_1)
			{
				case 1:
					WarriorBox(Cham.Job_1);
					break;
				case 10:
					ReconBox(Cham.Job_1);
					break;
			}
		}
		private void FourRuning(PictureBox champion, int num, int ChampionPos_x, int ChampionPos_y, Unit Cham)
		{
			int sum = 0;
			if (champion.Left < 1100)
			{
				if (m_dlist.Count < 9)
				{
					m_liJobCount[Cham.Job_1]++;
					m_liElemenCount[Cham.Element]++;
					m_liElemenCount[Cham.Element2]++;
					m_liElemenCount[Cham.Element3]++;
					m_liElemenCount[Cham.Element4]++;
					for (int i = 0; i < 10; i++)
					{
						if (m_arrSet[i] != 9)
						{
							m_nIndex = m_arrSet[i];
							m_arrSet[i] = 9;
							break;
						}
					}//순차등록
					if (sum == 0)
					{
						m_dlist[m_nIndex] = champion;
						m_dlist[m_nIndex].Left = Range(m_nIndex);
						m_dlist[m_nIndex].Top = 88;
						m_arrChampionNumber[num] = m_nIndex;
						sum++;
						m_nIndex++;
					}
				}
			}
			else
			{
				m_liJobCount[Cham.Job_1]--;
				m_liElemenCount[Cham.Element]--;
				m_liElemenCount[Cham.Element2]--;
				m_liElemenCount[Cham.Element3]--;
				m_liElemenCount[Cham.Element4]--;
				sum = 0;
				m_dlist.Remove(m_arrChampionNumber[num]);
				m_arrSet[m_nSeti] = m_arrChampionNumber[num];
				m_nSeti++;
				if (m_nSeti >= 9)
				{
					m_nSeti = 0;
				}
				champion.Top = ChampionPos_x;
				champion.Left = ChampionPos_y;
			}

			WindBox(Cham.Element);
			MountainBox(Cham.Element2);
			OceanBox(Cham.Element3);
			InfernoBox(Cham.Element4);
			AssassinBox(Cham.Job_1);




		}
	#region 야스오
		private void Yasuo_Click(object sender, EventArgs e)
		{
			Runing(Yasuo, 0, 88, 54, chamYasuo);
			if (Yasuo.Left > 1000)
			{
				pictureBox11.Visible = false;
			}
			else
			{
				pictureBox11.Visible = true;
			}
		}
		private void pictureBox11_Click(object sender, EventArgs e)
		{
			Runing(pictureBox11, 0, 273, 504, chamYasuo);
			if (pictureBox11.Left > 1000)
			{
				Yasuo.Visible = false;
			}
			else
			{
				Yasuo.Visible = true;
			}
		}
		#endregion 야스오

		#region 아트록스
		private void Aatrox_Click(object sender, EventArgs e)
		{
			Runing(Aatrox, 1, 88, 91, chamAatrox);
			if (Aatrox.Left > 1000)
			{
				pictureBox18.Visible = false;
			}
			else
			{
				pictureBox18.Visible = true;
			}
		}
		private void pictureBox18_Click(object sender, EventArgs e)
		{
			Runing(pictureBox18, 1, 399, 502, chamAatrox);
			if (pictureBox18.Left > 1000)
			{
				Aatrox.Visible = false;
			}
			else
			{
				Aatrox.Visible = true;
			}
		}
		#endregion 아트록스

		#region 시비르
		private void Sivir_Click(object sender, EventArgs e)
		{
			Runing(Sivir, 2, 88, 128, chamSivir);
			if (Sivir.Left > 1000)
			{
				pictureBox56.Visible = false;
			}
			else
			{
				pictureBox56.Visible = true;
			}
		}
		private void pictureBox56_Click(object sender, EventArgs e)
		{
			Runing(pictureBox56, 2, 618, 795, chamSivir);
			if (pictureBox56.Left > 1000)
			{
				Sivir.Visible = false;
			}
			else
			{
				Sivir.Visible = true;
			}
		}

		#endregion 시비르

		#region 마스터 이
		private void MasterYi_1_Click(object sender, EventArgs e)
		{
			DualRuning(MasterYi_1, 3, 88, 167, chamMasterYi);
			if (MasterYi_1.Left > 1000)
			{
				MasterYi_2.Visible = false;
			}
			else
			{
				MasterYi_2.Visible = true;
			}
			if (MasterYi_1.Left > 1000)
			{
				pictureBox45.Visible = false;
			}
			else
			{
				pictureBox45.Visible = true;
			}
		}
		private void MasterYi_2_Click(object sender, EventArgs e)
		{

			DualRuning(MasterYi_2, 3, 88, 395, chamMasterYi);
			if (MasterYi_2.Left > 1000)
			{
				MasterYi_1.Visible = false;
			}
			else
			{
				MasterYi_1.Visible = true;
			}
			if (MasterYi_2.Left > 1000)
			{
				pictureBox45.Visible = false;
			}
			else
			{
				pictureBox45.Visible = true;
			}

		}
		private void pictureBox45_Click(object sender, EventArgs e)
		{
			DualRuning(pictureBox45, 18, 430, 758, chamMasterYi);
			if (pictureBox45.Left > 1000)
			{
				MasterYi_1.Visible = false;
			}
			else
			{
				MasterYi_1.Visible = true;
			}
			if (pictureBox45.Left > 1000)
			{
				MasterYi_2.Visible = false;
			}
			else
			{
				MasterYi_2.Visible = true;
			}
		}
		#endregion 마스터 이

		#region 레넥톤
		private void Renekton_Click(object sender, EventArgs e)
		{
			Runing(Renekton, 4, 174, 54, chamRenekton);
			if (Renekton.Left > 1000)
			{
				pictureBox57.Visible = false;
			}
			else
			{
				pictureBox57.Visible = true;
			}
		}
		private void pictureBox57_Click(object sender, EventArgs e)
		{
			Runing(pictureBox57, 4, 618, 722, chamRenekton);
			if (pictureBox57.Left > 1000)
			{
				Renekton.Visible = false;
			}
			else
			{
				Renekton.Visible = true;
			}
		}
		#endregion 레넥톤

		#region 볼베
		private void Volibear_Click(object sender, EventArgs e)
		{
			TwoRuning(Volibear, 5, 174, 91, chamVolibear);
			if (Volibear.Left > 1000)
			{
				pictureBox26.Visible = false;
			}
			else
			{
				pictureBox26.Visible = true;
			}
			if (Volibear.Left > 1000)
			{
				pictureBox42.Visible = false;
			}
			else
			{
				pictureBox42.Visible = true;
			}
		}
		private void pictureBox26_Click(object sender, EventArgs e)
		{
			TwoRuning(pictureBox26, 5, 580, 534, chamVolibear);
			if (pictureBox26.Left > 1000)
			{
				Volibear.Visible = false;
			}
			else
			{
				Volibear.Visible = true;
			}
			if (pictureBox26.Left > 1000)
			{
				pictureBox42.Visible = false;
			}
			else
			{
				pictureBox42.Visible = true;
			}
		}
		private void pictureBox42_Click(object sender, EventArgs e)
		{
			TwoRuning(pictureBox42, 5, 288, 758, chamVolibear);
			if (pictureBox42.Left > 1000)
			{
				Volibear.Visible = false;
			}
			else
			{
				Volibear.Visible = true;
			}
			if (pictureBox42.Left > 1000)
			{
				pictureBox26.Visible = false;
			}
			else
			{
				pictureBox26.Visible = true;
			}
		}
		#endregion 볼베

		#region 잭스
		private void Jax_Click(object sender, EventArgs e)
		{
			Runing(Jax, 6, 174, 128, chamJax);
			if (Jax.Left > 1000)
			{
				pictureBox17.Visible = false;
			}
			else
			{
				pictureBox17.Visible = true;
			}
		}
		private void pictureBox17_Click(object sender, EventArgs e)
		{
			Runing(pictureBox17, 6, 358, 572, chamJax);
			if (pictureBox17.Left > 1000)
			{
				Jax.Visible = false;
			}
			else
			{
				Jax.Visible = true;
			}
		}
		#endregion 잭스

		#region 문도
		private void DrMundo_Click(object sender, EventArgs e)
		{
			Runing(DrMundo, 7, 174, 167, chamDrMundo);
			if (DrMundo.Left > 1000)
			{
				pictureBox7.Visible = false;
			}
			else
			{
				pictureBox7.Visible = true;
			}
		}
		private void pictureBox7_Click(object sender, EventArgs e)
		{
			Runing(pictureBox7, 7, 541, 170, chamDrMundo);
			if (pictureBox7.Left > 1000)

			{
				DrMundo.Visible = false;
			}
			else
			{
				DrMundo.Visible = true;
			}
		}
		#endregion 문도

		#region 사이온
		private void Sion_Click(object sender, EventArgs e)
		{
			Runing(Sion, 8, 210, 91, chamSion);
			if (Sion.Left > 1000)
			{
				pictureBox48.Visible = false;
			}
			else
			{
				pictureBox48.Visible = true;
			}
		}
		private void pictureBox48_Click(object sender, EventArgs e)
		{
			Runing(pictureBox48, 8, 399, 795, chamSion);
			if (pictureBox48.Left > 1000)
			{
				Sion.Visible = false;
			}
			else
			{
				Sion.Visible = true;
			}
		}
		#endregion 사이온

		#region 올라프
		private void Olaf_Click(object sender, EventArgs e)
		{
			Runing(Olaf, 9, 210, 128, chamOlaf);
			if (Olaf.Left > 1000)
			{
				pictureBox41.Visible = false;
			}
			else
			{
				pictureBox41.Visible = true;
			}
		}
		private void pictureBox41_Click(object sender, EventArgs e)
		{
			Runing(pictureBox41, 9, 322, 759, chamOlaf);
			if (pictureBox41.Left > 1000)
			{
				Olaf.Visible = false;
			}
			else
			{
				Olaf.Visible = true;
			}
		}
		#endregion 올라프

		#region 아이번
		private void Ivern_Click(object sender, EventArgs e)
		{
			Runing(Ivern, 10, 290, 68, chamIvern);
			if (Ivern.Left > 1000)
			{
				pictureBox53.Visible = false;
			}
			else
			{
				pictureBox53.Visible = true;
			}
		}

		private void pictureBox53_Click(object sender, EventArgs e)
		{
			Runing(pictureBox53, 10, 508, 722, chamIvern);
			if (pictureBox53.Left > 1000)
			{
				Ivern.Visible = false;
			}
			else
			{
				Ivern.Visible = true;
			}
		}
		#endregion 아이번

		#region 마오카이
		private void Maokai_Click(object sender, EventArgs e)
		{
			Runing(Maokai, 11, 290, 110, chamMaokai);
			if (Maokai.Left > 1000)
			{
				pictureBox52.Visible = false;
			}
			else
			{
				pictureBox52.Visible = true;
			}
		}

		private void pictureBox52_Click(object sender, EventArgs e)
		{
			Runing(pictureBox52, 11, 508, 764, chamMaokai);
			if (pictureBox52.Left > 1000)
			{
				Maokai.Visible = false;
			}
			else
			{
				Maokai.Visible = true;
			}
		}
		#endregion 마오카이

		#region 니코
		private void Neeko_Click(object sender, EventArgs e)
		{
			Runing(Neeko, 12, 290, 151, chamNeeko);
			if (Neeko.Left > 1000)
			{
				pictureBox51.Visible = false;
			}
			else
			{
				pictureBox51.Visible = true;
			}
		}

		private void pictureBox51_Click(object sender, EventArgs e)
		{
			Runing(pictureBox51, 12, 508, 806, chamNeeko);
			if (pictureBox51.Left > 1000)
			{
				Neeko.Visible = false;
			}
			else
			{
				Neeko.Visible = true;
			}
		}
		#endregion 니코

		#region 자이라
		private void Zyra_Click(object sender, EventArgs e)
		{
			Runing(Zyra, 13, 371, 53, chamZyra);
			if (Zyra.Left > 1000)
			{
				pictureBox64.Visible = false;
			}
			else
			{
				pictureBox64.Visible = true;
			}
		}
		private void pictureBox64_Click(object sender, EventArgs e)
		{
			Runing(pictureBox64, 13, 99, 959, chamZyra);
			if (pictureBox64.Left > 1000)
			{
				Zyra.Visible = false;
			}
			else
			{
				Zyra.Visible = true;
			}
		}
		#endregion 자이라

		#region 말자하
		private void Malzahar_Click(object sender, EventArgs e)
		{
			Runing(Malzahar, 14, 371, 91, chamMalzahar);
			if (Malzahar.Left > 1000)
			{
				pictureBox47.Visible = false;
			}
			else
			{
				pictureBox47.Visible = true;
			}
		}
		private void pictureBox47_Click(object sender, EventArgs e)
		{
			Runing(pictureBox47, 14, 399, 722, chamMalzahar);
			if (pictureBox47.Left > 1000)
			{
				Malzahar.Visible = false;
			}
			else
			{
				Malzahar.Visible = true;
			}
		}
		#endregion 말자하

		#region 아지르
		private void Azir_Click(object sender, EventArgs e)
		{
			Runing(Azir, 15, 371, 128, chamAzir);
			if (Azir.Left > 1000)
			{
				pictureBox55.Visible = false;
			}
			else
			{
				pictureBox55.Visible = true;
			}
		}
		private void pictureBox55_Click(object sender, EventArgs e)
		{
			Runing(pictureBox55, 15, 618, 758, chamAzir);
			if (pictureBox55.Left > 1000)
			{
				Azir.Visible = false;
			}
			else
			{
				Azir.Visible = true;
			}
		}

		#endregion 아지르

		#region 애니
		private void Annie_Click(object sender, EventArgs e)
		{
			Runing(Annie, 16, 371, 167, chamAnnie);
			if (Annie.Left > 1000)
			{
				pictureBox65.Visible = false;
			}
			else
			{
				pictureBox65.Visible = true;
			}
		}
		private void pictureBox65_Click(object sender, EventArgs e)
		{
			Runing(pictureBox65, 16, 140, 959, chamAnnie);
			if (pictureBox65.Left > 1000)
			{
				Annie.Visible = false;
			}
			else
			{
				Annie.Visible = true;
			}
		}
		#endregion 애니

		#region 요릭
		private void Yorick_Click(object sender, EventArgs e)
		{
			Runing(Yorick, 17, 412, 91, chamYorick);
			if (Yorick.Left > 1000)
			{
				pictureBox16.Visible = false;
			}
			else
			{
				pictureBox16.Visible = true;
			}
		}
		private void pictureBox16_Click(object sender, EventArgs e)
		{
			Runing(pictureBox16, 17, 399, 539, chamYorick);
			if (pictureBox16.Left > 1000)
			{
				Yorick.Visible = false;
			}
			else
			{
				Yorick.Visible = true;
			}
		}
		#endregion 요릭

		#region 제드
		private void Zed_1_Click(object sender, EventArgs e)
		{
			DualRuning(Zed_1, 18, 412, 128, chamZed);
			if (Zed_1.Left > 1000)
			{
				Zed_2.Visible = false;
			}
			else
			{
				Zed_2.Visible = true;
			}
			if (Zed_1.Left > 1000)
			{
				pictureBox25.Visible = false;
			}
			else
			{
				pictureBox25.Visible = true;
			}
		}

		private void Zed_2_Click(object sender, EventArgs e)
		{
			DualRuning(Zed_2, 18, 289, 355, chamZed);
			if (Zed_2.Left > 1000)
			{
				Zed_1.Visible = false;
			}
			else
			{
				Zed_1.Visible = true;
			}
			if (Zed_2.Left > 1000)
			{
				pictureBox25.Visible = false;
			}
			else
			{
				pictureBox25.Visible = true;
			}

		}

		private void pictureBox25_Click(object sender, EventArgs e)
		{
			DualRuning(pictureBox25, 18, 580, 571, chamZed);
			if (pictureBox25.Left > 1000)
			{
				Zed_1.Visible = false;
			}
			else
			{
				Zed_1.Visible = true;
			}
			if (pictureBox25.Left > 1000)
			{
				Zed_2.Visible = false;
			}
			else
			{
				Zed_2.Visible = true;
			}
		}
		#endregion 제드

		#region 블라디미르
		private void Vladimir_Click(object sender, EventArgs e)
		{
			Runing(Vladimir, 19, 497, 54, chamVladimir);
			if (Vladimir.Left > 1000)
			{
				pictureBox35.Visible = false;
			}
			else
			{
				pictureBox35.Visible = true;
			}

		}

		private void pictureBox35_Click(object sender, EventArgs e)
		{
			Runing(pictureBox35, 19, 162, 721, chamVladimir);
			if (Taliyah.Left > 1000)
			{
				Vladimir.Visible = false;
			}
			else
			{
				Vladimir.Visible = true;
			}
		}
		#endregion 블라디미르

		#region 탈리야
		private void Taliyah_Click(object sender, EventArgs e)
		{
			Runing(Taliyah, 20, 497, 91, chamTaliyah);
			if (Taliyah.Left > 1000)
			{
				pictureBox29.Visible = false;
			}
			else
			{
				pictureBox29.Visible = true;
			}
		}
		private void pictureBox29_Click(object sender, EventArgs e)
		{
			Runing(pictureBox29, 20, 88, 722, chamTaliyah);
			if (pictureBox29.Left > 1000)
			{
				Taliyah.Visible = false;
			}
			else
			{
				Taliyah.Visible = true;
			}
		}
		#endregion 탈리야

		#region 르블랑
		private void LeBlanc_2_Click(object sender, EventArgs e)
		{
			DualRuning(LeBlanc_2, 21, 497, 128, chamLeBlanc);
			if (LeBlanc_2.Left > 1000)
			{
				LeBlanc_1.Visible = false;
			}
			else
			{
				LeBlanc_1.Visible = true;
			}
			if (LeBlanc_2.Left > 1000)
			{
				pictureBox50.Visible = false;
			}
			else
			{
				pictureBox50.Visible = true;
			}
		}
		private void LeBlanc_1_Click(object sender, EventArgs e)
		{
			DualRuning(LeBlanc_1, 21, 246, 318, chamLeBlanc);
			if (LeBlanc_1.Left > 1000)
			{
				LeBlanc_2.Visible = false;
			}
			else
			{
				LeBlanc_2.Visible = true;
			}
			if (LeBlanc_1.Left > 1000)
			{
				pictureBox50.Visible = false;
			}
			else
			{
				pictureBox50.Visible = true;
			}
		}
		private void pictureBox50_Click(object sender, EventArgs e)
		{
			DualRuning(pictureBox50, 21, 508, 843, chamLeBlanc);
			if (pictureBox50.Left > 1000)
			{
				LeBlanc_2.Visible = false;
			}
			else
			{
				LeBlanc_2.Visible = true;
			}
			if (pictureBox50.Left > 1000)
			{
				LeBlanc_1.Visible = false;
			}
			else
			{
				LeBlanc_1.Visible = true;
			}
		}
		#endregion 르블랑

		#region 신드라
		private void Syndra_Click(object sender, EventArgs e)
		{
			Runing(Syndra, 22, 497, 167, chamSyndra);
			if (Syndra.Left > 1000)
			{
				pictureBox36.Visible = false;
			}
			else
			{
				pictureBox36.Visible = true;
			}
		}
		private void pictureBox36_Click(object sender, EventArgs e)
		{
			Runing(pictureBox36, 22, 162, 759, chamSyndra);
			if (pictureBox36.Left > 1000)
			{
				Syndra.Visible = false;
			}
			else
			{
				Syndra.Visible = true;
			}
		}
		#endregion 신드라

		#region 베이가
		private void Veigar_Click(object sender, EventArgs e)
		{
			Runing(Veigar, 23, 535, 91, chamVeigar);
			if (Veigar.Left > 1000)
			{
				pictureBox46.Visible = false;
			}
			else
			{
				pictureBox46.Visible = true;
			}
		}
		private void pictureBox46_Click(object sender, EventArgs e)
		{
			Runing(pictureBox46, 23, 399, 758, chamVeigar);
			if (pictureBox46.Left > 1000)
			{
				Veigar.Visible = false;
			}
			else
			{
				Veigar.Visible = true;
			}
		}
		#endregion 베이가

		#region 브랜드
		private void Brand_Click(object sender, EventArgs e)
		{
			Runing(Brand, 24, 535, 133, chamBrand);
			if (Brand.Left > 1000)
			{
				pictureBox63.Visible = false;
			}
			else
			{
				pictureBox63.Visible = true;
			}
		}
		private void pictureBox63_Click(object sender, EventArgs e)
		{
			Runing(pictureBox63, 24, 140, 996, chamBrand);
			if (pictureBox63.Left > 1000)
			{
				Brand.Visible = false;
			}
			else
			{
				Brand.Visible = true;
			}
		}
		#endregion 브랜드

		#region 신지드
		private void Singed_Click(object sender, EventArgs e)
		{
			Runing(Singed, 25, 618, 101, chamSinged);
			if (Singed.Left > 1000)
			{
				pictureBox6.Visible = false;
			}
			else
			{
				pictureBox6.Visible = true;
			}
		}
		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Runing(pictureBox6, 25, 610, 170, chamSinged);
			if (pictureBox6.Left > 1000)
			{
				Singed.Visible = false;
			}
			else
			{
				Singed.Visible = true;
			}
		}
		#endregion 신지드		

		#region 소라카
		private void Soraka_Click(object sender, EventArgs e)
		{
			Runing(Soraka, 26, 88, 281, chamSoraka);
			if (Soraka.Left > 1000)
			{
				pictureBox15.Visible = false;
			}
			else
			{
				pictureBox15.Visible = true;
			}
		}
		private void pictureBox15_Click(object sender, EventArgs e)
		{
			Runing(pictureBox15, 26, 358, 608, chamSoraka);
			if (pictureBox15.Left > 1000)
			{
				Soraka.Visible = false;
			}
			else
			{
				Soraka.Visible = true;
			}
		}
		#endregion 소라카		

		#region 잔나
		private void Janna_Click(object sender, EventArgs e)
		{
			Runing(Janna, 27, 88, 318, chamJanna);
			if (Janna.Left > 1000)
			{
				pictureBox10.Visible = false;
			}
			else
			{
				pictureBox10.Visible = true;
			}
		}
		private void pictureBox10_Click(object sender, EventArgs e)
		{
			Runing(pictureBox10, 27, 273, 574,chamJanna);
			if (pictureBox10.Left > 1000)
			{
				Janna.Visible = false;
			}
			else
			{
				Janna.Visible = true;
			}
		}
		#endregion 잔나

		#region 나미
		private void Nami_Click(object sender, EventArgs e)
		{
			Runing(Nami, 28, 88, 355, chamNami);
			if (Nami.Left > 1000)
			{
				pictureBox34.Visible = false;
			}
			else
			{
				pictureBox34.Visible = true;
			}
		}
		private void pictureBox34_Click(object sender, EventArgs e)
		{
			Runing(pictureBox34, 28, 162, 796, chamNami);
			if (pictureBox34.Left > 1000)
			{
				Nami.Visible = false;
			}
			else
			{
				Nami.Visible = true;
			}
		}
		#endregion 나미

		#region 럭스
		private void Lux_Click(object sender, EventArgs e)
		{
			Runing(Lux, 29, 161, 305,chamLux);
			if (Lux.Left > 1000)
			{
				pictureBox60.Visible = false;
			}
			else
			{
				pictureBox60.Visible = true;
			}
		}
		private void pictureBox60_Click(object sender, EventArgs e)
		{

			Runing(pictureBox60, 29, 140, 1033, chamLux);
			if (pictureBox60.Left > 1100)
			{
				Lux.Visible = false;
			}
			else
			{
				Lux.Visible = true;
			}
		}
		#endregion 럭스

		#region 다이애나
		private void Diana_Click(object sender, EventArgs e)
		{
			Runing(Diana, 30, 246, 282, chamDiana);
			if (Diana.Left > 1000)
			{
				pictureBox61.Visible = false;
			}
			else
			{
				pictureBox61.Visible = true;
			}
		}
		private void pictureBox61_Click(object sender, EventArgs e)
		{
			Runing(pictureBox61, 30, 99, 922, chamDiana);
			if (pictureBox61.Left > 1000)
			{
				Diana.Visible = false;
			}
			else
			{
				Diana.Visible = true;
			}
		}
		#endregion 다이애나

		#region 녹턴
		private void Nocturne_Click(object sender, EventArgs e)
		{
			Runing(Nocturne, 31, 245, 355, chamNocturne);
			if (Nocturne.Left > 1000)
			{
				pictureBox2.Visible = false;
			}
			else
			{
				pictureBox2.Visible = true;
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Runing(pictureBox2, 31, 545, 88, chamNocturne);
			if (pictureBox2.Left > 1000)
			{
				Nocturne.Visible = false;
			}
			else
			{
				Nocturne.Visible = true;
			}
		}
		#endregion 녹턴

		#region 키아나
		private void Qiyana_Click(object sender, EventArgs e)
		{
			FourRuning(Qiyana, 32, 245, 395, chamQiyana);
			if (Qiyana.Left > 1000)
			{
				pictureBox62.Visible = false;
				pictureBox33.Visible = false;
				pictureBox9.Visible = false;
				pictureBox27.Visible = false;
			}
			else
			{
				pictureBox62.Visible = true;
				pictureBox33.Visible = true;
				pictureBox9.Visible = true;
				pictureBox27.Visible = true;
			}
		}	
		private void pictureBox62_Click(object sender, EventArgs e)
		{
			FourRuning(pictureBox62, 32, 99,996,chamQiyana);
			if (pictureBox62.Left > 1000)
			{
				Qiyana.Visible = false;
				pictureBox33.Visible = false;
				pictureBox9.Visible = false;
				pictureBox27.Visible = false;
			}
			else
			{
				Qiyana.Visible = true;
				pictureBox33.Visible = true;
				pictureBox9.Visible = true;
				pictureBox27.Visible = true;
			}
		}
		private void pictureBox27_Click(object sender, EventArgs e)
		{
			FourRuning(pictureBox27, 32, 88, 759,chamQiyana);
			if (pictureBox27.Left > 1000)
			{
				Qiyana.Visible = false;
				pictureBox33.Visible = false;
				pictureBox9.Visible = false;
				pictureBox62.Visible = false;
			}
			else
			{
				Qiyana.Visible = true;
				pictureBox33.Visible = true;
				pictureBox9.Visible = true;
				pictureBox62.Visible = true;
			}
		} 
		private void pictureBox33_Click(object sender, EventArgs e)
		{
			FourRuning(pictureBox33, 32, 159,833, chamQiyana);
			if (pictureBox33.Left > 1000)
			{
				Qiyana.Visible = false;
				pictureBox27.Visible = false;
				pictureBox9.Visible = false;
				pictureBox62.Visible = false;
			}
			else
			{
				Qiyana.Visible = true;
				pictureBox27.Visible = true;
				pictureBox9.Visible = true;
				pictureBox62.Visible = true;
			}
		}
		private void pictureBox9_Click(object sender, EventArgs e)
		{
			FourRuning(pictureBox9, 32, 273,539,chamQiyana);
			if (pictureBox9.Left > 1000)
			{
				Qiyana.Visible = false;
				pictureBox27.Visible = false;
				pictureBox33.Visible = false;
				pictureBox62.Visible = false;
			}
			else
			{
				Qiyana.Visible = true;
				pictureBox27.Visible = true;
				pictureBox33.Visible = true;
				pictureBox62.Visible = true;
			}

		}
		#endregion 키아나

		#region 카직스
		private void Khazix_Click(object sender, EventArgs e)
		{
			Runing(Khazix, 33, 288, 318, chamKhazix);
			if (Khazix.Left > 1000)
			{
				pictureBox54.Visible = false;
			}
			else
			{
				pictureBox54.Visible = true;
			}
		}
		private void pictureBox54_Click(object sender, EventArgs e)
		{
			Runing(pictureBox54, 33, 618, 832, chamKhazix);
			if (pictureBox54.Left > 1000)
			{
				Khazix.Visible = false;
			}
			else
			{
				Khazix.Visible = true;
			}
		}
		#endregion 카직스

		#region 워윅
		private void Warwick_Click(object sender, EventArgs e)
		{
			Runing(Warwick, 34, 372, 283, chamWarwick);
			if (Warwick.Left > 1000)
			{
				pictureBox39.Visible = false;
			}
			else
			{
				pictureBox39.Visible = true;
			}
		}
		private void pictureBox39_Click(object sender, EventArgs e)
		{
			Runing(pictureBox39, 34, 288, 721, chamWarwick);
			if (pictureBox39.Left > 1000)
			{
				Warwick.Visible = false;
			}
			else
			{
				Warwick.Visible = true;
			}
		}
		#endregion 워윅

		#region 코그모
		private void KogMaw_Click(object sender, EventArgs e)
		{
			Runing(KogMaw, 35, 372, 320, chamKogMaw);
			if (KogMaw.Left > 1000)
			{
				pictureBox4.Visible = false;
			}
			else
			{
				pictureBox4.Visible = true;
			}
		}
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Runing(pictureBox4, 35, 504, 170, chamKogMaw);
			if (pictureBox4.Left > 1000)
			{
				KogMaw.Visible = false;
			}
			else
			{
				KogMaw.Visible = true;
			}
		}
		#endregion 코그모

		#region 렉사이
		private void RekSai_Click(object sender, EventArgs e)
		{
			Runing(RekSai, 36, 372, 360, chamRekSai);
			if (RekSai.Left > 1000)
			{
				pictureBox1.Visible = false;
			}
			else
			{
				pictureBox1.Visible = true;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Runing(pictureBox1, 36, 88, 508, chamRekSai);
			if (pictureBox1.Left > 1000)
			{
				RekSai.Visible = false;
			}
			else
			{
				RekSai.Visible = true;
			}
		}
		#endregion 렉사이

		#region 스카너
		private void Skarner_Click(object sender, EventArgs e)
		{
			Runing(Skarner, 37, 372, 360, chamSkarner);
			if (Skarner.Left > 1000)
			{
				pictureBox20.Visible = false;
			}
			else
			{
				pictureBox20.Visible = true;
			}
		}

		private void pictureBox20_Click(object sender, EventArgs e)
		{
			Runing(pictureBox20, 37, 478, 502, chamSkarner);
			if (pictureBox20.Left > 1000)
			{
				Skarner.Visible = false;
			}
			else
			{
				Skarner.Visible = true;
			}
		}

		#endregion 스카너

		#region 베인
		private void Vayne_Click(object sender, EventArgs e)
		{
			Runing(Vayne, 38, 467, 281, chamVayne);
			if (Vayne.Left > 1000)
			{
				pictureBox13.Visible = false;
			}
			else
			{
				pictureBox13.Visible = true;
			}
		}
		private void pictureBox13_Click(object sender, EventArgs e)
		{
			Runing(pictureBox13, 38, 358, 537, chamVayne);
			if (pictureBox13.Left > 1000)
			{
				Vayne.Visible = false;
			}
			else
			{
				Vayne.Visible = true;
			}
		}
		#endregion 베인

		#region 바루스
		private void Varus_Click(object sender, EventArgs e)
		{
			Runing(Varus, 39, 467, 317, chamVarus);
			if (Varus.Left > 1000)
			{
				pictureBox58.Visible = false;
			}
			else
			{
				pictureBox58.Visible = true;
			}
		}

		private void pictureBox58_Click(object sender, EventArgs e)
		{
			Runing(pictureBox58, 39, 99, 1033, chamVarus);
			if (pictureBox58.Left > 1000)
			{
				Varus.Visible = false;
			}
			else
			{
				Varus.Visible = true;
			}
		}
		#endregion 바루스

		#region 이즈리얼
		private void Ezreal_Click(object sender, EventArgs e)
		{
			Runing(Ezreal, 40, 467, 354, chamEzreal);
			if (Ezreal.Left > 1000)
			{
				pictureBox38.Visible = false;
			}
			else
			{
				pictureBox38.Visible = true;
			}
		}
		private void pictureBox38_Click(object sender, EventArgs e)
		{
			Runing(pictureBox38, 40, 288, 832, chamEzreal);
			if (pictureBox38.Left > 1000)
			{
				Ezreal.Visible = false;
			}
			else
			{
				Ezreal.Visible = true;
			}
		}
		#endregion 이즈리얼

		#region 킨드레드
		private void Kindred_Click(object sender, EventArgs e)
		{
			TwoRuning(Kindred, 41, 467, 394, chamKindred);
			if (Kindred.Left > 1000)
			{
				pictureBox43.Visible = false;
			}
			else
			{
				pictureBox43.Visible = true;
			}
			if (Kindred.Left > 1000)
			{
				pictureBox59.Visible = false;
			}
			else
			{
				pictureBox59.Visible = true;
			}
		}

		private void pictureBox43_Click(object sender, EventArgs e)
		{
			TwoRuning(pictureBox43, 41, 399, 832, chamKindred);
			if (pictureBox43.Left > 1000)
			{
				Kindred.Visible = false;
			}
			else
			{
				Kindred.Visible = true;
			}
			if (pictureBox43.Left > 1000)
			{
				pictureBox59.Visible = false;
			}
			else
			{
				pictureBox59.Visible = true;
			}
		}

		private void pictureBox59_Click(object sender, EventArgs e)
		{
			TwoRuning(pictureBox59, 41, 140, 922,  chamKindred);
			if (pictureBox59.Left > 1000)
			{
				pictureBox43.Visible = false;
			}
			else
			{
				pictureBox43.Visible = true;
			}
			if (pictureBox59.Left > 1000)
			{
				Kindred.Visible = false;
			}
			else
			{
				Kindred.Visible = true;
			}
		}
		#endregion 킨드레드

		#region 애쉬
		private void Ashe_Click(object sender, EventArgs e)
		{
			Runing(Ashe, 42, 509, 317, chamAshe);
			if (Ashe.Left > 1000)
			{
				pictureBox19.Visible = false;
			}
			else
			{
				pictureBox19.Visible = true;
			}
		}
		private void pictureBox19_Click(object sender, EventArgs e)
		{
			Runing(pictureBox19, 42, 478, 534, chamAshe);
			if (pictureBox19.Left > 1000)
			{
				Ashe.Visible = false;
			}
			else
			{
				Ashe.Visible = true;
			}
		}
		#endregion 애쉬

		#region 트위치
		private void Twitch_Click(object sender, EventArgs e)
		{
			Runing(Twitch, 43, 509, 357, chamTwitch);
			if (Twitch.Left > 1000)
			{
				pictureBox5.Visible = false;
			}
			else
			{
				pictureBox5.Visible = true;
			}
		}
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Runing(pictureBox5, 43, 574, 170, chamTwitch);
			if (pictureBox5.Left > 1000)
			{
				Twitch.Visible = false;
			}
			else
			{
				Twitch.Visible = true;
			}
		}

		#endregion 트위치

		#region 나서스
		private void Nasus_Click(object sender, EventArgs e)
		{
			Runing(Nasus, 44, 591, 277, chamNasus);
			if (Nasus.Left > 1000)
			{
				pictureBox12.Visible = false;
			}
			else
			{
				pictureBox12.Visible = true;
			}
		}

		private void pictureBox12_Click(object sender, EventArgs e)
		{
			Runing(pictureBox12, 44, 358, 502, chamNasus);
			if (pictureBox12.Left > 1000)
			{
				Nasus.Visible = false;
			}
			else
			{
				Nasus.Visible = true;
			}
		}
		#endregion 나서스

		#region 오른
		private void Ornn_Click(object sender, EventArgs e)
		{
			Runing(Ornn, 45, 591, 314, chamOrnn);
			if (Ornn.Left > 1000)
			{
				pictureBox23.Visible = false;
			}
			else
			{
				pictureBox23.Visible = true;
			}
		}
		private void pictureBox23_Click(object sender, EventArgs e)
		{
			Runing(pictureBox23, 45, 580, 502, chamOrnn);
			if (pictureBox23.Left > 1000)
			{
				Ornn.Visible = false;
			}
			else
			{
				Ornn.Visible = true;
			}
		}

		#endregion 오른

		#region 브라움
		private void Braum_Click(object sender, EventArgs e)
		{
			Runing(Braum, 46, 591, 354, chamBraum);
			if (Braum.Left > 1000)
			{
				pictureBox37.Visible = false;
			}
			else
			{
				pictureBox37.Visible = true;
			}
		}
		private void pictureBox37_Click(object sender, EventArgs e)
		{
			Runing(pictureBox37, 46, 288, 795, chamBraum);
			if (pictureBox37.Left > 1000)
			{
				Braum.Visible = false;
			}
			else
			{
				Braum.Visible = true;
			}
		}
		#endregion 브라움

		#region 쓰레쉬
		private void Thresh_Click(object sender, EventArgs e)
		{
			Runing(Thresh, 47, 591, 398, chamThresh);
			if (Thresh.Left > 1000)
			{
				pictureBox32.Visible = false;
			}
			else
			{
				pictureBox32.Visible = true;
			}
		}

		private void pictureBox32_Click(object sender, EventArgs e)
		{
			Runing(pictureBox32, 47, 200, 759, chamThresh);
			if (pictureBox32.Left > 1000)
			{
				Thresh.Visible = false;
			}
			else
			{
				Thresh.Visible = true;
			}
		}
		#endregion 쓰레쉬

		#region 노틸러스
		private void Nautilus_Click(object sender, EventArgs e)
		{
			Runing(Nautilus, 48, 632, 314, chamNautilus);
			if (Nautilus.Left > 1000)
			{
				pictureBox31.Visible = false;
			}
			else
			{
				pictureBox31.Visible = true;
			}
		}
		private void pictureBox31_Click(object sender, EventArgs e)
		{
			Runing(pictureBox31, 48, 200, 722, chamNautilus);
			if (pictureBox31.Left > 1000)
			{
				Nautilus.Visible = false;
			}
			else
			{
				Nautilus.Visible = true;
			}
		}
		#endregion 노틸러스	

		#region 말파이트
		private void Malphite_Click(object sender, EventArgs e)
		{
			Runing(Malphite, 49, 632, 354, chamMalphite);
			if (Malphite.Left > 1000)
			{
				pictureBox28.Visible = false;
			}
			else
			{
				pictureBox28.Visible = true;
			}
		}
		private void pictureBox28_Click(object sender, EventArgs e)
		{
			Runing(pictureBox28, 49, 88, 796, chamMalphite);
			if (pictureBox28.Left > 1000)
			{
				Malphite.Visible = false;
			}
			else
			{
				Malphite.Visible = true;
			}
		}
		#endregion 말파이트	

		#region 타릭
		private void Taric_Click(object sender, EventArgs e)
		{
			Runing(Taric, 49, 632, 395, chamTaric);
			if (Taric.Left > 1000)
			{
				pictureBox22.Visible = false;
			}
			else
			{
				pictureBox22.Visible = true;
			}
		}
		private void pictureBox22_Click(object sender, EventArgs e)
		{
			Runing(pictureBox22, 49, 478, 571, chamTaric);
			if (pictureBox22.Left > 1000)
			{
				Taric.Visible = false;
			}
			else
			{
				Taric.Visible = true;
			}
		}
		#endregion 타릭	


		string[] s = new string[20];
		string[] e = new string[20];
		private void SwordBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 2 && m_liJobCount[a_njob] < 4)
			{
				SwrodLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 추가 공격 1회\n";
			}
			else if (m_liJobCount[a_njob] >= 4 && m_liJobCount[a_njob] < 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 추가 공격 2회\n";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 추가 공격 3회\n";
			}
			if (m_liJobCount[a_njob] < 2)
			{
				SwrodLabel.Visible = false;
			}
			SwrodLabel.Text = s[a_njob];
		}
		private void WarriorBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 3 && m_liJobCount[a_njob] < 6)
			{
				WarriorLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 확률 45%\n";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 확률 100%\n";
			}
			if (m_liJobCount[a_njob] < 3)
			{
				WarriorLabel.Visible = false;
			}
			WarriorLabel.Text = s[a_njob];
		}
		private void PlantBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 2)
			{
				PlantLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " -  드루이드는 매초 40의 \n체력을 회복합니다.";
			}
			if (m_liJobCount[a_njob] < 2)
			{
				PlantLabel.Visible = false;
			}
			PlantLabel.Text = s[a_njob];
		}
		private void SummonerBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 3 && m_liJobCount[a_njob] < 6)
			{
				SummonerLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " -  체력 및 소환 지속시간 +40%";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " -  체력 및 소환 지속시간 +100%";
			}
			if (m_liJobCount[a_njob] < 3)
			{
				SummonerLabel.Visible = false;
			}
			SummonerLabel.Text = s[a_njob];
		}
		private void MagicianBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 3 && m_liJobCount[a_njob] < 6)
			{
				MagicianLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " -  확률 +50%";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " -  확률 +100%";
			}
			if (m_liJobCount[a_njob] < 3)
			{
				MagicianLabel.Visible = false;
			}
			MagicianLabel.Text = s[a_njob];
		}
		private void AlchemyBox(int a_njob)
		{
			if (m_liJobCount[a_njob] == 1)
			{
				AlchemyLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 고유 - 연금술사는 충돌을 \n무시하고 계속 이동합니다.";
			}
			else
			{
				AlchemyLabel.Visible = false;
			}
			AlchemyLabel.Text = s[a_njob];
		}
		private void MysteryBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 2 && m_liJobCount[a_njob] < 4)
			{
				MysteryLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 마법 저항력 +40";
			}
			else if (m_liJobCount[a_njob] == 4)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 마법 저항력 +120";
			}
			if (m_liJobCount[a_njob] < 2)
			{
				MysteryLabel.Visible = false;
			}
			MysteryLabel.Text = s[a_njob];
		}
		private void AvatarBox(int a_njob)
		{
			if (m_liJobCount[a_njob] == 1)
			{
				AvatarLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 특성 추가 효과에 대하여  \n아바타의 계열 원소는 두 번 적용됩니다.";
			}
			else
			{
				AvatarLabel.Visible = false;
			}
			AvatarLabel.Text = s[a_njob];
		}
		private void AssassinBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 3 && m_liJobCount[a_njob] < 6)
			{
				AssassinLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 치명타 피해 +75% 및  \n치명타 확률 +10% 증가";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 치명타 피해 +150% 및  \n치명타 확률 +20% 증가";
			}
			if (m_liJobCount[a_njob] < 3)
			{
				AssassinLabel.Visible = false;
			}
			AssassinLabel.Text = s[a_njob];
		}
		private void GluttonyBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 3)
			{
				GluttonyLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 포식자는 체력이 25% 아래인  \n대상을 즉시 처치합니다.";
			}
			else
			{
				GluttonyLabel.Visible = false;
			}
			GluttonyLabel.Text = s[a_njob];
		}
		private void ReconBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 2 && m_liJobCount[a_njob] < 4)
			{
				ReconLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 30% 확률로 공격 속도 두 배로 증가\n";
			}
			else if (m_liJobCount[a_njob] >= 4 && m_liJobCount[a_njob] < 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 60% 확률로 공격 속도 두 배로 증가\n";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 100% 확률로 공격 속도 두 배로 증가\n";
			}
			if (m_liJobCount[a_njob] < 2)
			{
				ReconLabel.Visible = false;
			}
			ReconLabel.Text = s[a_njob];
		}
		private void WardenBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 2 && m_liJobCount[a_njob] < 4)
			{
				WardenLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 방어력 +150%\n";
			}
			else if (m_liJobCount[a_njob] >= 4 && m_liJobCount[a_njob] < 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 방어력 +300%\n";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 방어력 +450%\n";
			}
			if (m_liJobCount[a_njob] < 2)
			{
				WardenLabel.Visible = false;
			}
			WardenLabel.Text = s[a_njob];
		}
		private void SteeldBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 2 && m_liElemenCount[a_nEle] < 3)
			{
				SteelLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 피해 면역 2초\n";
			}
			else if (m_liElemenCount[a_nEle] >= 3 && m_liElemenCount[a_nEle] < 4)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 피해 면역 3초\n";
			}
			else if (m_liElemenCount[a_nEle] == 4)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 피해 면역 4초\n";
			}
			if (m_liElemenCount[a_nEle] < 2)
			{
				SteelLabel.Visible = false;
			}
			SteelLabel.Text = e[a_nEle];
		}
		private void PoisonBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 3)
			{
				PoisonLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 맹독 챔피언이 피해를 입힐 때 신경독이 적용되어 \n대상이 사용하는 스킬의 마나 소모량을 50% 증가시킵니다.\n";
			}
			else
			{
				PoisonLabel.Visible = false;
			}
			PoisonLabel.Text = e[a_nEle];
		}
		private void WindBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 2 && m_liElemenCount[a_nEle] < 3)
			{
				WindLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 회피 확률 15%";
			}
			else if (m_liElemenCount[a_nEle] >= 3 && m_liElemenCount[a_nEle] < 4)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 회피 확률 20%";
			}
			else if (m_liElemenCount[a_nEle] >= 4)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 회피 확률 30%";
			}
			else
			{
				WindLabel.Visible = false;
			}
			WindLabel.Text = e[a_nEle];
		}
		private void LightBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 3 && m_liElemenCount[a_nEle] < 6)
			{
				LightLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 공격 속도 +10%";
			}
			else if (m_liElemenCount[a_nEle] >= 6 && m_liElemenCount[a_nEle] < 9)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + "  - 공격 속도 +20%";
			}
			else if (m_liElemenCount[a_nEle] >= 9)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 공격 속도 +35%";
			}
			if (m_liElemenCount[a_nEle] < 3)
			{
				LightLabel.Visible = false;
			}
			LightLabel.Text = e[a_nEle];
		}
		private void CrystalBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 2 && m_liElemenCount[a_nEle] < 4)
			{
				CrystalLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 최대 피해량 100";
			}
			else if (m_liElemenCount[a_nEle] == 4)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 최대 피해량 60";
			}
			if (m_liElemenCount[a_nEle] < 2)
			{
				CrystalLabel.Visible = false;
			}
			CrystalLabel.Text = e[a_nEle];
		}
		private void ElectricBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 2 && m_liElemenCount[a_nEle] < 3)
			{
				ElectricLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 피해량 70";
			}
			else if (m_liElemenCount[a_nEle] >= 3 && m_liElemenCount[a_nEle] < 4)
			{
				ElectricLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 피해량 250";
			}
			else if (m_liElemenCount[a_nEle] == 4)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 피해량 500";
			}
			if (m_liElemenCount[a_nEle] < 2)
			{
				ElectricLabel.Visible = false;
			}
			ElectricLabel.Text = e[a_nEle];
		}
		private void MountainBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 2)
			{
				MountainLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 전투 시작 시 무작위 아군 하나가 \n1500의 피해를 막아주는 돌방패를 얻습니다.";
			}
			if (m_liElemenCount[a_nEle] < 2)
			{
				MountainLabel.Visible = false;
			}
			MountainLabel.Text = e[a_nEle];
		}
		private void OceanBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 2 && m_liElemenCount[a_nEle] < 4)
			{
				OceanLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 마나 +15";
			}
			else if (m_liElemenCount[a_nEle] >= 4 && m_liElemenCount[a_nEle] < 6)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 마나 +35";
			}
			else if (m_liElemenCount[a_nEle] == 6)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 마나 +60";
			}
			else
			{
				OceanLabel.Visible = false;
			}
			OceanLabel.Text = e[a_nEle];
		}
		private void GlacialBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 2 && m_liElemenCount[a_nEle] < 4)
			{
				GlacialLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 적을 기절시킬 확률 20%";
			}
			else if (m_liElemenCount[a_nEle] >= 4 && m_liElemenCount[a_nEle] < 6)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 적을 기절시킬 확률 35%";
			}
			else if (m_liElemenCount[a_nEle] == 6)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 적을 기절시킬 확률 50%";
			}
			else
			{
				GlacialLabel.Visible = false;
			}
			GlacialLabel.Text = e[a_nEle];
		}
		private void ShadowBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 2 && m_liElemenCount[a_nEle] < 4)
			{
				ShadowLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 피해량 +45%";
			}
			else if (m_liElemenCount[a_nEle] >= 4)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 피해량 +85%, 그림자 챔피언이 \n처치 관여 시 초기화";
			}
			else
			{
				ShadowLabel.Visible = false;
			}
			ShadowLabel.Text = e[a_nEle];
		}
		private void ForestBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 3)
			{
				ShadowLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 전투 시작 시 무작위 숲 챔피언 \n하나가 자신과 동일한 복제 챔피언을 생성합니다.";
			}
			else
			{
				ShadowLabel.Visible = false;
			}
			ShadowLabel.Text = e[a_nEle];
		}
		private void DesertBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 2 && m_liElemenCount[a_nEle] < 4)
			{
				DesertLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 방어력 50% 감소";
			}
			else if (m_liElemenCount[a_nEle] >= 4)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 방어력 90% 감소";
			}
			else
			{
				DesertLabel.Visible = false;
			}
			DesertLabel.Text = e[a_nEle];
		}
		private void InfernoBox(int a_nEle)
		{
			if (m_liElemenCount[a_nEle] >= 3 && m_liElemenCount[a_nEle] < 6)
			{
				InfernoLabel.Visible = true;
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 추가 피해량 +80%";
			}
			else if (m_liElemenCount[a_nEle] >= 6 && m_liElemenCount[a_nEle] < 9)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 추가 피해량 +175%";
			}
			else if (m_liElemenCount[a_nEle] == 9)
			{
				e[a_nEle] = "(" + m_liElemenCount[a_nEle] + ")" + m_dicElementName[a_nEle] + " - 추가 피해량 +275%";
			}
			else
			{
				InfernoLabel.Visible = false;
			}
			InfernoLabel.Text = e[a_nEle];
		}		
	}

}
