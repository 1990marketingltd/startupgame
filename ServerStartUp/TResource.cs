using System;
using System.Runtime.InteropServices;

namespace ServerStartUp
{
	public static class TResource
	{
		public static class SW
		{
			public const int SW_HIDE = 0;

			public const int SW_SHOWNORMAL = 1;

			public const int SW_NORMAL = 1;

			public const int SW_SHOWMINIMIZED = 2;

			public const int SW_SHOWMAXIMIZED = 3;

			public const int SW_MAXIMIZE = 3;

			public const int SW_SHOWNOACTIVATE = 4;

			public const int SW_SHOW = 5;

			public const int SW_MINIMIZE = 6;

			public const int SW_SHOWMINNOACTIVE = 7;

			public const int SW_SHOWNA = 8;

			public const int SW_RESTORE = 9;

			public const int SW_SHOWDEFAULT = 10;

			public const int SW_FORCEMINIMIZE = 11;

			public const int SW_MAX = 11;

			[DllImport("user32.dll")]
			public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

			[DllImport("user32.dll")]
			public static extern bool ShowWindow(int hWnd, int nCmdShow);
		}
	}
}
