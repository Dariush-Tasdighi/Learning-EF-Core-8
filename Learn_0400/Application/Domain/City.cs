using Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class City(string name) : Entity
{
	[Required]
	public int StateId { get; set; }

	public virtual State? State { get; set; }

	public int Code { get; set; }

	[MaxLength(length: 50)]
	[Required(AllowEmptyStrings = false)]
	public string Name { get; set; } = name;
}
