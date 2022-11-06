namespace SecureApiStartersProject.Models
{
    public class TodoItem
    {
        public TodoItem(string id, string description)
        {
            Id = id;
            Description = description;
        }

        public TodoItem(string id, string description, bool completed)
        {
            Id = id;
            Description = description;
            Completed = completed;
        }
        public string Id { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
    }
}
