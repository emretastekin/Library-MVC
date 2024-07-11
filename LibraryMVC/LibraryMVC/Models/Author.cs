using System;
namespace LibraryMVC.Models
{
	public class Author
	{
        public long Id { get; set; }
        public string FullName { get; set; } = "";  //NULL olamaz
        public string? Biography { get; set; }
        public short BirthDate { get; set; }
        public short? DeathDate { get; set; }  //DeadTime Null olabilir
        public List<Book>? Books { get; set; } //Yazdığı kitapların listesi




    }
}

