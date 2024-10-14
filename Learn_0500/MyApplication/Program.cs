namespace MyApplication;

internal static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		System.Windows.Forms.Application.Run(new MainForm());
	}
}
