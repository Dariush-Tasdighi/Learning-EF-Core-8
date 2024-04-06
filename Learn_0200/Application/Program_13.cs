﻿//using System;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System.Text.RegularExpressions;

//try
//{
//}
//catch (Exception ex)
//{
//	Console.WriteLine(value: ex.Message);
//}

//// **************************************************
//// *** Category 01 **********************************
//// **************************************************
//public class Category01 : object
//{
//	public Category01() : base()
//	{
//	}

//	public int Id { get; set; }
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 02 **********************************
//// **************************************************
//public class Category02 : object
//{
//	public Category02() : base()
//	{
//	}

//	public int ID { get; set; }
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 03 **********************************
//// **************************************************
//public class Category03 : object
//{
//	public Category03() : base()
//	{
//	}

//	public int Category03Id { get; set; }
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 04 **********************************
//// **************************************************
//public class Category04 : object
//{
//	public Category04() : base()
//	{
//	}

//	public int Category04ID { get; set; }
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 05 **********************************
//// **************************************************
//public class Category05 : object
//{
//	public Category05() : base()
//	{
//	}

//	/// <summary>
//	/// خطا می‌دهد
//	/// </summary>
//	public int Key { get; set; }
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 06 **********************************
//// **************************************************
//public class Category06 : object
//{
//	public Category06() : base()
//	{
//	}

//	/// <summary>
//	/// این ویژگی فقط مربوط به بانک‌اطلاعاتی می‌شود
//	/// 
//	/// داریم Key چون در اسکیوال کلمه
//	/// می‌شود [Key] تبدیل به
//	/// </summary>
//	[Key]
//	public int Key { get; set; }
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 07 **********************************
//// **************************************************
//public class Category07 : object
//{
//	public Category07() : base()
//	{
//	}

//	[Key]
//	public int Id { get; set; }

//	/// <summary>
//	/// این ویژگی هم مربوط به برنامه
//	/// می‌شود و هم مربوط به بانک اطلاعاتی می‌شود
//	/// </summary>
//	[MaxLength(length: 100)]
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 08 **********************************
//// **************************************************
//public class Category08 : object
//{
//	public Category08() : base()
//	{
//	}

//	[Key]
//	public int Id { get; set; }

//	/// <summary>
//	/// این ویژگی فقط مربوط به برنامه می‌شود
//	/// </summary>
//	[MinLength(length: 3)]

//	/// <summary>
//	/// این ویژگی هم مربوط به برنامه
//	/// می‌شود و هم مربوط به بانک اطلاعاتی می‌شود
//	/// </summary>
//	[MaxLength(length: 100)]
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 09 **********************************
//// **************************************************
//public class Category09 : object
//{
//	public Category09() : base()
//	{
//	}

//	[Key]
//	public int Id { get; set; }

//	/// <summary>
//	/// این ویژگی هم مربوط به برنامه
//	/// می‌شود و هم مربوط به بانک اطلاعاتی می‌شود
//	/// </summary>
//	[StringLength(maximumLength: 100)]
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 10 **********************************
//// **************************************************
//public class Category10 : object
//{
//	public Category10() : base()
//	{
//	}

//	[Key]
//	public int Id { get; set; }

//	/// <summary>
//	/// بخشی از این ویژگی، هم مربوط به برنامه
//	/// می‌شود و هم مربوط به بانک اطلاعاتی می‌شود
//	/// 
//	/// ولی بخشی از این ویژگی، صرفا مربوط به برنامه می‌شود
//	/// </summary>
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 11 **********************************
//// **************************************************
//public class Category11 : object
//{
//	public Category11() : base()
//	{
//	}

//	[Key]
//	public int Id { get; set; }

//	/// <summary>
//	/// این ویژگی هم مربوط به برنامه
//	/// می‌شود و هم مربوط به بانک اطلاعاتی می‌شود
//	/// </summary>
//	[Required]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 12 **********************************
//// **************************************************
//public class Category12 : object
//{
//	public Category12() : base()
//	{
//	}

//	[Key]
//	public int Id { get; set; }

