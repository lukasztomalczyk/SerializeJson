using System;

namespace SerializeJson
{
    class Program
    {
        static void Main(string[] args)
        {

            Book myFavoriteBook = new Book()
            {
                Id = 1,
                Title = "The Adventures of Sherlock Holmes",
                Author = "Sherlock Holmes"
            };

            var convertedObjectToJsonStream = myFavoriteBook.SerializeObject();
            
                        
            Console.WriteLine($"This is stream Json: {convertedObjectToJsonStream}");

            try
            {
                var convertedStreamToObject =  (Book)ConverterJsonBothSide.DesializeObject(convertedObjectToJsonStream, typeof(Book));
                Console.WriteLine($"Id: {convertedStreamToObject.Id}," +
                                  $" Title: {convertedStreamToObject.Title}," +
                                  $" Author: {convertedStreamToObject.Author}");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            Console.ReadKey();
        }
    }
}
