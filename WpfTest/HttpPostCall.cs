using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest;

public class HttpPostCall
{
    private static HttpClient _httpClient = new HttpClient();

    public HttpPostCall()
    {
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("No Authorization");

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
