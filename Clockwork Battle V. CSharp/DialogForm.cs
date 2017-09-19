using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clockwork_Battle_V.CSharp
{
	public partial class DialogForm : Form
	{
		private bool drag;
		private int mouseX;
		private int mouseY;
		private static int _buttonID;

		private static DialogForm _dialog;

		public DialogForm()
		{
			InitializeComponent();
		}

		public static bool YesNo(string title, string description, string yes = "Yes", string no = "No")
		{
			_dialog = new DialogForm();
			TitleLabel.Text = title;
			Description.Text = description;

			AnswerPnl.ColumnCount = 2;
			AnswerPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			AnswerPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			var yesLbl  = new Label
			{
				BackColor = Color.Transparent,
				Font = new Font("Microsoft Jhenghei", 19, FontStyle.Bold),
				ForeColor = Color.White,
				Text = yes,
				BorderStyle = BorderStyle.FixedSingle,
				Dock = DockStyle.Fill ,
				TextAlign = ContentAlignment.MiddleCenter 
			};
			AnswerPnl.Controls.Add(yesLbl);
			yesLbl.Click += IDOne;

			var noLbl = new Label
			{
				BackColor = Color.Transparent,
				Font = new Font("Microsoft Jhenghei", 19, FontStyle.Bold),
				ForeColor = Color.White,
				Text = no,
				BorderStyle = BorderStyle.FixedSingle,
				Dock = DockStyle.Fill,
				TextAlign = ContentAlignment.MiddleCenter
			};
			AnswerPnl.Controls.Add(noLbl);
			noLbl.Click += IDTwo;

			_dialog.ShowDialog();
			return _buttonID == 1;
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

		private static void IDOne(object sender, EventArgs e)
		{
			_buttonID = 1;
			_dialog.Dispose();
		}
		private static void IDTwo(object sender, EventArgs e)
		{
			_buttonID = 2;
			_dialog.Dispose();
		}
	}
}