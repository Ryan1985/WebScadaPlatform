using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebScadaPlatform.Models
{
    public class TagModel
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }

        public dynamic Extensions { get; set; }
    }
}