using System;
using System.Windows.Forms;

namespace Gudgudak_Roblox_Executor
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00003D22 File Offset: 0x00001F22
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form2());
		}
	}
}
