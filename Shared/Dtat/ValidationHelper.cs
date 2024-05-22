using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dtat;

public static class ValidationHelper : object
{
	public static bool IsValid(object entity)
	{
		var validationContext =
			new ValidationContext(instance: entity);

		var isValid =
			Validator
			.TryValidateObject(instance: entity,
			validationContext: validationContext,
			validationResults: null, validateAllProperties: true);

		return isValid;
	}

	public static IList<ValidationResult> GetValidationResults(object entity)
	{
		var validationContext =
			new ValidationContext(instance: entity);

		var validationResults =
			new List<ValidationResult>();

		Validator
			.TryValidateObject(instance: entity,
			validationContext: validationContext,
			validationResults: validationResults, validateAllProperties: true);

		return validationResults;
	}
}