//	/// <summary>
//	/// بخشی از این ویژگی، هم مربوط به برنامه
//	/// می‌شود و هم مربوط به بانک اطلاعاتی می‌شود
//	/// 
//	/// ولی بخشی از این ویژگی، صرفا مربوط به برنامه می‌شود
//	/// </summary>
//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string? Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 13 **********************************
//// **************************************************
///// <summary>
///// طراحی هوشمندانه که در نسخه قبل امکان‌پذیر نبود
///// </summary>
//public class Category13 : object
//{
//	/// <summary>
//	/// را می‌نوشتیم Default Constructor در نسخه قدیم باید حتما
//	/// </summary>
//	//public Category13() : base()
//	//{
//	//}

//	public Category13(string name) : base()
//	{
//		Name = name;
//	}

//	/// <summary>
//	/// Note: private set;
//	/// </summary>
//	[Key]
//	public int Id { get; private set; }

//	/// <summary>
//	/// Note: string? -> string
//	/// </summary>
//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 14 **********************************
//// **************************************************
///// <summary>
///// طراحی هوشمندانه که در نسخه قبل امکان‌پذیر نبود
///// </summary>
//public class Category14(string name) : object
//{
//	//public Category14(string name) : base()
//	//{
//	//	Name = name;
//	//}

//	[Key]
//	public int Id { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 15 **********************************
//// **************************************************
//public class Category15(string name) : object
//{
//	[Key]
//	public int Id { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;

//	// **********
//	/// <summary>
//	/// این ویژگی، فقط مربوط به برنامه می‌شود
//	/// 
//	/// ها به شرطی عمل می‌کنند Validator
//	/// نباشد null که فیلد مربوط به آن‌ها
//	/// </summary>
//	//[Range(minimum: 1, maximum: 100000)]
//	[Range(minimum: 1, maximum: 100_000)]
//	//public int Ordering { get; set; } = 10000;
//	public int Ordering { get; set; } = 10_000;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 16 **********************************
//// **************************************************
//// In Classic EF: Automatically: Country -> Countries Based on Model Name
//// In EF Core: Automatically: Country -> Countries Based on DbSet Property Name
//// **************************************************
//public class Category16(string name) : object
//{
//	[Key]
//	public int Id { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;

//	[MaxLength(length: 10)]

//	/// <summary>
//	/// این ویژگی فقط مربوط به برنامه می‌شود
//	/// </summary>
//	[RegularExpression(pattern: "^\\d$")]
//	//[RegularExpression(pattern: "^\\d{10}$")]
//	//[RegularExpression(pattern: "^\\d{10,12}$")]
//	public string? PostalCode { get; set; }

//	public bool ValidatePostalCode()
//	{
//		if (string.IsNullOrEmpty(value: PostalCode))
//		{
//			return true;
//		}

//		var result =
//			Regex.IsMatch
//			(input: PostalCode, pattern: "^\\d{10}$");

//		return result;
//	}
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 17 **********************************
//// **************************************************
//// System.ComponentModel.DataAnnotations.Schema.Table
//// System.ComponentModel.DataAnnotations.Schema.Column
//// **************************************************
//[Table(name: "CategoriesTable")]
//public class Category17(string name) : object
//{
//	[Key]
//	[Column(name: "CategoryId")]
//	public int Id { get; private set; }

//	[Column(name: "CategoryName")]
//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 18 **********************************
//// **************************************************
//[Table(name: "TABLE_001")]
//public class Category18(string name) : object
//{
//	[Key]
//	[Column(name: "FIELD_001")]
//	public int Id { get; private set; }

