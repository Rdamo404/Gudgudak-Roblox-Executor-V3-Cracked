using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace Gudgudak_Roblox_Executor
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002073 File Offset: 0x00000273
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002076 File Offset: 0x00000276
		private void fastColoredTextBox1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002079 File Offset: 0x00000279
		private void button2_Click(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Clear();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002088 File Offset: 0x00000288
		private void button1_Click(object sender, EventArgs e)
		{
			this.module.SendLuaScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020A2 File Offset: 0x000002A2
		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020A5 File Offset: 0x000002A5
		private void button3_Click(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020B4 File Offset: 0x000002B4
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020B7 File Offset: 0x000002B7
		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020BA File Offset: 0x000002BA
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020BD File Offset: 0x000002BD
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020C0 File Offset: 0x000002C0
		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020C3 File Offset: 0x000002C3
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020C6 File Offset: 0x000002C6
		private void button4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020C9 File Offset: 0x000002C9
		private void textBox1_TextChanged_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020CC File Offset: 0x000002CC
		private void textBox4_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020CF File Offset: 0x000002CF
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020D2 File Offset: 0x000002D2
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020D8 File Offset: 0x000002D8
		private void button5_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter sw = new StreamWriter(s))
					{
						sw.Write(this.fastColoredTextBox1.Text);
					}
				}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000215C File Offset: 0x0000035C
		private void button7_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002167 File Offset: 0x00000367
		private void button6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002170 File Offset: 0x00000370
		private void button4_Click_2(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021B6 File Offset: 0x000003B6
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021D0 File Offset: 0x000003D0
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002231 File Offset: 0x00000431
		private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002234 File Offset: 0x00000434
		private void button11_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.mastersmzscripts.com/forum/mastersmz-scripts");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002242 File Offset: 0x00000442
		private void button10_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=YZ37CkMy7XQ");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002250 File Offset: 0x00000450
		private void button9_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/unuAr8JhxQ");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000225E File Offset: 0x0000045E
		private void button8_Click(object sender, EventArgs e)
		{
			Process.Start("https://gudgudakcheats.tk/");
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000226C File Offset: 0x0000046C
		private void button12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000226F File Offset: 0x0000046F
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private ExploitAPI module = new ExploitAPI();

		// Token: 0x04000002 RID: 2
		private Point lastPoint;
	}
}
