using Microsoft.EntityFrameworkCore;

namespace GameStation.Services
{
    public interface IDevicesService
    {

        IEnumerable<SelectListItem> GetSelectList();

    }
}


