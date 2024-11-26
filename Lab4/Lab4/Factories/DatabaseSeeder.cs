using Lab3.DataLayer;
using Lab3.Models;

namespace Lab3.Factories
{
    public class DatabaseSeeder
    {
        private readonly TodoAppContext context;
        private static Random random = new Random();

        public DatabaseSeeder(TodoAppContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            SeedCategories();
            SeedTags();
            SeedTasks();
            context.SaveChanges();
        }

        private void SeedCategories()
        {
            if (!context.categories.Any())
            {
                var categories = new List<Category>();
                for (int i = 1; i <= 10; i++)
                {
                    categories.Add(CategoryFactory.CreateCategory());
                }
                context.categories.AddRange(categories);
                context.SaveChanges();
            }
        }

        private void SeedTags()
        {
            if (!context.tags.Any())
            {
                var tags = new List<Tag>();
                for (int i = 1; i <= 10; i++)
                {
                    tags.Add(TagFactory.CreateTag());
                }
                context.tags.AddRange(tags);
                context.SaveChanges();
            }
        }

        private void SeedTasks()
        {
            if (!context.tasks.Any())
            {
                var tasks = new List<Lab3.Models.Task>();
                for (int i = 1; i <= 10; i++)
                {
                    int n = random.Next(1, 3);
                    ICollection<Tag> tags = new List<Tag>();
                    for (int j = 0; j < n; j++)
                    {
                        int idtag = random.Next(1, context.tags.Count());
                        var randomtag = context.tags.Where(t => t.id == idtag).FirstOrDefault();
                        tags.Add(randomtag);
                    }
                    int idcat = random.Next(1, context.categories.Count());
                    var randomCategory = context.categories.Where(c => c.id == idcat).FirstOrDefault();
                    tasks.Add(TaskFactory.CreateTask(randomCategory, tags));
                }
                context.tasks.AddRange(tasks);
                context.SaveChanges();
            }
        }
    }
}
