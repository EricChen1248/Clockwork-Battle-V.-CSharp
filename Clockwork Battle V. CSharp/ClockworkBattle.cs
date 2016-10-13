using System.Windows.Forms;
using SaveSystem;

namespace Clockwork_Battle_V.CSharp
{
    public partial class ClockworkBattle : Form
    {
	    public Control.ControlCollection IncidentControls;
	    public SaveFile Save;
	    private GameBase background;
		public ClockworkBattle()
        {
            InitializeComponent();
        }

	   
		private void lockBtn_Click(object sender, System.EventArgs e)
		{
			Text = "";
			ControlBox = false;
			Controls.Remove(lockBtn );
			WindowState = FormWindowState.Maximized;
			Base.Main = this;
			background = new GameBase();

			//Initialization Missing.
		}

	}
}
