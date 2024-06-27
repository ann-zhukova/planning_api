namespace PlanningAPI.Models
{
    public class ToDoTask
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required bool Status { get; set; }
        public uint? Time { get; set; }
    }
}
