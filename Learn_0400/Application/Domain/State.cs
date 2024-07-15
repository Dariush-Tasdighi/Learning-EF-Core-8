using Domain.Seedwork;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class State(string name) : Entity
{
	[Required]
	public int CountryId { get; set; }

	public virtual Country? Country { get; set; }

	public int Code { get; set; }

	[MaxLength(length: 20)]
	[Required(AllowEmptyStrings = false)]
	public string Name { get; set; } = name;

	public virtual IList<City> Cities { get; } = [];
}
