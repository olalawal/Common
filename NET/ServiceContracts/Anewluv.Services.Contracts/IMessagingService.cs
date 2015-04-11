using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Anewluv.Domain.Data;
using Anewluv.Domain.Data.ViewModels;
using System.ServiceModel.Web;

namespace Anewluv.Services.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMembersService" in both code and config file together.
    [ServiceContract]
     public interface IMessagingService
    {

       
              
        // tobe deleted
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebGet(UriTemplate = "/sendmessage", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool sendmessage(ProfileModel model);
               
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/addmailfoxfolder", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         void addmailboxfoxfolder(ProfileModel model);
               
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebGet(UriTemplate = "/getallmailcountbyfolderid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         int getmailcountbyfolder(ProfileModel model);   
               
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebGet(UriTemplate = "/getallmailbyfolder/{folderid}/{profileid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         List<mailviewmodel> getmailpagedbyfolder(ProfileModel model);

         //TO DO a method to 
         [WebGet(UriTemplate = "/getallmailbyfolder/{folderid}/{profileid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         List<mailviewmodel> getfoldersdetailsbyprofileid(ProfileModel model);
        
        ////TO DO read out the description feild from enum using sample code
        //  [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        //[WebGet(UriTemplate = "/getmailmsgthreadbyuserid/{uniqueid}/{profileid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        // List<mailviewmodel> getmailmsgthreadbyuserid(int uniqueid, int profileid);      

              

    }
}
