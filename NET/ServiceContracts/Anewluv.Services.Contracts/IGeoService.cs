using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

using System.Text;

using GeoData.Domain.Models.ViewModels;
using Anewluv.Domain.Data.ViewModels;
using GeoData.Domain.ViewModels;
using System.Threading.Tasks;



namespace Anewluv.Services.Contracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code  config file together.
    [ServiceContract]
    public interface IGeoService
    {


     

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getcountrynamebycountryid", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<string> getcountrynamebycountryid(GeoModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/verifyorupdateregistrationgeodata", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<registermodel> verifyorupdateregistrationgeodata(registermodel model);
        //gets the country list  orders it
        //added sorting

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebGet(UriTemplate = "/getcountrypostalcodestatuslist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task <List<countrypostalcode>> getcountrypostalcodestatuslist();

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebGet(UriTemplate = "/getcountrylist", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<List<country>> getcountrylist();

        /// <summary>
        /// Gets the Status of weather this country has valid postal codes or just GeoCodes which are just id values identifying a city
        /// </summary>
        ///       

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getpostalcodestatusbycountryname", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<bool> getpostalcodestatusbycountryname(GeoModel model);


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getcountryidbycountryname", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<int> getcountryidbycountryname(GeoModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getcitystateprovincelistbycountrynamepostalcodefilter", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<List<citystateprovince>> getcitystateprovincelistbycountrynamepostalcodefilter(GeoModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getgpsdatalistbycountrycitypostalcode", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<List<gpsdata>> getgpsdatalistbycountrycitypostalcode(GeoModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getgpsdatabycountrycity", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<gpsdata> getgpsdatabycountrycity(GeoModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getgpsdatabycitycountrypostalcode", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task<gpsdata> getgpsdatabycitycountrypostalcode(GeoModel model);


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getpostalcodesbycountrycityfilter", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task <List<postalcode>> getpostalcodesbycountrycityfilter(GeoModel model);
        //gets the single geo code as string

        //[OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        //[WebGet(UriTemplate = "/getpostalcodesbycountrynamecity/{country}/{city}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        //List<postalcode> getpostalcodesbycountrynamecity(string country, string city);


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/validatepostalcodebycountrycitypostalcode", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
       Task< bool> validatepostalcodebycountrycitypostalcode(GeoModel model);


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getpostalcodesbycountryandlatlong", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<List<postalcode>> getpostalcodesbycountrylatlong(GeoModel model);


        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getpostalcodesbycountrynamecitystateprovince", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<List<postalcode>> getpostalcodesbycountrynamecitystateprovince(GeoModel model);

        //TO DO move these lookups to geo
        // List<string> getcountrylist(string country);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getfilteredcitybycountrypostalcodefilter", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<List<citystateprovince>> getfilteredcitybycountrypostalcodefilter(GeoModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getfilteredcitybycountrycityfilter", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<List<citystateprovince>> getfilteredcitybycountrycityfilter(GeoModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getfilteredcitybycountryidcityfilter", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]       
        Task<List<citystateprovince>> getfilteredcitybycountryidcityfilter(GeoModel model);       

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getfilteredpostalcodesbycountrycityfilter", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
         Task<List<postalcode>> getfilteredpostalcodesbycountrycityfilter(GeoModel model);

        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getfilteredpostalcodesbycountryidcityfilter", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<List<postalcode>> getfilteredpostalcodesbycountryidcityfilter(GeoModel model);




        [OperationContract(), FaultContractAttribute(typeof(ServiceFault), Action = "http://Schemas.Testws.Medtox.com")]
        [WebInvoke(UriTemplate = "/getdistancebetweenmembers", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Task<double?> getdistancebetweenmembers(GeoModel model);

    }

}
