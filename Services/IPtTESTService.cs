namespace pt_AB_Demo1_TEST.PtTEST
{
    public interface IPtTESTService
    {
        Task<List<Tasks>> GetTasks();

        Task<Tasks> PostTasks(object data, string contentType = "application/json");

        Task<List<Tasks>> DeleteTasks(string id);

        Task<Tasks> PutTasks(object data, string contentType = "application/json");
    }
}