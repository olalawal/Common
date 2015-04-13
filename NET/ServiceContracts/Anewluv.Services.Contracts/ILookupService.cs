using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.Text;
using System.Web.Security;
using Anewluv.Domain.Data;
//using Shell.MVC2.Domain.Entities.Anewluv;
using Anewluv.Domain.Data.ViewModels;
using Nmedia.Infrastructure.DTOs;
//using Shell.MVC2.Domain.Entities.Anewluv.ViewModels;


namespace Anewluv.Services.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILookupService
    {

       


        #region "New Lookups"

        [WebGet(UriTemplate = "/getphotostatusdescriptionlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        List<lu_photostatusdescription> getphotostatusdescriptionlist();
          [WebGet(UriTemplate = "/getabusetypelist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        List<listitem> getabusetypelist();
          [WebGet(UriTemplate = "/getprofilestatuslist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getprofilestatuslist();
          [WebGet(UriTemplate = "/getphotoImagersizerformatlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getphotoImagersizerformatlist();

          [WebGet(UriTemplate = "/getphotosecurityleveltypelist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
          [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getphotosecurityleveltypelist();

          [WebGet(UriTemplate = "/getrolelist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<lu_role> getrolelist();
          [WebGet(UriTemplate = "/getsecurityleveltypelist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        List<listitem> getsecurityleveltypelist();
          [WebGet(UriTemplate = "/getshowmelist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getshowmelist();
          [WebGet(UriTemplate = "/getsortbytypelist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getsortbytypelist();
          [WebGet(UriTemplate = "/getsecurityquestionlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getsecurityquestionlist();
          [WebGet(UriTemplate = "/getflagyesnolist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        List<lu_flagyesno> getflagyesnolist();
          [WebGet(UriTemplate = "/getprofilefiltertypelist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getprofilefiltertypelist();

        #endregion


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebGet(UriTemplate = "/getsystempagesettinglist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        List<systempagesetting> getsystempagesettinglist();

          [WebGet(UriTemplate = "/getgenderlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        List<listitem> getgenderlist();

          [WebGet(UriTemplate = "/getageslist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        List<age> getageslist();

          [WebGet(UriTemplate = "/getmetricheightlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        List<metricheight> getmetricheightlist();

          [WebGet(UriTemplate = "/getbodycssbypagename/{pagename}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        string getbodycssbypagename(string pagename);
        //List<age> createagelist(); //not created by Initial Catalog= 


        #region "Criteria Appearance dropdowns"
          [WebGet(UriTemplate = "/getethnicitylist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getethnicitylist();
          [WebGet(UriTemplate = "/getbodytypelist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getbodytypelist();
          [WebGet(UriTemplate = "/geteyecolorlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> geteyecolorlist();
          [WebGet(UriTemplate = "/gethaircolorlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> gethaircolorlist();


        #endregion

        #region "Criteria Character Dropdowns"
          [WebGet(UriTemplate = "/getdietlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getdietlist();
          [WebGet(UriTemplate = "/getdrinkslist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getdrinkslist();
          [WebGet(UriTemplate = "/getexerciselist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getexerciselist();
          [WebGet(UriTemplate = "/gethobbylist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> gethobbylist();
          [WebGet(UriTemplate = "/gethumorlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> gethumorlist();
          [WebGet(UriTemplate = "/getpoliticalviewlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getpoliticalviewlist();
          [WebGet(UriTemplate = "/getreligionlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getreligionlist();
          [WebGet(UriTemplate = "/getreligiousattendancelist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getreligiousattendancelist();
          [WebGet(UriTemplate = "/getsignlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getsignlist();
          [WebGet(UriTemplate = "/getsmokeslist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getsmokeslist();



        #endregion

        #region "Criteria Lifestyle Dropdowns"
          [WebGet(UriTemplate = "/geteducationlevellist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> geteducationlevellist();

          [WebGet(UriTemplate = "/getemploymentstatuslist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getemploymentstatuslist();

          [WebGet(UriTemplate = "/gethavekidslist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> gethavekidslist();

          [WebGet(UriTemplate = "/getincomelevellist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getincomelevellist();

          [WebGet(UriTemplate = "/getlivingsituationlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getlivingsituationlist();

          [WebGet(UriTemplate = "/getlookingforlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getlookingforlist();

          [WebGet(UriTemplate = "/getmaritalstatuslist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getmaritalstatuslist();

          [WebGet(UriTemplate = "/getprofessionlist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getprofessionlist();

          [WebGet(UriTemplate = "/getwantskidslist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
          List<listitem> getwantskidslist();


        #endregion


    }
}
