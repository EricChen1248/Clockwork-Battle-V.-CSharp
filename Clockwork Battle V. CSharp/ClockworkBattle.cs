using System;
using System.Windows.Forms;
using SaveSystem;

namespace Clockwork_Battle_V.CSharp
{
    public partial class ClockworkBattle : Form
    {
	    public Control.ControlCollection IncidentControls;
	    public SaveFile Save;
	    private GameBase gameBase;
		private Settings settings;
		public ClockworkBattle()
        {
            InitializeComponent();
        }

	   
		private void lockBtn_Click(object sender, EventArgs e)
		{
			Text = "";
			ControlBox = false;
			Controls.Remove(lockBtn );
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Maximized;
			Base.Main = this;
			gameBase  = new GameBase();	   
			settings = new Settings();		    
			Base.GameBase = gameBase;
			Base.Settings = settings;
			TeamSelection.GameBase = gameBase;
			Settings.GameBase = gameBase;

			//Initialization Missing.
		}

	}
}
