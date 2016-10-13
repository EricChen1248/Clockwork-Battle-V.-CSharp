using System;
using System.Drawing;
using System.Windows.Forms;
using Clockwork_Battle_V.CSharp.Properties;

namespace Clockwork_Battle_V.CSharp.Classes
{
	/// <summary>
	/// Base class for all Aliens. Initialize first then finish up with method FinshInit();
	/// </summary>
	internal class Alien
	{
		public static GameBase GameBase;

		private const decimal DoctorMultiplier = 0.05M;
		private const decimal ReporterMultiplier = 0.1M;

		private readonly Team team;
		
		public Careers Career { get; }
		public IsKing King { get; set; }
		public Alien Reporter { private get; set; }
		public decimal Points { get; private set; }
		public decimal Multiplier { get; private set; }
		public int ID { get; set; }

		public Label CareerLabel { private get; set; }
		public Label PointsLabel { private get; set; }
		public PictureBox image { private get; set; }


		public Alien(Careers career,Team team)
		{
			Career = career;
			this.team = team;
		}
		
		//Interface
		public void AddPoints(decimal points)
		{
			Points += points*Multiplier;
			CheckKing();
			CheckSkill();
			DoctorSkill(points);
			ReporterSkill(points);
			UpdateLabels();
			// Implementation Missing
		}
		public void DirectAdd(decimal points)
		{
			Points += Multiplier*points;
			CheckKing();
			CheckSkill();
		}
		public void FinishInit()
		{
			CareerLabel.Text = ChineseCareers();
			UpdateLabels();
			image.Image = DeterminePic();
		}


		//Private Methods
		private Image DeterminePic()
		{
			switch (Career)
			{
				case Careers.Doctor:
					return Resources.Doctor;
				case Careers.Accountant:
					return Resources.Accountant;
				case Careers.Senator:
					return Resources.Senator;
				case Careers.Builder:
					return Resources.Builder;
				case Careers.Programmer:
					return Resources.Programmer;
				case Careers.Reporter:
					return Resources.Reporter;
				default:
					return null;
			}
		}

		private void UpdateLabels()
		{
			PointsLabel.Text = ((int) Points).ToString( );
		}
		private void CheckSkill()
		{
			if (Career == Careers.Programmer)
				Multiplier *= 4 / 3M;
			if (Career == Careers.Builder)
				Multiplier *= 3 / 4M;
		}
		private void CheckKing()
		{
			if (King != IsKing.Undetermined) return;
			if (Points <= 300) return;
			King = IsKing.King;
			CareerLabel.Text = @"♔" + ChineseCareers();
			foreach (var alien in GameBase.AlienCareers[(int)Career])
			{
				alien.King = IsKing.NotKing;
				alien.Multiplier *= 0.85M;
				//Kick off Event;
			}
		}

		private void DoctorSkill(decimal points)
		{
			if (Career != Careers.Doctor) return;
			for (var i = 0; i < 3; i++)
			{
				Alien alien;
				if ((alien = team.Aliens[i]) != this)
					alien.DirectAdd(points * DoctorMultiplier);
			}
		}
		private void ReporterSkill(decimal points)
		{
			Reporter?.DirectAdd(points*ReporterMultiplier);
		}

		//Helper Methods
		private string ChineseCareers()
		{
			switch (Career)
			{
				case Careers.Doctor:
					return "醫師";
				case Careers.Accountant:
					return "會計師";
				case Careers.Senator:
					return "立委";
				case Careers.Builder:
					return "建築師";
				case Careers.Programmer:
					return "電腦工程師";
				case Careers.Reporter:
					return "記者";
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		//Enums
		public enum IsKing
		{
			Undetermined,
			King,
			NotKing
		}
		public enum Careers
		{
			Doctor,
			Accountant,
			Senator,
			Builder,
			Programmer,
			Reporter
		}
		
	}
}
