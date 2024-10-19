[How to code?]

1. Console
2. Windows Forms Application
3. WPF
4. ASP.NET / ASP.NET Core
	4.1 MVC
	4.2 Razor Pages
	4.3 Web API

[Sample:]

var data =
	applicationDbContext.Countries
	.AsQueryable()
	;

if (string.IsNullOrWhiteSpace(value: nameTextBox.Text) == false)
{
	data = data.Where(current =>
		current.Name.ToLower().Contains(nameTextBox.Text.ToLower()));
}

if (string.IsNullOrWhiteSpace(value: codeFromTextBox.Text) == false)
{
	var codeFrom =
		Convert.ToInt32(value: codeFromTextBox.Text);

	data = data.Where(current => current.Code >= codeFrom);
}

if (string.IsNullOrWhiteSpace(value: codeToTextBox.Text) == false)
{
	var codeTo =
		Convert.ToInt32(value: codeToTextBox.Text);

	data = data.Where(current => current.Code <= codeTo);
}

...

[Dependency Injection!]

[Create Some Classes:]
	- Base
	- ViewModels / Dtos / Request or Response
