using System;
using System.Collections.Generic;
using System.Text;

namespace Continuity_Blazor_V2.CoreBusiness.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public List<string> Comments { get; set; }
    }
}
