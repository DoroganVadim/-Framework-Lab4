using Lab3.Models;

namespace Lab3.Factories
{
    public class TaskFactory
    {
        private static Random random = new Random();

        public static Lab3.Models.Task CreateTask(Category category = null, ICollection<Tag> tags = null)
        {
            return new Lab3.Models.Task
            {
                title = $"Task {random.Next(1, 1000)}",
                category = category,
                description = $"Description {random.Next(1, 1000)}",
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                tags = tags
            };
        }
    }
}
