using Anewluv.Domain.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.XPath;

namespace Anewluv.Services.Contracts
{
    public interface IOpenidService
    {
        //Jain Rain OPEN ID auth code 
        rpxprofile authinfojson(string token);
        // List<string> mappings(string primaryKey);
        string getcontents(string xpath_expr, XPathNavigator nav);
        //void map(string identifier, string primaryKey);
       // void unmap(string identifier, string primaryKey);
        rpxprofile apicalljson(string methodName, Dictionary<string, string> partialQuery);
        //End of JainRan code


    }
}
