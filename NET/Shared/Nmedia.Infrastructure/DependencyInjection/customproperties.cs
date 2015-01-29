using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//add properties for all Nemedia databases 
namespace Nmedia.Infrastructure.DependencyInjection
{
         public class IAnewluvEntitesScope : Attribute { }
        public class InSpatialEntitesScope : Attribute { }
        public class InVariosEntitiesScope : Attribute { }
    
}
