namespace TodoApp.UI.Helpers
{
    public class HttpClientInstance
    {
        public static HttpClient CreateClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7270/api/");
            return client;
        }
    }
}
