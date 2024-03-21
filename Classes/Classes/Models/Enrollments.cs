using System.ComponentModel.DataAnnotations.Schema;

namespace Classes.Models
{
    public class Enrollments
    {

        public Enrollments() { }
    }

    [ForeignKey(nameof(Class))]
    
    public int ClassFK { get; set; }
    public courses Class { get; set; }

}
