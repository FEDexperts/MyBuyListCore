namespace WebApi.Models
{
    public class ListModel
    {
        public int listId { get; set; }
        public int ownerId { get; set; }
        public int itemId { get; set; }
        public string itemName { get; set; }
        public string itemUnit { get; set; }
        public decimal value;
    }
}