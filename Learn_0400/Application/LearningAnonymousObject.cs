namespace Application;

public class Person : object
{
	public Person() : base()
	{
	}

	public int Age { get; set; }

	public string? FullName { get; set; }
}

public class SomeClass : object
{
	public SomeClass() : base()
	{
	}

	public void SomeFunction()
	{
		// **************************************************
		{
			var person =
				new Person
				{
					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			person.Age = 30;
			person.FullName = "Sara Ahmadi";
		}
		// **************************************************

		// **************************************************
		// Anonymous Object
		// **************************************************
		{
			var person =
				new { Age = 20, FullName = "Ali Reza Alavi" };

			// Note: Wrong Usage! Properties are Read Only!
			//person.Age = 30;
			//person.FullName = "Sara Ahmadi";

			var age = person.Age;
			var fullName = person.FullName;
		}
		// **************************************************

		// **************************************************
		{
			var person = new Person();

			var employee =
				new { Salary = 10_000, FName = person.FullName };
		}

		{
			var person = new Person();

			var employee =
				new { Salary = 10_000, FullName = person.FullName };
		}

		{
			var person = new Person();

			var employee =
				new { Salary = 10_000, person.FullName };
		}
		// **************************************************
	}
}
