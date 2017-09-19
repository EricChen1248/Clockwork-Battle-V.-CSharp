using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Clockwork_Battle_V.CSharp.Classes;
using Clockwork_Battle_V.CSharp.Properties;
using static System.Math;

namespace Clockwork_Battle_V.CSharp
{
	public class GameBase : Base
	{
		//Controls
		private readonly Label[] borders = new Label[13];
		private readonly Label[] teamLabels = new Label[13];
		private readonly Label[,] alienLabels = new Label[12, 3];
		private readonly Label[,] pointLabels = new Label[12, 3];
		private readonly PictureBox[] planets = new PictureBox[12];
		private readonly PictureBox[,] alienImages = new PictureBox[12,3];

		private PictureBox settingRockets;
		private Label title;
		private Label time;

		private readonly Timer currentTime = new Timer();

		public readonly List<Alien>[] AlienCareers = new List<Alien>[6];	

		public Team[] Teams = new Team[12];
	
		//Constructors
		public GameBase()
		{
			Alien.GameBase = this;
			Intialize();
			foreach (var baseControl in Controls)
				Main.Controls.Add(baseControl);
		}

		public void Intialize()
		{
			TitleInit();
			LabelInit();
			BorderInit();
			
			foreach (var control in Controls)	
				control.BackColor = Color.FromArgb(150, 130, 130, 130);

			PictureInit();
		}
		private void TitleInit()
		{
			title = new Label
			{
				AutoSize = true,
				Text = "鐘點戰",
				Left = (Main.Width / 2 - Main.Height / 8) - 70,
				Top = 10,
				Font = new Font("Microsoft JhengHei", 30),
				ForeColor = Color.White
			};
			Controls.Add(title);

			time = new Label
			{
				AutoSize = true,
				Left = (Main.Width / 2 - Main.Height / 8) - 50,
				Text = DateTime.Now.ToShortTimeString(),
				Top = 60,
				Font = new Font("Microsoft JhengHei", 15),
				ForeColor = Color.White
			};
			Controls.Add(time);
			
			borders[12] = new Label
			{
				Size = new Size(Main.Width - Main.Height / 4 * 3, Main.Height / 12),
				Left = Main.Height / 4,
				Top = 0,
				BorderStyle = BorderStyle.FixedSingle
			};
			Controls.Add(borders[12]);

			currentTime.Interval = 5000;
			currentTime.Start();
			currentTime.Tick += CurrentTime_Tick;
		}
		private void LabelInit()
		{
			for (var i = 0; i < 4; i++)
			{
				teamLabels[i] = new Label
				{
					AutoSize = true,
					Left = 20,
					Text = NumToChin(i + 1) + "點星",
					Top = (i)*Main.Height/4 + 13,
					Font = new Font("Microsoft JhengHei", 21, FontStyle.Bold),
					ForeColor = Color.White
				};
				Controls.Add(teamLabels[i]);

				teamLabels[i + 4] = new Label
				{
					AutoSize = true,
					Left = Main.Width - Main.Height/2 + 20,
					Text = NumToChin(i + 5) + "點星",
					Top = (i)*Main.Height/4 + 13,
					Font = new Font("Microsoft JhengHei", 21, FontStyle.Bold),
					ForeColor = Color.White
				};
				Controls.Add(teamLabels[i + 4]);

				teamLabels[i + 8] = new Label
				{
					AutoSize = true,
					Left = Main.Width - Main.Height/4 + 20,
					Text = NumToChin(i + 9) + "點星",
					Top = (i)*Main.Height/4 + 13,
					Font = new Font("Microsoft JhengHei", 21, FontStyle.Bold),
					ForeColor = Color.White
				};
				Controls.Add(teamLabels[i + 8]);

				for (int j = 0; j < 3; j++)
				{
					alienLabels[i, j] = new Label
					{
						AutoSize = true,
						Left = 22,
						Top = i * Main.Height / 4 + 70 + (65 * j),
						Font = new Font("Microsoft Jhenghei", 20, FontStyle.Bold ),
						ForeColor = Color.White
					};
					Controls.Add(alienLabels[i,j]);
					
					alienLabels[i + 4, j] = new Label
					{
						AutoSize = true,
						Left = Main.Width - Main.Height / 2 + 22,
						Top = i * Main.Height / 4 + 70 + (65 * j),
						Font = new Font("Microsoft Jhenghei", 20, FontStyle.Bold),
						ForeColor = Color.White
					};
					Controls.Add(alienLabels[i + 4, j]);

					alienLabels[i + 8, j] = new Label
					{
						AutoSize = true,
						Left = Main.Width - Main.Height / 4 + 22,
						Top = i * Main.Height / 4 + 70 + (65 * j),
						Font = new Font("Microsoft Jhenghei", 20, FontStyle.Bold),
						ForeColor = Color.White
					};
					Controls.Add(alienLabels[i + 8, j]);


					pointLabels[i, j] = new Label
					{
						AutoSize = true,
						Left = 180,
						Top = i * Main.Height / 4 + 70 + (65 * j),
						Font = new Font("Microsoft Jhenghei", 20, FontStyle.Bold),
						ForeColor = Color.White
					};
					Controls.Add(pointLabels[i, j]);

					pointLabels[i + 4, j] = new Label
					{
						AutoSize = true,
						Left = Main.Width - Main.Height / 2 + 180,
						Top = i * Main.Height / 4 + 70 + (65 * j),
						Font = new Font("Microsoft Jhenghei", 20, FontStyle.Bold),
						ForeColor = Color.White
					};
					Controls.Add(pointLabels[i + 4, j]);

					pointLabels[i + 8, j] = new Label
					{
						AutoSize = true,
						Left = Main.Width - Main.Height / 4 +180,
						Top = i * Main.Height / 4 + 70 + (65 * j),
						Font = new Font("Microsoft Jhenghei", 20, FontStyle.Bold),
						ForeColor = Color.White
					};
					Controls.Add(pointLabels[i + 8, j]);
				}
			}

		}
		private void BorderInit()
		{
			for (var i = 0; i < 4; i++)
			{
				borders[i] = new Label
				{
					Size = new Size(Main.Height/4, Main.Height/4),
					Left = 0,
					Top = (i)*Main.Height/4,
					BorderStyle = BorderStyle.FixedSingle
				};
				Controls.Add(borders[i]);

				borders[i + 4] = new Label
				{
					Size = new Size(Main.Height/4, Main.Height/4),
					Left = Main.Width - Main.Height/2,
					Top = (i)*Main.Height/4,
					BorderStyle = BorderStyle.FixedSingle
				};
				Controls.Add(borders[i + 4]);

				borders[i + 8] = new Label
				{
					Size = new Size(Main.Height/4, Main.Height/4),
					Left = Main.Width - Main.Height/4,
					Top = (i)*Main.Height/4,
					BorderStyle = BorderStyle.FixedSingle
				};
				Controls.Add(borders[i + 8]);
			}
		}
		private void PictureInit()
		{
			settingRockets = new PictureBox
			{
				Location = new Point(Main.Height/4 + 50, Main.Height/36*31),
				Size = new Size(50, 50),
				Image = Resources.Rocket,
				SizeMode = PictureBoxSizeMode.StretchImage,
				BackColor = Color.Transparent
			};
			Controls.Add(settingRockets);
			settingRockets.MouseClick += SettingRockets_MouseClick;

			for (var i = 0; i < 12; i++)
			{
				planets[i] = new PictureBox
				{
					Size = new Size( 70,70),
					Location = new Point((int)(Main .Width / 2 - Main.Height / 8 - Cos(PI / 6 * (i + 4)) * 285 - 35),
												(int)(Main.Height / 2 + 40 - Sin(PI / 6 * (i + 4)) * 285 - 35)),
					BackColor = Color.Transparent,
					SizeMode = PictureBoxSizeMode.StretchImage
				};
				Controls.Add(planets[i]);
				for (var j = 0; j < 3; j++)
				{
					alienImages[i, j] = new PictureBox
					{
						Height = 50,
						Width = 50,
						Location = new Point(Main.Width / 2 - Main.Height / 8 - (int)(Cos(PI / 6 * (i + 4) + (j - 1) * PI / 20) * 365) - 25,
													Main.Height / 2 + 40 - (int)(Sin(PI / 6 * (i + 4) + (j - 1) * PI / 20) * 365) - 25),
						BackColor = Color.Transparent,
						SizeMode = PictureBoxSizeMode.StretchImage
					};
					Controls.Add(alienImages[i, j]);
				}
			}
			planets[0].Image = Resources.Planet1;
			planets[1].Image = Resources.Planet2;
			planets[2].Image = Resources.Planet3;
			planets[3].Image = Resources.Planet4;
			planets[4].Image = Resources.Planet5;
			planets[5].Image = Resources.Planet6;
			planets[6].Image = Resources.Planet7;
			planets[7].Image = Resources.Planet8;
			planets[8].Image = Resources.Planet9;
			planets[9].Image = Resources.Planet10;
			planets[10].Image = Resources.Planet11;
			planets[11].Image = Resources.Planet12;
		}

		private void SettingRockets_MouseClick(object sender, MouseEventArgs e)
		{
			Settings.Show();	
			Settings.BringToFront();
		}

		public void TeamIntialization()
		{
			for (int i = 0; i < 12; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Teams[i].Aliens[j].Image = alienImages[i, j];
					Teams[i].Aliens[j].CareerLabel  = alienLabels[i, j];
					Teams[i].Aliens[j].PointsLabel = pointLabels[i, j];
					Teams[i].Aliens [j].FinishInit();
				}
				
			}
		}

		//Event Handlers
		private void CurrentTime_Tick(object sender,EventArgs e)
		{
			time.Text = DateTime.Now.ToShortTimeString();
		}
	}
}
