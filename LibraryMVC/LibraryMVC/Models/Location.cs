using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryMVC.Models
{
	public class Location
	{
		[Key]
		public string Shelf { get; set; } = "";
		public List<Book>? Books { get; set; }

	}
}

