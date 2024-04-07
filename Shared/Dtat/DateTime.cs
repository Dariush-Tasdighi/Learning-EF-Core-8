using System;
using System.Threading;
using System.Globalization;

namespace Dtat;

public static class DateTime : object
{
	static DateTime()
	{
	}

	/// <summary>
	/// https://nwb.one/blog/difference-between-datetime-now-utcnow
	/// https://learn.microsoft.com/en-us/dotnet/standard/datetime/converting-between-datetime-and-offset
	/// </summary>
	public static DateTimeOffset Now
	{
		get
		{
			//return System.DateTime.Now;

			//return System.DateTime.UtcNow;

			var currentCulture =
				Thread.CurrentThread.CurrentCulture;

			var currentUICulture =
				Thread.CurrentThread.CurrentUICulture;

			var englishCulture =
				new CultureInfo(name: "en-US");

			Thread.CurrentThread.CurrentCulture = englishCulture;
			Thread.CurrentThread.CurrentUICulture = englishCulture;

			var result = DateTime.Now;
			//var result = DateTime.UtcNow;

			Thread.CurrentThread.CurrentCulture = currentCulture;
			Thread.CurrentThread.CurrentUICulture = currentUICulture;

			return result;
		}
	}
}
