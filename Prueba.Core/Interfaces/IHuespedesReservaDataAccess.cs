using Prueba.Core.DTOs;
using Prueba.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Core.Interfaces
{
    public interface IHuespedesReservaDataAccess
    {
        public HuespedesReservaDto ObtenerHuespedesReserva(HuespedesReservaDto request);

        public List<HuespedesReservaDto> ListaHuespedesReserva(HuespedesReservaDto request);

        public HuespedesReservaDto CrearHuespedesReserva(HuespedesReservaDto request);


    }
}