//	[Column(name: "FIELD_002")]
//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 19 **********************************
//// **************************************************
//// Multiple Schema does not work in Sqlite!
//// Schema does not work in SQL Server Compact Edition at all!
//// **************************************************
//[Table(name: "Categories", Schema = "Cms")]
//public class Category19(string name) : object
//{
//	[Key]
//	public int Id { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 20 **********************************
//// **************************************************
//// متاسفانه هیچ‌یک از سه دستور ذیل کار نمی‌کند
//// **************************************************
////[Table(Schema = "Cms")]
////[Table(name: "", Schema = "Cms")]
////[Table(name: null, Schema = "Cms")]
//public class Category20(string name) : object
//{
//	[Key]
//	public int Id { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 21 **********************************
//// **************************************************
//// Id:
//// 
////		In C#			In SQL Server Database
//// 
////		int				int
////		long			bigint
////		System.Guid		uniqueidentifier
//// **************************************************
//public class Category21(string name) : object
//{
//	[Key]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//	public int Id { get; set; }
//	//public int Id { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 22 **********************************
//// **************************************************
//public class Category22(string name) : object
//{
//	// **********
//	/// <summary>
//	/// بانک اطلاعاتی مقدار آن را
//	/// تولید می‌کند و به سمت برنامه ارسال می‌کند
//	/// </summary>
//	[Key]
//	public Guid Id { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 23 **********************************
//// **************************************************
//public class Category23(string name) : object
//{
//	[Key]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	//public Guid Id { get; private set; } = new Guid(); // این دستور غلط است
//	public Guid Id { get; private set; } = Guid.NewGuid();

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 24 **********************************
//// **************************************************
//public class Category24(string name) : object
//{
//	[Key]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public System.Guid Id { get; private set; } = Guid.NewGuid();

//	/// <summary>
//	/// Note: private set;
//	/// </summary>
//	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//	public int Code { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 25 **********************************
//// **************************************************
//public class Category25(string name) : object
//{
//	[Key]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public Guid Id { get; private set; } = Guid.NewGuid();

//	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//	public int Code1 { get; private set; }

//	/// <summary>
//	/// Error!
//	/// only one column per table can be configured as 'Identity'.
//	///
//	/// تعریف نمایید Sequence بعدا یاد خواهید گرفت که چیزی به نام
//	/// </summary>
//	//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//	//public int Code2 { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 26 **********************************
//// **************************************************
//public class Category26(string name) : object
//{
//	[Key]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public Guid Id { get; private set; }

//	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//	public int Code { get; private set; }

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100, MinimumLength = 3)]
//	public string Name { get; set; } = name;

//	public string DisplayName
//	{
//		get
//		{
//			var result =
//				$"{Code} - {Name}";

//			return result;
//		}
//	}

//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	//public DateTime InsertDateTime { get; private set; }
//	//public DateTimeOffset InsertDateTime { get; private set; } = DateTimeOffset.Now;
//	public DateTimeOffset InsertDateTime { get; private set; } = Dtat.DateTime.Now;

//	/// <summary>
//	/// Set ای که Property
//	/// نداشته باشد تبدیل به فیلد در بانک اطلاعاتی نمی‌شود
//	/// </summary>
//	public Dtat.PersianDate InsertPersianDate
//	{
//		get
//		{
//			var result =
//				InsertDateTime.ToPersianDate();

//			return result;
//		}
//	}

//	public Dtat.PersianDateTime InsertPersianDateTime
//	{
//		get
//		{
//			var result =
//				InsertDateTime.ToPersianDateTime();

//			return result;
//		}
//	}
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 27 **********************************
//// **************************************************
//public class Category27(string name) : object
//{
//	[Key]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public Guid Id { get; private set; } = Guid.NewGuid();

//	[Required(AllowEmptyStrings = false)]
//	[StringLength(maximumLength: 100)]
//	public string Name { get; set; } = name;

//	/// <summary>
//	/// تبدیل به فیلد بانک اطلاعاتی می‌شود
//	/// </summary>
//	public int MyProperty11 { get; set; }

//	/// <summary>
//	/// تبدیل به فیلد بانک اطلاعاتی می‌شود
//	/// </summary>
//	public int MyProperty12 { get; private set; }

//	/// <summary>
//	/// تبدیل به فیلد بانک اطلاعاتی می‌شود
//	/// </summary>
//	public int MyProperty13 { get; protected set; }

//	/// <summary>
//	/// تبدیل به فیلد بانک اطلاعاتی می‌شود
//	/// </summary>
//	public int MyProperty14 { get; internal set; }

//	/// <summary>
//	/// تبدیل به فیلد بانک اطلاعاتی می‌شود
//	/// </summary>
//	public int MyProperty15 { get; private protected set; }

//	/// <summary>
//	/// تبدیل به فیلد بانک اطلاعاتی می‌شود
//	/// </summary>
//	public int MyProperty16 { get; protected internal set; }

//	/// <summary>
//	/// !تبدیل به فیلد بانک اطلاعاتی نمی‌شود
//	/// </summary>
//	public int MyProperty21 { get; }

