namespace mvc_app.Models
{
    public class Books
    {
        public string[] Library { get; set; }
        public string FavoriteBook { get; set; }
        public Books()
        {
            Library=["Programming in C#",
                     "Introduction to Algorithms",
                     "Design Patterns: Elements of Reusable Object-Oriented Software",
                     "Clean Code: A Handbook of Agile Software Craftsmanship"];
            FavoriteBook = "Clean Code: A Handbook of Agile Software Craftsmanship";
        }
    
       }
}