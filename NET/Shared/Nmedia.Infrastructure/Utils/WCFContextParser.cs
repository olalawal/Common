using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Nmedia.Infrastructure.Utils
{
    public class WCFContextParser
    {
        const string APIKEY = "apikey";

        public static string GetRequestIP(OperationContext context)
        {
            try
            {
                MessageProperties prop = context.IncomingMessageProperties;
                RemoteEndpointMessageProperty endpoint = prop[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;
                string ip = endpoint.Address;

                return ip;
            }
            catch (Exception ex)
            {

               
                throw ex;
            }
        }

        public static string GetUserAgent(OperationContext operationContext)
        {

            try
            {
                var message = operationContext.RequestContext.RequestMessage;
                var request = (HttpRequestMessageProperty)message.Properties[HttpRequestMessageProperty.Name];
                string agent = request.Headers[HttpRequestHeader.UserAgent];

                return agent;



                // string username = operationContext.IncomingMessageHeaders.GetHeader<string>("username","");
                //  string password = operationContext.IncomingMessageHeaders.GetHeader <string>("password", string.Empty);
                // return _membmbershipprovider.ValidateUser(username, password);
            }
            catch (Exception ex)
            {
                //return false;
                throw ex;

            }

        }


        public static Guid? GetAPIKey(OperationContext operationContext)
        {


            // Get the request message
            var request = operationContext.RequestContext.RequestMessage;


            // Get the HTTP Request
            var requestProp = (HttpRequestMessageProperty)request.Properties[HttpRequestMessageProperty.Name];
            // Get the query string
            // NameValueCollection queryParams = HttpUtility.get(requestProp.Headers);

            var prop = (HttpRequestMessageProperty)request.Properties[HttpRequestMessageProperty.Name];

            var dd = prop.Headers[APIKEY];

            if (dd != null)
            {
                Guid apiKey;
                Guid.TryParse(prop.Headers[APIKEY], out apiKey);

                return apiKey;
            }
            return null;

            //var dd = operationContext.IncomingMessageHeaders.Where(p=>p.Name == APIKEY);

            // if (operationContext.IncomingMessageHeaders.FindHeader(APIKEY, "") != -1)
            // {
            //     MessageHeaders headers = operationContext.IncomingMessageHeaders;
            //     string apikey = headers.GetHeader<string>(APIKEY, "");
            //     return apikey;
            // }


            // Return the API key (if present, null if not)
            // return queryParams[APIKEY];
        }

       

    }
}
