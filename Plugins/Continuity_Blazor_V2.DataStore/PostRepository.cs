using Continuity_Blazor_V2.CoreBusiness.Models;
using Continuity_Blazor_V2.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using Faker;

namespace Continuity_Blazor_V2.DataStore
{
    public class PostRepository : IPostRepository
    {
        private List<Post> posts;

        public PostRepository()
        {
            posts = new List<Post>
            {
                new Post { Id = 1, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence(), Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },
                new Post { Id = 2, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },
                new Post { Id = 3, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence(), Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },
                new Post { Id = 4, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence(), Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },
                new Post { Id = 5, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },
                new Post { Id = 6, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence(), Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },
                new Post { Id = 7, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence(), Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },
                new Post { Id = 8, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence(), Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },
                new Post { Id = 9, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence(), Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },
                new Post { Id = 10, Body = Faker.Lorem.Paragraph(), Comments = new List<string> { Faker.Lorem.Sentence(), Faker.Lorem.Sentence(), Faker.Lorem.Sentence() }, Title = Faker.Lorem.Sentence() },

            };

        }

        public IEnumerable<Post> GetPosts(string filter = null)
        {
            if (string.IsNullOrEmpty(filter)) return posts;

            return posts.Where(x => x.Title.ToLower().Contains(filter.ToLower()));
        }

        public Post GetPost(int id)
        {
            return posts.FirstOrDefault(x => x.Id == id);
        }
    }
}
