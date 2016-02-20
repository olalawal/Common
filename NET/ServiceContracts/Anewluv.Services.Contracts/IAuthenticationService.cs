using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using System.ServiceModel;
using System.Text;
using System.Web.Security;

using Anewluv.Domain.Data;
using Anewluv.Domain.Data.ViewModels;
using Anewluv.Services.Contracts.ServiceResponse;
using System.ServiceModel.Web;
using System.Threading.Tasks;
using Nmedia.Infrastructure.Domain.Data.CustomClaimToken;




namespace Anewluv.Services.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAuthenticationService                    
    {


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(MembershipUserViewModel))]
        [WebInvoke(UriTemplate = "/createuser", ResponseFormat = WebMessageFormat.Json,  BodyStyle = WebMessageBodyStyle.Bare)]
        Task<AnewluvResponse> createuser(MembershipUserViewModel model);
                  
   

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebGet(UriTemplate = "/applicationname", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]	      
        string applicationname();


       // [WebInvoke(UriTemplate =
       // "/CreateUser/{username}/{password}/{email}/{securityQuestion}/{securityAnswer}/{isApproved}/{providerUserKey}",
       // Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]	


     

        //[OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        //[ServiceKnownType(typeof(AnewLuvMembershipUser))]
        //[WebInvoke(UriTemplate = "/createusercustom", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        //AnewLuvMembershipUser  createusercustom(MembershipUserViewModel model);

        //[OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        //[WebGet(UriTemplate = "/resetpassword/{username}/{answer}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]	
        //string resetpassword(string username, string answer);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/changepassword", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<string> changepassword(MembershipUserViewModel user);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/resetpassword", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<string> resetpassword(MembershipUserViewModel user);
            
            //handles reseting password duties.  First verifys that security uqestion was correct for the profile ID, the generated a password
            // using the local generatepassword method the send the encyrpted passwoerd and profile ID to the dating service so it can be updated in the DB
            //finally returns the new password to the calling functon or an empty string if failure.
        //[OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        //[WebGet(UriTemplate = "/resetpasswordcustom/{profileid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]	  
        // string resetpasswordcustom(string profileid) ;

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(AnewLuvMembershipUser))]
        [WebInvoke(UriTemplate = "/updateuser", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
              void updateuser(MembershipUser user);


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebGet(UriTemplate = "/getuser/{username}/{userisonline}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]	
        MembershipUser getuser(string username, string  userIsOnline);
           
            //custom remapped membership get user function
     
        //[OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        //[WebGet(UriTemplate = "/getusercustom/{username}/{userisonline}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]	
        //AnewLuvMembershipUser getusercustom(string username, string  userisonline);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebGet(UriTemplate = "/generatepassword", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]	                         
         string generatepassword()  ;

        //validators duplicated in memberservcie
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(AnewLuvMembershipUser))]
        [WebInvoke(UriTemplate = "/checkifemailalreadyexists", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> checkifemailalreadyexists(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(AnewLuvMembershipUser))]
        [WebInvoke(UriTemplate = "/checkifopenidalreadyexists", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> checkifopenidalreadyexists(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(AnewLuvMembershipUser))]
        [WebInvoke(UriTemplate = "/checkifactivationcodeisvalid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> checkifactivationcodeisvalid(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(AnewLuvMembershipUser))]
        [WebInvoke(UriTemplate = "/checkifprofileisactivated", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> checkifprofileisactivated(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(AnewLuvMembershipUser))]
        [WebInvoke(UriTemplate = "/checkifusernamealreadyexists", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> checkifusernamealreadyexists(ProfileModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(AnewLuvMembershipUser))]
        [WebInvoke(UriTemplate = "/checkifscreennamealreadyexists", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> checkifscreennamealreadyexists(ProfileModel model);
        



        #region "Custom methods specific for AnewLuv"

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(AnewluvMessages))]
        [WebInvoke(UriTemplate = "/activateprofile", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<AnewluvMessages> activateprofile(activateprofilemodel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [ServiceKnownType(typeof(AnewluvMessages))]
        [WebInvoke(UriTemplate = "/recoveractivationcode", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<AnewluvMessages> recoveractivationcode(activateprofilemodel model);



        //new method that we want to use to return the profileID to validate somwhere else
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/validateuserandgettoken", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<NmediaToken> validateuserandgettoken(ProfileModel profile); 

         //new method that we want to use to return the profileID to validate somwhere else
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/validateuserandgettokenbyopenid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<NmediaToken> validateuserandgettokenbyopenid(ProfileModel model);

        //Logout handling
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/logoutuserandinvalidatetoken", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<Boolean> logoutuserandinvalidatetoken(ProfileModel profile);


        #endregion
        
        //[WebInvoke]
        //[OperationContract]
        //     void UpdateUserCustom(string username, string ProfileID,
        //            string password,
        //            string securityQuestion,
        //            string securityAnswer,
        //            DateTime birthdate, string gender, string country, string city, string zippostalcode);
            
           
        //TO DO expose the rest of these servces later
            //public bool CheckForUploadedPhotoByProfileID(string profileid);
           
            //public bool CheckIfPhotoCaptionAlreadyExists(string profileid, string photocaption);           

            //public bool checkifmailboxfoldersarecreated(string profileid)   ;        

            //public bool CheckIfEmailAlreadyExists(string email) ;         

            //public bool CheckIfProfileisActivated(string profileid);           

            //public bool ActivateProfile(string profileid);           

            //public bool createmailboxfolders(string profileid);           

            //public string GetUserNamebyProfileID(string profileid);           

            //public string GetScreenNamebyProfileID(string profileid);           

            //public string GetScreenNamebyUserName(string username);

            //// Other overrides not implemented
            
            //public  bool ChangePassword(string username, string oldPassword, string newPassword);           

            //public  bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer);           

            //public  bool DeleteUser(string username, bool deleteAllRelatedData);          

            //public  bool EnablePasswordReset();          

            //public  bool EnablePasswordRetrieval();            

            //public  MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)   ;       

            //public  MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)  ;          

            //public  MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
           
            //public  int GetNumberOfUsersOnline() ;         

            //public  string GetPassword(string username, string answer);
           
            //public  MembershipUser GetUser(object providerUserKey, bool userIsOnline)       ;    

            //public  string GetUserNameByEmail(string email)    ;       

            //public  int MaxInvalidPasswordAttempts()    ;      

            //public  int MinRequiredNonAlphanumericCharacters() ;          

            //public  int MinRequiredPasswordLength();          

            //public  int PasswordAttemptWindow();
           
            //public  MembershipPasswordFormat PasswordFormat();          

            //public  string PasswordStrengthRegularExpression();         

            //public  bool RequiresQuestionAndAnswer();

            //public  bool RequiresUniqueEmail();    

            //public  bool UnlockUser(string userName);
           

           



        


    }
}
