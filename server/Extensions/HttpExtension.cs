using System.Text.Json;
using server.RequestHelpers;

namespace server.Extensions
{
    public static class HttpExtension
    {
        public static void AddPaginationToHeader(this HttpResponse response, MetaData metaData)
        {
            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            response.Headers.Append("Pagination", JsonSerializer.Serialize(metaData, options));
            response.Headers.Append("Access-Control-Expose-Headers", "Pagination");
        }
    }
}