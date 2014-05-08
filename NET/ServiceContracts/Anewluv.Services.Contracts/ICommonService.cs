using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.Text;
using System.Web.Security;
using Anewluv.Domain.Data;
using Anewluv.Domain.Data.ViewModels;


namespace Anewluv.Services.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICommonService
    {


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getNETJSONdatefromISO", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string getNETJSONdatefromISO(DateValidateModel date);
       
     
        

    }
}
