using Continuity_Blazor.Business.Models;

namespace Continuity_Blazor_V2.Web.UserPortal.ViewModels
{
    public interface IViewPostViewModel
    {
        PostModel PostModel { get; set; }

        void GetPostModel(int id);
    }
}