using System;
using System.Collections.Generic;

namespace prospectos_comerciales.Data.Entities
{
    public partial class Color
    {
        public Color()
        {
            Prospecto = new HashSet<Prospecto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Prospecto> Prospecto { get; set; }
    }
}
