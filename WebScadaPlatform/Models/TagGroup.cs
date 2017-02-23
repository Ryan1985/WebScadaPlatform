using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebScadaPlatform.Models
{
    public class TagGroupModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IList<TagModel> Tags { get; set; }
        public dynamic Extensions { get; set; }
    }
}