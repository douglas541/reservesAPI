using Microsoft.AspNetCore.Mvc;
using ReservesAPI.Models;

namespace ReservesAPI.Controllers
{
    [ApiController]
    [Route("v1/reservation")]
    public class ReservationController
    {
        private ReservationModel _reservation = new ReservationModel(1, new ClientModel(1, "Douglas"), DateTime.Now);

        [HttpGet(Name = "create")]
        public ReservationModel GetReservation()
        {
            return _reservation;
        }
    }
}
