using System;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
	// Token: 0x02000009 RID: 9
	internal static class Program
	{
		// Token: 0x06000045 RID: 69 RVA: 0x000056C4 File Offset: 0x000038C4
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Main());
		}
	}
}
