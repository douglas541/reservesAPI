using Microsoft.AspNetCore.Mvc;
using ReservesAPI.Models;

namespace ReservesAPI.Controllers
{
    [ApiController]
    [Route("hmg/reservation")]
    public class ReservationController : ControllerBase
    {
        private static List<ReservationModel> _reservations = new List<ReservationModel>();

        [HttpGet]
        public IActionResult GetReservation()
        {
            return Ok(_reservations);
        }
        [HttpPost]
        public IActionResult CreateReservation([FromBody] ReservationModel reservation)
        {
            _reservations.Add(reservation);
            return Ok(_reservations);
        }
    }
}
