//Person person = new Person();
//person.Age = 51;
//person.FullName = "Darisuh Tasdighi";

//Person person = new Person() { FullName = "Dariush Tasdighi", Age = 51 };

//Person person =
//	new Person()
//	{
//		FullName = "Dariush Tasdighi",
//		Age = 51
//	};

//Person person =
//	new()
//	{
//		FullName = "Dariush Tasdighi",
//		Age = 51
//	};

//var person =
//	new Person()
//	{
//		FullName = "Dariush Tasdighi",
//		Age = 51
//	};

//var person =
//	new Person
//	{
//		FullName = "Dariush Tasdighi",
//		Age = 51
//	};

//var person =
//	new Person
//	{
//		Age = 51,
//		FullName = "Dariush Tasdighi",
//	};

//public class Person : object
//{
//	public Person() : base()
//	{
//	}

//	public int Age { get; set; }

//	public string FullName { get; set; }

//	// 98 Other Properties

//	public void ShowInformation()
//	{
//		System.Console.WriteLine
//			($"I'm {FullName} and {Age} years old.");
//	}
//}

public class Person(string fullName) : object
{
	public int Age { get; set; }

	public string FullName { get; set; } = fullName;

	// 98 Other Properties

	public void ShowInformation()
	{
		System.Console.WriteLine
			($"I'm {FullName} and {Age} years old.");
	}
}