//	/// <summary>
//	/// !تبدیل به فیلد بانک اطلاعاتی نمی‌شود
//	/// </summary>
//	[NotMapped]
//	public int MyProperty22 { get; set; }

//	/// <summary>
//	/// !تبدیل به فیلد بانک اطلاعاتی نمی‌شود
//	/// </summary>
//	private int MyProperty23 { get; set; }

//	/// <summary>
//	/// !تبدیل به فیلد بانک اطلاعاتی نمی‌شود
//	/// </summary>
//	protected int MyProperty24 { get; set; }

//	/// <summary>
//	/// !تبدیل به فیلد بانک اطلاعاتی نمی‌شود
//	/// </summary>
//	internal int MyProperty25 { get; set; }

//	/// <summary>
//	/// !تبدیل به فیلد بانک اطلاعاتی نمی‌شود
//	/// </summary>
//	private protected int MyProperty26 { get; set; }

//	/// <summary>
//	/// !تبدیل به فیلد بانک اطلاعاتی نمی‌شود
//	/// </summary>
//	protected internal int MyProperty27 { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** Category 28 **********************************
//// **************************************************
//public class Category28(string name) : object
//{
//	[Key]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public Guid Id { get; private set; } = Guid.NewGuid();

//	[StringLength(maximumLength: 100)]
//	[Required(AllowEmptyStrings = false)]
//	public string Name { get; set; } = name;

//	[StringLength(maximumLength: 100)]

//	/// <summary>
//	/// Order is Zero based!
//	/// Note: Using TypeName is not recommended!
//	/// 
//	/// Example: Default: nVarChar(100) -> Char(100)
//	/// </summary>
//	[Column(Order = 0, TypeName = "Char")]
//	public string? Description { get; set; }
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** UserInGroup 01 *******************************
//// **************************************************
//// ضمن آن‌که تفکر ذیل را اصلا
//// توصیه نمی‌کنم، باید دقت داشته باشیم که
//// کار نمی‌کند EF Core کار می‌کند، ولی در EF روش ذیل، در
//// 
//// Error:
//// The entity type 'UserInGroup01' has multiple properties with the [Key] attribute.
//// Composite primary keys can only be set using 'HasKey' in 'OnModelCreating'.
//// **************************************************
//public class UserInGroup01(Guid userId, Guid groupId) : object
//{
//	[Key]
//	[Column(Order = 0)]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public Guid UserId { get; private set; } = userId;

//	[Key]
//	[Column(Order = 1)]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public Guid GroupId { get; private set; } = groupId;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** UserInGroup 02 *******************************
//// **************************************************
//public class UserInGroup02(Guid userId, Guid groupId) : object
//{
//	[Key]
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public Guid Id { get; private set; } = Guid.NewGuid();

//	/// <summary>
//	/// Foreign Key
//	/// 
//	/// دستور ذیل، ناقص است! انشاءالله در قسمت روابط
//	/// یک به چند و چند به چند به این موضوع به طور کامل می‌پردازیم
//	/// </summary>
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public Guid UserId { get; private set; } = userId;

//	/// <summary>
//	/// Foreign Key
//	/// 
//	/// دستور ذیل، ناقص است! انشاءالله در قسمت روابط
//	/// یک به چند و چند به چند به این موضوع به طور کامل می‌پردازیم
//	/// </summary>
//	[DatabaseGenerated(DatabaseGeneratedOption.None)]
//	public System.Guid GroupId { get; private set; } = groupId;
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** User 01 **************************************
//// **************************************************
//public class User01 : object
//{
//	public User01(string username) : base()
//	{
//		Username = username;
//		Id = System.Guid.NewGuid();
//	}

//	// **********
//	[System.ComponentModel.DataAnnotations.Key]

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//	public System.Guid Id { get; private set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.Required
//		(AllowEmptyStrings = false)]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20)]

//	// کار نمی‌کند EF Core کار می‌کند و در EF دستور ذیل فقط در
//	//[System.ComponentModel.DataAnnotations.Schema.Index
//	//	(IsUnique = true)]
//	public string Username { get; private set; }
//	// **********
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** User 02 **************************************
//// **************************************************
///// <summary>
///// نکته بسیار مهم
///// 
///// تعریف کرد Index هستند VarChar, NVarChar, Text, nText نمی‌توان برای فیلدهایی که از جنس
///// </summary>
////[Microsoft.EntityFrameworkCore.Index
////	("Username", IsUnique = true)]

