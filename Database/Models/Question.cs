using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    public class Question : Entity
    {
        public bool isExample { get; set; }
        [Required, ForeignKey("Subtopic")]
        public int SubtopicId { get; set; }
        public virtual Subtopic Subtopic { get; set; }
        [Required, ForeignKey("Answer")]
        public int AnswerId { get; set; }
        public virtual Answer Answer { get; set; }
    }
}