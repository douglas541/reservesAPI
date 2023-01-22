namespace ReservesAPI.Models
{
    public class ReservationModel
    {
        public ReservationModel(int id, ClientModel client, DateTime reservationData)
        {
            Id = id;
            Client = client;
            ReservationData = reservationData;
        }

        public int Id { get; set; }
        public ClientModel Client { get; set; }
        public DateTime ReservationData { get; set; }
    }
}