//// Index Name: IX_Users02_Username
//[Microsoft.EntityFrameworkCore.Index
//	(nameof(Username), IsUnique = true)]

////[Microsoft.EntityFrameworkCore.Index
////	(nameof(Username), IsUnique = true, Name = "Googooli")]

//// Note: Obsolete
////[Microsoft.EntityFrameworkCore.Index
////	(propertyNames: nameof(Username), IsUnique = true, Name = "Googooli")]

//// مدل نوشتن ذیل خطا می‌دهد
////[Microsoft.EntityFrameworkCore.Index
////	(propertyNames: nameof(FirstName), nameof(LastName), IsUnique = false)]

//[Microsoft.EntityFrameworkCore.Index
//	(nameof(FirstName), nameof(LastName), IsUnique = false)]

//// خطا می‌دهد EF دستور ذیل در
////
//// با اجرای دستور ذیل اتفاق جالبی رخ می‌دهد
//// nvarchar(450)
//// صورت می‌گیرد EF Core این عمل به طور اتوماتیک توسط
//[Microsoft.EntityFrameworkCore.Index
//	(nameof(Description))]
//public class User02 : object
//{
//	public User02(string username) : base()
//	{
//		Username = username;
//		Id = System.Guid.NewGuid();
//	}

//	// **********
//	[System.ComponentModel.DataAnnotations.Key]

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//	public System.Guid Id { get; private set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.Required
//		(AllowEmptyStrings = false)]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20)]
//	public string Username { get; private set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20)]
//	public string? FirstName { get; set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 30)]
//	public string? LastName { get; set; }
//	// **********

//	// **********
//	public string? Description { get; set; }
//	// **********
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** User 03 **************************************
//// **************************************************
//// See:
//// CreateUser03Async() Function
//// **************************************************
//[Microsoft.EntityFrameworkCore.Index
//	(nameof(Username), IsUnique = true)]

//[Microsoft.EntityFrameworkCore.Index
//	(nameof(FirstName), nameof(LastName), IsUnique = false)]
//public class User03 : object
//{
//	public User03(string username) : base()
//	{
//		Ordering = 10_000;
//		Username = username;
//		Id = System.Guid.NewGuid();
//	}

//	// **********
//	[System.ComponentModel.DataAnnotations.Key]

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//	public System.Guid Id { get; private set; }
//	// **********

//	// **********
//	//[System.ComponentModel.DataAnnotations.Range
//	//	(minimum: 1, maximum: 100000)]

//	[System.ComponentModel.DataAnnotations.Range
//		(minimum: 1, maximum: 100_000)]
//	public int Ordering { get; set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.Required
//		(AllowEmptyStrings = false)]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20)]
//	public string Username { get; private set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20)]
//	public string? FirstName { get; set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 30)]
//	public string? LastName { get; set; }
//	// **********
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** User 04 **************************************
//// **************************************************
//// See:
//// CreateUser04Async() Function
//// **************************************************
//[Microsoft.EntityFrameworkCore.Index
//	(nameof(Username), IsUnique = true)]

//[Microsoft.EntityFrameworkCore.Index
//	(nameof(FirstName), nameof(LastName), IsUnique = false)]
//public class User04 : object
//{
//	public User04(string username) : base()
//	{
//		Ordering = 10_000;
//		Username = username;
//		Id = System.Guid.NewGuid();
//	}

//	// **********
//	[System.ComponentModel.DataAnnotations.Key]

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//	public System.Guid Id { get; private set; }
//	// **********

//	// **********
//	//[System.ComponentModel.DataAnnotations.Range
//	//	(minimum: 1, maximum: 100_000)]

//	//[System.ComponentModel.DataAnnotations.Range
//	//	(minimum: 1, maximum: 100_000,
//	//	ErrorMessage = "The Ordering value should be between 1 and 100000!")]

