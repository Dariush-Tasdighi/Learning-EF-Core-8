namespace Dtat;

public static class Constant : object
{
	public static class MaxLength : object
	{
		public const int Name = 100;

		//public const int NAME = 100;
	}

	public static class RegularExpression : object
	{
		public const string PostalCode = "^\\d{10}$";
	}
}
