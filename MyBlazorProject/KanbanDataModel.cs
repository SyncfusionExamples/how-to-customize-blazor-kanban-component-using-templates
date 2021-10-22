using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlazorProject
{
    public class KanbanDataModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Tags { get; set; }
        public double Estimate { get; set; }
        public string Assignee { get; set; }
        public string AssigneeKey { get; set; }
        public int RankId { get; set; }
        public string Color { get; set; }

        public List<KanbanDataModel> GetTasks()
        {
            List<KanbanDataModel> TaskDetails = new List<KanbanDataModel>();
            TaskDetails.Add(new KanbanDataModel { 
                Id = "Task 1", 
                Title = "Task  - 29001", 
                Status = "Open", 
                Summary = "Analyze the new requirements gathered from the customer.", 
                Type = "Story", 
                Priority = "Low", 
                Tags = "Analyze,Customer", 
                Estimate = 3.5, 
                Assignee = "Nancy Davloio", 
                RankId = 1, 
                Color = "#8b447a", 
                AssigneeKey = "Nancy" 
            });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 2", Title = "Task  - 29002", Status = "InProgress", Summary = "Improve application performance", Type = "Improvement", Priority = "Normal", Tags = "Improvement", Estimate = 6, Assignee = "Andrew Fuller", RankId = 1, Color = "#7d7297", AssigneeKey = "Andrew" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 3", Title = "Task  - 29003", Status = "Open", Summary = "Arrange a web meeting with the customer to get new requirements.", Type = "Others", Priority = "Critical", Tags = "Meeting", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 2, Color = "#27AE60", AssigneeKey = "Janet" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 4", Title = "Task  - 29004", Status = "InProgress", Summary = "Fix the issues reported in the IE browser.", Type = "Bug", Priority = "Release Breaker", Tags = "IE", Estimate = 2.5, Assignee = "Janet Leverling", RankId = 2, Color = "#cc0000", AssigneeKey = "Janet" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 5", Title = "Task  - 29005", Status = "Review", Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Low", Tags = "Customer", Estimate = 3.5, Assignee = "Steven walker", RankId = 1, Color = "#cc0000", AssigneeKey = "Steven" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 6", Title = "Task  - 29007", Status = "Validate", Summary = "Validate new requirements", Type = "Improvement", Priority = "Low", Tags = "Validation", Estimate = 1.5, Assignee = "Robert King", RankId = 1, Color = "#7d7297", AssigneeKey = "Robert" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 7", Title = "Task  - 29009", Status = "Review", Summary = "Fix the issues reported in Safari browser.", Type = "Bug", Priority = "Release Breaker", Tags = "Fix,Safari", Estimate = 1.5, Assignee = "Nancy Davloio", RankId = 2, Color = "#cc0000", AssigneeKey = "Nancy" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 8", Title = "Task  - 29010", Status = "Close", Summary = "Test the application in the IE browser.", Type = "Story", Priority = "Low", Tags = "Review,IE", Estimate = 5.5, Assignee = "Margaret hamilt", RankId = 3, Color = "#8b447a", AssigneeKey = "Margaret" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 9", Title = "Task  - 29011", Status = "Validate", Summary = "Validate the issues reported by the customer.", Type = "Story", Priority = "High", Tags = "Validation,Fix", Estimate = 1, Assignee = "Steven walker", RankId = 1, Color = "#8b447a", AssigneeKey = "Steven" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 10", Title = "Task  - 29015", Status = "Open", Summary = "Show the retrieved data from the server in grid control.", Type = "Story", Priority = "High", Tags = "Database,SQL", Estimate = 5.5, Assignee = "Margaret hamilt", RankId = 4, Color = "#8b447a", AssigneeKey = "Margaret" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 11", Title = "Task  - 29016", Status = "InProgress", Summary = "Fix cannot open user’s default database SQL error.", Priority = "Critical", Type = "Bug", Tags = "Database,Sql2008", Estimate = 2.5, Assignee = "Janet Leverling", RankId = 4, Color = "#cc0000", AssigneeKey = "Janet" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 12", Title = "Task  - 29017", Status = "Review", Summary = "Fix the issues reported in data binding.", Type = "Story", Priority = "Normal", Tags = "Databinding", Estimate = 3.5, Assignee = "Janet Leverling", RankId = 4, Color = "#8b447a", AssigneeKey = "Janet" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 13", Title = "Task  - 29018", Status = "Close", Summary = "Analyze SQL server 2008 connection.", Type = "Story", Priority = "Release Breaker", Tags = "Grid,Sql", Estimate = 2, Assignee = "Andrew Fuller", RankId = 4, Color = "#8b447a", AssigneeKey = "Andrew" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 14", Title = "Task  - 29019", Status = "Validate", Summary = "Validate databinding issues.", Type = "Story", Priority = "Low", Tags = "Validation", Estimate = 1.5, Assignee = "Margaret hamilt", RankId = 1, Color = "#8b447a", AssigneeKey = "Margaret" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 15", Title = "Task  - 29020", Status = "Close", Summary = "Analyze grid control.", Type = "Story", Priority = "High", Tags = "Analyze", Estimate = 2.5, Assignee = "Margaret hamilt", RankId = 5, Color = "#8b447a", AssigneeKey = "Margaret" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 16", Title = "Task  - 29021", Status = "Close", Summary = "Stored procedure for initial data binding of the grid.", Type = "Others", Priority = "Release Breaker", Tags = "Databinding", Estimate = 1.5, Assignee = "Steven walker", RankId = 6, Color = "#27AE60", AssigneeKey = "Steven" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 17", Title = "Task  - 29022", Status = "Close", Summary = "Analyze stored procedures.", Type = "Story", Priority = "Release Breaker", Tags = "Procedures", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 7, Color = "#8b447a", AssigneeKey = "Janet" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 18", Title = "Task  - 29023", Status = "Validate", Summary = "Validate editing issues.", Type = "Story", Priority = "Critical", Tags = "Editing", Estimate = 1, Assignee = "Nancy Davloio", RankId = 1, Color = "#8b447a", AssigneeKey = "Nancy" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 19", Title = "Task  - 29024", Status = "Review", Summary = "Test editing functionality.", Type = "Story", Priority = "Normal", Tags = "Editing,Test", Estimate = 0.5, Assignee = "Nancy Davloio", RankId = 5, Color = "#8b447a", AssigneeKey = "Nancy" });
            TaskDetails.Add(new KanbanDataModel { Id = "Task 20", Title = "Task  - 29025", Status = "Open", Summary = "Enhance editing functionality.", Type = "Improvement", Priority = "Low", Tags = "Editing", Estimate = 3.5, Assignee = "Andrew Fuller", RankId = 5, Color = "#7d7297", AssigneeKey = "Andrew" });
            return TaskDetails;
        }
    }
}
