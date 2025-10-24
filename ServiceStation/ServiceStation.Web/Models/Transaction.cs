namespace ServiceStation.Web.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int VehicleServiceId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public TranscationStatus status { get; set; } = TranscationStatus.New;
    }
}
