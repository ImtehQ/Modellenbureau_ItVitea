using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modellenbureau.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string ImgData { get; set; }
        public ModelUser ModelUser { get; set; }
    }
}
