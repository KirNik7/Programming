using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using static System.Environment;

namespace ProductsApp.Model
{
    /// <summary>
    /// Предоставляет методы для сериализации и десериализации данных.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Serializer"/>.
        /// </summary>
        static Serializer()
        {
            Path = $"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}"
                + "/ProductsApp/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="products">Список, который нужно сериализовать.</param>
        public static void Serialize(List<Product> products)
        {
            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(products));
            }
        }

        /// <summary>
        /// Реализует десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию товаров.</returns>
        public static List<Product> Deserialize()
        {
            var products = new List<Product>();

            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
                {
                    products = JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());
                }
                
                if (products == null)
                {
                    products = new List<Product>();
                }
            }
            catch
            {
                return products;
            }

            return products;
        }

        /// <summary>
        /// Возвращает и задаёт путь, где будут сериализоваться данные.
        /// </summary>
        public static string Path { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт имя файла.
        /// </summary>
        public static string FileName { get; set; }
    }
}
