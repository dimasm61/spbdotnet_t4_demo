using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Net.Http;

using System.Text.Json;

namespace RuntimeCodegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://jsonplaceholder.typicode.com/
            var url = "https://jsonplaceholder.typicode.com/users";

            using var client = new HttpClient();
            
            var jsonStr = client.GetStringAsync(url).GetAwaiter().GetResult();
            
            var users = JsonSerializer.Deserialize<List<User>>(jsonStr);
            
            var template = new RuntimeTextTemplate1(users);
            
            var str = template.TransformText();
            
            Console.WriteLine(str);

            Console.ReadLine();

        }
    }
}