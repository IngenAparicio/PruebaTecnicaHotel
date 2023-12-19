using System;
using System.Collections.Generic;

#nullable disable

namespace Prueba.Core.Entities
{
    public partial class Hotel
    {
        public Hotel()
        {
            HabitacionHotel = new HashSet<HabitacionHotel>();
        }

        public int Id { get; set; }
        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ciudad { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<HabitacionHotel> HabitacionHotel { get; set; }
    }
}
