//using System;
//using System.IO;
//using System.Linq;

//WorkingOnXml();
//WorkingOnFiles();
//WorkinngOnDatabase();

//WorkingOnFilesWithLinq();
//WorkinngOnDatabaseWithLinq();

//void WorkinngOnDatabase()
//{
//	//var query =
//	//	"SELECT * FROM Users WHERE Age >= 25 AND Age <= 35 ORDER BY FullName ASC";

//	// ارسال به بانک اطلاعاتی برای بدست آوردن اطلاعات اشخاص
//}

//void WorkingOnFiles()
//{
//	var path =
//		"C:\\WINDOWS";

//	var directoryInfo =
//		new DirectoryInfo(path: path);

//	var files =
//		directoryInfo.GetFiles();

//	foreach (var fileInfo in files)
//	{
//		Console.WriteLine(value: fileInfo.Name);
//	}

//	foreach (var fileInfo in files)
//	{
//		if (fileInfo.Length is >= (25 * 1024) and <= (35 * 1024))
//		{
//			Console.WriteLine(value: fileInfo.Name);
//		}
//	}

//	// صورت مساله‌ای که چهارشاخ گاردان را پایین می‌آورد

//	// حال تمام فایل‌هایی را می‌خواهیم که سایز آنها بین
//	// بیست و پنج کیلو بایت تا سی و پنج کیلو بایت بوده
//	// و مرتب شده بر حسب نام فایل‌ها باشند
//}

//void WorkingOnXml()
//{
//	// XmlDocument, XmlReader,...
//}

//void WorkinngOnDatabaseWithLinq()
//{
//	//using var applicationDbContext = new ApplicationDbContext();

//	//var users =
//	//	applicationDbContext.Users
//	//	.Where(current => current.Age >= 25 && current.Age <= 35)
//	//	.OrderBy(current => current.FullName)
//	//	.ToList()
//	//	;
//}

//void WorkingOnFilesWithLinq()
//{
//	var path =
//		"C:\\WINDOWS";

//	var directoryInfo =
//		new DirectoryInfo(path: path);

//	var files =
//		directoryInfo.GetFiles()
//		.Where(current => current.Length >= 25 * 1024 && current.Length <= 35 * 1024)
//		.OrderBy(current => current.Name)
//		.ToList()
//		;
//}
