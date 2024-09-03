using Domain.Seedwork;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Hotel(string name) : Entity
{
	[Required]
	public int SectionId { get; set; }

	public virtual Section? Section { get; set; }

	public int Code { get; set; }

	public bool IsActive { get; set; }

	[MaxLength(length: 50)]
	[Required(AllowEmptyStrings = false)]
	public string Name { get; set; } = name;
}
