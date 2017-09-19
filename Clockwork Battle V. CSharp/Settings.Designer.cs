using System.ComponentModel;
using System.Windows.Forms;

namespace Clockwork_Battle_V.CSharp
{
	partial class Settings
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
			this.TitleLabel = new System.Windows.Forms.Label();
			this.CloseBtn = new System.Windows.Forms.Label();
			this.SaveBtn = new System.Windows.Forms.Label();
			this.Background = new System.Windows.Forms.Label();
			this.LoadBtn = new System.Windows.Forms.Label();
			this.InitBtn = new System.Windows.Forms.Label();
			this.RndBtn = new System.Windows.Forms.Label();
			this.StatsBtn = new System.Windows.Forms.Label();
			this.QuitBtn = new System.Windows.Forms.Label();
			this.BreakfastBtn = new System.Windows.Forms.Label();
			this.LunchBtn = new System.Windows.Forms.Label();
			this.DinnerBtn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(0, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(341, 35);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "設定";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
			this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseMove);
			this.TitleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseUp);
			// 
			// CloseBtn
			// 
			this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.CloseBtn.Font = new System.Drawing.Font("Webdings", 19.9604F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.CloseBtn.ForeColor = System.Drawing.Color.White;
			this.CloseBtn.Location = new System.Drawing.Point(309, 2);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(30, 30);
			this.CloseBtn.TabIndex = 1;
			this.CloseBtn.Text = "r";
			this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// SaveBtn
			// 
			this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.SaveBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SaveBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.SaveBtn.ForeColor = System.Drawing.Color.White;
			this.SaveBtn.Location = new System.Drawing.Point(40, 58);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(61, 43);
			this.SaveBtn.TabIndex = 2;
			this.SaveBtn.Text = "儲存";
			this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// Background
			// 
			this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Background.Location = new System.Drawing.Point(0, 0);
			this.Background.Name = "Background";
			this.Background.Size = new System.Drawing.Size(341, 382);
			this.Background.TabIndex = 3;
			// 
			// LoadBtn
			// 
			this.LoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.LoadBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LoadBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LoadBtn.ForeColor = System.Drawing.Color.White;
			this.LoadBtn.Location = new System.Drawing.Point(139, 58);
			this.LoadBtn.Name = "LoadBtn";
			this.LoadBtn.Size = new System.Drawing.Size(61, 43);
			this.LoadBtn.TabIndex = 4;
			this.LoadBtn.Text = "載入";
			this.LoadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
			// 
			// InitBtn
			// 
			this.InitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.InitBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.InitBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.InitBtn.ForeColor = System.Drawing.Color.White;
			this.InitBtn.Location = new System.Drawing.Point(40, 131);
			this.InitBtn.Name = "InitBtn";
			this.InitBtn.Size = new System.Drawing.Size(61, 43);
			this.InitBtn.TabIndex = 5;
			this.InitBtn.Text = "初始";
			this.InitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.InitBtn.Click += new System.EventHandler(this.InitBtn_Click);
			// 
			// RndBtn
			// 
			this.RndBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.RndBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.RndBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.RndBtn.ForeColor = System.Drawing.Color.White;
			this.RndBtn.Location = new System.Drawing.Point(139, 131);
			this.RndBtn.Name = "RndBtn";
			this.RndBtn.Size = new System.Drawing.Size(61, 43);
			this.RndBtn.TabIndex = 6;
			this.RndBtn.Text = "隨機";
			this.RndBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RndBtn.Click += new System.EventHandler(this.RndBtn_Click);
			// 
			// StatsBtn
			// 
			this.StatsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.StatsBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StatsBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.StatsBtn.ForeColor = System.Drawing.Color.White;
			this.StatsBtn.Location = new System.Drawing.Point(40, 200);
			this.StatsBtn.Name = "StatsBtn";
			this.StatsBtn.Size = new System.Drawing.Size(61, 43);
			this.StatsBtn.TabIndex = 7;
			this.StatsBtn.Text = "數值";
			this.StatsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.StatsBtn.Click += new System.EventHandler(this.StatsBtn_Click);
			// 
			// QuitBtn
			// 
			this.QuitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.QuitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.QuitBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.QuitBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.QuitBtn.ForeColor = System.Drawing.Color.White;
			this.QuitBtn.Location = new System.Drawing.Point(223, 339);
			this.QuitBtn.Name = "QuitBtn";
			this.QuitBtn.Size = new System.Drawing.Size(118, 43);
			this.QuitBtn.TabIndex = 8;
			this.QuitBtn.Text = "關閉程式";
			this.QuitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
			// 
			// BreakfastBtn
			// 
			this.BreakfastBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.BreakfastBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BreakfastBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.BreakfastBtn.ForeColor = System.Drawing.Color.White;
			this.BreakfastBtn.Location = new System.Drawing.Point(40, 131);
			this.BreakfastBtn.Name = "BreakfastBtn";
			this.BreakfastBtn.Size = new System.Drawing.Size(61, 43);
			this.BreakfastBtn.TabIndex = 9;
			this.BreakfastBtn.Text = "早餐";
			this.BreakfastBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BreakfastBtn.Visible = false;
			// 
			// LunchBtn
			// 
			this.LunchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.LunchBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LunchBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LunchBtn.ForeColor = System.Drawing.Color.White;
			this.LunchBtn.Location = new System.Drawing.Point(139, 131);
			this.LunchBtn.Name = "LunchBtn";
			this.LunchBtn.Size = new System.Drawing.Size(61, 43);
			this.LunchBtn.TabIndex = 10;
			this.LunchBtn.Text = "午餐";
			this.LunchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LunchBtn.Visible = false;
			// 
			// DinnerBtn
			// 
			this.DinnerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			this.DinnerBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.DinnerBtn.Font = new System.Drawing.Font("Microsoft JhengHei", 15.68317F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.DinnerBtn.ForeColor = System.Drawing.Color.White;
			this.DinnerBtn.Location = new System.Drawing.Point(238, 131);
			this.DinnerBtn.Name = "DinnerBtn";
			this.DinnerBtn.Size = new System.Drawing.Size(61, 43);
			this.DinnerBtn.TabIndex = 11;
			this.DinnerBtn.Text = "晚餐";
			this.DinnerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.DinnerBtn.Visible = false;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Clockwork_Battle_V.CSharp.Properties.Resources.Background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(341, 382);
			this.ControlBox = false;
			this.Controls.Add(this.DinnerBtn);
			this.Controls.Add(this.LunchBtn);
			this.Controls.Add(this.BreakfastBtn);
			this.Controls.Add(this.QuitBtn);
			this.Controls.Add(this.StatsBtn);
			this.Controls.Add(this.RndBtn);
			this.Controls.Add(this.InitBtn);
			this.Controls.Add(this.LoadBtn);
			this.Controls.Add(this.SaveBtn);
			this.Controls.Add(this.CloseBtn);
			this.Controls.Add(this.TitleLabel);
			this.Controls.Add(this.Background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Settings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);

		}

		#endregion

		private Label TitleLabel;
		private Label CloseBtn;
		private Label SaveBtn;
		private Label Background;
		private Label LoadBtn;
		private Label InitBtn;
		private Label RndBtn;
		private Label StatsBtn;
		private Label QuitBtn;
		private Label BreakfastBtn;
		private Label LunchBtn;
		private Label DinnerBtn;
	}
}