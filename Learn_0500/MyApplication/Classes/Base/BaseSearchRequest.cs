namespace MyApplication.Classes.Base;

public class BaseSearchRequest : object
{
	public BaseSearchRequest() : base()
	{
	}

	public int PageSize { get; set; }
	public int PageIndex { get; set; }
}
