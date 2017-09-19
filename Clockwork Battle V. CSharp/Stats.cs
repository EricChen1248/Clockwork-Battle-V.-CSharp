using System;
using System.Drawing;
using System.Windows.Forms;
using Clockwork_Battle_V.CSharp.Classes;

namespace Clockwork_Battle_V.CSharp
{
	public partial class Stats : Form
	{
		public Team[] Teams = new Team[12];
		private bool drag;
		private int mouseX;
		private int mouseY;

		private Label[,] Jobs = new Label[12,3];
		public Stats(Team[] teams)
		{
			for (int i = 0; i < 12; i++)
				Teams[i] = teams[i];

			InitializeComponent();
			Init();
			BasePanel.Controls.Add(new TeamSet(1, Teams[0]));
		}

		private void Init()
		{
			Jobs[0, 0] = Job0101;
			Jobs[0, 1] = Job0102;
			Jobs[0, 2] = Job0103;
			Jobs[1, 0] = Job0201;
			Jobs[1, 1] = Job0202;
			Jobs[1, 2] = Job0203;
			Jobs[2, 0] =  label19;
			Jobs[2, 1] =  label18;
			Jobs[2, 2] =  label17;
			Jobs[3, 0] =	 label23;
			Jobs[3, 1] =	 label22;
			Jobs[3, 2] =	 label21;
			Jobs[4, 0] =  label27;
			Jobs[4, 1] =  label26;
			Jobs[4, 2] =  label25;
			Jobs[5, 0] =  label31;
			Jobs[5, 1] =  label30;
			Jobs[5, 2] =  label29;
			Jobs[6, 0] =  label35;
			Jobs[6, 1] =  label34;
			Jobs[6, 2] =  label33;
			Jobs[7, 0] =  label39;
			Jobs[7, 1] =  label38;
			Jobs[7, 2] =  label37;
			Jobs[8, 0] =  label43;
			Jobs[8, 1] =  label42;
			Jobs[8, 2] =  label41;
			Jobs[9, 0] =  label47;
			Jobs[9, 1] =  label46;
			Jobs[9, 2] =  label45;
			Jobs[10, 0] =label11;
			Jobs[10, 1] =label10;
			Jobs[10, 2] =label9	 ;
			Jobs[11, 0] =label7	 ;
			Jobs[11, 1] =label6	 ;
			Jobs[11, 2] = label5;

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

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
	}

	internal class TeamSet : UserControl
	{
		public decimal[] Points  = new decimal[3];
		public decimal[] Multiplier = new decimal[3];

		private int Team;
		public TeamSet(int teamNo, Team team)
		{
			Team = teamNo;

			var panel = new TableLayoutPanel
			{
				Dock = DockStyle.Fill,
				ColumnCount = 6,
				RowCount = 3,
				BackColor = Color.Transparent
			};
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F/6F));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / 6F));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / 6F));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / 6F));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / 6F));
			panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / 6F));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
			panel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
			
			panel.Controls.Add(new Label
			{
				Name = "TeamLabel",
				Dock = DockStyle.Fill,
				Font = new Font("Microsoft JhengHei", 14.25743F, FontStyle.Bold, GraphicsUnit.Point, 136),
				Text = team.Aliens[0].ChineseCareers(),
				ForeColor = Color.White,
			});
			panel.SetColumnSpan(panel.Controls["TeamLabel"], 3);

			panel.Controls.Add(new Label
			{
				Name = "TeamLabel",
				Dock = DockStyle.Fill,
				Font = new Font("Microsoft JhengHei", 14.25743F, FontStyle.Bold, GraphicsUnit.Point, 136),
				Text = team.Aliens[1].ChineseCareers(),
				ForeColor = Color.White,
			});

			panel.Controls.Add(new Label
			{
				Name = "TeamLabel",
				Dock = DockStyle.Fill,
				Font = new Font("Microsoft JhengHei", 14.25743F, FontStyle.Bold, GraphicsUnit.Point, 136),
				Text = team.Aliens[2].ChineseCareers(),
				ForeColor = Color.White,
			});

			panel.Controls.Add(new Label
			{
				Name = "TeamLabel",
				Dock = DockStyle.Fill,
				Font = new Font("Microsoft JhengHei", 14.25743F, FontStyle.Bold, GraphicsUnit.Point, 136),
				Text = "第" + Base.NumToChin(Team) + "組",
				ForeColor = Color.White,
			});
			



		}
	}


}
