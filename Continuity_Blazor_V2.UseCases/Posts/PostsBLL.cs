using Continuity_Blazor.Business.Models;
using Continuity_Blazor_V2.CoreBusiness.Models;
using Continuity_Blazor_V2.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Continuity_Blazor.Business.Posts
{
    public class PostsBLL : IPostsBLL
    {
        private readonly IPostRepository postRepository;

        public PostsBLL(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public List<PostModel> GetPosts(string filter = null)
        {
            var posts = postRepository.GetPosts(filter);
            var postModels = new List<PostModel>();

            foreach(var post in posts)
            {
                postModels.Add(new PostModel
                {
                    Body = post.Body,
                    Comments = post.Comments,
                    Id = post.Id,
                    Title = post.Title
                });
            }

            return postModels;
        }

        public PostModel GetPost(int id)
        {
            var post = postRepository.GetPost(id);
            return new PostModel
            { 
                Body = post.Body,
                Comments = post.Comments,
                Id = post.Id,
                Title = post.Title
            };

        }
    }
}
