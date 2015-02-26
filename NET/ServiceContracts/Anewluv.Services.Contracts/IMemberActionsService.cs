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


        #region "Interest Methods"

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getmyrelationshipsfiltered", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getmyrelationshipsfiltered(ProfileModel model);


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoiaminterestedincount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<int> getwhoiaminterestedincount(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoisinterestedinmecount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<int> getwhoisinterestedinmecount(ProfileModel model);
       
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoisinterestedinmenewcount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task<int> getwhoisinterestedinmenewcount(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoiaminterestedin", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwhoiaminterestedin(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoisinterestedinme", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwhoisinterestedinme(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoisinterestedinmenew", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwhoisinterestedinmenew(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getmutualinterests", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getmutualinterests(ProfileModel model);
       
        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/checkinterest", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<bool> checkinterest(ProfileModel model);
        
        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/addinterest", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task addinterest(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removeinterestbyprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removeinterestbyprofileid(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removeinterestbyinterestprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removeinterestbyinterestprofileid(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restoreinterestbyprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restoreinterestbyprofileid(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restoreinterestbyinterestprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restoreinterestbyinterestprofileid(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removeinterestsbyprofileidandscreennames", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removeinterestsbyprofileidandscreennames(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restoreinterestsbyprofileidandscreennames", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restoreinterestsbyprofileidandscreennames(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updateinterestviewstatus", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task updateinterestviewstatus(ProfileModel model);



        #endregion

        #region "peek methods"

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoipeekedatcount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task<int> getwhoipeekedatcount(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhopeekedatmecount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task<int> getwhopeekedatmecount(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhopeekedatmenewcount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task<int> getwhopeekedatmenewcount(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhopeekedatme", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwhopeekedatme(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhopeekedatmenew", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwhopeekedatmenew(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoipeekedat", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwhoipeekedat(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getmutualpeeks", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getmutualpeeks(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/checkpeek", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<bool> checkpeek(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/addpeek", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task addpeek(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removepeekbyprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removepeekbyprofileid(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removepeekbypeekprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removepeekbypeekprofileid(ProfileModel model);
        
        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restorepeekbyprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restorepeekbyprofileid(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restorepeekbypeekprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restorepeekbypeekprofileid( ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removepeeksbyprofileidandscreennames", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removepeeksbyprofileidandscreennames(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restorepeeksbyprofileidandscreennames", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restorepeeksbyprofileidandscreennames(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updatepeekviewstatus", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task updatepeekviewstatus(ProfileModel model);

        #endregion

        #region "block methods"

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoiblockedcount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task<int> getwhoiblockedcount(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoiblocked", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwhoiblocked(ProfileModel model);


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getmutualblocks", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getmutualblocks(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/checkblock", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<bool> checkblock(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/addblock", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task addblock(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removeblock", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removeblock(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restoreblock", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restoreblock(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removeblocksbyscreennames", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removeblocksbyscreennames(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restoreblocksbyscreennames", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restoreblocksbyscreennames(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updateblockreviewstatus", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task updateblockreviewstatus(ProfileModel model);

        #endregion

        #region "Like methods"

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoilikecount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task<int> getwhoilikecount(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwholikesmecount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task<int> getwholikesmecount(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoislikesmenewcount", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task<int> getwhoislikesmenewcount(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwholikesmenew", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwholikesmenew(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwholikesme", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwholikesme(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getwhoilike", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getwhoilike(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/getmutuallikes", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<SearchResultsViewModel> getmutuallikes(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
       [WebInvoke(UriTemplate ="/checklike", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<bool> checklike(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/addlike", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task addlike(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removelikebyprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removelikebyprofileid(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removelikebylikeprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removelikebylikeprofileid( ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restorelikebyprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restorelikebyprofileid(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restorelikebylikeprofileid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restorelikebylikeprofileid( ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/removelikesbyprofileidandscreennames", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task removelikesbyprofileidandscreennames(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/restorelikesbyprofileidandscreennames", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task restorelikesbyprofileidandscreennames(ProfileModel model);

        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updatelikeviewstatus", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task updatelikeviewstatus(ProfileModel model);


        #endregion

    }
}
