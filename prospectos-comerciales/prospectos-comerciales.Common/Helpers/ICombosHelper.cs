using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace prospectos_comerciales.Common.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboColors();
    }
}