//	[System.ComponentModel.DataAnnotations.Range
//		(minimum: 1, maximum: 100_000,
//		ErrorMessage = "The {0} value should be between {1} and {2}!")]
//	public int Ordering { get; set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.Required
//		(AllowEmptyStrings = false)]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20)]
//	public string Username { get; private set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.Display
//		(Name = "First Name")]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20,
//		ErrorMessage = "The {0} value must be a string with a maximum length of '{1}'!")]
//	public string? FirstName { get; set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 30)]
//	public string? LastName { get; set; }
//	// **********
//}
//// **************************************************
//// **************************************************
//// **************************************************

//// **************************************************
//// *** User 05 **************************************
//// **************************************************
//// See:
//// CreateUser05Async() Function
//// **************************************************
//[Microsoft.EntityFrameworkCore.Index
//	(nameof(Username), IsUnique = true)]

//[Microsoft.EntityFrameworkCore.Index
//	(nameof(FirstName), nameof(LastName), IsUnique = false)]
//public class User05 : object
//{
//	public User05(string username) : base()
//	{
//		Ordering = 10_000;
//		Username = username;
//		Id = System.Guid.NewGuid();
//	}

//	// **********
//	//[System.ComponentModel.DataAnnotations.Display
//	//	(Name = "Identity")]

//	//[System.ComponentModel.DataAnnotations.Display
//	//	(Name = "شناسه")]

//	//[System.ComponentModel.DataAnnotations.Display
//	//	(ResourceType = typeof(Resources.DataDictionary),
//	//	Name = "Id")]

//	// سوتی می‌دهم
//	//[System.ComponentModel.DataAnnotations.Display
//	//	(ResourceType = typeof(Resources.DataDictionary),
//	//	Name = "Idd")]

//	[System.ComponentModel.DataAnnotations.Display
//		(ResourceType = typeof(Resources.DataDictionary),
//		Name = nameof(Resources.DataDictionary.Id))]

//	[System.ComponentModel.DataAnnotations.Key]

//	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
//		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
//	public System.Guid Id { get; private set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.Display
//		(ResourceType = typeof(Resources.DataDictionary),
//		Name = nameof(Resources.DataDictionary.Ordering))]

//	[System.ComponentModel.DataAnnotations.Range
//		(minimum: 1, maximum: 100_000,
//		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
//		ErrorMessageResourceName = nameof(Resources.Messages.Validations.Range))]
//	public int Ordering { get; set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.Display
//		(ResourceType = typeof(Resources.DataDictionary),
//		Name = nameof(Resources.DataDictionary.Username))]

//	[System.ComponentModel.DataAnnotations.Required
//		(AllowEmptyStrings = false,
//		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
//		ErrorMessageResourceName = nameof(Resources.Messages.Validations.Required))]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20,
//		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
//		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
//	public string Username { get; private set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.Display
//		(ResourceType = typeof(Resources.DataDictionary),
//		Name = nameof(Resources.DataDictionary.FirstName))]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20,
//		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
//		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
//	public string? FirstName { get; set; }
//	// **********

//	// **********
//	[System.ComponentModel.DataAnnotations.Display
//		(ResourceType = typeof(Resources.DataDictionary),
//		Name = nameof(Resources.DataDictionary.LastName))]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 30,
//		ErrorMessageResourceType = typeof(Resources.Messages.Validations),
//		ErrorMessageResourceName = nameof(Resources.Messages.Validations.MaxLength))]
//	public string? LastName { get; set; }
//	// **********
//}
//// **************************************************
//// **************************************************
//// **************************************************

//public class ApplicationDbContext : DbContext
//{
//	public ApplicationDbContext() : base()
//	{
//		Database.EnsureCreated();
//	}

//	//public DbSet<Category> Categories { get; set; }

//	protected override void OnConfiguring
//		(DbContextOptionsBuilder optionsBuilder)
//	{
//		var connectionString =
//			"Server=.;User ID=sa;Password=1234512345;Database=LEARNING_EF_CORE_0200;MultipleActiveResultSets=true;TrustServerCertificate=True;";

//		optionsBuilder.UseSqlServer
//			(connectionString: connectionString);
//	}
//	protected override void OnModelCreating(ModelBuilder modelBuilder)
//	{
//		modelBuilder.ApplyConfigurationsFromAssembly
//			(assembly: typeof(ApplicationDbContext).Assembly);
//	}
//}