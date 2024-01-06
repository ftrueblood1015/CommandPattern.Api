using CommandPattern.BlazorServer.Services;
using Newtonsoft.Json;
using System.Net;

namespace CommandPattern.BlazorServer
{
    public static class Extensions
    {
        public static async Task<T> GetData<T>(this ApiServerClient client, Uri uri)
        {
            uri = uri.VerifyNotNull();
            client = client.VerifyNotNull();

            string rawData = await client.Client.GetStringAsync(uri);

            var data = JsonConvert.DeserializeObject<T>(rawData);

            if (data == null)
            {
                return Activator.CreateInstance<T>();
            }

            return data;
        }

        public static async Task<T?> GetData<T>(this HttpResponseMessage response)
                where T : class
        {
            response = response.VerifyNotNull();
            switch (response.StatusCode)
            {
                case HttpStatusCode.Created:
                case HttpStatusCode.OK:
                    string rawData = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(rawData);

                case HttpStatusCode.Conflict:
                case HttpStatusCode.UnprocessableEntity:
                    string conflictingUserMessage = await response.Content.ReadAsStringAsync();
                    throw new ArgumentException(conflictingUserMessage);

                default:
                    return null;
            }
        }

        public static T VerifyNotNull<T>(this T? value)
        where T : class
        {
            switch (value)
            {
                case string strVal:
                    if (string.IsNullOrWhiteSpace(strVal))
                    {
                        throw new ArgumentNullException(nameof(value));
                    }

                    return value;

                default:
                    return value ?? throw new ArgumentNullException(nameof(value));
            }
        }
    }
}
