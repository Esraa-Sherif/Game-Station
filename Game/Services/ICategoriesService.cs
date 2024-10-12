using System.Reflection.Metadata.Ecma335;

namespace GameStation.Services
{
    public interface ICategoriesService
    {
        IEnumerable<SelectListItem> GetSelectList();

    }
}
