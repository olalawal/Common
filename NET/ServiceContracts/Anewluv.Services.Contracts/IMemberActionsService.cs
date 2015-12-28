using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using Anewluv.Domain.Data.ViewModels;
using Anewluv.Domain.Data;
using System.Threading.Tasks;


namespace Anewluv.Services.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMembersService" in both code and config file together.
    [ServiceContract]
    public interface IMemberActionsService
    {
        #region "Agregate functions"

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getmemberactionsbyprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<MemberActionsModel> getmemberactionsbyprofileid(ProfileModel model);

        #endregion


     



        
        //count methods first
        /// <summary>
        /// count all total interests
        /// </summary>    
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getmyactioncount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<int> getmyactioncount(ProfileModel model);


        //count methods first
        /// <summary>
        /// count all total interests
        /// </summary>    
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getothersactioncount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<int> getothersactioncount(ProfileModel model);
  

        //count methods first
        /// <summary>
        /// count all total interests
       [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getothersactioncountnew", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<int> getothersactioncountnew(ProfileModel model);
 

        /// <summary>
        /// //gets list of all the profiles I am interested in
        /// count all total interests
       [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getmyaction", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<SearchResultsViewModel> getmyaction(ProfileModel model);
 
        //1/18/2011 modifed results to use correct ordering
        /// <summary>
        /// //gets all the members who are interested in me
        /// count all total interests
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getothersaction", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<SearchResultsViewModel> getothersaction(ProfileModel model);

        /// <summary>
        /// //gets all the members who are interested in me, that ive not viewd yet
        /// count all total interests
       [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getothersactionnew", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<SearchResultsViewModel> getothersactionnew(ProfileModel model);


        /// <summary>
        ///  //returns a list of all mutal profiles i.e people who you both interest 
        ///  //not inmplemented
         /// count all total interests
       [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getmutualactions", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<SearchResultsViewModel> getmutualactions(ProfileModel model);
  
        /// <summary>
        /// //checks if you already sent and interest to the target profile
          /// count all total interests
       [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/checkaction", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)] 
         Task<bool> checkaction(ProfileModel model);

        /// <summary>
        /// Adds a New interest
              [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/addmyaction", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)] 
         Task addmyaction(ProfileModel model);
       

        /// <summary>
        ///  //Removes an interest i.e changes the interest to deleted so they do not shwo up to you anymore unless filtered in that person anymore
        ///  Right now it is a straight delete no history i.e you could keep spamming but they can interest u
        ///  //not inmplemented
         /// count all total interests
       [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removemyactionbyprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removemyactionbyprofileid(ProfileModel model);
      
        /// <summary>
        ///  Update interest with a view     
       /// count all total interests
       [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updateotheractionviewstatus", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task updateotheractionviewstatus(ProfileModel model);
       

        /// <summary>
        ///  //Removes an interest i.e changes the interest to deleted so they do not shwo up to you anymore unless filtered in that person anymore
        ///  Right now it is a straight delete no history i.e you could keep spamming but they can interest u
        ///  //not inmplemented
         /// count all total interests
       [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removeothersactionbyprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
          Task removeothersactionbyprofileid(ProfileModel model);
     
     
        

        ///// <summary>
        ///// NOT IMPLEMENTED YET
        /////  //Removes an iterest i.e makes you not interested in that person anymore
        /////  //removed multiples 
        //  /// count all total interests
        // [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        // [WebInvoke(UriTemplate = "/removeactionsbyprofileidandscreennames", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        //  Task removeactionsbyprofileidandscreennames(ProfileModel model);
 


         /// <summary>
         ///  //Removes an iterest i.e makes you not interested in that person anymore
         ///  //removed multiples 
         /// count all total interests
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/removeothersactionnbyprofileidbulk", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removeothersactionnbyprofileidbulk(ProfileModel model);

        
         /// <summary>         ///  
         ///  bulk rmove of this users actions to others i.e blocks or mypeeks etc
         /// count all total interests
         [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
         [WebInvoke(UriTemplate = "/removemyactionbyprofileidbulk", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removemyactionbyprofileidbulk(ProfileModel model);

  
     

    }
}
