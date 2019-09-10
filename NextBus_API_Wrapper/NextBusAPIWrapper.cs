using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NextBus_API_Wrapper
{
    class NextBusAPIWrapper
    {
        static readonly HttpClient client = new HttpClient();
        public static async Task<XmlDocument> CommandQuery(string agency, string command, string[] parameters, string[] values)
        {
            XmlDocument xmlDoc = new XmlDocument();

            string[] parameterValues = parameters;

            string url = @"http://webservices.nextbus.com/service/publicXMLFeed?command=" + command;

            for (int i = 0; i < parameterValues.Length; i++)
            {
                parameterValues[i] += "=" + values[i];
                url += "&" + parameterValues;
            }

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                System.IO.Stream stream = await response.Content.ReadAsStreamAsync();

                xmlDoc.Load(stream);

            }catch(HttpRequestException ex)
            {

            }
            return xmlDoc;
        }
    }
}
