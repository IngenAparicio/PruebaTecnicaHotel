using Prueba.Core.DTOs;
using Prueba.Core.Interfaces;
using Prueba.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Prueba.infraestructure.Access;

namespace Prueba.BL.Services
{
    public class HuespedesReservaServices : IHuespedesReservaServices
    {
        private readonly IHuespedesReservaDataAccess huespedesReservaDataAccess;
        private readonly IReservaDataAccess reservaDataAccess;
        private readonly IHotelDataAccess hotelDataAccess;
        public HuespedesReservaServices(IHuespedesReservaDataAccess _huespedesReservaDataAccess, 
            IReservaDataAccess _reservaDataAccess,
            IHotelDataAccess _hotelDataAccess)
        {
            huespedesReservaDataAccess = _huespedesReservaDataAccess;
            reservaDataAccess = _reservaDataAccess;
            hotelDataAccess = _hotelDataAccess;
        }        

        public ResponseQuery<HuespedesReservaDto> ObtenerHuespedesReserva(HuespedesReservaDto request, ResponseQuery<HuespedesReservaDto> response)
        {
            try
            {
                response.Result = huespedesReservaDataAccess.ObtenerHuespedesReserva(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HuespedesReservaDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<List<HuespedesReservaDto>> ListaHuespedesReserva(HuespedesReservaDto request, ResponseQuery<List<HuespedesReservaDto>> response)
        {
            try
            {
                response.Result = huespedesReservaDataAccess.ListaHuespedesReserva(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new List<HuespedesReservaDto>();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        public ResponseQuery<HuespedesReservaDto> CrearHuespedesReserva(HuespedesReservaDto request, ResponseQuery<HuespedesReservaDto> response)
        {
            try
            {
                response.Result = huespedesReservaDataAccess.CrearHuespedesReserva(request);
                EnviarCorreo(request);
                response.Exitosos = true;
            }
            catch (Exception ex)
            {
                response.Result = new HuespedesReservaDto();
                response.Mensaje = ex.Message;
                response.Exitosos = false;
            }
            return response;
        }

        private bool EnviarCorreo(HuespedesReservaDto request)
        {
            var reserva = new ReservaDto();
            reserva.Id = request.ReservaId.Value;
            reserva = reservaDataAccess.ObtenerReserva(reserva);
            var hotel = new HotelDto();
            hotel.Id = reserva.HotelId.Value;
            hotel = hotelDataAccess.ObtenerHotel(hotel);
            MailMessage message = new MailMessage();
            string from = "hotelPrueba27@outlook.com";
            string smtpCliente = "smtp-mail.outlook.com";
            string puerto = "587";
            string usuario = "hotelPrueba27@outlook.com";
            string clave = "Prueba123456";            
            string correoReporte = request.Correo;

            message.To.Add(new MailAddress(correoReporte));
            message.From = new MailAddress(from);
            message.Subject = "Reserva en el hotel: " + hotel.Nombre;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Body = "Señor/a: " + request.Nombre + ", usted tiene una reserva en el hotel: " + hotel.Nombre + " para las fechas: " + reserva.FechaInicio + " hasta " + reserva.FechaFin;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            new SmtpClient(smtpCliente)
            {
                EnableSsl = true,
                Port = Convert.ToInt32(puerto),
                Credentials = new NetworkCredential(usuario, clave),
                UseDefaultCredentials = false,
             }.Send(message);
            return true;
        }

    }
}
