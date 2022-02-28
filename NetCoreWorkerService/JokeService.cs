using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WorkerServiceTest1
{

    public class JokeService
    {
        public static int Count { get; set; }
        public string GetJoke()
        {
            return  $"No joke here... {++Count}";
        }
    }
}