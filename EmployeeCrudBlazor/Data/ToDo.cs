
namespace EmployeeCrudBlazor.Models
{
        public class ToDo
        {
            public int Id { get; set; }
            public DateTime TaskDate { get; set; }
            public string TaskName { get; set; }
            public string TaskDescription { get; set; }
            public string TaskImportanceScore { get; set; }
            public string TaskCategory { get; set; }
            public bool Completed { get; set; } 
    }
}
