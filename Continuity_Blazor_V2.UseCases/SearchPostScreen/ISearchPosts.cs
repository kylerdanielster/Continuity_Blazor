using Continuity_Blazor_V2.CoreBusiness.Models;
using System.Collections.Generic;

namespace Continuity_Blazor_V2.UseCases.SearchPostScreen
{
    public interface ISearchPosts
    {
        IEnumerable<Post> Execute(string filter = null);
    }
}