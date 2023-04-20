using System.Net.Http.Json;

namespace pt_AB_Demo1_TEST.PtTEST
{
    public class PtTESTService: IPtTESTService
    {
        private readonly HttpClient _http;

        public PtTESTService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Tasks>> GetTasks()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://pt-apiapp-test.azurewebsites.net/tasks", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<Tasks>>().ConfigureAwait(false);
            }

            return new List<Tasks>();
        }

        public async Task<Tasks> PostTasks(object data, string contentType = "application/json")
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, new Uri("https://pt-apiapp-test.azurewebsites.net/task", UriKind.RelativeOrAbsolute));
            request.Content = new StringContent(@"{
  ""taskId"": 123,
  ""taskName"": ""string"",
  ""dateAdded"": ""string"",
  ""dateUpdated"": ""string"",
  ""dateDue"": ""string"",
  ""projectId"": 123,
  ""assignedToEmail"": ""string"",
  ""priority"": 123
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Tasks>().ConfigureAwait(false);
            }

            return new Tasks();
        }

        public async Task<List<Tasks>> DeleteTasks(string id)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, new Uri($"https://pt-apiapp-test.azurewebsites.net/task/{id}", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<Tasks>>().ConfigureAwait(false);
            }

            return new List<Tasks>();
        }

        public async Task<Tasks> PutTasks(object data, string contentType = "application/json")
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, new Uri("https://pt-apiapp-test.azurewebsites.net/task", UriKind.RelativeOrAbsolute));
            request.Content = new StringContent(@"{
  ""taskId"": 123,
  ""taskName"": ""string"",
  ""dateAdded"": ""string"",
  ""dateUpdated"": ""string"",
  ""dateDue"": ""string"",
  ""projectId"": 123,
  ""assignedToEmail"": ""string"",
  ""priority"": 123
}", System.Text.Encoding.UTF8, "application/json");
            request.Content = JsonContent.Create(data);
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Tasks>().ConfigureAwait(false);
            }

            return new Tasks();
        }
    }
}