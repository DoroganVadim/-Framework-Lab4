using Lab3.Models;

namespace Lab3.Factories
{
    public class TagFactory
    {
        private static Random random = new Random();

        public static Tag CreateTag(ICollection<Lab3.Models.Task> tasks = null)
        {
            return new Tag
            {
                name = $"Tag {random.Next(1, 1000)}",
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                tasks = tasks
            };
        }
    }
}
