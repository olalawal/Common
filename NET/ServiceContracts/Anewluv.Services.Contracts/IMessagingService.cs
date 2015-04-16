using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Anewluv.Domain.Data;
using Anewluv.Domain.Data.ViewModels;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace Anewluv.Services.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMembersService" in both code and config file together.
    [ServiceContract]
     public interface IMessagingService
    {

       
              
    
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/getmailfolderdetails", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<List<mailfoldermodel>> getmailfolderdetails(MailModel model);   
               
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/getmailfilteredandpaged", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<List<mailviewmodel>> getmailfilteredandpaged(MailModel model);
        

         // tobe deleted
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/sendmessage", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> sendmessage(MailModel model);
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/deletemessages", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> deletemessages(MailModel model);
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/movemessages", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> movemessages(MailModel model);
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/addmailfoxfolder", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> addmailboxfoxfolder(MailModel model);
               

        ////TO DO read out the description feild from enum using sample code
        //  [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        //[WebInvoke(UriTemplate = "/getmailmsgthreadbyuserid/{uniqueid}/{profileid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        // List<mailviewmodel> getmailmsgthreadbyuserid(int uniqueid, int profileid);      

              

    }
}
