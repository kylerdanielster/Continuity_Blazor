using Continuity_Blazor.Business.Models;
using Continuity_Blazor.Business.Posts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Continuity_Blazor_V2.Web.UserPortal.ViewModels
{
    public class ViewPostViewModel : IViewPostViewModel
    {
        public PostModel PostModel { get; set; }

        private readonly IPostsBLL postsBLL;

        public ViewPostViewModel(IPostsBLL postsBLL)
        {
            this.postsBLL = postsBLL;
        }

        public void GetPostModel(int id)
        {
            PostModel = postsBLL.GetPost(id);
        }

    }
}
