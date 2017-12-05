using System;
using RestSharp;

namespace WebServiceTest.Utils
{
    public class RestHelper
    {
        public static IRestResponse<T> ExecuteRequest<T>(RestRequest request, string url) where T:new()
        {
            var client = new RestClient(url);
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var responceException = new ApplicationException(message, response.ErrorException);
                throw responceException;
            }
            return response;
        }
    }
}
