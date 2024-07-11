using System;
using System.ComponentModel.DataAnnotations;
namespace LibraryMVC.Models
{
	public class Language
	{
		[Key]  //Veri tabanında primary key oldugunu belirtir.
		public string Code { get; set; } = "";
        public string Name { get; set; } = "";
        public List<Book>? Books { get; set; }
	}
}

