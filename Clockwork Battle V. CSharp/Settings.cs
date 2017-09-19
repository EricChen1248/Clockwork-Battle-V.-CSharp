using System;
using System.Windows.Forms;

namespace Clockwork_Battle_V.CSharp
{
	public partial class Settings : Form
	{
		public static GameBase GameBase;
		private bool drag;
		private int mouseX;
		private int mouseY;

		public Settings()
		{
			InitializeComponent();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Hide();
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

		private void SaveBtn_Click(object sender, EventArgs e)
		{
		}

		private void LoadBtn_Click(object sender, EventArgs e)
		{
			LoadMeals();
		}

		private void InitBtn_Click(object sender, EventArgs e)
		{
			var teamSelection = new TeamSelection();
			teamSelection.Show();
		}

		private void RndBtn_Click(object sender, EventArgs e)
		{
			var teamSelection = new TeamSelection();
			teamSelection.Random();
			Controls.Remove(RndBtn);
			Controls.Remove(InitBtn );
		}

		private void QuitBtn_Click(object sender, EventArgs e)
		{
			if (DialogForm.YesNo("關閉程式?", "你確定要關閉鐘點戰嗎?", "確認", "取消"))
			{
				Application.Exit();
			}
		}

		private void StatsBtn_Click(object sender, EventArgs e)
		{
			var stats = new Stats(GameBase.Teams);
			stats.Show();
		}

		public void LoadMeals()
		{
			BreakfastBtn.Visible = true;
			LunchBtn.Visible = true;
			DinnerBtn.Visible = true;
		}
	}
}