using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Anewluv.Domain.Data;
using System.ServiceModel.Web;
using Anewluv.Domain.Data.ViewModels;
using System.Threading.Tasks;
using Anewluv.Domain.Data.ViewModels;

namespace Anewluv.Services.Contracts
{
    //TESTgfdgfdgfdgfdgfdgfdgfdgfdgfdgfdgfdg
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMembersService" in both code and config file together.
    [ServiceContract]
    public interface IMemberService
    {
        //TO Do posibly move this to a separate service for benchmarking
        //member viewmodoem mapping and registration models mappers

        //TO DO move to unit test
        // registermodel mapregistrationtest();  
        //end of profile mapping

        //initial profile stuffs
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getprofilebyusername",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        profile getprofilebyusername(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getprofileidbyopenid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        int? getprofileidbyopenid(ProfileModel model);



        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getprofiledatabyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        profiledata getprofiledatabyprofileid(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getperfectmatchsearchsettingsbyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<searchsetting> getperfectmatchsearchsettingsbyprofileid(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/createmyperfectmatchsearchsettingsbyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task createmyperfectmatchsearchsettingsbyprofileid(ProfileModel model);

        //get full profile stuff    
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getgenderbyscreenname",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string getgenderbyscreenname(ProfileModel model);

     
        //TO DO this needs to be  linked to roles

        //Message and Email Quota stuff
        // Description:	Updates the users logout time
        // added 1/18/2010 ola lawal
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/checkifquoutareachedandupdate",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool checkifquoutareachedandupdate(ProfileModel model);

        //Activate, Valiate if Profile is Acivated Code and Create Mailbox Folders as well"
        //update the Initial Catalog= i.e create folders and change profile status from guest to active ?!
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/createmailboxfolders",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task createmailboxfolders(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/activateprofile",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> activateprofile(ProfileModel model);

        //updates the profile with a password that is presumed to be already encyrpted
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updatepassword/{encryptedpassword}",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool updatepassword(ProfileModel model, string encryptedpassword);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/addnewopenidforprofile",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool addnewopenidforprofile(ProfileModel model);

        //check if profile is activated 
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/checkifprofileisactivated",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> checkifprofileisactivated(ProfileModel model);
        //check if mailbox folder exist

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/checkifmailboxfoldersarecreated",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> checkifmailboxfoldersarecreated(ProfileModel model);

        //DateTimeFUcntiosn for longin etc "
        //********************************************
        // Description:	Updates the users logout time
        // added 1/18/2010 ola lawal
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updateuserlogouttimebyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task updateuserlogouttimebyprofileid(ProfileModel model);



        //get the last time the user logged in from profile
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getmemberlastlogintimebyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<DateTime?> getmemberlastlogintimebyprofileid(ProfileModel model);

        //updates all the areas  that handle when a user logs in 
        // added 1/18/2010 ola lawal
        //also updates the last log in and profile data

        //TO DO convert to asynch
        [OperationContract(AsyncPattern = true), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updateuserlogintimebyprofileidandsessionid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task updateuserlogintimebyprofileidandsessionid(ProfileModel model);



        //TO DO convert to asynch
        [OperationContract(AsyncPattern = true), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updateuserlogintimebyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task updateuserlogintimebyprofileid(ProfileModel model);

        //TO DO convert to asynch
        [OperationContract(AsyncPattern = true), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/addprofileactvity",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task addprofileactvity(ActivityModel model);

        //better method for adding multiple activities in one call 
        [OperationContract(AsyncPattern = true), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/addprofileactivities",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task addprofileactivities(List<ActivityModel> models);

         //TO DO convert to asynch
        [OperationContract(AsyncPattern = true), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/addprofileactvitygeodata",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task addprofileactvitygeodata(ActivityModel model);
        


        //date time functions '
        //***********************************************************
        //this function will send back when the member last logged in
        //be it This Week,3 Weeks ago, 3 months Ago or In the last Six Months
        //Ola Lawal 7/10/2009 feel free to drill down even to the day
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getlastloggedinstring/{logindate}",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string getlastloggedinstring(string logindate);

        //returns true if somone logged on
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getuseronlinestatus",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool getuseronlinestatus(ProfileModel model);

        //other standard verifcation methods added here
        /// <summary>
        /// Gets the Status of weather this country has valid postal codes or just GeoCodes which are just id values identifying a city
        /// 5/5/2012 als added check that the screen name withoute spaces does not match an existing one with no spaces either
        /// </summary>      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/checkifscreennamealreadyexists",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool checkifscreennamealreadyexists(ProfileModel model);

        //5-20-2012 added to check if a user email is registered  
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/checkifusernamealreadyexists",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool checkifusernamealreadyexists(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/validatesecurityansweriscorrect",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string validatesecurityansweriscorrect(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getprofileidbyusername",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        int? getprofileidbyusername(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getprofileidbyscreenname",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        int? getprofileidbyscreenname(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getprofileidbyssessionid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        int? getprofileidbyssessionid(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getusernamebyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string getusernamebyprofileid(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getscreennamebyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string getscreennamebyprofileid(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getscreennamebyusername",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        string getscreennamebyusername(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/checkifemailalreadyexists",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool checkifemailalreadyexists(ProfileModel model);
        // added by Deshola on 5/17/2011       
        //   byte[] GetGalleryPhotobyPhotoID(Guid strPhotoID);   
        //   byte[] GetGalleryPhotobyProfileID(int strProfileID); 
        //    byte[] GetGalleryPhotobyScreenName(string strScreenName);
        //    byte[] GetGalleryImagebyNormalizedScreenName(string strScreenName);   
        // bool InsertPhotoCustom(Shell.MVC2.Domain.Entities.Anewluv.photo newphoto);
        // bool CheckIfPhotoCaptionAlreadyExists(int strProfileID, string strPhotoCaption);  
        /// <summary>
        /// Determines wethare an activation code matches the value in the Initial Catalog= for a given profileID
        /// </summary>

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/checkifactivationcodeisvalid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool checkifactivationcodeisvalid(ProfileModel model);
        //  bool CheckForGalleryPhotobyProfileID(int strProfileID);
        //  bool CheckForUploadedPhotobyProfileID(int strProfileID);


        //Hereis where the members Repository stuff that was in the MVC project starts at
        //************************************************************************************
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getprofilebyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        profile getprofilebyprofileid(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/deactivateprofile",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        bool deactivateprofile(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getprofilevisibilitysettingsbyprofileid",RequestFormat=WebMessageFormat.Json , ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        visiblitysetting getprofilevisibilitysettingsbyprofileid(ProfileModel model);

        //mapper calls that use the appfabric cache
    }
}
