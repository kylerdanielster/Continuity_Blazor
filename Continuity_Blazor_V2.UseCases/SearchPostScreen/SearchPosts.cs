using Continuity_Blazor_V2.CoreBusiness.Models;
using Continuity_Blazor_V2.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Continuity_Blazor_V2.UseCases.SearchPostScreen
{
    public class SearchPosts : ISearchPosts
    {
        private readonly IPostRepository postRepository;

        public SearchPosts(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public IEnumerable<Post> Execute(string filter = null)
        {
            return postRepository.GetPosts(filter);
        }
    }
}
