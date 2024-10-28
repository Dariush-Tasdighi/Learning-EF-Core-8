using Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Country(string name) : Entity
{
	public int Code { get; set; }

	[MaxLength(length: 50)]
	[Required(AllowEmptyStrings = false)]
	public string Name { get; set; } = name;
}
