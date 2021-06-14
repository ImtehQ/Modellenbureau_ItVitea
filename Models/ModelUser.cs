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
        public List<Photo> Photos { get; set; }
    }

    public class Photo
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
    }
}
