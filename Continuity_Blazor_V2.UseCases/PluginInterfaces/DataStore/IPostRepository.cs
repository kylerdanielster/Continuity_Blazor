using Continuity_Blazor_V2.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Continuity_Blazor_V2.UseCases.PluginInterfaces.DataStore
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetPosts(string filter);

        Post GetPost(int id);
    }
}
