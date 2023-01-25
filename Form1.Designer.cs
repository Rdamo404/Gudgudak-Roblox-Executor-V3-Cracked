namespace Gudgudak_Roblox_Executor
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002274 File Offset: 0x00000474
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000022AC File Offset: 0x000004AC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Gudgudak_Roblox_Executor.Form1));
			this.fastColoredTextBox1 = new global::FastColoredTextBoxNS.FastColoredTextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip2 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.contextMenuStrip3 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.button5 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button4 = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.button11 = new global::System.Windows.Forms.Button();
			this.button10 = new global::System.Windows.Forms.Button();
			this.button9 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			base.SuspendLayout();
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
			this.fastColoredTextBox1.AutoScrollMinSize = new global::System.Drawing.Size(1011, 18);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.fastColoredTextBox1.CharHeight = 18;
			this.fastColoredTextBox1.CharWidth = 10;
			this.fastColoredTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.fastColoredTextBox1.DisabledColor = global::System.Drawing.Color.FromArgb(100, 180, 180, 180);
			this.fastColoredTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.Location = new global::System.Drawing.Point(158, 62);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new global::System.Windows.Forms.Padding(0);
			this.fastColoredTextBox1.SelectionColor = global::System.Drawing.Color.FromArgb(60, 0, 0, 255);
			this.fastColoredTextBox1.ServiceColors = (global::FastColoredTextBoxNS.ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors");
			this.fastColoredTextBox1.Size = new global::System.Drawing.Size(536, 191);
			this.fastColoredTextBox1.TabIndex = 0;
			this.fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()";
			this.fastColoredTextBox1.Zoom = 100;
			this.fastColoredTextBox1.Load += new global::System.EventHandler(this.fastColoredTextBox1_Load);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new global::System.Drawing.Point(8, 3);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(104, 33);
			this.button1.TabIndex = 1;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(118, 3);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(104, 33);
			this.button2.TabIndex = 2;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button3.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = global::System.Drawing.Color.Transparent;
			this.button3.Location = new global::System.Drawing.Point(668, 3);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(104, 33);
			this.button3.TabIndex = 3;
			this.button3.Text = "Inject";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(61, 4);
			this.contextMenuStrip1.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			this.contextMenuStrip2.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new global::System.Drawing.Size(61, 4);
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "5ce9d0a75a85981f7e3275f2e7204d58.png");
			this.contextMenuStrip3.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.contextMenuStrip3.Name = "contextMenuStrip3";
			this.contextMenuStrip3.Size = new global::System.Drawing.Size(61, 4);
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button5.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = global::System.Drawing.Color.Transparent;
			this.button5.Location = new global::System.Drawing.Point(379, 3);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(104, 33);
			this.button5.TabIndex = 13;
			this.button5.Text = "Save Script";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(-3, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1030, 42);
			this.panel1.TabIndex = 14;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel3.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.panel3.Location = new global::System.Drawing.Point(3, 41);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(70, 100);
			this.panel3.TabIndex = 18;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new global::System.Drawing.Font("Segoe Print", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button7.ForeColor = global::System.Drawing.Color.White;
			this.button7.Location = new global::System.Drawing.Point(701, 0);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(29, 36);
			this.button7.TabIndex = 2;
			this.button7.Text = "-";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new global::System.Drawing.Font("Segoe Print", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button6.ForeColor = global::System.Drawing.Color.White;
			this.button6.Location = new global::System.Drawing.Point(736, 0);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(36, 34);
			this.button6.TabIndex = 1;
			this.button6.Text = "X";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Constantia", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(213, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gudgudak Roblox Executor";
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = global::System.Drawing.Color.Transparent;
			this.button4.Location = new global::System.Drawing.Point(239, 3);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(104, 33);
			this.button4.TabIndex = 15;
			this.button4.Text = "Open Script";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click_2);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button5);
			this.panel2.Location = new global::System.Drawing.Point(-3, 296);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(785, 40);
			this.panel2.TabIndex = 17;
			this.panel4.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.panel4.Controls.Add(this.button11);
			this.panel4.Controls.Add(this.button10);
			this.panel4.Controls.Add(this.button9);
			this.panel4.Controls.Add(this.button8);
			this.panel4.Location = new global::System.Drawing.Point(-3, 39);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(76, 264);
			this.panel4.TabIndex = 18;
			this.button11.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 25.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button11.ForeColor = global::System.Drawing.Color.White;
			this.button11.Location = new global::System.Drawing.Point(3, 7);
			this.button11.Name = "button11";
			this.button11.Size = new global::System.Drawing.Size(75, 67);
			this.button11.TabIndex = 3;
			this.button11.Text = "Ⓢ";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new global::System.EventHandler(this.button11_Click);
			this.button10.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 25.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button10.ForeColor = global::System.Drawing.Color.White;
			this.button10.Location = new global::System.Drawing.Point(8, 71);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(62, 55);
			this.button10.TabIndex = 2;
			this.button10.Text = "?";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new global::System.EventHandler(this.button10_Click);
			this.button9.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 25.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button9.ForeColor = global::System.Drawing.Color.White;
			this.button9.Location = new global::System.Drawing.Point(8, 132);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(65, 60);
			this.button9.TabIndex = 1;
			this.button9.Text = "Ⓓ";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.button8.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 25.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button8.ForeColor = global::System.Drawing.Color.White;
			this.button8.Location = new global::System.Drawing.Point(8, 184);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(65, 67);
			this.button8.TabIndex = 0;
			this.button8.Text = "\ud83c\udf10";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.label2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(250, 254);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(444, 39);
			this.label2.TabIndex = 19;
			this.label2.Text = "This script is example, you can click \"Clear\" button and paste your own script.\r\n\r\n\r\n";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			base.ClientSize = new global::System.Drawing.Size(777, 333);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.fastColoredTextBox1);
			this.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 238);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "Gudgudak Roblox Executor";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip3;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button button9;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button button10;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button11;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label label2;
	}
}
