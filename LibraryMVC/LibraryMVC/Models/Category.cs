using System;
namespace LibraryMVC.Models
{
	public class Category
	{
        public short Id { get; set; }
        public string Name { get; set; } = "";
        public List<SubCategory>? SubCategories { get; set; }

    }
}

