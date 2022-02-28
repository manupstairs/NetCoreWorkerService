using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreWorkerService
{

    public class JokeService
    {
        public static int Count { get; set; }
        public string GetJoke()
        {
            return $"No joke here... {++Count}";
        }
    }
}