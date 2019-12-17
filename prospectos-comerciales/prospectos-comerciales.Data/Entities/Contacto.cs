using System;
using System.Collections.Generic;

namespace prospectos_comerciales.Data.Entities
{
    public partial class Contacto
    {
        public Contacto()
        {
            Prospecto = new HashSet<Prospecto>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }

        public ICollection<Prospecto> Prospecto { get; set; }
    }
}
