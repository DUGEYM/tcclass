using System.ComponentModel.DataAnnotations.Schema;

namespace courseunits.Models
{
    public class Classes
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int CurricularYear { get; set; }

        public int Semester{ get; set; }

        
        [ForeignKey(nameof (Course))]
        
        public int CourseFk { get; set; }
        public courses Course { get; set; }











    }
}
