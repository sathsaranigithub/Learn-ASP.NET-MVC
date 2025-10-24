namespace ServiceStation.Web.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; } 
        public string Model { get; set; }
        public int year { get; set; } 
        public string Color { get; set; } 
        public bool IsDeleted { get; set; } = false;

        //foregin key , one vehicale has one customer 1:1 relationship
        public int CustomerId { get; set; }
    }
}
