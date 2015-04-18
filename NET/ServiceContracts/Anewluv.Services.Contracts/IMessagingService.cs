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
         Task<MailFoldersViewModel> getmailfolderdetails(MailModel model);   
               
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/getmailfilteredandpaged", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<MailSearchResultsViewModel> getmailfilteredandpaged(MailModel model);


         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/updatemessage", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> updatemessage(MailModel model);
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/sendmessage", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> sendmessage(MailModel model);
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/deletemessagesfromfolder", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> deletemessagesfromfolder(MailModel model);
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/movemessagestofolder", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> movemessagestofolder(MailModel model);
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/addmailboxfolder", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> addmailboxfolder(MailModel model);
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/deletemailboxfolder", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<AnewluvMessages> deletemailboxfolder(MailModel model);
               

        ////TO DO read out the description feild from enum using sample code
        //  [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        //[WebInvoke(UriTemplate = "/getmailmsgthreadbyuserid/{uniqueid}/{profileid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        // List<mailviewmodel> getmailmsgthreadbyuserid(int uniqueid, int profileid);      

              

    }
}
