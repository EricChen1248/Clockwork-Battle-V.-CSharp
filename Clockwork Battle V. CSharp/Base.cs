using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Clockwork_Battle_V.CSharp
{
	class Base
	{
		internal static Form Main;
		public List<Control> Controls = new List<Control>();
		

		private const decimal endGameMoney = 0.05M;
		

		public void End()
		{
			foreach (var baseControl in Controls)
			{
				Main.Controls.Remove(baseControl);
			}
		}

		public string NumToChin(int team)
		{
			switch (team)
			{
				case 1:
					return "一　";
				case 2:
					return "二　";
				case 3:
					return "三　";
				case 4:
					return "四　";
				case 5:
					return "五　";
				case 6:
					return "六　";
				case 7:
					return "七　";
				case 8:
					return "八　";
				case 9:
					return "九　";
				case 10:
					return "十　";
				case 11:
					return "十一";
				case 12:
					return "十二";
				default:
					return "";
			}
		}

	}
}
