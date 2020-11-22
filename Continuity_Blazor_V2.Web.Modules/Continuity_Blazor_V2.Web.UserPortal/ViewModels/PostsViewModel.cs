using Continuity_Blazor.Business.Models;
using Continuity_Blazor.Business.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Continuity_Blazor_V2.Web.UserPortal.ViewModels
{
    public class PostsViewModel : IPostsViewModel
    {
        private readonly IPostsBLL postsBLL;

        public PostsViewModel(IPostsBLL postsBLL)
        {
            this.postsBLL = postsBLL;

            PostModels = postsBLL.GetPosts();
        }

        public void HandleSearch(string filter)
        {
            PostModels = postsBLL.GetPosts(filter);
        }

        public List<PostModel> PostModels { get; set; }
    }
}
