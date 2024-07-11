using System;
namespace LibraryMVC.Models
{
    public class Book
    {
        public int Id { get; set; }             //Int mi Long mu? Veri tiplerinin saklayabileceği maksimum değerlere göre belirlenir. 
                                                // ekstradan Id ile birlikte ISBN numarasıda özellik olarak verilmelidir.Çünkü bir kitabın adeti birden fazla olabilir
                                                // ama eğer aynı yayın evinden ise ISBN leri aynı olur. Bundan dolayı kitap üzerinde işlem yapmak Id özelliği belirtilmelidir. 
        public string? ISBN { get; set; }       //(?) işareti var ise null olabilir.
        public string Title { get; set; } = ""; //Title null değer olamaz.
        /*
        public Book()
        {
            Title = "";
        }
        */
        public short PageCount { get; set; }
        public short PublishingYear { get; set; }
        public string? Description { get; set; } 
        public int PrintCount { get; set; }
        public bool Banned { get; set; }
        public float Rating { get; set; }
        public List<Author>? Authors { get; set; }  //Bir kitabın birden fazla yazarı olabilir.(Birden fazla yazar olsa bile her yerde (publisherlarda) aynı sayı kadar yazar olur)
        public Publisher? Publisher { get; set; }   //Bir kitap birden fazla yayınevi tarafından çıkarabilir.Ondan dolayı List kullanmadık.Publisherların birbirinden farklı ISBN'leri vardır. Her kitap kaydının kendine özel publisherı vardır.
        public List<SubCategory>? SubCategories { get; set; }
        public List<Language>? Languages { get; set; }
        public Location? Location { get; set; }



    }

    public class Execute
    {
        public void Code()
        {
            int a = 3;
            string b = "abc";

            Book book = new Book();
        }
    }
}
