using Continuity_Blazor_V2.CoreBusiness.Models;

namespace Continuity_Blazor_V2.UseCases.ViewPostScreen
{
    public interface IViewPost
    {
        Post Execute(int id);
    }
}