using System;
namespace LibraryMVC.Models
{
	public class Publisher
	{
		public int Id { get; set; }
		public string Name { get; set; } = "";
		public string? Phone { get; set; }
		public string? EMail { get; set; }
		public string? ContactPerson { get; set; }
		public List<Book>? Books { get; set; }
	}
}

