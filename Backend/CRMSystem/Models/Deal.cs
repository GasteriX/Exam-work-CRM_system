namespace CRMSystem.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client? Client { get; set; }
        public string? Status { get; set; }
        public decimal? Amount { get; set; }
    }
}
