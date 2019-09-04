using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace image_processing.Models
{
    public partial class tbl_Picture
    {
        public string picture_id { get; set; }
        public string operator_id { get; set; }
        public byte[] picture { get; set; }
    }
}