using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace courseunits.Models

{
    public class Students
    {

        public DataSetDateTime EnrollmentDate { get; set; }

         

        

        //1-n
        [ForeignKey(nameof(Course))]

        public int CourseFk { get; set; }
        public courses Course { get; set; }
        //M-N

        public ICollection <Enrollments> ListOfEnrollments { get; set; }

    }
}
