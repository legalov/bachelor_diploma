using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models.QA
{
    public class Question : Entity
    {
        [ForeignKey("Subtopic")]
        public int? SubtopicId { get; set; }
        public virtual Subtopic Subtopic { get; set; }
        public virtual ICollection<Intent> Intent { get; set; }
    }
}