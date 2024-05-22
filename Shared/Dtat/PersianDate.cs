using System;
using System.Globalization;

namespace Dtat;

public class PersianDate : object
{
	static PersianDate()
	{
		PersianCalendar =
			new PersianCalendar();
	}

	protected static PersianCalendar PersianCalendar { get; }

	public PersianDate(DateTimeOffset dateTime) : base()
	{
		DateTime = dateTime;

		Day = PersianCalendar
			.GetDayOfMonth(time: dateTime.Date);

		Month = PersianCalendar
			.GetMonth(time: dateTime.Date);

		Year = PersianCalendar
			.GetYear(time: dateTime.Date);
	}

	public int Day { get; }

	public int Month { get; }

	public int Year { get; }

	public DateTimeOffset DateTime { get; }

	//public override string ToString()
	//{
	//	return base.ToString();
	//}

	public override string ToString()
	{
		var dayString =
			Day.ToString()
			.PadLeft(totalWidth: 2, paddingChar: '0');

		var monthString =
			Month.ToString()
			.PadLeft(totalWidth: 2, paddingChar: '0');

		var result =
			$"{Year}/{monthString}/{dayString}";

		return result;
	}
}
