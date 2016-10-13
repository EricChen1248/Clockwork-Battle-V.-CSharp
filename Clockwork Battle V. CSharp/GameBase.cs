
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security;
using System.Windows.Forms;
using Clockwork_Battle_V.CSharp.Classes;
using Clockwork_Battle_V.CSharp.Properties;
using static System.Math;

namespace Clockwork_Battle_V.CSharp
{
	internal class GameBase : Base
	{
		//Controls
		private readonly Label[] borders = new Label[13];
		private readonly Label[] teamLabels = new Label[13];

		private PictureBox settingRockets;
		private PictureBox[] planets = new PictureBox[12];
		private PictureBox[,] alienImages = new PictureBox[12,3];
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
			PictureInit();
			
			foreach (var control in Controls)	
				control.BackColor = Color.FromArgb(150, 130, 130, 130);
		}
		private void TitleInit()
		{
			title = new Label()
			{
				AutoSize = true,
				Text = "鐘點戰",
				Left = (Main.Width / 2 - Main.Height / 8) - 70,
				Top = 10,
				Font = new Font("Microsoft JhengHei", 30),
				ForeColor = Color.White,
			};
			Controls.Add(title);

			time = new Label()
			{
				AutoSize = true,
				Left = (Main.Width / 2 - Main.Height / 8) - 50,
				Text = DateTime.Now.ToShortTimeString(),
				Top = 60,
				Font = new Font("Microsoft JhengHei", 15),
				ForeColor = Color.White,
			};
			Controls.Add(time);
			
			borders[12] = new Label
			{
				Size = new Size(Main.Width - Main.Height / 4 * 3, Main.Height / 12),
				Left = Main.Height / 4,
				Top = 0,
				BorderStyle = BorderStyle.FixedSingle,
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
					BorderStyle = BorderStyle.FixedSingle,
				};
				Controls.Add(borders[i]);

				borders[i + 4] = new Label
				{
					Size = new Size(Main.Height/4, Main.Height/4),
					Left = Main.Width - Main.Height/2,
					Top = (i)*Main.Height/4,
					BorderStyle = BorderStyle.FixedSingle,
				};
				Controls.Add(borders[i + 4]);

				borders[i + 8] = new Label
				{
					Size = new Size(Main.Height/4, Main.Height/4),
					Left = Main.Width - Main.Height/4,
					Top = (i)*Main.Height/4,
					BorderStyle = BorderStyle.FixedSingle,
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

			for (var i = 0; i < 12; i++)
			{
				planets[i] = new PictureBox
				{
					Size = new Size( 70,70),
					Location = new Point(Main .Width / 2 - Main.Height / 8 - (int)Cos(PI / 6 * (i + 4)) * 285 - 35, 
												Main.Height / 2 + 40 - (int)Sin(PI / 6 * (i + 4)) * 285 - 35),
					BackColor = Color.Transparent,
					SizeMode = PictureBoxSizeMode.StretchImage
				};
				Controls.Add(planets[i]);
				for (var j = 0; j < 3; j++)
				{
					alienImages[i, j] = new PictureBox
					{
						Height = 50																						  ,
						Width = 50																						 ,
						Location = new Point(Main.Width / 2 - Main.Height / 8 - (int)Cos(PI / 6 * (i + 4) + (j - 1) * PI / 20) * 365 - 25,
													Main.Height / 2 + 40 - (int)Sin(PI / 6 * (i + 4) + (j - 1) * PI / 20) * 365 - 25),
						BackColor = Color.Transparent																  ,
						SizeMode = PictureBoxSizeMode.StretchImage
					};
					Controls.Add(alienImages[i, j]);
				}
			}
		}

		private void TeamIntialization()
		{
			foreach (var team in Teams)
			{
				//team = new Team();
			}
		}

		//Event Handlers
		private void CurrentTime_Tick(object sender,EventArgs e)
		{
			time.Text = DateTime.Now.ToShortTimeString();
		}
	}
}
