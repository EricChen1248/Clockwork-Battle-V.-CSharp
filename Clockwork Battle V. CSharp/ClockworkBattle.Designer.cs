namespace Clockwork_Battle_V.CSharp
{
    partial class ClockworkBattle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
			this.components = new System.ComponentModel.Container();
			this.lockBtn = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lockBtn
			// 
			this.lockBtn.Font = new System.Drawing.Font("Segoe Print", 12.11881F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lockBtn.Location = new System.Drawing.Point(77, 221);
			this.lockBtn.Name = "lockBtn";
			this.lockBtn.Size = new System.Drawing.Size(208, 40);
			this.lockBtn.TabIndex = 0;
			this.lockBtn.Text = "Lock and Maximize";
			this.lockBtn.UseVisualStyleBackColor = true;
			this.lockBtn.Click += new System.EventHandler(this.lockBtn_Click);
			// 
			// ClockworkBattle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Clockwork_Battle_V.CSharp.Properties.Resources.Background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(284, 260);
			this.Controls.Add(this.lockBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ClockworkBattle";
			this.ShowIcon = false;
			this.Text = "Clockwork Battle";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lockBtn;
		private System.Windows.Forms.Timer timer1;
	}
}

