using Microsoft.AspNetCore.Mvc.Rendering;
using prospectos_comerciales.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace prospectos_comerciales.Common.Helpers
{
    public class CombosHelper: ICombosHelper
    {
        private readonly SentryContext _dataContext;

        public CombosHelper(SentryContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> GetComboColors()
        {
            var list = _dataContext.Colors.Select(c => new SelectListItem
            {
                Text = c.Nombre,
                Value = $"{c.Id}"
            })
                .OrderBy(c => c.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Seleccione un color...]",
                Value = "0"
            });

            return list;
        }
    }
}
