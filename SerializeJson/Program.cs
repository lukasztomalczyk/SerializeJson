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

            
            string ConvertedObjecToJsonStream = ConverterJsonBothSide<Book>.SerializeObject(myFavoriteBook);
            
            Console.WriteLine($"This is stream Json: {ConvertedObjecToJsonStream}");
            try
            {
                Book ConvertedStreamToBookClass =
                    (Book) ConverterJsonBothSide<Book>.DesializeObject(ConvertedObjecToJsonStream);
                
                Console.WriteLine($"Id: {ConvertedStreamToBookClass.Id}," +
                                  $" Title: {ConvertedStreamToBookClass.Title}," +
                                  $" Author: {ConvertedStreamToBookClass.Author}");
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
