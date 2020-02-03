using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sodiacal_Sign.Models;
using System.ComponentModel.DataAnnotations;

namespace Sodiacal_Sign.Models
{
    public class UserForm
    {
               
        public string Name { get; set; }
                        
        
        public string Birthday { get; set; }
                
        
       public string BirthMonth { get; set; }
    }
}
