using System;
using System.Drawing;
using System.Windows.Forms;
using Clockwork_Battle_V.CSharp.Classes;

namespace Clockwork_Battle_V.CSharp
{
	public partial class TeamSelection : Form
	{
		public static GameBase GameBase;

		private readonly int[] alienSelected = new int[12];
		private readonly Label[,] ticks = new Label[12, 6];
		private bool drag;
		private int mouseX;
		private int mouseY;

		public TeamSelection()
		{
			InitializeComponent();
			for (var i = 0; i < 6; i++)
				for (var j = 0; j < 12; j++)
				{
					ticks[j, i] = new Label
					{
						Size = new Size(70, 58),
						Font = new Font("Microsoft Jhenghei", 36),
						Text = "",
						ForeColor = Color.White,
						TextAlign = ContentAlignment.MiddleCenter,
						BackColor = Color.Transparent,
						BorderStyle = BorderStyle.Fixed3D
					};
					CareerTabel.Controls.Add(ticks[j, i]);
					var j1 = j;
					ticks[j, i].MouseClick += (sender, e) => Team_Selection_MouseClick(sender, j1);
				}
		}

		public void Random()
		{
			var rnd = new Random();

			for (var i = 0; i < 12; i++)
				for (var j = 0; j < 3; j++)
				{
					var r = rnd.Next(6);
					if (ticks[i, r].Text == "")
						Team_Selection_MouseClick(ticks[i,r],i);
					else
						--j;
				}

			ConfirmLabel_Click(null, EventArgs.Empty);
		}

		private void Team_Selection_MouseClick(object sender, int column)
		{
			var label = (Label) sender;
			if (label.Text != "✓")
				if (alienSelected[column] < 3)
				{
					++alienSelected[column];
					label.Text = "✓";
				}
				else
					MessageBox.Show("你已經給第" + Base.NumToChin(column + 1) + "組選三個外星人了");
			else
			{
				label.Text = "";
				--alienSelected[column];
			}
		}

		private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
		{
			if (!drag) return;
			Top = Cursor.Position.Y - mouseY;
			Left = Cursor.Position.X - mouseX;
		}

		private void TitleLabel_MouseUp(object sender, MouseEventArgs e)
		{
			drag = false;
		}

		private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
		{
			drag = true;
			mouseX = Cursor.Position.X - Left;
			mouseY = Cursor.Position.Y - Top;
		}

		private void CancelLabel_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void ConfirmLabel_Click(object sender, EventArgs e)
		{
			for (var i = 0; i < 12; i++)
				if (alienSelected[i] != 3)
				{
					MessageBox.Show("請選好所有小組的外星人");
					return;
				}

			var career = new Alien.Careers[3, 12];
			for (var j = 0; j < 12; j++)
			{
				var i = 0;
				for (var k = 0; k < 6; k++)
					if (ticks[j, k].Text != "")
						career[i++, j] = (Alien.Careers) k;
			}
			for (var i = 0; i < 12; i++)
				GameBase.Teams[i] = new Team(career[0, i], career[1, i], career[2, i]);
			GameBase.TeamIntialization();
			Base.Settings.LoadMeals();
			Hide();
		}

	}
}