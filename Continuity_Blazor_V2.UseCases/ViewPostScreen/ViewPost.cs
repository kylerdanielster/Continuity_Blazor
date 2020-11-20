using Continuity_Blazor_V2.CoreBusiness.Models;
using Continuity_Blazor_V2.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Continuity_Blazor_V2.UseCases.ViewPostScreen
{
    public class ViewPost : IViewPost
    {
        private readonly IPostRepository postRepository;

        public ViewPost(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public Post Execute(int id)
        {
            return postRepository.GetPost(id);
        }
    }
}
