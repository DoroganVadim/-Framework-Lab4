using Lab3.Models;

namespace Lab3.Factories
{
    public class CategoryFactory
    {
        private static Random random = new Random();

        public static Category CreateCategory(ICollection<Lab3.Models.Task> tasks = null)
        {
            return new Category
            {
                description = $"Description {random.Next(1, 1000)}",
                name = $"Category {random.Next(1, 1000)}",
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
        }
    }
}
