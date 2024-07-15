using Domain.Seedwork;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Country(string name) : Entity
{
	public bool IsActive { get; set; }

	public int Code { get; set; }

	public int Population { get; set; }

	public int HealthyRate { get; set; }

	[MaxLength(length: 20)]
	[Required(AllowEmptyStrings = false)]
	public string Name { get; set; } = name;

	public virtual IList<State> States { get; } = [];
}
