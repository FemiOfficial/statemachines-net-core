namespace src.web.api.infrastructure.Persistence.Entities
{
    public class Order
    {

        public long Id { get; set; }
        public long TaskId { get; set; }
        public string ProductName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }


    }
}