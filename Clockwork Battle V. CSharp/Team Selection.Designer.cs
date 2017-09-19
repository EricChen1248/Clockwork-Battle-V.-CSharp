using System.ComponentModel;
using System.Windows.Forms;

namespace Clockwork_Battle_V.CSharp
{
	partial class TeamSelection
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
			TitlePanel = new System.Windows.Forms.Panel();
			TitleLabel = new System.Windows.Forms.Label();
			Title = new System.Windows.Forms.Label();
			tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			CancelLabel = new System.Windows.Forms.Label();
			ConfirmLabel = new System.Windows.Forms.Label();
			CareerTabel = new System.Windows.Forms.TableLayoutPanel();
			label20 = new System.Windows.Forms.Label();
			label19 = new System.Windows.Forms.Label();
			label18 = new System.Windows.Forms.Label();
			label17 = new System.Windows.Forms.Label();
			label16 = new System.Windows.Forms.Label();
			label15 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label31 = new System.Windows.Forms.Label();
			label32 = new System.Windows.Forms.Label();
			label33 = new System.Windows.Forms.Label();
			CareerLabel = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			TitlePanel.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			CareerTabel.SuspendLayout();
			SuspendLayout();
			// 
			// TitlePanel
			// 
			TitlePanel.BackColor = System.Drawing.Color.Transparent;
			TitlePanel.Controls.Add(TitleLabel);
			TitlePanel.Controls.Add(Title);
			TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			TitlePanel.Location = new System.Drawing.Point(0, 0);
			TitlePanel.Name = "TitlePanel";
			TitlePanel.Size = new System.Drawing.Size(1096, 40);
			TitlePanel.TabIndex = 1;
			// 
			// TitleLabel
			// 
			TitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			TitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			TitleLabel.ForeColor = System.Drawing.Color.White;
			TitleLabel.Location = new System.Drawing.Point(0, 0);
			TitleLabel.Name = "TitleLabel";
			TitleLabel.Size = new System.Drawing.Size(1096, 40);
			TitleLabel.TabIndex = 2;
			TitleLabel.Text = "職業選取";
			TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			TitleLabel.UseCompatibleTextRendering = true;
			TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(TitleLabel_MouseDown);
			TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(TitleLabel_MouseMove);
			TitleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(TitleLabel_MouseUp);
			// 
			// Title
			// 
			Title.AutoSize = true;
			Title.BackColor = System.Drawing.Color.Transparent;
			Title.Location = new System.Drawing.Point(0, 0);
			Title.Name = "Title";
			Title.Size = new System.Drawing.Size(41, 15);
			Title.TabIndex = 0;
			Title.Text = "label1";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(CancelLabel, 0, 0);
			tableLayoutPanel2.Controls.Add(ConfirmLabel, 0, 0);
			tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			tableLayoutPanel2.Location = new System.Drawing.Point(0, 448);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
			tableLayoutPanel2.Size = new System.Drawing.Size(1096, 42);
			tableLayoutPanel2.TabIndex = 2;
			// 
			// CancelLabel
			// 
			CancelLabel.BackColor = System.Drawing.Color.Transparent;
			CancelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			CancelLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			CancelLabel.ForeColor = System.Drawing.Color.White;
			CancelLabel.Location = new System.Drawing.Point(551, 1);
			CancelLabel.Name = "CancelLabel";
			CancelLabel.Size = new System.Drawing.Size(541, 40);
			CancelLabel.TabIndex = 4;
			CancelLabel.Text = "取消";
			CancelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			CancelLabel.UseCompatibleTextRendering = true;
			CancelLabel.Click += new System.EventHandler(CancelLabel_Click);
			// 
			// ConfirmLabel
			// 
			ConfirmLabel.BackColor = System.Drawing.Color.Transparent;
			ConfirmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			ConfirmLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			ConfirmLabel.ForeColor = System.Drawing.Color.White;
			ConfirmLabel.Location = new System.Drawing.Point(4, 1);
			ConfirmLabel.Name = "ConfirmLabel";
			ConfirmLabel.Size = new System.Drawing.Size(540, 40);
			ConfirmLabel.TabIndex = 3;
			ConfirmLabel.Text = "確認";
			ConfirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			ConfirmLabel.UseCompatibleTextRendering = true;
			ConfirmLabel.Click += new System.EventHandler(ConfirmLabel_Click);
			// 
			// CareerTabel
			// 
			CareerTabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
			CareerTabel.ColumnCount = 13;
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
			CareerTabel.Controls.Add(label20, 11, 0);
			CareerTabel.Controls.Add(label19, 10, 0);
			CareerTabel.Controls.Add(label18, 9, 0);
			CareerTabel.Controls.Add(label17, 8, 0);
			CareerTabel.Controls.Add(label16, 7, 0);
			CareerTabel.Controls.Add(label15, 6, 0);
			CareerTabel.Controls.Add(label14, 5, 0);
			CareerTabel.Controls.Add(label13, 4, 0);
			CareerTabel.Controls.Add(label12, 3, 0);
			CareerTabel.Controls.Add(label11, 2, 0);
			CareerTabel.Controls.Add(label10, 1, 0);
			CareerTabel.Controls.Add(label8, 0, 6);
			CareerTabel.Controls.Add(label1, 0, 0);
			CareerTabel.Controls.Add(label9, 0, 2);
			CareerTabel.Controls.Add(label31, 0, 3);
			CareerTabel.Controls.Add(label32, 0, 4);
			CareerTabel.Controls.Add(label33, 0, 5);
			CareerTabel.Controls.Add(CareerLabel, 0, 1);
			CareerTabel.Controls.Add(label3, 12, 0);
			CareerTabel.Dock = System.Windows.Forms.DockStyle.Fill;
			CareerTabel.Location = new System.Drawing.Point(0, 40);
			CareerTabel.Name = "CareerTabel";
			CareerTabel.RowCount = 7;
			CareerTabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			CareerTabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			CareerTabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			CareerTabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			CareerTabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			CareerTabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			CareerTabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
			CareerTabel.Size = new System.Drawing.Size(1096, 408);
			CareerTabel.TabIndex = 3;
			// 
			// label20
			// 
			label20.BackColor = System.Drawing.Color.Transparent;
			label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label20.Dock = System.Windows.Forms.DockStyle.Fill;
			label20.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label20.ForeColor = System.Drawing.Color.White;
			label20.Location = new System.Drawing.Point(943, 0);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(70, 58);
			label20.TabIndex = 20;
			label20.Text = "十一";
			label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label20.UseCompatibleTextRendering = true;
			// 
			// label19
			// 
			label19.BackColor = System.Drawing.Color.Transparent;
			label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label19.Dock = System.Windows.Forms.DockStyle.Fill;
			label19.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label19.ForeColor = System.Drawing.Color.White;
			label19.Location = new System.Drawing.Point(867, 0);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(70, 58);
			label19.TabIndex = 19;
			label19.Text = "十";
			label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label19.UseCompatibleTextRendering = true;
			// 
			// label18
			// 
			label18.BackColor = System.Drawing.Color.Transparent;
			label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label18.Dock = System.Windows.Forms.DockStyle.Fill;
			label18.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label18.ForeColor = System.Drawing.Color.White;
			label18.Location = new System.Drawing.Point(791, 0);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(70, 58);
			label18.TabIndex = 18;
			label18.Text = "九";
			label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label18.UseCompatibleTextRendering = true;
			// 
			// label17
			// 
			label17.BackColor = System.Drawing.Color.Transparent;
			label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label17.Dock = System.Windows.Forms.DockStyle.Fill;
			label17.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label17.ForeColor = System.Drawing.Color.White;
			label17.Location = new System.Drawing.Point(715, 0);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(70, 58);
			label17.TabIndex = 17;
			label17.Text = "八";
			label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label17.UseCompatibleTextRendering = true;
			// 
			// label16
			// 
			label16.BackColor = System.Drawing.Color.Transparent;
			label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label16.Dock = System.Windows.Forms.DockStyle.Fill;
			label16.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label16.ForeColor = System.Drawing.Color.White;
			label16.Location = new System.Drawing.Point(639, 0);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(70, 58);
			label16.TabIndex = 16;
			label16.Text = "七";
			label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label16.UseCompatibleTextRendering = true;
			// 
			// label15
			// 
			label15.BackColor = System.Drawing.Color.Transparent;
			label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label15.Dock = System.Windows.Forms.DockStyle.Fill;
			label15.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label15.ForeColor = System.Drawing.Color.White;
			label15.Location = new System.Drawing.Point(563, 0);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(70, 58);
			label15.TabIndex = 15;
			label15.Text = "六";
			label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label15.UseCompatibleTextRendering = true;
			// 
			// label14
			// 
			label14.BackColor = System.Drawing.Color.Transparent;
			label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label14.Dock = System.Windows.Forms.DockStyle.Fill;
			label14.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label14.ForeColor = System.Drawing.Color.White;
			label14.Location = new System.Drawing.Point(487, 0);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(70, 58);
			label14.TabIndex = 14;
			label14.Text = "五";
			label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label14.UseCompatibleTextRendering = true;
			// 
			// label13
			// 
			label13.BackColor = System.Drawing.Color.Transparent;
			label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label13.Dock = System.Windows.Forms.DockStyle.Fill;
			label13.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label13.ForeColor = System.Drawing.Color.White;
			label13.Location = new System.Drawing.Point(411, 0);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(70, 58);
			label13.TabIndex = 13;
			label13.Text = "四";
			label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label13.UseCompatibleTextRendering = true;
			// 
			// label12
			// 
			label12.BackColor = System.Drawing.Color.Transparent;
			label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label12.Dock = System.Windows.Forms.DockStyle.Fill;
			label12.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label12.ForeColor = System.Drawing.Color.White;
			label12.Location = new System.Drawing.Point(335, 0);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(70, 58);
			label12.TabIndex = 12;
			label12.Text = "三";
			label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label12.UseCompatibleTextRendering = true;
			// 
			// label11
			// 
			label11.BackColor = System.Drawing.Color.Transparent;
			label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label11.Dock = System.Windows.Forms.DockStyle.Fill;
			label11.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label11.ForeColor = System.Drawing.Color.White;
			label11.Location = new System.Drawing.Point(259, 0);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(70, 58);
			label11.TabIndex = 11;
			label11.Text = "二";
			label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label11.UseCompatibleTextRendering = true;
			// 
			// label10
			// 
			label10.BackColor = System.Drawing.Color.Transparent;
			label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label10.Dock = System.Windows.Forms.DockStyle.Fill;
			label10.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label10.ForeColor = System.Drawing.Color.White;
			label10.Location = new System.Drawing.Point(183, 0);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(70, 58);
			label10.TabIndex = 10;
			label10.Text = "一";
			label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label10.UseCompatibleTextRendering = true;
			// 
			// label8
			// 
			label8.BackColor = System.Drawing.Color.Transparent;
			label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label8.Dock = System.Windows.Forms.DockStyle.Fill;
			label8.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label8.ForeColor = System.Drawing.Color.White;
			label8.Location = new System.Drawing.Point(3, 348);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(174, 60);
			label8.TabIndex = 8;
			label8.Text = "會計師";
			label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label8.UseCompatibleTextRendering = true;
			// 
			// label1
			// 
			label1.BackColor = System.Drawing.Color.Transparent;
			label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label1.Dock = System.Windows.Forms.DockStyle.Fill;
			label1.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label1.ForeColor = System.Drawing.Color.White;
			label1.Location = new System.Drawing.Point(3, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(174, 58);
			label1.TabIndex = 2;
			label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label1.UseCompatibleTextRendering = true;
			// 
			// label9
			// 
			label9.BackColor = System.Drawing.Color.Transparent;
			label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label9.Dock = System.Windows.Forms.DockStyle.Fill;
			label9.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label9.ForeColor = System.Drawing.Color.White;
			label9.Location = new System.Drawing.Point(3, 116);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(174, 58);
			label9.TabIndex = 9;
			label9.Text = "醫師";
			label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label9.UseCompatibleTextRendering = true;
			// 
			// label31
			// 
			label31.BackColor = System.Drawing.Color.Transparent;
			label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label31.Dock = System.Windows.Forms.DockStyle.Fill;
			label31.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label31.ForeColor = System.Drawing.Color.White;
			label31.Location = new System.Drawing.Point(3, 174);
			label31.Name = "label31";
			label31.Size = new System.Drawing.Size(174, 58);
			label31.TabIndex = 9;
			label31.Text = "建築師";
			label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label31.UseCompatibleTextRendering = true;
			// 
			// label32
			// 
			label32.BackColor = System.Drawing.Color.Transparent;
			label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label32.Dock = System.Windows.Forms.DockStyle.Fill;
			label32.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label32.ForeColor = System.Drawing.Color.White;
			label32.Location = new System.Drawing.Point(3, 232);
			label32.Name = "label32";
			label32.Size = new System.Drawing.Size(174, 58);
			label32.TabIndex = 9;
			label32.Text = "電腦工程師";
			label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label32.UseCompatibleTextRendering = true;
			// 
			// label33
			// 
			label33.BackColor = System.Drawing.Color.Transparent;
			label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label33.Dock = System.Windows.Forms.DockStyle.Fill;
			label33.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label33.ForeColor = System.Drawing.Color.White;
			label33.Location = new System.Drawing.Point(3, 290);
			label33.Name = "label33";
			label33.Size = new System.Drawing.Size(174, 58);
			label33.TabIndex = 9;
			label33.Text = "立委";
			label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label33.UseCompatibleTextRendering = true;
			// 
			// CareerLabel
			// 
			CareerLabel.BackColor = System.Drawing.Color.Transparent;
			CareerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			CareerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			CareerLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			CareerLabel.ForeColor = System.Drawing.Color.White;
			CareerLabel.Location = new System.Drawing.Point(3, 58);
			CareerLabel.Name = "CareerLabel";
			CareerLabel.Size = new System.Drawing.Size(174, 58);
			CareerLabel.TabIndex = 21;
			CareerLabel.Text = "記者";
			CareerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			CareerLabel.UseCompatibleTextRendering = true;
			// 
			// label3
			// 
			label3.BackColor = System.Drawing.Color.Transparent;
			label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			label3.Dock = System.Windows.Forms.DockStyle.Fill;
			label3.Font = new System.Drawing.Font("Microsoft JhengHei", 20F, System.Drawing.FontStyle.Bold);
			label3.ForeColor = System.Drawing.Color.White;
			label3.Location = new System.Drawing.Point(1019, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(74, 58);
			label3.TabIndex = 20;
			label3.Text = "十二";
			label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			label3.UseCompatibleTextRendering = true;
			// 
			// Team_Selection
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackgroundImage = global::Clockwork_Battle_V.CSharp.Properties.Resources.Background;
			ClientSize = new System.Drawing.Size(1096, 490);
			ControlBox = false;
			Controls.Add(CareerTabel);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(TitlePanel);
			DoubleBuffered = true;
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "TeamSelection";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			TopMost = true;
			TitlePanel.ResumeLayout(false);
			TitlePanel.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			CareerTabel.ResumeLayout(false);
			ResumeLayout(false);

		}

		#endregion
		private Panel TitlePanel;
		private Label Title;
		private TableLayoutPanel tableLayoutPanel2;
		private Label TitleLabel;
		private Label CancelLabel;
		private Label ConfirmLabel;
		private TableLayoutPanel CareerTabel;
		private Label label20;
		private Label label19;
		private Label label18;
		private Label label17;
		private Label label16;
		private Label label15;
		private Label label14;
		private Label label13;
		private Label label12;
		private Label label11;
		private Label label10;
		private Label label8;
		private Label label1;
		private Label label9;
		private Label label31;
		private Label label32;
		private Label label33;
		private Label CareerLabel;
		private Label label3;
	}
}