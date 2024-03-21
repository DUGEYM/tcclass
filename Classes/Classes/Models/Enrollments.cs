using System.ComponentModel.DataAnnotations.Schema;

namespace courseunits.Models
{
    public class Enrollments
    {

        public Enrollments() { }
    }

    [ForeignKey(nameof(Class))]
    
    public int ClassFK { get; set; }
    public courses Class { get; set; }

}
