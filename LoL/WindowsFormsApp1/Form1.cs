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
		Dictionary<int,PictureBox> list = new Dictionary<int,PictureBox>();
		int k = 0;
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
					k= 1150;
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
		#region 야스오
		private void Yasuo_Click(object sender, EventArgs e)
		{
			int k = 0;
			if (Yasuo.Left < 1000)
			{
				for (int i = 0; i < 9; i++)
				{
					if (list.Count < 9&&list[i]==null)
					{
						list.Add(this.k, Yasuo);
						break;
					}
				}
				list[this.k].Left = Range(this.k);
			}
			else
			{
				list.Remove(k);
				Yasuo.Left = 54;	
			}

		}
		#endregion 야스오

		#region 아트록스
		private void Aatrox_Click(object sender, EventArgs e)
		{
			if (Aatrox.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Aatrox);
				}
				list[k].Left = Range(k);				
			}
			else
			{
				list.Remove(k);
				Aatrox.Left = 91;			
			}

		}
		#endregion 아트록스

		#region 시비르
		private void Sivir_Click(object sender, EventArgs e)
		{
			if (Sivir.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Sivir);
				}
				list[k].Left = Range(k);				
			}
			else
			{
				list.Remove(k);
				Sivir.Left = 128;			
			}

		}

		#endregion 시비르

		#region 마스터 이
		private void MasterYi_1_Click(object sender, EventArgs e)
		{
			if (MasterYi_1.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, MasterYi_1);
				}
				list[k].Left = Range(k);			
			}
			else
			{
				list.Remove(k);
				MasterYi_1.Left = 167;			
			}
		}

		#endregion 마스터 이

		#region 레넥톤
		private void Renekton_Click(object sender, EventArgs e)
		{
			if (Renekton.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Renekton);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;				
			}
			else
			{
				list.Remove(k);
				Renekton.Top = 174;
				Renekton.Left = 54;				
			}
		}
		#endregion 레넥톤

		#region 볼베
		private void Volibear_Click(object sender, EventArgs e)
		{
			if (Volibear.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Volibear);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;			
			}
			else
			{
				list.Remove(k);
				Volibear.Top = 174;
				Volibear.Left = 91;
			}
		}
		#endregion 볼베

		#region 잭스
		private void Jax_Click(object sender, EventArgs e)
		{
			if (Jax.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Jax);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;			
			}
			else
			{
				list.Remove(k);
				Jax.Top = 174;
				Jax.Left = 128;			
			}
		}
		#endregion 잭스

		#region 문도
		private void DrMundo_Click(object sender, EventArgs e)
		{
			if (DrMundo.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, DrMundo);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;				
			}
			else
			{
				list.Remove(k);
				DrMundo.Top = 174;
				DrMundo.Left = 167;			
			}
		}

		#endregion 문도

		#region 사이온
		private void Sion_Click(object sender, EventArgs e)
		{
			if (Sion.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Sion);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;
			}
			else
			{
				list.Remove(k);
				Sion.Top = 210;
				Sion.Left = 91;
			}
		}
		#endregion 사이온

		#region 올라프
		private void Olaf_Click(object sender, EventArgs e)
		{
			if (Olaf.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Olaf);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;
			}
			else
			{
				list.Remove(k);
				Olaf.Top = 210;
				Olaf.Left = 128;
			}
		}

		#endregion 올라프

		#region 아이번
		private void Ivern_Click(object sender, EventArgs e)
		{
			if (Ivern.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Ivern);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;
			}
			else
			{
				list.Remove(k);
				Ivern.Top = 290;
				Ivern.Left = 68;
				;
			}
		}

		#endregion 아이번

		#region 마오카이
		private void Maokai_Click(object sender, EventArgs e)
		{
			if (Maokai.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Maokai);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;			
			}
			else
			{
				list.Remove(k);
				Maokai.Top = 290;
				Maokai.Left = 110;
			}
		}
		#endregion 마오카이

		#region 니코
		private void Neeko_Click(object sender, EventArgs e)
		{
			if (Neeko.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Neeko);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;
			}
			else
			{
				list.Remove(k);
				Neeko.Top = 290;
				Neeko.Left = 151;
			}
		}
		#endregion 니코

		#region 자이라
		private void Zyra_Click(object sender, EventArgs e)
		{
			if (Zyra.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Zyra);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;
			}
			else
			{
				list.Remove(k);
				Zyra.Top = 371;
				Zyra.Left = 54;
			}
		}
		#endregion 자이라

		#region 말자하
		private void Malzahar_Click(object sender, EventArgs e)
		{
			if (Malzahar.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Malzahar);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;
			}
			else
			{
				list.Remove(k);
				Malzahar.Top = 371;
				Malzahar.Left = 91;
			}
		}
		#endregion 말자하

		#region 아지르
		private void Azir_Click(object sender, EventArgs e)
		{
			if (Azir.Left < 1000)
			{
				if (list.Count < 9)
				{
					list.Add(k, Azir);
				}
				list[k].Left = Range(k);
				list[k].Top = 88;
			}
			else
			{
				list.Remove(k);
				Azir.Top = 371;
				Azir.Left = 128;
			}
		}
		#endregion 아지르
	}
}
