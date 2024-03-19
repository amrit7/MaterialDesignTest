using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace WpfTest;

public class HttpPostCall
{
    private readonly string _baseUrl = "";

    private static HttpClient _httpClient = new HttpClient();

    public HttpPostCall()
    {
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("No Authorization");

        var currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var configFileFullPath = Path.Combine(currentDirectory, @"config\config.json");

        // **************
        // with the below lines and package Microsoft.Extensions.Configuration.Json 
        // the SetTestValue call fails
        // if you comment the below lines and remove the package
        // the SetTestValue call is successful
        // **************

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile(configFileFullPath)
            .Build();

        _baseUrl = configuration["baseUrl"];
    }

    public static async Task<bool> SetTestValue()
    {

        var valueTest = 1;

        // online test site
        // https://reqbin.com/post-online 

        var url = "https://reqbin.com/echo/post/json";

        var obj = new
        {
            Settings = new
            {
                id = valueTest
            }
        };

        var response = await _httpClient.PostAsJsonAsync(url, obj);

        return true;
    }
}
