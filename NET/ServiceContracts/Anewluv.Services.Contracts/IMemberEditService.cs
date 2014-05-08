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
    public interface IMemberEditService
    {
        //TO Do posibly move this to a separate service for benchmarking
        //member viewmodoem mapping and registration models mappers

        //TO DO move to unit test
        // registermodel mapregistrationtest();  
        //end of profile mapping

        //initial profile stuffs

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/updateprofilevisibilitysettings", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]      
        bool updateprofilevisibilitysettings(visiblitysetting model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getbasicsettingsmodel", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        BasicSettingsModel getbasicsettingsmodel(EditProfileModel editprofilemodel);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getappearancesettingsmodel", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        AppearanceSettingsModel getappearancesettingsmodel(EditProfileModel editprofilemodel);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getlifestylesettingsmodel", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        LifeStyleSettingsModel getlifestylesettingsmodel(EditProfileModel editprofilemodel);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getcharactersettingsmodel", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        CharacterSettingsModel getcharactersettingsmodel(EditProfileModel editprofilemodel);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/membereditbasicsettings", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]   
        AnewluvMessages membereditbasicsettings(EditProfileModel editprofilemodel);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/membereditappearancesettings", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]   
        AnewluvMessages membereditappearancesettings(EditProfileModel editprofilemodel);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/membereditlifestylesettings", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]   
        AnewluvMessages membereditlifestylesettings(EditProfileModel editprofilemodel);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/membereditcharactersettings", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]   
        AnewluvMessages membereditcharactersettings(EditProfileModel editprofilemodel);

    }
}
