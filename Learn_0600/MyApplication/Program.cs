using System;
using Application.Persistence;

try
{
	using var applicationDbContext = new ApplicationDbContext();

}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
