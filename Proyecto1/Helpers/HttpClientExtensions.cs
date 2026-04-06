using System.Text;
using System.Text.Json;

namespace Proyecto1.Helpers
{
    public static class HttpClientExtensions
    {
        public static async Task<T> ReadContentAsync<T>(this HttpResponseMessage respuesta)
        {
            if (respuesta.IsSuccessStatusCode == false)
            {
                throw new ApplicationException($"No se pudo conectar con el Api: {respuesta.ReasonPhrase}");
            }
            var dataString = await respuesta.Content.ReadAsStringAsync().ConfigureAwait(false);
            var resultado = JsonSerializer.Deserialize<T>(
                dataString, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                });
            return resultado;
        }

        public static StringContent ToJsonContent<T>(this T obj)
        {
            return new StringContent(
                JsonSerializer.Serialize(obj),
                Encoding.UTF8,
                "application/json"
            );
        }
    }
}
