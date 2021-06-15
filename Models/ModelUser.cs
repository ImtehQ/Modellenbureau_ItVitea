using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modellenbureau.Models
{
    public class ModelUser : IdentityUser
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public byte Age { get; set; }
        public int BodySize { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
