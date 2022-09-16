using System.Net.Http;
using System.Threading.Tasks;

namespace TicketsController.Infra.Repository
{
    public class HttpRepository
    {
        private HttpClient _request = new();

        public async Task<string> GetRequest(string address)
        {
            var response =  _request.GetAsync(address);
            response.Wait();

            return !response.Result.StatusCode.Equals(System.Net.HttpStatusCode.OK)
                ? throw new HttpRequestException($"{response.Result.StatusCode}")
                : await response.Result.Content.ReadAsStringAsync();
        }
    }
}
