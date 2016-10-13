namespace Clockwork_Battle_V.CSharp.Classes
{
	class Team
	{
		public Alien[] Aliens = new Alien[3];

		public Team(Alien.Careers career0, Alien.Careers career1, Alien.Careers  career2)
		{
			Aliens[0] = new Alien(career0, this);
			Aliens[1] = new Alien(career1, this);
			Aliens[2] = new Alien(career2, this);
			IsReporter() ;
		}

		private void IsReporter()
		{
			foreach (var alien in Aliens)
				if (alien.Career == Alien.Careers.Reporter )
					foreach (var alien1 in Aliens)
						if (alien1 != alien)
							alien1.Reporter = alien;
		}
	}
}
