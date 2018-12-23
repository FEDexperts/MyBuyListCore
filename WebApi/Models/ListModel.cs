using System;

namespace WebApi.Models
{
    public class ListModel
    {
        public int? ownerId { get; set; }
        public int? itemId { get; set; }
        public string itemName { get; set; }
        public string itemUnit { get; set; }
        public int? itemUnitId { get; set; }
        public decimal? value { get; set; }
        public Guid version { get; set; }

        public ListModel()
        {
            ownerId = null;
            itemId = null;
            itemName = null;
            itemUnit = null;
            itemUnitId = null;
            value = null;
            version = Guid.NewGuid();
        }
    }
    
}