using System.ComponentModel;
using System.Windows.Forms;

namespace Clockwork_Battle_V.CSharp
{
	partial class DialogForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			TitleLabel = new System.Windows.Forms.Label();
			Description = new System.Windows.Forms.Label();
			Background = new System.Windows.Forms.Label();
			AnswerPnl = new System.Windows.Forms.TableLayoutPanel();
			SuspendLayout();
			// 
			// TitleLabel
			// 
			TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
			TitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			TitleLabel.ForeColor = System.Drawing.Color.White;
			TitleLabel.Location = new System.Drawing.Point(0, 0);
			TitleLabel.Name = "TitleLabel";
			TitleLabel.Size = new System.Drawing.Size(284, 35);
			TitleLabel.TabIndex = 1;
			TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(TitleLabel_MouseDown);
			TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(TitleLabel_MouseMove);
			TitleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(TitleLabel_MouseUp);
			// 
			// Description
			// 
			Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			Description.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			Description.ForeColor = System.Drawing.Color.White;
			Description.Location = new System.Drawing.Point(31, 63);
			Description.Name = "Description";
			Description.Size = new System.Drawing.Size(220, 95);
			Description.TabIndex = 2;
			// 
			// Background
			// 
			Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			Background.Dock = System.Windows.Forms.DockStyle.Fill;
			Background.Location = new System.Drawing.Point(0, 0);
			Background.Name = "Background";
			Background.Size = new System.Drawing.Size(284, 260);
			Background.TabIndex = 3;
			// 
			// AnswerPnl
			// 
			AnswerPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			AnswerPnl.ColumnCount = 1;
			AnswerPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			AnswerPnl.Location = new System.Drawing.Point(3, 203);
			AnswerPnl.Name = "AnswerPnl";
			AnswerPnl.RowCount = 1;
			AnswerPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			AnswerPnl.Size = new System.Drawing.Size(281, 45);
			AnswerPnl.TabIndex = 0;
			// 
			// DialogForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackgroundImage = global::Clockwork_Battle_V.CSharp.Properties.Resources.Background;
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			ClientSize = new System.Drawing.Size(284, 260);
			ControlBox = false;
			Controls.Add(AnswerPnl);
			Controls.Add(Description);
			Controls.Add(TitleLabel);
			Controls.Add(Background);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			Name = "DialogForm";
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			TopMost = true;
			ResumeLayout(false);

		}

		#endregion
		private Label Background;
		private static Label TitleLabel;
		private static Label Description;
		private static TableLayoutPanel AnswerPnl;
	}
}