using Dtat;
using System;
using Resources;
using Resources.Messages;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// **************************************************
{
	var user = new User();

	var isValid =
		ValidationHelper.IsValid(entity: user);

	var errors =
		ValidationHelper.GetValidationResults(entity: user);

	foreach (var error in errors)
	{
		Console.WriteLine(error.ErrorMessage);
	}
}
// **************************************************

Console.WriteLine(Environment.NewLine);

// **************************************************
{
	var user = new User();

	user.Ordering = 2_000_000;
	user.LastName = "1234567890123456789012345678901234567890";
	user.FirstName = "1234567890123456789012345678901234567890";

	var isValid =
		ValidationHelper.IsValid(entity: user);

	var errors =
		ValidationHelper.GetValidationResults(entity: user);

	foreach (var error in errors)
	{
		Console.WriteLine(error.ErrorMessage);
	}
}
// **************************************************

public class User : object
{
	[Key]
	[Display(ResourceType = typeof(DataDictionary),
		Name = nameof(DataDictionary.Id))]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public Guid Id { get; private set; } = Guid.NewGuid();

	[Display(ResourceType = typeof(DataDictionary),
		Name = nameof(DataDictionary.Ordering))]
	[Range(minimum: 1, maximum: 100_000,
		ErrorMessageResourceType = typeof(Validations),
		ErrorMessageResourceName = nameof(Validations.Range))]
	public int Ordering { get; set; } = 10_000;

	[Display(ResourceType = typeof(DataDictionary),
		Name = nameof(DataDictionary.Username))]
	[Required(AllowEmptyStrings = false,
		ErrorMessageResourceType = typeof(Validations),
		ErrorMessageResourceName = nameof(Validations.Required))]
	[MaxLength(length: 20,
		ErrorMessageResourceType = typeof(Validations),
		ErrorMessageResourceName = nameof(Validations.MaxLength))]
	public string? Username { get; set; }

	[Display(ResourceType = typeof(DataDictionary),
		Name = nameof(DataDictionary.FirstName))]
	[MaxLength(length: 20,
		ErrorMessageResourceType = typeof(Validations),
		ErrorMessageResourceName = nameof(Validations.MaxLength))]
	public string? FirstName { get; set; }

	[Display(ResourceType = typeof(DataDictionary),
		Name = nameof(DataDictionary.LastName))]
	[MaxLength(length: 30,
		ErrorMessageResourceType = typeof(Validations),
		ErrorMessageResourceName = nameof(Validations.MaxLength))]
	public string? LastName { get; set; }
}
