namespace Disaster_Management.Models.Interface
{
    public interface IDisasterViewModel
    {
        public DisasterViewModel Model { get; set; }
        IEnumerable<DisasterViewModel> getAllDisasters();
    }
}
