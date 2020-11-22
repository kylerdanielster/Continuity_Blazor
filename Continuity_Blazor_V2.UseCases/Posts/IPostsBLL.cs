using Continuity_Blazor.Business.Models;
using Continuity_Blazor_V2.CoreBusiness.Models;
using System.Collections.Generic;

namespace Continuity_Blazor.Business.Posts
{
    public interface IPostsBLL
    {
        List<PostModel> GetPosts(string filter = null);

        PostModel GetPost(int id);
    }
}