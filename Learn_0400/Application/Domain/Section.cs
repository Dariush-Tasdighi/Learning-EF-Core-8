using Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Section(string name) : Entity
{
	[Required]
	public int CityId { get; set; }

	public virtual City? City { get; set; }

	public int Code { get; set; }

	public bool IsActive { get; set; }

	[MaxLength(length: 50)]
	[Required(AllowEmptyStrings = false)]
	public string Name { get; set; } = name;
}
