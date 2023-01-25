namespace Gudgudak_Roblox_Executor
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x0000366C File Offset: 0x0000186C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000036A4 File Offset: 0x000018A4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Gudgudak_Roblox_Executor.Form2));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label1.Location = new global::System.Drawing.Point(149, 51);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(98, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label2.Location = new global::System.Drawing.Point(84, 71);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(236, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "GudgudakCheats";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new global::System.Drawing.Point(71, 115);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(264, 44);
			this.button1.TabIndex = 2;
			this.button1.Text = "Launch Gudgudak Roblox Executor\r\n";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new global::System.Drawing.Point(71, 182);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(264, 44);
			this.button2.TabIndex = 3;
			this.button2.Text = "Join Discord Server";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new global::System.Drawing.Point(71, 249);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(264, 44);
			this.button3.TabIndex = 5;
			this.button3.Text = "Official Website";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Segoe Print", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button4.Location = new global::System.Drawing.Point(375, 6);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(41, 33);
			this.button4.TabIndex = 6;
			this.button4.Text = "X";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new global::System.Drawing.Font("Segoe Print", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button5.Location = new global::System.Drawing.Point(343, 6);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(36, 33);
			this.button5.TabIndex = 7;
			this.button5.Text = "-";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(414, 328);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gudgudak Home";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001A RID: 26
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button button5;
	}
}
