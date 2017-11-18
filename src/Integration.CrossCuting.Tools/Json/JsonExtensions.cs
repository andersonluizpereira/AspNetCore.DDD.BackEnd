using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Integration.CrossCuting.Tools.Json
{
    public static class JsonExtensions
    {
        public static string ToJsonString(this object obj, bool camelCase = false, bool indented = false)
        {
            var options = new JsonSerializerSettings();

            if (camelCase)
            {
                options.ContractResolver = new CamelCasePropertyNamesContractResolver();
            }

            if (indented)
            {
                options.Formatting = Formatting.Indented;
            }

            options.Converters.Insert(0, new DateTimeConverter());

            return JsonConvert.SerializeObject(obj, options);
        }

        public static string ReturnContent(Task<HttpResponseMessage> resultJson)
        {
            var response = resultJson.Result.EnsureSuccessStatusCode();

            return response.Content.ReadAsStringAsync().Result;

        }

    }
}
