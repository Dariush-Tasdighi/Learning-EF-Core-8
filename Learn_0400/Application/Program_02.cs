using Domain;
using System;
using ViewModels;
using System.Linq;
using Application.Persistence;
using Microsoft.EntityFrameworkCore;

try
{
	using var applicationDbContext = new ApplicationDbContext();

	// **************************************************
	// سه دستور ذيل، کاملا با هم معادل می‌باشند
	// **************************************************
	{
		// Load() -> using Microsoft.EntityFrameworkCore;
		applicationDbContext.Countries
			.Load();

		// استفاده می کنيم Local از

		var countries =
			applicationDbContext.Countries.Local;
	}

	{
		var countries =
			applicationDbContext.Countries
			.ToList()
			;
	}

	{
		var countries =
			await
			applicationDbContext.Countries
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries"
	// **************************************************

	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Code <= 10)
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries WHERE Code <= 10"
	// **************************************************

	// **************************************************
	// دو دستور ذيل، کاملا با هم معادل می‌باشند
	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Code >= 10 && current.Code <= 20)
			.ToListAsync()
			;
	}

	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Code >= 10)
			.Where(current => current.Code <= 20)
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries WHERE Code >= 10 AND Code <= 20"
	// **************************************************

	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Code < 10 || current.Code > 20)
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries WHERE Code < 10 OR Code > 20"
	// **************************************************

	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Name == "Iran")
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries WHERE Name = 'Iran'"
	// **************************************************

	// **************************************************
	// دو دستور ذيل، کاملا با هم معادل می‌باشند
	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Name.ToLower() == "Iran".ToLower())
			.ToListAsync()
			;
	}

	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Name.ToUpper() == "Iran".ToUpper())
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries WHERE Name = 'Iran'"
	// **************************************************

	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Name.ToLower().StartsWith("Ir".ToLower()))
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries WHERE Name LIKE 'Ir%'"
	// **************************************************

	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Name.ToLower().EndsWith("an".ToLower()))
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries WHERE Name LIKE '%an'"
	// **************************************************

	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Name.ToLower().Contains("ra".ToLower()))
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries WHERE Name LIKE '%ra%'"
	// **************************************************

	// **************************************************
	// Note: دقت کنيد که دستور ذيل کار نمی کند
	// **************************************************
	{
		var search = "علی علوی";

		search =
			search.Replace(" ", "%"); // "علی%علوی"

		// "SELECT * FROM Countries WHERE Name LIKE '%علی%علوی%'"
	}
	// **************************************************

	// **************************************************
	// Dynamic Search: Introduction
	// **************************************************
	{
		var search = "علی علوی";

		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Name.ToLower().Contains(search.ToLower()))
			.ToListAsync()
			;
	}

	{
		var search = "علی علوی";

		var keywords =
			search.Split(separator: ' ');

		//var countries =
		//	await
		//	databaseContext.Countries
		//	.Where(current => current.Name.ToLower().Contains("علی".ToLower()))
		//	.Where(current => current.Name.ToLower().Contains("علوی".ToLower()))
		//	.ToListAsync()
		//	;

		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Name.ToLower().Contains(keywords[0].ToLower()))
			.Where(current => current.Name.ToLower().Contains(keywords[1].ToLower()))
			.ToListAsync()
			;
	}

	{
		var search = "علی علوی";

		var keywords =
			search.Split(separator: ' ');

		var countries =
			await
			applicationDbContext.Countries
			.Where(current =>
				current.Name.ToLower().Contains(keywords[0].ToLower())
				||
				current.Name.ToLower().Contains(keywords[1].ToLower()))
			.ToListAsync()
			;
	}
	// **************************************************
	// EF & EF Core -> SQL Injection Free
	// **************************************************

	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.OrderBy(current => current.Code)
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries ORDER BY Code"
	// "SELECT * FROM Countries ORDER BY Code ASC"
	// **************************************************

	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.OrderByDescending(current => current.Code)
			.ToListAsync()
			;
	}
	// **************************************************
	// "SELECT * FROM Countries ORDER BY Code DESC"
	// **************************************************

	// **************************************************
	// Note: Bad Practice
	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.OrderBy(current => current.Name)
			.Where(current => current.Code <= 10)
			.ToListAsync()
			;
	}
	// **************************************************

	// **************************************************
	// Note: Best Practice
	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.Where(current => current.Code <= 10)
			.OrderBy(current => current.Name)
			.ToListAsync()
			;
	}
	// **************************************************

	// **************************************************
	// Note: Wrong Usage!
	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.OrderBy(current => current.Code)
			.OrderBy(current => current.Name)
			.ToListAsync()
			;
	}
	// **************************************************

	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			.OrderBy(current => current.Code)
			.ThenBy(current => current.Name)
			.ToListAsync()
			;
	}

	{
		var countries =
			await
			applicationDbContext.Countries
			.OrderBy(current => current.Code)
			.ThenByDescending(current => current.Name)
			.ToListAsync()
			;
	}

	{
		var countries =
			await
			applicationDbContext.Countries
			.OrderByDescending(current => current.Code)
			.ThenBy(current => current.Name)
			.ToListAsync()
			;
	}

	{
		var countries =
			await
			applicationDbContext.Countries
			.OrderByDescending(current => current.Code)
			.ThenByDescending(current => current.Name)
			.ToListAsync()
			;
	}
	// **************************************************

	// **************************************************
	{
		var country =
			await
			applicationDbContext.Countries
			.Where(current => current.Code == 1)
			.FirstOrDefaultAsync();

		if (country is not null)
		{
			// In Lazy Mode:
			// If the states property with the virtual keyword:
			// States will be created and will be loaded automatically.

			// In Normal Mode:
			// stateCount is always zero!
			var stateCount =
				country.States.Count;
		}
	}
	// **************************************************

	// **************************************************
	{
		var states =
			await
			applicationDbContext.States
			.Where(current => current.CountryId == 1)
			.ToListAsync();
		;

		var stateCountOfSomeCountry = states.Count;
	}
	// **************************************************
	// "SELECT * FROM States WHERE CountryId = 1"
	// **************************************************

	// **************************************************
	{
		var stateCountOfSomeCountry =
			await
			applicationDbContext.States
			.Where(current => current.CountryId == 1)
			.CountAsync();
	}
	// **************************************************
	// "SELECT COUNT(*) FROM States WHERE CountryId = 1"
	// **************************************************

	// **************************************************
	// Undocumented!
	// **************************************************
	//{
	//	var country =
	//		await
	//		applicationDbContext.Countries
	//		.Where(current => current.Code == 1)
	//		.FirstOrDefaultAsync();

	//	if (country is not null)
	//	{
	//		var stateCountOfSomeCountry =
	//			await
	//			applicationDbContext.Entry(country)
	//				.Collection(current => current.States)
	//				.Query()
	//				.CountAsync();
	//	}
	//}
	// **************************************************

	// **************************************************
	// فاجعه
	// **************************************************
	{
		var country =
			await
			applicationDbContext.Countries
			.Where(current => current.Code == 1)
			.FirstOrDefaultAsync();

		if (country is not null)
		{
			var states =
				country.States
				.Where(current => current.Code <= 10)
				.ToList()
				;
		}
	}
	// **************************************************

	// **************************************************
	{
		var country =
			await
			applicationDbContext.Countries
			.Where(current => current.Code == 1)
			.FirstOrDefaultAsync();

		if (country is not null)
		{
			var states =
				await
				applicationDbContext.States
				.Where(current => current.Code <= 10)
				.Where(current => current.CountryId == country.Id)
				.ToListAsync()
				;
		}
	}
	// **************************************************

	// **************************************************
	// Undocumented!
	// **************************************************
	{
		var country =
			await
			applicationDbContext.Countries
			.Where(current => current.Code == 1)
			.FirstOrDefaultAsync();

		if (country is not null)
		{
			var statesOfSomeCountry =
				await
				applicationDbContext.Entry(country)
				.Collection(current => current.States)
				.Query()
				.Where(state => state.Code <= 10)
				.ToListAsync()
				;
		}
	}
	// **************************************************

	// **************************************************
	{
		var country =
			await
			applicationDbContext.Countries
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync()
			;

		if (country is not null)
		{
			var stateCount =
				country.States.Count;
		}
	}

	{
		// اگر بخواهیم، زمانی که کشوری از بانک اطلاعاتی دریافت
		// کردیم، همه استان‌های آن نیز، در همان درخواست، منتقل شود
		// از دستور ذیل استفاده می‌کنیم
		var country =
			await
			applicationDbContext.Countries
			.Include("States")
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync();

		// در این حالت امکان بی‌دقتی وجود دارد

		//var country =
		//	await
		//	applicationDbContext.Countries
		//	.Include("Stats")
		//	.Where(current => current.Code >= 10)
		//	.FirstOrDefaultAsync();

		if (country is not null)
		{
			var stateCount =
				country.States.Count;
		}
	}
	// **************************************************

	// **************************************************
	// Note: Strongly Typed
	// **************************************************
	{
		var country =
			await
			applicationDbContext.Countries
			.Include(current => current.States)
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync();

		if (country is not null)
		{
			var stateCount =
				country.States.Count;
		}
	}
	// **************************************************
	// در این حالت امکان بی‌دقتی وجود ندارد
	// **************************************************

	// **************************************************
	{
		var country =
			await
			applicationDbContext.Countries
			.Include("States")
			.Include("States.Cities")
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync();

		// در این حالت امکان بی‌دقتی وجود دارد

		if (country is not null)
		{
			var stateCount =
				country.States.Count;
		}
	}
	// **************************************************

	// **************************************************
	// Undocumented!
	// Note: Strongly Typed
	// **************************************************
	{
		var country =
			await
			applicationDbContext.Countries
			.Include(current => current.States)
			.Include(current => current.States.Select(state => state.Cities))
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync();

		if (country is not null)
		{
			var stateCount =
				country.States.Count;
		}
	}
	// **************************************************
	// در این حالت امکان بی‌دقتی وجود ندارد
	// **************************************************

	// **************************************************
	//{
	//	var country =
	//		await
	//		applicationDbContext.Countries
	//		.Include(current => current.States)
	//		.Include(current => current.States.Select(state => state.Cities))
	//		.Include(current => current.States.Select(state => state.Cities.Select(city => city.Sections))
	//		.Where(current => current.Code == 10)
	//		.FirstOrDefaultAsync();

	//	if (country is not null)
	//	{
	//		var stateCount =
	//			country.States.Count;
	//	}
	//}
	// **************************************************

	// **************************************************
	{
		var city =
			await
			applicationDbContext.Cities
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync();

		if (city is not null)
		{
			var stateName =
				city.State?.Name;
		}
	}
	// **************************************************

	// **************************************************
	{
		var city =
			await
			applicationDbContext.Cities
			.Include(navigationPropertyPath: "State")
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync();

		if (city is not null)
		{
			var stateName =
				city.State?.Name;

			var countryName =
				city.State?.Country?.Name;
		}
	}
	// **************************************************

	// **************************************************
	{
		var city =
			await
			applicationDbContext.Cities
			.Include(navigationPropertyPath: "State")
			.Include(navigationPropertyPath: "State.Country")
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync();

		if (city is not null)
		{
			var stateName =
				city.State?.Name;

			var countryName =
				city.State?.Country?.Name;
		}
	}
	// **************************************************

	// **************************************************
	// Note: Strongly Typed
	// **************************************************
	{
		var city =
			await
			applicationDbContext.Cities
			.Include(current => current.State)
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync();

		if (city is not null)
		{
			var stateName =
				city.State?.Name;

			var countryName =
				city.State?.Country?.Name;
		}
	}
	// **************************************************

	// **************************************************
	{
		var city =
			await
			applicationDbContext.Cities
			.Include(current => current.State)
			.Include(current => current.State.Country)
			.Where(current => current.Code == 10)
			.FirstOrDefaultAsync();

		if (city is not null)
		{
			var stateName =
				city.State?.Name;

			var countryName =
				city.State?.Country?.Name;
		}
	}
	// **************************************************

	// **************************************************
	// صورت مساله
	// من همه کشورهايی را می‌خواهم که
	// لااقل در نام يکی از استان‌های آن، حرف {بی} وجود داشته باشد
	// لااقل = Any
	// **************************************************
	{
		// Solution (1)
		var countries =
			await
			applicationDbContext.Countries
			// دقت کنيد که صرف شرط ذيل، نيازی به دستور
			// Include
			// نيست
			//.Include(current => current.States)
			.Where(current => current.States.Any
				(state => state.Name.ToLower().Contains("B".ToLower())))
			.ToListAsync()
			;
	}

	{
		// Solution (2)
		// Note: Wrong Answer
		var countries =
			await
			applicationDbContext.States
			.Where(current => current.Name.ToLower().Contains("B".ToLower()))
			.Select(current => current.Country)
			.ToListAsync()
			;
	}
	// **************************************************

	// **************************************************
	// صورت مساله
	// من همه کشورهايی را می‌خواهم که
	// در لااقل نام يکی از شهرهای آن، حرف {بی} وجود داشته باشد
	// **************************************************
	{
		var countries =
			await
			applicationDbContext.Countries
			// دقت کنيد که صرف شرط ذيل، نيازی به دستور
			// Include
			// نيست
			//.Include(current => current.States)
			//.Include(current => current.States.Select(state => state.Cities))
			.Where(current => current.States.Any(state => state.Cities.Any(city => city.Name.Contains("B"))))
			.ToListAsync()
			;
	}
	// **************************************************

	// **************************************************
	{
		var cities =
			await
			applicationDbContext.Cities
			// دقت کنيد که صرف شرط ذيل، نيازی به دستور
			// Include
			// نيست
			//.Include(current => current.State)
			//.Include(current => current.State.Country)
			.Where(current => current.State.Country.Population >= 10_000_000)
			.ToListAsync()
			;
	}
	// **************************************************

	// **************************************************
	// Country -> State -> City -> Region -> Hotel
	// **************************************************
	//var hotels =
	//	await
	//	applicationDbContext.Hotels
	//	.ToListAsync()
	//	;

	//var hotels =
	//	await
	//	applicationDbContext.Hotels
	//	.Where(current => current.RegionId == someRegionId)
	//	.ToListAsync()
	//	;

	//var hotels =
	//	await
	//	applicationDbContext.Hotels
	//	.Where(current => current.Region.CityId == someCityId)
	//	.ToListAsync()
	//	;

	//var hotels =
	//	await
	//	applicationDbContext.Hotels
	//	.Where(current => current.Region.City.StateId == someStateId)
	//	.ToListAsync()
	//	;

	//var hotels =
	//	await
	//	applicationDbContext.Hotels
	//	.Where(current => current.Region.City.State.CountryId == someCountryId)
	//	.ToListAsync()
	//	;
	// **************************************************

	// **************************************************
	// خاطره
	// **************************************************
	//var countries =
	//	await
	//	applicationDbContext.Countries
	//	.Where(current => current.Code => 5)
	//	.Where(current => current.Code =< 45)
	//	.ToListAsync()
	//	;
	// **************************************************

	// **************************************************
	{
		applicationDbContext.Countries
			.Where(current => current.Code >= 5)
			.Where(current => current.Code <= 45)
			.Load();

		var countryCount =
			applicationDbContext.Countries.Local.Count;

		applicationDbContext.Countries
			.Where(current => current.Code >= 10)
			.Where(current => current.Code <= 50)
			.Load();

		countryCount =
			applicationDbContext.Countries.Local.Count;
	}
	// **************************************************

	// **************************************************
	// Dynamic Search:
	// **************************************************
	{
		// **************************************************
		//string? countryName = null;
		//string? countryCodeTo = null;
		//string? countryCodeFrom = null;
		// OR
		//string? countryName = "Iran";
		//string? countryCodeTo = null;
		//string? countryCodeFrom = null;
		// OR
		//string? countryName = null;
		//string? countryCodeTo = "10";
		//string? countryCodeFrom = null;
		// OR
		string? countryName = "Iran";
		string? countryCodeTo = "10";
		string? countryCodeFrom = null;
		// OR
		// Up to 8 States!
		// **************************************************

		// ما با دستور ذیل مشکل داریم
		//var data =
		//	applicationDbContext.Countries
		//	;

		//var data =
		//	applicationDbContext.Countries
		//		.Where(current => current.IsActive)
		//		;

		//var data =
		//	applicationDbContext.Countries
		//		.Where(current => 1 == 1)
		//		;

		var data =
			applicationDbContext.Countries
			.AsQueryable()
			;

		if (string.IsNullOrWhiteSpace(value: countryName) == false)
		{
			data =
				data
				.Where(current =>
					current.Name.ToLower()
					.Contains(countryName.ToLower()));
		}

		if (string.IsNullOrWhiteSpace(value: countryCodeFrom) == false)
		{
			// Note: Wrong Usage!
			//data =
			//	data
			//	.Where(current => current.Code >=
			//		Convert.ToInt32(countryCodeFrom));

			var countryCodeFromInt =
				Convert.ToInt32(value: countryCodeFrom);

			data =
				data
				.Where(current => current.Code >= countryCodeFromInt);
		}

		if (string.IsNullOrWhiteSpace(value: countryCodeTo) == false)
		{
			var countryCodeToInt =
				Convert.ToInt32(value: countryCodeTo);

			data =
				data
				.Where(current => current.Code <= countryCodeToInt);
		}

		data =
			data
			.OrderBy(current => current.Id);

		//data
		//	.Load();

		// يا

		// Note: Wrong Usage!
		//data =
		//	data.ToList();

		var result =
			data.ToList();
	}
	// **************************************************

	// **************************************************
	{
		//var search =
		//	"   Ali       Reza  Iran Carpet   Ali         ";

		// یه جوری
		//string[] keywords =
		//	{ "Ali", "Reza", "Iran", "Carpet" };

		// دستور ذیل کار نمی‌کند
		//var keywords =
		//	{ "Ali", "Reza", "Iran", "Carpet" };

		var keywords =
			new string[] { "Ali", "Reza", "Iran", "Carpet" };

		var data =
			applicationDbContext.Countries
			.AsQueryable();

		foreach (var keyword in keywords)
		{
			data =
				data
				.Where(current => current.Name
					.ToLower().Contains(keyword.ToLower()));
		}

		data =
			data
			.OrderBy(current => current.Code)
			;

		var result =
			data.ToList();
	}
	// **************************************************

	// **************************************************
	{
		var search =
			"   Ali       Reza  Iran Carpet   Ali         ";

		//search = "Ali       Reza  Iran Carpet   Ali";
		search =
			search.Trim();

		//search = "Ali Reza Iran Carpet Ali";
		while (search.Contains(value: "  "))
		{
			search = search.Replace
				(oldValue: "  ", newValue: " ");
		}

		// keywords: ["Ali", "Reza", "Iran", "Carpet", "Ali"]
		//var keywords =
		//	search.Split(separator: ' ');

		// keywords: ["Ali", "Reza", "Iran", "Carpet"]
		var keywords =
			search.Split(separator: ' ').Distinct();

		var data =
			applicationDbContext.Countries
			.AsQueryable();

		foreach (var keyword in keywords)
		{
			data =
				data
				.Where(current => current.Name
					.ToLower().Contains(keyword.ToLower()));
		}

		data =
			data
			.OrderBy(current => current.Code)
			;

		var result =
			data.ToList();
	}
	// **************************************************

	// **************************************************
	{
		var search =
			"   Ali       Reza  Iran Carpet   Ali         ";

		search =
			search.Trim();

		while (search.Contains(value: "  "))
		{
			search = search.Replace
				(oldValue: "  ", newValue: " ");
		}

		var keywords =
			search.Split(separator: ' ').Distinct();

		var data =
			applicationDbContext.Countries
			.AsQueryable();

		// Mr. Farshad Rabiei
		// دستور ذیل باید چک شود
		data =
			data.Where(current =>
				keywords.Contains(current.Name));

		data =
			data
			.OrderBy(current => current.Code)
			;

		var result =
			data.ToList();
	}
	// **************************************************

	// **************************************************
	// Learning Traditional LINQ
	// **************************************************
	// دستورات ذيل کاملا با هم معادل هستند
	// **************************************************
	{
		applicationDbContext.Countries
			.Load();

		// applicationDbContext.Countries.Local
	}

	{
		var data =
			applicationDbContext.Countries
			.ToList()
			;
	}

	{
		var data =
			from Country in applicationDbContext.Countries
			select Country
			;
	}
	// **************************************************
	// SELECT * FROM Countries
	// **************************************************

	// **************************************************
	// ها Country آرایه‌ای از
	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.ToLower().Contains("Iran".ToLower())
			select Country
			;
	}
	// **************************************************

	// **************************************************
	// ها Country آرایه‌ای از
	// Select * From Countries WHERE ... ORDER BY ...
	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.ToLower().Contains("Iran".ToLower())
			orderby Country.Name
			select Country
			;

		foreach (var currentCountry in data)
		{
			Console.WriteLine
				(value: currentCountry.Name);
		}
	}
	// **************************************************

	// **************************************************
	// (A)
	// ها string آرایه‌ای از
	// Select Name From Countries WHERE ... ORDER BY ...
	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.ToLower().Contains("Iran".ToLower())
			orderby Country.Name
			select Country.Name
			;

		foreach (var currentCountryName in data)
		{
			Console.WriteLine
				(value: currentCountryName);
		}
	}
	// **************************************************

	// **************************************************
	// Note: See Learning Anonymous Object File!
	// **************************************************

	// **************************************************
	// (B)
	// ها object آرایه‌ای از
	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.ToLower().Contains("Iran".ToLower())
			orderby Country.Name
			select new { Name = Country.Name }
			;

		foreach (var currentPartialCountry in data)
		{
			Console.WriteLine
				(value: currentPartialCountry.Name);
		}
	}
	// **************************************************

	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.ToLower().Contains("Iran".ToLower())
			orderby Country.Name
			select new { Country.Name }
			//select new { Name = Country.Name }
			;

		foreach (var currentPartialCountry in data)
		{
			Console.WriteLine
				(value: currentPartialCountry.Name);
		}
	}
	// **************************************************

	// **************************************************
	// (C)
	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.Contains("Iran")
			orderby Country.Name
			select new { Googooli = Country.Name }
			;

		foreach (var currentPartialCountry in data)
		{
			Console.WriteLine
				(value: currentPartialCountry.Googooli);
		}
	}
	// **************************************************

	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.Contains("Iran")
			orderby Country.Name
			select new { Size = Country.Population, Country.Name }
			;

		foreach (var currentPartialCountry in data)
		{
			Console.WriteLine
				(value: currentPartialCountry.Name);
		}
	}
	// **************************************************

	// **************************************************
	// (D1)
	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.Contains("Iran")
			orderby Country.Name
			select (new CountryViewModel1() { NewName = Country.Name })
			;

		foreach (var currentCountryViewModel in data)
		{
			currentCountryViewModel.NewName += "!";

			Console.WriteLine
				(value: currentCountryViewModel.NewName);
		}
	}
	// **************************************************

	// **************************************************
	// (D2)
	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.Contains("Iran")
			orderby Country.Name
			select (new CountryViewModel2() { Name = Country.Name })
			;

		foreach (var currentCountryViewModel in data)
		{
			currentCountryViewModel.Name += "!";

			Console.WriteLine
				(value: currentCountryViewModel.Name);
		}
	}
	// **************************************************

	// **************************************************
	// (D3)
	// Note: Wrong Usage!
	// **************************************************
	//{
	//	var data =
	//		from Country in applicationDbContext.Countries
	//		where Country.Name.Contains("Iran")
	//		orderby Country.Name
	//		select (new CountryViewModel2() { Country.Name })
	//		;

	//	foreach (var currentCountryViewModel in data)
	//	{
	//		currentCountryViewModel.Name += "!";

	//		Console.WriteLine
	//			(value: currentCountryViewModel.Name);
	//	}
	//}
	// **************************************************

	// **************************************************
	// (E)
	// Note: متاسفانه دستور ذیل کار نمی کند
	// **************************************************
	{
		var data =
			from Country in applicationDbContext.Countries
			where Country.Name.Contains("Iran")
			orderby Country.Name
			select new Country(Country.Name)
			//select new Domain.Features.Identity.Country() { Name = Country.Name }
			;

		foreach (var currentCountry in data)
		{
			Console.WriteLine
				(value: currentCountry.Name);
		}
	}
	// **************************************************

	// **************************************************
	// "SELECT * FROM Countries"
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.ToList()
			;
	}
	// **************************************************

	// **************************************************
	// (A)
	// "SELECT Name FROM Countries"
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => current.Name)
			.ToList()
			;
	}
	// **************************************************

	// **************************************************
	// (B)
	// "SELECT Name FROM Countries"
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => new { Name = current.Name })
			.ToList()
			;
	}
	// **************************************************

	// **************************************************
	// (B)
	// "SELECT Name FROM Countries"
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => new { current.Name })
			.ToList()
			;
	}
	// **************************************************

	// **************************************************
	// (C)
	// "SELECT Name FROM Countries"
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => new { Googooli = current.Name })
			.ToList()
			;
	}
	// **************************************************

	// **************************************************
	// (D)
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => new CountryViewModel1() { NewName = current.Name })
			.ToList()
			;
	}
	// **************************************************

	// **************************************************
	// (D)
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => new CountryViewModel2() { Name = current.Name })
			.ToList()
			;
	}
	// **************************************************

	// **************************************************
	// (D)
	// **************************************************
	//{
	//	var data =
	//		applicationDbContext.Countries
	//		.Select(current => new CountryViewModel2() { current.Name })
	//		.ToList()
	//		;
	//}
	// **************************************************

	// **************************************************
	// (E)
	// Note: متاسفانه کار نمی کند
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => new Country(current.Name))
			.ToList()
			;
	}
	// **************************************************

	// **************************************************
	// "SELECT Name FROM Countries"
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => new { current.Name })
			.ToList()
			.Select(current => new Country(current.Name))
			.ToList()
			;
	}
	// **************************************************

	// **************************************************
	// "SELECT Id, Name FROM Countries"
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => new { current.Id, current.Name })
			.ToList()
			.Select(current => new Country(name: current.Name)
			{
				Id = current.Id,
			})
			.ToList()
			;
	}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	{
		var data =
			await
			applicationDbContext.Countries
			.Select(current => new
			{
				Id = current.Id,
				Name = current.Name,
				StateCount = current.States.Count,
			})
			.ToListAsync()
			;
	}
	// **************************************************

	// **************************************************
	{
		var data =
			await
			applicationDbContext.Countries
			.Select(current => new
			{
				current.Id,
				current.Name,
				StateCount = current.States.Count,
			})
			.ToListAsync()
			;
	}
	// **************************************************

	// **************************************************
	// در دو دستور ذیل، در صورتی که تحت شرایطی
	// تعداد استان‌ها، برای یک کشور صفر باشد، خطا ایجاد می‌شود
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.Select(current => new
			{
				current.Id,
				current.Name,
				StateCount = current.States.Count,
				CityCount = current.States.Sum(state => state.Cities.Count),
			})
			.ToList()
			;
	}

	{
		var data =
			applicationDbContext.Countries
			.Select(current => new
			{
				current.Id,
				current.Name,
				StateCount = current.States.Count,
				CityCount = current.States.Select(state => state.Cities.Count).Sum(),
			})
			.ToList()
			;
	}

	{
		var number1 = 10;
		var number2 = 20;
		var max = (number1 > number2) ? number1 : number2;
		var min = (number1 < number2) ? number1 : number2;

		var data =
			applicationDbContext.Countries
			.Select(current => new
			{
				current.Id,
				current.Name,

				StateCount = current.States.Count,

				CityCount = current.States.Count == 0 ? 0 :
					current.States.Select(state => new { XCount = state.Cities.Count }).Sum(x => x.XCount)

				//CityCount = current.States.Count == 0 ? 0 :
				//	current.States.Select(state => state.Cities.Count).Sum()

				//CityCount = current.States == null || current.States.Count == 0 ? 0 :
				//	current.States.Select(state => new { XCount = state.Cities == null ? 0 : state.Cities.Count }).Sum(x => x.XCount)
			})
			.ToList()
			;
	}

	{
		// مهدی اکبری
		var data =
			applicationDbContext.Countries
			.Select(current => new
			{
				current.Id,
				current.Name,

				StateCount =
					current.States.Count,

				CityCount = current.States.Select
					(state => state.Cities.Count).DefaultIfEmpty(0).Sum(),
			})
			.ToList()
			;
	}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// Group By
	// **************************************************
	{
		var data =
			applicationDbContext.Countries
			.GroupBy(current => current.Population)
			.Select(current => new
			{
				Population = current.Key,

				Count = current.Count(),
			})
			.ToList()
			;
	}

	{
		var data =
			applicationDbContext.Countries
			.Where(current => current.Population >= 120_000_000)
			.GroupBy(current => current.Population)
			.Select(current => new
			{
				Population = current.Key,

				Count = current.Count(),
			})
			.ToList()
			;
	}

	//{
	//	var data =
	//		applicationDbContext.Countries
	//		.GroupBy(current => current.Population)
	//		.Where(current => current.Population >= 120_000_000) // Error!
	//		.Select(current => new
	//		{
	//			Population = current.Key,

	//			Count = current.Count(),
	//		})
	//		.ToList()
	//		;
	//}

	{
		var data =
			applicationDbContext.Countries
			.GroupBy(current => current.Population)
			.Select(current => new
			{
				Population = current.Key,

				Count = current.Count(),
			})
			.Where(other => other.Population >= 120_000_000)
			.ToList()
			;
	}

	{
		var data =
			applicationDbContext.Countries
			.Where(current => current.Name.Contains('I'))
			.GroupBy(current => current.Population)
			.Select(current => new
			{
				Population = current.Key,

				Count = current.Count(),
			})
			.ToList()
			;
	}

	//{
	//	// Note: Wrong Usage!
	//	var data =
	//		applicationDbContext.Countries
	//		.GroupBy(current => current.Population)
	//		.Select(current => new
	//		{
	//			Population = current.Key,

	//			Count = current.Count(),
	//		})
	//		.Where(other => other.Name.Contains('ا'))
	//		.ToList()
	//		;
	//}

	{
		var data =
			applicationDbContext.Countries
			.GroupBy(current => current.Population)
			.Select(current => new
			{
				Population = current.Key,

				Count = current.Count(),
			})
			.Where(other => other.Count >= 5)
			.ToList()
			;
	}

	{
		var data =
			applicationDbContext.Countries
			.Where(current => current.Name.Contains('I'))
			.GroupBy(current => current.Population)
			.Select(current => new
			{
				Population = current.Key,

				Count = current.Count(),
			})
			.Where(other => other.Count >= 5)
			.ToList()
			;
	}

	{
		var data =
			applicationDbContext.Countries
			.GroupBy(current => new { current.Population, current.HealthyRate })
			.Select(current => new
			{
				Population = current.Key.Population,
				HealthyRate = current.Key.HealthyRate,

				Count = current.Count(),
			})
			.ToList()
			;
	}

	{
		var data =
			applicationDbContext.Countries
			.GroupBy(current => new { current.Population, current.HealthyRate })
			.Select(current => new
			{
				current.Key.Population,
				current.Key.HealthyRate,

				Count = current.Count(),
			})
			.ToList()
			;
	}

	{
		var data =
			applicationDbContext.Countries
			.GroupBy(current => current.Population)
			.Select(current => new
			{
				Population = current.Key,

				Count = current.Count(),

				Max = current.Max(x => x.HealthyRate),
				Min = current.Min(x => x.HealthyRate),
				Sum = current.Sum(x => x.HealthyRate),
				Average = current.Average(x => x.HealthyRate),
			})
			.ToList()
			;
	}
	// **************************************************
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
