using Practice.Application.Contracts.Insfrastructure;
using Practice.Application.Models;
using RestSharp;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Practice.Infrastructure.Services
{
    internal class RequestExternalApiService : IRequestExternalApiService
    {
        public async Task<TleData> GetTleAPIData()
        {
            try
            {
                //var client = new RestClient("https://tle.ivanstanojevic.me/api/tle");
                //var request = new RestRequest("", Method.Get);

                //var result = await client.ExecuteAsync(request);

                HttpResponseMessage result = await new HttpClient().GetAsync("https://tle.ivanstanojevic.me/api/tle");

                if (result.IsSuccessStatusCode)
                {
                    TleData tleData = new();

                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        Converters = { new JsonStringEnumConverter(), }
                    };

                    string responseBody = await result.Content.ReadAsStringAsync();

                    var jsonObject = JsonSerializer.Deserialize<JsonElement>(responseBody, options);

                    if (jsonObject.TryGetProperty("member", out var memberArray))
                    {
                        List<Member> members = new List<Member>();

                        foreach (var memberElement in memberArray.EnumerateArray())
                        {
                            var name = memberElement.GetProperty("name").GetString();
                            members.Add(new Member { Name = name });
                        }

                        tleData.Member.AddRange(members);
                    }

                    return tleData;
                }
                else
                {
                    return new();
                }
            }
            catch (Exception)
            {
                return new();
            }
        }
    }
}
