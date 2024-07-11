using System;
namespace LibraryMVC.Models
{
	public class SubCategory
	{
        public short Id { get; set; }
        public string Name { get; set; } = "";
        public Category? Category { get; set; }
        public List<Book>? Books { get; set; }


    }
}

