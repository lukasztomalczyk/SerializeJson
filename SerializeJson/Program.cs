using System;
using Newtonsoft.Json;

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

    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }

    static class ConverterJsonBothSide<T> where T : class
    {
        public static string SerializeObject(T item)
        {
            return JsonConvert.SerializeObject(item);
        }

        public static T DesializeObject(string item)
        {
            return (T)JsonConvert.DeserializeObject(item, typeof(T));
        }
    }
}
