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
		Dictionary<int, PictureBox> m_dlist = new Dictionary<int, PictureBox>();

		int[] m_arrSet = new int[9] { 9, 9, 9, 9, 9, 9, 9, 9, 9 };
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
		Dictionary<int, List<int>> m_liSynergyCount = new Dictionary<int, List<int>>();
		public Form1()
		{
			InitializeComponent();
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
		private void Runing(PictureBox champion, int num, int ChampionPos_x, int ChampionPos_y)
		{
			int sum = 0;			
			if (champion.Left < 1000)
			{

				if (m_dlist.Count < 9)
				{
					for (int i = 0; i < 9; i++)
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

		}

		#region 야스오
		private void Yasuo_Click(object sender, EventArgs e)
		{
			Synergy(0,Yasuo.Left);
			Runing(Yasuo, 0, 88, 54);
		}
		#endregion 야스오

		#region 아트록스
		private void Aatrox_Click(object sender, EventArgs e)
		{
			Runing(Aatrox, 1, 88, 91);
		}
		#endregion 아트록스

		#region 시비르
		private void Sivir_Click(object sender, EventArgs e)
		{
			Runing(Sivir, 2, 88, 128);
		}

		#endregion 시비르

		#region 마스터 이
		private void MasterYi_1_Click(object sender, EventArgs e)
		{
			
			Runing(MasterYi_1, 3, 88, 167);
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
			
			Runing(MasterYi_2, 3, 88, 395);
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
			Runing(Renekton, 4, 174, 54);
		}
		#endregion 레넥톤

		#region 볼베
		private void Volibear_Click(object sender, EventArgs e)
		{
			Runing(Volibear, 5, 174, 91);
		}
		#endregion 볼베

		#region 잭스
		private void Jax_Click(object sender, EventArgs e)
		{
			Runing(Jax, 6, 174, 128);
		}
		#endregion 잭스

		#region 문도
		private void DrMundo_Click(object sender, EventArgs e)
		{
			Runing(DrMundo, 7, 174, 167);
		}
		#endregion 문도

		#region 사이온
		private void Sion_Click(object sender, EventArgs e)
		{
			Runing(Sion, 8, 210, 91);
		}
		#endregion 사이온

		#region 올라프
		private void Olaf_Click(object sender, EventArgs e)
		{
			Runing(Olaf, 9, 210, 128);
		}

		#endregion 올라프

		#region 아이번
		private void Ivern_Click(object sender, EventArgs e)
		{
			Runing(Ivern, 10, 290, 68);
		}

		#endregion 아이번

		#region 마오카이
		private void Maokai_Click(object sender, EventArgs e)
		{
			Runing(Maokai, 11, 290, 110);
		}
		#endregion 마오카이

		#region 니코
		private void Neeko_Click(object sender, EventArgs e)
		{
			Runing(Neeko, 12, 290, 151);
		}
		#endregion 니코

		#region 자이라
		private void Zyra_Click(object sender, EventArgs e)
		{
			Runing(Zyra, 13, 371, 53);
		}
		#endregion 자이라

		#region 말자하
		private void Malzahar_Click(object sender, EventArgs e)
		{
			Runing(Malzahar, 14, 371, 91);
		}
		#endregion 말자하

		#region 아지르
		private void Azir_Click(object sender, EventArgs e)
		{
			Runing(Azir, 15, 371, 91);
		}
		#endregion 아지르

		#region 애니
		private void Annie_Click(object sender, EventArgs e)
		{
			Runing(Annie, 16, 371, 167);
		}
		#endregion 애니

		#region 요릭
		private void Yorick_Click(object sender, EventArgs e)
		{
			Runing(Yorick, 17, 412, 91);
		}
		#endregion 요릭

		#region 제드
		private void Zed_1_Click(object sender, EventArgs e)
		{
			Runing(Zed_1, 18, 412, 128);
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
			Runing(Zed_2, 18, 289, 355);
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
			Runing(Vladimir, 19, 497, 54);
		}
		#endregion 블라디미르

		#region 탈리야
		private void Taliyah_Click(object sender, EventArgs e)
		{
			Runing(Taliyah, 20, 497, 91);
		}
		#endregion 탈리야

		#region 르블랑
		private void LeBlanc_2_Click(object sender, EventArgs e)
		{
			Runing(LeBlanc_2, 21, 497, 128);
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
			Runing(LeBlanc_1, 21, 246, 318);
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
			Runing(Syndra, 22, 497, 167);
		}
		#endregion 신드라

		#region 베이가
		private void Veigar_Click(object sender, EventArgs e)
		{
			Runing(Veigar, 23, 535, 91);
		}
		#endregion 베이가

		#region 브랜드
		private void Brand_Click(object sender, EventArgs e)
		{
			Runing(Brand, 24, 535, 133);
		}
		#endregion 브랜드

		#region 신지드
		private void Singed_Click(object sender, EventArgs e)
		{
			Runing(Singed, 25, 618, 101);
		}
		#endregion 신지드		

		#region 소라카
		private void Soraka_Click(object sender, EventArgs e)
		{
			Runing(Soraka, 26, 88, 281);
		}
		#endregion 소라카

		#region 잔나
		private void Janna_Click(object sender, EventArgs e)
		{
			Runing(Janna, 27, 88, 318);
		}

		#endregion 잔나

		#region 나미
		private void Nami_Click(object sender, EventArgs e)
		{
			Runing(Nami, 28, 88, 355);
		}
		#endregion 나미

		#region 럭스
		private void Lux_Click(object sender, EventArgs e)
		{
			Runing(Lux, 29, 162, 308);
		}
		#endregion 럭스

		#region 다이애나
		private void Diana_Click(object sender, EventArgs e)
		{
			Runing(Diana, 30, 246, 282);
		}

		#endregion 다이애나

		#region 녹턴
		private void Nocturne_Click(object sender, EventArgs e)
		{
			Runing(Nocturne, 31, 245, 355);
		}
		#endregion 녹턴

		#region 키아나
		private void Qiyana_Click(object sender, EventArgs e)
		{
			Runing(Qiyana, 32, 245, 395);
		}
		#endregion 키아나

		#region 카직스
		private void Khazix_Click(object sender, EventArgs e)
		{
			Runing(Khazix, 33, 288, 318);
		}
		#endregion 카직스

		#region 워윅
		private void Warwick_Click(object sender, EventArgs e)
		{
			Runing(Warwick, 34, 372, 283);
		}
		#endregion 워윅

		#region 코그모
		private void KogMaw_Click(object sender, EventArgs e)
		{
			Runing(KogMaw, 35, 372, 320);
		}

		#endregion 코그모

		#region 렉사이
		private void RekSai_Click(object sender, EventArgs e)
		{
			Runing(RekSai, 36, 372, 360);
		}
		#endregion 렉사이

		#region 스카너
		private void Skarner_Click(object sender, EventArgs e)
		{
			Runing(Skarner, 37, 372, 360);
		}

		#endregion 스카너

		#region 베인
		private void Vayne_Click(object sender, EventArgs e)
		{
			Runing(Vayne, 38, 467, 281);
		}
		#endregion 베인

		#region 바루스
		private void Varus_Click(object sender, EventArgs e)
		{
			Runing(Varus, 39, 467, 317);
		}
		#endregion 바루스

		#region 이즈리얼
		private void Ezreal_Click(object sender, EventArgs e)
		{
			Runing(Ezreal, 40, 467, 354);
		}
		#endregion 이즈리얼

		#region 킨드레드
		private void Kindred_Click(object sender, EventArgs e)
		{
			Runing(Kindred, 41, 467, 394);
		}
		#endregion 킨드레드

		#region 애쉬
		private void Ashe_Click(object sender, EventArgs e)
		{
			Runing(Ashe, 42, 509, 317);
		}
		#endregion 애쉬

		#region 트위치
		private void Twitch_Click(object sender, EventArgs e)
		{
			Runing(Twitch, 43, 509, 357);
		}

		#endregion 트위치

		#region 나서스
		private void Nasus_Click(object sender, EventArgs e)
		{
			Runing(Nasus, 44, 591, 277);
		}
		#endregion 나서스

		#region 오른
		private void Ornn_Click(object sender, EventArgs e)
		{
			Runing(Ornn, 45, 591, 314);
		}

		#endregion 오른

		#region 브라움
		private void Braum_Click(object sender, EventArgs e)
		{
			Runing(Braum, 46, 591, 354);
		}
		#endregion 브라움

		#region 쓰레쉬
		private void Thresh_Click(object sender, EventArgs e)
		{
			Runing(Thresh, 47, 591, 398);
		}
		#endregion 쓰레쉬

		#region 노틸러스
		private void Nautilus_Click(object sender, EventArgs e)
		{
			Runing(Nautilus, 48, 632, 314);
		}
		#endregion 노틸러스	

		#region 말파이트
		private void Malphite_Click(object sender, EventArgs e)
		{
			Runing(Malphite, 49, 632, 354);
		}
		#endregion 말파이트			


		private void SwordMan_MouseHover_1(object sender, EventArgs e)
		{
			MessageBox.Show("검사는 기본 공격시 40% 확률로 대상에게 추가 공격을 가합니다. 추가 공격은 기본 공격과 같은 피해를 입히며 적중 시 효과가 적용됩니다.\n" +
							"(2) 추가 공격 1회\n" +
							"(4) 추가 공격 2회\n" +
							"(6) 추가 공격 1회\n");
		}
		private void Synergy(int num,int pos_y)
		{
			if (m_liSynergyCount.ContainsKey(1) == false) { m_liSynergyCount.Add(1, new List<int>()); }
			m_liSynergyCount.TryGetValue(1, out List<int> L);
			if (num >= 0 && num <= 4&& pos_y<1000)
			{
				L.Add(num);
			}		
			else
			{
				L.Remove(num);
			}
			SynergyBox.Text = L.Count.ToString();
			//if (m_liSynergyCount.TryGetValue(1, out List<int> L1))
			//{
			//	SynergyBox.Text = L.Count.ToString();
			//}
		}

	}
}
