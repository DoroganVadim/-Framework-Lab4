using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Tag
    {
        [Key]
        public int id {  get; set; }
        public string name {  get; set; }
        public DateTime created_at {  get; set; }
        public DateTime updated_at { get; set; }

        public virtual ICollection<Lab3.Models.Task> tasks { get; set; }
    }
}
