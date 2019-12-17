using System;
using System.Collections.Generic;

namespace prospectos_comerciales.Data.Entities
{
    public partial class Prospecto
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Comentarios { get; set; }
        public int IdCiudad { get; set; }
        public string TelefonoRecepcion { get; set; }
        public string PaginaWeb { get; set; }
        public int IdSector { get; set; }
        public string Recepcionista { get; set; }
        public int IdContacto { get; set; }
        public int IdColor { get; set; }

        public Ciudad IdCiudadNavigation { get; set; }
        public Color IdColorNavigation { get; set; }
        public Contacto IdContactoNavigation { get; set; }
        public Sector IdSectorNavigation { get; set; }
    }
}
