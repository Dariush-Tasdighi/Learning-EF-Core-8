using MyApplication.Classes.Base;

namespace MyApplication.Classes.Countries;

public class CountriesSearchRequest : BaseSearchRequest
{
	public CountriesSearchRequest() : base()
	{
	}

	public string? Name { get; set; }
	public string? CodeTo { get; set; }
	public string? CodeFrom { get; set; }
}
