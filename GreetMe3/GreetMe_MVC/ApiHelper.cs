using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace GreetMe_MVC
{
    public static class ApiHelper
    {
        //we make it static because we only want one per application
        //opens up a tcp ip port
        //thread save, and support multiable concurrent calls
        //public static HttpClient ApiClient { get; set; } 
        public static HttpClient InitializeClient(string url)
        {
            var ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("http://localhost:5184/api/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return ApiClient;
        }
    }
}
