using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Anewluv.Services.Contracts
{
    class Class1
    {

        public Stream http_webinvoke_options()
        {
            WebOperationContext web_op_context = WebOperationContext.Current;
            OperationContext op_context = OperationContext.Current;
            WebHeaderCollection header_list = web_op_context.IncomingRequest.Headers;


            web_op_context.OutgoingResponse.StatusDescription = "OK";
            web_op_context.OutgoingResponse.StatusCode = HttpStatusCode.OK;
            web_op_context.OutgoingResponse.Headers.Add("Access-Control-Allow-Methods", "OPTIONS, POST, GET, PUT, DELETE");


            string headers = "";
            headers += "Content-Type, ";
            headers += "X-Requested-With, ";
            headers += "Accept";


            web_op_context.OutgoingResponse.Headers.Add("Access-Control-Allow-Headers", headers);
            web_op_context.OutgoingResponse.Headers.Add("Access-Control-Expose-Headers", headers);
            web_op_context.OutgoingResponse.Headers.Add("Accept", "*/*");
            web_op_context.OutgoingResponse.Headers.Add("Accept-Language", "en-US, en");
            web_op_context.OutgoingResponse.Headers.Add("Accept-Charset", "ISO-8859-1, utf-8");
            web_op_context.OutgoingResponse.Headers.Add("Connection", "keep-alive");


            string url = op_context.IncomingMessageHeaders.To.ToString();
            url = url.Replace(op_context.IncomingMessageHeaders.To.PathAndQuery, "");
            web_op_context.OutgoingResponse.Headers.Add("Host", url);
            web_op_context.OutgoingResponse.Headers.Add("Access-Control-Allow-Origin", "*");
            web_op_context.OutgoingResponse.Headers.Remove("Server");
            web_op_context.OutgoingResponse.Headers.Remove("X-Powered-By");
            return null;
        }

    }
}
