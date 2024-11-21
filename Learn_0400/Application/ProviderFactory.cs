using System.Data;
using Microsoft.Data.SqlClient;

namespace Application;

public static class ProviderFactory : object
{
	public static IDbDataParameter GetDataParameter(string parameterName, string value)
	{
		//switch(...)
		//{
		//}

		var sqlParameter =
			new SqlParameter(parameterName: parameterName, value: value);

		return sqlParameter;
	}
}
