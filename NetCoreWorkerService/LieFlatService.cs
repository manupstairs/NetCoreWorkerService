using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetCoreWorkerService
{

    public class LieFlatService
    {
        public static int Count { get; set; }
        public string LieFlat()
        {
            return $"Lie flat and play PS4 & Switch... {++Count}";
        }
    }
}