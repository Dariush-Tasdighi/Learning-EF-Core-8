using System;

namespace Dtat;

public class PersianDateTime : PersianDate
{
	public PersianDateTime
		(DateTimeOffset dateTime) : base(dateTime: dateTime)
	{
		Hour = dateTime.Hour;
		Minute = dateTime.Minute;
		Second = dateTime.Second;
	}

	public int Hour { get; }

	public int Minute { get; }

	public int Second { get; }

	public override string ToString()
	{
		var hourString =
			Hour.ToString()
			.PadLeft(totalWidth: 2, paddingChar: '0');

		var minuteString =
			Minute.ToString()
			.PadLeft(totalWidth: 2, paddingChar: '0');

		var secondString =
			Second.ToString()
			.PadLeft(totalWidth: 2, paddingChar: '0');

		var result =
			$"{base.ToString()} - {hourString}:{minuteString}:{secondString}";

		return result;
	}
}
