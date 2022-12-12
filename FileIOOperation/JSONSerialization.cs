using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileIOOperation
{
    internal class JSONSerialization
    {

        public static void JsonDeSerialization()
        {
            string json = @"{
                'Name' : 'Hii Darshan',
                'Description' : 'HoW Are You?I am From BridgeLabz'
            }";
            BlogSites bsObj = JsonConvert.DeserializeObject<BlogSites>(json);
            Console.WriteLine("Name = {0} \nDescription = {1}", bsObj.Name, bsObj.Description);
        }
        public static void JsonSerialization()
        {
            BlogSites bsObj = new BlogSites()
            {
                Name = "Hii Darshan",
                Description = "HoW Are You?I am From BridgeLabz"
            };
            string jsonData = JsonConvert.SerializeObject(bsObj);
            Console.WriteLine(jsonData);
        }
        public class BlogSites
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}
