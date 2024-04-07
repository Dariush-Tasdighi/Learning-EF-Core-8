using System;

namespace Dtat;

public static class PersianDateExtensions : object
{
	static PersianDateExtensions()
	{
	}

	public static PersianDate ToPersianDate(this DateTimeOffset value)
	{
		var result =
			new PersianDate(dateTime: value);

		return result;
	}

	public static PersianDateTime ToPersianDateTime(this DateTimeOffset value)
	{
		var result =
			new PersianDateTime(dateTime: value);

		return result;
	}
}
