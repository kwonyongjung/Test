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


		Dictionary<int, PictureBox> m_dlist = new Dictionary<int, PictureBox>();
		int[] m_arrSet = new int[20] { 9, 9, 9, 9, 9, 9, 9, 9, 9,9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };
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
        //Dictionary<int, List<int>> m_liSynergyCount = new Dictionary<int, List<int>>();
        Dictionary<int, string> m_dicJobName = new Dictionary<int, string>();
        Dictionary<int, int> m_dicJobCount = new Dictionary<int, int>();

        List<int> m_liJobCount = new List<int>();
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
			if (champion.Left < 1000)
			{          						   
                if (m_dlist.Count < 9)
				{
					m_liJobCount[Cham.Job_1]++;
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
			}
        }
		private void DualRuning(PictureBox champion, int num, int ChampionPos_x, int ChampionPos_y, Unit Cham)
		{
			int sum = 0;
			if (champion.Left < 1000)
			{							
				if (m_dlist.Count < 9)
				{
					m_liJobCount[Cham.Job_1]++;
					m_liJobCount[Cham.Job_2]++;
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
		#region 야스오
		private void Yasuo_Click(object sender, EventArgs e)
		{
			Runing(Yasuo, 0, 88, 54,chamYasuo);           
        }
		#endregion 야스오

		#region 아트록스
		private void Aatrox_Click(object sender, EventArgs e)
		{
			Runing(Aatrox, 1, 88, 91, chamAatrox);
		}
		#endregion 아트록스

		#region 시비르
		private void Sivir_Click(object sender, EventArgs e)
		{
			Runing(Sivir, 2, 88, 128, chamSivir);
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

		}
		#endregion 마스터 이

		#region 레넥톤
		private void Renekton_Click(object sender, EventArgs e)
		{
			Runing(Renekton, 4, 174, 54, chamRenekton);
		}
		#endregion 레넥톤

		#region 볼베
		private void Volibear_Click(object sender, EventArgs e)
		{
			Runing(Volibear, 5, 174, 91, chamVolibear);
		}
		#endregion 볼베

		#region 잭스
		private void Jax_Click(object sender, EventArgs e)
		{
			Runing(Jax, 6, 174, 128, chamJax);
		}
		#endregion 잭스

		#region 문도
		private void DrMundo_Click(object sender, EventArgs e)
		{
			Runing(DrMundo, 7, 174, 167, chamDrMundo);
		}
		#endregion 문도

		#region 사이온
		private void Sion_Click(object sender, EventArgs e)
		{
			Runing(Sion, 8, 210, 91, chamSion);
		}
		#endregion 사이온

		#region 올라프
		private void Olaf_Click(object sender, EventArgs e)
		{
			Runing(Olaf, 9, 210, 128, chamOlaf);
		}

		#endregion 올라프

		#region 아이번
		private void Ivern_Click(object sender, EventArgs e)
		{
			Runing(Ivern, 10, 290, 68, chamIvern);
		}
		#endregion 아이번

		#region 마오카이
		private void Maokai_Click(object sender, EventArgs e)
		{
			Runing(Maokai, 11, 290, 110, chamMaokai);
		}
		#endregion 마오카이

		#region 니코
		private void Neeko_Click(object sender, EventArgs e)
		{
			Runing(Neeko, 12, 290, 151, chamNeeko);
		}
		#endregion 니코

		#region 자이라
		private void Zyra_Click(object sender, EventArgs e)
		{
			Runing(Zyra, 13, 371, 53, chamZyra);
		}
		#endregion 자이라

		#region 말자하
		private void Malzahar_Click(object sender, EventArgs e)
		{
			Runing(Malzahar, 14, 371, 91, chamMalzahar);
		}
		#endregion 말자하

		#region 아지르
		private void Azir_Click(object sender, EventArgs e)
		{
			Runing(Azir, 15, 371, 128, chamAzir);
		}
		#endregion 아지르

		#region 애니
		private void Annie_Click(object sender, EventArgs e)
		{
			Runing(Annie, 16, 371, 167, chamAnnie);
		}
		#endregion 애니

		#region 요릭
		private void Yorick_Click(object sender, EventArgs e)
		{
			Runing(Yorick, 17, 412, 91, chamYorick);
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

		}
		#endregion 제드

		#region 블라디미르
		private void Vladimir_Click(object sender, EventArgs e)
		{
			Runing(Vladimir, 19, 497, 54, chamVladimir);
		}
		#endregion 블라디미르

		#region 탈리야
		private void Taliyah_Click(object sender, EventArgs e)
		{
			Runing(Taliyah, 20, 497, 91, chamTaliyah);
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
		}
		#endregion 르블랑

		#region 신드라
		private void Syndra_Click(object sender, EventArgs e)
		{
			Runing(Syndra, 22, 497, 167, chamSyndra);
		}
		#endregion 신드라

		#region 베이가
		private void Veigar_Click(object sender, EventArgs e)
		{
			Runing(Veigar, 23, 535, 91, chamVeigar);
		}
		#endregion 베이가

		#region 브랜드
		private void Brand_Click(object sender, EventArgs e)
		{
			Runing(Brand, 24, 535, 133, chamBrand);
		}
		#endregion 브랜드

		#region 신지드
		private void Singed_Click(object sender, EventArgs e)
		{
			Runing(Singed, 25, 618, 101, chamSinged);
		}
		#endregion 신지드		

		#region 소라카
		private void Soraka_Click(object sender, EventArgs e)
		{
			Runing(Soraka, 26, 88, 281, chamSoraka);
		}
		#endregion 소라카		

		#region 잔나
		private void Janna_Click(object sender, EventArgs e)
		{
			Runing(Janna, 27, 88, 318, chamJanna);
		}

		#endregion 잔나

		#region 나미
		private void Nami_Click(object sender, EventArgs e)
		{
			Runing(Nami, 28, 88, 355, chamNami);
		}
		#endregion 나미

		#region 럭스
		private void Lux_Click(object sender, EventArgs e)
		{
			Runing(Lux, 29, 162, 308, chamLux);
		}
		#endregion 럭스

		#region 다이애나
		private void Diana_Click(object sender, EventArgs e)
		{
			Runing(Diana, 30, 246, 282, chamDiana);
		}

		#endregion 다이애나

		#region 녹턴
		private void Nocturne_Click(object sender, EventArgs e)
		{
			Runing(Nocturne, 31, 245, 355, chamNocturne);
		}
		#endregion 녹턴

		#region 키아나
		private void Qiyana_Click(object sender, EventArgs e)
		{
			Runing(Qiyana, 32, 245, 395, chamQiyana);
		}
		#endregion 키아나

		#region 카직스
		private void Khazix_Click(object sender, EventArgs e)
		{
			Runing(Khazix, 33, 288, 318, chamKhazix);
		}
		#endregion 카직스

		#region 워윅
		private void Warwick_Click(object sender, EventArgs e)
		{
			Runing(Warwick, 34, 372, 283, chamWarwick);
		}
		#endregion 워윅

		#region 코그모
		private void KogMaw_Click(object sender, EventArgs e)
		{
			Runing(KogMaw, 35, 372, 320, chamKogMaw);
		}

		#endregion 코그모

		#region 렉사이
		private void RekSai_Click(object sender, EventArgs e)
		{
			Runing(RekSai, 36, 372, 360, chamRekSai);
		}
		#endregion 렉사이

		#region 스카너
		private void Skarner_Click(object sender, EventArgs e)
		{
			Runing(Skarner, 37, 372, 360, chamSkarner);
		}

		#endregion 스카너

		#region 베인
		private void Vayne_Click(object sender, EventArgs e)
		{
			Runing(Vayne, 38, 467, 281, chamYasuo);
		}
		#endregion 베인

		#region 바루스
		private void Varus_Click(object sender, EventArgs e)
		{
			Runing(Varus, 39, 467, 317, chamYasuo);
		}
		#endregion 바루스

		#region 이즈리얼
		private void Ezreal_Click(object sender, EventArgs e)
		{
			Runing(Ezreal, 40, 467, 354, chamYasuo);
		}
		#endregion 이즈리얼

		#region 킨드레드
		private void Kindred_Click(object sender, EventArgs e)
		{
			Runing(Kindred, 41, 467, 394, chamYasuo);
		}
		#endregion 킨드레드

		#region 애쉬
		private void Ashe_Click(object sender, EventArgs e)
		{
			Runing(Ashe, 42, 509, 317, chamYasuo);
		}
		#endregion 애쉬

		#region 트위치
		private void Twitch_Click(object sender, EventArgs e)
		{
			Runing(Twitch, 43, 509, 357, chamYasuo);
		}

		#endregion 트위치

		#region 나서스
		private void Nasus_Click(object sender, EventArgs e)
		{
			Runing(Nasus, 44, 591, 277, chamYasuo);
		}
		#endregion 나서스

		#region 오른
		private void Ornn_Click(object sender, EventArgs e)
		{
			Runing(Ornn, 45, 591, 314, chamYasuo);
		}

		#endregion 오른

		#region 브라움
		private void Braum_Click(object sender, EventArgs e)
		{
			Runing(Braum, 46, 591, 354, chamYasuo);
		}
		#endregion 브라움

		#region 쓰레쉬
		private void Thresh_Click(object sender, EventArgs e)
		{
			Runing(Thresh, 47, 591, 398, chamYasuo);
		}
		#endregion 쓰레쉬

		#region 노틸러스
		private void Nautilus_Click(object sender, EventArgs e)
		{
			Runing(Nautilus, 48, 632, 314, chamYasuo);
		}
		#endregion 노틸러스	

		#region 말파이트
		private void Malphite_Click(object sender, EventArgs e)
		{
			Runing(Malphite, 49, 632, 354, chamYasuo);
		}
		#endregion 말파이트			


		private void SwordMan_MouseHover_1(object sender, EventArgs e)
		{
			MessageBox.Show("검사는 기본 공격시 40% 확률로 대상에게 추가 공격을 가합니다. 추가 공격은 기본 공격과 같은 피해를 입히며 적중 시 효과가 적용됩니다.\n" +
							"(2) 추가 공격 1회\n" +
							"(4) 추가 공격 2회\n" +
							"(6) 추가 공격 3회\n");
		}
		string []s = new string[9];
		private void SwordBox(int a_njob)
		{	
			if (m_liJobCount[a_njob] >= 2&& m_liJobCount[a_njob] < 4)
			{
				SwrodLabel.Visible = true;
				s[a_njob] = "("+ m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 추가 공격 1회\n";
			}
			else if (m_liJobCount[a_njob] >= 2 && m_liJobCount[a_njob] < 6)
			{
				SwrodLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 추가 공격 2회\n";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				SwrodLabel.Visible = true;
				s[a_njob] = "(" +m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 추가 공격 3회\n";
			}
			if (m_liJobCount[a_njob] < 2)
			{
				SwrodLabel.Visible = false;
				SwrodLabel.Text = " ";
			}
			SwrodLabel.Text = s[a_njob];			
		}
		private void WarriorBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 3&& m_liJobCount[a_njob] <6)
			{
				WarriorLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 확률 45%\n";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				WarriorLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 확률 100%\n";
			}
			if (m_liJobCount[a_njob] <3)
			{
				WarriorLabel.Visible = false;
				WarriorLabel.Text = " ";
			}
			WarriorLabel.Text = s[a_njob];
		}
		private void PlantBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 2)
			{
				PlantLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " -  드루이드는 매초 40의 체력을 회복합니다.";
			}			
			if (m_liJobCount[a_njob] <2)
			{
				PlantLabel.Visible = false;
				PlantLabel.Text = " ";
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
				SummonerLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " -  체력 및 소환 지속시간 +100%";
			}
			if (m_liJobCount[a_njob] <3)
			{
				SummonerLabel.Visible = false;
				PlantLabel.Text = " ";
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
				MagicianLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " -  확률 +100%";
			}
			if (m_liJobCount[a_njob] <3)
			{
				MagicianLabel.Visible = false;
				PlantLabel.Text = " ";
			}
			MagicianLabel.Text = s[a_njob];
		}
		private void AlchemyBox(int a_njob)
		{
			if (m_liJobCount[a_njob] ==1)
			{
				AlchemyLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 고유 - 연금술사는 충돌을 무시하고 계속 이동합니다.";
			}
			else
			{ 
				AlchemyLabel.Visible = false;
				PlantLabel.Text = " ";
			}
			AlchemyLabel.Text = s[a_njob];
		}
		private void MysteryBox(int a_njob)
		{		
			if (m_liJobCount[a_njob] >= 2&& m_liJobCount[a_njob] <4)
			{
				MysteryLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 마법 저항력 +40";
			}
			else  if (m_liJobCount[a_njob] == 4)
			{
				MysteryLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 마법 저항력 +120";
			}
			if(m_liJobCount[a_njob] < 2)
			{
				MysteryLabel.Visible = false;
				PlantLabel.Text = " ";
			}
			MysteryLabel.Text = s[a_njob];
		}
		private void AvatarBox(int a_njob)
		{
			if (m_liJobCount[a_njob] == 1)
			{
				AvatarLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 특성 추가 효과에 대하여 아바타의 계열 원소는 두 번 적용됩니다.";
			}			
			else
			{
				AvatarLabel.Visible = false;
				PlantLabel.Text = " ";
			}
			AvatarLabel.Text = s[a_njob];
		}
		private void AssassinBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 3 && m_liJobCount[a_njob] < 6)
			{
				AssassinLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 치명타 피해 +75% 및 치명타 확률 +10% 증가";
			}
			else if (m_liJobCount[a_njob] == 6)
			{
				AssassinLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 치명타 피해 +150% 및 치명타 확률 +20% 증가";
			}
			if (m_liJobCount[a_njob] < 3)
			{
				AssassinLabel.Visible = false;
				PlantLabel.Text = " ";
			}
			AssassinLabel.Text = s[a_njob];
		}
		private void GluttonyBox(int a_njob)
		{
			if (m_liJobCount[a_njob] >= 3)
			{
				GluttonyLabel.Visible = true;
				s[a_njob] = "(" + m_liJobCount[a_njob] + ")" + m_dicJobName[a_njob] + " - 포식자는 체력이 25% 아래인 대상을 즉시 처치합니다.";
			}			
			if(m_liJobCount[a_njob]<3)
			{
				GluttonyLabel.Visible = false;
				GluttonyLabel.Text = " ";
			}
			GluttonyLabel.Text = s[a_njob];
		}	
	}
}
