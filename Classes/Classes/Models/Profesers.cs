namespace courseunits.Models
{
    public class Professers
    {


        public Professors()
        {
            ListOfClasses=new HashSet <Classes>
        }


    public ICollection<Classes > ListOfClasses { get; set; }
    }
}
