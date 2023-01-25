using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Gudgudak_Roblox_Executor
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : Form
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000035E9 File Offset: 0x000017E9
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003601 File Offset: 0x00001801
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003604 File Offset: 0x00001804
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003607 File Offset: 0x00001807
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000360A File Offset: 0x0000180A
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/unuAr8JhxQ");
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003618 File Offset: 0x00001818
		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Thank you for choosing Gudgudak Roblox Executor! This is a free executor, if you see someone selling this executor, please report it immediately to Martinko_Ezz#9973 on discord. GL HF!");
			base.Hide();
			Form1 Form = new Form1();
			Form.Show();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003645 File Offset: 0x00001845
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("https://gudgudakcheats.tk/");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003653 File Offset: 0x00001853
		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000365C File Offset: 0x0000185C
		private void button5_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003667 File Offset: 0x00001867
		private void Form2_Load(object sender, EventArgs e)
		{
		}
	}
}
