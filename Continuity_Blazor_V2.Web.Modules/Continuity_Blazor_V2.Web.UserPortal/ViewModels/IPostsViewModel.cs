using Continuity_Blazor.Business.Models;
using System.Collections.Generic;

namespace Continuity_Blazor_V2.Web.UserPortal.ViewModels
{
    public interface IPostsViewModel
    {
        List<PostModel> PostModels { get; set; }

        void HandleSearch(string filter);
    }
}