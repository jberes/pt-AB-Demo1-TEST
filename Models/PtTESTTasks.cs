//namespace pt_AB_Demo1_TEST.Data.PtTEST; // Razor won't recognize third level namespace
namespace pt_AB_Demo1_TEST.PtTEST;

public class Tasks
{
    public double TaskId { get; set; }
    public string TaskName { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime DateDue { get; set; }
    public double ProjectId { get; set; }
    public string AssignedToEmail { get; set; }
    public double Priority { get; set; }
}
