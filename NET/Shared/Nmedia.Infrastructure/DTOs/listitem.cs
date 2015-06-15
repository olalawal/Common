using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Nmedia.Infrastructure.DTOs
{    

        [DataContract]
        [Serializable]
        public class listitem 
        {          
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public bool selected { get; set; }
            [DataMember]
            public string description { get; set; }         
  


        }
    
}
